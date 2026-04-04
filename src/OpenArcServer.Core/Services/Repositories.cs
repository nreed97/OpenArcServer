using OpenArcServer.Core.Models;

namespace OpenArcServer.Core.Services;

public interface IDxSpotRepository
{
    Task<long> InsertAsync(DxSpot spot, CancellationToken ct = default);
    Task<IReadOnlyList<DxSpot>> GetRecentAsync(int count, CancellationToken ct = default);
    Task<IReadOnlyList<DxSpot>> SearchByCallAsync(string call, int count, CancellationToken ct = default);
    Task PurgeOlderThanAsync(DateTime cutoff, CancellationToken ct = default);
    Task PurgeExcessAsync(int maxCount, CancellationToken ct = default);
    Task<long> CountAsync(CancellationToken ct = default);
}

public interface IUserRepository
{
    Task<UserProfile> GetOrCreateAsync(string callsign, CancellationToken ct = default);
    Task UpdateAsync(UserProfile profile, CancellationToken ct = default);
    Task PurgeOlderThanAsync(DateTime cutoff, CancellationToken ct = default);
}

public interface ICtyLookup
{
    /// <summary>Longest-prefix match a callsign to its country record</summary>
    CtyRecord? LookupCallsign(string callsign);
}

public interface IBandModeLookup
{
    /// <summary>Find the band/mode entry for a frequency in kHz</summary>
    BandModeEntry? LookupFrequency(float freqKhz);
}

public interface IFilterList
{
    bool IsBlocked(string value);
    IReadOnlyList<string> GetAll();
}
