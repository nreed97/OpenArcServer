namespace OpenArcServer.Core.Commands;

public interface IArcCommand
{
    Task ExecuteAsync(CommandContext context, CancellationToken ct = default);
}
