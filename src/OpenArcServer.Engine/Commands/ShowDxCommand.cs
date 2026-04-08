using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: SH/DX [n] [call] [band] [mode] — and inline one-shot filter variants:
///
///   SH/DX              last DxCount spots using the user's persistent filter
///   SH/DX 20           last 20 spots  (space arg → count)
///   SH/DX 20 W1AW      last 20 spots for W1AW prefix
///   SH/DX/20m          last DxCount spots on 20m  (slash arg → band filter)
///   SH/DX/CW           last DxCount spots in CW mode
///   SH/DX/20m/CW       20m + CW inline filters combined
///   SH/DX/DXCC/JA      spots from Japan (DX spot Cty field)
///   SH/DX/CALL/W1      spots from callsigns starting with W1
///   SH/DX/20m/CW 10    10 spots on 20m in CW
///
/// The DX de … spot line format is never modified; this command only affects the query.
/// </summary>
public sealed class ShowDxCommand : IArcCommand
{
    private readonly IDxSpotRepository _spots;
    private readonly ICtyLookup? _cty;

    // Well-known ham band values (metre suffixed or plain number)
    private static readonly HashSet<string> KnownBands = new(StringComparer.OrdinalIgnoreCase)
    {
        "160", "160M", "80", "80M", "60", "60M", "40", "40M", "30", "30M",
        "20", "20M", "17", "17M", "15", "15M", "12", "12M", "10", "10M",
        "6", "6M", "4", "4M", "2", "2M", "70CM", "23CM", "13CM",
    };

    private static readonly HashSet<string> KnownModes = new(StringComparer.OrdinalIgnoreCase)
    {
        "CW", "SSB", "USB", "LSB", "AM", "FM", "RTTY", "PSK", "PSK31",
        "FT8", "FT4", "WSPR", "JT65", "JT9", "JS8", "DIGITAL", "DATA", "PHONE",
        "DIGI", "MSK144", "Q65", "EME",
    };

    public ShowDxCommand(IDxSpotRepository spots, ICtyLookup? cty = null)
    {
        _spots = spots;
        _cty   = cty;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var session = context.Session;
        var resp    = context.Response;

        int count = session.DxCount;
        string? callFilter = null;
        string? dxccFilter = null;
        var inlineBands = new HashSet<float>();
        var inlineModes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        ParseArgs(context.Request.RawMessage, ref count, ref callFilter, ref dxccFilter, inlineBands, inlineModes);

        // Resolve DXCC keyword to a CTY code (e.g. "JA" → "JA", "JAPAN" → "JA" if found)
        string? dxccCtyCode = null;
        if (!string.IsNullOrEmpty(dxccFilter) && _cty is not null)
        {
            var rec = _cty.LookupCallsign(dxccFilter);
            dxccCtyCode = rec?.CtyCode;
            if (dxccCtyCode is null)
            {
                resp.Messages.Add($"Unknown DXCC entity: {dxccFilter}");
                resp.DistroType = DistroType.ToRequester;
                return;
            }
        }

        // Fetch from repository
        IReadOnlyList<Core.Models.DxSpot> spots;
        if (!string.IsNullOrEmpty(callFilter))
            spots = await _spots.SearchByCallAsync(callFilter, count, ct);
        else
            spots = await _spots.GetRecentAsync(count, ct);

        // Combine persistent user filter with one-shot inline overrides
        var filter = BuildEffectiveFilter(session.SpotFilter, inlineBands, inlineModes);

        var filtered = spots
            .Where(s => filter.IsEmpty || filter.Matches(s))
            .Where(s => dxccCtyCode is null ||
                        s.Cty.Equals(dxccCtyCode, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (filtered.Count == 0)
        {
            resp.Messages.Add(spots.Count == 0 ? "No spots found." : "No spots match the specified filter.");
        }
        else
        {
            foreach (var line in DxSpotFormatter.FormatList(filtered))
                resp.Messages.Add(line);
        }

        resp.DistroType = DistroType.ToRequester;
        resp.MsgType    = MsgType.Dx;
    }

    // ── Argument parsing ────────────────────────────────────────────────────

    private static void ParseArgs(
        string raw,
        ref int count,
        ref string? callFilter,
        ref string? dxccFilter,
        HashSet<float> inlineBands,
        HashSet<string> inlineModes)
    {
        if (string.IsNullOrWhiteSpace(raw)) return;

        var trimmed  = raw.Trim().ToUpperInvariant();
        var spaceIdx = trimmed.IndexOf(' ');
        var slashBlock = spaceIdx >= 0 ? trimmed[..spaceIdx] : trimmed;
        var spaceArgs  = spaceIdx >= 0 ? trimmed[(spaceIdx + 1)..].Trim() : string.Empty;

        // Parse slash-separated filter tokens (skip "SH" and "DX"/"SH" abbreviation)
        var slashParts = slashBlock.Split('/');
        bool dxccMode = false;
        bool callMode = false;

        for (int i = 2; i < slashParts.Length; i++)
        {
            var part = slashParts[i].Trim();
            if (part.Length == 0) continue;

            if (part == "DXCC")
            {
                dxccMode = true;
                // Consume immediately following slash-part if present
                if (i + 1 < slashParts.Length && slashParts[i + 1].Length > 0)
                    dxccFilter = slashParts[++i];
            }
            else if (part == "CALL")
            {
                callMode = true;
                if (i + 1 < slashParts.Length && slashParts[i + 1].Length > 0)
                {
                    callFilter = slashParts[++i];
                    callMode = false;
                }
            }
            else if (KnownModes.Contains(part))
            {
                inlineModes.Add(part.ToUpperInvariant());
            }
            else
            {
                var bandVal = SpotFilter.ParseBand(part);
                if (bandVal.HasValue && KnownBands.Contains(part))
                    inlineBands.Add(bandVal.Value);
            }
        }

        // Space-separated args: DXCC prefix | CALL prefix | count | callsign
        var spaceTokens = spaceArgs.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int ti = 0;

        if (dxccMode && dxccFilter is null && ti < spaceTokens.Length)
        {
            dxccFilter = spaceTokens[ti++];
        }
        else if (callMode && callFilter is null && ti < spaceTokens.Length)
        {
            callFilter = spaceTokens[ti++];
        }

        // Remaining space args: optional count then optional callsign
        if (ti < spaceTokens.Length && int.TryParse(spaceTokens[ti], out var n) && n >= 1 && n <= 100)
        {
            count = n;
            ti++;
        }
        if (ti < spaceTokens.Length && callFilter is null)
        {
            callFilter = spaceTokens[ti];
        }
    }

    private static SpotFilter BuildEffectiveFilter(
        SpotFilter persistent,
        HashSet<float> inlineBands,
        HashSet<string> inlineModes)
    {
        if (inlineBands.Count == 0 && inlineModes.Count == 0)
            return persistent;

        return new SpotFilter
        {
            Bands      = inlineBands.Count > 0 ? inlineBands : persistent.Bands,
            Modes      = inlineModes.Count > 0 ? inlineModes : persistent.Modes,
            Continents = persistent.Continents,
            CqZones    = persistent.CqZones,
        };
    }
}
