using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Parsers;

/// <summary>
/// Loads a simple line-per-entry text file (CallBlock.dat, ConnectBlock.dat, BadWord.dat).
/// Lines starting with '#' or ';' are comments. Entries are trimmed and uppercased.
/// Supports hot-reload via <see cref="Reload"/> — thread-safe through a volatile class reference.
/// </summary>
public sealed class FilterListParser : IFilterList
{
    // Reference type so volatile works correctly for atomic reference swap.
    private sealed class FilterData
    {
        public readonly HashSet<string> Set;
        public readonly List<string>    List;
        public FilterData(HashSet<string> set, List<string> list) { Set = set; List = list; }
    }

    private readonly string _filePath;
    private volatile FilterData _data;

    public FilterListParser(string filePath)
    {
        _filePath = filePath;
        _data     = Parse(filePath);
    }

    public bool IsBlocked(string value) =>
        _data.Set.Contains(value.ToUpperInvariant().Trim());

    public IReadOnlyList<string> GetAll() => _data.List;

    /// <summary>Re-reads the filter file from disk. Thread-safe via volatile reference swap.</summary>
    public void Reload() => _data = Parse(_filePath);

    private static FilterData Parse(string filePath)
    {
        var set  = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var list = new List<string>();

        if (!File.Exists(filePath))
            return new FilterData(set, list);

        foreach (var line in File.ReadLines(filePath))
        {
            var trimmed = line.Trim();
            if (string.IsNullOrEmpty(trimmed) || trimmed.StartsWith('#') || trimmed.StartsWith(';'))
                continue;

            var entry = trimmed.ToUpperInvariant();
            if (set.Add(entry))
                list.Add(entry);
        }

        return new FilterData(set, list);
    }
}
