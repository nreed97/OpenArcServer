using System.Text.Json;
using Microsoft.Extensions.Logging;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using OpenArcServer.Engine.Spots;
using Prometheus;

namespace OpenArcServer.Engine.Distribution;

public sealed class MessageDistributor : IMessageDistributor
{
    private static readonly Counter SpotsDistributedTotal = Metrics.CreateCounter(
        "openarcserver_spots_distributed_total",
        "Total DX spots distributed to all users/nodes");
    private readonly IConnectionManager _connections;
    private readonly INodeManager _nodes;
    private readonly IArxClientRegistry _arxClients;
    private readonly IWebSocketClientRegistry _wsClients;
    private readonly ICtyLookup? _cty;
    private readonly ILogger<MessageDistributor> _log;

    public MessageDistributor(
        IConnectionManager connections,
        INodeManager nodes,
        IArxClientRegistry arxClients,
        IWebSocketClientRegistry wsClients,
        ILogger<MessageDistributor> log,
        ICtyLookup? cty = null)
    {
        _connections = connections;
        _nodes       = nodes;
        _arxClients  = arxClients;
        _wsClients   = wsClients;
        _cty         = cty;
        _log = log;
    }

    public async Task DistributeAsync(CommandResponse response, UserSession sender, CancellationToken ct = default)
    {
        if (response.Messages.Count == 0 && response.ArxMessage is null) return;

        var text = response.Messages.Count > 0
            ? string.Join("\r\n", response.Messages) + "\r\n"
            : string.Empty;

        switch (response.DistroType)
        {
            case Core.DistroType.ToRequester:
                if (!string.IsNullOrEmpty(text))
                    await SendToSessionAsync(sender, text, ct);
                break;

            case Core.DistroType.ToAll:
                // Telnet + ARx2 clients + PCxx nodes + WebSocket clients
                if (!string.IsNullOrEmpty(text))
                {
                    SpotsDistributedTotal.Inc();
                    await SendToAllUsersAsync(text, response.SpotData, ct);
                }
                if (!string.IsNullOrEmpty(response.ArxMessage))
                    await SendToAllArxClientsAsync(response.ArxMessage, response.SpotData, sender, ct);
                if (!string.IsNullOrEmpty(response.PcxxMessage))
                    await SendToAllNodesAsync(response.PcxxMessage, ct);
                // WebSocket: send structured JSON if this is a DX spot, otherwise text
                if (!string.IsNullOrEmpty(text) && response.SpotData is { } spot)
                    await SendToAllWebSocketClientsJsonAsync(spot, ct);
                else if (!string.IsNullOrEmpty(text))
                    await SendToAllWebSocketClientsTextAsync(text, ct);
                break;

            case Core.DistroType.ToUsers:
                if (!string.IsNullOrEmpty(text))
                    await SendToAllUsersAsync(text, response.SpotData, ct);
                if (!string.IsNullOrEmpty(response.ArxMessage))
                    await SendToAllArxClientsAsync(response.ArxMessage, response.SpotData, sender, ct);
                // WebSocket clients also receive user-facing spots
                if (!string.IsNullOrEmpty(text) && response.SpotData is { } usersSpot)
                    await SendToAllWebSocketClientsJsonAsync(usersSpot, ct);
                else if (!string.IsNullOrEmpty(text))
                    await SendToAllWebSocketClientsTextAsync(text, ct);
                break;

            case Core.DistroType.ToPcxxNodes:
                if (!string.IsNullOrEmpty(response.PcxxMessage))
                    await SendToAllNodesAsync(response.PcxxMessage, ct);
                break;

            case Core.DistroType.ToNode:
                if (!string.IsNullOrEmpty(response.TargetCallsign) && !string.IsNullOrEmpty(response.PcxxMessage))
                {
                    var nodeSession = _nodes.GetSession(response.TargetCallsign);
                    if (nodeSession is not null)
                        await SendToSessionAsync(nodeSession, response.PcxxMessage, ct);
                }
                break;

            case Core.DistroType.ToNil:
                break;

            default:
                if (!string.IsNullOrEmpty(text))
                    await SendToSessionAsync(sender, text, ct);
                break;
        }
    }

    private async Task SendToAllUsersAsync(string text, DxSpot? spotData, CancellationToken ct)
    {
        var sessions = _connections.GetConnectedUsers();
        IEnumerable<UserSession> targets = spotData is null
            ? sessions
            : sessions.Where(s => s.SpotFilter.Matches(spotData) && AllowsSpot(s, spotData));

        var targetList = targets.ToList();
        var tasks = new List<Task>(targetList.Count);

        foreach (var s in targetList)
        {
            tasks.Add(SendToSessionAsync(s, text, ct));

            // Opt-in bearing/distance annotation — a separate line starting with spaces.
            // This line is NEVER parsed by logging software (N1MM+, Logger32, DXLab, etc.)
            // because those programs only match lines that start with "DX de".
            if (spotData is not null && s.ShowDistance &&
                !string.IsNullOrEmpty(s.Grid) && _cty is not null)
            {
                var annotation = BuildAnnotation(s, spotData);
                if (annotation is not null)
                    tasks.Add(SendToSessionAsync(s, annotation, ct));
            }
        }

        await Task.WhenAll(tasks);
    }

    /// <summary>
    /// Builds the optional per-session bearing/distance annotation line.
    /// Returns null if the session grid is invalid or the call cannot be resolved.
    /// </summary>
    private string? BuildAnnotation(UserSession session, DxSpot spot)
    {
        try
        {
            if (!GeoCalculator.TryParseGrid(session.Grid!, out var userLat, out var userLon))
                return null;

            // Prefer CTY record for the DX station's position (accurate to entity centroid)
            var rec = _cty!.LookupCallsign(spot.Call);
            double targetLat, targetLon;
            string label;

            if (rec is not null)
            {
                targetLat = rec.Latitude;
                targetLon = rec.Longitude;
                label = $"{rec.CtyCode}: {rec.CountryName}  CQ{rec.CqZone}";
            }
            else
            {
                // No CTY match — nothing useful to annotate
                return null;
            }

            var dist    = GeoCalculator.DistanceKm(userLat, userLon, targetLat, targetLon);
            var bearing = GeoCalculator.BearingDeg(userLat, userLon, targetLat, targetLon);

            // Pad to align with DX spot lines (72 chars wide); always starts with spaces
            var body = $"  [{label,-30}  {bearing:F0}°  {dist:F0} km]";
            return body + "\r\n";
        }
        catch
        {
            return null;
        }
    }

    private async Task SendToAllArxClientsAsync(
        string arxXml, DxSpot? spotData, UserSession sender, CancellationToken ct)
    {
        var clients = _arxClients.GetAll();
        IEnumerable<UserSession> targets = spotData is null
            ? clients
            : clients.Where(s => s.SpotFilter.Matches(spotData) && AllowsSpot(s, spotData));

        // ARx peer node sessions: never reflect a spot back to the node it arrived from.
        targets = targets.Where(s =>
            s.ConnectType != Core.ConnectStateType.ArxNode ||
            s.SessionId   != sender.SessionId);

        await Task.WhenAll(targets
            .Where(s => s.SendAsync is not null)
            .Select(s => SendToSessionAsync(s, arxXml, ct)));
    }

    private async Task SendToAllNodesAsync(string pcxxMessage, CancellationToken ct)
    {
        var nodes = _nodes.GetConnectedNodes();
        var tasks = nodes
            .Select(n => _nodes.GetSession(n.Callsign))
            .Where(s => s?.SendAsync is not null)
            .Select(s => SendToSessionAsync(s!, pcxxMessage, ct));
        await Task.WhenAll(tasks);
    }

    private async Task SendToAllWebSocketClientsJsonAsync(DxSpot spot, CancellationToken ct)
    {
        var json = JsonSerializer.Serialize(new
        {
            type      = "dx_spot",
            call      = spot.Call,
            spotter   = spot.Spotter,
            freq      = spot.Freq,
            band      = spot.Band,
            mode      = spot.Mode,
            comment   = spot.Comment,
            cont      = spot.Cont,
            cqZone    = spot.CqZone,
            skimmer   = spot.Skimmer,
            rbn       = spot.SpotterNode == "RBN",
            timestamp = spot.Timestamp.ToString("O"),
        });
        var clients = _wsClients.GetAll();
        var targets = clients.Where(s => s.SpotFilter.Matches(spot) && AllowsSpot(s, spot));
        await Task.WhenAll(targets.Where(s => s.SendAsync is not null).Select(s => SendToSessionAsync(s, json, ct)));
    }

    /// <summary>
    /// Returns true if the session's filter settings permit this spot.
    /// RBN spots (SpotterNode=="RBN") are gated by ReceiveRbn.
    /// Non-RBN skimmer spots are gated by ReceiveSkimmer.
    /// Human/non-skimmer spots always pass.
    /// </summary>
    private static bool AllowsSpot(UserSession s, DxSpot spot)
    {
        if (spot.SpotterNode == "RBN") return s.ReceiveRbn;
        if (spot.Skimmer)              return s.ReceiveSkimmer;
        return true;
    }

    private async Task SendToAllWebSocketClientsTextAsync(string text, CancellationToken ct)
    {
        var clients = _wsClients.GetAll();
        await Task.WhenAll(clients.Where(s => s.SendAsync is not null).Select(s => SendToSessionAsync(s, text, ct)));
    }

    private async Task SendToSessionAsync(UserSession session, string text, CancellationToken ct)
    {
        if (session.SendAsync is null) return;
        try
        {
            await session.SendAsync(text, ct);
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "Failed to send to {Callsign}", session.Callsign);
        }
    }
}
