using System.Collections.Concurrent;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;

namespace OpenArcServer.Engine.Spots;

public sealed class DuplicateSpotDetector
{
    private readonly ConcurrentDictionary<string, DateTime> _cache = new(StringComparer.OrdinalIgnoreCase);
    private readonly int _windowMinutes;

    public DuplicateSpotDetector(IOptions<SpotProcessingOptions> opts)
    {
        _windowMinutes = opts.Value.DuplicateWindowMinutes;
    }

    /// <summary>
    /// Returns true if the spot is a duplicate within the configured window.
    /// If not a dupe, records it and returns false.
    /// </summary>
    public bool IsDuplicate(string call, string band)
    {
        var key = $"{call.ToUpperInvariant()}|{band.ToUpperInvariant()}";
        var now = DateTime.UtcNow;
        var cutoff = now.AddMinutes(-_windowMinutes);

        if (_cache.TryGetValue(key, out var lastSeen) && lastSeen > cutoff)
            return true;

        _cache[key] = now;
        return false;
    }

    /// <summary>Remove expired entries from the cache.</summary>
    public void Cleanup()
    {
        var cutoff = DateTime.UtcNow.AddMinutes(-_windowMinutes);
        foreach (var kvp in _cache)
        {
            if (kvp.Value < cutoff)
                _cache.TryRemove(kvp.Key, out _);
        }
    }
}
