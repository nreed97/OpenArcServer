using System.Net.Sockets;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using OpenArcServer.Engine.Spots;
using IArxClientRegistry = OpenArcServer.Core.Services.IArxClientRegistry;

namespace OpenArcServer.Protocols.Arx;

/// <summary>
/// Handles a single ARx2 client connection (AR-Cluster native client protocol).
///
/// Wire format per message: [Arx2]{zlib-compressed UTF-8 XML}[/Arx2]
///
/// Known client → server message types:
///   AB5K_Client_DxSpot   — post a DX spot
///   AB5K_Client_LogIn    — login with callsign  (ASSUMED — confirm via capture)
///
/// Known server → client message types:
///   AB5K_Server_LogIn    — login response       (ASSUMED — confirm via capture)
///   AB5K_Server_DxSpot   — broadcast DX spot    (ASSUMED — confirm via capture)
///   AB5K_Server_Msg      — plain text message   (ASSUMED — confirm via capture)
/// </summary>
public sealed class ArxClientConnection
{
    private readonly TcpClient _client;
    private readonly IConnectionManager _connections;
    private readonly IArxClientRegistry _arxRegistry;
    private readonly IMessageDistributor _distributor;
    private readonly IDxSpotRepository _spots;
    private readonly ICtyLookup _cty;
    private readonly IBandModeLookup _bandMode;
    private readonly DuplicateSpotDetector _dupeDetector;
    private readonly ServerOptions _serverOpts;
    private readonly SpotProcessingOptions _spotOpts;
    private readonly ILogger<ArxClientConnection> _log;

    public ArxClientConnection(
        TcpClient client,
        IConnectionManager connections,
        IArxClientRegistry arxRegistry,
        IMessageDistributor distributor,
        IDxSpotRepository spots,
        ICtyLookup cty,
        IBandModeLookup bandMode,
        DuplicateSpotDetector dupeDetector,
        IOptions<ServerOptions> serverOpts,
        IOptions<SpotProcessingOptions> spotOpts,
        ILogger<ArxClientConnection> log)
    {
        _client  = client;
        _connections = connections;
        _arxRegistry = arxRegistry;
        _distributor = distributor;
        _spots   = spots;
        _cty     = cty;
        _bandMode = bandMode;
        _dupeDetector = dupeDetector;
        _serverOpts = serverOpts.Value;
        _spotOpts   = spotOpts.Value;
        _log = log;
    }

    public async Task HandleAsync(CancellationToken ct)
    {
        var endpoint = _client.Client.RemoteEndPoint?.ToString() ?? "unknown";
        _log.LogInformation("ARx2 connection from {Endpoint}", endpoint);

        var cts = CancellationTokenSource.CreateLinkedTokenSource(ct);
        var session = new UserSession
        {
            RemoteEndpoint = endpoint,
            ConnectType    = ConnectStateType.ArxClient,
            ConnectionState = ConnectionState.Idle,
        };

        var stream = _client.GetStream();
        session.SendAsync = async (data, token) =>
        {
            var bytes = ArxFrame.Wrap(data);
            await stream.WriteAsync(bytes, token);
        };
        session.DisconnectAsync = async () => await cts.CancelAsync();

        try
        {
            await ReadLoopAsync(stream, session, cts.Token);
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) when (!ct.IsCancellationRequested)
        {
            _log.LogWarning(ex, "ARx2 connection error from {Endpoint}", endpoint);
        }
        finally
        {
            _arxRegistry.Remove(session.SessionId);
            if (!string.IsNullOrEmpty(session.Callsign))
            {
                _connections.RemoveSession(session.SessionId);
                _log.LogInformation("ARx2 client {Callsign} disconnected", session.Callsign);
            }
            cts.Dispose();
            _client.Dispose();
        }
    }

    // ── Read loop ─────────────────────────────────────────────────────────

    private async Task ReadLoopAsync(NetworkStream stream, UserSession session, CancellationToken ct)
    {
        var buffer = new byte[65536];
        var acc    = new List<byte>(65536);

        while (!ct.IsCancellationRequested)
        {
            int n;
            try { n = await stream.ReadAsync(buffer, ct); }
            catch { break; }
            if (n == 0) break;

            acc.AddRange(buffer[..n]);

            // Extract all complete frames from the accumulation buffer
            while (true)
            {
                var span = acc.ToArray().AsSpan();
                var xml  = ArxFrame.TryExtract(span, out int consumed);
                if (xml is null) break;

                acc.RemoveRange(0, consumed);
                await ProcessMessageAsync(session, xml, ct);
            }
        }
    }

    // ── Dispatch ──────────────────────────────────────────────────────────

    private async Task ProcessMessageAsync(UserSession session, string xml, CancellationToken ct)
    {
        var msgType = ArxFrame.GetMessageType(xml);
        _log.LogDebug("ARx2 RX ← {Endpoint} [{Type}]: {Xml}",
            session.Callsign.Or(session.RemoteEndpoint), msgType, xml);

        switch (msgType)
        {
            case "AB5K_Client_LogIn":
            case "AB5K_Client_Login":
                await HandleLoginAsync(session, xml, ct);
                break;

            case "AB5K_Client_DxSpot":
                await HandleDxSpotAsync(session, xml, ct);
                break;

            default:
                // Log the full XML so unknown messages can be identified and added
                _log.LogInformation("ARx2 UNKNOWN message type [{Type}] from {Endpoint}: {Xml}",
                    msgType ?? "(null)", session.RemoteEndpoint, xml);
                break;
        }
    }

    // ── Login ─────────────────────────────────────────────────────────────

    private async Task HandleLoginAsync(UserSession session, string xml, CancellationToken ct)
    {
        XElement root;
        try { root = XElement.Parse(xml); }
        catch { return; }

        // Try common field name variants
        var callsign = (root.Element("Call")
                     ?? root.Element("Callsign")
                     ?? root.Element("call")
                     ?? root.Element("callsign"))?.Value?.Trim().ToUpperInvariant();

        if (string.IsNullOrEmpty(callsign))
        {
            _log.LogWarning("ARx2 login missing callsign from {Endpoint}: {Xml}", session.RemoteEndpoint, xml);
            await session.SendAsync!(ArxFrame.BuildXml("AB5K_Server_LogIn",
                ("Success", "false"),
                ("Msg", "Missing callsign")), ct);
            return;
        }

        session.Callsign = callsign;
        session.ConnectionState = ConnectionState.Connected;
        _connections.AddSession(session);
        _arxRegistry.Add(session);

        _log.LogInformation("ARx2 login: {Callsign} from {Endpoint}", callsign, session.RemoteEndpoint);

        // Send login response
        var welcome = _serverOpts.ServerName;
        await session.SendAsync!(ArxFrame.BuildXml("AB5K_Server_LogIn",
            ("Success", "true"),
            ("Msg", $"Hello {callsign}, welcome to {_serverOpts.NodeCallsign}")), ct);
    }

    // ── DX Spot ───────────────────────────────────────────────────────────

    private async Task HandleDxSpotAsync(UserSession session, string xml, CancellationToken ct)
    {
        if (session.ConnectionState != ConnectionState.Connected)
        {
            _log.LogWarning("ARx2 DxSpot from unauthenticated client {Endpoint}", session.RemoteEndpoint);
            return;
        }

        XElement root;
        try { root = XElement.Parse(xml); }
        catch { return; }

        var call    = root.Element("Call")?.Value?.Trim().ToUpperInvariant() ?? string.Empty;
        var freqStr = root.Element("Freq")?.Value?.Trim() ?? string.Empty;
        var comment = root.Element("Comment")?.Value?.Trim() ?? string.Empty;
        var spotter = root.Element("Spotter")?.Value?.Trim().ToUpperInvariant()
                   ?? session.Callsign;

        if (string.IsNullOrEmpty(call) ||
            !float.TryParse(freqStr, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out var freq))
        {
            _log.LogWarning("ARx2 DxSpot bad data from {Callsign}: {Xml}", session.Callsign, xml);
            return;
        }

        if (freq < _spotOpts.MinFrequencyKhz || freq > _spotOpts.MaxFrequencyKhz)
        {
            _log.LogWarning("ARx2 DxSpot out-of-range freq {Freq} from {Callsign}", freq, session.Callsign);
            return;
        }

        if (comment.Length > _spotOpts.MaxCommentLength)
            comment = comment[.._spotOpts.MaxCommentLength];

        var bm       = _bandMode.LookupFrequency(freq);
        var band     = bm?.Band ?? 0f;
        var mode     = bm?.Mode ?? string.Empty;
        var calledCty  = _cty.LookupCallsign(call);
        var spotterCty = _cty.LookupCallsign(spotter);

        bool isDupe = band > 0f && _dupeDetector.IsDuplicate(call,
            band.ToString(System.Globalization.CultureInfo.InvariantCulture));

        var now = DateTime.UtcNow;
        var spot = new DxSpot
        {
            Call      = call,
            Spotter   = spotter,
            SpotterNode = _serverOpts.NodeCallsign,
            Freq      = freq,
            Band      = band,
            Mode      = mode,
            Comment   = comment,
            Cty       = calledCty?.CtyCode   ?? string.Empty,
            SpotterCty = spotterCty?.CtyCode ?? string.Empty,
            Cont      = calledCty?.Continent  ?? string.Empty,
            SpotterCont = spotterCty?.Continent ?? string.Empty,
            CqZone    = (byte)(calledCty?.CqZone  ?? 0),
            ItuZone   = (byte)(calledCty?.ItuZone  ?? 0),
            SpotterCqZone  = (byte)(spotterCty?.CqZone  ?? 0),
            SpotterItuZone = (byte)(spotterCty?.ItuZone  ?? 0),
            DupeKey   = $"{call}|{band}",
            IsDupe    = isDupe,
            Timestamp = now,
            ReceivedAt = now,
        };

        await _spots.InsertAsync(spot, ct);

        if (!isDupe)
        {
            // Distribute to telnet users (plain text) and ARx2 clients (XML)
            var response = new CommandResponse
            {
                DistroType = DistroType.ToAll,
                MsgType    = MsgType.Dx,
                ArxMessage = BuildArxServerDxSpot(spot),
            };
            response.Messages.Add(DxSpotFormatter.Format(spot));
            await _distributor.DistributeAsync(response, session, ct);

            _log.LogInformation("ARx2 spot: {Spotter} → {Call} @ {Freq} kHz", spotter, call, freq);
        }
    }

    // ── ARx2 spot broadcast builder ───────────────────────────────────────

    public static string BuildArxServerDxSpot(DxSpot spot)
    {
        var freq = spot.Freq.ToString("F1", System.Globalization.CultureInfo.InvariantCulture);
        var time = spot.Timestamp.ToUniversalTime().ToString("HHmm") + "Z";
        var date = spot.Timestamp.ToUniversalTime().ToString("dd-MMM-yyyy");
        return ArxFrame.BuildXml("AB5K_Server_DxSpot",
            ("Call",    spot.Call),
            ("Freq",    freq),
            ("Comment", spot.Comment),
            ("Spotter", spot.Spotter),
            ("Time",    time),
            ("Date",    date),
            ("Band",    spot.Band.ToString(System.Globalization.CultureInfo.InvariantCulture)),
            ("Mode",    spot.Mode),
            ("Cty",     spot.Cty),
            ("Cont",    spot.Cont));
    }
}

internal static class StringEx
{
    public static string Or(this string? value, string fallback) =>
        string.IsNullOrEmpty(value) ? fallback : value;
}
