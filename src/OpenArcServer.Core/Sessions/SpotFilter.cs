using OpenArcServer.Core.Models;

namespace OpenArcServer.Core.Sessions;

/// <summary>
/// Per-user real-time DX spot filter. Null/empty sets mean "no restriction".
/// Users configure this via SET/DX/BAND, SET/DX/MODE, SET/DX/CONT, SET/DX/CQ.
/// </summary>
public sealed class SpotFilter
{
    /// <summary>Band float values from BandMode.dat (e.g. 20, 40, 15). Null = all bands.</summary>
    public HashSet<float>? Bands { get; set; }

    /// <summary>Mode strings (e.g. "CW", "SSB", "RTTY"). Null = all modes.</summary>
    public HashSet<string>? Modes { get; set; }

    /// <summary>Two-letter continent codes (e.g. "NA", "EU"). Null = all continents.</summary>
    public HashSet<string>? Continents { get; set; }

    /// <summary>CQ zone numbers 1-40. Null = all zones.</summary>
    public HashSet<int>? CqZones { get; set; }

    public bool IsEmpty =>
        (Bands is null || Bands.Count == 0) &&
        (Modes is null || Modes.Count == 0) &&
        (Continents is null || Continents.Count == 0) &&
        (CqZones is null || CqZones.Count == 0);

    /// <summary>Returns true if the spot passes all active filter criteria.</summary>
    public bool Matches(DxSpot spot)
    {
        if (Bands is { Count: > 0 } && !Bands.Contains(spot.Band))
            return false;
        if (Modes is { Count: > 0 } && !Modes.Contains(spot.Mode, StringComparer.OrdinalIgnoreCase))
            return false;
        if (Continents is { Count: > 0 } && !Continents.Contains(spot.Cont, StringComparer.OrdinalIgnoreCase))
            return false;
        if (CqZones is { Count: > 0 } && !CqZones.Contains(spot.CqZone))
            return false;
        return true;
    }

    /// <summary>Parses a band name like "20m" or "20" to the BandMode.dat float value.</summary>
    public static float? ParseBand(string input)
    {
        var s = input.TrimEnd('m', 'M');
        if (float.TryParse(s, System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out var v))
            return v;
        return null;
    }

    /// <summary>Human-readable summary of active filters.</summary>
    public string Describe()
    {
        if (IsEmpty) return "No filters active — receiving all spots.";

        var parts = new List<string>();
        if (Bands is { Count: > 0 })
            parts.Add($"Band: {string.Join(" ", Bands.Select(b => b + "m"))}");
        if (Modes is { Count: > 0 })
            parts.Add($"Mode: {string.Join(" ", Modes)}");
        if (Continents is { Count: > 0 })
            parts.Add($"Cont: {string.Join(" ", Continents)}");
        if (CqZones is { Count: > 0 })
            parts.Add($"CQ: {string.Join(" ", CqZones.Order())}");
        return string.Join("  |  ", parts);
    }
}
