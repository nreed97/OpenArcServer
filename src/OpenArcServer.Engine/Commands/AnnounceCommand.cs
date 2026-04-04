using OpenArcServer.Core;
using OpenArcServer.Core.Commands;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: A/ANN &lt;message&gt;
/// Broadcasts an announcement to all connected users.
/// Display: "To ALL de W1AW: Hello everyone!"
/// </summary>
public sealed class AnnounceCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var session = context.Session;
        var resp = context.Response;

        // Rebuild message from raw input, stripping the verb
        var raw = context.Request.RawMessage.Trim();
        var spaceIdx = raw.IndexOf(' ');
        var message = spaceIdx >= 0 ? raw[(spaceIdx + 1)..].Trim() : string.Empty;

        if (string.IsNullOrWhiteSpace(message))
        {
            resp.Messages.Add("Usage: ANN <message>");
            resp.DistroType = DistroType.ToRequester;
            return Task.CompletedTask;
        }

        var time = DateTime.UtcNow.ToString("HHmm") + "Z";
        var line = $"To ALL de {session.Callsign,-10}: {message,-48} {time}";
        resp.Messages.Add(line);
        resp.DistroType = DistroType.ToAll;
        resp.MsgType = MsgType.Ann;
        return Task.CompletedTask;
    }
}
