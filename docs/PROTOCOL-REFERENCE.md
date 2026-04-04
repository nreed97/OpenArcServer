# ArcServer (AR-Cluster Server) - Protocol & Compatibility Research

## Overview

**AR-Cluster Server** (ArcServer) was a DX cluster server application written by **Terry Gerdes, AB5K** (SK - Silent Key). It was a .NET 4.0 Windows application using SQL Server Compact Edition 3.5 for data persistence, with Spring.NET for dependency injection. The last known version is **6.1** (build 5123), copyrighted 1998-2013.

This document captures protocol specifications, data formats, and architectural observations gathered through analysis of the AR-Cluster Server ecosystem. OpenArcServer is an independent, clean-room implementation — it shares no code with the original software.

---

## 1. Application Architecture

### Assembly Structure

| Assembly | Size | Purpose |
|----------|------|---------|
| `ArcServer.exe` | 127 KB | Main WinForms application, server UI |
| `ArcEngine.DLL` | 1,013 KB | Core server engine - commands, caching, IO, DB, protocol |
| `ArcShared.DLL` | 745 KB | Shared libraries - TCP server, database helpers, utilities |
| `ArcInterfaces.DLL` | 36 KB | Interface contracts (IArcCmd, spots, configuration) |
| `ArcClientEngine.DLL` | 309 KB | Built-in client engine |
| `ArcClientUi.DLL` | 163 KB | Built-in client UI |
| `ArcCallbookExt.DLL` | 7,122 KB | Callbook extension (US/VE callsign database) |

### Technology Stack (Original)

- **.NET Framework 4.0** (C# / VB.NET mixed)
- **SQL Server Compact Edition 3.5** (`System.Data.SqlServerCe`)
- **Spring.NET** (`Spring.Core.DLL`) for dependency injection
- **log4net** for logging
- **WinForms** UI with `WeifenLuo.WinFormsUI.Docking` for docked panels
- **ZedGraph** for spot rate graphing
- **Meebey.SmartIrc4net** for IRC/mIRC integration
- **ICSharpCode.SharpZipLib** for compression
- **HtmlAgilityPack** for web scraping (callbook lookups)
- **Starksoft.Net.Proxy** for SOCKS proxy support
- **Common.Logging** abstraction layer

### Dependency Injection (Spring.NET)

All commands and caches are configured in `ArcServerDi.xml` using Spring.NET IoC container. Objects are defined as either singletons (caches) or transient instances (commands). This makes the command system highly extensible.

---

## 2. Networking Architecture

### Connection Types

The server supports multiple simultaneous listener/client protocols:

| Protocol | Direction | Description |
|----------|-----------|-------------|
| **Telnet** | Server (inbound) | Standard DX cluster telnet interface |
| **PCxx** | Server/Client | DX Spider-compatible node-to-node protocol |
| **ARx/Arc6** | Server/Client | AR-Cluster's native XML-based protocol |
| **Arc4Active** | Client | Legacy AR-Cluster 4 active connection |
| **Arc4Passive** | Server | Legacy AR-Cluster 4 passive connection |
| **AgwBpqTcp** | Server | AGW/BPQ packet radio gateway |
| **mIRC** | Client | IRC-based DX spot feed |
| **ReverseBeacon** | Client | Reverse Beacon Network feed |

### TCP Server Implementation (`ArcShared.ArcIo.Tcp.TcpServer`)

- Standard `System.Net.Sockets.Socket` with `SocketType.Stream`
- Binds to `IPAddress.Any` on configurable port
- **Dual-stack**: Separate IPv4 and IPv6 listener threads
- Async `BeginAccept()` pattern for inbound connections
- **1024-byte buffer** per client
- Client cleanup timer every 5 minutes (300,000 ms)
- Concurrent client queue for thread-safe message processing

### Connection State Machine

Each connection is tracked via `ArcConnect` with states:

```
TelnetUser    - Telnet client user session
PcxxNode      - PCxx cluster node connection
PcxxUser      - User connected through a PCxx node
ArxNode       - ARx6 cluster node connection
ArxClient     - ARx6 client connection
AgwBpqUser    - AGW/BPQ packet radio user
RcvOnly       - Receive-only (monitoring) connection
```

### Connection Handshake Flows

**Telnet User Connection:**
1. Client connects to telnet port
2. Server creates `ArcConnect` object
3. Sets EOF character for message boundary detection
4. Fires `OnConnectEvent` to create user session
5. User issues commands in text format

**PCxx Node Connection:**
1. Node connects to PCxx port
2. Server sends `PC18` (init) command
3. Awaits `PC38` (init start) response
4. Exchanges `PC19` (add node) messages
5. `PC20` turnaround, then `PC22` (init complete)
6. Node is registered in cluster topology

**ARx Node Connection:**
1. Node connects to ARx port
2. XML `ArcLogInRqst` / `ArcLogInResp` exchange
3. Bi-directional XML message streaming

---

## 3. Protocol Specifications

### Telnet User Commands

Users connect via telnet and issue text commands:

| Command | Example | Description |
|---------|---------|-------------|
| `DX` | `DX 14025 W1AW good signal` | Post a DX spot |
| `SH/DX` | `SH/DX` | Show recent DX spots |
| `SH/DX <call>` | `SH/DX W1AW` | Show spots for a callsign |
| `ANN` | `ANN hello everyone` | Post announcement (local) |
| `ANN/FULL` | `ANN/FULL hello` | Post announcement (network-wide) |
| `WX` | `WX sunny and warm` | Post weather report |
| `WX/FULL` | `WX/FULL wx report` | Network-wide weather |
| `TALK` | `TALK W1AW hey there` | Private message to user |
| `SH/WWV` | `SH/WWV` | Show propagation data |
| `SH/WX` | `SH/WX` | Show weather reports |
| `SH/ANN` | `SH/ANN` | Show announcements |
| `SH/U` | `SH/U` | Show connected users |
| `SH/CLUSTER` | `SH/CLUSTER` | Show connected clusters |
| `SH/NODE` | `SH/NODE` | Show connected nodes |
| `SH/SUN` | `SH/SUN` | Show sunrise/sunset |
| `SH/HEADING` | `SH/HEADING JA` | Show beam heading |
| `SH/PREFIX` | `SH/PREFIX W` | Show prefix info |
| `SH/HAM` | `SH/HAM W1AW` | Look up callsign |
| `SH/HAMQTH` | `SH/HAMQTH W1AW` | Look up on HamQTH |
| `SH/QSLINFO` | `SH/QSLINFO W1AW` | QSL route info |
| `SH/LOG` | `SH/LOG` | Show activity log |
| `SH/VERSION` | `SH/VERSION` | Show server version |
| `SH/UPTIME` | `SH/UPTIME` | Show server uptime |
| `SH/TIME` | `SH/TIME` | Show UTC date/time |
| `SH/GRAYLINE` | `SH/GRAYLINE` | Show grayline info |
| `SH/CONTEST` | `SH/CONTEST` | Show contest station info |
| `SH/PERFORMANCE` | `SH/PERFORMANCE` | Show server performance |
| `SET/STA/NAME` | `SET/STA/NAME John` | Set your name |
| `SET/STA/QTH` | `SET/STA/QTH Dallas TX` | Set your QTH |
| `SET/STA/GRID` | `SET/STA/GRID EM13` | Set grid square |
| `SET/STA/EMAIL` | `SET/STA/EMAIL a@b.com` | Set email |
| `SET/STA/LATLON` | `SET/STA/LATLON ...` | Set lat/lon |
| `SET/DX/FILTER` | `SET/DX/FILTER ...` | Set DX spot filters |
| `SET/DX/MODE` | `SET/DX/MODE CW` | Set preferred mode |
| `SET/DX/COUNT` | `SET/DX/COUNT 25` | Set # spots returned |
| `SET/ANN/FILTER` | `SET/ANN/FILTER ...` | Set announcement filters |
| `SET/WX/FILTER` | `SET/WX/FILTER ...` | Set weather filters |
| `SET/WWV/COUNT` | `SET/WWV/COUNT 10` | Set WWV line count |
| `BYE` | `BYE` | Disconnect |
| `CLEAR` | `CLEAR` | Clear screen |
| `HELP` | `HELP` | Show help |

**Legacy AR-Cluster 4 commands** are also supported:
- `SET/ANNOUNCEMENTS`, `SET/NOANNOUNCEMENTS`
- `SET/DX/BOB`, `SET/NODX/BOB`
- `SET/DXS/CTY`, `SET/NODXS/CTY`
- `SET/BEEP`, `SET/NOBEEP`
- `SET/TALK`, `SET/NOTALK`
- `SET/WWV`, `SET/NOWWV`
- `SET/WEATHER`, `SET/NOWEATHER`
- `SET/LOGIN`, `SET/NOLOGIN`
- `SH/SETTINGS`

### PCxx Protocol (DX Spider Compatible)

Messages are delimited by the caret `^` character. Key message types:

#### PC11 - DX Spot
```
PC11^<freq>^<call>^<spotter>^<date>^<time>^<comment>^<spotter_node>^[extended]^
```
Example:
```
PC11^14025.0^W1AW^AB5K^10-Jan-2014^1530Z^Good signal^AB5K-2^
```

#### PC12 - Announcement/Weather
```
PC12^<from>^<to>^<message>^<origin>^<node>^
```

#### PC16 - Add User to Node
```
PC16^<call>^<node>^<flags>^<ip>^
```

#### PC17 - Delete User from Node
```
PC17^<call>^<node>^
```

#### PC18 - Node Init Request
Sent by server to initiate node handshake.

#### PC19 - Add Node(s)
```
PC19^<count>^<node1>^<port1>^<version1>^<flags1>^[<node2>^<port2>^...]^<origin>^
```

#### PC20 - Init Turnaround
Signals end of initial node list exchange.

#### PC21 - Delete Node
```
PC21^<node>^<origin>^
```

#### PC22 - Init Complete
Signals initialization handshake is finished.

#### PC23 - WWV Propagation Data
```
PC23^<sfi>^<a>^<k>^<forecast>^<spotter>^<node>^<time>^
```

#### PC38 - Init Start
Response to PC18, begins the initialization sequence.

#### PC41 - User Info
Extended user information exchange.

#### PC51 - Ping
Keepalive/latency check between nodes.

### ARx Protocol (XML-based)

AR-Cluster 6's native protocol uses XML serialization:
- `ArcLogInRqst` - Login request
- `ArcLogInResp` - Login response
- Subsequent messages are XML-serialized spot/command objects
- Detected by `<` character at start of message

### DX Spot Telnet Output Format

DX spots are sent to telnet clients in a fixed-width format:

**Standard format (26-char comment):**
```
DX de <spotter>:    <freq>  <call>        <comment>               <time>Z
```
Example:
```
DX de AB5K:         14025.0  W1AW         Good signal             1530Z
```

**Extended format (30-char comment):**
```
DX de <spotter>:    <freq>  <call>        <30-char comment>            <time>Z
```

---

## 4. Database Schema

### SQL Server Compact Edition 3.5

Two database files:
- **`ArClusterDb.sdf`** - Main cluster data (DX spots, announcements, WWV, weather, logs)
- **`ArClusterPvtDb.sdf`** - Private/local data (user profiles, mail)

### DX Spots Table

| Column | Type | Description |
|--------|------|-------------|
| Call | string | Spotted station callsign |
| Spotter | string | Reporting station callsign |
| SpotterNode | string | Originating node |
| Freq | float | Frequency in kHz |
| Band | float | Band designation |
| Mode | string | Operating mode (CW, SSB, etc.) |
| Cty | string | DXCC country |
| State | string | US state |
| County | string | US county |
| Cont | string | Continent |
| CqZone | int | CQ zone |
| ItuZone | int | ITU zone |
| SpotterCty | string | Spotter's country |
| SpotterState | string | Spotter's state |
| SpotterCont | string | Spotter's continent |
| SpotterCqZone | int | Spotter's CQ zone |
| SpotterItuZone | int | Spotter's ITU zone |
| Comment | string | Spot comment text |
| Grid | string | Grid square |
| Name | string | Station name |
| Route | string | Network route |
| DupeKey | string | Deduplication key |
| Dts | datetime | Spot timestamp |
| DtsRx | datetime | Received timestamp |
| Lotw | bool | LOTW user flag |
| Bob | bool | Bearing/distance flag |
| Cq | bool | CQ flag |
| Master | bool | Master callsign list match |
| InCb | bool | In callbook flag |
| Top100 | bool | Top 100 most wanted |
| Ham | bool | HAM lookup available |
| Foc | bool | FOC member |
| IsDupe | bool | Duplicate spot flag |
| Buddy | bool | On buddy list |
| Atno | bool | All-time new one |
| BndMode | string | Band/mode key |
| Skimmer | bool | From skimmer |
| SkimQsy | bool | Skimmer QSY flag |
| SkimDupe | bool | Skimmer duplicate |
| SkimWpm | int | CW speed (WPM) |
| SkimDb | float | Signal strength (dB) |
| SkimCtyCnt | int | Skimmer country count |
| IsSkimValid | bool | Valid skimmer spot |
| IsSkimBusted | bool | Busted skimmer spot |
| IsSkimUnknown | bool | Unknown skimmer status |

### Database Retention Defaults

| Data Type | In-Memory Cache | Database Retention |
|-----------|----------------|-------------------|
| DX Spots | 20 minutes | 30 days, max 250,000 |
| Announcements | 30 minutes | 30 days |
| WWV | 30 minutes | 30 days |
| Weather | 30 minutes | 30 days |
| Talk/Chat | 30 minutes | 30 days |
| Users | - | 3 years |
| Logs | 30 minutes | 30 days |

---

## 5. Data Files

### Configuration Files

| File | Purpose |
|------|---------|
| `ArcServer.exe.config` | .NET config - connection strings, WCF endpoints, user settings |
| `ArcServerDi.xml` | Spring.NET DI container - all command/cache object definitions |
| `ArcServerLog4net.xml` | Logging configuration |
| `ArcServerConnections.dat` | Node connection definitions (binary) |
| `ArcClientDi.xml` | Client-side DI container |
| `ArcClientLog4net.xml` | Client logging config |

### Reference Data Files

| File | Format | Description |
|------|--------|-------------|
| `Cty_wt_mod.dat` | Text | Country/prefix database (640 KB, CTY format) |
| `DXCC.dat` | Text | DXCC entity list (60 KB) |
| `Master.scp.dat` | Text | Master callsign database (330 KB, Super Check Partial) |
| `BandMode.dat` | Text | Band/mode frequency ranges |
| `States.dat` | Text | US state list |
| `Provinces.dat` | Text | Canadian province list |
| `DxPubTop100.dat` | Text | Top 100 most wanted DXCC entities |
| `FocMembers.dat` | Text | First Class CW Operators Club member list |
| `LotwUsers.dat` | Text | ARRL Logbook of the World user list (495 KB) |
| `Buddies.dat` | Text | Buddy callsign list |

### Security/Filtering Files

| File | Format | Description |
|------|--------|-------------|
| `BadWord.dat` | Text | Profanity filter word list |
| `CallBlock.dat` | Text | Blocked callsigns (can't post) |
| `ConnectBlock.dat` | Text | Blocked callsigns (can't connect) |
| `DxSpotBlock.dat` | Text | Blocked DX spot patterns |
| `IpLockout.dat` | Text | Blocked IP addresses |

### Chat Rooms

| File | Format | Description |
|------|--------|-------------|
| `ChatRoomPub.dat` | Text | Public chat rooms: SOLAR, MBAND, 50PROP, SYSOP |
| `ChatRoomPvt.dat` | Text | Private chat rooms with member lists |

### Multimedia

- **WAV files**: 36 sound files for CW callsign readout (A-Z, 0-9) plus alert sounds
- `ArTechCallSignEmpty.mdb` - Empty Access database template for callbook
- `Global.ico` - Application icon

---

## 6. External Services

The server connects to external web services:

1. **QSL Info** - `http://www.qslinfo.de/qslinfo.asmx` (SOAP)
   - QSL route lookup service

2. **ARx Web Service** - `http://ab5k.net/ArxWebServices/ArxWebService.svc` (WCF)
   - AR-Cluster's own web service (likely defunct now)

3. **HamQTH.com** - Callsign lookup via web scraping
4. **Reverse Beacon Network** - CW skimmer spot feed

---

## 7. Cache System Architecture

All caches extend a common pattern:
1. **Singleton** lifetime via Spring.NET DI
2. **In-memory DataTable** for fast access
3. **Background DB sync** for persistence
4. **Configurable TTL** for memory and DB retention
5. **Thread-safe** access with Monitor locks

### Registered Caches (from ArcServerDi.xml)

```
BadWordCache, BandModeCache, CtyCache, ChatRoomPvtCache, ChatRoomPubCache,
DxSpotBlockCache, DxClusterListCache, LotwCache, MasterCallCache,
DxSpotUniqueCache, UserCache, CallBlockCache, ConnectBlockCache,
MailCache, IpLockoutCache, ConnectsCache, ProtocolCache, WsPcxxCache,
CallBookExtCache, Top100Cache, LoginMsgCache, FocCache, SkimmerCt1bohCache
```

---

## 8. Message Distribution System

When a command is processed, its response is tagged with a `DistroType`:

| Type | Behavior |
|------|----------|
| `ToRequester` | Reply only to command issuer |
| `ToAll` | Broadcast to all users and nodes |
| `ToUsers` | Send to all connected users only |
| `ToNode` | Send to a specific node |
| `ToNodes` / `ToPcxxNodes` | Broadcast to all connected nodes |
| `ToCall` / `ToCallPlusSsids` | Send to specific callsign |
| `ToPubChatRoom` | Route to public chat room members |
| `ToPvtChatRoom` | Route to private chat room members |
| `ToNil` | Drop (no distribution) |

The `Publisher.Process()` method handles serialization into the appropriate wire format (text for telnet, `^`-delimited for PCxx, XML for ARx) and routes to the correct recipients.

---

## 9. Key Observations for Compatible Implementation

### Must Support for Client Compatibility
1. **Telnet interface** on configurable port - this is how 99% of existing clients connect
2. **Standard DX cluster telnet command set** - DX, SH/DX, ANN, TALK, BYE, SET/*, SH/*
3. **DX spot output format** - fixed-width text matching the standard telnet cluster format
4. **PCxx protocol** - required for node-to-node peering with DX Spider and other clusters
5. **Legacy AR-Cluster 4 commands** - still used by some older clients

### Can Modernize
1. **Database**: SQL Server CE 3.5 is obsolete. Use **SQLite** or **PostgreSQL** for cross-platform
2. **DI Framework**: Spring.NET is abandoned. Use built-in .NET DI or any modern container
3. **UI**: WinForms is Windows-only. Use a **web dashboard** or **headless server** with REST API
4. **Logging**: log4net works but **Serilog** or built-in `ILogger` is more modern
5. **Runtime**: Target **.NET 8/9** for cross-platform (Linux, macOS, Windows)
6. **Configuration**: Move from XML DI config to **JSON/YAML** config files
7. **IRC integration**: SmartIrc4net is dead. Use a modern IRC library if needed

### Architecture Recommendations
1. Keep the **command pattern** (IArcCmd interface) - it's clean and extensible
2. Keep the **cache layer** concept but use modern concurrent collections
3. The **publisher/distribution** model is solid - implement as an event bus
4. Separate the **protocol handlers** into pluggable modules
5. Add **WebSocket** support for modern web clients alongside telnet
6. Add a **REST API** for integration with logging software

---

## 10. Version History

- **AR-Cluster 4**: Legacy version, still had command compatibility
- **AR-Cluster 6 (ArcServer 6.x)**: Major rewrite in .NET, introduced ARx XML protocol
- **Version 6.1 (build 5123)**: Last known release, January 2014
- **Author**: Terry Gerdes, AB5K (Silent Key)
- **Copyright**: 1998-2013
- **MSI Product GUID**: `{14C97260-69EE-48C4-B0EB-90C977C6CE0D}`
