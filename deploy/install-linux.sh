#!/usr/bin/env bash
# install-linux.sh — Install OpenArcServer as a systemd service on Linux
# Run as root: sudo bash deploy/install-linux.sh
set -euo pipefail

INSTALL_DIR=/opt/openarcserver
SERVICE_USER=openarcserver
SERVICE_FILE=/etc/systemd/system/openarcserver.service
PUBLISH_DIR="$(dirname "$0")/../publish"

echo "==> OpenArcServer Linux installer"

# 1. Create service user if it doesn't exist
if ! id "$SERVICE_USER" &>/dev/null; then
    echo "==> Creating system user: $SERVICE_USER"
    useradd --system --no-create-home --shell /usr/sbin/nologin "$SERVICE_USER"
fi

# 2. Publish the application
echo "==> Publishing application..."
cd "$(dirname "$0")/.."
dotnet publish src/OpenArcServer.Server/OpenArcServer.Server.csproj \
    -c Release -o "$INSTALL_DIR" --no-build 2>/dev/null || \
dotnet publish src/OpenArcServer.Server/OpenArcServer.Server.csproj \
    -c Release -o "$INSTALL_DIR"

# 3. Create data and log directories
mkdir -p "$INSTALL_DIR/data" "$INSTALL_DIR/logs"
chown -R "$SERVICE_USER:$SERVICE_USER" "$INSTALL_DIR"
chmod 755 "$INSTALL_DIR/OpenArcServer.Server" 2>/dev/null || true

# 4. Install systemd unit file
echo "==> Installing systemd service..."
sed "s|/opt/openarcserver|$INSTALL_DIR|g" deploy/openarcserver.service > "$SERVICE_FILE"
chmod 644 "$SERVICE_FILE"

# 5. Reload systemd and enable service
systemctl daemon-reload
systemctl enable openarcserver.service
systemctl start  openarcserver.service

echo ""
echo "==> Installation complete!"
echo "    Status:  systemctl status openarcserver"
echo "    Logs:    journalctl -u openarcserver -f"
echo "    Config:  $INSTALL_DIR/appsettings.json"
echo "    Data:    $INSTALL_DIR/data/"
echo ""
echo "    IMPORTANT: Set an admin API key in appsettings.json:"
echo '    "Api": { "AdminKey": "your-secret-key" }'
