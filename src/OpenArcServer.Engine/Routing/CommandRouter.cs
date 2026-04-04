using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Routing;

/// <summary>
/// Replicates the original UserCmdLookup abbreviation expansion.
/// A definition like "SH DX" registers keys: "SH DX", "SHOW DX", "SH/DX", "SHOW/DX"
/// and all minimum-abbreviation variants (e.g. "S DX", "SH DX", etc.).
/// </summary>
public sealed class CommandRouter : ICommandRouter
{
    private readonly Dictionary<string, IArcCommand> _map =
        new(StringComparer.OrdinalIgnoreCase);

    public IArcCommand? Resolve(string commandKey)
    {
        commandKey = commandKey.Trim();

        // Try the full key first, then progressively fewer tokens
        // This allows "DX 14025 K1JT" to match the "DX" command
        var tokens = commandKey.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        for (int len = tokens.Length; len >= 1; len--)
        {
            var key = string.Join(' ', tokens[..len]);
            if (_map.TryGetValue(key, out var cmd))
                return cmd;
        }
        return null;
    }

    public void Register(string definition, IArcCommand command)
    {
        // Split definition into tokens ("SH DX" → ["SH", "DX"])
        var tokens = definition.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (tokens.Length == 0) return;

        // Expand each token to all valid abbreviations
        var tokenExpansions = tokens.Select(ExpandToken).ToArray();

        // Build all combinations
        foreach (var combo in Combinations(tokenExpansions))
        {
            // Register space-separated ("SH DX") and slash-separated ("SH/DX")
            var spaceKey = string.Join(' ', combo);
            var slashKey = string.Join('/', combo);

            _map[spaceKey] = command;
            if (slashKey != spaceKey)
                _map[slashKey] = command;
        }
    }

    /// <summary>
    /// Expand a token into all valid abbreviations (all lengths from minLength to full).
    /// For common words, minimum length is the standard ham radio abbreviation.
    /// </summary>
    private static IReadOnlyList<string> ExpandToken(string token)
    {
        token = token.ToUpperInvariant();

        // Minimum prefix lengths by known command words
        int min = token switch
        {
            "SHOW"      => 2,
            "ANNOUNCE"  => 2,
            "HELP"      => 1,
            "BYE"       => 2,
            "USERS"     => 1,
            "VERSION"   => 1,
            "TIME"      => 2,
            "DX"        => 2,
            "SET"       => 2,
            _           => token.Length, // unknown tokens: only exact match
        };

        var result = new List<string>();
        for (int len = min; len <= token.Length; len++)
            result.Add(token[..len]);

        return result;
    }

    private static IEnumerable<string[]> Combinations(IReadOnlyList<string>[] expansions)
    {
        if (expansions.Length == 0)
            yield break;

        // Recursive cartesian product
        foreach (var combo in CartesianProduct(expansions, 0))
            yield return combo;
    }

    private static IEnumerable<string[]> CartesianProduct(IReadOnlyList<string>[] arrays, int index)
    {
        if (index == arrays.Length)
        {
            yield return Array.Empty<string>();
            yield break;
        }

        foreach (var tail in CartesianProduct(arrays, index + 1))
        {
            foreach (var head in arrays[index])
            {
                var result = new string[tail.Length + 1];
                result[0] = head;
                Array.Copy(tail, 0, result, 1, tail.Length);
                yield return result;
            }
        }
    }
}
