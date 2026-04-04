using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Repositories;

public sealed class SqliteBuddyRepository : IBuddyRepository
{
    private readonly string _connectionString;

    public SqliteBuddyRepository(IOptions<DatabaseOptions> opts)
    {
        _connectionString = opts.Value.ConnectionString;
    }

    public async Task AddAsync(string ownerCallsign, string buddyCallsign, CancellationToken ct = default)
    {
        ownerCallsign = ownerCallsign.ToUpperInvariant();
        buddyCallsign = buddyCallsign.ToUpperInvariant();

        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
INSERT OR IGNORE INTO buddies (owner_callsign, buddy_callsign)
VALUES ($owner, $buddy)";
        cmd.Parameters.AddWithValue("$owner", ownerCallsign);
        cmd.Parameters.AddWithValue("$buddy", buddyCallsign);
        await cmd.ExecuteNonQueryAsync(ct);
    }

    public async Task RemoveAsync(string ownerCallsign, string buddyCallsign, CancellationToken ct = default)
    {
        ownerCallsign = ownerCallsign.ToUpperInvariant();
        buddyCallsign = buddyCallsign.ToUpperInvariant();

        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
DELETE FROM buddies WHERE owner_callsign = $owner AND buddy_callsign = $buddy";
        cmd.Parameters.AddWithValue("$owner", ownerCallsign);
        cmd.Parameters.AddWithValue("$buddy", buddyCallsign);
        await cmd.ExecuteNonQueryAsync(ct);
    }

    public async Task<IReadOnlyList<string>> GetBuddiesAsync(string ownerCallsign, CancellationToken ct = default)
    {
        ownerCallsign = ownerCallsign.ToUpperInvariant();

        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
SELECT buddy_callsign FROM buddies WHERE owner_callsign = $owner ORDER BY buddy_callsign";
        cmd.Parameters.AddWithValue("$owner", ownerCallsign);

        await using var reader = await cmd.ExecuteReaderAsync(ct);
        var results = new List<string>();
        while (await reader.ReadAsync(ct))
            results.Add(reader.GetString(0));
        return results;
    }

    public async Task<bool> IsBuddyAsync(string ownerCallsign, string targetCallsign, CancellationToken ct = default)
    {
        ownerCallsign  = ownerCallsign.ToUpperInvariant();
        targetCallsign = targetCallsign.ToUpperInvariant();

        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
SELECT 1 FROM buddies WHERE owner_callsign = $owner AND buddy_callsign = $buddy LIMIT 1";
        cmd.Parameters.AddWithValue("$owner", ownerCallsign);
        cmd.Parameters.AddWithValue("$buddy", targetCallsign);
        var result = await cmd.ExecuteScalarAsync(ct);
        return result is not null;
    }
}
