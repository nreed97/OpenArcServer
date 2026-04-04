# OpenArcServer

An open-source, cross-platform DX cluster server compatible with existing AR-Cluster and DX Spider clients.

## Background

**AR-Cluster Server** was a popular DX cluster server created by Terry Dawson, AB5K (SK). With the original author having passed away and no source code available, this project recreates a compatible server that works with the thousands of existing DX cluster clients deployed worldwide.

Born from reverse engineering the original `ArcServerSetup.msi` installer (version 6.1, January 2014) — a .NET 4.0 WinForms application using SQL Server Compact Edition 3.5.

## Status

**Phase 1 MVP — complete and working.**

The server accepts telnet connections on port 7373 and is compatible with N1MM+, DXLab SpotCollector, Logger32, and any other AR-Cluster telnet client.

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

## Solution Structure

```
src/
  OpenArcServer.Core/              # Interfaces, models, enums, config POCOs
  OpenArcServer.Data/              # SQLite repos, CTY.DAT/BandMode parsers
  OpenArcServer.Engine/            # Commands, routing, distribution, spot pipeline
  OpenArcServer.Protocols.Telnet/  # TCP server, connection handler, login state machine
  OpenArcServer.Server/            # Generic Host, DI wiring, appsettings.json
tests/
  OpenArcServer.Engine.Tests/
  OpenArcServer.Data.Tests/
  OpenArcServer.Integration.Tests/
docs/
  REVERSE-ENGINEERING.md           # Full analysis of original ArcServer
  IMPLEMENTATION-PLAN.md           # Phase 1 build plan
data/                              # Reference data files
```

## Building

```bash
dotnet build
dotnet test
dotnet run --project src/OpenArcServer.Server
```

## Roadmap

### Phase 2 — Networking
- [ ] PCxx protocol for DX Spider node peering
- [ ] Spot/announcement distribution to peer nodes
- [ ] Node topology management (PC16-PC22, PC38)
- [ ] Reverse Beacon Network (RBN) integration

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

## Reverse Engineering

See [docs/REVERSE-ENGINEERING.md](docs/REVERSE-ENGINEERING.md) for the complete analysis of the original ArcServer, including protocol specifications, database schema, networking architecture, and data file formats.

## License

MIT License

## Acknowledgments

- **Terry Dawson, AB5K (SK)** — Original AR-Cluster Server author. This project continues his legacy.
- The amateur radio DX cluster community
