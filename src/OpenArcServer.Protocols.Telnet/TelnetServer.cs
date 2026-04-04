using System.Net;
using System.Net.Sockets;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Protocols.Arx;

namespace OpenArcServer.Protocols.Telnet;

public sealed class TelnetServer : BackgroundService
{
    private readonly TelnetOptions _opts;
    private readonly IServiceProvider _services;
    private readonly ILogger<TelnetServer> _log;

    public TelnetServer(
        IOptions<TelnetOptions> opts,
        IServiceProvider services,
        ILogger<TelnetServer> log)
    {
        _opts = opts.Value;
        _services = services;
        _log = log;
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

                var capturedClient = client;
                _ = Task.Run(async () =>
                {
                    using var scope = _services.CreateScope();
                    var sp = scope.ServiceProvider;

                    // All connections start as plain-text telnet (login is always plain-text).
                    // TelnetClientConnection detects [Arx2] frames mid-stream post-login
                    // and automatically switches to ARx2 framing mode for that session.
                    var connection = new TelnetClientConnection(
                        capturedClient,
                        sp.GetRequiredService<IConnectionManager>(),
                        sp.GetRequiredService<ICommandRouter>(),
                        sp.GetRequiredService<IMessageDistributor>(),
                        sp.GetRequiredService<IUserRepository>(),
                        sp.GetRequiredKeyedService<IFilterList>("connectblock"),
                        sp.GetRequiredService<IArxClientRegistry>(),
                        sp.GetRequiredService<IArxMessageProcessor>(),
                        sp.GetRequiredService<IOptions<TelnetOptions>>(),
                        sp.GetRequiredService<IOptions<ServerOptions>>(),
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
}
