using System.Net.Sockets;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using OpenArcServer.Engine.Spots;
using Prometheus;

namespace OpenArcServer.Protocols.Pcxx;

public sealed class PcxxClientConnection
{
    private static readonly Counter DxSpotsTotal = Metrics.CreateCounter(
        "openarcserver_dx_spots_total",
        "Total DX spots received",
        new CounterConfiguration { LabelNames = new[] { "source" } });
    private readonly TcpClient _client;
    private readonly INodeManager _nodes;
    private readonly IConnectionManager _connections;
    private readonly IMessageDistributor _distributor;
    private readonly IDxSpotRepository _spots;
    private readonly ICtyLookup _cty;
    private readonly IBandModeLookup _bandMode;
    private readonly DuplicateSpotDetector _dupeDetector;
    private readonly ServerOptions _serverOpts;
    private readonly PcxxOptions _opts;
    private readonly ILogger<PcxxClientConnection> _log;
    private readonly bool _isOutbound;

    private static readonly Encoding _enc = Encoding.UTF8;

    public PcxxClientConnection(
        TcpClient client,
        INodeManager nodes,
        IConnectionManager connections,
        IMessageDistributor distributor,
        IDxSpotRepository spots,
        ICtyLookup cty,
        IBandModeLookup bandMode,
        DuplicateSpotDetector dupeDetector,
        IOptions<ServerOptions> serverOpts,
        IOptions<PcxxOptions> opts,
        ILogger<PcxxClientConnection> log,
        bool isOutbound = false)
    {
        _client = client;
        _nodes = nodes;
        _connections = connections;
        _distributor = distributor;
        _spots = spots;
        _cty = cty;
        _bandMode = bandMode;
        _dupeDetector = dupeDetector;
        _serverOpts = serverOpts.Value;
        _opts = opts.Value;
        _log = log;
        _isOutbound = isOutbound;
    }

    public async Task HandleAsync(CancellationToken ct)
    {
        var endpoint = _client.Client.RemoteEndPoint?.ToString() ?? "unknown";
        _log.LogInformation("PCxx {Direction} connection {Endpoint}",
            _isOutbound ? "outbound to" : "inbound from", endpoint);

        var cts = CancellationTokenSource.CreateLinkedTokenSource(ct);
        var session = new UserSession
        {
            RemoteEndpoint = endpoint,
            ConnectType = ConnectStateType.PcxxNode,
            ConnectionState = ConnectionState.Idle,
        };

        var stream = _client.GetStream();

        session.SendAsync = async (text, token) =>
        {
            var bytes = _enc.GetBytes(text);
            await stream.WriteAsync(bytes, token);
        };
        session.DisconnectAsync = async () => await cts.CancelAsync();

        try
        {
            if (_isOutbound)
            {
                // Outbound: wait for peer to send PC18 first, then we respond PC38
                session.ConnectionState = ConnectionState.CallsignRequest;
            }
            else
            {
                // Inbound: we initiate handshake with PC18
                var pc18 = PcxxMessage.Pc18(_serverOpts.NodeCallsign);
                await session.SendAsync(pc18, cts.Token);
                session.ConnectionState = ConnectionState.CallsignRequest;

                if (_opts.LogOutboundNodeUser)
                    _log.LogInformation("PCxx TX → {Endpoint}: {Msg}", endpoint, pc18.TrimEnd());
            }

            await ReadLoopAsync(stream, session, cts.Token);
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) when (!ct.IsCancellationRequested)
        {
            _log.LogWarning(ex, "PCxx connection error from {Endpoint}", endpoint);
        }
        finally
        {
            if (!string.IsNullOrEmpty(session.Callsign))
            {
                _nodes.RemoveNode(session.Callsign);
                _connections.RemoveSession(session.SessionId);

                // Broadcast PC21 (node deleted) to remaining nodes
                var pc21 = PcxxMessage.Pc21(session.Callsign, _serverOpts.NodeCallsign);
                await BroadcastToNodesAsync(pc21, session.Callsign, ct);

                _log.LogInformation("PCxx node {Callsign} disconnected", session.Callsign);
            }
            cts.Dispose();
            _client.Dispose();
        }
    }

    private async Task ReadLoopAsync(NetworkStream stream, UserSession session, CancellationToken ct)
    {
        var buffer = new byte[8192];
        var partial = new StringBuilder();

        while (!ct.IsCancellationRequested)
        {
            int n;
            try
            {
                n = await stream.ReadAsync(buffer, ct);
            }
            catch
            {
                break;
            }

            if (n == 0) break;

            partial.Append(_enc.GetString(buffer, 0, n));
            var text = partial.ToString();
            partial.Clear();

            // Process complete lines (terminated by \n)
            int start = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    var line = text[start..i].TrimEnd('\r');
                    start = i + 1;
                    if (!string.IsNullOrWhiteSpace(line))
                        await ProcessMessageAsync(session, line, ct);
                }
            }

            // Keep any partial line for next iteration
            if (start < text.Length)
                partial.Append(text[start..]);
        }
    }

    private async Task ProcessMessageAsync(UserSession session, string raw, CancellationToken ct)
    {
        session.LastActivityAt = DateTime.UtcNow;
        var fields = PcxxMessage.Split(raw);
        var msgNum = PcxxMessage.GetMessageNumber(fields);

        _log.LogDebug("PCxx RX ← {Node}: {Msg}", session.Callsign.Or(session.RemoteEndpoint), raw);

        switch (msgNum)
        {
            case 18: await HandlePc18Async(session, fields, ct); break; // outbound: peer sends PC18 to us
            case 38: await HandlePc38Async(session, fields, ct); break; // inbound: peer responds PC38
            case 11: await HandlePc11Async(session, fields, ct); break;
            case 12: await HandlePc12Async(session, fields, ct); break;
            case 16: HandlePc16(session, fields); break;
            case 17: HandlePc17(session, fields); break;
            case 19: await HandlePc19Async(session, fields, ct); break;
            case 20: HandlePc20(session, fields); break;
            case 21: HandlePc21(session, fields); break;
            case 22: HandlePc22(session, fields); break;
            case 51: await HandlePc51Async(session, fields, ct); break;
            default:
                _log.LogDebug("PCxx unhandled PC{Num} from {Node}", msgNum, session.Callsign);
                break;
        }
    }

    // ── PC18 — Init Request (outbound: peer sends this to us after we connect) ─
    private async Task HandlePc18Async(UserSession session, string[] fields, CancellationToken ct)
    {
        if (!_isOutbound) return; // inbound connections don't receive PC18

        // PC18^node_call^  — peer is telling us their callsign
        var nodeCall = (fields.ElementAtOrDefault(1) ?? string.Empty).ToUpperInvariant().Trim();
        if (string.IsNullOrEmpty(nodeCall))
            nodeCall = session.RemoteEndpoint;

        // Respond with PC38 (our software name, our callsign, our version)
        var pc38 = PcxxMessage.Pc38("OpenArcServer", _serverOpts.NodeCallsign, _serverOpts.Version);
        await session.SendAsync(pc38, ct);

        // Register the node now (handshake finishes when we receive PC22 from them)
        session.Callsign = nodeCall;
        session.ConnectionState = ConnectionState.Connected;

        var node = new NodeRecord
        {
            Callsign = nodeCall,
            Software = "PCxx",
            Version = string.Empty,
            Port = _opts.Port,
            RemoteEndpoint = session.RemoteEndpoint,
        };

        _nodes.AddNode(node, session);
        _connections.AddSession(session);
        _log.LogInformation("PCxx outbound: received PC18 from {Callsign}, sent PC38", nodeCall);
    }

    // ── PC38 — Init Start (inbound: response to our PC18) ─────────────────
    private async Task HandlePc38Async(UserSession session, string[] fields, CancellationToken ct)
    {
        // PC38^software^node_call^version^
        var software = fields.ElementAtOrDefault(1) ?? string.Empty;
        var nodeCall = (fields.ElementAtOrDefault(2) ?? string.Empty).ToUpperInvariant().Trim();
        var version = fields.ElementAtOrDefault(3) ?? string.Empty;

        if (string.IsNullOrEmpty(nodeCall))
        {
            _log.LogWarning("PCxx PC38 missing node callsign from {Endpoint}", session.RemoteEndpoint);
            return;
        }

        session.Callsign = nodeCall;
        session.ConnectionState = ConnectionState.Connected;

        var node = new NodeRecord
        {
            Callsign = nodeCall,
            Software = software,
            Version = version,
            Port = _opts.Port,
            RemoteEndpoint = session.RemoteEndpoint,
        };

        _nodes.AddNode(node, session);
        _connections.AddSession(session);
        _log.LogInformation("PCxx node {Callsign} ({Software} {Version}) connected", nodeCall, software, version);

        if (!_opts.IgnoreNodeUserProtocol)
        {
            // Send our node list (PC19) then turnaround (PC20) then complete (PC22)
            await SendNodeListAsync(session, ct);
        }

        // Send PC20 turnaround
        var pc20 = PcxxMessage.Pc20(_serverOpts.NodeCallsign);
        await session.SendAsync(pc20, ct);

        // Send PC22 init complete
        var pc22 = PcxxMessage.Pc22(_serverOpts.NodeCallsign);
        await session.SendAsync(pc22, ct);

        node.HandshakeComplete = true;

        if (_opts.LogOutboundNodeUser)
            _log.LogInformation("PCxx handshake complete with {Callsign}", nodeCall);

        // Announce this node to all other connected nodes via PC19
        if (!_opts.IgnoreNodeUserProtocol)
        {
            var pc19 = PcxxMessage.Pc19(
                new[] { (nodeCall, _opts.Port, version) },
                _serverOpts.NodeCallsign);
            await BroadcastToNodesAsync(pc19, nodeCall, ct);
        }

        // Tell the new node about all currently connected telnet users via PC16
        foreach (var user in _connections.GetConnectedUsers())
        {
            if (string.IsNullOrEmpty(user.Callsign)) continue;
            var pc16 = PcxxMessage.Pc16(user.Callsign, _serverOpts.NodeCallsign);
            await session.SendAsync(pc16, ct);
        }
    }

    private async Task SendNodeListAsync(UserSession session, CancellationToken ct)
    {
        var knownNodes = _nodes.GetConnectedNodes()
            .Where(n => n.HandshakeComplete)
            .Select(n => (n.Callsign, n.Port, n.Version))
            .ToList();

        // Always include ourselves
        knownNodes.Insert(0, (_serverOpts.NodeCallsign, _opts.Port, _serverOpts.Version));

        if (knownNodes.Count > 0)
        {
            var pc19 = PcxxMessage.Pc19(knownNodes, _serverOpts.NodeCallsign);
            await session.SendAsync(pc19, ct);
            if (_opts.LogOutboundNodeUser)
                _log.LogInformation("PCxx TX PC19 ({Count} nodes) → {Node}", knownNodes.Count, session.Callsign);
        }
    }

    // ── PC11 — DX Spot ─────────────────────────────────────────────────────
    private async Task HandlePc11Async(UserSession session, string[] fields, CancellationToken ct)
    {
        // PC11^freq^dx_call^comment^date^time^spotter^node^
        if (fields.Length < 7) return;

        if (!float.TryParse(fields[1], System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out var freq))
            return;

        var dxCall = fields[2].ToUpperInvariant().Trim();
        var comment = fields[3].Trim();
        var spotter = fields[6].ToUpperInvariant().Trim();
        var originNode = fields.ElementAtOrDefault(7)?.Trim() ?? session.Callsign;

        if (string.IsNullOrEmpty(dxCall) || string.IsNullOrEmpty(spotter)) return;

        var bandMode = _bandMode.LookupFrequency(freq);
        var band = bandMode?.Band ?? 0f;
        var mode = bandMode?.Mode ?? string.Empty;
        var calledCty = _cty.LookupCallsign(dxCall);
        var spotterCty = _cty.LookupCallsign(spotter);

        bool isDupe = band > 0f && _dupeDetector.IsDuplicate(dxCall,
            band.ToString(System.Globalization.CultureInfo.InvariantCulture));

        var now = DateTime.UtcNow;
        var spot = new DxSpot
        {
            Call = dxCall,
            Spotter = spotter,
            SpotterNode = originNode,
            Freq = freq,
            Band = band,
            Mode = mode,
            Comment = comment.Length > 30 ? comment[..30] : comment,
            Cty = calledCty?.CtyCode ?? string.Empty,
            SpotterCty = spotterCty?.CtyCode ?? string.Empty,
            Cont = calledCty?.Continent ?? string.Empty,
            SpotterCont = spotterCty?.Continent ?? string.Empty,
            CqZone = (byte)(calledCty?.CqZone ?? 0),
            ItuZone = (byte)(calledCty?.ItuZone ?? 0),
            SpotterCqZone = (byte)(spotterCty?.CqZone ?? 0),
            SpotterItuZone = (byte)(spotterCty?.ItuZone ?? 0),
            DupeKey = $"{dxCall}|{band}",
            IsDupe = isDupe,
            Timestamp = now,
            ReceivedAt = now,
        };

        await _spots.InsertAsync(spot, ct);
        DxSpotsTotal.WithLabels("pcxx").Inc();

        if (!isDupe)
        {
            // Distribute formatted spot to all connected telnet users
            var formatted = DxSpotFormatter.Format(spot);
            var response = new Core.Commands.CommandResponse
            {
                DistroType = DistroType.ToUsers,
                MsgType = MsgType.Dx,
            };
            response.Messages.Add(formatted);
            await _distributor.DistributeAsync(response, session, ct);

            // Forward PC11 to all other connected nodes (flood-fill, skip origin)
            var pc11 = PcxxMessage.Pc11(freq, dxCall, spot.Comment, now, spotter, originNode);
            await BroadcastToNodesAsync(pc11, originNode, ct);
        }

        _log.LogInformation("PCxx PC11: {Spotter}@{Node} → {Call} @ {Freq} kHz", spotter, originNode, dxCall, freq);
    }

    // ── PC12 — Announcement ────────────────────────────────────────────────
    private async Task HandlePc12Async(UserSession session, string[] fields, CancellationToken ct)
    {
        // PC12^from^to^message^origin^node^
        if (fields.Length < 4) return;

        var from = fields[1].Trim();
        var message = fields[3].Trim();

        if (string.IsNullOrEmpty(message)) return;

        var formatted = $"\n*** {from} announces: {message}";
        var response = new Core.Commands.CommandResponse
        {
            DistroType = DistroType.ToUsers,
            MsgType = MsgType.Ann,
        };
        response.Messages.Add(formatted);
        await _distributor.DistributeAsync(response, session, ct);

        // Forward to other nodes
        var pc12 = string.Join("^", fields) + "^" + PcxxMessage.LineEnding;
        await BroadcastToNodesAsync(pc12, fields.ElementAtOrDefault(5)?.Trim() ?? session.Callsign, ct);
    }

    // ── PC16 — Add User ────────────────────────────────────────────────────
    private void HandlePc16(UserSession session, string[] fields)
    {
        if (_opts.IgnoreNodeUserProtocol) return;
        // PC16^call^node^flags^ip^  — we just log it for now
        var call = fields.ElementAtOrDefault(1)?.Trim() ?? string.Empty;
        var node = fields.ElementAtOrDefault(2)?.Trim() ?? string.Empty;
        _log.LogDebug("PCxx PC16: user {Call} connected to {Node}", call, node);
    }

    // ── PC17 — Delete User ─────────────────────────────────────────────────
    private void HandlePc17(UserSession session, string[] fields)
    {
        if (_opts.IgnoreNodeUserProtocol) return;
        var call = fields.ElementAtOrDefault(1)?.Trim() ?? string.Empty;
        var node = fields.ElementAtOrDefault(2)?.Trim() ?? string.Empty;
        _log.LogDebug("PCxx PC17: user {Call} disconnected from {Node}", call, node);
    }

    // ── PC19 — Add Nodes ───────────────────────────────────────────────────
    private async Task HandlePc19Async(UserSession session, string[] fields, CancellationToken ct)
    {
        if (_opts.IgnoreNodeUserProtocol) return;

        // Forward to all other nodes
        var raw = string.Join("^", fields) + "^" + PcxxMessage.LineEnding;
        await BroadcastToNodesAsync(raw, session.Callsign, ct);

        _log.LogDebug("PCxx PC19 forwarded from {Node}", session.Callsign);
    }

    // ── PC20 — Init Turnaround ─────────────────────────────────────────────
    private void HandlePc20(UserSession session, string[] fields)
    {
        // Peer signals end of their node list; no action needed, just log
        _log.LogDebug("PCxx PC20 turnaround from {Node}", session.Callsign);
    }

    // ── PC22 — Init Complete ───────────────────────────────────────────────
    private void HandlePc22(UserSession session, string[] fields)
    {
        // Handshake complete (outbound path: peer sent PC19/PC20/PC22 to us)
        var node = _nodes.FindNode(session.Callsign);
        if (node is not null)
        {
            node.HandshakeComplete = true;
            _log.LogInformation("PCxx outbound handshake complete with {Callsign}", session.Callsign);
        }
    }

    // ── PC21 — Delete Node ─────────────────────────────────────────────────
    private void HandlePc21(UserSession session, string[] fields)
    {
        if (_opts.IgnoreNodeUserProtocol) return;
        var nodeCall = fields.ElementAtOrDefault(1)?.Trim() ?? string.Empty;
        if (!string.IsNullOrEmpty(nodeCall))
        {
            _nodes.RemoveNode(nodeCall);
            _log.LogInformation("PCxx PC21: node {Node} removed from topology", nodeCall);
        }
    }

    // ── PC51 — Ping ────────────────────────────────────────────────────────
    private async Task HandlePc51Async(UserSession session, string[] fields, CancellationToken ct)
    {
        // PC51^target^sequence^origin^
        // If we are the target, respond; otherwise forward
        var target = fields.ElementAtOrDefault(1)?.Trim() ?? string.Empty;
        var sequence = fields.ElementAtOrDefault(2)?.Trim() ?? string.Empty;
        var origin = fields.ElementAtOrDefault(3)?.Trim() ?? session.Callsign;

        session.LastActivityAt = DateTime.UtcNow;
        if (_nodes.FindNode(session.Callsign) is { } node)
            node.LastSeenAt = DateTime.UtcNow;

        if (string.Equals(target, _serverOpts.NodeCallsign, StringComparison.OrdinalIgnoreCase))
        {
            // Respond with the same sequence, swapping origin/target
            var pong = PcxxMessage.Pc51(origin, sequence, _serverOpts.NodeCallsign);
            await session.SendAsync(pong, ct);
        }
        else
        {
            // Forward to target if we know it
            var targetSession = _nodes.GetSession(target);
            if (targetSession?.SendAsync is not null)
            {
                var fwd = string.Join("^", fields) + "^" + PcxxMessage.LineEnding;
                await targetSession.SendAsync(fwd, ct);
            }
        }
    }

    // ── Helpers ────────────────────────────────────────────────────────────

    /// <summary>Send a raw message to all connected nodes except the one that originated it.</summary>
    private async Task BroadcastToNodesAsync(string message, string excludeCallsign, CancellationToken ct)
    {
        var tasks = _nodes.GetConnectedNodes()
            .Where(n => !string.Equals(n.Callsign, excludeCallsign, StringComparison.OrdinalIgnoreCase)
                        && n.HandshakeComplete)
            .Select(n => _nodes.GetSession(n.Callsign))
            .Where(s => s?.SendAsync is not null)
            .Select(s => s!.SendAsync!(message, ct));

        await Task.WhenAll(tasks);
    }
}

internal static class StringExtensions
{
    public static string Or(this string? value, string fallback) =>
        string.IsNullOrEmpty(value) ? fallback : value;
}
