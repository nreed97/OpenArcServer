using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: DX &lt;freq&gt; &lt;call&gt; [comment]
/// Posts a DX spot and broadcasts to all connected users.
/// </summary>
public sealed class DxSpotCommand : IArcCommand
{
    private readonly IDxSpotRepository _spots;
    private readonly ICtyLookup _cty;
    private readonly IBandModeLookup _bandMode;
    private readonly IFilterList _spotBlock;
    private readonly IFilterList _badWords;
    private readonly DuplicateSpotDetector _dupeDetector;
    private readonly SpotProcessingOptions _opts;
    private readonly ILogger<DxSpotCommand> _log;

    public DxSpotCommand(
        IDxSpotRepository spots,
        ICtyLookup cty,
        IBandModeLookup bandMode,
        IFilterList spotBlock,
        IFilterList badWords,
        DuplicateSpotDetector dupeDetector,
        IOptions<SpotProcessingOptions> opts,
        ILogger<DxSpotCommand> log)
    {
        _spots = spots;
        _cty = cty;
        _bandMode = bandMode;
        _spotBlock = spotBlock;
        _badWords = badWords;
        _dupeDetector = dupeDetector;
        _opts = opts.Value;
        _log = log;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var req = context.Request;
        var session = context.Session;
        var resp = context.Response;

        // Extract arguments after the "DX" verb
        var args = req.RawMessage.Trim();
        if (args.StartsWith("DX", StringComparison.OrdinalIgnoreCase))
            args = args[2..].TrimStart();

        var parsed = DxSpotParser.Parse(args);
        if (parsed is null)
        {
            resp.Messages.Add("Usage: DX <freq> <call> [comment]");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        var (freq, call, comment) = parsed.Value;

        // Validate frequency
        if (freq < _opts.MinFrequencyKhz || freq > _opts.MaxFrequencyKhz)
        {
            resp.Messages.Add($"Invalid frequency {freq} kHz");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        // Truncate comment
        if (comment.Length > _opts.MaxCommentLength)
            comment = comment[.._opts.MaxCommentLength];

        // Bad word filter
        if (_opts.EnableBadWordFilter && _badWords.IsBlocked(comment))
        {
            resp.Messages.Add("Comment contains disallowed content.");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        // Spot block
        if (_spotBlock.IsBlocked(call))
        {
            resp.DistroType = DistroType.ToNil;
            return;
        }

        // Band/mode lookup
        var bandMode = _bandMode.LookupFrequency(freq);
        var band = bandMode?.Band ?? 0f;
        var mode = bandMode?.Mode ?? string.Empty;

        // CTY lookups
        var calledCty = _cty.LookupCallsign(call);
        var spotterCty = _cty.LookupCallsign(session.Callsign);

        // Dupe detection
        bool isDupe = false;
        if (_opts.EnableDuplicateDetection && band > 0f)
            isDupe = _dupeDetector.IsDuplicate(call, band.ToString(System.Globalization.CultureInfo.InvariantCulture));

        var now = DateTime.UtcNow;
        var spot = new DxSpot
        {
            Call = call,
            Spotter = session.Callsign,
            SpotterNode = string.Empty,
            Freq = freq,
            Band = band,
            Mode = mode,
            Comment = comment,
            Cty = calledCty?.CtyCode ?? string.Empty,
            SpotterCty = spotterCty?.CtyCode ?? string.Empty,
            Cont = calledCty?.Continent ?? string.Empty,
            SpotterCont = spotterCty?.Continent ?? string.Empty,
            CqZone = (byte)(calledCty?.CqZone ?? 0),
            ItuZone = (byte)(calledCty?.ItuZone ?? 0),
            SpotterCqZone = (byte)(spotterCty?.CqZone ?? 0),
            SpotterItuZone = (byte)(spotterCty?.ItuZone ?? 0),
            DupeKey = $"{call}|{band}",
            IsDupe = isDupe,
            Timestamp = now,
            ReceivedAt = now,
        };

        await _spots.InsertAsync(spot, ct);
        _log.LogInformation("DX spot: {Spotter} -> {Call} @ {Freq} kHz [{Band}]",
            session.Callsign, call, freq, band);

        resp.Messages.Add(DxSpotFormatter.Format(spot));
        resp.DistroType = isDupe ? DistroType.ToRequester : DistroType.ToAll;
        resp.MsgType = MsgType.Dx;
        if (!isDupe)
        {
            resp.PcxxMessage = DxSpotFormatter.FormatPc11(spot, session.Callsign);
            resp.ArxMessage  = DxSpotFormatter.FormatArxServerDxSpot(spot);
        }
    }

}
