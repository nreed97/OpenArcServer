using OpenArcServer.Core.Models;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Core.Services;

public interface INodeManager
{
    void AddNode(NodeRecord node, UserSession session);
    void RemoveNode(string callsign);
    NodeRecord? FindNode(string callsign);
    IReadOnlyList<NodeRecord> GetConnectedNodes();
    /// <summary>Get the session for a connected node (for sending messages).</summary>
    UserSession? GetSession(string callsign);
    int Count { get; }
}
