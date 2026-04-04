using OpenArcServer.Core;
using OpenArcServer.Core.Commands;

namespace OpenArcServer.Engine.Commands;

/// <summary>Handles: SH/TIME — shows current UTC time.</summary>
public sealed class ShowTimeCommand : IArcCommand
{
    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var now = DateTime.UtcNow;
        context.Response.Messages.Add(now.ToString("HH:mm:ss UTC  dddd dd-MMM-yyyy"));
        context.Response.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
