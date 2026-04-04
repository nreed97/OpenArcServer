using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Configuration;
using Microsoft.Extensions.Options;

namespace OpenArcServer.Engine.Commands;

/// <summary>Handles: BYE — disconnects the user.</summary>
public sealed class ByeCommand : IArcCommand
{
    private readonly TelnetOptions _telnetOpts;
    private readonly ServerOptions _serverOpts;

    public ByeCommand(IOptions<TelnetOptions> telnetOpts, IOptions<ServerOptions> serverOpts)
    {
        _telnetOpts = telnetOpts.Value;
        _serverOpts = serverOpts.Value;
    }

    public async Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var resp = context.Response;
        var session = context.Session;

        var message = _telnetOpts.LogoutMessage
            .Replace("{NodeCallsign}", _serverOpts.NodeCallsign)
            .Replace("{Callsign}", session.Callsign);

        resp.Messages.Add(message);
        resp.DistroType = DistroType.ToRequester;

        // Signal disconnect after response is sent
        var disconnectFn = session.DisconnectAsync;
        if (disconnectFn is not null)
        {
            _ = Task.Run(async () =>
            {
                await Task.Delay(200, CancellationToken.None);
                await disconnectFn();
            });
        }
    }
}
