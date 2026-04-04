using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;
using OpenArcServer.Engine.Spots;

namespace OpenArcServer.Server.Services;

public sealed class MaintenanceService : BackgroundService
{
    private readonly IDxSpotRepository _spots;
    private readonly IUserRepository _users;
    private readonly DuplicateSpotDetector _dupeDetector;
    private readonly DatabaseOptions _dbOpts;
    private readonly ILogger<MaintenanceService> _log;

    public MaintenanceService(
        IDxSpotRepository spots,
        IUserRepository users,
        DuplicateSpotDetector dupeDetector,
        IOptions<DatabaseOptions> dbOpts,
        ILogger<MaintenanceService> log)
    {
        _spots = spots;
        _users = users;
        _dupeDetector = dupeDetector;
        _dbOpts = dbOpts.Value;
        _log = log;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Run maintenance every hour
        using var timer = new PeriodicTimer(TimeSpan.FromHours(1));
        while (await timer.WaitForNextTickAsync(stoppingToken))
        {
            await RunMaintenanceAsync(stoppingToken);
        }
    }

    private async Task RunMaintenanceAsync(CancellationToken ct)
    {
        try
        {
            _log.LogInformation("Running maintenance...");

            // Purge old spots
            var spotCutoff = DateTime.UtcNow.AddDays(-_dbOpts.DxSpotRetentionDays);
            await _spots.PurgeOlderThanAsync(spotCutoff, ct);
            await _spots.PurgeExcessAsync(_dbOpts.DxSpotMaxCount, ct);

            // Purge old user records
            var userCutoff = DateTime.UtcNow.AddYears(-_dbOpts.UserRetentionYears);
            await _users.PurgeOlderThanAsync(userCutoff, ct);

            // Cleanup dupe cache
            _dupeDetector.Cleanup();

            _log.LogInformation("Maintenance complete");
        }
        catch (Exception ex) when (!ct.IsCancellationRequested)
        {
            _log.LogError(ex, "Maintenance failed");
        }
    }
}
