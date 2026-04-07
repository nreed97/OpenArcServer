using System.Net.Sockets;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Protocols.Arx;

/// <summary>
/// Handles an AR-Cluster native (ARx2) client connection on port 3608.
///
/// Protocol (confirmed from Wireshark capture of K1TTT AR-Cluster Server):
///   1. Server → Client: AB5K_LoginRqst (server introduces itself as ArcNode)
///   2. Client → Server: AB5K_LoginResp (client provides callsign; Type=ArcUser or ArcNode)
///   3. Server → Client: AB5K_Client_Dx frames for each DX spot broadcast
///
/// Type=ArcNode means the connecting client is a peer AR-Cluster node — it is
/// registered in INodeManager (shows in SH/N and /api/nodes) and NOT in
/// IConnectionManager (so it doesn't appear in the user list).
///
/// Type=ArcUser (or any other value) means an end-user AR-Cluster client —
/// registered in IConnectionManager so it shows in SH/U and /api/users.
/// </summary>
public sealed class ArxClientConnection
{
    private readonly TcpClient _client;
    private readonly IArxClientRegistry _arxRegistry;
    private readonly IConnectionManager _connections;
    private readonly INodeManager _nodes;
    private readonly IArxMessageProcessor _arxProcessor;
    private readonly ServerOptions _serverOpts;
    private readonly ILogger<ArxClientConnection> _log;

    public ArxClientConnection(
        TcpClient client,
        IArxClientRegistry arxRegistry,
        IConnectionManager connections,
        INodeManager nodes,
        IArxMessageProcessor arxProcessor,
        IOptions<ServerOptions> serverOpts,
        ILogger<ArxClientConnection> log)
    {
        _client       = client;
        _arxRegistry  = arxRegistry;
        _connections  = connections;
        _nodes        = nodes;
        _arxProcessor = arxProcessor;
        _serverOpts   = serverOpts.Value;
        _log          = log;
    }

    public async Task HandleAsync(CancellationToken ct)
    {
        var endpoint = _client.Client.RemoteEndPoint?.ToString() ?? "?";
        _log.LogInformation("ARx2 inbound connection from {Endpoint}", endpoint);

        UserSession? session = null;
        try
        {
            using var stream = _client.GetStream();

            // Step 1: send AB5K_LoginRqst — server identifies itself
            var loginRqst = ArxFrame.BuildXml("AB5K_LoginRqst",
                ("Call",    _serverOpts.NodeCallsign),
                ("Message", "Connection Registered"),
                ("Type",    "ArcNode"));
            await stream.WriteAsync(ArxFrame.Wrap(loginRqst), ct);

            // Step 2: read AB5K_LoginResp from client — extract callsign AND type
            var (callsign, loginType) = await ReadLoginRespAsync(stream, ct);
            if (string.IsNullOrWhiteSpace(callsign))
            {
                _log.LogWarning("ARx2 inbound from {Endpoint}: no valid AB5K_LoginResp received", endpoint);
                return;
            }

            // Type=ArcNode → peer cluster node; anything else → end-user client
            var isNode = string.Equals(loginType, "ArcNode", StringComparison.OrdinalIgnoreCase);

            _log.LogInformation("ARx2 inbound: {Callsign} from {Endpoint} (Type={Type})",
                callsign.ToUpperInvariant(), endpoint, loginType);

            // Step 3: create session and register appropriately
            session = new UserSession
            {
                Callsign        = callsign.ToUpperInvariant(),
                RemoteEndpoint  = endpoint,
                ConnectType     = isNode ? ConnectStateType.ArxNode : ConnectStateType.ArxClient,
                ConnectionState = ConnectionState.Connected,
            };
            session.SendAsync = async (data, token) =>
            {
                var bytes = ArxFrame.Wrap(data);
                await stream.WriteAsync(bytes, token);
            };

            _arxRegistry.Add(session);

            if (isNode)
            {
                // Peer node — register in node list (SH/N and /api/nodes)
                var nodeRecord = new NodeRecord
                {
                    Callsign          = session.Callsign,
                    Software          = "AR-Cluster",
                    Version           = "ARx2",
                    RemoteEndpoint    = endpoint,
                    HandshakeComplete = true,
                };
                _nodes.AddNode(nodeRecord, session);
            }
            else
            {
                // End-user — register in connection manager (SH/U and /api/users)
                _connections.AddSession(session);
            }

            // Read any ARx2 frames sent by the client after login
            // (e.g. AB5K_Client_DxSpot spot posting frames).
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
                    await _arxProcessor.ProcessAsync(session, xml, ct);
                }
            }
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) when (ex is IOException or SocketException)
        {
            _log.LogDebug("ARx2 inbound {Endpoint} disconnected: {Msg}", endpoint, ex.Message);
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "ARx2 inbound {Endpoint} error", endpoint);
        }
        finally
        {
            if (session is not null)
            {
                _arxRegistry.Remove(session.SessionId);
                if (session.ConnectType == ConnectStateType.ArxNode)
                    _nodes.RemoveNode(session.Callsign);
                else
                    _connections.RemoveSession(session.SessionId);

                _log.LogInformation("ARx2 inbound disconnected: {Callsign} from {Endpoint}",
                    session.Callsign, endpoint);
            }
            _client.Dispose();
        }
    }

    /// <summary>
    /// Read until a complete AB5K_LoginResp frame arrives.
    /// Returns the client's callsign and Type field (e.g. "ArcUser" or "ArcNode").
    /// </summary>
    private static async Task<(string Callsign, string Type)> ReadLoginRespAsync(
        NetworkStream stream, CancellationToken ct)
    {
        using var cts = CancellationTokenSource.CreateLinkedTokenSource(ct);
        cts.CancelAfter(TimeSpan.FromSeconds(15));

        var acc = new List<byte>(512);
        var buf = new byte[256];

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
                if (root.Name.LocalName == "AB5K_LoginResp")
                {
                    var call = root.Element("Call")?.Value?.Trim() ?? string.Empty;
                    var type = root.Element("Type")?.Value?.Trim() ?? string.Empty;
                    return (call, type);
                }
            }
            catch { }

            acc.Clear();
        }
        return (string.Empty, string.Empty);
    }
}
