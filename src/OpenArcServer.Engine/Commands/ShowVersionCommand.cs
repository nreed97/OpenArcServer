using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Configuration;
using Microsoft.Extensions.Options;

namespace OpenArcServer.Engine.Commands;

/// <summary>Handles: SH/VERSION — shows server version info.</summary>
public sealed class ShowVersionCommand : IArcCommand
{
    private readonly ServerOptions _opts;

    public ShowVersionCommand(IOptions<ServerOptions> opts)
    {
        _opts = opts.Value;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var resp = context.Response;
        resp.Messages.Add($"{_opts.ServerName} v{_opts.Version}");
        resp.Messages.Add($"Node: {_opts.NodeCallsign}  Sysop: {_opts.SysopCallsign}");
        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
