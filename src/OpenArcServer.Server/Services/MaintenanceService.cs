using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Spots;
using Prometheus;


namespace OpenArcServer.Server.Services;

public sealed class MaintenanceService : BackgroundService
{
    private static readonly Gauge DbSpotsTotal = Metrics.CreateGauge(
        "openarcserver_db_spots_total",
        "Total DX spots currently stored in the database");

    private readonly IDxSpotRepository _spots;
    private readonly IUserRepository _users;
    private readonly IWwvRepository _wwv;
    private readonly IWxRepository _wx;
    private readonly IConnectionManager _connections;
    private readonly DuplicateSpotDetector _dupeDetector;
    private readonly DatabaseOptions _dbOpts;
    private readonly TelnetOptions _telnetOpts;
    private readonly ServerStats _stats;
    private readonly ILogger<MaintenanceService> _log;

    public MaintenanceService(
        IDxSpotRepository spots,
        IUserRepository users,
        IWwvRepository wwv,
        IWxRepository wx,
        IConnectionManager connections,
        DuplicateSpotDetector dupeDetector,
        IOptions<DatabaseOptions> dbOpts,
        IOptions<TelnetOptions> telnetOpts,
        ServerStats stats,
        ILogger<MaintenanceService> log)
    {
        _spots       = spots;
        _users       = users;
        _wwv         = wwv;
        _wx          = wx;
        _connections = connections;
        _dupeDetector = dupeDetector;
        _dbOpts      = dbOpts.Value;
        _telnetOpts  = telnetOpts.Value;
        _stats       = stats;
        _log         = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Idle-timeout check every minute; DB maintenance every hour
        int minuteCount = 0;
        using var timer = new PeriodicTimer(TimeSpan.FromMinutes(1));
        while (await timer.WaitForNextTickAsync(stoppingToken))
        {
            await EnforceIdleTimeoutsAsync(stoppingToken);
            minuteCount++;
            if (minuteCount >= 60)
            {
                minuteCount = 0;
                await RunMaintenanceAsync(stoppingToken);
            }
        }
    }

    // ── Idle timeout ──────────────────────────────────────────────────────────

    private async Task EnforceIdleTimeoutsAsync(CancellationToken ct)
    {
        var timeoutMinutes = _telnetOpts.IdleTimeoutMinutes;
        if (timeoutMinutes <= 0) return; // 0 = disabled

        var cutoff = DateTime.UtcNow.AddMinutes(-timeoutMinutes);
        var sessions = _connections.GetConnectedUsers();

        // Update peak-user stat while we have the list
        _stats.UpdatePeakUsers(sessions.Count);

        foreach (var session in sessions)
        {
            if (session.LastActivityAt < cutoff && session.DisconnectAsync is not null)
            {
                _log.LogInformation(
                    "{Callsign} idle for >{Timeout} min — disconnecting",
                    session.Callsign, timeoutMinutes);
                try
                {
                    await session.SendAsync!(
                        $"\r\n*** Disconnected: idle for more than {timeoutMinutes} minutes. 73! ***\r\n", ct);
                }
                catch { /* may already be gone */ }
                _ = session.DisconnectAsync();
            }
        }
    }

    // ── Hourly DB maintenance ─────────────────────────────────────────────────

    private async Task RunMaintenanceAsync(CancellationToken ct)
    {
        try
        {
            _log.LogInformation("Running maintenance...");

            var spotCutoff = DateTime.UtcNow.AddDays(-_dbOpts.DxSpotRetentionDays);
            await _spots.PurgeOlderThanAsync(spotCutoff, ct);
            await _spots.PurgeExcessAsync(_dbOpts.DxSpotMaxCount, ct);

            var userCutoff = DateTime.UtcNow.AddYears(-_dbOpts.UserRetentionYears);
            await _users.PurgeOlderThanAsync(userCutoff, ct);

            var propCutoff = DateTime.UtcNow.AddDays(-_dbOpts.DxSpotRetentionDays);
            await _wwv.PurgeOlderThanAsync(propCutoff, ct);
            await _wx.PurgeOlderThanAsync(propCutoff, ct);

            _dupeDetector.Cleanup();

            var spotCount = await _spots.CountAsync(ct);
            DbSpotsTotal.Set(spotCount);

            _log.LogInformation("Maintenance complete");
        }
        catch (Exception ex) when (!ct.IsCancellationRequested)
        {
            _log.LogError(ex, "Maintenance failed");
        }
    }
}
