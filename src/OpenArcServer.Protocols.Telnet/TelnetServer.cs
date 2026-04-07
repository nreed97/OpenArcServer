using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Commands;

namespace OpenArcServer.Protocols.Telnet;

public sealed class TelnetServer : BackgroundService
{
    private readonly TelnetOptions _opts;
    private readonly RateLimitOptions _rl;
    private readonly IServiceProvider _services;
    private readonly ILogger<TelnetServer> _log;

    // Per-IP connection tracking: IP → (count in window, window start)
    private readonly ConcurrentDictionary<string, (int Count, DateTime WindowStart)> _ipCounts = new();

    public TelnetServer(
        IOptions<TelnetOptions> opts,
        IOptions<RateLimitOptions> rateLimitOpts,
        IServiceProvider services,
        ILogger<TelnetServer> log)
    {
        _opts     = opts.Value;
        _rl       = rateLimitOpts.Value;
        _services = services;
        _log      = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_opts.Enabled)
        {
            _log.LogInformation("Telnet server is disabled");
            return;
        }

        var bindAddress = IPAddress.Parse(_opts.BindAddress);
        var listener = new TcpListener(bindAddress, _opts.Port);
        listener.Start();

        _log.LogInformation("Telnet server listening on {Address}:{Port}", _opts.BindAddress, _opts.Port);

        // Periodically prune expired IP-count windows to prevent unbounded growth
        _ = Task.Run(() => PruneIpCountsAsync(stoppingToken), stoppingToken);

        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                TcpClient client;
                try
                {
                    client = await listener.AcceptTcpClientAsync(stoppingToken);
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    _log.LogError(ex, "Error accepting connection");
                    continue;
                }

                // Per-IP connection rate limiting
                if (_rl.Enabled && _rl.MaxConnectionsPerIpPerMinute > 0)
                {
                    var ip = client.Client.RemoteEndPoint is IPEndPoint ep
                        ? ep.Address.ToString()
                        : "unknown";

                    var now = DateTime.UtcNow;
                    var entry = _ipCounts.AddOrUpdate(
                        ip,
                        _ => (1, now),
                        (_, existing) =>
                        {
                            // Reset window if more than a minute has elapsed
                            if ((now - existing.WindowStart).TotalMinutes >= 1)
                                return (1, now);
                            return (existing.Count + 1, existing.WindowStart);
                        });

                    if (entry.Count > _rl.MaxConnectionsPerIpPerMinute)
                    {
                        _log.LogWarning(
                            "Connection rate limit exceeded for {IP} ({Count}/min) — dropping",
                            ip, entry.Count);
                        client.Dispose();
                        continue;
                    }
                }

                var capturedClient = client;
                _ = Task.Run(async () =>
                {
                    using var scope = _services.CreateScope();
                    var sp = scope.ServiceProvider;

                    var connection = new TelnetClientConnection(
                        capturedClient,
                        sp.GetRequiredService<IConnectionManager>(),
                        sp.GetRequiredService<ICommandRouter>(),
                        sp.GetRequiredService<IMessageDistributor>(),
                        sp.GetRequiredService<IUserRepository>(),
                        sp.GetRequiredKeyedService<IFilterList>("connectblock"),
                        sp.GetRequiredService<IArxMessageProcessor>(),
                        sp.GetRequiredService<BuddyAlertService>(),
                        sp.GetRequiredService<IOptions<TelnetOptions>>(),
                        sp.GetRequiredService<IOptions<ServerOptions>>(),
                        sp.GetRequiredService<IOptions<RateLimitOptions>>(),
                        sp.GetRequiredService<ILogger<TelnetClientConnection>>());

                    await connection.HandleAsync(stoppingToken);
                }, stoppingToken);
            }
        }
        finally
        {
            listener.Stop();
            _log.LogInformation("Telnet server stopped");
        }
    }

    private async Task PruneIpCountsAsync(CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            await Task.Delay(TimeSpan.FromMinutes(2), ct).ConfigureAwait(false);
            var cutoff = DateTime.UtcNow.AddMinutes(-2);
            foreach (var key in _ipCounts.Keys.ToList())
            {
                if (_ipCounts.TryGetValue(key, out var v) && v.WindowStart < cutoff)
                    _ipCounts.TryRemove(key, out _);
            }
        }
    }
}
