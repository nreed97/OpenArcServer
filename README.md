# OpenArcServer

An open-source, cross-platform DX cluster server compatible with existing AR-Cluster and DX Spider clients.

## Background

**AR-Cluster Server** was a popular DX cluster server created by Terry Dawson, AB5K (SK). With the original author having passed away and no source code available, this project aims to recreate a compatible server that works with the thousands of existing DX cluster clients deployed worldwide.

This project was born from reverse engineering the original `ArcServerSetup.msi` installer (version 6.1, January 2014) - a .NET 4.0 WinForms application using SQL Server Compact Edition 3.5.

## Goals

- **Client compatibility** - Work with all existing DX cluster telnet clients (DXLab, N1MM+, Logger32, etc.)
- **Node compatibility** - Peer with DX Spider, CC Cluster, and other PCxx-protocol cluster nodes
- **Cross-platform** - Run on Linux, macOS, and Windows
- **Modern stack** - .NET 8+, SQLite, containerized deployment
- **Headless operation** - Run as a daemon/service with web dashboard for management
- **Extensible** - Clean command pattern, plugin architecture for extensions

## Supported Protocols

| Protocol | Status | Description |
|----------|--------|-------------|
| Telnet | Planned | Standard DX cluster telnet (primary client interface) |
| PCxx | Planned | DX Spider-compatible node-to-node protocol |
| WebSocket | Planned | Modern web client support |
| REST API | Planned | Integration API for logging software |

## Reverse Engineering Documentation

See [docs/REVERSE-ENGINEERING.md](docs/REVERSE-ENGINEERING.md) for the complete analysis of the original ArcServer, including:

- Full protocol specifications (PCxx message formats, telnet commands)
- Database schema and data model
- Networking architecture
- Cache system design
- Command processing pipeline
- Data file formats

## Architecture (Planned)

```
OpenArcServer/
  src/
    OpenArcServer.Core/          # Interfaces, data models, shared types
    OpenArcServer.Engine/         # Command processing, caching, filtering
    OpenArcServer.Protocols/      # Telnet, PCxx, WebSocket protocol handlers
    OpenArcServer.Data/           # SQLite database layer
    OpenArcServer.Server/         # Host application, configuration, DI
    OpenArcServer.Web/            # Web dashboard (optional)
  tests/
    OpenArcServer.Engine.Tests/
    OpenArcServer.Protocols.Tests/
  docs/
    REVERSE-ENGINEERING.md        # Original ArcServer analysis
```

## Key Features to Implement

### Phase 1 - Core Server
- [ ] TCP/Telnet listener with connection management
- [ ] User authentication (callsign-based login)
- [ ] DX spot posting and retrieval (`DX`, `SH/DX`)
- [ ] Announcement system (`ANN`, `SH/ANN`)
- [ ] User session management (`BYE`, `SH/U`)
- [ ] Basic station settings (`SET/STA/*`)
- [ ] SQLite database for spot persistence
- [ ] CTY.DAT country prefix lookup
- [ ] Duplicate spot detection

### Phase 2 - Networking
- [ ] PCxx protocol for node-to-node peering
- [ ] Spot/announcement distribution to peer nodes
- [ ] Node topology management (PC16-PC22, PC38)
- [ ] Reverse Beacon Network integration

### Phase 3 - Advanced Features
- [ ] DX spot filtering system
- [ ] WWV/WX propagation data
- [ ] Talk/private messaging
- [ ] Chat rooms (public and private)
- [ ] Mail system
- [ ] Callbook lookups (HamQTH, QRZ)
- [ ] Sunrise/sunset, beam heading calculations
- [ ] Skimmer spot processing and validation
- [ ] LOTW user integration
- [ ] Buddy list alerts

### Phase 4 - Modern Enhancements
- [ ] WebSocket server for browser clients
- [ ] REST API
- [ ] Web-based admin dashboard
- [ ] Docker container support
- [ ] Prometheus metrics export
- [ ] Systemd service integration

## Building

*Coming soon - project scaffolding in progress*

```bash
dotnet build
dotnet run --project src/OpenArcServer.Server
```

## Configuration

*Coming soon*

The server will use `appsettings.json` for configuration, replacing the original's XML-based Spring.NET DI config.

## Contributing

Contributions are welcome! This is a community effort to preserve and modernize an important piece of amateur radio infrastructure.

Key areas where help is needed:
- Protocol testing with real DX cluster clients
- PCxx protocol compatibility testing with DX Spider nodes
- Web dashboard development
- Documentation of undocumented protocol features

## License

MIT License

## Acknowledgments

- **Terry Dawson, AB5K (SK)** - Original AR-Cluster Server author. This project exists to continue his legacy and keep the DX cluster network accessible.
- The amateur radio DX cluster community
