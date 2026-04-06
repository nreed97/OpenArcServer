using System.Net.Sockets;
using System.Xml.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Protocols.Arx;

/// <summary>
/// Maintains outbound connections to configured ARx2 peer nodes (AR-Cluster servers).
///
/// Handshake (connecting side):
///   1. Connect TCP to peer host:port
///   2. Receive AB5K_LoginRqst from peer (extracts their node callsign)
///   3. Send AB5K_LoginResp with our callsign and Type=ArcNode
///   4. Register session in IArxClientRegistry so MessageDistributor
///      pushes our spots to the peer as AB5K_Client_Dx frames
///   5. Read loop: parse incoming AB5K_Client_Dx frames via IArxMessageProcessor
///
/// Reconnects automatically with exponential backoff on disconnect.
/// </summary>
public sealed class ArxOutboundConnector : BackgroundService
{
    private readonly IOptionsMonitor<ArxServerOptions> _optsMon;
    private readonly IServiceProvider _services;
    private readonly ILogger<ArxOutboundConnector> _log;

    public ArxOutboundConnector(
        IOptionsMonitor<ArxServerOptions> optsMon,
        IServiceProvider services,
        ILogger<ArxOutboundConnector> log)
    {
        _optsMon  = optsMon;
        _services = services;
        _log      = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var initialPeers = _optsMon.CurrentValue.Peers;
        if (initialPeers.Count == 0)
        {
            _log.LogInformation("ARx outbound connector: no peers configured");
            return;
        }

        _log.LogInformation("ARx outbound connector starting for {Count} peer(s)", initialPeers.Count);

        // Spawn one long-running task per peer (keyed by host:port)
        var tasks = initialPeers.Select(peer => MaintainPeerAsync($"{peer.Host}:{peer.Port}", stoppingToken));
        await Task.WhenAll(tasks);
    }

    private async Task MaintainPeerAsync(string peerKey, CancellationToken ct)
    {
        var delay = TimeSpan.FromSeconds(5);

        while (!ct.IsCancellationRequested)
        {
            // Re-read live options each iteration so Enabled changes take effect immediately
            var opts = _optsMon.CurrentValue;
            var peer = opts.Peers.FirstOrDefault(p => $"{p.Host}:{p.Port}" == peerKey);

            if (peer is null)
            {
                // Peer was removed from config entirely — stop this task
                _log.LogInformation("ARx outbound: peer {Key} no longer in config, stopping", peerKey);
                return;
            }

            var label    = string.IsNullOrEmpty(peer.Label) ? peerKey : peer.Label;
            var maxDelay = TimeSpan.FromSeconds(opts.ReconnectDelaySeconds > 0 ? opts.ReconnectDelaySeconds : 300);

            if (!peer.Enabled)
            {
                // Disabled — wait a short interval then re-check
                await Task.Delay(TimeSpan.FromSeconds(10), ct).ConfigureAwait(false);
                continue;
            }

            _log.LogInformation("ARx outbound: connecting to {Peer}", label);
            try
            {
                using var client = new TcpClient(System.Net.Sockets.AddressFamily.InterNetwork);
                await client.ConnectAsync(peer.Host, peer.Port, ct);
                _log.LogInformation("ARx outbound: connected to {Peer}", label);
                delay = TimeSpan.FromSeconds(5); // reset backoff on success

                await HandlePeerAsync(client, label, ct);
            }
            catch (OperationCanceledException) { return; }
            catch (Exception ex)
            {
                _log.LogWarning("ARx outbound {Peer} error: {Message}", label, ex.Message);
            }

            if (ct.IsCancellationRequested) return;

            _log.LogInformation("ARx outbound: reconnecting to {Peer} in {Delay}s",
                label, (int)delay.TotalSeconds);
            await Task.Delay(delay, ct).ConfigureAwait(false);
            delay = delay * 2 < maxDelay ? delay * 2 : maxDelay;
        }
    }

    private async Task HandlePeerAsync(TcpClient client, string label, CancellationToken ct)
    {
        using var scope = _services.CreateScope();
        var sp = scope.ServiceProvider;

        var arxRegistry  = sp.GetRequiredService<IArxClientRegistry>();
        var arxProcessor = sp.GetRequiredService<IArxMessageProcessor>();
        var serverOpts   = sp.GetRequiredService<IOptions<ServerOptions>>().Value;

        var stream   = client.GetStream();
        var endpoint = client.Client.RemoteEndPoint?.ToString() ?? label;

        // Step 1: read AB5K_LoginRqst from peer
        var peerCallsign = await ReadLoginRqstAsync(stream, label, ct);
        if (string.IsNullOrEmpty(peerCallsign))
        {
            _log.LogWarning("ARx outbound {Peer}: no valid AB5K_LoginRqst received", label);
            return;
        }

        _log.LogInformation("ARx outbound {Peer}: peer identified as {Callsign}", label, peerCallsign);

        // Step 2: send AB5K_LoginResp — identify ourselves as a node
        var loginResp = ArxFrame.BuildXml("AB5K_LoginResp",
            ("Call", serverOpts.NodeCallsign),
            ("Type", "ArcNode"));
        await stream.WriteAsync(ArxFrame.Wrap(loginResp), ct);

        _log.LogInformation("ARx outbound {Peer}: sent AB5K_LoginResp as {OurCall}", label, serverOpts.NodeCallsign);

        // Step 3: register session so MessageDistributor pushes spots to this peer
        var session = new UserSession
        {
            Callsign        = peerCallsign,
            RemoteEndpoint  = endpoint,
            ConnectType     = ConnectStateType.ArxNode,
            ConnectionState = ConnectionState.Connected,
        };
        session.SendAsync = async (xml, token) =>
        {
            var bytes = ArxFrame.Wrap(xml);
            await stream.WriteAsync(bytes, token);
        };
        arxRegistry.Add(session);

        try
        {
            // Step 4: read loop — receive AB5K_Client_Dx frames from peer
            var acc = new List<byte>(4096);
            var buf = new byte[4096];

            while (!ct.IsCancellationRequested)
            {
                int n = await stream.ReadAsync(buf, ct);
                if (n == 0) break;

                acc.AddRange(buf.AsSpan(0, n).ToArray());

                while (true)
                {
                    var xml = ArxFrame.TryExtract(acc.ToArray().AsSpan(), out int consumed);
                    if (xml is null) break;
                    acc.RemoveRange(0, consumed);
                    await arxProcessor.ProcessAsync(session, xml, ct);
                }
            }
        }
        finally
        {
            arxRegistry.Remove(session.SessionId);
            _log.LogInformation("ARx outbound {Peer} ({Callsign}) disconnected", label, peerCallsign);
        }
    }

    /// <summary>
    /// Read from the stream until a complete [Arx2] frame is received that contains
    /// AB5K_LoginRqst. Returns the peer's node callsign, or empty on timeout/error.
    /// </summary>
    private async Task<string> ReadLoginRqstAsync(
        NetworkStream stream, string label, CancellationToken ct)
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(ct);
        cts.CancelAfter(TimeSpan.FromSeconds(15));

        var acc = new List<byte>(512);
        var buf = new byte[256];

        try
        {
            while (!cts.Token.IsCancellationRequested)
            {
                int n = await stream.ReadAsync(buf, cts.Token);
                if (n == 0) break;
                acc.AddRange(buf.AsSpan(0, n).ToArray());

                var xml = ArxFrame.TryExtract(acc.ToArray().AsSpan(), out _);
                if (xml is null) continue;

                try
                {
                    var root = XElement.Parse(xml);
                    if (root.Name.LocalName == "AB5K_LoginRqst")
                        return root.Element("Call")?.Value?.Trim().ToUpperInvariant() ?? string.Empty;
                }
                catch { }

                // Got a frame but not AB5K_LoginRqst — clear and keep reading
                acc.Clear();
            }
        }
        catch (OperationCanceledException)
        {
            _log.LogWarning("ARx outbound {Peer}: timed out waiting for AB5K_LoginRqst", label);
        }

        return string.Empty;
    }
}
