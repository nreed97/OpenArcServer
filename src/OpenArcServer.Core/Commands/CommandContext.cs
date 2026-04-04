using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Core.Commands;

public sealed class CommandContext
{
    public UserSession Session { get; init; } = null!;
    public CommandRequest Request { get; init; } = null!;
    public CommandResponse Response { get; } = new();
}

public sealed class CommandRequest
{
    public string RawMessage { get; init; } = string.Empty;

    /// <summary>Tokens split on space, with '/' also treated as a separator</summary>
    public string[] Tokens { get; init; } = Array.Empty<string>();

    /// <summary>Normalized command key for routing (uppercase, spaces between parts)</summary>
    public string CommandKey { get; init; } = string.Empty;

    public static CommandRequest Parse(string rawMessage)
    {
        if (string.IsNullOrWhiteSpace(rawMessage))
            return new CommandRequest { RawMessage = rawMessage };

        // Normalize: replace '/' with ' ', collapse whitespace
        var normalized = rawMessage.Trim().Replace('/', ' ');
        var tokens = normalized.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (tokens.Length == 0)
            return new CommandRequest { RawMessage = rawMessage };

        // Command key is the first 1-4 tokens uppercased
        var keyTokens = tokens.Take(4).Select(t => t.ToUpperInvariant()).ToArray();
        var commandKey = string.Join(" ", keyTokens);

        return new CommandRequest
        {
            RawMessage = rawMessage,
            Tokens = tokens.Select(t => t.ToUpperInvariant()).ToArray(),
            CommandKey = commandKey
        };
    }
}

public sealed class CommandResponse
{
    public List<string> Messages { get; } = new();
    public DistroType DistroType { get; set; } = DistroType.ToNil;
    public MsgType MsgType { get; set; } = MsgType.General;
    public string? TargetCallsign { get; set; }

    public void AddLine(string line) => Messages.Add(line);
    public void AddLines(IEnumerable<string> lines) => Messages.AddRange(lines);
}
