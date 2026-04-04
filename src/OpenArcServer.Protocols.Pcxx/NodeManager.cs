using System.Collections.Concurrent;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using Prometheus;

namespace OpenArcServer.Protocols.Pcxx;

public sealed class NodeManager : INodeManager
{
    private static readonly Gauge ConnectedNodes = Metrics.CreateGauge(
        "openarcserver_connected_nodes",
        "Number of currently connected PCxx cluster nodes");

    private readonly ConcurrentDictionary<string, (NodeRecord Node, UserSession Session)> _nodes =
        new(StringComparer.OrdinalIgnoreCase);

    public void AddNode(NodeRecord node, UserSession session)
    {
        _nodes[node.Callsign] = (node, session);
        ConnectedNodes.Set(_nodes.Count);
    }

    public void RemoveNode(string callsign)
    {
        _nodes.TryRemove(callsign, out _);
        ConnectedNodes.Set(_nodes.Count);
    }

    public NodeRecord? FindNode(string callsign) =>
        _nodes.TryGetValue(callsign, out var entry) ? entry.Node : null;

    public IReadOnlyList<NodeRecord> GetConnectedNodes() =>
        _nodes.Values.Select(e => e.Node).ToList();

    public UserSession? GetSession(string callsign) =>
        _nodes.TryGetValue(callsign, out var entry) ? entry.Session : null;

    public int Count => _nodes.Count;
}
