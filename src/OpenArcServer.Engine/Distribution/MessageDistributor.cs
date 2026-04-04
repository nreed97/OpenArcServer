using Microsoft.Extensions.Logging;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Engine.Distribution;

public sealed class MessageDistributor : IMessageDistributor
{
    private readonly IConnectionManager _connections;
    private readonly INodeManager _nodes;
    private readonly ILogger<MessageDistributor> _log;

    public MessageDistributor(
        IConnectionManager connections,
        INodeManager nodes,
        ILogger<MessageDistributor> log)
    {
        _connections = connections;
        _nodes = nodes;
        _log = log;
    }

    public async Task DistributeAsync(CommandResponse response, UserSession sender, CancellationToken ct = default)
    {
        if (response.Messages.Count == 0) return;

        var text = string.Join("\r\n", response.Messages);
        if (!text.EndsWith("\r\n")) text += "\r\n";

        switch (response.DistroType)
        {
            case Core.DistroType.ToRequester:
                await SendToSessionAsync(sender, text, ct);
                break;

            case Core.DistroType.ToAll:
                // Telnet users + PCxx node raw messages (if set)
                await SendToAllUsersAsync(text, ct);
                if (!string.IsNullOrEmpty(response.PcxxMessage))
                    await SendToAllNodesAsync(response.PcxxMessage, ct);
                break;

            case Core.DistroType.ToUsers:
                await SendToAllUsersAsync(text, ct);
                break;

            case Core.DistroType.ToPcxxNodes:
                if (!string.IsNullOrEmpty(response.PcxxMessage))
                    await SendToAllNodesAsync(response.PcxxMessage, ct);
                break;

            case Core.DistroType.ToNode:
                if (!string.IsNullOrEmpty(response.TargetCallsign) && !string.IsNullOrEmpty(response.PcxxMessage))
                {
                    var nodeSession = _nodes.GetSession(response.TargetCallsign);
                    if (nodeSession is not null)
                        await SendToSessionAsync(nodeSession, response.PcxxMessage, ct);
                }
                break;

            case Core.DistroType.ToNil:
                break;

            default:
                await SendToSessionAsync(sender, text, ct);
                break;
        }
    }

    private async Task SendToAllUsersAsync(string text, CancellationToken ct)
    {
        var sessions = _connections.GetConnectedUsers();
        await Task.WhenAll(sessions.Select(s => SendToSessionAsync(s, text, ct)));
    }

    private async Task SendToAllNodesAsync(string pcxxMessage, CancellationToken ct)
    {
        var nodes = _nodes.GetConnectedNodes();
        var tasks = nodes
            .Select(n => _nodes.GetSession(n.Callsign))
            .Where(s => s?.SendAsync is not null)
            .Select(s => SendToSessionAsync(s!, pcxxMessage, ct));
        await Task.WhenAll(tasks);
    }

    private async Task SendToSessionAsync(UserSession session, string text, CancellationToken ct)
    {
        if (session.SendAsync is null) return;
        try
        {
            await session.SendAsync(text, ct);
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "Failed to send to {Callsign}", session.Callsign);
        }
    }
}
