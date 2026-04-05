using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Security.Cryptography;
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

/// <summary>
/// WebSocket server built on a raw <see cref="TcpListener"/> with a manual
/// RFC 6455 opening handshake.  Unlike <see cref="System.Net.HttpListener"/>
/// this requires no Windows HTTP.sys URL ACL reservation and works under any
/// user account.
/// </summary>
public sealed class WebSocketServer : BackgroundService
{
    // Magic GUID defined by RFC 6455
    private const string WsGuid = "258EAFA5-E914-47DA-95CA-C5AB0DC85B11";

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

        var bindAddr = _opts.BindAddress == "0.0.0.0"
            ? IPAddress.Any
            : IPAddress.Parse(_opts.BindAddress);

        var listener = new TcpListener(bindAddr, _opts.Port);
        listener.Start();
        _log.LogInformation("WebSocket server listening on {BindAddress}:{Port}", _opts.BindAddress, _opts.Port);

        // Stop the listener when the host shuts down
        stoppingToken.Register(() => listener.Stop());

        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                TcpClient client;
                try { client = await listener.AcceptTcpClientAsync(stoppingToken); }
                catch (OperationCanceledException) { break; }
                catch (Exception ex) { _log.LogError(ex, "WS accept error"); continue; }

                _ = Task.Run(() => HandleClientAsync(client, stoppingToken), stoppingToken);
            }
        }
        finally
        {
            try { listener.Stop(); } catch { }
            _log.LogInformation("WebSocket server stopped");
        }
    }

    // ── RFC 6455 opening handshake ────────────────────────────────────────

    private async Task HandleClientAsync(TcpClient tcp, CancellationToken ct)
    {
        var endpoint = tcp.Client.RemoteEndPoint?.ToString() ?? "unknown";
        System.Net.WebSockets.WebSocket? ws = null;

        try
        {
            tcp.NoDelay = true;
            var stream = tcp.GetStream();

            // 1. Read HTTP upgrade request (until \r\n\r\n)
            string? wsKey = await ReadUpgradeRequestAsync(stream, ct);
            if (wsKey is null)
            {
                _log.LogDebug("WS: non-WebSocket or malformed HTTP request from {Endpoint}", endpoint);
                var bad = "HTTP/1.1 400 Bad Request\r\nContent-Length: 0\r\nConnection: close\r\n\r\n"u8.ToArray();
                await stream.WriteAsync(bad, ct);
                return;
            }

            // 2. Compute Sec-WebSocket-Accept
            var accept = ComputeAcceptKey(wsKey);

            // 3. Send 101 Switching Protocols
            var response = Encoding.ASCII.GetBytes(
                "HTTP/1.1 101 Switching Protocols\r\n" +
                "Upgrade: websocket\r\n" +
                "Connection: Upgrade\r\n" +
                $"Sec-WebSocket-Accept: {accept}\r\n" +
                "\r\n");
            await stream.WriteAsync(response, ct);

            // 4. Wrap stream in a managed WebSocket
            ws = System.Net.WebSockets.WebSocket.CreateFromStream(
                stream, isServer: true, subProtocol: null,
                keepAliveInterval: TimeSpan.FromSeconds(30));

            await HandleWebSocketAsync(ws, endpoint, ct);
        }
        catch (OperationCanceledException) { }
        catch (Exception ex) { _log.LogWarning(ex, "WS error from {Endpoint}", endpoint); }
        finally
        {
            try { ws?.Dispose(); } catch { }
            try { tcp.Dispose(); } catch { }
        }
    }

    /// <summary>
    /// Reads the HTTP upgrade headers and returns the Sec-WebSocket-Key value,
    /// or null if the request is not a valid WebSocket upgrade.
    /// </summary>
    private static async Task<string?> ReadUpgradeRequestAsync(NetworkStream stream, CancellationToken ct)
    {
        // Read bytes until we see the end-of-headers marker \r\n\r\n
        var buf  = new byte[4096];
        var recv = new StringBuilder();
        while (true)
        {
            var n = await stream.ReadAsync(buf, ct);
            if (n == 0) return null;
            recv.Append(Encoding.ASCII.GetString(buf, 0, n));
            if (recv.ToString().Contains("\r\n\r\n")) break;
            if (recv.Length > 8192) return null; // guard against oversized headers
        }

        var headers = recv.ToString();

        // Must be an Upgrade: websocket request
        if (!headers.Contains("Upgrade: websocket", StringComparison.OrdinalIgnoreCase) &&
            !headers.Contains("Upgrade:websocket",  StringComparison.OrdinalIgnoreCase))
            return null;

        // Extract Sec-WebSocket-Key
        foreach (var line in headers.Split("\r\n"))
        {
            if (line.StartsWith("Sec-WebSocket-Key:", StringComparison.OrdinalIgnoreCase))
                return line["Sec-WebSocket-Key:".Length..].Trim();
        }
        return null;
    }

    private static string ComputeAcceptKey(string clientKey)
    {
        var combined = clientKey + WsGuid;
        var hash     = SHA1.HashData(Encoding.ASCII.GetBytes(combined));
        return Convert.ToBase64String(hash);
    }

    // ── Authenticated client session ──────────────────────────────────────

    private async Task HandleWebSocketAsync(System.Net.WebSockets.WebSocket ws, string endpoint, CancellationToken ct)
    {
        _log.LogInformation("WebSocket connection from {Endpoint}", endpoint);

        // Wait for auth message (30 s timeout).
        // Accepts two forms:
        //   {"type":"auth","callsign":"W1AW"}   — operator, gets filtered spots
        //   {"type":"monitor"}                  — read-only dashboard, gets all spots
        string? callsign = null;
        bool    isMonitor = false;
        try
        {
            using var authCts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            using var linked  = CancellationTokenSource.CreateLinkedTokenSource(ct, authCts.Token);
            var msg = await ReceiveJsonAsync(ws, linked.Token);
            if (msg?.TryGetProperty("type", out var typeEl) == true)
            {
                var msgType = typeEl.GetString();
                if (msgType == "auth" && msg.Value.TryGetProperty("callsign", out var callEl))
                {
                    var c = callEl.GetString()?.Trim().ToUpperInvariant();
                    if (!string.IsNullOrWhiteSpace(c)) callsign = c;
                }
                else if (msgType == "monitor")
                {
                    callsign  = "MONITOR";
                    isMonitor = true;
                }
            }
        }
        catch { }

        if (callsign is null)
        {
            await SendJsonAsync(ws, new { type = "error", message = "Send {\"type\":\"auth\",\"callsign\":\"W1AW\"} or {\"type\":\"monitor\"}" }, ct);
            try { await ws.CloseAsync(WebSocketCloseStatus.PolicyViolation, "Auth required", ct); } catch { }
            return;
        }

        var session = new UserSession
        {
            Callsign        = callsign,
            RemoteEndpoint  = endpoint,
            ConnectType     = ConnectStateType.WebSocketUser,
            ConnectionState = ConnectionState.Connected,
            // Monitor sessions receive everything; operator sessions start with skimmer off
            ReceiveSkimmer  = isMonitor,
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
        }
    }

    // ── WebSocket framing helpers ─────────────────────────────────────────

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

    private static bool IsValidIdentifier(string? cs)
    {
        if (string.IsNullOrWhiteSpace(cs) || cs.Length < 2 || cs.Length > 20) return false;
        return System.Text.RegularExpressions.Regex.IsMatch(cs, @"^[A-Z0-9/_\-]+$");
    }
}
