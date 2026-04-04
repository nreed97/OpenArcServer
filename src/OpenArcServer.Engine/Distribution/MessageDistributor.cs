using Microsoft.Extensions.Logging;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Engine.Distribution;

public sealed class MessageDistributor : IMessageDistributor
{
    private readonly IConnectionManager _connections;
    private readonly ILogger<MessageDistributor> _log;

    public MessageDistributor(IConnectionManager connections, ILogger<MessageDistributor> log)
    {
        _connections = connections;
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
            case Core.DistroType.ToUsers:
                var sessions = _connections.GetConnectedUsers();
                var tasks = sessions.Select(s => SendToSessionAsync(s, text, ct));
                await Task.WhenAll(tasks);
                break;

            case Core.DistroType.ToNil:
                break;

            default:
                // For Phase 1, unrecognized types go to requester only
                await SendToSessionAsync(sender, text, ct);
                break;
        }
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
