using System.Collections.Concurrent;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Protocols.WebSocket;

public sealed class WebSocketClientRegistry : IWebSocketClientRegistry
{
    private readonly ConcurrentDictionary<string, UserSession> _sessions = new();
    public void Register(UserSession session) => _sessions[session.SessionId] = session;
    public void Unregister(string sessionId) => _sessions.TryRemove(sessionId, out _);
    public IReadOnlyList<UserSession> GetAll() => _sessions.Values.ToList();
    public int Count => _sessions.Count;
}
