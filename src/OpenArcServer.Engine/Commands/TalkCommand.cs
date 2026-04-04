using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: T/TALK &lt;callsign&gt; &lt;message&gt;
/// Sends a private message to a connected user.
/// </summary>
public sealed class TalkCommand : IArcCommand
{
    private readonly IConnectionManager _connections;

    public TalkCommand(IConnectionManager connections) => _connections = connections;

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var tokens = context.Request.Tokens;
        var session = context.Session;
        var resp = context.Response;

        // Tokens: [T|TALK, <callsign>, <word1>, ...]
        // Allow "T callsign message" and "TALK callsign message"
        int callIdx = Array.FindIndex(tokens,
            t => t.Equals("T", StringComparison.OrdinalIgnoreCase) ||
                 t.Equals("TALK", StringComparison.OrdinalIgnoreCase));

        if (callIdx < 0 || callIdx + 1 >= tokens.Length)
        {
            resp.Messages.Add("Usage: T <callsign> <message>");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        var targetCallsign = tokens[callIdx + 1].ToUpperInvariant();

        if (callIdx + 2 >= tokens.Length)
        {
            resp.Messages.Add("Usage: T <callsign> <message>");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        // Rebuild the message from original input (preserving case/spaces)
        // Find message start after the verb and callsign
        var raw = context.Request.RawMessage.Trim();
        var verbEnd = raw.IndexOf(' ');
        if (verbEnd < 0) { resp.Messages.Add("Usage: T <callsign> <message>"); resp.DistroType = DistroType.ToRequester; return; }
        var afterVerb = raw[(verbEnd + 1)..].TrimStart();
        var msgStart = afterVerb.IndexOf(' ');
        if (msgStart < 0) { resp.Messages.Add("Usage: T <callsign> <message>"); resp.DistroType = DistroType.ToRequester; return; }
        var message = afterVerb[(msgStart + 1)..].Trim();

        if (string.IsNullOrWhiteSpace(message))
        {
            resp.Messages.Add("Usage: T <callsign> <message>");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        // Can't talk to yourself
        if (targetCallsign.Equals(session.Callsign, StringComparison.OrdinalIgnoreCase))
        {
            resp.Messages.Add("You can't send a talk to yourself.");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        var targetSession = _connections.FindByCallsign(targetCallsign);
        if (targetSession is null)
        {
            resp.Messages.Add($"{targetCallsign} is not connected to the cluster.");
            resp.DistroType = DistroType.ToRequester;
            return;
        }

        // Deliver to recipient
        var toRecipient = $"Talk({session.Callsign}) {message}\r\n";
        if (targetSession.SendAsync is not null)
            await targetSession.SendAsync(toRecipient, ct);

        // Echo back to sender
        resp.Messages.Add($"Talk(to {targetCallsign}) {message}");
        resp.DistroType = DistroType.ToRequester;
        resp.MsgType = MsgType.Talk;
    }
}
