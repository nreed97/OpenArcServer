# OpenArcServer

An open-source, cross-platform DX cluster server compatible with existing AR-Cluster and DX Spider clients.

## Background

**AR-Cluster Server** was a popular DX cluster server created by Terry Gerdes, AB5K (SK). With the original author having passed away and no source code available, this project recreates a compatible server that works with the thousands of existing DX cluster clients deployed worldwide.

Built through protocol analysis and compatibility research of the AR-Cluster Server ecosystem (version 6.1, January 2014) — a .NET 4.0 WinForms application. OpenArcServer is an independent, clean-room implementation sharing no code with the original.

## Status

**Phase 2 — PCxx node peering complete and working.**

The server accepts telnet connections on port 7373 and is compatible with N1MM+, DXLab SpotCollector, Logger32, and any other AR-Cluster telnet client. It also accepts inbound PCxx node connections on port 7300 for peering with DX Spider, CC Cluster, and other PCxx-compatible cluster nodes.

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

## Roadmap

### Phase 2 — Networking ✓
- [x] PCxx inbound: accept connections from DX Spider, CC Cluster, etc.
- [x] PCxx outbound: connect TO configured peer nodes with auto-reconnect
- [x] Spot/announcement distribution to peer nodes (PC11, PC12)
- [x] Node topology management (PC16-PC22, PC38, PC51)
- [x] SH/N — show connected nodes
- [x] Reverse Beacon Network (RBN) telnet feed integration

### Phase 3 — Advanced Features
- [ ] DX spot filtering (band, mode, continent, prefix, CQ zone)
- [ ] WWV/WX propagation data
- [ ] Talk / private messaging
- [ ] Chat rooms
- [ ] `SET` commands (SET/STA, SET/QTH, SET/HOME, etc.)
- [ ] Callbook lookups (HamQTH, QRZ)
- [ ] Skimmer spot processing
- [ ] Buddy list alerts

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
