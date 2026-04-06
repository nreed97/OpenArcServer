using System.Globalization;
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

namespace OpenArcServer.Protocols.Arx;

/// <summary>
/// Processes decoded ARx2 XML messages (decompressed, frame stripped).
/// Shared by both TelnetClientConnection (post-login ARx2 switch) and
/// ArxClientConnection (pure-ARx2 connections if any).
/// </summary>
public sealed class ArxMessageProcessor : IArxMessageProcessor
{
    private readonly IMessageDistributor _distributor;
    private readonly IDxSpotRepository _spots;
    private readonly ICtyLookup _cty;
    private readonly IBandModeLookup _bandMode;
    private readonly DuplicateSpotDetector _dupeDetector;
    private readonly SpotProcessingOptions _spotOpts;
    private readonly ILogger<ArxMessageProcessor> _log;

    public ArxMessageProcessor(
        IMessageDistributor distributor,
        IDxSpotRepository spots,
        ICtyLookup cty,
        IBandModeLookup bandMode,
        DuplicateSpotDetector dupeDetector,
        IOptions<SpotProcessingOptions> spotOpts,
        ILogger<ArxMessageProcessor> log)
    {
        _distributor  = distributor;
        _spots        = spots;
        _cty          = cty;
        _bandMode     = bandMode;
        _dupeDetector = dupeDetector;
        _spotOpts     = spotOpts.Value;
        _log          = log;
    }

    public async Task ProcessAsync(UserSession session, string xml, CancellationToken ct)
    {
        var msgType = ArxFrame.GetMessageType(xml);
        _log.LogDebug("ARx2 RX ← {Callsign} [{Type}]: {Xml}",
            session.Callsign, msgType, xml);

        switch (msgType)
        {
            case "AB5K_Client_DxSpot":
                await HandleDxSpotAsync(session, xml, ct);
                break;

            // Received from a peer node pushing spots to us (outbound ARx connection)
            case "AB5K_Client_Dx":
                await HandleIncomingDxAsync(session, xml, ct);
                break;

            default:
                _log.LogDebug(
                    "ARx2 unhandled message type [{Type}] from {Callsign}",
                    msgType ?? "(null)", session.Callsign);
                break;
        }
    }

    // ── DX Spot ───────────────────────────────────────────────────────────

    private async Task HandleDxSpotAsync(UserSession session, string xml, CancellationToken ct)
    {
        XElement root;
        try { root = XElement.Parse(xml); }
        catch { return; }

        var call    = root.Element("Call")?.Value?.Trim().ToUpperInvariant() ?? string.Empty;
        var freqStr = root.Element("Freq")?.Value?.Trim() ?? string.Empty;
        var comment = root.Element("Comment")?.Value?.Trim() ?? string.Empty;
        var spotter = (root.Element("Spotter")?.Value?.Trim().ToUpperInvariant()
                    ?? session.Callsign).TrimEnd(':');

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
            Call        = call,
            Spotter     = spotter,
            SpotterNode = string.Empty,
            Freq        = freq,
            Band        = band,
            Mode        = mode,
            Comment     = comment,
            Cty         = calledCty?.CtyCode    ?? string.Empty,
            SpotterCty  = spotterCty?.CtyCode   ?? string.Empty,
            Cont        = calledCty?.Continent   ?? string.Empty,
            SpotterCont = spotterCty?.Continent  ?? string.Empty,
            CqZone      = (byte)(calledCty?.CqZone  ?? 0),
            ItuZone     = (byte)(calledCty?.ItuZone  ?? 0),
            SpotterCqZone  = (byte)(spotterCty?.CqZone  ?? 0),
            SpotterItuZone = (byte)(spotterCty?.ItuZone  ?? 0),
            DupeKey     = $"{call}|{band}",
            IsDupe      = isDupe,
            Timestamp   = now,
            ReceivedAt  = now,
        };

        await _spots.InsertAsync(spot, ct);

        if (!isDupe)
        {
            var response = new CommandResponse
            {
                DistroType = DistroType.ToAll,
                MsgType    = MsgType.Dx,
                SpotData   = spot,
                ArxMessage  = DxSpotFormatter.FormatArxClientDx(spot),
                PcxxMessage = DxSpotFormatter.FormatPc11(spot, spotter),
            };
            response.Messages.Add(DxSpotFormatter.Format(spot));
            await _distributor.DistributeAsync(response, session, ct);

            _log.LogInformation("ARx2 spot: {Spotter} → {Call} @ {Freq} kHz", spotter, call, freq);
        }
    }

    // ── Incoming DX from peer node (AB5K_Client_Dx pushed to us) ─────────────

    private async Task HandleIncomingDxAsync(UserSession session, string xml, CancellationToken ct)
    {
        XElement root;
        try { root = XElement.Parse(xml); }
        catch { return; }

        var call        = root.Element("Call")?.Value?.Trim().ToUpperInvariant() ?? string.Empty;
        var freqStr     = root.Element("Freq")?.Value?.Trim() ?? string.Empty;
        var comment     = root.Element("Comment")?.Value?.Trim() ?? string.Empty;
        var spotter     = root.Element("Spotter")?.Value?.Trim().ToUpperInvariant() ?? string.Empty;
        var spotterNode = root.Element("SpotterNode")?.Value?.Trim() ?? session.Callsign;
        var skimmerStr  = root.Element("Skimmer")?.Value?.Trim() ?? "false";
        bool isSkimmer  = string.Equals(skimmerStr, "true", StringComparison.OrdinalIgnoreCase);

        if (string.IsNullOrEmpty(call) || string.IsNullOrEmpty(spotter) ||
            !float.TryParse(freqStr, NumberStyles.Float, CultureInfo.InvariantCulture, out var freq))
            return;

        if (freq < _spotOpts.MinFrequencyKhz || freq > _spotOpts.MaxFrequencyKhz) return;
        if (comment.Length > _spotOpts.MaxCommentLength) comment = comment[.._spotOpts.MaxCommentLength];

        var bm         = _bandMode.LookupFrequency(freq);
        var band       = bm?.Band ?? 0f;
        var mode       = bm?.Mode ?? string.Empty;
        var calledCty  = _cty.LookupCallsign(call);
        var spotterCty = _cty.LookupCallsign(spotter);

        bool isDupe = band > 0f && _dupeDetector.IsDuplicate(call,
            band.ToString(CultureInfo.InvariantCulture));

        var now  = DateTime.UtcNow;
        var spot = new DxSpot
        {
            Call           = call,
            Spotter        = spotter,
            SpotterNode    = spotterNode,
            Skimmer        = isSkimmer,
            Freq           = freq,
            Band           = band,
            Mode           = mode,
            Comment        = comment,
            Cty            = calledCty?.CtyCode    ?? string.Empty,
            SpotterCty     = spotterCty?.CtyCode   ?? string.Empty,
            Cont           = calledCty?.Continent   ?? string.Empty,
            SpotterCont    = spotterCty?.Continent  ?? string.Empty,
            CqZone         = (byte)(calledCty?.CqZone  ?? 0),
            ItuZone        = (byte)(calledCty?.ItuZone  ?? 0),
            SpotterCqZone  = (byte)(spotterCty?.CqZone  ?? 0),
            SpotterItuZone = (byte)(spotterCty?.ItuZone  ?? 0),
            DupeKey        = $"{call}|{band}",
            IsDupe         = isDupe,
            Timestamp      = now,
            ReceivedAt     = now,
        };

        await _spots.InsertAsync(spot, ct);

        if (!isDupe)
        {
            var formatted = DxSpotFormatter.Format(spot);
            var response  = new CommandResponse
            {
                DistroType  = DistroType.ToAll,
                MsgType     = MsgType.Dx,
                SpotData    = spot,
                ArxMessage  = DxSpotFormatter.FormatArxClientDx(spot, spotterNode),
                PcxxMessage = DxSpotFormatter.FormatPc11(spot, spotterNode),
            };
            response.Messages.Add(formatted);
            // session is the peer node — distributor excludes it so the spot won't loop back
            await _distributor.DistributeAsync(response, session, ct);

            _log.LogInformation("ARx peer spot: {Spotter}@{Node} → {Call} @ {Freq} kHz [{Band}]",
                spotter, spotterNode, call, freq, band);
        }
    }
}
