using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Repositories;

public sealed class SqliteUserRepository : IUserRepository
{
    private readonly string _connectionString;

    public SqliteUserRepository(IOptions<DatabaseOptions> opts)
    {
        _connectionString = opts.Value.ConnectionString;
    }

    public async Task<UserProfile> GetOrCreateAsync(string callsign, CancellationToken ct = default)
    {
        callsign = callsign.ToUpperInvariant();

        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var selectCmd = conn.CreateCommand();
        selectCmd.CommandText = "SELECT * FROM users WHERE callsign = $callsign";
        selectCmd.Parameters.AddWithValue("$callsign", callsign);

        await using var reader = await selectCmd.ExecuteReaderAsync(ct);
        if (await reader.ReadAsync(ct))
        {
            return ReadProfile(reader);
        }
        await reader.DisposeAsync();

        // Create new profile
        var now = DateTime.UtcNow.ToString("O");
        await using var insertCmd = conn.CreateCommand();
        insertCmd.CommandText = @"
INSERT INTO users (callsign, first_seen, last_seen)
VALUES ($callsign, $now, $now)";
        insertCmd.Parameters.AddWithValue("$callsign", callsign);
        insertCmd.Parameters.AddWithValue("$now", now);
        await insertCmd.ExecuteNonQueryAsync(ct);

        return new UserProfile { Callsign = callsign };
    }

    public async Task UpdateAsync(UserProfile profile, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
UPDATE users SET
    name           = $name,
    qth            = $qth,
    grid           = $grid,
    email          = $email,
    latitude       = $lat,
    longitude      = $lon,
    dx_count       = $dx_count,
    last_seen      = $last_seen,
    total_connects = $total_connects
WHERE callsign = $callsign";

        cmd.Parameters.AddWithValue("$callsign", profile.Callsign);
        cmd.Parameters.AddWithValue("$name", profile.Name);
        cmd.Parameters.AddWithValue("$qth", profile.Qth);
        cmd.Parameters.AddWithValue("$grid", profile.Grid);
        cmd.Parameters.AddWithValue("$email", profile.Email);
        cmd.Parameters.AddWithValue("$lat", profile.Latitude);
        cmd.Parameters.AddWithValue("$lon", profile.Longitude);
        cmd.Parameters.AddWithValue("$dx_count", profile.DxCount);
        cmd.Parameters.AddWithValue("$last_seen", profile.LastSeen.ToString("O"));
        cmd.Parameters.AddWithValue("$total_connects", profile.TotalConnects);

        await cmd.ExecuteNonQueryAsync(ct);
    }

    public async Task PurgeOlderThanAsync(DateTime cutoff, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM users WHERE last_seen < $cutoff";
        cmd.Parameters.AddWithValue("$cutoff", cutoff.ToString("O"));
        await cmd.ExecuteNonQueryAsync(ct);
    }

    private static UserProfile ReadProfile(SqliteDataReader reader) => new()
    {
        Callsign = reader.GetString(reader.GetOrdinal("callsign")),
        Name = reader.GetString(reader.GetOrdinal("name")),
        Qth = reader.GetString(reader.GetOrdinal("qth")),
        Grid = reader.GetString(reader.GetOrdinal("grid")),
        Email = reader.GetString(reader.GetOrdinal("email")),
        Latitude = (float)reader.GetDouble(reader.GetOrdinal("latitude")),
        Longitude = (float)reader.GetDouble(reader.GetOrdinal("longitude")),
        DxCount = reader.GetInt32(reader.GetOrdinal("dx_count")),
        FirstSeen = DateTime.Parse(reader.GetString(reader.GetOrdinal("first_seen"))),
        LastSeen = DateTime.Parse(reader.GetString(reader.GetOrdinal("last_seen"))),
        TotalConnects = reader.GetInt32(reader.GetOrdinal("total_connects")),
    };
}
