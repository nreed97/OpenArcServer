using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Engine.Commands;

/// <summary>
/// Handles: SH/STATS — server statistics (uptime, spots today, peak users, total connects).
/// </summary>
public sealed class ShowStatsCommand : IArcCommand
{
    private readonly ServerStats _stats;
    private readonly IConnectionManager _connections;
    private readonly INodeManager _nodes;

    public ShowStatsCommand(ServerStats stats, IConnectionManager connections, INodeManager nodes)
    {
        _stats       = stats;
        _connections = connections;
        _nodes       = nodes;
    }

    public Task ExecuteAsync(CommandContext context, CancellationToken ct = default)
    {
        var now     = DateTime.UtcNow;
        var elapsed = now - _stats.StartedAt;
        var uptime  = elapsed.TotalDays >= 1
            ? $"{(int)elapsed.TotalDays}d {elapsed.Hours:D2}h {elapsed.Minutes:D2}m"
            : elapsed.TotalHours >= 1
                ? $"{(int)elapsed.TotalHours}h {elapsed.Minutes:D2}m {elapsed.Seconds:D2}s"
                : $"{elapsed.Minutes}m {elapsed.Seconds:D2}s";

        var resp = context.Response;
        resp.Messages.Add($"OpenArcServer — Statistics");
        resp.Messages.Add($"  Uptime         : {uptime}");
        resp.Messages.Add($"  Started at     : {_stats.StartedAt:dd-MMM-yyyy HH:mmZ}");
        resp.Messages.Add($"  Users now      : {_connections.Count}");
        resp.Messages.Add($"  Peak users     : {_stats.PeakUsers}");
        resp.Messages.Add($"  Nodes now      : {_nodes.Count}");
        resp.Messages.Add($"  Spots today    : {_stats.SpotsToday}");
        resp.Messages.Add($"  Total connects : {_stats.TotalConnects}");

        resp.DistroType = DistroType.ToRequester;
        return Task.CompletedTask;
    }
}
