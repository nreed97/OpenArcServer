# OpenArcServer

An open-source, cross-platform DX cluster server compatible with AR-Cluster, DX Spider, and common logging software (N1MM+, DXLab, Logger32).

## Background

**AR-Cluster Server** was a popular DX cluster server created by Terry Gerdes, AB5K (SK). With the original author having passed away and no source code available, this project recreates a compatible server that works with the thousands of existing DX cluster clients deployed worldwide.

Built through protocol analysis and compatibility research of the AR-Cluster Server ecosystem (version 6.1, January 2014). OpenArcServer is an independent, clean-room implementation sharing no code with the original.

## Features

### Protocols

| Protocol | Port | Description |
|----------|------|-------------|
| Telnet | 7373 | Standard DX cluster — all logging software |
| ARx2 native | 3608 | AR-Cluster native XML push protocol |
| PCxx node peering | 7300 | DX Spider / CC Cluster inter-node spots |
| WebSocket | 7374 | Browser-compatible real-time spot stream |
| REST API / Admin | 8080 | Admin dashboard + JSON API |

### Telnet Commands

| Command | Description |
|---------|-------------|
| `DX <freq> <call> [comment]` | Post a DX spot |
| `SH/DX [n] [call]` | Show last n spots, optionally by callsign |
| `SH/DX/<band>` | Show spots on a specific band (e.g. `SH/DX/20m`) |
| `SH/DX/<mode>` | Show spots in a specific mode (e.g. `SH/DX/CW`) |
| `SH/DX/<band>/<mode>` | Combine band and mode (e.g. `SH/DX/20m/CW`) |
| `SH/U` | Show connected users |
| `SH/N` | Show connected cluster nodes |
| `SH/CONNECT` | Detailed peer node diagnostics |
| `SH/STATS` | Server statistics (uptime, spots today, peak users) |
| `SH/SOLAR` | Grayline info — sub-solar point, sunrise/sunset |
| `SH/FILTER` | Show your current spot filter settings |
| `SH/WWV [n]` | Show recent propagation reports |
| `SH/WX [n]` | Show recent weather reports |
| `SH/STA` | Show your station profile |
| `SH/VERSION` | Show server version |
| `SH/TIME` | Show current UTC time |
| `SET/DX/BAND <bands>` | Persistent band filter (e.g. `SET/DX/BAND 20m 40m`) |
| `SET/DX/NOBAND` | Clear band filter |
| `SET/DX/MODE <modes>` | Persistent mode filter (e.g. `SET/DX/MODE CW`) |
| `SET/DX/NOMODE` | Clear mode filter |
| `SET/DX/CONT <conts>` | Continent filter (NA EU AF AS OC SA AN) |
| `SET/DX/NOCONT` | Clear continent filter |
| `SET/DX/CQ <zones>` | CQ zone filter (1-40) |
| `SET/DX/NOCQ` | Clear CQ zone filter |
| `SET/NAME <name>` | Set your name |
| `SET/QTH <qth>` | Set your QTH |
| `SET/GRID <locator>` | Set your Maidenhead grid square |
| `SET/EMAIL <email>` | Set your email |
| `SET/DXCOUNT <n>` | Set default spot count for SH/DX |
| `SET/SKIMMER` / `SET/NOSKIMMER` | Toggle CW skimmer spots |
| `SET/RBN` / `SET/NORBN` | Toggle Reverse Beacon Network spots |
| `ADD/BUDDY <call>` | Add a callsign to your buddy alert list |
| `DEL/BUDDY <call>` | Remove from buddy list |
| `SH/BUDDY` | Show your buddy list |
| `WWV <SFI> <A> <K> [forecast]` | Post a propagation report |
| `WX <message>` | Post a weather report |
| `TALK <call> <message>` | Send a private message |
| `ANN <message>` | Broadcast an announcement |
| `TEST/DX <freq> <call>` | Post a local test spot (not propagated) |
| `HELP` | List available commands |
| `BYE` | Disconnect |

### Spot Processing

- Column-exact AR-Cluster spot format (compatible with all logging software)
- Callsign validation on login (amateur callsign regex)
- CTY.DAT country/prefix lookup (`cty_wt_mod.dat`) for band, mode, continent, and CQ zone enrichment
- Duplicate spot detection (configurable window, default 20 min)
- Bad word filter on comments
- Optional amateur band plan enforcement (rejects spots outside BandMode.dat ranges)
- Per-user real-time spot filters (band, mode, continent, CQ zone) — persists across commands

### Automated Space Weather

When enabled, OpenArcServer fetches solar and geomagnetic data from NOAA SWPC on a configurable interval and posts it as a WWV propagation report visible to all connected users:

- **SFI** (F10.7 cm solar flux) from `services.swpc.noaa.gov/json/f107_cm_flux.json`
- **K** (3-hourly planetary Kp) and **A** (running A-index) from `services.swpc.noaa.gov/products/noaa-planetary-k-index.json`

### Admin Dashboard

Web-based dashboard at `http://yourserver:8080/` with:

- Live stats: connected users, nodes, WebSocket clients, spots in DB
- Recent DX spots table with auto-refresh
- Connected users table with per-user spot filter editor
- Connected nodes table with spot counters and uptime
- WWV propagation history
- Server endpoints panel
- Live log viewer (tail the current Serilog rolling file)
- MOTD editor
- Filter file editors (BadWord, CallBlock, ConnectBlock, DxSpotBlock, IpBlock)
- Peer node management (add/remove/enable ARx and PCxx peers)
- Settings editor (all appsettings.json sections)
- Admin announcement broadcast
- Graceful restart
- Data file hot-reload (CTY.DAT, BandMode.dat, all filter lists) without restarting

### Security

- SHA-256 hashed admin key (`AdminKeyHash` in `appsettings.json`)
- Per-IP connection rate limiting (configurable, default 5/min)
- Per-user command rate limiting (configurable, default 60 commands/min; sliding window)
- IP block list (`IpBlock.dat`) — checked at TCP accept time before login
- Connect block list for callsigns
- Idle timeout enforcement (configurable; 0 = disabled)

### Observability

- Serilog structured logging (console + rolling daily log files, 7-day retention)
- Prometheus metrics at `/metrics` (`prometheus-net.AspNetCore`)
- `openarcserver_db_spots_total` gauge updated hourly

### Service Integration

- Runs as a **systemd** service on Linux
- Runs as a **Windows Service**
- Docker-compatible (no OS-specific dependencies)

---

## Quick Start

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- CTY.DAT file — download `cty_wt_mod.dat` from [country-files.com](https://www.country-files.com/contest/ct/) and place it in `src/OpenArcServer.Server/data/`

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

Admin dashboard: `http://localhost:8080/`

---

## Configuration

All configuration lives in `src/OpenArcServer.Server/appsettings.json`. A minimal example:

```json
{
  "Server": {
    "NodeCallsign": "W1AW-2",
    "SysopCallsign": "W1AW",
    "ServerName": "OpenArcServer",
    "MotdFile": "data/motd.txt"
  },
  "Telnet": {
    "Enabled": true,
    "Port": 7373,
    "MaxConnections": 200,
    "IdleTimeoutMinutes": 60
  },
  "Api": {
    "Enabled": true,
    "Port": 8080,
    "AdminKeyHash": "<sha256 of your admin key>"
  }
}
```

Generate an `AdminKeyHash`:

```bash
echo -n "yourpassword" | sha256sum
# or via the dashboard: POST /api/admin/keyhash { "key": "yourpassword" }
```

### Full Configuration Reference

<details>
<summary>appsettings.json sections</summary>

```json
{
  "Server": {
    "NodeCallsign": "W1AW-2",
    "SysopCallsign": "W1AW",
    "ServerName": "OpenArcServer",
    "Version": "1.0.0",
    "MotdFile": "data/motd.txt"
  },
  "Telnet": {
    "Enabled": true,
    "Port": 7373,
    "BindAddress": "0.0.0.0",
    "MaxConnections": 200,
    "IdleTimeoutMinutes": 60,
    "IntroMessage": "AR-Cluster Server\r\n\r\nPlease enter your callsign: ",
    "WelcomeMessage": "Hello {Callsign}, welcome to {NodeCallsign}\r\n",
    "InvalidCallsignMessage": "Invalid callsign. Please try again: ",
    "BlockedMessage": "Sorry, you are not permitted to connect to this cluster."
  },
  "Database": {
    "ConnectionString": "Data Source=data/openarcserver.db",
    "DxSpotRetentionDays": 30,
    "DxSpotMaxCount": 250000,
    "UserRetentionYears": 3
  },
  "DataFiles": {
    "CtyDatPath": "data/cty_wt_mod.dat",
    "BandModePath": "data/BandMode.dat",
    "BadWordPath": "data/BadWord.dat",
    "CallBlockPath": "data/CallBlock.dat",
    "ConnectBlockPath": "data/ConnectBlock.dat",
    "DxSpotBlockPath": "data/DxSpotBlock.dat",
    "IpBlockPath": "data/IpBlock.dat"
  },
  "SpotProcessing": {
    "MaxCommentLength": 30,
    "MaxFrequencyKhz": 500000.0,
    "MinFrequencyKhz": 1800.0,
    "EnableBadWordFilter": true,
    "EnableDuplicateDetection": true,
    "DuplicateWindowMinutes": 20,
    "EnforceBandPlan": false
  },
  "RateLimit": {
    "Enabled": true,
    "MaxCommandsPerMinute": 60,
    "MaxConnectionsPerIpPerMinute": 5
  },
  "SpaceWeather": {
    "Enabled": false,
    "FetchIntervalMinutes": 60,
    "InitialDelayMinutes": 2,
    "AutoSpotter": "NOAA-SWPC"
  },
  "Pcxx": {
    "Enabled": true,
    "Port": 7300,
    "MaxNodeConnections": 50,
    "PingIntervalSeconds": 300,
    "NodeTimeoutMinutes": 30,
    "Peers": [
      { "Host": "dx.example.net", "Port": 7300, "Label": "W9DX-2", "Enabled": true }
    ]
  },
  "Arx": {
    "Enabled": true,
    "Port": 3608,
    "Peers": [
      { "Host": "arx.example.net", "Port": 3608, "Enabled": true }
    ]
  },
  "Rbn": {
    "Enabled": false,
    "Host": "telnet.reversebeacon.net",
    "Port": 7000,
    "Callsign": "W1AW"
  },
  "WebSocket": {
    "Enabled": true,
    "Port": 7374
  },
  "Api": {
    "Enabled": true,
    "Port": 8080,
    "AdminKeyHash": "<sha256hex>"
  }
}
```

</details>

---

## Data Files

Files go in `data/` relative to the server binary (or wherever `appsettings.json` points):

| File | Description |
|------|-------------|
| `cty_wt_mod.dat` | CTY.DAT country prefix database — download from [country-files.com](https://www.country-files.com/contest/ct/) |
| `BandMode.dat` | Band/mode frequency ranges (included) |
| `CallBlock.dat` | Callsigns blocked from all commands |
| `ConnectBlock.dat` | Callsigns blocked from logging in |
| `DxSpotBlock.dat` | Callsigns whose DX spots are rejected |
| `BadWord.dat` | Words filtered from spot comments |
| `IpBlock.dat` | IP addresses blocked at TCP accept time |
| `motd.txt` | Message of the day shown after login |

All filter files can be hot-reloaded without restarting via `POST /api/admin/reload` or the dashboard.

---

## PCxx Node Peering

OpenArcServer speaks the PCxx protocol used by DX Spider, CC Cluster, and AR-Cluster for inter-node spot propagation.

**Supported PCxx messages:**

| Message | Description |
|---------|-------------|
| PC11 | DX spot |
| PC12 | Announcement/talk |
| PC16/17 | User connect/disconnect |
| PC18/19/20/21/22/38 | Node handshake and topology |
| PC51 | Ping/keepalive |

**Outbound peers:** add entries to `Pcxx.Peers` and OpenArcServer will connect and maintain the link automatically with exponential-backoff reconnect.

**Inbound:** configure your peer node to connect to your IP on port 7300.

---

## ARx2 Native Protocol

The original AR-Cluster client uses a second connection on port 3608 for real-time XML spot push. OpenArcServer supports both:

- **Server mode** (port 3608): accepts connections from AR-Cluster client software, sends `AB5K_Client_Dx` XML frames in real-time
- **Outbound peering**: connects to other ARx2 nodes and receives `AB5K_Client_DxSpot` frames

Wire format: `[Arx2]{zlib-compressed UTF-8 XML}[/Arx2]`

---

## REST API

Base URL: `http://yourserver:8080/api`

### Public endpoints

| Method | Path | Description |
|--------|------|-------------|
| GET | `/spots?count=N` | Recent DX spots (max 500) |
| GET | `/users` | Connected users |
| GET | `/nodes` | Connected peer nodes |
| GET | `/wwv?count=N` | Recent propagation reports |
| GET | `/wx?count=N` | Recent weather reports |
| GET | `/stats` | Server stats (users, nodes, spot count) |

### Admin endpoints (require `X-Admin-Key` header)

| Method | Path | Description |
|--------|------|-------------|
| GET | `/admin/settings` | Read appsettings.json |
| PUT | `/admin/settings` | Update appsettings.json |
| GET | `/admin/peers` | List ARx and PCxx peers |
| PATCH | `/admin/peers/{type}/{index}/enabled` | Toggle a peer |
| GET | `/admin/filters/{name}` | Read a filter file |
| PUT | `/admin/filters/{name}` | Write a filter file |
| GET | `/admin/users/{callsign}/filter` | Read connected user's spot filter |
| PUT | `/admin/users/{callsign}/filter` | Set connected user's spot filter |
| DELETE | `/admin/users/{callsign}` | Disconnect a user |
| GET | `/admin/motd` | Read MOTD |
| PUT | `/admin/motd` | Write MOTD |
| GET | `/admin/logs?lines=N` | Tail the current log file |
| POST | `/admin/announce` | Broadcast an announcement |
| POST | `/admin/reload` | Hot-reload data files |
| POST | `/admin/restart` | Graceful restart |
| POST | `/admin/keyhash` | Generate SHA-256 hash of a key |

---

## Running as a Service

### systemd (Linux)

```ini
[Unit]
Description=OpenArcServer DX Cluster
After=network.target

[Service]
Type=notify
WorkingDirectory=/opt/openarcserver
ExecStart=/usr/bin/dotnet /opt/openarcserver/OpenArcServer.Server.dll
Restart=always
RestartSec=10

[Install]
WantedBy=multi-user.target
```

### Windows Service

```powershell
sc.exe create OpenArcServer binpath= "C:\path\to\OpenArcServer.Server.exe"
sc.exe start OpenArcServer
```

### Docker

```dockerfile
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY publish/ .
EXPOSE 7373 3608 7300 7374 8080
ENTRYPOINT ["dotnet", "OpenArcServer.Server.dll"]
```

---

## Building

```bash
dotnet build
dotnet run --project src/OpenArcServer.Server
```

Publish for deployment:

```bash
dotnet publish src/OpenArcServer.Server -c Release -o publish/
```
