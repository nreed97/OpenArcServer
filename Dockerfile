# ── Build stage ──────────────────────────────────────────────────────────────
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy solution / project files first for layer-cached restore
COPY ["src/OpenArcServer.Core/OpenArcServer.Core.csproj",               "src/OpenArcServer.Core/"]
COPY ["src/OpenArcServer.Data/OpenArcServer.Data.csproj",               "src/OpenArcServer.Data/"]
COPY ["src/OpenArcServer.Engine/OpenArcServer.Engine.csproj",           "src/OpenArcServer.Engine/"]
COPY ["src/OpenArcServer.Protocols.Telnet/OpenArcServer.Protocols.Telnet.csproj",       "src/OpenArcServer.Protocols.Telnet/"]
COPY ["src/OpenArcServer.Protocols.Pcxx/OpenArcServer.Protocols.Pcxx.csproj",           "src/OpenArcServer.Protocols.Pcxx/"]
COPY ["src/OpenArcServer.Protocols.Arx/OpenArcServer.Protocols.Arx.csproj",             "src/OpenArcServer.Protocols.Arx/"]
COPY ["src/OpenArcServer.Protocols.WebSocket/OpenArcServer.Protocols.WebSocket.csproj", "src/OpenArcServer.Protocols.WebSocket/"]
COPY ["src/OpenArcServer.Server/OpenArcServer.Server.csproj",           "src/OpenArcServer.Server/"]

RUN dotnet restore "src/OpenArcServer.Server/OpenArcServer.Server.csproj"

# Copy everything and publish
COPY . .
RUN dotnet publish "src/OpenArcServer.Server/OpenArcServer.Server.csproj" \
    -c Release -o /app/publish --no-restore

# ── Runtime stage ─────────────────────────────────────────────────────────────
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app

# Create data + log directories
RUN mkdir -p /app/data /app/logs

COPY --from=build /app/publish .

# Expose all server ports:
#   7373  Telnet (DX cluster clients)
#   3608  ARx2 native protocol (original AR-Cluster client)
#   7300  PCxx node-to-node peering
#   7374  WebSocket (browser / modern clients)
#   8080  REST API + admin dashboard
EXPOSE 7373 3608 7300 7374 8080

# Mount volumes for persistent data and logs
VOLUME ["/app/data", "/app/logs"]

ENTRYPOINT ["dotnet", "OpenArcServer.Server.dll"]
