# OpenArcServer Implementation Plan

## Context

The original AR-Cluster Server by AB5K (SK) is no longer maintained. Through protocol analysis and compatibility research of the AR-Cluster ecosystem, we have full protocol documentation and a GitHub repo at `nreed97/OpenArcServer`. The goal is to build a cross-platform, open-source replacement compatible with all existing DX cluster telnet clients (N1MM+, DXLab, Logger32, etc.) and PCxx-protocol cluster nodes. This is a clean-room implementation sharing no code with the original.

This plan covers **Phase 1 (MVP)**: a working telnet DX cluster server that can accept client connections, handle DX spot posting/querying, and basic user commands.

---

## Solution Structure

```
S:/vibe/DXCluster/OpenArcServer/
  OpenArcServer.sln
  src/
    OpenArcServer.Core/              # Interfaces, models, enums, config POCOs
    OpenArcServer.Data/              # SQLite repos, CTY.DAT/BandMode parsers
    OpenArcServer.Engine/            # Commands, caches, routing, publisher, formatters
    OpenArcServer.Protocols.Telnet/  # TCP/telnet server, connection handler, login state machine
    OpenArcServer.Server/            # Console host, DI wiring, appsettings.json
  tests/
    OpenArcServer.Engine.Tests/      # Command, parser, formatter, dupe detector tests
    OpenArcServer.Data.Tests/        # Repository and file parser tests
    OpenArcServer.Integration.Tests/ # End-to-end telnet client tests
  reference/                         # (existing) protocol reference material
  docs/                              # (existing) protocol & compatibility research docs
  data/                              # Runtime data files (CTY.DAT, BandMode.dat, etc.)
```

**Dependencies:** `Core` has none (except `Microsoft.Extensions.Logging.Abstractions`). `Data` and `Engine` depend on `Core`. `Protocols.Telnet` depends on `Core` + `Engine`. `Server` depends on everything.

---

## Implementation Steps

### Step 1: Solution Scaffold + Core Models

Create .sln with all 5 src projects + 3 test projects. Define in `OpenArcServer.Core`:

**Enums** (match original exactly for protocol compat):
- `DistroType` (ToRequester, ToAll, ToUsers, ToNode, ToNodes, ToPcxxNodes, ToNil, etc.)
- `ConnectStateType` (TelnetUser, PcxxNode, PcxxUser, ArxNode, ArxClient, AgwBpqUser, RcvOnly)
- `ConnectionState` (Idle, CallsignRequest, CallsignValidation, Connected)
- `MsgType` (General, Dx, DxLocal, Ann, Wx, Wwv)

**Models** (`OpenArcServer.Core.Models`):
- `DxSpot` - 40+ fields matching original (Call, Spotter, Freq, Band, Mode, Comment, Cty, CqZone, ItuZone, etc.)
- `CtyRecord` - Country/prefix (CountryName, CtyCode, CqZone, ItuZone, Continent, Lat, Lon, Prefixes)
- `BandModeEntry` - Freq range to band/mode mapping
- `UserProfile` - Persisted user data (Callsign, Name, Qth, Grid, Email, Lat, Lon)

**Command Framework** (`OpenArcServer.Core.Commands`):
- `IArcCommand` with `Task ExecuteAsync(CommandContext ctx, CancellationToken ct)`
- `CommandContext` wrapping `UserSession`, `CommandRequest`, `CommandResponse`
- `CommandRequest` with `RawMessage`, `Tokens[]`, `CommandKey`
- `CommandResponse` with `Messages` list, `DistroType`, `MsgType`

**Session** (`OpenArcServer.Core.Sessions`):
- `UserSession` - per-connection state (Callsign, ConnectType, ConnectionState, endpoint, timestamps, station info, `Func<string, CancellationToken, Task> SendAsync` callback)

**Service Interfaces**:
- `IConnectionManager` - AddSession, RemoveSession, GetConnectedUsers, FindByCallsign
- `IMessageDistributor` - DistributeAsync(response, sender)
- `ICommandRouter` - Resolve(commandKey), Register(definition, command)

**Repository Interfaces**:
- `IDxSpotRepository` - Insert, GetRecent, Search, Purge
- `IUserRepository` - GetOrCreate, Update
- `ICtyLookup` - LookupCallsign(string) -> CtyRecord
- `IBandModeLookup` - LookupFrequency(float) -> BandModeEntry

**Config POCOs** (for `appsettings.json` binding):
- `ServerOptions` (NodeCallsign, SysopCallsign, Version)
- `TelnetOptions` (Port, BindAddress, MaxConnections, IdleTimeout, messages)
- `DatabaseOptions` (ConnectionString, retention settings)
- `DataFileOptions` (paths to CTY.DAT, BandMode.dat, etc.)
- `SpotProcessingOptions` (dupe window, freq limits, bad word filter)

### Step 2: Data Layer

**SQLite database** (`OpenArcServer.Data`):

```sql
CREATE TABLE dx_spots (
    id INTEGER PRIMARY KEY AUTOINCREMENT,
    call TEXT NOT NULL, spotter TEXT NOT NULL, spotter_node TEXT DEFAULT '',
    freq REAL NOT NULL, band REAL DEFAULT 0, mode TEXT DEFAULT '',
    comment TEXT DEFAULT '', cty TEXT DEFAULT '', spotter_cty TEXT DEFAULT '',
    cont TEXT DEFAULT '', spotter_cont TEXT DEFAULT '',
    state TEXT DEFAULT '', spotter_state TEXT DEFAULT '',
    cq_zone INTEGER DEFAULT 0, itu_zone INTEGER DEFAULT 0,
    spotter_cq_zone INTEGER DEFAULT 0, spotter_itu_zone INTEGER DEFAULT 0,
    grid TEXT DEFAULT '', dupe_key TEXT DEFAULT '',
    is_dupe INTEGER DEFAULT 0, skimmer INTEGER DEFAULT 0,
    timestamp TEXT NOT NULL, received_at TEXT NOT NULL
);
-- Indexes on timestamp DESC, call, spotter, dupe_key, freq

CREATE TABLE users (
    callsign TEXT PRIMARY KEY,
    name TEXT DEFAULT '', qth TEXT DEFAULT '', grid TEXT DEFAULT '',
    email TEXT DEFAULT '', latitude REAL DEFAULT 0, longitude REAL DEFAULT 0,
    dx_count INTEGER DEFAULT 10,
    first_seen TEXT NOT NULL, last_seen TEXT NOT NULL,
    total_connects INTEGER DEFAULT 0
);
```

**File parsers** (reference: `ArcShared/CtyInfo.cs` line 170-181 for field positions):

- `CtyDatParser` - Fixed-width: Country[0:25], CqZone[26:5], ItuZone[31:5], Continent[36:5], Lat[41:9], Lon[50:9] (negated), TimeOffset[60:8], Cty[68:end]. Then parse comma-separated prefix lines with override syntax (parentheses for CQ zone, brackets for ITU zone, etc.). Build prefix→CtyRecord dictionary for longest-prefix matching.
- `BandModeParser` - Space-delimited: band, mode, freq_low, freq_high. Build sorted list for binary search.
- Simple line-list parsers for BadWord.dat, CallBlock.dat, ConnectBlock.dat

### Step 3: Telnet Server

**`OpenArcServer.Protocols.Telnet`** using `System.IO.Pipelines` for efficient line buffering:

- `TelnetServer` - `IHostedService`, binds to configurable port, accepts connections async
- `TelnetClientConnection` - Per-client: PipeReader for line-buffered input, manages send queue
- `TelnetProtocolHandler` - Login state machine:
  1. `Idle` → send intro message, prompt "Please enter your callsign:"
  2. `CallsignRequest` → receive input, validate callsign format (regex: `^[A-Z0-9]{1,3}[0-9][A-Z0-9]{0,3}[A-Z](-[0-9]{1,2})?$`)
  3. `CallsignValidation` → check ConnectBlock list, create/load UserProfile
  4. `Connected` → route lines to CommandRouter
- `ConnectionManager` - `ConcurrentDictionary<string, UserSession>`, implements `IConnectionManager`

### Step 4: Command Infrastructure

- `CommandRouter` - Replicates original's `UserCmdLookup` pattern (reference: `ArcEngine/UserCmdLookup.cs`):
  - Split command definition on spaces ("SH DX" → ["SH", "DX"])
  - Expand each token to abbreviation variants (the `Ⴍ(string)` method builds [original, uppercase] plus if it's a known word like "SHOW" also register "SH")
  - Build all combinations as dictionary keys: "SH DX", "SHOW DX", "SH/DX", "SHOW/DX"
  - Commands also matchable with `/` separator (clients send both "SH DX" and "SH/DX")
- `MessageDistributor` - Switch on DistroType, iterate sessions via IConnectionManager, call SendAsync

**Phase 1 commands:**

| Command | Definition | Class |
|---------|-----------|-------|
| `DX` | `DX` | `DxSpotCommand` |
| `SH/DX` | `SH DX` | `ShowDxCommand` |
| `BYE` | `BYE` | `ByeCommand` |
| `SH/U` | `SH U` | `ShowUsersCommand` |
| `SH/VERSION` | `SH VERSION` | `ShowVersionCommand` |
| `SH/TIME` | `SH TIME` | `ShowTimeCommand` |
| `HELP` | `HELP` | `HelpCommand` |

### Step 5: DX Spot Pipeline (Critical Path)

This must produce output identical to the original for client compatibility.

**`DxSpotParser`** - Parse "DX 14025 W1AW good signal":
- Token[0] = frequency (float, kHz)
- Token[1] = callsign (uppercase)
- Token[2+] = comment (joined)

**`DxSpotFormatter`** - Standard telnet fixed-width output:
```
DX de {spotter,-10}:  {freq,9:F1}  {call,-12}  {comment,-30} {time:HHmm}Z
```
Example: `DX de AB5K:       14025.0  W1AW         Good signal                    1530Z`

**`DuplicateSpotDetector`** - ConcurrentDictionary<string, DateTime> with configurable TTL (default 20 min). DupeKey = `"{call}|{band}"` or `"{call}|{band}|{spotter}"`.

**`DxSpotCommand.ExecuteAsync()` flow:**
1. Parse input → freq, call, comment
2. `IBandModeLookup.LookupFrequency(freq)` → band, mode
3. `ICtyLookup.LookupCallsign(call)` → country, zones, continent
4. `ICtyLookup.LookupCallsign(spotter)` → spotter country info
5. Check duplicate
6. `IDxSpotRepository.InsertAsync(spot)`
7. Format output via `DxSpotFormatter`
8. Set `DistroType = ToAll`, `MsgType = Dx`

**`ShowDxCommand.ExecuteAsync()`:**
1. Query `IDxSpotRepository.GetRecentAsync(count)` or `.SearchAsync(call, count)`
2. Format each spot via `DxSpotFormatter`
3. Set `DistroType = ToRequester`

### Step 6: Server Host + DI Wiring

**`OpenArcServer.Server/Program.cs`** using .NET Generic Host:
- Load `appsettings.json`
- Register all services (repos, caches, commands, router, distributor, connection manager)
- Register `TelnetServer` as `IHostedService`
- Register background `MaintenanceService` (periodic spot purge, cache cleanup)
- Serilog for logging

**`appsettings.json`** with sections: Server, Telnet, Database, DataFiles, SpotProcessing, Caches, Logging.

### Step 7: Data Files Setup

Copy reference data files to `data/` directory:
- `cty_wt_mod.dat` (from reference/data or downloadable)
- `BandMode.dat`
- `BadWord.dat`, `CallBlock.dat`, `ConnectBlock.dat`
- `States.dat`, `Provinces.dat`

### Step 8: Testing

**Unit tests:** DxSpotParser, DxSpotFormatter (verify exact column positions), CtyDatParser, BandModeParser, DuplicateSpotDetector, CommandRouter abbreviation expansion, SQLite repos (in-memory DB).

**Integration tests:** Spin up server on random port, connect with TcpClient:
- Login flow (connect → callsign prompt → send callsign → welcome)
- DX spot roundtrip (post spot → verify format in response)
- DX spot broadcast (two clients → one posts → both receive)
- SH/DX query
- BYE disconnect

**Manual compatibility testing:** PuTTY, N1MM+ cluster window, DXLab SpotCollector.

---

## Key Design Decisions

1. **System.IO.Pipelines** for telnet I/O (efficient line buffering, backpressure handling)
2. **Async/await** throughout (replaces original's Thread[] + AutoResetEvent)
3. **Raw SQL via Microsoft.Data.Sqlite** (matches original's raw SQL approach, lighter than EF Core)
4. **ConcurrentDictionary** for dupe cache (replaces original's DataTable + Monitor locks)
5. **Command abbreviation expansion** preserved exactly (critical for client compat)
6. **Fixed-width spot output** must be byte-exact (clients parse by column position)

---

## Verification

1. Run `dotnet build` - all projects compile
2. Run `dotnet test` - all unit + integration tests pass
3. Start server: `dotnet run --project src/OpenArcServer.Server`
4. Connect with `telnet localhost 7373` - verify login flow
5. Post `DX 14025 W1AW test spot` - verify formatted output
6. Open second telnet session - verify spot broadcast
7. Run `SH/DX` - verify spot listing format
8. Test with N1MM+ DX cluster connection - verify spots are parsed correctly

---

## Critical Reference Files

- `reference/ArcShared/ArcShared/CtyInfo.cs` - CTY.DAT field positions (line 170-181)
- `reference/ArcEngine/ArcEngine.ArcCmds.UserProcessor/UserCmdLookup.cs` - Command abbreviation expansion
- `reference/ArcEngine/ArcEngine.ArcCmds.Dx/DxSpotBase.cs` - DX spot processing and output format
- `reference/ArcEngine/ArcEngine.ArcCmds.Dx/DxSpotPc11.cs` - PC11 message parsing
- `reference/ArcEngine/ArcEngine.ArcCmds.Publish/Publisher.cs` - Message distribution
- `reference/config/ArcServerDi.xml` - All command registrations
- `reference/data/BandMode.dat` - Band/mode frequency ranges
