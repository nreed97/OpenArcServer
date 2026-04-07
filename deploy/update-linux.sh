#!/usr/bin/env bash
# update-linux.sh — Pull latest changes and redeploy OpenArcServer in-place.
# Preserves appsettings.json, data/, and logs/ — your config and data are safe.
# Run as root: sudo bash deploy/update-linux.sh
set -euo pipefail

INSTALL_DIR=/opt/openarcserver
SERVICE_NAME=openarcserver
REPO_DIR="$(cd "$(dirname "$0")/.." && pwd)"

echo "==> OpenArcServer updater"
echo "    Repo:    $REPO_DIR"
echo "    Install: $INSTALL_DIR"
echo ""

# ── 0. Must run as root ───────────────────────────────────────────────────────
if [[ $EUID -ne 0 ]]; then
    echo "ERROR: Run as root: sudo bash deploy/update-linux.sh" >&2
    exit 1
fi

# ── 1. Check for updates ──────────────────────────────────────────────────────
cd "$REPO_DIR"

echo "==> Fetching latest changes from remote…"
git fetch origin

LOCAL=$(git rev-parse HEAD)
REMOTE=$(git rev-parse '@{u}' 2>/dev/null || echo "")

if [[ -z "$REMOTE" ]]; then
    echo "WARNING: No upstream tracking branch configured."
    echo "         Run: git branch --set-upstream-to=origin/main main"
    echo "         Continuing with current HEAD…"
elif [[ "$LOCAL" == "$REMOTE" ]]; then
    echo "==> Already up-to-date ($LOCAL)"
    read -rp "    Force redeploy anyway? [y/N]: " FORCE
    if [[ "${FORCE,,}" != "y" ]]; then
        echo "==> Nothing to do."
        exit 0
    fi
else
    echo ""
    echo "==> Changes available:"
    git log --oneline "${LOCAL}..${REMOTE}" | head -20
    echo ""
    read -rp "    Apply these updates? [Y/n]: " CONFIRM
    if [[ "${CONFIRM,,}" == "n" ]]; then
        echo "==> Update cancelled."
        exit 0
    fi
fi

# ── 2. Pull ───────────────────────────────────────────────────────────────────
if [[ -n "$REMOTE" && "$LOCAL" != "$REMOTE" ]]; then
    echo "==> Pulling…"
    git reset --hard origin/"$(git rev-parse --abbrev-ref HEAD)"
fi

# ── 3. Back up config and data ────────────────────────────────────────────────
BACKUP_DIR="/tmp/openarcserver-backup-$(date +%Y%m%d-%H%M%S)"
echo "==> Backing up config and data to $BACKUP_DIR"
mkdir -p "$BACKUP_DIR"

[[ -f "$INSTALL_DIR/appsettings.json" ]] && cp "$INSTALL_DIR/appsettings.json" "$BACKUP_DIR/"
[[ -d "$INSTALL_DIR/data"  ]] && cp -r "$INSTALL_DIR/data"  "$BACKUP_DIR/"
[[ -d "$INSTALL_DIR/logs"  ]] && cp -r "$INSTALL_DIR/logs"  "$BACKUP_DIR/"

echo "    Backup saved to $BACKUP_DIR"

# ── 4. Stop service ───────────────────────────────────────────────────────────
echo "==> Stopping $SERVICE_NAME…"
if systemctl is-active --quiet "$SERVICE_NAME"; then
    systemctl stop "$SERVICE_NAME"
    echo "    Stopped."
else
    echo "    Service was not running."
fi

# ── 5. Publish ────────────────────────────────────────────────────────────────
echo "==> Building and publishing…"
dotnet publish src/OpenArcServer.Server/OpenArcServer.Server.csproj \
    -c Release -o "$INSTALL_DIR"

# ── 6. Restore config and data ────────────────────────────────────────────────
echo "==> Restoring config and data…"
[[ -f "$BACKUP_DIR/appsettings.json" ]] && cp "$BACKUP_DIR/appsettings.json" "$INSTALL_DIR/appsettings.json"
[[ -d "$BACKUP_DIR/data"  ]] && cp -r "$BACKUP_DIR/data/."  "$INSTALL_DIR/data/"
[[ -d "$BACKUP_DIR/logs"  ]] && cp -r "$BACKUP_DIR/logs/."  "$INSTALL_DIR/logs/"

# ── 7. Fix permissions ────────────────────────────────────────────────────────
chown -R openarcserver:openarcserver "$INSTALL_DIR"
chmod 755 "$INSTALL_DIR/OpenArcServer.Server" 2>/dev/null || true
chmod 640 "$INSTALL_DIR/appsettings.json"     2>/dev/null || true

# ── 8. Update systemd unit if it changed ─────────────────────────────────────
SERVICE_FILE=/etc/systemd/system/${SERVICE_NAME}.service
if [[ -f "deploy/openarcserver.service" ]]; then
    NEW_UNIT=$(sed "s|/opt/openarcserver|$INSTALL_DIR|g" deploy/openarcserver.service)
    OLD_UNIT=$(cat "$SERVICE_FILE" 2>/dev/null || echo "")
    if [[ "$NEW_UNIT" != "$OLD_UNIT" ]]; then
        echo "==> Updating systemd unit file…"
        echo "$NEW_UNIT" > "$SERVICE_FILE"
        chmod 644 "$SERVICE_FILE"
        systemctl daemon-reload
        echo "    Unit updated and daemon reloaded."
    fi
fi

# ── 9. Restart service ────────────────────────────────────────────────────────
echo "==> Starting $SERVICE_NAME…"
systemctl start "$SERVICE_NAME"

# ── 10. Verify ────────────────────────────────────────────────────────────────
sleep 3
if systemctl is-active --quiet "$SERVICE_NAME"; then
    echo ""
    echo "==> Update complete! Service is running."
    echo "    Version: $(git rev-parse --short HEAD)"
    echo "    Logs:    journalctl -u $SERVICE_NAME -f"
    echo "    Backup:  $BACKUP_DIR  (safe to remove)"
else
    echo ""
    echo "ERROR: Service failed to start after update." >&2
    echo "       Check: journalctl -u $SERVICE_NAME -n 50" >&2
    echo "       Your config backup is at: $BACKUP_DIR" >&2
    echo ""
    echo "==> Attempting rollback…"
    [[ -f "$BACKUP_DIR/appsettings.json" ]] && cp "$BACKUP_DIR/appsettings.json" "$INSTALL_DIR/appsettings.json"
    systemctl start "$SERVICE_NAME" || true
    exit 1
fi
