using OpenArcServer.Core.Sessions;
namespace OpenArcServer.Core.Services;
public interface IWebSocketClientRegistry
{
    void Register(UserSession session);
    void Unregister(string sessionId);
    IReadOnlyList<UserSession> GetAll();
    int Count { get; }
}
