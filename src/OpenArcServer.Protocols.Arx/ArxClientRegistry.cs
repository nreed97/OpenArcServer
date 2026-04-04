using System.Collections.Concurrent;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Protocols.Arx;

public sealed class ArxClientRegistry : IArxClientRegistry
{
    private readonly ConcurrentDictionary<string, UserSession> _clients =
        new(StringComparer.Ordinal);

    public void Add(UserSession session)    => _clients[session.SessionId] = session;
    public void Remove(string sessionId)   => _clients.TryRemove(sessionId, out _);
    public IReadOnlyList<UserSession> GetAll() => _clients.Values.ToList();
    public int Count => _clients.Count;
}
