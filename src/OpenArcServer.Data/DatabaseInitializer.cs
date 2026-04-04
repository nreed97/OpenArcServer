using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OpenArcServer.Core.Configuration;

namespace OpenArcServer.Data;

public sealed class DatabaseInitializer
{
    private readonly DatabaseOptions _opts;
    private readonly ILogger<DatabaseInitializer> _log;

    public DatabaseInitializer(IOptions<DatabaseOptions> opts, ILogger<DatabaseInitializer> log)
    {
        _opts = opts.Value;
        _log = log;
    }

    public void Initialize()
    {
        _log.LogInformation("Initializing database at {ConnectionString}", _opts.ConnectionString);

        using var conn = new SqliteConnection(_opts.ConnectionString);
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
PRAGMA journal_mode=WAL;
PRAGMA synchronous=NORMAL;
PRAGMA foreign_keys=ON;

CREATE TABLE IF NOT EXISTS dx_spots (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    call            TEXT    NOT NULL,
    spotter         TEXT    NOT NULL,
    spotter_node    TEXT    NOT NULL DEFAULT '',
    freq            REAL    NOT NULL,
    band            REAL    NOT NULL DEFAULT 0,
    mode            TEXT    NOT NULL DEFAULT '',
    comment         TEXT    NOT NULL DEFAULT '',
    cty             TEXT    NOT NULL DEFAULT '',
    spotter_cty     TEXT    NOT NULL DEFAULT '',
    cont            TEXT    NOT NULL DEFAULT '',
    spotter_cont    TEXT    NOT NULL DEFAULT '',
    state           TEXT    NOT NULL DEFAULT '',
    spotter_state   TEXT    NOT NULL DEFAULT '',
    cq_zone         INTEGER NOT NULL DEFAULT 0,
    itu_zone        INTEGER NOT NULL DEFAULT 0,
    spotter_cq_zone INTEGER NOT NULL DEFAULT 0,
    spotter_itu_zone INTEGER NOT NULL DEFAULT 0,
    grid            TEXT    NOT NULL DEFAULT '',
    dupe_key        TEXT    NOT NULL DEFAULT '',
    is_dupe         INTEGER NOT NULL DEFAULT 0,
    skimmer         INTEGER NOT NULL DEFAULT 0,
    timestamp       TEXT    NOT NULL,
    received_at     TEXT    NOT NULL
);

CREATE INDEX IF NOT EXISTS ix_dx_spots_timestamp    ON dx_spots (timestamp DESC);
CREATE INDEX IF NOT EXISTS ix_dx_spots_call         ON dx_spots (call);
CREATE INDEX IF NOT EXISTS ix_dx_spots_spotter      ON dx_spots (spotter);
CREATE INDEX IF NOT EXISTS ix_dx_spots_dupe_key     ON dx_spots (dupe_key);
CREATE INDEX IF NOT EXISTS ix_dx_spots_freq         ON dx_spots (freq);

CREATE TABLE IF NOT EXISTS users (
    callsign        TEXT    PRIMARY KEY,
    name            TEXT    NOT NULL DEFAULT '',
    qth             TEXT    NOT NULL DEFAULT '',
    grid            TEXT    NOT NULL DEFAULT '',
    email           TEXT    NOT NULL DEFAULT '',
    latitude        REAL    NOT NULL DEFAULT 0,
    longitude       REAL    NOT NULL DEFAULT 0,
    dx_count        INTEGER NOT NULL DEFAULT 10,
    first_seen      TEXT    NOT NULL,
    last_seen       TEXT    NOT NULL,
    total_connects  INTEGER NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS wwv_spots (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    sfi             TEXT    NOT NULL DEFAULT '',
    a_index         TEXT    NOT NULL DEFAULT '',
    k_index         TEXT    NOT NULL DEFAULT '',
    forecast        TEXT    NOT NULL DEFAULT '',
    spotter         TEXT    NOT NULL DEFAULT '',
    spotter_node    TEXT    NOT NULL DEFAULT '',
    timestamp       TEXT    NOT NULL
);

CREATE INDEX IF NOT EXISTS ix_wwv_spots_timestamp ON wwv_spots (timestamp DESC);

CREATE TABLE IF NOT EXISTS wx_spots (
    id              INTEGER PRIMARY KEY AUTOINCREMENT,
    message         TEXT    NOT NULL DEFAULT '',
    spotter         TEXT    NOT NULL DEFAULT '',
    spotter_node    TEXT    NOT NULL DEFAULT '',
    timestamp       TEXT    NOT NULL
);

CREATE INDEX IF NOT EXISTS ix_wx_spots_timestamp ON wx_spots (timestamp DESC);

CREATE TABLE IF NOT EXISTS buddies (
    owner_callsign  TEXT    NOT NULL,
    buddy_callsign  TEXT    NOT NULL,
    PRIMARY KEY (owner_callsign, buddy_callsign)
);

CREATE INDEX IF NOT EXISTS ix_buddies_owner ON buddies (owner_callsign);
";
        cmd.ExecuteNonQuery();
        _log.LogInformation("Database initialized successfully");
    }
}
