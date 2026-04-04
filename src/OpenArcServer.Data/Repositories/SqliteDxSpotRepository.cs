using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;
using OpenArcServer.Core.Models;
using OpenArcServer.Core.Services;

namespace OpenArcServer.Data.Repositories;

public sealed class SqliteDxSpotRepository : IDxSpotRepository
{
    private readonly string _connectionString;

    public SqliteDxSpotRepository(IOptions<DatabaseOptions> opts)
    {
        _connectionString = opts.Value.ConnectionString;
    }

    public async Task<long> InsertAsync(DxSpot spot, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
INSERT INTO dx_spots
    (call, spotter, spotter_node, freq, band, mode, comment,
     cty, spotter_cty, cont, spotter_cont, state, spotter_state,
     cq_zone, itu_zone, spotter_cq_zone, spotter_itu_zone,
     grid, dupe_key, is_dupe, skimmer, timestamp, received_at)
VALUES
    ($call, $spotter, $spotter_node, $freq, $band, $mode, $comment,
     $cty, $spotter_cty, $cont, $spotter_cont, $state, $spotter_state,
     $cq_zone, $itu_zone, $spotter_cq_zone, $spotter_itu_zone,
     $grid, $dupe_key, $is_dupe, $skimmer, $timestamp, $received_at);
SELECT last_insert_rowid();";

        cmd.Parameters.AddWithValue("$call", spot.Call);
        cmd.Parameters.AddWithValue("$spotter", spot.Spotter);
        cmd.Parameters.AddWithValue("$spotter_node", spot.SpotterNode);
        cmd.Parameters.AddWithValue("$freq", spot.Freq);
        cmd.Parameters.AddWithValue("$band", spot.Band);
        cmd.Parameters.AddWithValue("$mode", spot.Mode);
        cmd.Parameters.AddWithValue("$comment", spot.Comment);
        cmd.Parameters.AddWithValue("$cty", spot.Cty);
        cmd.Parameters.AddWithValue("$spotter_cty", spot.SpotterCty);
        cmd.Parameters.AddWithValue("$cont", spot.Cont);
        cmd.Parameters.AddWithValue("$spotter_cont", spot.SpotterCont);
        cmd.Parameters.AddWithValue("$state", spot.State);
        cmd.Parameters.AddWithValue("$spotter_state", spot.SpotterState);
        cmd.Parameters.AddWithValue("$cq_zone", spot.CqZone);
        cmd.Parameters.AddWithValue("$itu_zone", spot.ItuZone);
        cmd.Parameters.AddWithValue("$spotter_cq_zone", spot.SpotterCqZone);
        cmd.Parameters.AddWithValue("$spotter_itu_zone", spot.SpotterItuZone);
        cmd.Parameters.AddWithValue("$grid", spot.Grid);
        cmd.Parameters.AddWithValue("$dupe_key", spot.DupeKey);
        cmd.Parameters.AddWithValue("$is_dupe", spot.IsDupe ? 1 : 0);
        cmd.Parameters.AddWithValue("$skimmer", spot.Skimmer ? 1 : 0);
        cmd.Parameters.AddWithValue("$timestamp", spot.Timestamp.ToString("O"));
        cmd.Parameters.AddWithValue("$received_at", spot.ReceivedAt.ToString("O"));

        var result = await cmd.ExecuteScalarAsync(ct);
        return Convert.ToInt64(result);
    }

    public async Task<IReadOnlyList<DxSpot>> GetRecentAsync(int count, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
SELECT * FROM dx_spots
WHERE is_dupe = 0
ORDER BY timestamp DESC
LIMIT $count";
        cmd.Parameters.AddWithValue("$count", count);

        return await ReadSpotsAsync(cmd, ct);
    }

    public async Task<IReadOnlyList<DxSpot>> SearchByCallAsync(string call, int count, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
SELECT * FROM dx_spots
WHERE call LIKE $call AND is_dupe = 0
ORDER BY timestamp DESC
LIMIT $count";
        cmd.Parameters.AddWithValue("$call", call.ToUpperInvariant() + "%");
        cmd.Parameters.AddWithValue("$count", count);

        return await ReadSpotsAsync(cmd, ct);
    }

    public async Task PurgeOlderThanAsync(DateTime cutoff, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = "DELETE FROM dx_spots WHERE timestamp < $cutoff";
        cmd.Parameters.AddWithValue("$cutoff", cutoff.ToString("O"));
        await cmd.ExecuteNonQueryAsync(ct);
    }

    public async Task PurgeExcessAsync(int maxCount, CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
DELETE FROM dx_spots
WHERE id NOT IN (
    SELECT id FROM dx_spots
    ORDER BY timestamp DESC
    LIMIT $maxCount
)";
        cmd.Parameters.AddWithValue("$maxCount", maxCount);
        await cmd.ExecuteNonQueryAsync(ct);
    }

    public async Task<long> CountAsync(CancellationToken ct = default)
    {
        await using var conn = new SqliteConnection(_connectionString);
        await conn.OpenAsync(ct);

        await using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT COUNT(*) FROM dx_spots";
        var result = await cmd.ExecuteScalarAsync(ct);
        return Convert.ToInt64(result);
    }

    private static async Task<IReadOnlyList<DxSpot>> ReadSpotsAsync(SqliteCommand cmd, CancellationToken ct)
    {
        var spots = new List<DxSpot>();
        await using var reader = await cmd.ExecuteReaderAsync(ct);
        while (await reader.ReadAsync(ct))
        {
            spots.Add(new DxSpot
            {
                Id = reader.GetInt64(reader.GetOrdinal("id")),
                Call = reader.GetString(reader.GetOrdinal("call")),
                Spotter = reader.GetString(reader.GetOrdinal("spotter")),
                SpotterNode = reader.GetString(reader.GetOrdinal("spotter_node")),
                Freq = (float)reader.GetDouble(reader.GetOrdinal("freq")),
                Band = (float)reader.GetDouble(reader.GetOrdinal("band")),
                Mode = reader.GetString(reader.GetOrdinal("mode")),
                Comment = reader.GetString(reader.GetOrdinal("comment")),
                Cty = reader.GetString(reader.GetOrdinal("cty")),
                SpotterCty = reader.GetString(reader.GetOrdinal("spotter_cty")),
                Cont = reader.GetString(reader.GetOrdinal("cont")),
                SpotterCont = reader.GetString(reader.GetOrdinal("spotter_cont")),
                State = reader.GetString(reader.GetOrdinal("state")),
                SpotterState = reader.GetString(reader.GetOrdinal("spotter_state")),
                CqZone = (byte)reader.GetInt32(reader.GetOrdinal("cq_zone")),
                ItuZone = (byte)reader.GetInt32(reader.GetOrdinal("itu_zone")),
                SpotterCqZone = (byte)reader.GetInt32(reader.GetOrdinal("spotter_cq_zone")),
                SpotterItuZone = (byte)reader.GetInt32(reader.GetOrdinal("spotter_itu_zone")),
                Grid = reader.GetString(reader.GetOrdinal("grid")),
                DupeKey = reader.GetString(reader.GetOrdinal("dupe_key")),
                IsDupe = reader.GetInt32(reader.GetOrdinal("is_dupe")) != 0,
                Skimmer = reader.GetInt32(reader.GetOrdinal("skimmer")) != 0,
                Timestamp = DateTime.Parse(reader.GetString(reader.GetOrdinal("timestamp"))),
                ReceivedAt = DateTime.Parse(reader.GetString(reader.GetOrdinal("received_at"))),
            });
        }
        return spots;
    }
}
