using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Server.Services;

/// <summary>
/// Background service that fetches solar/geomagnetic data from NOAA Space Weather
/// Prediction Center (SWPC) on a configurable interval and posts it as automated
/// WWV reports visible to all connected users.
///
/// Endpoints used:
///   K + A index: https://services.swpc.noaa.gov/products/noaa-planetary-k-index.json
///                Array of { time_tag, Kp, a_running, station_count }
///   F10.7 SFI  : https://services.swpc.noaa.gov/json/f107_cm_flux.json
///                Array of { time_tag, frequency, flux, ... }  (newest first)
/// </summary>
public sealed class SpaceWeatherService : BackgroundService
{
    private const string KIndexUrl = "https://services.swpc.noaa.gov/products/noaa-planetary-k-index.json";
    private const string SfiUrl    = "https://services.swpc.noaa.gov/json/f107_cm_flux.json";

    private readonly SpaceWeatherOptions _opts;
    private readonly IWwvRepository _wwv;
    private readonly IConnectionManager _connections;
    private readonly ILogger<SpaceWeatherService> _log;

    private static readonly HttpClient _http = new()
    {
        Timeout = TimeSpan.FromSeconds(30),
        DefaultRequestHeaders = { { "User-Agent", "OpenArcServer/1.0 (DX Cluster; space-weather)" } },
    };

    public SpaceWeatherService(
        IOptions<SpaceWeatherOptions> opts,
        IWwvRepository wwv,
        IConnectionManager connections,
        ILogger<SpaceWeatherService> log)
    {
        _opts        = opts.Value;
        _wwv         = wwv;
        _connections = connections;
        _log         = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!_opts.Enabled)
        {
            _log.LogInformation("Space weather service is disabled");
            return;
        }

        _log.LogInformation(
            "Space weather service enabled — first fetch in {Delay} min, then every {Interval} min",
            _opts.InitialDelayMinutes, _opts.FetchIntervalMinutes);

        await Task.Delay(TimeSpan.FromMinutes(_opts.InitialDelayMinutes), stoppingToken);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                await FetchAndPostAsync(stoppingToken);
            }
            catch (OperationCanceledException) when (stoppingToken.IsCancellationRequested)
            {
                break;
            }
            catch (Exception ex)
            {
                _log.LogWarning(ex, "Space weather fetch failed — will retry next cycle");
            }

            await Task.Delay(TimeSpan.FromMinutes(_opts.FetchIntervalMinutes), stoppingToken);
        }
    }

    // ── Main fetch ────────────────────────────────────────────────────────────

    private async Task FetchAndPostAsync(CancellationToken ct)
    {
        // Run both fetches concurrently
        var kTask   = FetchKpAAsync(ct);
        var sfiTask = FetchSfiAsync(ct);
        await Task.WhenAll(kTask, sfiTask);

        var (kp, a) = kTask.Result;
        var sfi     = sfiTask.Result;

        if (sfi <= 0 && kp < 0)
        {
            _log.LogWarning("Space weather: could not retrieve usable data from NOAA — skipping post");
            return;
        }

        // Use 0 for any values we couldn't fetch rather than silently dropping
        if (sfi <= 0) sfi = 0;
        if (kp  <  0) kp  = 0;
        if (a   <  0) a   = 0;

        var now  = DateTime.UtcNow;
        var spot = new WwvSpot
        {
            Sfi         = ((int)Math.Round(sfi)).ToString(),
            A           = ((int)Math.Round(a)).ToString(),
            K           = kp.ToString("F1"),
            Forecast    = string.Empty,
            Spotter     = _opts.AutoSpotter,
            SpotterNode = string.Empty,
            Timestamp   = now,
        };

        await _wwv.InsertAsync(spot, ct);
        _log.LogInformation(
            "Space weather posted: SFI={Sfi} A={A} K={K}", spot.Sfi, spot.A, spot.K);

        // Broadcast inline to all connected telnet users
        var line = $"\r\n{FormatWwv(spot)}\r\n";
        foreach (var session in _connections.GetConnectedUsers())
        {
            if (session.SendAsync is not null)
            {
                try { await session.SendAsync(line, ct); }
                catch { /* non-fatal — user may have disconnected */ }
            }
        }
    }

    // ── NOAA fetchers ─────────────────────────────────────────────────────────

    /// <summary>
    /// Fetches the latest 3-hourly Kp and running A-index from NOAA SWPC.
    /// Endpoint: /products/noaa-planetary-k-index.json
    /// Schema:   array of { time_tag, Kp, a_running, station_count } ordered oldest→newest.
    /// Returns (-1, -1) on failure.
    /// </summary>
    private async Task<(double Kp, double A)> FetchKpAAsync(CancellationToken ct)
    {
        try
        {
            var json = await _http.GetStringAsync(KIndexUrl, ct);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            if (root.ValueKind != JsonValueKind.Array || root.GetArrayLength() == 0)
                return (-1, -1);

            // Data is ordered oldest→newest — take the last element
            var last = root[root.GetArrayLength() - 1];

            var kp = GetDouble(last, "Kp");
            var a  = GetDouble(last, "a_running");

            if (kp < 0)
            {
                _log.LogWarning("Space weather: Kp field missing or non-numeric in NOAA response");
                return (-1, -1);
            }

            return (kp, a);
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "Space weather: K/A-index fetch failed");
            return (-1, -1);
        }
    }

    /// <summary>
    /// Fetches the latest F10.7 cm solar flux from NOAA SWPC.
    /// Endpoint: /json/f107_cm_flux.json
    /// Schema:   array of { time_tag, frequency, flux, ... } ordered newest→oldest.
    /// Returns -1 on failure.
    /// </summary>
    private async Task<double> FetchSfiAsync(CancellationToken ct)
    {
        try
        {
            var json = await _http.GetStringAsync(SfiUrl, ct);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            if (root.ValueKind != JsonValueKind.Array || root.GetArrayLength() == 0)
                return -1;

            // Newest entry is first — find the first with a positive flux value
            foreach (var item in root.EnumerateArray())
            {
                var flux = GetDouble(item, "flux");
                if (flux > 0) return flux;
            }

            _log.LogWarning("Space weather: no usable flux value in NOAA SFI response");
            return -1;
        }
        catch (Exception ex)
        {
            _log.LogWarning(ex, "Space weather: SFI fetch failed");
            return -1;
        }
    }

    // ── Helpers ───────────────────────────────────────────────────────────────

    /// <summary>Reads a JSON property as double regardless of whether it's stored as number or string.</summary>
    private static double GetDouble(JsonElement el, string property)
    {
        if (!el.TryGetProperty(property, out var prop)) return -1;
        if (prop.ValueKind == JsonValueKind.Number && prop.TryGetDouble(out var d)) return d;
        if (prop.ValueKind == JsonValueKind.String && double.TryParse(prop.GetString(),
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture, out var s)) return s;
        return -1;
    }

    private static string FormatWwv(WwvSpot s)
    {
        var date     = s.Timestamp.ToString("dd-MMM-yyyy").ToUpper();
        var time     = s.Timestamp.ToString("HHmm") + "Z";
        var forecast = string.IsNullOrWhiteSpace(s.Forecast) ? string.Empty : $", {s.Forecast}";
        var body     = $"WWV de {s.Spotter,-10} <{date}>: SFI={s.Sfi}, A={s.A}, K={s.K}{forecast}";
        return $"{body,-72}{time}";
    }
}
