namespace OpenArcServer.Core.Services;

/// <summary>
/// Singleton tracking server-wide statistics that survive across maintenance cycles.
/// Thread-safe via Interlocked operations.
/// </summary>
public sealed class ServerStats
{
    public DateTime StartedAt { get; } = DateTime.UtcNow;

    private int _peakUsers;
    private long _totalConnects;
    private long _spotsToday;
    private DateTime _spotsTodayDate = DateTime.UtcNow.Date;

    public int PeakUsers => _peakUsers;
    public long TotalConnects => _totalConnects;

    /// <summary>Spots received since midnight UTC (resets daily).</summary>
    public long SpotsToday
    {
        get
        {
            var today = DateTime.UtcNow.Date;
            if (today != _spotsTodayDate)
            {
                _spotsTodayDate = today;
                Interlocked.Exchange(ref _spotsToday, 0);
            }
            return _spotsToday;
        }
    }

    public void RecordConnect() => Interlocked.Increment(ref _totalConnects);

    public void RecordSpot() => Interlocked.Increment(ref _spotsToday);

    public void UpdatePeakUsers(int currentCount)
    {
        int current;
        do { current = _peakUsers; }
        while (current < currentCount &&
               Interlocked.CompareExchange(ref _peakUsers, currentCount, current) != current);
    }
}
