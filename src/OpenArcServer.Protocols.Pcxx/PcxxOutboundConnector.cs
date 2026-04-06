using System.Net.Sockets;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Protocols.Pcxx;

/// <summary>
/// Maintains outbound connections to configured PCxx peer nodes.
/// For each peer: connects, waits for their PC18, responds with PC38,
/// then enters the same read loop as inbound connections.
/// Reconnects automatically with backoff on disconnect.
/// </summary>
public sealed class PcxxOutboundConnector : BackgroundService
{
    private readonly IOptionsMonitor<PcxxOptions> _optsMon;
    private readonly IServiceProvider _services;
    private readonly ILogger<PcxxOutboundConnector> _log;

    public PcxxOutboundConnector(
        IOptionsMonitor<PcxxOptions> optsMon,
        IServiceProvider services,
        ILogger<PcxxOutboundConnector> log)
    {
        _optsMon  = optsMon;
        _services = services;
        _log      = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var initial = _optsMon.CurrentValue;
        if (!initial.Enabled || initial.Peers.Count == 0)
        {
            _log.LogInformation("PCxx outbound connector: no peers configured");
            return;
        }

        _log.LogInformation("PCxx outbound connector starting for {Count} peer(s)", initial.Peers.Count);

        var tasks = initial.Peers.Select(peer => MaintainPeerAsync($"{peer.Host}:{peer.Port}", stoppingToken));
        await Task.WhenAll(tasks);
    }

    private async Task MaintainPeerAsync(string peerKey, CancellationToken ct)
    {
        var delay    = TimeSpan.FromSeconds(5);
        var maxDelay = TimeSpan.FromSeconds(300);

        while (!ct.IsCancellationRequested)
        {
            // Re-read live options each iteration so Enabled changes take effect immediately
            var opts = _optsMon.CurrentValue;
            var peer = opts.Peers.FirstOrDefault(p => $"{p.Host}:{p.Port}" == peerKey);

            if (peer is null)
            {
                _log.LogInformation("PCxx outbound: peer {Key} no longer in config, stopping", peerKey);
                return;
            }

            var label = string.IsNullOrEmpty(peer.Label) ? peerKey : peer.Label;

            if (!peer.Enabled)
            {
                await Task.Delay(TimeSpan.FromSeconds(10), ct).ConfigureAwait(false);
                continue;
            }

            _log.LogInformation("PCxx outbound: connecting to {Peer}", label);
            try
            {
                using var client = new TcpClient(System.Net.Sockets.AddressFamily.InterNetwork);
                await client.ConnectAsync(peer.Host, peer.Port, ct);
                _log.LogInformation("PCxx outbound: connected to {Peer}", label);
                delay = TimeSpan.FromSeconds(5); // reset backoff on successful connect

                await HandlePeerAsync(client, label, ct);
            }
            catch (OperationCanceledException) { return; }
            catch (Exception ex)
            {
                _log.LogWarning("PCxx outbound {Peer} error: {Message}", label, ex.Message);
            }

            if (ct.IsCancellationRequested) return;

            _log.LogInformation("PCxx outbound: reconnecting to {Peer} in {Delay}s", label, (int)delay.TotalSeconds);
            await Task.Delay(delay, ct).ConfigureAwait(false);
            delay = delay * 2 < maxDelay ? delay * 2 : maxDelay;
        }
    }

    private async Task HandlePeerAsync(TcpClient client, string label, CancellationToken ct)
    {
        using var scope = _services.CreateScope();
        var sp = scope.ServiceProvider;

        var nodes = sp.GetRequiredService<INodeManager>();
        var connections = sp.GetRequiredService<IConnectionManager>();
        var distributor = sp.GetRequiredService<IMessageDistributor>();
        var spots = sp.GetRequiredService<IDxSpotRepository>();
        var cty = sp.GetRequiredService<ICtyLookup>();
        var bandMode = sp.GetRequiredService<IBandModeLookup>();
        var dupeDetector = sp.GetRequiredService<DuplicateSpotDetector>();
        var serverOpts = sp.GetRequiredService<IOptions<ServerOptions>>();
        var pcxxOpts = sp.GetRequiredService<IOptions<PcxxOptions>>();
        var connLog = sp.GetRequiredService<ILogger<PcxxClientConnection>>();

        var conn = new PcxxClientConnection(
            client, nodes, connections, distributor,
            spots, cty, bandMode, dupeDetector,
            serverOpts, pcxxOpts, connLog,
            isOutbound: true);

        await conn.HandleAsync(ct);
    }
}
