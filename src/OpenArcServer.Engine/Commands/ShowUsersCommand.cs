using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Commands;

/// <summary>Handles: SH/U — lists connected users.</summary>
public sealed class ShowUsersCommand : IArcCommand
{
    private readonly IConnectionManager _connections;
    private readonly INodeManager _nodes;

    public ShowUsersCommand(IConnectionManager connections, INodeManager nodes)
    {
        _connections = connections;
        _nodes = nodes;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var users = _connections.GetConnectedUsers();
        var resp = context.Response;

        resp.Messages.Add($"Nodes  - {_nodes.Count} connected");
        resp.Messages.Add($"Users  - {users.Count} connected");
        resp.Messages.Add(string.Empty);

        foreach (var u in users)
        {
            var elapsed = DateTime.UtcNow - u.ConnectedAt;
            var duration = elapsed.TotalHours >= 1
                ? $"{(int)elapsed.TotalHours}h{elapsed.Minutes:D2}m"
                : $"{elapsed.Minutes}m{elapsed.Seconds:D2}s";
            resp.Messages.Add($"  {u.Callsign,-12} {u.RemoteEndpoint,-22} {duration,8} ago  [{u.ConnectType}]");
        }

        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
