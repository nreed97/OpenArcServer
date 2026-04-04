using Microsoft.Extensions.Logging;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Sends a connect/disconnect alert to every online user who has
/// <paramref name="callsign"/> on their buddy list.
/// </summary>
public sealed class BuddyAlertService
{
    private readonly IBuddyRepository _buddies;
    private readonly IConnectionManager _connections;
    private readonly ILogger<BuddyAlertService> _log;

    public BuddyAlertService(
        IBuddyRepository buddies,
        IConnectionManager connections,
        ILogger<BuddyAlertService> log)
    {
        _buddies     = buddies;
        _connections = connections;
        _log         = log;
    }

    /// <summary>Call when a user logs in. Notifies all online users who have them as a buddy.</summary>
    public async Task NotifyConnectedAsync(string callsign, CancellationToken ct = default)
    {
        var users = _connections.GetConnectedUsers();
        foreach (var session in users)
        {
            if (string.Equals(session.Callsign, callsign, StringComparison.OrdinalIgnoreCase))
                continue; // Don't alert yourself

            if (session.SendAsync is null) continue;

            try
            {
                if (await _buddies.IsBuddyAsync(session.Callsign, callsign, ct))
                {
                    var msg = $"*** Buddy {callsign} has connected to the cluster ***\r\n";
                    await session.SendAsync(msg, ct);
                }
            }
            catch (Exception ex)
            {
                _log.LogWarning(ex, "Failed to send buddy alert to {Callsign}", session.Callsign);
            }
        }
    }

    /// <summary>Call when a user disconnects. Notifies all online users who have them as a buddy.</summary>
    public async Task NotifyDisconnectedAsync(string callsign, CancellationToken ct = default)
    {
        var users = _connections.GetConnectedUsers();
        foreach (var session in users)
        {
            if (string.Equals(session.Callsign, callsign, StringComparison.OrdinalIgnoreCase))
                continue;

            if (session.SendAsync is null) continue;

            try
            {
                if (await _buddies.IsBuddyAsync(session.Callsign, callsign, ct))
                {
                    var msg = $"*** Buddy {callsign} has disconnected from the cluster ***\r\n";
                    await session.SendAsync(msg, ct);
                }
            }
            catch (Exception ex)
            {
                _log.LogWarning(ex, "Failed to send buddy alert to {Callsign}", session.Callsign);
            }
        }
    }
}
