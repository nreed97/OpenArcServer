using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Repositories;

public sealed class SqliteWwvRepository : IWwvRepository
{
    private readonly string _connectionString;

    public SqliteWwvRepository(IOptions<DatabaseOptions> opts)
    {
        _connectionString = opts.Value.ConnectionString;
    }

    public async Task<long> InsertAsync(WwvSpot spot, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
INSERT INTO wwv_spots (sfi, a_index, k_index, forecast, spotter, spotter_node, timestamp)
VALUES ($sfi, $a, $k, $forecast, $spotter, $spotter_node, $timestamp);
SELECT last_insert_rowid();";
        cmd.Parameters.AddWithValue("$sfi", spot.Sfi);
        cmd.Parameters.AddWithValue("$a", spot.A);
        cmd.Parameters.AddWithValue("$k", spot.K);
        cmd.Parameters.AddWithValue("$forecast", spot.Forecast);
        cmd.Parameters.AddWithValue("$spotter", spot.Spotter);
        cmd.Parameters.AddWithValue("$spotter_node", spot.SpotterNode);
        cmd.Parameters.AddWithValue("$timestamp", spot.Timestamp.ToString("O"));
        var result = await cmd.ExecuteScalarAsync(ct);
        spot.Id = result is long l ? l : 0;
        return spot.Id;
    }

    public async Task<IReadOnlyList<WwvSpot>> GetRecentAsync(int count, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
SELECT id, sfi, a_index, k_index, forecast, spotter, spotter_node, timestamp
FROM wwv_spots ORDER BY timestamp DESC LIMIT $count";
        cmd.Parameters.AddWithValue("$count", count);
        await using var reader = await cmd.ExecuteReaderAsync(ct);
        var results = new List<WwvSpot>();
        while (await reader.ReadAsync(ct))
            results.Add(ReadSpot(reader));
        results.Reverse();
        return results;
    }

    public async Task PurgeOlderThanAsync(DateTime cutoff, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM wwv_spots WHERE timestamp < $cutoff";
        cmd.Parameters.AddWithValue("$cutoff", cutoff.ToString("O"));
        await cmd.ExecuteNonQueryAsync(ct);
    }

    private static WwvSpot ReadSpot(SqliteDataReader r) => new()
    {
        Id = r.GetInt64(0),
        Sfi = r.GetString(1),
        A = r.GetString(2),
        K = r.GetString(3),
        Forecast = r.GetString(4),
        Spotter = r.GetString(5),
        SpotterNode = r.GetString(6),
        Timestamp = DateTime.Parse(r.GetString(7), null, System.Globalization.DateTimeStyles.RoundtripKind),
    };
}
