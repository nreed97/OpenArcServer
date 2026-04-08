using System.Buffers;
using System.IO.Pipelines;
using System.Net.Sockets;
using System.Text;
using System.Threading.RateLimiting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;
using OpenArcServer.Engine.Commands;
using OpenArcServer.Protocols.Arx;

namespace OpenArcServer.Protocols.Telnet;

public sealed class TelnetClientConnection
{
    private readonly TcpClient _client;
    private readonly IConnectionManager _connections;
    private readonly ICommandRouter _router;
    private readonly IMessageDistributor _distributor;
    private readonly IUserRepository _users;
    private readonly IFilterList _connectBlock;
    private readonly IArxMessageProcessor _arxProcessor;
    private readonly BuddyAlertService _buddyAlerts;
    private readonly IWwvRepository _wwv;
    private readonly TelnetOptions _opts;
    private readonly ServerOptions _serverOpts;
    private readonly ILogger<TelnetClientConnection> _log;
    private readonly SlidingWindowRateLimiter? _rateLimiter;

    private static readonly Encoding _enc = Encoding.UTF8;

    public TelnetClientConnection(
        TcpClient client,
        IConnectionManager connections,
        ICommandRouter router,
        IMessageDistributor distributor,
        IUserRepository users,
        IWwvRepository wwv,
        IFilterList connectBlock,
        IArxMessageProcessor arxProcessor,
        BuddyAlertService buddyAlerts,
        IOptions<TelnetOptions> opts,
        IOptions<ServerOptions> serverOpts,
        IOptions<RateLimitOptions> rateLimitOpts,
        ILogger<TelnetClientConnection> log)
    {
        _client       = client;
        _connections  = connections;
        _router       = router;
        _distributor  = distributor;
        _users        = users;
        _wwv          = wwv;
        _connectBlock = connectBlock;
        _arxProcessor = arxProcessor;
        _buddyAlerts  = buddyAlerts;
        _opts         = opts.Value;
        _serverOpts   = serverOpts.Value;
        _log          = log;

        var rl = rateLimitOpts.Value;
        if (rl.Enabled && rl.MaxCommandsPerMinute > 0)
        {
            _rateLimiter = new SlidingWindowRateLimiter(new SlidingWindowRateLimiterOptions
            {
                PermitLimit          = rl.MaxCommandsPerMinute,
                Window               = TimeSpan.FromMinutes(1),
                SegmentsPerWindow    = 6,   // 10-second buckets
                QueueProcessingOrder = QueueProcessingOrder.NewestFirst,
                QueueLimit           = 0,
                AutoReplenishment    = true,
            });
        }
    }

    public async Task HandleAsync(CancellationToken ct)
    {
        var endpoint = _client.Client.RemoteEndPoint?.ToString() ?? "unknown";
        _log.LogInformation("New connection from {Endpoint}", endpoint);

        var session = new UserSession
        {
            RemoteEndpoint  = endpoint,
            ConnectionState = ConnectionState.Idle,
        };

        var stream = _client.GetStream();
        var cts = CancellationTokenSource.CreateLinkedTokenSource(ct);

        session.SendAsync = async (text, token) =>
        {
            var bytes = _enc.GetBytes(text);
            await stream.WriteAsync(bytes, token);
        };

        session.DisconnectAsync = async () =>
        {
            await cts.CancelAsync();
        };

        var pipe = new Pipe();

        var writing = FillPipeAsync(stream, pipe.Writer, cts.Token);
        var reading = ReadPipeAsync(pipe.Reader, session, cts.Token);

        try
        {
            await session.SendAsync(_opts.IntroMessage, cts.Token);
            session.ConnectionState = ConnectionState.CallsignRequest;

            await Task.WhenAll(writing, reading);
        }
        catch (OperationCanceledException) { }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "Connection error from {Endpoint}", endpoint);
        }
        finally
        {
            _rateLimiter?.Dispose();

            if (!string.IsNullOrEmpty(session.Callsign))
            {
                // Fire buddy disconnect alerts before removing from session list
                try { await _buddyAlerts.NotifyDisconnectedAsync(session.Callsign, ct); }
                catch { /* non-fatal */ }

                _connections.RemoveSession(session.SessionId);
                _log.LogInformation("{Callsign} disconnected from {Endpoint}", session.Callsign, endpoint);

                try
                {
                    var profile = await _users.GetOrCreateAsync(session.Callsign, ct);
                    profile.LastSeen = DateTime.UtcNow;
                    await _users.UpdateAsync(profile, ct);
                }
                catch (Exception ex)
                {
                    _log.LogWarning(ex, "Failed to update last-seen for {Callsign}", session.Callsign);
                }
            }
            cts.Dispose();
            _client.Dispose();
        }
    }

    // ── Pipe fill ─────────────────────────────────────────────────────────

    private static async Task FillPipeAsync(NetworkStream stream, PipeWriter writer, CancellationToken ct)
    {
        const int bufferSize = 4096;
        while (!ct.IsCancellationRequested)
        {
            var memory = writer.GetMemory(bufferSize);
            try
            {
                int bytesRead = await stream.ReadAsync(memory, ct);
                if (bytesRead == 0) break;
                writer.Advance(bytesRead);
            }
            catch { break; }

            var result = await writer.FlushAsync(ct);
            if (result.IsCompleted) break;
        }
        await writer.CompleteAsync();
    }

    // ── Pipe read — handles both plain-text lines and [Arx2] frames ───────

    private async Task ReadPipeAsync(PipeReader reader, UserSession session, CancellationToken ct)
    {
        while (!ct.IsCancellationRequested)
        {
            ReadResult result;
            try { result = await reader.ReadAsync(ct); }
            catch { break; }

            var buffer   = result.Buffer;
            var consumed = buffer.Start;
            var examined = buffer.End;

            bool progress = true;
            while (progress && !ct.IsCancellationRequested)
            {
                progress = false;

                // Check for [Arx2] frame (AR-Cluster client may post spots via ARx2 on port 7373)
                if (TryPeekArxFrame(buffer))
                {
                    var bytes = buffer.ToArray();
                    var xml   = ArxFrame.TryExtract(bytes, out int arxConsumed);

                    if (xml is not null)
                    {
                        buffer   = buffer.Slice(arxConsumed);
                        consumed = buffer.Start;
                        progress = true;
                        await _arxProcessor.ProcessAsync(session, xml, ct);
                        continue;
                    }

                    // Frame header present but frame incomplete — wait for more data
                    examined = buffer.End;
                    break;
                }

                // Fall through to plain-text line reading
                if (TryReadLine(ref buffer, out var line))
                {
                    consumed = buffer.Start;
                    progress = true;
                    await ProcessLineAsync(session, line, ct);
                }
            }

            reader.AdvanceTo(consumed, examined);
            if (result.IsCompleted) break;
        }
        await reader.CompleteAsync();
    }

    /// <summary>Returns true if the buffer starts with the [Arx2] frame opener.</summary>
    private static bool TryPeekArxFrame(ReadOnlySequence<byte> buffer)
    {
        if (buffer.Length < 6) return false;
        Span<byte> peek = stackalloc byte[6];
        buffer.Slice(0, 6).CopyTo(peek);
        return ArxFrame.StartsWithFrame(peek);
    }

    // ── Plain-text line reading ───────────────────────────────────────────

    private static bool TryReadLine(ref ReadOnlySequence<byte> buffer, out string line)
    {
        var reader = new SequenceReader<byte>(buffer);
        if (reader.TryReadTo(out ReadOnlySequence<byte> lineSeq, (byte)'\n'))
        {
            var bytes = lineSeq.ToArray();
            int len = bytes.Length;

            // Strip trailing CR/LF
            while (len > 0 && (bytes[len - 1] == '\r' || bytes[len - 1] == '\n'))
                len--;

            // Strip telnet IAC sequences (RFC 854) and ASCII control characters.
            int cleanLen = 0;
            int i = 0;
            while (i < len)
            {
                byte b = bytes[i];
                if (b == 0xFF) // IAC — skip 2 or 3-byte sequence
                {
                    i++;
                    if (i < len)
                    {
                        byte cmd = bytes[i++];
                        if (cmd >= 251 && cmd <= 254 && i < len)
                            i++; // skip option byte for WILL/WONT/DO/DONT
                    }
                }
                else if (b >= 32)
                {
                    bytes[cleanLen++] = b;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            line   = Encoding.UTF8.GetString(bytes, 0, cleanLen);
            buffer = buffer.Slice(reader.Position);
            return true;
        }
        line = string.Empty;
        return false;
    }

    private async Task ProcessLineAsync(UserSession session, string line, CancellationToken ct)
    {
        session.LastActivityAt = DateTime.UtcNow;

        switch (session.ConnectionState)
        {
            case ConnectionState.CallsignRequest:
                await HandleCallsignAsync(session, line.Trim().ToUpperInvariant(), ct);
                break;

            case ConnectionState.Connected:
                await HandleCommandAsync(session, line, ct);
                break;
        }
    }

    // ── Login ─────────────────────────────────────────────────────────────

    private async Task HandleCallsignAsync(UserSession session, string callsign, CancellationToken ct)
    {
        if (!IsValidCallsign(callsign))
        {
            await session.SendAsync!(_opts.InvalidCallsignMessage, ct);
            return;
        }

        if (_connectBlock.IsBlocked(callsign))
        {
            await session.SendAsync!(_opts.BlockedMessage + "\r\n", ct);
            session.DisconnectAsync?.Invoke();
            return;
        }

        if (_connections.Count >= _opts.MaxConnections)
        {
            await session.SendAsync!("Sorry, the server is full. Please try again later.\r\n", ct);
            session.DisconnectAsync?.Invoke();
            return;
        }

        session.Callsign        = callsign;
        session.ConnectionState = ConnectionState.Connected;

        var profile = await _users.GetOrCreateAsync(callsign, ct);
        profile.TotalConnects++;
        profile.LastSeen = DateTime.UtcNow;
        await _users.UpdateAsync(profile, ct);

        // Restore persisted profile fields so they survive server restarts
        session.Name    = profile.Name;
        session.Qth     = profile.Qth;
        session.Grid    = profile.Grid;
        session.Email   = profile.Email;
        session.DxCount = profile.DxCount;

        _connections.AddSession(session);
        _log.LogInformation("{Callsign} connected from {Endpoint}", callsign, session.RemoteEndpoint);

        var welcome = _opts.WelcomeMessage
            .Replace("{Callsign}", callsign)
            .Replace("{NodeCallsign}", _serverOpts.NodeCallsign);

        await session.SendAsync!(welcome, ct);

        var motdPath = _serverOpts.MotdFile;
        if (File.Exists(motdPath))
        {
            var motd = await File.ReadAllTextAsync(motdPath, ct);
            if (!string.IsNullOrWhiteSpace(motd))
                await session.SendAsync!(motd.Replace("\n", "\r\n"), ct);
        }

        // Show latest propagation report (WWV) so operators know band conditions on login
        try
        {
            var wwvList = await _wwv.GetRecentAsync(1, ct);
            if (wwvList.Count > 0)
            {
                var w = wwvList[0];
                var date = w.Timestamp.ToString("dd-MMM-yyyy").ToUpper();
                var time = w.Timestamp.ToString("HHmm") + "Z";
                var forecast = string.IsNullOrWhiteSpace(w.Forecast) ? string.Empty : $", {w.Forecast}";
                var body = $"WWV de {w.Spotter,-10} <{date}>: SFI={w.Sfi}, A={w.A}, K={w.K}{forecast}";
                await session.SendAsync!($"{body,-72}{time}\r\n", ct);
            }
        }
        catch { /* non-fatal */ }

        // Fire buddy connect alerts to online users who have this callsign on their list
        _ = Task.Run(() => _buddyAlerts.NotifyConnectedAsync(callsign, ct), ct);
    }

    // ── Command dispatch ──────────────────────────────────────────────────

    private async Task HandleCommandAsync(UserSession session, string line, CancellationToken ct)
    {
        if (string.IsNullOrWhiteSpace(line)) return;

        // Per-user command rate limiting
        if (_rateLimiter is not null)
        {
            using var lease = _rateLimiter.AttemptAcquire();
            if (!lease.IsAcquired)
            {
                await session.SendAsync!("*** Too many commands — please slow down. ***\r\n", ct);
                return;
            }
        }

        var request = CommandRequest.Parse(line);
        var context = new CommandContext { Session = session, Request = request };

        var command = _router.Resolve(request.CommandKey);
        if (command is null)
        {
            await session.SendAsync!($"Unknown command: {request.CommandKey}\r\n", ct);
            return;
        }

        await command.ExecuteAsync(context, ct);
        await _distributor.DistributeAsync(context.Response, session, ct);
    }

    private static bool IsValidCallsign(string callsign)
    {
        if (string.IsNullOrWhiteSpace(callsign) || callsign.Length < 3 || callsign.Length > 12)
            return false;

        return System.Text.RegularExpressions.Regex.IsMatch(callsign,
            @"^[A-Z0-9]{1,3}[0-9][A-Z0-9]{0,3}[A-Z](-[0-9]{1,2})?$");
    }
}
