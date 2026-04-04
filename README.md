# OpenArcServer

An open-source, cross-platform DX cluster server compatible with existing AR-Cluster and DX Spider clients.

## Background

**AR-Cluster Server** was a popular DX cluster server created by Terry Gerdes, AB5K (SK). With the original author having passed away and no source code available, this project recreates a compatible server that works with the thousands of existing DX cluster clients deployed worldwide.

Built through protocol analysis and compatibility research of the AR-Cluster Server ecosystem (version 6.1, January 2014) — a .NET 4.0 WinForms application. OpenArcServer is an independent, clean-room implementation sharing no code with the original.

## Status

**Phase 3 complete — DX spot filtering, SET profile commands, TALK, ANN, WWV/WX propagation, skimmer toggle, and buddy list alerts all working.**

The server accepts telnet connections on port 7373, the AR-Cluster native ARx2 client protocol on port 3608 (confirmed from Wireshark captures of real K1TTT traffic), and inbound PCxx node connections on port 7300 for peering with DX Spider, CC Cluster, and other PCxx-compatible cluster nodes.

```
AR-Cluster Server

Please enter your callsign: W1AW
Hello W1AW, welcome to N0CALL-2

DX de W1AW     :   14025.5  K1JT          Great signal!                  1505Z
```

## Features (Phase 1)

| Command | Description |
|---------|-------------|
| `DX <freq> <call> [comment]` | Post a DX spot (broadcast to all users) |
| `SH/DX [n] [call]` | Show last n spots, optionally filtered by callsign |
| `SH/U` | Show connected users |
| `SH/N` | Show connected cluster nodes |
| `SH/VERSION` | Show server version |
| `SH/TIME` | Show current UTC time |
| `HELP` | List available commands |
| `BYE` | Disconnect |

- Standard AR-Cluster fixed-width spot format (column-exact, compatible with all logging software)
- Callsign validation on login
- Connect block list, DX spot block list, bad word filter
- Duplicate spot detection (configurable window, default 20 min)
- Band/mode lookup from BandMode.dat
- CTY.DAT country/prefix lookup (cty_wt_mod.dat)
- SQLite persistence with configurable retention
- Hourly maintenance (purge old spots/users, dupe cache cleanup)
- Serilog structured logging (console + rolling file)
- Cross-platform: Linux, macOS, Windows

## Quick Start

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- A CTY.DAT file — download `cty_wt_mod.dat` from [country-files.com](https://www.country-files.com/contest/ct/) and place it in `src/OpenArcServer.Server/data/`

### Run

```bash
git clone https://github.com/nreed97/OpenArcServer.git
cd OpenArcServer
dotnet run --project src/OpenArcServer.Server
```

Connect with any telnet client:

```bash
telnet localhost 7373
```

### Configuration

Edit `src/OpenArcServer.Server/appsettings.json`:

```json
{
  "Server": {
    "NodeCallsign": "W1AW-2",
    "SysopCallsign": "W1AW",
    "ServerName": "OpenArcServer"
  },
  "Telnet": {
    "Port": 7373,
    "BindAddress": "0.0.0.0",
    "MaxConnections": 200
  }
}
```

## Data Files

The following data files go in `src/OpenArcServer.Server/data/`:

| File | Required | Description |
|------|----------|-------------|
| `cty_wt_mod.dat` | Recommended | CTY.DAT country prefix database. Download from [country-files.com](https://www.country-files.com/contest/ct/) |
| `BandMode.dat` | Included | Band/mode frequency ranges |
| `CallBlock.dat` | Included | Blocked callsigns (login) |
| `ConnectBlock.dat` | Included | Blocked connecting callsigns |
| `DxSpotBlock.dat` | Included | Blocked DX spot callsigns |
| `BadWord.dat` | Included | Comment bad word filter |
| `motd.txt` | Optional | Message of the day shown on login |

## Building

```bash
dotnet build
dotnet test
dotnet run --project src/OpenArcServer.Server
```

## Features (Phase 2)

### PCxx Node Peering

OpenArcServer can accept inbound connections from other DX cluster nodes using the PCxx protocol (used by DX Spider, CC Cluster, and AR-Cluster). This allows spots from peer nodes to be distributed to your connected users, and vice versa.

**Supported PCxx messages:**

| Message | Direction | Description |
|---------|-----------|-------------|
| PC11 | Both | DX spot |
| PC12 | Inbound | Announcement/talk |
| PC16 | Outbound | User connected notification |
| PC17 | Outbound | User disconnected notification |
| PC18 | Inbound | Init request from peer |
| PC19 | Outbound | Node topology exchange |
| PC20 | Outbound | Handshake turnaround |
| PC21 | Both | Node disconnected |
| PC22 | Outbound | Init complete |
| PC38 | Outbound | Init start response |
| PC51 | Both | Ping/pong keepalive |

**Inbound handshake** (peer connects to us):
```
Us   → PC18^OURNODECALL^
Peer → PC38^software^PEERCALL^version^
Us   → PC19^...nodes...^
Us   → PC20^OURNODECALL^
Us   → PC22^OURNODECALL^
Us   → PC16^user^OURNODECALL^^^  (one per connected user)
```

**Outbound handshake** (we connect to peer):
```
Peer → PC18^PEERCALL^
Us   → PC38^OpenArcServer^OURNODECALL^version^
Peer → PC19^...nodes...^
Peer → PC20^PEERCALL^
Peer → PC22^PEERCALL^
```

**Enable PCxx peering** in `appsettings.json`:

```json
{
  "Pcxx": {
    "Enabled": true,
    "Port": 7300,
    "BindAddress": "0.0.0.0",
    "MaxNodeConnections": 50,
    "PingIntervalSeconds": 300,
    "NodeTimeoutMinutes": 30,
    "Peers": [
      { "Host": "dx.somenode.net", "Port": 7300, "Label": "W1AW-2" }
    ]
  }
}
```

Inbound: configure your peer node (e.g., DX Spider) to connect to your IP on port 7300.
Outbound: add entries to `Peers` and OpenArcServer will connect and maintain the link automatically.

### ARx2 Native Client Protocol

The original AR-Cluster client (ArClient) uses **two separate TCP connections** simultaneously:

| Port | Protocol | Direction | Description |
|------|----------|-----------|-------------|
| 7373 | Plain-text telnet | Both | Standard DX cluster: login, spot posting, spot display |
| 3608 | ARx2 native (XML) | Server → Client push | Receives DX spots in real-time as structured XML |

**Architecture (confirmed from Wireshark captures of K1TTT AR-Cluster Server):**

1. Client opens **port 7373** — standard telnet login (`callsign:` prompt, plain-text `DX de ...` spot display), also accepts `AB5K_Client_DxSpot` ARx2 XML frames for posting
2. Client opens **port 3608** — server-initiated ARx2 login handshake, then server pushes `AB5K_Client_Dx` XML frames for each DX spot

**ARx2 login handshake (port 3608):**
```
Server → Client: <AB5K_LoginRqst><Call>K1TTT</Call><Message>Connection Registered</Message><Type>ArcNode</Type></AB5K_LoginRqst>
Client → Server: <AB5K_LoginResp><Call>W0NYY</Call><Message>Connection Response</Message><Type>ArcUser</Type></AB5K_LoginResp>
```

**Wire format:** `[Arx2]{zlib-compressed UTF-8 XML}[/Arx2]`

**Confirmed ARx2 message types:**

| Port | Direction | XML root element | Description |
|------|-----------|-----------------|-------------|
| 3608 | Server → Client | `AB5K_LoginRqst` | Server announces itself on connect |
| 3608 | Client → Server | `AB5K_LoginResp` | Client provides callsign |
| 3608 | Server → Client | `AB5K_Client_Dx` | DX spot broadcast (35-field XML) |
| 7373 | Client → Server | `AB5K_Client_DxSpot` | Post a DX spot |

**Enable ARx2 server** in `appsettings.json`:

```json
{
  "Arx": {
    "Enabled": true,
    "Port": 3608,
    "BindAddress": "0.0.0.0"
  }
}
```

Any unrecognised message type is logged in full (XML text) so new types can be identified and added as discovered.

### Reverse Beacon Network (RBN)

Connect to the RBN telnet feed to receive CW/digital skimmer spots:

```json
{
  "Rbn": {
    "Enabled": true,
    "Host": "telnet.reversebeacon.net",
    "Port": 7000,
    "Callsign": "W1AW",
    "ReconnectDelaySeconds": 30
  }
}
```

RBN spots are inserted into the database and broadcast to all connected telnet users in standard spot format. The `Callsign` field is used to log in to the RBN server.

## Solution Structure

```
src/
  OpenArcServer.Core/              # Interfaces, models, enums, config POCOs
  OpenArcServer.Data/              # SQLite repos, CTY.DAT/BandMode parsers
  OpenArcServer.Engine/            # Commands, routing, distribution, spot pipeline
  OpenArcServer.Protocols.Telnet/  # TCP server, connection handler, login state machine
  OpenArcServer.Protocols.Pcxx/    # PCxx node-to-node protocol server
  OpenArcServer.Protocols.Arx/     # ARx2 native client protocol server (port 3608)
  OpenArcServer.Server/            # Generic Host, DI wiring, appsettings.json
tests/
  OpenArcServer.Engine.Tests/
  OpenArcServer.Data.Tests/
  OpenArcServer.Integration.Tests/
docs/
  PROTOCOL-REFERENCE.md           # Protocol specs and compatibility research
  IMPLEMENTATION-PLAN.md           # Phase 1 build plan
data/                              # Reference data files
```

## Features (Phase 3)

### DX Spot Filtering

Each connected user can apply real-time filters so they only receive spots matching their interests. Filters persist for the session; `SH/FILTER` shows the current settings.

| Command | Description |
|---------|-------------|
| `SET/DX/BAND <bands>` | Only receive spots on specified bands (e.g. `20m 40m 15m`) |
| `SET/DX/NOBAND` | Clear band filter — receive all bands |
| `SET/DX/MODE <modes>` | Only receive spots for specified modes (e.g. `CW SSB FT8`) |
| `SET/DX/NOMODE` | Clear mode filter |
| `SET/DX/CONT <conts>` | Only receive spots from specified continents (`NA EU AF AS SA OC AN`) |
| `SET/DX/NOCONT` | Clear continent filter |
| `SET/DX/CQ <zones>` | Only receive spots from specified CQ zones (1-40) |
| `SET/DX/NOCQ` | Clear CQ zone filter |
| `SET/SKIMMER` | Enable skimmer/RBN spots (default) |
| `SET/NOSKIMMER` | Suppress skimmer/RBN spots |
| `SH/FILTER` | Show your current filter settings |

`SH/DX` also applies the user's active filter to the spot history listing.

### Station Profile (SET Commands)

| Command | Description |
|---------|-------------|
| `SET/NAME <name>` | Set your operator name (persisted across sessions) |
| `SET/QTH <location>` | Set your QTH / location description |
| `SET/GRID <grid>` | Set your Maidenhead grid square (e.g. `FN42`) |
| `SET/EMAIL <address>` | Set your email address |
| `SET/DXCOUNT <n>` | Set default number of spots shown by `SH/DX` (1-100) |
| `SH/STA [callsign]` | Show station info for yourself or another user |

### Talk & Announcements

| Command | Description |
|---------|-------------|
| `T <callsign> <message>` | Send a private talk message to a connected user |
| `ANN <message>` | Broadcast an announcement to all connected users |

Private talk format: `Talk(W1AW) hello there` delivered directly to the recipient; the sender sees an echo `Talk(to W1AW) hello there`.

Announcement format: `To ALL de W1AW    : Hello everyone!                             1530Z`

### WWV / Propagation Reports

| Command | Description |
|---------|-------------|
| `WWV <sfi> <a> <k> [forecast]` | Post a WWV solar/geomagnetic propagation report |
| `SH/WWV [n]` | Show last *n* WWV reports (default 5) |

Format: `WWV de W1AW     <04-APR-2026>: SFI=150, A=5, K=2, No Storms             1530Z`

### Weather Reports

| Command | Description |
|---------|-------------|
| `WX <message>` | Post a weather announcement broadcast to all users |
| `SH/WX [n]` | Show last *n* WX reports (default 5) |

Format: `WX de W1AW      <04-APR-2026>: Sunny and warm, winds SW 10 mph           1530Z`

### Buddy List Alerts

| Command | Description |
|---------|-------------|
| `ADD/BUDDY <callsign>` | Add a callsign to your buddy list (persisted in DB) |
| `DEL/BUDDY <callsign>` | Remove a callsign from your buddy list |
| `SH/BUDDY` | Show your buddy list with online/offline status |

When a buddy connects or disconnects, online users who have them on their list receive an instant alert:
```
*** Buddy W1AW has connected to the cluster ***
```

## Roadmap

### Phase 2 — Networking ✓
- [x] PCxx inbound: accept connections from DX Spider, CC Cluster, etc.
- [x] PCxx outbound: connect TO configured peer nodes with auto-reconnect
- [x] Spot/announcement distribution to peer nodes (PC11, PC12)
- [x] Node topology management (PC16-PC22, PC38, PC51)
- [x] SH/N — show connected nodes
- [x] Reverse Beacon Network (RBN) telnet feed integration
- [x] ARx2 native client protocol (original AR-Cluster client support)

### Phase 3 — Advanced Features ✓
- [x] DX spot filtering (band, mode, continent, CQ zone) per user
- [x] Skimmer/RBN spot toggle (SET/SKIMMER, SET/NOSKIMMER)
- [x] WWV/WX propagation data (post + query, persisted in DB)
- [x] Talk / private messaging (T command)
- [x] Announcements (ANN command)
- [x] `SET` commands (SET/NAME, SET/QTH, SET/GRID, SET/EMAIL, SET/DXCOUNT)
- [x] SH/STA station info (self + any callsign)
- [x] Buddy list alerts (ADD/BUDDY, DEL/BUDDY, SH/BUDDY, connect/disconnect notifications)

### Phase 4 — Modern Enhancements
- [ ] WebSocket server for browser clients
- [ ] REST API
- [ ] Web-based admin dashboard
- [ ] Docker container support
- [ ] Prometheus metrics
- [ ] Systemd/launchd service integration

## Contributing

Contributions welcome! Key areas:
- Protocol testing with real DX cluster clients (N1MM+, DXLab, Logger32)
- PCxx compatibility testing against DX Spider nodes
- Unit and integration tests
- Phase 2+ features

## Protocol & Architecture Reference

See [docs/PROTOCOL-REFERENCE.md](docs/PROTOCOL-REFERENCE.md) for protocol specifications, database schema, networking architecture, and data file format analysis used to build compatibility with existing AR-Cluster clients.

## License

MIT License

## Acknowledgments

- **Terry Gerdes, AB5K (SK)** — Original AR-Cluster Server author. This project continues his legacy.
- The amateur radio DX cluster community
