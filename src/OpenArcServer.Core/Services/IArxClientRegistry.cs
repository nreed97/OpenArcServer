using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Core.Services;

/// <summary>
/// Tracks connected ARx2 native clients so the MessageDistributor can
/// send them ARx2-formatted XML alongside the telnet plain-text broadcast.
/// </summary>
public interface IArxClientRegistry
{
    void Add(UserSession session);
    void Remove(string sessionId);
    IReadOnlyList<UserSession> GetAll();
    int Count { get; }
}
