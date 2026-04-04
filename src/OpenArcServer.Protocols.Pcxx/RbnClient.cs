using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core;
using OpenArcServer.Core.Commands;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Protocols.Pcxx;

/// <summary>
/// Connects to a Reverse Beacon Network (RBN) telnet feed, parses incoming
/// DX spots, and distributes them to connected users.
///
/// RBN uses the standard AR-Cluster telnet format:
///   DX de DK9IP-#:    14025.0  W1AW    CW  20 dB 22 WPM  CQ    1530Z
/// </summary>
public sealed class RbnClient : BackgroundService
{
    // Matches: DX de <spotter>:  <freq>  <call>  <comment>  <time>Z
    private static readonly Regex SpotRegex = new(
        @"^DX de\s+(?<spotter>\S+)\s*:\s*(?<freq>[\d.]+)\s+(?<call>\S+)\s+(?<comment>.+?)\s+(?<time>\d{4}Z)\s*$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    private readonly RbnOptions _opts;
    private readonly IServiceProvider _services;
    private readonly ILogger<RbnClient> _log;

    public RbnClient(
        IOptions<RbnOptions> opts,
        IServiceProvider services,
        ILogger<RbnClient> log)
    {
        _opts = opts.Value;
        _services = services;
        _log = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_opts.Enabled)
        {
            _log.LogInformation("RBN client is disabled");
            return;
        }

        if (string.IsNullOrWhiteSpace(_opts.Callsign))
        {
            _log.LogWarning("RBN client: Callsign not configured, cannot connect");
            return;
        }

        _log.LogInformation("RBN client starting, connecting to {Host}:{Port}", _opts.Host, _opts.Port);

        var delay = TimeSpan.FromSeconds(5);
        var maxDelay = TimeSpan.FromSeconds(_opts.ReconnectDelaySeconds > 0 ? _opts.ReconnectDelaySeconds : 30);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await ConnectAndReadAsync(stoppingToken);
                delay = TimeSpan.FromSeconds(5);
            }
            catch (OperationCanceledException) { return; }
            catch (Exception ex)
            {
                _log.LogWarning("RBN connection error: {Message}", ex.Message);
            }

            _log.LogInformation("RBN client reconnecting in {Delay}s", (int)delay.TotalSeconds);
            await Task.Delay(delay, stoppingToken).ConfigureAwait(false);
            delay = delay * 2 < maxDelay ? delay * 2 : maxDelay;
        }
    }

    private async Task ConnectAndReadAsync(CancellationToken ct)
    {
        using var client = new TcpClient();
        await client.ConnectAsync(_opts.Host, _opts.Port, ct);
        _log.LogInformation("RBN client connected to {Host}:{Port}", _opts.Host, _opts.Port);

        using var scope = _services.CreateScope();
        var sp = scope.ServiceProvider;
        var spots = sp.GetRequiredService<IDxSpotRepository>();
        var distributor = sp.GetRequiredService<IMessageDistributor>();
        var cty = sp.GetRequiredService<ICtyLookup>();
        var bandMode = sp.GetRequiredService<IBandModeLookup>();
        var dupeDetector = sp.GetRequiredService<DuplicateSpotDetector>();
        var spotOpts = sp.GetRequiredService<IOptions<SpotProcessingOptions>>().Value;

        var stream = client.GetStream();
        var enc = Encoding.UTF8;
        var partial = new StringBuilder();
        var buffer = new byte[8192];
        var loginSent = false;

        while (!ct.IsCancellationRequested)
        {
            int n;
            try { n = await stream.ReadAsync(buffer, ct); }
            catch { break; }
            if (n == 0) break;

            partial.Append(enc.GetString(buffer, 0, n));
            var text = partial.ToString();
            partial.Clear();

            // ── Pre-login: scan the entire accumulated buffer for the prompt ──────
            // RBN sends "Please enter your call: " with NO trailing newline, so it
            // will never appear as a complete \n-terminated line.  We must check the
            // raw accumulated text (both complete lines and the unterminated tail).
            if (!loginSent && text.Contains("call", StringComparison.OrdinalIgnoreCase))
            {
                var callsign = _opts.Callsign.Trim().ToUpperInvariant();
                _log.LogInformation("RBN: detected login prompt, sending callsign {Callsign}", callsign);
                var login = enc.GetBytes(callsign + "\r\n");
                await stream.WriteAsync(login, ct);
                loginSent = true;
                // Discard banner content — nothing useful in it for us
                continue;
            }

            // ── Post-login: process spot lines ────────────────────────────────────
            int start = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    var line = text[start..i].TrimEnd('\r');
                    start = i + 1;

                    if (!string.IsNullOrWhiteSpace(line) && line.StartsWith("DX de", StringComparison.OrdinalIgnoreCase))
                        await ProcessSpotLineAsync(line, spots, distributor, cty, bandMode, dupeDetector, spotOpts, ct);
                }
            }

            if (start < text.Length)
                partial.Append(text[start..]);
        }
    }

    private async Task ProcessSpotLineAsync(
        string line,
        IDxSpotRepository spots,
        IMessageDistributor distributor,
        ICtyLookup cty,
        IBandModeLookup bandMode,
        DuplicateSpotDetector dupeDetector,
        SpotProcessingOptions spotOpts,
        CancellationToken ct)
    {
        var m = SpotRegex.Match(line);
        if (!m.Success)
        {
            _log.LogDebug("RBN: could not parse spot line: {Line}", line);
            return;
        }

        var spotter = m.Groups["spotter"].Value.TrimEnd(':').ToUpperInvariant();
        var call = m.Groups["call"].Value.ToUpperInvariant();
        var comment = m.Groups["comment"].Value.Trim();

        if (!float.TryParse(m.Groups["freq"].Value,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out var freq))
            return;

        if (freq < spotOpts.MinFrequencyKhz || freq > spotOpts.MaxFrequencyKhz)
            return;

        if (comment.Length > spotOpts.MaxCommentLength)
            comment = comment[..spotOpts.MaxCommentLength];

        var bm = bandMode.LookupFrequency(freq);
        var band = bm?.Band ?? 0f;
        var mode = bm?.Mode ?? string.Empty;
        var calledCty = cty.LookupCallsign(call);
        var spotterCty = cty.LookupCallsign(spotter);

        bool isDupe = band > 0f && dupeDetector.IsDuplicate(call,
            band.ToString(System.Globalization.CultureInfo.InvariantCulture));

        var now = DateTime.UtcNow;
        var spot = new DxSpot
        {
            Call = call,
            Spotter = spotter,
            SpotterNode = "RBN",
            Skimmer = true,
            Freq = freq,
            Band = band,
            Mode = mode,
            Comment = comment,
            Cty = calledCty?.CtyCode ?? string.Empty,
            SpotterCty = spotterCty?.CtyCode ?? string.Empty,
            Cont = calledCty?.Continent ?? string.Empty,
            SpotterCont = spotterCty?.Continent ?? string.Empty,
            CqZone = (byte)(calledCty?.CqZone ?? 0),
            ItuZone = (byte)(calledCty?.ItuZone ?? 0),
            SpotterCqZone = (byte)(spotterCty?.CqZone ?? 0),
            SpotterItuZone = (byte)(spotterCty?.ItuZone ?? 0),
            DupeKey = $"{call}|{band}",
            IsDupe = isDupe,
            Timestamp = now,
            ReceivedAt = now,
        };

        await spots.InsertAsync(spot, ct);

        if (!isDupe)
        {
            var formatted = DxSpotFormatter.Format(spot);
            var response = new CommandResponse
            {
                DistroType = DistroType.ToUsers,
                MsgType = MsgType.Dx,
            };
            response.Messages.Add(formatted);

            // Use a dummy session for distribution (no sender to reply to)
            var dummySession = new Core.Sessions.UserSession
            {
                Callsign = "RBN",
                ConnectType = ConnectStateType.RcvOnly,
            };
            await distributor.DistributeAsync(response, dummySession, ct);

            _log.LogDebug("RBN spot: {Spotter} → {Call} @ {Freq} kHz [{Band}]", spotter, call, freq, band);
        }
    }
}
