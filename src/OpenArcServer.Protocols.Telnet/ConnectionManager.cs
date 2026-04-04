using System.Collections.Concurrent;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Protocols.Telnet;

public sealed class ConnectionManager : IConnectionManager
{
    private readonly ConcurrentDictionary<string, UserSession> _sessions = new();

    public void AddSession(UserSession session) =>
        _sessions[session.SessionId] = session;

    public void RemoveSession(string sessionId) =>
        _sessions.TryRemove(sessionId, out _);

    public UserSession? GetSession(string sessionId) =>
        _sessions.TryGetValue(sessionId, out var s) ? s : null;

    public IReadOnlyList<UserSession> GetConnectedUsers() =>
        _sessions.Values.ToList();

    public UserSession? FindByCallsign(string callsign) =>
        _sessions.Values.FirstOrDefault(s =>
            string.Equals(s.Callsign, callsign, StringComparison.OrdinalIgnoreCase));

    public int Count => _sessions.Count;
}
