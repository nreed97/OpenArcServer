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

public interface IWwvRepository
{
    Task<long> InsertAsync(WwvSpot spot, CancellationToken ct = default);
    Task<IReadOnlyList<WwvSpot>> GetRecentAsync(int count, CancellationToken ct = default);
    Task PurgeOlderThanAsync(DateTime cutoff, CancellationToken ct = default);
}

public interface IWxRepository
{
    Task<long> InsertAsync(WxSpot spot, CancellationToken ct = default);
    Task<IReadOnlyList<WxSpot>> GetRecentAsync(int count, CancellationToken ct = default);
    Task PurgeOlderThanAsync(DateTime cutoff, CancellationToken ct = default);
}

public interface IFilterList
{
    bool IsBlocked(string value);
    IReadOnlyList<string> GetAll();
}

public interface IBuddyRepository
{
    Task AddAsync(string ownerCallsign, string buddyCallsign, CancellationToken ct = default);
    Task RemoveAsync(string ownerCallsign, string buddyCallsign, CancellationToken ct = default);
    Task<IReadOnlyList<string>> GetBuddiesAsync(string ownerCallsign, CancellationToken ct = default);
    Task<bool> IsBuddyAsync(string ownerCallsign, string targetCallsign, CancellationToken ct = default);
}
