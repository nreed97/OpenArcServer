using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: SH/DX [n] [call] [band] [mode]
///
/// Slash-separated parts after the base command are treated as one-shot band/mode filters
/// that apply only to this query (they do not change the user's persistent SET/DX/BAND filter).
///
/// Examples:
///   SH/DX          — last DxCount spots using the user's persistent filter
///   SH/DX 20       — last 20 spots
///   SH/DX 20 W1AW  — last 20 spots for W1AW prefix
///   SH/DX/20m      — last DxCount spots on 20m (inline band filter)
///   SH/DX/CW       — last DxCount spots in CW mode (inline mode filter)
///   SH/DX/20m/CW   — last DxCount spots on 20m in CW mode
///   SH/DX/20m/CW 10 — last 10 spots on 20m in CW
/// </summary>
public sealed class ShowDxCommand : IArcCommand
{
    private readonly IDxSpotRepository _spots;

    // Well-known amateur band numbers (meter values) and their aliases
    private static readonly HashSet<string> KnownBands = new(StringComparer.OrdinalIgnoreCase)
    {
        "160", "160M", "80", "80M", "60", "60M", "40", "40M", "30", "30M",
        "20", "20M", "17", "17M", "15", "15M", "12", "12M", "10", "10M",
        "6", "6M", "4", "4M", "2", "2M", "70CM", "23CM", "13CM",
    };

    // Well-known mode names — anything that is clearly not a callsign or number
    private static readonly HashSet<string> KnownModes = new(StringComparer.OrdinalIgnoreCase)
    {
        "CW", "SSB", "USB", "LSB", "AM", "FM", "RTTY", "PSK", "PSK31",
        "FT8", "FT4", "WSPR", "JT65", "JT9", "JS8", "DIGITAL", "DATA", "PHONE",
        "DIGI", "MSK144", "Q65", "EME",
    };

    public ShowDxCommand(IDxSpotRepository spots)
    {
        _spots = spots;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var session = context.Session;
        var resp    = context.Response;

        // Parse args: slash-separated inline band/mode filters + space-separated count/call
        int count = session.DxCount;
        string? callFilter = null;
        var inlineBands = new HashSet<float>();
        var inlineModes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        ParseArgs(context.Request.RawMessage, ref count, ref callFilter, inlineBands, inlineModes);

        // Fetch from repository
        IReadOnlyList<Core.Models.DxSpot> spots;
        if (!string.IsNullOrEmpty(callFilter))
            spots = await _spots.SearchByCallAsync(callFilter, count, ct);
        else
            spots = await _spots.GetRecentAsync(count, ct);

        // Build effective filter: combine the user's persistent filter with inline overrides
        var filter = BuildEffectiveFilter(session.SpotFilter, inlineBands, inlineModes);

        var filtered = filter.IsEmpty ? spots : spots.Where(filter.Matches).ToList();

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
        resp.MsgType = MsgType.Dx;
    }

    /// <summary>
    /// Parses the raw command string into count, callFilter, and inline band/mode sets.
    ///
    /// Slash-separated parts after the base command (SH/DX or abbreviations) become
    /// one-shot band/mode overrides.  Space-separated args after the slash block are
    /// parsed as count (first numeric token ≤ 100) and/or callsign prefix.
    /// </summary>
    private static void ParseArgs(
        string raw,
        ref int count,
        ref string? callFilter,
        HashSet<float> inlineBands,
        HashSet<string> inlineModes)
    {
        if (string.IsNullOrWhiteSpace(raw)) return;

        // Split at first space to separate the slash block from space-based args
        var trimmed    = raw.Trim().ToUpperInvariant();
        var spaceIdx   = trimmed.IndexOf(' ');
        var slashBlock = spaceIdx >= 0 ? trimmed[..spaceIdx] : trimmed;
        var spaceArgs  = spaceIdx >= 0 ? trimmed[(spaceIdx + 1)..].Trim() : string.Empty;

        // Parse slash-separated inline filters (skip first two: SH + DX/abbreviation)
        var slashParts = slashBlock.Split('/');
        for (int i = 2; i < slashParts.Length; i++)
        {
            var part = slashParts[i].Trim();
            if (part.Length == 0) continue;

            if (KnownModes.Contains(part))
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

        // Parse space-separated args: [count] [callsign]
        var spaceTokens = spaceArgs.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int ti = 0;
        if (ti < spaceTokens.Length && int.TryParse(spaceTokens[ti], out var n) && n >= 1 && n <= 100)
        {
            count = n;
            ti++;
        }
        if (ti < spaceTokens.Length)
        {
            callFilter = spaceTokens[ti].ToUpperInvariant();
        }
    }

    /// <summary>
    /// Returns a SpotFilter that combines the user's persistent filter with any
    /// inline overrides provided in this query.  Inline sets replace (not append to)
    /// the corresponding persistent set so the query is self-contained.
    /// </summary>
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
