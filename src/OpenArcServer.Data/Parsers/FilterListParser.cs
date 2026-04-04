using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Parsers;

/// <summary>
/// Loads a simple line-per-entry text file (CallBlock.dat, ConnectBlock.dat, BadWord.dat).
/// Lines starting with '#' or ';' are comments. Entries are trimmed and uppercased.
/// </summary>
public sealed class FilterListParser : IFilterList
{
    private readonly HashSet<string> _entries;
    private readonly List<string> _ordered;

    public FilterListParser(string filePath)
    {
        (_entries, _ordered) = Parse(filePath);
    }

    public bool IsBlocked(string value)
    {
        return _entries.Contains(value.ToUpperInvariant().Trim());
    }

    public IReadOnlyList<string> GetAll() => _ordered;

    private static (HashSet<string>, List<string>) Parse(string filePath)
    {
        var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var list = new List<string>();

        if (!File.Exists(filePath))
            return (set, list);

        foreach (var line in File.ReadLines(filePath))
        {
            var trimmed = line.Trim();
            if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith('#') || trimmed.StartsWith(';'))
                continue;

            var entry = trimmed.ToUpperInvariant();
            if (set.Add(entry))
                list.Add(entry);
        }

        return (set, list);
    }
}
