using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Protocols.Pcxx;

public sealed class PcxxServer : BackgroundService
{
    private readonly PcxxOptions _opts;
    private readonly IServiceProvider _services;
    private readonly ILogger<PcxxServer> _log;

    public PcxxServer(
        IOptions<PcxxOptions> opts,
        IServiceProvider services,
        ILogger<PcxxServer> log)
    {
        _opts = opts.Value;
        _services = services;
        _log = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_opts.Enabled)
        {
            _log.LogInformation("PCxx server is disabled");
            return;
        }

        var bindAddress = IPAddress.Parse(_opts.BindAddress);
        var listener = new TcpListener(bindAddress, _opts.Port);
        listener.Start();
        _log.LogInformation("PCxx server listening on {Address}:{Port}", _opts.BindAddress, _opts.Port);

        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                TcpClient client;
                try
                {
                    client = await listener.AcceptTcpClientAsync(stoppingToken);
                }
                catch (OperationCanceledException) { break; }
                catch (Exception ex)
                {
                    _log.LogError(ex, "PCxx accept error");
                    continue;
                }

                var capturedClient = client;
                _ = Task.Run(async () =>
                {
                    using var scope = _services.CreateScope();
                    var sp = scope.ServiceProvider;

                    var conn = new PcxxClientConnection(
                        capturedClient,
                        sp.GetRequiredService<INodeManager>(),
                        sp.GetRequiredService<IConnectionManager>(),
                        sp.GetRequiredService<IMessageDistributor>(),
                        sp.GetRequiredService<IDxSpotRepository>(),
                        sp.GetRequiredService<ICtyLookup>(),
                        sp.GetRequiredService<IBandModeLookup>(),
                        sp.GetRequiredService<DuplicateSpotDetector>(),
                        sp.GetRequiredService<IOptions<ServerOptions>>(),
                        sp.GetRequiredService<IOptions<PcxxOptions>>(),
                        sp.GetRequiredService<ILogger<PcxxClientConnection>>());

                    await conn.HandleAsync(stoppingToken);
                }, stoppingToken);
            }
        }
        finally
        {
            listener.Stop();
            _log.LogInformation("PCxx server stopped");
        }
    }
}
