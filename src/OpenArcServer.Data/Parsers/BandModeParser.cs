using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Parsers;

/// <summary>
/// Parses BandMode.dat: space-delimited lines with band, mode, freq_low, freq_high (kHz).
/// Lines starting with '#' or ';' are comments.
/// </summary>
public sealed class BandModeParser : IBandModeLookup
{
    private readonly string _filePath;
    private volatile BandModeEntry[] _entries;

    public BandModeParser(string filePath)
    {
        _filePath = filePath;
        _entries = Parse(filePath);
    }

    public BandModeEntry? LookupFrequency(float freqKhz)
    {
        // Linear scan — entry count is small (~50)
        foreach (var entry in _entries)
        {
            if (freqKhz >= entry.FreqLow && freqKhz <= entry.FreqHigh)
                return entry;
        }
        return null;
    }

    /// <summary>Re-reads BandMode.dat from disk. Thread-safe via volatile reference swap.</summary>
    public void Reload() => _entries = Parse(_filePath);

    private static BandModeEntry[] Parse(string filePath)
    {
        if (!File.Exists(filePath))
            return Array.Empty<BandModeEntry>();

        var entries = new List<BandModeEntry>();
        foreach (var line in File.ReadLines(filePath))
        {
            var trimmed = line.Trim();
            if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith('#') || trimmed.StartsWith(';'))
                continue;

            var parts = trimmed.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 4) continue;

            if (!float.TryParse(parts[0], System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out var band)) continue;
            if (!float.TryParse(parts[2], System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out var low)) continue;
            if (!float.TryParse(parts[3], System.Globalization.NumberStyles.Float,
                    System.Globalization.CultureInfo.InvariantCulture, out var high)) continue;

            entries.Add(new BandModeEntry
            {
                Band = band,
                Mode = parts[1],
                FreqLow = low,
                FreqHigh = high,
            });
        }

        return entries.ToArray();
    }
}
