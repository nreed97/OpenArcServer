using System.Collections.Concurrent;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using Prometheus;

namespace OpenArcServer.Protocols.Telnet;

public sealed class ConnectionManager : IConnectionManager
{
    private static readonly Gauge ConnectedUsers = Metrics.CreateGauge(
        "openarcserver_connected_users",
        "Number of currently connected telnet/WebSocket users");

    private readonly ConcurrentDictionary<string, UserSession> _sessions = new();

    public void AddSession(UserSession session)
    {
        _sessions[session.SessionId] = session;
        ConnectedUsers.Inc();
    }

    public void RemoveSession(string sessionId)
    {
        if (_sessions.TryRemove(sessionId, out _))
            ConnectedUsers.Dec();
    }

    public UserSession? GetSession(string sessionId) =>
        _sessions.TryGetValue(sessionId, out var s) ? s : null;

    public IReadOnlyList<UserSession> GetConnectedUsers() =>
        _sessions.Values.ToList();

    public UserSession? FindByCallsign(string callsign) =>
        _sessions.Values.FirstOrDefault(s =>
            string.Equals(s.Callsign, callsign, StringComparison.OrdinalIgnoreCase));

    public int Count => _sessions.Count;
}
