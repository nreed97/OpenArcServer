using System.Net.Sockets;
using Microsoft.Extensions.Logging;
using OpenArcServer.Core;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Protocols.Arx;

/// <summary>
/// Handles a pure-ARx2 client connection where the very first bytes are [Arx2].
/// In practice the original AR-Cluster client always does a plain-text login first,
/// so this class is reserved for future or third-party ARx2-only clients.
/// Post-login ARx2 frame handling for mixed connections is done inside
/// TelnetClientConnection via IArxMessageProcessor.
/// </summary>
public sealed class ArxClientConnection
{
    private readonly TcpClient _client;
    private readonly IArxClientRegistry _arxRegistry;
    private readonly IArxMessageProcessor _processor;
    private readonly ILogger<ArxClientConnection> _log;

    public ArxClientConnection(
        TcpClient client,
        IArxClientRegistry arxRegistry,
        IArxMessageProcessor processor,
        ILogger<ArxClientConnection> log)
    {
        _client      = client;
        _arxRegistry = arxRegistry;
        _processor   = processor;
        _log         = log;
    }

    public async Task HandleAsync(CancellationToken ct)
    {
        var endpoint = _client.Client.RemoteEndPoint?.ToString() ?? "unknown";
        _log.LogInformation("ARx2-only connection from {Endpoint}", endpoint);

        var cts = CancellationTokenSource.CreateLinkedTokenSource(ct);
        var session = new UserSession
        {
            Callsign        = "UNKNOWN",
            RemoteEndpoint  = endpoint,
            ConnectType     = ConnectStateType.ArxClient,
            ConnectionState = ConnectionState.Connected,
        };

        var stream = _client.GetStream();
        session.SendAsync = async (data, token) =>
        {
            var bytes = ArxFrame.Wrap(data);
            await stream.WriteAsync(bytes, token);
        };
        session.DisconnectAsync = async () => await cts.CancelAsync();

        _arxRegistry.Add(session);

        try
        {
            var buffer = new byte[65536];
            var acc    = new List<byte>(65536);

            while (!cts.Token.IsCancellationRequested)
            {
                int n;
                try { n = await stream.ReadAsync(buffer, cts.Token); }
                catch { break; }
                if (n == 0) break;

                acc.AddRange(buffer[..n]);

                while (true)
                {
                    var span = acc.ToArray().AsSpan();
                    var xml  = ArxFrame.TryExtract(span, out int consumed);
                    if (xml is null) break;
                    acc.RemoveRange(0, consumed);
                    await _processor.ProcessAsync(session, xml, cts.Token);
                }
            }
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) when (!ct.IsCancellationRequested)
        {
            _log.LogWarning(ex, "ARx2 connection error from {Endpoint}", endpoint);
        }
        finally
        {
            _arxRegistry.Remove(session.SessionId);
            cts.Dispose();
            _client.Dispose();
        }
    }
}
