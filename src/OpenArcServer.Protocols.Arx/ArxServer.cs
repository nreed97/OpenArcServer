using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Protocols.Arx;

/// <summary>
/// TCP listener for AR-Cluster native (ARx2) client connections on port 3608.
/// Each accepted connection is handed to ArxClientConnection for the login handshake
/// and spot-push lifecycle.
/// </summary>
public sealed class ArxServer : BackgroundService
{
    private readonly ArxServerOptions _opts;
    private readonly IServiceProvider _services;
    private readonly ILogger<ArxServer> _log;

    public ArxServer(
        IOptions<ArxServerOptions> opts,
        IServiceProvider services,
        ILogger<ArxServer> log)
    {
        _opts     = opts.Value;
        _services = services;
        _log      = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_opts.Enabled)
        {
            _log.LogInformation("ARx2 server is disabled");
            return;
        }

        var bindAddress = IPAddress.Parse(_opts.BindAddress);
        var listener = new TcpListener(bindAddress, _opts.Port);
        listener.Start();
        _log.LogInformation("ARx2 server listening on {Address}:{Port}", _opts.BindAddress, _opts.Port);

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
                    _log.LogError(ex, "ARx2 server: error accepting connection");
                    continue;
                }

                var capturedClient = client;
                _ = Task.Run(async () =>
                {
                    using var scope = _services.CreateScope();
                    var sp = scope.ServiceProvider;

                    var conn = new ArxClientConnection(
                        capturedClient,
                        sp.GetRequiredService<IArxClientRegistry>(),
                        sp.GetRequiredService<IArxMessageProcessor>(),
                        sp.GetRequiredService<IOptions<ServerOptions>>(),
                        sp.GetRequiredService<ILogger<ArxClientConnection>>());

                    await conn.HandleAsync(stoppingToken);
                }, stoppingToken);
            }
        }
        finally
        {
            listener.Stop();
            _log.LogInformation("ARx2 server stopped");
        }
    }
}
