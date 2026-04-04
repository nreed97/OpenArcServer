using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using OpenArcServer.Engine.Commands;

namespace OpenArcServer.Protocols.WebSocket;

public sealed class WebSocketServer : BackgroundService
{
    private readonly WebSocketOptions _opts;
    private readonly ServerOptions _serverOpts;
    private readonly IConnectionManager _connections;
    private readonly IWebSocketClientRegistry _registry;
    private readonly ICommandRouter _router;
    private readonly IMessageDistributor _distributor;
    private readonly BuddyAlertService _buddyAlerts;
    private readonly ILogger<WebSocketServer> _log;

    public WebSocketServer(
        IOptions<WebSocketOptions> opts,
        IOptions<ServerOptions> serverOpts,
        IConnectionManager connections,
        IWebSocketClientRegistry registry,
        ICommandRouter router,
        IMessageDistributor distributor,
        BuddyAlertService buddyAlerts,
        ILogger<WebSocketServer> log)
    {
        _opts        = opts.Value;
        _serverOpts  = serverOpts.Value;
        _connections = connections;
        _registry    = registry;
        _router      = router;
        _distributor = distributor;
        _buddyAlerts = buddyAlerts;
        _log         = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_opts.Enabled) { _log.LogInformation("WebSocket server is disabled"); return; }

        var listener = new HttpListener();
        // Use * for HttpListener to bind to all interfaces (0.0.0.0 doesn't work directly)
        var bindHost = _opts.BindAddress == "0.0.0.0" ? "*" : _opts.BindAddress;
        listener.Prefixes.Add($"http://{bindHost}:{_opts.Port}/ws/");
        listener.Start();
        _log.LogInformation("WebSocket server listening on {BindAddress}:{Port}/ws/", _opts.BindAddress, _opts.Port);

        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                HttpListenerContext ctx;
                try { ctx = await listener.GetContextAsync().WaitAsync(stoppingToken); }
                catch (OperationCanceledException) { break; }
                catch (Exception ex) { _log.LogError(ex, "WS accept error"); continue; }

                if (!ctx.Request.IsWebSocketRequest)
                {
                    ctx.Response.StatusCode = 400;
                    ctx.Response.Close();
                    continue;
                }

                _ = Task.Run(() => HandleClientAsync(ctx, stoppingToken), stoppingToken);
            }
        }
        finally
        {
            listener.Stop();
            _log.LogInformation("WebSocket server stopped");
        }
    }

    private async Task HandleClientAsync(HttpListenerContext httpCtx, CancellationToken ct)
    {
        var endpoint = httpCtx.Request.RemoteEndPoint?.ToString() ?? "unknown";
        System.Net.WebSockets.WebSocket ws;
        try
        {
            var wsCtx = await httpCtx.AcceptWebSocketAsync(null);
            ws = wsCtx.WebSocket;
        }
        catch (Exception ex) { _log.LogWarning(ex, "WS handshake failed from {Endpoint}", endpoint); return; }

        _log.LogInformation("WebSocket connection from {Endpoint}", endpoint);

        // Step 1: Wait for auth message
        string? callsign = null;
        try
        {
            using var authCts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            using var linked  = CancellationTokenSource.CreateLinkedTokenSource(ct, authCts.Token);
            var msg = await ReceiveJsonAsync(ws, linked.Token);
            if (msg?.TryGetProperty("type", out var typeEl) == true &&
                typeEl.GetString() == "auth" &&
                msg.Value.TryGetProperty("callsign", out var callEl))
            {
                var c = callEl.GetString()?.ToUpperInvariant();
                if (IsValidCallsign(c)) callsign = c;
            }
        }
        catch { }

        if (callsign is null)
        {
            await SendJsonAsync(ws, new { type = "error", message = "Authentication required. Send {\"type\":\"auth\",\"callsign\":\"W1AW\"}" }, ct);
            try { await ws.CloseAsync(WebSocketCloseStatus.PolicyViolation, "Auth required", ct); } catch { }
            return;
        }

        var session = new UserSession
        {
            Callsign        = callsign,
            RemoteEndpoint  = endpoint,
            ConnectType     = ConnectStateType.WebSocketUser,
            ConnectionState = ConnectionState.Connected,
        };

        session.SendAsync = async (text, token) =>
        {
            if (ws.State != WebSocketState.Open) return;
            var bytes = Encoding.UTF8.GetBytes(text);
            await ws.SendAsync(bytes, WebSocketMessageType.Text, true, token);
        };

        session.DisconnectAsync = async () =>
        {
            try { await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "Bye", CancellationToken.None); }
            catch { }
        };

        _connections.AddSession(session);
        _registry.Register(session);
        _log.LogInformation("{Callsign} connected via WebSocket from {Endpoint}", callsign, endpoint);

        var welcome = JsonSerializer.Serialize(new
        {
            type         = "welcome",
            nodeCallsign = _serverOpts.NodeCallsign,
            serverName   = _serverOpts.ServerName,
            callsign     = callsign,
        });
        await session.SendAsync(welcome, ct);

        _ = Task.Run(() => _buddyAlerts.NotifyConnectedAsync(callsign, ct), ct);

        try
        {
            while (!ct.IsCancellationRequested && ws.State == WebSocketState.Open)
            {
                var msg = await ReceiveJsonAsync(ws, ct);
                if (msg is null) break;

                if (msg.Value.TryGetProperty("type", out var tEl) && tEl.GetString() == "command" &&
                    msg.Value.TryGetProperty("text", out var textEl))
                {
                    var line = textEl.GetString() ?? string.Empty;
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var request = CommandRequest.Parse(line);
                        var context = new CommandContext { Session = session, Request = request };
                        var command = _router.Resolve(request.CommandKey);
                        if (command is not null)
                        {
                            await command.ExecuteAsync(context, ct);
                            await _distributor.DistributeAsync(context.Response, session, ct);
                        }
                        else
                        {
                            await session.SendAsync($"Unknown command: {request.CommandKey}\r\n", ct);
                        }
                    }
                }
            }
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) { _log.LogWarning(ex, "WS error for {Callsign}", callsign); }
        finally
        {
            try { await _buddyAlerts.NotifyDisconnectedAsync(callsign, ct); } catch { }
            _connections.RemoveSession(session.SessionId);
            _registry.Unregister(session.SessionId);
            _log.LogInformation("{Callsign} disconnected from WebSocket", callsign);
            try { ws.Dispose(); } catch { }
        }
    }

    private static async Task<JsonElement?> ReceiveJsonAsync(System.Net.WebSockets.WebSocket ws, CancellationToken ct)
    {
        var buffer = new byte[8192];
        using var ms = new System.IO.MemoryStream();
        WebSocketReceiveResult result;
        do
        {
            result = await ws.ReceiveAsync(buffer, ct);
            if (result.MessageType == WebSocketMessageType.Close) return null;
            ms.Write(buffer, 0, result.Count);
        } while (!result.EndOfMessage);

        ms.Position = 0;
        try
        {
            using var doc = await JsonDocument.ParseAsync(ms, cancellationToken: ct);
            return doc.RootElement.Clone();
        }
        catch { return null; }
    }

    private static async Task SendJsonAsync(System.Net.WebSockets.WebSocket ws, object payload, CancellationToken ct)
    {
        var json  = JsonSerializer.Serialize(payload);
        var bytes = Encoding.UTF8.GetBytes(json);
        await ws.SendAsync(bytes, WebSocketMessageType.Text, true, ct);
    }

    private static bool IsValidCallsign(string? cs)
    {
        if (string.IsNullOrWhiteSpace(cs) || cs.Length < 3 || cs.Length > 12) return false;
        return System.Text.RegularExpressions.Regex.IsMatch(cs,
            @"^[A-Z0-9]{1,3}[0-9][A-Z0-9]{0,3}[A-Z](-[0-9]{1,2})?$");
    }
}
