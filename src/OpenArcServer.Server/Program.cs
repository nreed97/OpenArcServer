using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
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
using OpenArcServer.Protocols.WebSocket;
using OpenArcServer.Server.Services;
using Prometheus;
using Serilog;

// Bootstrap Serilog early so startup errors are captured
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    // Pin content root to the binary's directory so appsettings.json is found
    // regardless of which directory `dotnet run` is invoked from.
    var builder = WebApplication.CreateBuilder(new WebApplicationOptions
    {
        Args = args,
        ContentRootPath = AppContext.BaseDirectory,
        WebRootPath     = Path.Combine(AppContext.BaseDirectory, "wwwroot"),
    });

    // Service integration (systemd, Windows Service, launchd)
    builder.Host.UseSystemd();
    builder.Host.UseWindowsService(opts => opts.ServiceName = "OpenArcServer");

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
    builder.Services.Configure<OpenArcServer.Core.Configuration.WebSocketOptions>(builder.Configuration.GetSection("WebSocket"));
    builder.Services.Configure<ApiOptions>(builder.Configuration.GetSection("Api"));
    builder.Services.Configure<RateLimitOptions>(builder.Configuration.GetSection("RateLimit"));
    builder.Services.Configure<SpaceWeatherOptions>(builder.Configuration.GetSection("SpaceWeather"));

    // Data layer
    builder.Services.AddSingleton<DatabaseInitializer>();
    builder.Services.AddSingleton<IDxSpotRepository, SqliteDxSpotRepository>();
    builder.Services.AddSingleton<IUserRepository, SqliteUserRepository>();
    builder.Services.AddSingleton<IWwvRepository, SqliteWwvRepository>();
    builder.Services.AddSingleton<IWxRepository, SqliteWxRepository>();
    builder.Services.AddSingleton<IBuddyRepository, SqliteBuddyRepository>();

    // File-based lookups — registered as concrete types (for reload) + interface aliases
    builder.Services.AddSingleton<CtyDatParser>(sp =>
    {
        var opts = sp.GetRequiredService<IOptions<DataFileOptions>>().Value;
        return new CtyDatParser(opts.CtyDatPath);
    });
    builder.Services.AddSingleton<ICtyLookup>(sp => sp.GetRequiredService<CtyDatParser>());

    builder.Services.AddSingleton<BandModeParser>(sp =>
    {
        var opts = sp.GetRequiredService<IOptions<DataFileOptions>>().Value;
        return new BandModeParser(opts.BandModePath);
    });
    builder.Services.AddSingleton<IBandModeLookup>(sp => sp.GetRequiredService<BandModeParser>());

    // Named filter lists — concrete type for reload + keyed interface for injection
    builder.Services.AddKeyedSingleton<FilterListParser>("badwords", (sp, _) =>
    {
        var opts = sp.GetRequiredService<IOptions<DataFileOptions>>().Value;
        return new FilterListParser(opts.BadWordPath);
    });
    builder.Services.AddKeyedSingleton<IFilterList>("badwords",
        (sp, _) => (IFilterList)sp.GetRequiredKeyedService<FilterListParser>("badwords"));

    builder.Services.AddKeyedSingleton<FilterListParser>("callblock", (sp, _) =>
    {
        var opts = sp.GetRequiredService<IOptions<DataFileOptions>>().Value;
        return new FilterListParser(opts.CallBlockPath);
    });
    builder.Services.AddKeyedSingleton<IFilterList>("callblock",
        (sp, _) => (IFilterList)sp.GetRequiredKeyedService<FilterListParser>("callblock"));

    builder.Services.AddKeyedSingleton<FilterListParser>("connectblock", (sp, _) =>
    {
        var opts = sp.GetRequiredService<IOptions<DataFileOptions>>().Value;
        return new FilterListParser(opts.ConnectBlockPath);
    });
    builder.Services.AddKeyedSingleton<IFilterList>("connectblock",
        (sp, _) => (IFilterList)sp.GetRequiredKeyedService<FilterListParser>("connectblock"));

    builder.Services.AddKeyedSingleton<FilterListParser>("spotblock", (sp, _) =>
    {
        var opts = sp.GetRequiredService<IOptions<DataFileOptions>>().Value;
        return new FilterListParser(opts.DxSpotBlockPath);
    });
    builder.Services.AddKeyedSingleton<IFilterList>("spotblock",
        (sp, _) => (IFilterList)sp.GetRequiredKeyedService<FilterListParser>("spotblock"));

    // Engine
    builder.Services.AddSingleton<DuplicateSpotDetector>();
    builder.Services.AddSingleton<IConnectionManager, ConnectionManager>();
    builder.Services.AddSingleton<INodeManager, NodeManager>();
    builder.Services.AddSingleton<IArxClientRegistry, ArxClientRegistry>();
    builder.Services.AddSingleton<IArxMessageProcessor, ArxMessageProcessor>();
    builder.Services.AddSingleton<IWebSocketClientRegistry, WebSocketClientRegistry>();
    builder.Services.AddSingleton<IMessageDistributor, MessageDistributor>();
    builder.Services.AddSingleton<BuddyAlertService>();

    // Commands (must be registered before ICommandRouter so router factory can resolve them)
    builder.Services.AddSingleton<DxSpotCommand>(sp => new DxSpotCommand(
        sp.GetRequiredService<IDxSpotRepository>(),
        sp.GetRequiredService<ICtyLookup>(),
        sp.GetRequiredService<IBandModeLookup>(),
        sp.GetRequiredKeyedService<IFilterList>("spotblock"),
        sp.GetRequiredKeyedService<IFilterList>("badwords"),
        sp.GetRequiredService<DuplicateSpotDetector>(),
        sp.GetRequiredService<IOptions<SpotProcessingOptions>>(),
        sp.GetRequiredService<Microsoft.Extensions.Logging.ILogger<DxSpotCommand>>()));
    builder.Services.AddSingleton<ShowDxCommand>();
    builder.Services.AddSingleton<ShowUsersCommand>();
    builder.Services.AddSingleton<ShowNodesCommand>();
    builder.Services.AddSingleton<ShowConnectCommand>();
    builder.Services.AddSingleton<ShowVersionCommand>();
    builder.Services.AddSingleton<ShowTimeCommand>();
    builder.Services.AddSingleton<ByeCommand>();
    builder.Services.AddSingleton<HelpCommand>();
    // DX filter commands
    builder.Services.AddSingleton<SetDxBandCommand>();
    builder.Services.AddSingleton<SetDxNoBandCommand>();
    builder.Services.AddSingleton<SetDxModeCommand>();
    builder.Services.AddSingleton<SetDxNoModeCommand>();
    builder.Services.AddSingleton<SetDxContCommand>();
    builder.Services.AddSingleton<SetDxNoContCommand>();
    builder.Services.AddSingleton<SetDxCqCommand>();
    builder.Services.AddSingleton<SetDxNoCqCommand>();
    builder.Services.AddSingleton<ShowFilterCommand>();
    // WWV/WX commands
    builder.Services.AddSingleton<WwvCommand>();
    builder.Services.AddSingleton<ShowWwvCommand>();
    builder.Services.AddSingleton<WxCommand>();
    builder.Services.AddSingleton<ShowWxCommand>();
    // Talk / Announce
    builder.Services.AddSingleton<TalkCommand>();
    builder.Services.AddSingleton<AnnounceCommand>();
    // SET profile commands
    builder.Services.AddSingleton<SetNameCommand>();
    builder.Services.AddSingleton<SetQthCommand>();
    builder.Services.AddSingleton<SetGridCommand>();
    builder.Services.AddSingleton<SetEmailCommand>();
    builder.Services.AddSingleton<SetDxCountCommand>();
    builder.Services.AddSingleton<ShowStationCommand>();
    // Skimmer / RBN toggles
    builder.Services.AddSingleton<SetSkimmerCommand>();
    builder.Services.AddSingleton<SetNoSkimmerCommand>();
    builder.Services.AddSingleton<SetRbnCommand>();
    builder.Services.AddSingleton<SetNoRbnCommand>();
    // Buddy list
    builder.Services.AddSingleton<AddBuddyCommand>();
    builder.Services.AddSingleton<DelBuddyCommand>();
    builder.Services.AddSingleton<ShowBuddyCommand>();
    // Test spot (local only, not propagated)
    builder.Services.AddSingleton<TestDxCommand>();

    builder.Services.AddSingleton<ICommandRouter>(sp =>
    {
        var router = new CommandRouter();
        router.Register("DX",             sp.GetRequiredService<DxSpotCommand>());
        router.Register("SH DX",          sp.GetRequiredService<ShowDxCommand>());
        router.Register("SH U",           sp.GetRequiredService<ShowUsersCommand>());
        router.Register("SH N",           sp.GetRequiredService<ShowNodesCommand>());
        router.Register("SH CONNECT",     sp.GetRequiredService<ShowConnectCommand>());
        router.Register("SH VERSION",     sp.GetRequiredService<ShowVersionCommand>());
        router.Register("SH TIME",        sp.GetRequiredService<ShowTimeCommand>());
        router.Register("BYE",            sp.GetRequiredService<ByeCommand>());
        router.Register("HELP",           sp.GetRequiredService<HelpCommand>());
        // DX spot filters
        router.Register("SET DX BAND",    sp.GetRequiredService<SetDxBandCommand>());
        router.Register("SET DX NOBAND",  sp.GetRequiredService<SetDxNoBandCommand>());
        router.Register("SET DX MODE",    sp.GetRequiredService<SetDxModeCommand>());
        router.Register("SET DX NOMODE",  sp.GetRequiredService<SetDxNoModeCommand>());
        router.Register("SET DX CONT",    sp.GetRequiredService<SetDxContCommand>());
        router.Register("SET DX NOCONT",  sp.GetRequiredService<SetDxNoContCommand>());
        router.Register("SET DX CQ",      sp.GetRequiredService<SetDxCqCommand>());
        router.Register("SET DX NOCQ",    sp.GetRequiredService<SetDxNoCqCommand>());
        router.Register("SH FILTER",      sp.GetRequiredService<ShowFilterCommand>());
        // WWV / WX
        router.Register("WWV",            sp.GetRequiredService<WwvCommand>());
        router.Register("SH WWV",         sp.GetRequiredService<ShowWwvCommand>());
        router.Register("WX",             sp.GetRequiredService<WxCommand>());
        router.Register("SH WX",          sp.GetRequiredService<ShowWxCommand>());
        // Talk / Announce
        router.Register("TALK",           sp.GetRequiredService<TalkCommand>());
        router.Register("ANN",            sp.GetRequiredService<AnnounceCommand>());
        // SET profile commands
        router.Register("SET NAME",       sp.GetRequiredService<SetNameCommand>());
        router.Register("SET QTH",        sp.GetRequiredService<SetQthCommand>());
        router.Register("SET GRID",       sp.GetRequiredService<SetGridCommand>());
        router.Register("SET EMAIL",      sp.GetRequiredService<SetEmailCommand>());
        router.Register("SET DXCOUNT",    sp.GetRequiredService<SetDxCountCommand>());
        router.Register("SH STA",         sp.GetRequiredService<ShowStationCommand>());
        // Skimmer / RBN toggles
        router.Register("SET SKIMMER",    sp.GetRequiredService<SetSkimmerCommand>());
        router.Register("SET NOSKIMMER",  sp.GetRequiredService<SetNoSkimmerCommand>());
        router.Register("SET RBN",        sp.GetRequiredService<SetRbnCommand>());
        router.Register("SET NORBN",      sp.GetRequiredService<SetNoRbnCommand>());
        // Buddy list
        router.Register("ADD BUDDY",      sp.GetRequiredService<AddBuddyCommand>());
        router.Register("DEL BUDDY",      sp.GetRequiredService<DelBuddyCommand>());
        router.Register("SH BUDDY",       sp.GetRequiredService<ShowBuddyCommand>());
        // Test spot
        router.Register("TEST DX",        sp.GetRequiredService<TestDxCommand>());
        return router;
    });

    // Telnet server
    builder.Services.AddHostedService<TelnetServer>();

    // ARx2 native client server (port 3608) + outbound peer connector
    builder.Services.AddHostedService<ArxServer>();
    builder.Services.AddHostedService<ArxOutboundConnector>();

    // PCxx node server (inbound) + outbound connector + RBN
    builder.Services.AddHostedService<PcxxServer>();
    builder.Services.AddHostedService<PcxxOutboundConnector>();
    builder.Services.AddHostedService<RbnClient>();

    // WebSocket server
    builder.Services.AddHostedService<WebSocketServer>();

    // Background maintenance
    builder.Services.AddHostedService<MaintenanceService>();

    // Automated space weather (NOAA SWPC → WWV posts)
    builder.Services.AddHostedService<SpaceWeatherService>();

    // Configure Kestrel to bind on the Api port
    builder.WebHost.ConfigureKestrel((ctx, opts) =>
    {
        var apiOpts = ctx.Configuration.GetSection("Api").Get<ApiOptions>() ?? new ApiOptions();
        if (apiOpts.Enabled)
        {
            var addr = apiOpts.BindAddress == "0.0.0.0"
                ? System.Net.IPAddress.Any
                : System.Net.IPAddress.Parse(apiOpts.BindAddress);
            opts.Listen(addr, apiOpts.Port);
        }
    });

    builder.Services.AddCors(o => o.AddDefaultPolicy(p =>
        p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

    var app = builder.Build();

    // Initialize database before starting
    app.Services.GetRequiredService<DatabaseInitializer>().Initialize();

    app.UseCors();

    // ── Static files (admin dashboard from wwwroot/) ──────────────────────
    app.UseDefaultFiles();
    app.UseStaticFiles();

    // ── Prometheus metrics ────────────────────────────────────────────────
    app.UseMetricServer("/metrics");

    // ── REST API ──────────────────────────────────────────────────────────
    var api = app.MapGroup("/api");

    // GET /api/spots[?count=N]
    api.MapGet("/spots", async (
        IDxSpotRepository spots,
        int count = 20) =>
    {
        count = Math.Clamp(count, 1, 500);
        var list = await spots.GetRecentAsync(count);
        return Results.Ok(list);
    });

    // GET /api/users  — only actual human users, not inter-node sessions
    api.MapGet("/users", (IConnectionManager connections) =>
    {
        var users = connections.GetConnectedUsers()
            .Where(s => s.ConnectType is not ConnectStateType.PcxxNode
                                      and not ConnectStateType.ArxNode)
            .Select(s => new
            {
                callsign    = s.Callsign,
                name        = s.Name,
                qth         = s.Qth,
                grid        = s.Grid,
                connectedAt = s.ConnectedAt,
                connectType = s.ConnectType.ToString(),
            });
        return Results.Ok(users);
    });

    // GET /api/nodes
    api.MapGet("/nodes", (INodeManager nodes) =>
    {
        var list = nodes.GetConnectedNodes().Select(n => new
        {
            callsign          = n.Callsign,
            software          = n.Software,
            version           = n.Version,
            remoteEndpoint    = n.RemoteEndpoint,
            connectedAt       = n.ConnectedAt,
            lastSeenAt        = n.LastSeenAt,
            handshakeComplete = n.HandshakeComplete,
            spotsReceived     = n.SpotsReceived,
            spotsSent         = n.SpotsSent,
            lastSpotAt        = n.LastSpotAt,
        });
        return Results.Ok(list);
    });

    // GET /api/wwv[?count=N]
    api.MapGet("/wwv", async (IWwvRepository wwv, int count = 5) =>
    {
        count = Math.Clamp(count, 1, 50);
        var list = await wwv.GetRecentAsync(count);
        return Results.Ok(list);
    });

    // GET /api/wx[?count=N]
    api.MapGet("/wx", async (IWxRepository wx, int count = 5) =>
    {
        count = Math.Clamp(count, 1, 50);
        var list = await wx.GetRecentAsync(count);
        return Results.Ok(list);
    });

    // GET /api/stats
    api.MapGet("/stats", async (
        IConnectionManager connections,
        INodeManager nodes,
        IWebSocketClientRegistry wsClients,
        IDxSpotRepository spots) =>
    {
        var spotCount = await spots.CountAsync();
        return Results.Ok(new
        {
            connectedUsers      = connections.Count,
            connectedNodes      = nodes.Count,
            connectedWsClients  = wsClients.Count,
            totalSpotsInDb      = spotCount,
            serverTime          = DateTime.UtcNow.ToString("O"),
        });
    });

    // ── Admin endpoints (require X-Admin-Key header) ──────────────────────
    var admin = app.MapGroup("/api/admin");

    // POST /api/admin/announce  { "message": "..." }
    admin.MapPost("/announce", async (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IConnectionManager connections,
        IMessageDistributor distributor,
        AdminAnnounceRequest req) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        if (string.IsNullOrWhiteSpace(req.Message)) return Results.BadRequest("message required");

        var text = $"To ALL de SYSOP   : {req.Message,-39} {DateTime.UtcNow:HHmm}Z\r\n";
        var response = new OpenArcServer.Core.Commands.CommandResponse
        {
            DistroType = OpenArcServer.Core.DistroType.ToAll,
        };
        response.Messages.Add(text.TrimEnd('\r', '\n'));
        // Broadcast via a dummy system session
        var sysop = new OpenArcServer.Core.Sessions.UserSession
        {
            Callsign = "SYSOP",
        };
        await distributor.DistributeAsync(response, sysop, http.RequestAborted);
        return Results.Ok(new { sent = true });
    });

    // DELETE /api/admin/users/{callsign}
    admin.MapDelete("/users/{callsign}", (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IConnectionManager connections,
        string callsign) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        var session = connections.FindByCallsign(callsign.ToUpperInvariant());
        if (session is null) return Results.NotFound(new { error = $"{callsign} not connected" });
        session.SendAsync?.Invoke("*** You have been disconnected by the sysop. ***\r\n", CancellationToken.None);
        connections.RemoveSession(session.SessionId);
        return Results.Ok(new { disconnected = callsign.ToUpperInvariant() });
    });

    // POST /api/admin/restart  — gracefully stop the process (systemd/Windows Service restarts it)
    admin.MapPost("/restart", (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IHostApplicationLifetime lifetime) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        // Schedule stop slightly after response is sent
        _ = Task.Run(async () =>
        {
            await Task.Delay(500);
            lifetime.StopApplication();
        });
        return Results.Ok(new { restarting = true, note = "Server is stopping. It will restart automatically if running under systemd or Windows Service." });
    });

    // GET /api/admin/settings  — return current appsettings.json from disk
    // Reading from disk (not IOptions) ensures: (a) values match what was last saved,
    // (b) keys keep their original PascalCase so the JS form can populate correctly,
    // (c) changes saved from another device are reflected immediately.
    var settingsPath = Path.Combine(app.Environment.ContentRootPath, "appsettings.json");

    admin.MapGet("/settings", async (
        HttpContext http,
        IOptions<ApiOptions> apiOpts) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        try
        {
            var text = await File.ReadAllTextAsync(settingsPath, http.RequestAborted);
            var root = JsonNode.Parse(text) as JsonObject;
            if (root is null) return Results.Problem("Could not parse settings file");
            // Never send key material to the browser
            root["Api"]?.AsObject()?.Remove("AdminKey");
            root["Api"]?.AsObject()?.Remove("AdminKeyHash");
            return Results.Ok(root);
        }
        catch (Exception ex)
        {
            return Results.Problem($"Could not read settings file: {ex.Message}");
        }
    });

    // PUT /api/admin/settings  — merge body into appsettings.json and save
    admin.MapPut("/settings", async (HttpContext http, IOptions<ApiOptions> apiOpts) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();

        JsonNode? body;
        try { body = await JsonNode.ParseAsync(http.Request.Body); }
        catch { return Results.BadRequest(new { error = "Invalid JSON body" }); }
        if (body is null) return Results.BadRequest(new { error = "Empty body" });

        // Read current appsettings.json
        JsonNode root;
        try
        {
            var existing = await File.ReadAllTextAsync(settingsPath, http.RequestAborted);
            root = JsonNode.Parse(existing) ?? new JsonObject();
        }
        catch { root = new JsonObject(); }

        // Merge each top-level section present in the body into the root document
        if (body is JsonObject bodyObj)
        {
            foreach (var (key, value) in bodyObj)
            {
                if (value is JsonObject section && root[key] is JsonObject existing)
                {
                    // Merge: only update keys present in the submitted section
                    foreach (var (k, v) in section)
                        existing[k] = v?.DeepClone();
                }
                else
                {
                    root[key] = value?.DeepClone();
                }
            }
        }

        try
        {
            var json = root.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(settingsPath, json, http.RequestAborted);
        }
        catch (Exception ex)
        {
            return Results.Problem($"Could not write settings file: {ex.Message}");
        }

        return Results.Ok(new { saved = true, note = "Restart the server for changes to take effect." });
    });

    // GET /api/admin/peers  — list all ARx and PCxx peers with their enabled state
    admin.MapGet("/peers", (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IOptions<ArxServerOptions> arxOpts,
        IOptions<PcxxOptions> pcxxOpts) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        return Results.Ok(new
        {
            arx  = arxOpts.Value.Peers.Select((p, i) => new
                   { index = i, host = p.Host, port = p.Port, label = p.Label, enabled = p.Enabled }),
            pcxx = pcxxOpts.Value.Peers.Select((p, i) => new
                   { index = i, host = p.Host, port = p.Port, label = p.Label, enabled = p.Enabled }),
        });
    });

    // PATCH /api/admin/peers/{type}/{index}/enabled  — toggle a peer without saving full settings
    admin.MapPatch("/peers/{type}/{index}/enabled", async (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        string type,
        int index) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();

        JsonNode? body;
        try { body = await JsonNode.ParseAsync(http.Request.Body); }
        catch { return Results.BadRequest(new { error = "Expected JSON body: {\"enabled\": true/false}" }); }

        var enabled = body?["enabled"]?.GetValue<bool>();
        if (enabled is null) return Results.BadRequest(new { error = "Missing 'enabled' field" });

        type = type.ToLowerInvariant();
        if (type is not ("arx" or "pcxx"))
            return Results.BadRequest(new { error = "type must be 'arx' or 'pcxx'" });

        // Read, patch, write appsettings.json
        JsonNode root;
        try
        {
            var existing = await File.ReadAllTextAsync(settingsPath, http.RequestAborted);
            root = JsonNode.Parse(existing) ?? new JsonObject();
        }
        catch { return Results.Problem("Could not read settings file"); }

        var section = type == "arx" ? "Arx" : "Pcxx";
        var peers = root[section]?["Peers"]?.AsArray();
        if (peers is null || index < 0 || index >= peers.Count)
            return Results.NotFound(new { error = $"Peer index {index} not found in {section}" });

        var peer = peers[index];
        if (peer is JsonObject peerObj)
        {
            peerObj["Enabled"] = enabled.Value;
        }
        else if (peer is JsonValue strVal && strVal.TryGetValue<string>(out var hostPort))
        {
            // Was stored as plain "host:port" string — upgrade to object form
            var parts = hostPort.LastIndexOf(':') is int c && c > 0
                ? new JsonObject { ["Host"] = hostPort[..c], ["Port"] = int.Parse(hostPort[(c+1)..]), ["Enabled"] = enabled.Value }
                : new JsonObject { ["Host"] = hostPort, ["Port"] = type == "arx" ? 3608 : 7300, ["Enabled"] = enabled.Value };
            peers[index] = parts;
        }

        try
        {
            var json = root.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(settingsPath, json, http.RequestAborted);
        }
        catch (Exception ex)
        {
            return Results.Problem($"Could not write settings file: {ex.Message}");
        }

        return Results.Ok(new { type, index, enabled = enabled.Value });
    });

    // GET /api/admin/logs?lines=N  — tail the current Serilog rolling log file
    admin.MapGet("/logs", async (
        HttpContext http,
        IOptions<ApiOptions> apiOpts) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();

        var linesParam = http.Request.Query["lines"].FirstOrDefault();
        var count = int.TryParse(linesParam, out var n) ? Math.Clamp(n, 10, 2000) : 300;

        var logDir = Path.Combine(app.Environment.ContentRootPath, "logs");
        if (!Directory.Exists(logDir))
            return Results.Ok(new { file = (string?)null, lines = Array.Empty<string>() });

        // Serilog names files openarcserver20260407.log — pick the newest
        var latest = Directory.GetFiles(logDir, "openarcserver*.log")
            .OrderByDescending(f => f)
            .FirstOrDefault();

        if (latest is null)
            return Results.Ok(new { file = (string?)null, lines = Array.Empty<string>() });

        try
        {
            // Read with FileShare.ReadWrite so the open log file isn't locked
            string[] allLines;
            await using (var fs = new FileStream(latest, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(fs))
                allLines = (await sr.ReadToEndAsync(http.RequestAborted)).Split('\n');

            var tail = allLines
                .Where(l => l.Length > 0)
                .TakeLast(count)
                .ToArray();

            return Results.Ok(new { file = Path.GetFileName(latest), lines = tail });
        }
        catch (Exception ex)
        {
            return Results.Problem($"Could not read log file: {ex.Message}");
        }
    });

    // GET /api/admin/motd  — read the MOTD file
    admin.MapGet("/motd", async (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IOptions<ServerOptions> srvOpts) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        var motdPath = srvOpts.Value.MotdFile;
        if (!Path.IsPathRooted(motdPath))
            motdPath = Path.Combine(app.Environment.ContentRootPath, motdPath);
        try
        {
            var text = File.Exists(motdPath) ? await File.ReadAllTextAsync(motdPath, http.RequestAborted) : "";
            return Results.Ok(new { content = text });
        }
        catch (Exception ex) { return Results.Problem($"Could not read MOTD file: {ex.Message}"); }
    });

    // PUT /api/admin/motd  — write the MOTD file
    admin.MapPut("/motd", async (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IOptions<ServerOptions> srvOpts) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        JsonNode? body;
        try { body = await JsonNode.ParseAsync(http.Request.Body); }
        catch { return Results.BadRequest(new { error = "Invalid JSON body" }); }
        var content = body?["content"]?.GetValue<string>() ?? "";

        var motdPath = srvOpts.Value.MotdFile;
        if (!Path.IsPathRooted(motdPath))
            motdPath = Path.Combine(app.Environment.ContentRootPath, motdPath);
        try
        {
            var dir = Path.GetDirectoryName(motdPath);
            if (!string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);
            await File.WriteAllTextAsync(motdPath, content, http.RequestAborted);
            return Results.Ok(new { saved = true });
        }
        catch (Exception ex) { return Results.Problem($"Could not write MOTD file: {ex.Message}"); }
    });

    // GET /api/admin/filters/{name}  — name: badwords | callblock | connectblock | spotblock
    admin.MapGet("/filters/{name}", async (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IOptions<DataFileOptions> dataOpts,
        string name) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        var df = dataOpts.Value;
        var path = name.ToLowerInvariant() switch
        {
            "badwords"     => df.BadWordPath,
            "callblock"    => df.CallBlockPath,
            "connectblock" => df.ConnectBlockPath,
            "spotblock"    => df.DxSpotBlockPath,
            _              => null,
        };
        if (path is null) return Results.NotFound(new { error = $"Unknown filter '{name}'. Valid: badwords, callblock, connectblock, spotblock" });
        if (!Path.IsPathRooted(path))
            path = Path.Combine(app.Environment.ContentRootPath, path);
        try
        {
            var text = File.Exists(path) ? await File.ReadAllTextAsync(path, http.RequestAborted) : "";
            return Results.Ok(new { name, content = text });
        }
        catch (Exception ex) { return Results.Problem($"Could not read filter file: {ex.Message}"); }
    });

    // POST /api/admin/reload  — reload data files from disk without restarting
    admin.MapPost("/reload", (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IServiceProvider sp,
        ILogger<Program> logger) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();

        var df = sp.GetRequiredService<IOptions<DataFileOptions>>().Value;

        sp.GetRequiredService<CtyDatParser>().Reload();
        sp.GetRequiredService<BandModeParser>().Reload();
        sp.GetRequiredKeyedService<FilterListParser>("badwords").Reload();
        sp.GetRequiredKeyedService<FilterListParser>("callblock").Reload();
        sp.GetRequiredKeyedService<FilterListParser>("connectblock").Reload();
        sp.GetRequiredKeyedService<FilterListParser>("spotblock").Reload();

        logger.LogInformation("Data files reloaded via admin API");
        return Results.Ok(new { reloaded = true, files = new[]
        {
            df.CtyDatPath, df.BandModePath,
            df.BadWordPath, df.CallBlockPath, df.ConnectBlockPath, df.DxSpotBlockPath,
        }});
    });

    // POST /api/admin/keyhash  { "key": "yourpassword" }  — returns SHA-256 hex to paste into AdminKeyHash
    admin.MapPost("/keyhash", async (HttpContext http, IOptions<ApiOptions> apiOpts) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        JsonNode? body;
        try { body = await JsonNode.ParseAsync(http.Request.Body); }
        catch { return Results.BadRequest(new { error = "Invalid JSON body" }); }
        var key = body?["key"]?.GetValue<string>() ?? "";
        if (string.IsNullOrEmpty(key)) return Results.BadRequest(new { error = "key required" });
        var hash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(key))).ToLowerInvariant();
        return Results.Ok(new { hash, note = "Paste this value into appsettings.json Api.AdminKeyHash and remove Api.AdminKey" });
    });

    // PUT /api/admin/filters/{name}  — overwrite a filter file
    admin.MapPut("/filters/{name}", async (
        HttpContext http,
        IOptions<ApiOptions> apiOpts,
        IOptions<DataFileOptions> dataOpts,
        string name) =>
    {
        if (!IsAdminAuthorized(http, apiOpts.Value)) return Results.Unauthorized();
        var df = dataOpts.Value;
        var path = name.ToLowerInvariant() switch
        {
            "badwords"     => df.BadWordPath,
            "callblock"    => df.CallBlockPath,
            "connectblock" => df.ConnectBlockPath,
            "spotblock"    => df.DxSpotBlockPath,
            _              => null,
        };
        if (path is null) return Results.NotFound(new { error = $"Unknown filter '{name}'." });
        if (!Path.IsPathRooted(path))
            path = Path.Combine(app.Environment.ContentRootPath, path);
        JsonNode? body;
        try { body = await JsonNode.ParseAsync(http.Request.Body); }
        catch { return Results.BadRequest(new { error = "Invalid JSON body" }); }
        var content = body?["content"]?.GetValue<string>() ?? "";
        try
        {
            var dir = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(dir)) Directory.CreateDirectory(dir);
            await File.WriteAllTextAsync(path, content, http.RequestAborted);
            return Results.Ok(new { saved = true, name });
        }
        catch (Exception ex) { return Results.Problem($"Could not write filter file: {ex.Message}"); }
    });

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

// ── Helpers ───────────────────────────────────────────────────────────────

/// <summary>
/// Validates the X-Admin-Key request header.
/// Prefers AdminKeyHash (SHA-256 hex); falls back to plaintext AdminKey for migration.
/// Returns false (disabled) if neither is configured.
/// </summary>
static bool IsAdminAuthorized(HttpContext http, ApiOptions opts)
{
    http.Request.Headers.TryGetValue("X-Admin-Key", out var provided);
    var key = provided.ToString();
    if (string.IsNullOrEmpty(key)) return false;

    // Preferred path: compare SHA-256 hash of the supplied key
    if (!string.IsNullOrEmpty(opts.AdminKeyHash))
    {
        var hash = Convert.ToHexString(
            SHA256.HashData(Encoding.UTF8.GetBytes(key))).ToLowerInvariant();
        return hash == opts.AdminKeyHash.ToLowerInvariant();
    }

    // Legacy fallback: plaintext comparison (set AdminKeyHash in production)
    return !string.IsNullOrEmpty(opts.AdminKey) && key == opts.AdminKey;
}

// ── Request DTOs ──────────────────────────────────────────────────────────
record AdminAnnounceRequest(string Message);
