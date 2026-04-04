using System.Net.Sockets;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Protocols.Arx;

/// <summary>
/// Handles an AR-Cluster native (ARx2) client connection on port 3608.
///
/// Protocol (confirmed from Wireshark capture of K1TTT AR-Cluster Server):
///   1. Server → Client: AB5K_LoginRqst (server introduces itself as ArcNode)
///   2. Client → Server: AB5K_LoginResp (client provides callsign, Type=ArcUser)
///   3. Server → Client: AB5K_Client_Dx frames for each DX spot broadcast
///
/// The client only sends TCP ACKs after the initial login response.
/// Spot posting from the client happens on the separate telnet connection (port 7373).
/// </summary>
public sealed class ArxClientConnection
{
    private readonly TcpClient _client;
    private readonly IArxClientRegistry _arxRegistry;
    private readonly ServerOptions _serverOpts;
    private readonly ILogger<ArxClientConnection> _log;

    public ArxClientConnection(
        TcpClient client,
        IArxClientRegistry arxRegistry,
        IOptions<ServerOptions> serverOpts,
        ILogger<ArxClientConnection> log)
    {
        _client      = client;
        _arxRegistry = arxRegistry;
        _serverOpts  = serverOpts.Value;
        _log         = log;
    }

    public async Task HandleAsync(CancellationToken ct)
    {
        var endpoint = _client.Client.RemoteEndPoint?.ToString() ?? "?";
        _log.LogInformation("ARx2 client connecting from {Endpoint}", endpoint);

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

            // Step 2: read AB5K_LoginResp from client
            var callsign = await ReadLoginRespAsync(stream, ct);
            if (string.IsNullOrWhiteSpace(callsign))
            {
                _log.LogWarning("ARx2 client from {Endpoint} sent no valid login", endpoint);
                return;
            }

            _log.LogInformation("ARx2 client logged in: {Callsign} from {Endpoint}", callsign, endpoint);

            // Step 3: register session so MessageDistributor can push AB5K_Client_Dx frames
            session = new UserSession
            {
                Callsign       = callsign.ToUpperInvariant(),
                RemoteEndpoint = endpoint,
                ConnectType    = ConnectStateType.ArxClient,
                ConnectionState = ConnectionState.Connected,
            };
            session.SendAsync = async (data, token) =>
            {
                var bytes = ArxFrame.Wrap(data);
                await stream.WriteAsync(bytes, token);
            };
            _arxRegistry.Add(session);

            // Keep connection alive — read until disconnected.
            // Client sends only TCP ACKs after login; any data would be future ARx2 commands.
            var buf = new byte[4096];
            while (!ct.IsCancellationRequested)
            {
                int n = await stream.ReadAsync(buf, ct);
                if (n == 0) break; // client disconnected
                // Future: process any ARx2 frames the client sends (e.g. spot posting)
            }
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) when (ex is IOException or SocketException)
        {
            _log.LogDebug("ARx2 client {Endpoint} disconnected: {Msg}", endpoint, ex.Message);
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "ARx2 client {Endpoint} error", endpoint);
        }
        finally
        {
            if (session is not null)
            {
                _arxRegistry.Remove(session.SessionId);
                _log.LogInformation("ARx2 client disconnected: {Callsign} from {Endpoint}",
                    session.Callsign, endpoint);
            }
            _client.Dispose();
        }
    }

    /// <summary>
    /// Read bytes from the stream until a complete [Arx2]...[/Arx2] frame is received,
    /// parse it as AB5K_LoginResp, and return the client's callsign.
    /// </summary>
    private static async Task<string> ReadLoginRespAsync(NetworkStream stream, CancellationToken ct)
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
            if (xml is null) continue; // frame incomplete, read more

            try
            {
                var root = XElement.Parse(xml);
                if (root.Name.LocalName == "AB5K_LoginResp")
                    return root.Element("Call")?.Value?.Trim() ?? string.Empty;
            }
            catch { }

            // Got a frame but it wasn't AB5K_LoginResp — keep reading
            acc.Clear();
        }
        return string.Empty;
    }
}
