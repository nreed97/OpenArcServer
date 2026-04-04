using OpenArcServer.Core;
using OpenArcServer.Core.Commands;

namespace OpenArcServer.Engine.Commands;

/// <summary>Handles: HELP — lists available commands.</summary>
public sealed class HelpCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var resp = context.Response;
        resp.Messages.Add("Commands available:");
        resp.Messages.Add("  DX <freq> <call> [comment]  - Post a DX spot");
        resp.Messages.Add("  SH/DX [n] [call]            - Show last n DX spots (default 10)");
        resp.Messages.Add("  SH/U                        - Show connected users");
        resp.Messages.Add("  SH/VERSION                  - Show server version");
        resp.Messages.Add("  SH/TIME                     - Show current UTC time");
        resp.Messages.Add("  BYE                         - Disconnect");
        resp.Messages.Add("  HELP                        - This help");
        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
