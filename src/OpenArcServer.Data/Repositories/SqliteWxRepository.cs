using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Repositories;

public sealed class SqliteWxRepository : IWxRepository
{
    private readonly string _connectionString;

    public SqliteWxRepository(IOptions<DatabaseOptions> opts)
    {
        _connectionString = opts.Value.ConnectionString;
    }

    public async Task<long> InsertAsync(WxSpot spot, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
INSERT INTO wx_spots (message, spotter, spotter_node, timestamp)
VALUES ($message, $spotter, $spotter_node, $timestamp);
SELECT last_insert_rowid();";
        cmd.Parameters.AddWithValue("$message", spot.Message);
        cmd.Parameters.AddWithValue("$spotter", spot.Spotter);
        cmd.Parameters.AddWithValue("$spotter_node", spot.SpotterNode);
        cmd.Parameters.AddWithValue("$timestamp", spot.Timestamp.ToString("O"));
        var result = await cmd.ExecuteScalarAsync(ct);
        spot.Id = result is long l ? l : 0;
        return spot.Id;
    }

    public async Task<IReadOnlyList<WxSpot>> GetRecentAsync(int count, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);
        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
SELECT id, message, spotter, spotter_node, timestamp
FROM wx_spots ORDER BY timestamp DESC LIMIT $count";
        cmd.Parameters.AddWithValue("$count", count);
        await using var reader = await cmd.ExecuteReaderAsync(ct);
        var results = new List<WxSpot>();
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
        cmd.CommandText = "DELETE FROM wx_spots WHERE timestamp < $cutoff";
        cmd.Parameters.AddWithValue("$cutoff", cutoff.ToString("O"));
        await cmd.ExecuteNonQueryAsync(ct);
    }

    private static WxSpot ReadSpot(SqliteDataReader r) => new()
    {
        Id = r.GetInt64(0),
        Message = r.GetString(1),
        Spotter = r.GetString(2),
        SpotterNode = r.GetString(3),
        Timestamp = DateTime.Parse(r.GetString(4), null, System.Globalization.DateTimeStyles.RoundtripKind),
    };
}
