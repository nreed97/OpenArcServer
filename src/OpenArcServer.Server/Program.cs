using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Data;
using OpenArcServer.Data.Parsers;
using OpenArcServer.Data.Repositories;
using OpenArcServer.Engine.Commands;
using OpenArcServer.Engine.Distribution;
using OpenArcServer.Engine.Routing;
using OpenArcServer.Engine.Spots;
using OpenArcServer.Protocols.Arx;
using OpenArcServer.Protocols.Pcxx;
using OpenArcServer.Protocols.Telnet;
using OpenArcServer.Server.Services;
using Serilog;

// Bootstrap Serilog early so startup errors are captured
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    var builder = Host.CreateApplicationBuilder(args);

    // Serilog
    builder.Services.AddSerilog((services, lc) => lc
        .MinimumLevel.Information()
        .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
        .MinimumLevel.Override("System", Serilog.Events.LogEventLevel.Warning)
        .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}")
        .WriteTo.File("logs/openarcserver.log",
            rollingInterval: RollingInterval.Day,
            retainedFileCountLimit: 7));

    // Configuration
    builder.Services.Configure<ServerOptions>(builder.Configuration.GetSection("Server"));
    builder.Services.Configure<TelnetOptions>(builder.Configuration.GetSection("Telnet"));
    builder.Services.Configure<DatabaseOptions>(builder.Configuration.GetSection("Database"));
    builder.Services.Configure<DataFileOptions>(builder.Configuration.GetSection("DataFiles"));
    builder.Services.Configure<SpotProcessingOptions>(builder.Configuration.GetSection("SpotProcessing"));
    builder.Services.Configure<PcxxOptions>(builder.Configuration.GetSection("Pcxx"));
    builder.Services.Configure<RbnOptions>(builder.Configuration.GetSection("Rbn"));
    builder.Services.Configure<ArxServerOptions>(builder.Configuration.GetSection("Arx"));

    // Data layer
    builder.Services.AddSingleton<DatabaseInitializer>();
    builder.Services.AddSingleton<IDxSpotRepository, SqliteDxSpotRepository>();
    builder.Services.AddSingleton<IUserRepository, SqliteUserRepository>();

    // File-based lookups (registered as singletons, path resolved at startup)
    builder.Services.AddSingleton<ICtyLookup>(sp =>
    {
        var opts = sp.GetRequiredService<Microsoft.Extensions.Options.IOptions<DataFileOptions>>().Value;
        return new CtyDatParser(opts.CtyDatPath);
    });
    builder.Services.AddSingleton<IBandModeLookup>(sp =>
    {
        var opts = sp.GetRequiredService<Microsoft.Extensions.Options.IOptions<DataFileOptions>>().Value;
        return new BandModeParser(opts.BandModePath);
    });

    // Named filter lists — register as keyed services
    builder.Services.AddKeyedSingleton<IFilterList>("badwords", (sp, _) =>
    {
        var opts = sp.GetRequiredService<Microsoft.Extensions.Options.IOptions<DataFileOptions>>().Value;
        return (IFilterList)new FilterListParser(opts.BadWordPath);
    });
    builder.Services.AddKeyedSingleton<IFilterList>("callblock", (sp, _) =>
    {
        var opts = sp.GetRequiredService<Microsoft.Extensions.Options.IOptions<DataFileOptions>>().Value;
        return (IFilterList)new FilterListParser(opts.CallBlockPath);
    });
    builder.Services.AddKeyedSingleton<IFilterList>("connectblock", (sp, _) =>
    {
        var opts = sp.GetRequiredService<Microsoft.Extensions.Options.IOptions<DataFileOptions>>().Value;
        return (IFilterList)new FilterListParser(opts.ConnectBlockPath);
    });
    builder.Services.AddKeyedSingleton<IFilterList>("spotblock", (sp, _) =>
    {
        var opts = sp.GetRequiredService<Microsoft.Extensions.Options.IOptions<DataFileOptions>>().Value;
        return (IFilterList)new FilterListParser(opts.DxSpotBlockPath);
    });

    // Engine
    builder.Services.AddSingleton<DuplicateSpotDetector>();
    builder.Services.AddSingleton<IConnectionManager, ConnectionManager>();
    builder.Services.AddSingleton<INodeManager, NodeManager>();
    builder.Services.AddSingleton<IArxClientRegistry, ArxClientRegistry>();
    builder.Services.AddSingleton<IArxMessageProcessor, ArxMessageProcessor>();
    builder.Services.AddSingleton<IMessageDistributor, MessageDistributor>();

    // Commands (must be registered before ICommandRouter so router factory can resolve them)
    builder.Services.AddSingleton<DxSpotCommand>(sp => new DxSpotCommand(
        sp.GetRequiredService<IDxSpotRepository>(),
        sp.GetRequiredService<ICtyLookup>(),
        sp.GetRequiredService<IBandModeLookup>(),
        sp.GetRequiredKeyedService<IFilterList>("spotblock"),
        sp.GetRequiredKeyedService<IFilterList>("badwords"),
        sp.GetRequiredService<DuplicateSpotDetector>(),
        sp.GetRequiredService<Microsoft.Extensions.Options.IOptions<SpotProcessingOptions>>(),
        sp.GetRequiredService<Microsoft.Extensions.Logging.ILogger<DxSpotCommand>>()));
    builder.Services.AddSingleton<ShowDxCommand>();
    builder.Services.AddSingleton<ShowUsersCommand>();
    builder.Services.AddSingleton<ShowNodesCommand>();
    builder.Services.AddSingleton<ShowVersionCommand>();
    builder.Services.AddSingleton<ShowTimeCommand>();
    builder.Services.AddSingleton<ByeCommand>();
    builder.Services.AddSingleton<HelpCommand>();

    builder.Services.AddSingleton<ICommandRouter>(sp =>
    {
        var router = new CommandRouter();
        router.Register("DX",          sp.GetRequiredService<DxSpotCommand>());
        router.Register("SH DX",       sp.GetRequiredService<ShowDxCommand>());
        router.Register("SH U",        sp.GetRequiredService<ShowUsersCommand>());
        router.Register("SH N",        sp.GetRequiredService<ShowNodesCommand>());
        router.Register("SH VERSION",  sp.GetRequiredService<ShowVersionCommand>());
        router.Register("SH TIME",     sp.GetRequiredService<ShowTimeCommand>());
        router.Register("BYE",         sp.GetRequiredService<ByeCommand>());
        router.Register("HELP",        sp.GetRequiredService<HelpCommand>());
        return router;
    });

    // Telnet server
    builder.Services.AddHostedService<TelnetServer>();

    // ARx2 native client server (port 3608)
    builder.Services.AddHostedService<ArxServer>();

    // PCxx node server (inbound) + outbound connector + RBN
    builder.Services.AddHostedService<PcxxServer>();
    builder.Services.AddHostedService<PcxxOutboundConnector>();
    builder.Services.AddHostedService<RbnClient>();

    // Background maintenance
    builder.Services.AddHostedService<MaintenanceService>();

    var app = builder.Build();

    // Initialize database before starting
    app.Services.GetRequiredService<DatabaseInitializer>().Initialize();

    await app.RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Server terminated unexpectedly");
    return 1;
}
finally
{
    await Log.CloseAndFlushAsync();
}

return 0;
