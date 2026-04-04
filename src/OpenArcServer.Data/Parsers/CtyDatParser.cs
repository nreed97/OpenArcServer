using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Parsers;

/// <summary>
/// Parses CTY.DAT (or cty_wt_mod.dat) into a prefix→CtyRecord dictionary.
/// Field positions confirmed from ArcShared/CtyInfo.cs lines 170-181:
///   Country[0:25], CqZone[26:5], ItuZone[31:5], Continent[36:5],
///   Lat[41:9], Lon[50:9] (negated in file), TimeOffset[60:8], Cty[68:end]
/// </summary>
public sealed class CtyDatParser : ICtyLookup
{
    // Sorted longest-first for prefix matching
    private readonly (string Prefix, CtyRecord Record)[] _prefixes;

    public CtyDatParser(string filePath)
    {
        _prefixes = Parse(filePath);
    }

    public CtyRecord? LookupCallsign(string callsign)
    {
        if (string.IsNullOrWhiteSpace(callsign))
            return null;

        callsign = callsign.ToUpperInvariant().Trim();

        // Try longest prefix first
        foreach (var (prefix, record) in _prefixes)
        {
            if (callsign.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                return record;
        }
        return null;
    }

    private static (string Prefix, CtyRecord Record)[] Parse(string filePath)
    {
        var records = new List<CtyRecord>();
        var allPrefixes = new List<(string Prefix, CtyRecord Record)>();

        if (!File.Exists(filePath))
            return Array.Empty<(string, CtyRecord)>();

        var lines = File.ReadAllLines(filePath);
        int i = 0;
        while (i < lines.Length)
        {
            var headerLine = lines[i].TrimEnd();
            if (string.IsNullOrWhiteSpace(headerLine) || headerLine.StartsWith('#'))
            {
                i++;
                continue;
            }

            // Header line must be at least 69 chars (Cty starts at col 68)
            if (headerLine.Length < 69)
            {
                i++;
                continue;
            }

            var record = new CtyRecord
            {
                CountryName = headerLine[..25].Trim(),
                CqZone = (byte)ParseInt(headerLine, 26, 5),
                ItuZone = (byte)ParseInt(headerLine, 31, 5),
                Continent = headerLine[36..41].Trim(),
                Latitude = ParseFloat(headerLine, 41, 9),
                Longitude = -ParseFloat(headerLine, 50, 9), // negated in file
                TimeOffset = headerLine.Length >= 68 ? headerLine[60..68].Trim() : string.Empty,
                CtyCode = headerLine[68..].Trim().TrimEnd(':'),
            };
            i++;

            // Read prefix continuation lines (end with ';')
            var prefixBuilder = new System.Text.StringBuilder();
            while (i < lines.Length)
            {
                var prefixLine = lines[i].Trim();
                prefixBuilder.Append(prefixLine);
                i++;
                if (prefixLine.EndsWith(';'))
                    break;
            }

            // Parse comma-separated prefixes
            var rawPrefixes = prefixBuilder.ToString().TrimEnd(';').Split(',');
            foreach (var raw in rawPrefixes)
            {
                var p = raw.Trim();
                if (string.IsNullOrEmpty(p)) continue;

                // Build override record for prefixes with special annotations
                var overrideRecord = record;
                int cqOverride = 0, ituOverride = 0;

                // Extract overrides: (##) = CQ zone, [##] = ITU zone
                var remaining = p;
                while (true)
                {
                    int parenOpen = remaining.IndexOf('(');
                    int parenClose = remaining.IndexOf(')');
                    if (parenOpen >= 0 && parenClose > parenOpen)
                    {
                        var val = remaining[(parenOpen + 1)..parenClose];
                        if (int.TryParse(val, out cqOverride))
                        {
                            remaining = remaining.Remove(parenOpen, parenClose - parenOpen + 1);
                        }
                        else break;
                    }
                    else break;
                }
                while (true)
                {
                    int brackOpen = remaining.IndexOf('[');
                    int brackClose = remaining.IndexOf(']');
                    if (brackOpen >= 0 && brackClose > brackOpen)
                    {
                        var val = remaining[(brackOpen + 1)..brackClose];
                        if (int.TryParse(val, out ituOverride))
                        {
                            remaining = remaining.Remove(brackOpen, brackClose - brackOpen + 1);
                        }
                        else break;
                    }
                    else break;
                }

                // Strip leading '=' (exact match marker — treat same for MVP)
                remaining = remaining.TrimStart('=').Trim();
                if (string.IsNullOrEmpty(remaining)) continue;

                if (cqOverride != 0 || ituOverride != 0)
                {
                    overrideRecord = new CtyRecord
                    {
                        CountryName = record.CountryName,
                        CtyCode = record.CtyCode,
                        Continent = record.Continent,
                        Latitude = record.Latitude,
                        Longitude = record.Longitude,
                        TimeOffset = record.TimeOffset,
                        CqZone = (byte)(cqOverride != 0 ? cqOverride : record.CqZone),
                        ItuZone = (byte)(ituOverride != 0 ? ituOverride : record.ItuZone),
                        Prefixes = record.Prefixes,
                    };
                }

                overrideRecord.Prefixes.Add(remaining.ToUpperInvariant());
                allPrefixes.Add((remaining.ToUpperInvariant(), overrideRecord));
            }

            records.Add(record);
        }

        // Sort by prefix length descending (longest-prefix match)
        allPrefixes.Sort((a, b) => b.Prefix.Length.CompareTo(a.Prefix.Length));
        return allPrefixes.ToArray();
    }

    private static int ParseInt(string line, int start, int length)
    {
        if (start + length > line.Length)
            return 0;
        var s = line.Substring(start, length).Trim();
        return int.TryParse(s, out var v) ? v : 0;
    }

    private static float ParseFloat(string line, int start, int length)
    {
        if (start + length > line.Length)
            return 0f;
        var s = line.Substring(start, length).Trim();
        return float.TryParse(s, System.Globalization.NumberStyles.Float,
            System.Globalization.CultureInfo.InvariantCulture, out var v) ? v : 0f;
    }
}
