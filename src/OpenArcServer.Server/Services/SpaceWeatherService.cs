using System.Text.Json;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;
using OpenArcServer.Core.Sessions;

namespace OpenArcServer.Server.Services;

/// <summary>
/// Background service that fetches solar/geomagnetic data from NOAA Space Weather
/// Prediction Center (SWPC) on a configurable interval and posts it as automated
/// WWV reports visible to all connected users.
///
/// Data sources used:
///   K-index : https://services.swpc.noaa.gov/json/planetary_k_index_1m.json
///   F10.7   : https://services.swpc.noaa.gov/json/f107_cm_flux.json
/// </summary>
public sealed class SpaceWeatherService : BackgroundService
{
    private const string KIndexUrl  = "https://services.swpc.noaa.gov/json/planetary_k_index_1m.json";
    private const string SfiUrl     = "https://services.swpc.noaa.gov/json/f107_cm_flux.json";

    private readonly SpaceWeatherOptions _opts;
    private readonly IWwvRepository _wwv;
    private readonly IConnectionManager _connections;
    private readonly ILogger<SpaceWeatherService> _log;

    private static readonly HttpClient _http = new()
    {
        Timeout = TimeSpan.FromSeconds(30),
        DefaultRequestHeaders = { { "User-Agent", "OpenArcServer/1.0 (DX Cluster)" } },
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

        // Initial delay so the server fully starts before the first HTTP call
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

    private async Task FetchAndPostAsync(CancellationToken ct)
    {
        var (kIndex, aIndex) = await FetchKIndexAsync(ct);
        var sfi              = await FetchSfiAsync(ct);

        if (sfi <= 0 && kIndex < 0)
        {
            _log.LogWarning("Space weather: could not retrieve usable data from NOAA — skipping post");
            return;
        }

        // Use 0 for any values we couldn't fetch
        if (sfi   <= 0) sfi   = 0;
        if (kIndex < 0) kIndex = 0;
        if (aIndex < 0) aIndex = 0;

        var now  = DateTime.UtcNow;
        var spot = new WwvSpot
        {
            Sfi        = sfi.ToString(),
            A          = aIndex.ToString(),
            K          = kIndex.ToString("F1"),
            Forecast   = string.Empty,
            Spotter    = _opts.AutoSpotter,
            SpotterNode = string.Empty,
            Timestamp  = now,
        };

        await _wwv.InsertAsync(spot, ct);
        _log.LogInformation(
            "Space weather posted: SFI={Sfi} A={A} K={K}", spot.Sfi, spot.A, spot.K);

        // Format and broadcast to all connected telnet users
        var formatted = FormatWwv(spot);
        var line = $"\r\n{formatted}\r\n";

        foreach (var session in _connections.GetConnectedUsers())
        {
            if (session.SendAsync is not null)
            {
                try { await session.SendAsync(line, ct); }
                catch { /* non-fatal — user may have disconnected */ }
            }
        }
    }

    // ── NOAA data fetchers ────────────────────────────────────────────────────

    /// <summary>
    /// Fetches the latest planetary K-index and running A-index from NOAA SWPC.
    /// The JSON format is an array of arrays; the first row is a header.
    /// Columns: [time_tag, Kp, Kp_fraction, a_running, station_count]
    /// Returns (-1, -1) on failure.
    /// </summary>
    private async Task<(double KIndex, double AIndex)> FetchKIndexAsync(CancellationToken ct)
    {
        try
        {
            var json = await _http.GetStringAsync(KIndexUrl, ct);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            if (root.ValueKind != JsonValueKind.Array || root.GetArrayLength() < 2)
                return (-1, -1);

            // Skip header row (index 0), take the last data row
            JsonElement? lastRow = null;
            foreach (var row in root.EnumerateArray())
            {
                // Header row has string values; data rows have mixed types
                if (row.ValueKind == JsonValueKind.Array && row.GetArrayLength() >= 4)
                {
                    var first = row[0];
                    if (first.ValueKind == JsonValueKind.String &&
                        first.GetString() != "time_tag")
                    {
                        lastRow = row;
                    }
                }
            }

            if (lastRow is null) return (-1, -1);

            var row2 = lastRow.Value;
            // Kp may be a number or string depending on NOAA endpoint version
            double kp = row2[1].ValueKind == JsonValueKind.Number
                ? row2[1].GetDouble()
                : double.TryParse(row2[1].GetString(), out var kpStr) ? kpStr : -1;

            double a = row2[3].ValueKind == JsonValueKind.Number
                ? row2[3].GetDouble()
                : double.TryParse(row2[3].GetString(), out var aStr) ? aStr : -1;

            return (kp, a);
        }
        catch (Exception ex)
        {
            _log.LogDebug(ex, "K-index fetch failed");
            return (-1, -1);
        }
    }

    /// <summary>
    /// Fetches the latest F10.7 cm solar flux index from NOAA SWPC.
    /// The JSON format is an array of arrays; the first row is a header.
    /// Columns: [time_tag, flux, flux_adjusted]  (approximate — NOAA format varies)
    /// Returns -1 on failure.
    /// </summary>
    private async Task<double> FetchSfiAsync(CancellationToken ct)
    {
        try
        {
            var json = await _http.GetStringAsync(SfiUrl, ct);
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            if (root.ValueKind != JsonValueKind.Array || root.GetArrayLength() < 2)
                return -1;

            // Take the last data row that has a numeric second element
            double result = -1;
            foreach (var row in root.EnumerateArray())
            {
                if (row.ValueKind != JsonValueKind.Array || row.GetArrayLength() < 2) continue;
                var first = row[0];
                if (first.ValueKind == JsonValueKind.String &&
                    first.GetString() == "time_tag") continue; // header

                var val = row[1];
                double flux = val.ValueKind == JsonValueKind.Number
                    ? val.GetDouble()
                    : double.TryParse(val.GetString(), out var s) ? s : -1;

                if (flux > 0) result = flux;
            }

            return result;
        }
        catch (Exception ex)
        {
            _log.LogDebug(ex, "SFI fetch failed");
            return -1;
        }
    }

    // ── Formatting ────────────────────────────────────────────────────────────

    private static string FormatWwv(WwvSpot s)
    {
        var date     = s.Timestamp.ToString("dd-MMM-yyyy").ToUpper();
        var time     = s.Timestamp.ToString("HHmm") + "Z";
        var forecast = string.IsNullOrWhiteSpace(s.Forecast) ? string.Empty : $", {s.Forecast}";
        var body     = $"WWV de {s.Spotter,-10} <{date}>: SFI={s.Sfi}, A={s.A}, K={s.K}{forecast}";
        return $"{body,-72}{time}";
    }
}
