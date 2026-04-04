using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Commands;

/// <summary>Handles: SH/N — lists connected PCxx cluster nodes.</summary>
public sealed class ShowNodesCommand : IArcCommand
{
    private readonly INodeManager _nodes;

    public ShowNodesCommand(INodeManager nodes)
    {
        _nodes = nodes;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var nodes = _nodes.GetConnectedNodes();
        var resp = context.Response;

        resp.Messages.Add($"Nodes  - {nodes.Count} connected");
        resp.Messages.Add(string.Empty);

        if (nodes.Count == 0)
        {
            resp.Messages.Add("  No nodes connected.");
        }
        else
        {
            foreach (var n in nodes)
            {
                var elapsed = DateTime.UtcNow - n.ConnectedAt;
                var duration = elapsed.TotalHours >= 1
                    ? $"{(int)elapsed.TotalHours}h{elapsed.Minutes:D2}m"
                    : $"{elapsed.Minutes}m{elapsed.Seconds:D2}s";
                var software = string.IsNullOrEmpty(n.Software) ? "PCxx" : n.Software;
                var version = string.IsNullOrEmpty(n.Version) ? string.Empty : $" {n.Version}";
                resp.Messages.Add(
                    $"  {n.Callsign,-12} {n.RemoteEndpoint,-24} {duration,8} ago  [{software}{version}]");
            }
        }

        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
