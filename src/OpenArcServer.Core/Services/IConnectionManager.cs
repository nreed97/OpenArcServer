using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Core.Services;

public interface IConnectionManager
{
    void AddSession(UserSession session);
    void RemoveSession(string sessionId);
    UserSession? GetSession(string sessionId);
    IReadOnlyList<UserSession> GetConnectedUsers();
    UserSession? FindByCallsign(string callsign);
    int Count { get; }
}
