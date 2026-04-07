using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: SH/CONNECT — detailed diagnostics for all connected peer nodes.
/// Shows endpoint, protocol, handshake state, uptime, and spot counters.
/// </summary>
public sealed class ShowConnectCommand : IArcCommand
{
    private readonly INodeManager _nodes;

    public ShowConnectCommand(INodeManager nodes)
    {
        _nodes = nodes;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var nodes = _nodes.GetConnectedNodes();
        var resp  = context.Response;

        resp.Messages.Add($"Node connections — {nodes.Count} peer(s)");

        if (nodes.Count == 0)
        {
            resp.Messages.Add("  No peer nodes connected.");
        }
        else
        {
            foreach (var n in nodes)
            {
                var now     = DateTime.UtcNow;
                var elapsed = now - n.ConnectedAt;
                var uptime  = elapsed.TotalHours >= 1
                    ? $"{(int)elapsed.TotalHours}h {elapsed.Minutes:D2}m"
                    : $"{elapsed.Minutes}m {elapsed.Seconds:D2}s";

                var software  = string.IsNullOrEmpty(n.Software) ? "PCxx" : n.Software;
                var version   = string.IsNullOrEmpty(n.Version)  ? ""    : $" {n.Version}";
                var handshake = n.HandshakeComplete ? "READY" : "INIT";

                var lastSpot = n.LastSpotAt.HasValue
                    ? n.LastSpotAt.Value.ToString("dd-MMM HH:mmZ")
                    : "never";

                resp.Messages.Add(string.Empty);
                resp.Messages.Add($"  {n.Callsign}  [{handshake}]  {software}{version}");
                resp.Messages.Add($"    Endpoint  : {n.RemoteEndpoint}");
                resp.Messages.Add($"    Connected : {n.ConnectedAt:dd-MMM-yyyy HH:mmZ}  (up {uptime})");
                resp.Messages.Add($"    Last seen : {n.LastSeenAt:dd-MMM-yyyy HH:mmZ}");
                resp.Messages.Add($"    Last spot : {lastSpot}");
                resp.Messages.Add($"    RX spots  : {n.SpotsReceived}");
                resp.Messages.Add($"    TX spots  : {n.SpotsSent}");
            }
        }

        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
