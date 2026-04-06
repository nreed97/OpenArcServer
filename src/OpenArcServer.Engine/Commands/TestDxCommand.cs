using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// TEST DX &lt;freq&gt; &lt;call&gt; [comment]
///
/// Performs all normal spot parsing, CTY lookup, and formatting but does NOT:
///   - Insert into the database
///   - Distribute to any user or peer node
///
/// The formatted spot is returned only to the requester so they can verify
/// how it would look and what CTY/band/mode would be resolved, without
/// putting a spot on the air.
/// </summary>
public sealed class TestDxCommand : IArcCommand
{
    private readonly ICtyLookup _cty;
    private readonly IBandModeLookup _bandMode;
    private readonly SpotProcessingOptions _opts;

    public TestDxCommand(
        ICtyLookup cty,
        IBandModeLookup bandMode,
        IOptions<SpotProcessingOptions> opts)
    {
        _cty     = cty;
        _bandMode = bandMode;
        _opts    = opts.Value;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var req  = context.Request;
        var resp = context.Response;
        resp.DistroType = DistroType.ToRequester;

        // Strip "TEST DX" prefix
        var args = req.RawMessage.Trim();
        var idx = args.IndexOf("DX", StringComparison.OrdinalIgnoreCase);
        args = idx >= 0 ? args[(idx + 2)..].TrimStart() : args;

        var parsed = DxSpotParser.Parse(args);
        if (parsed is null)
        {
            resp.Messages.Add("Usage: TEST DX <freq> <call> [comment]");
            return Task.CompletedTask;
        }

        var (freq, call, comment) = parsed.Value;

        if (freq < _opts.MinFrequencyKhz || freq > _opts.MaxFrequencyKhz)
        {
            resp.Messages.Add($"TEST: invalid frequency {freq} kHz");
            return Task.CompletedTask;
        }

        if (comment.Length > _opts.MaxCommentLength)
            comment = comment[.._opts.MaxCommentLength];

        var bm         = _bandMode.LookupFrequency(freq);
        var band       = bm?.Band ?? 0f;
        var mode       = bm?.Mode ?? string.Empty;
        var calledCty  = _cty.LookupCallsign(call);
        var spotterCty = _cty.LookupCallsign(context.Session.Callsign);

        var spot = new Core.Models.DxSpot
        {
            Call           = call,
            Spotter        = context.Session.Callsign,
            SpotterNode    = string.Empty,
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
            Timestamp      = DateTime.UtcNow,
            ReceivedAt     = DateTime.UtcNow,
        };

        resp.Messages.Add(DxSpotFormatter.Format(spot));
        resp.Messages.Add(
            $"TEST: not propagated — DXCC={spot.Cty} cont={spot.Cont} " +
            $"CQ={spot.CqZone} ITU={spot.ItuZone} band={band} mode={mode}");

        return Task.CompletedTask;
    }
}
