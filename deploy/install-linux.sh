#!/usr/bin/env bash
# install-linux.sh — Install OpenArcServer as a systemd service on Linux
# Run as root: sudo bash deploy/install-linux.sh
set -euo pipefail

INSTALL_DIR=/opt/openarcserver
SERVICE_USER=openarcserver
SERVICE_FILE=/etc/systemd/system/openarcserver.service
DOTNET_REQUIRED="10.0"

echo "==> OpenArcServer Linux installer"

# ── 0. Prerequisite checks ────────────────────────────────────────────────────

# Must run as root
if [[ $EUID -ne 0 ]]; then
    echo "ERROR: This script must be run as root (sudo bash $0)" >&2
    exit 1
fi

# Detect package manager
if command -v apt-get &>/dev/null; then
    PKG_MGR=apt
elif command -v dnf &>/dev/null; then
    PKG_MGR=dnf
elif command -v yum &>/dev/null; then
    PKG_MGR=yum
else
    PKG_MGR=unknown
fi

install_dotnet_apt() {
    echo "==> Installing .NET $DOTNET_REQUIRED SDK via Microsoft package feed..."
    local DISTRO_ID DISTRO_VER
    DISTRO_ID=$(. /etc/os-release && echo "$ID")
    DISTRO_VER=$(. /etc/os-release && echo "$VERSION_ID")

    # Download and register the Microsoft package signing key + repo
    apt-get update -qq
    apt-get install -y wget ca-certificates apt-transport-https

    local PKG="packages-microsoft-prod.deb"
    wget -q "https://packages.microsoft.com/config/${DISTRO_ID}/${DISTRO_VER}/${PKG}" -O /tmp/${PKG} || {
        # Fallback: use the dotnet-install.sh script
        install_dotnet_script
        return
    }
    dpkg -i /tmp/${PKG}
    apt-get update -qq
    apt-get install -y dotnet-sdk-10.0 || {
        echo "==> Microsoft feed install failed, falling back to dotnet-install.sh..."
        install_dotnet_script
    }
}

install_dotnet_dnf() {
    echo "==> Installing .NET $DOTNET_REQUIRED SDK via dnf..."
    dnf install -y dotnet-sdk-10.0 || {
        echo "==> dnf install failed, falling back to dotnet-install.sh..."
        install_dotnet_script
    }
}

install_dotnet_script() {
    echo "==> Installing .NET $DOTNET_REQUIRED via dotnet-install.sh (system-wide to /usr/local)..."
    local SCRIPT=/tmp/dotnet-install.sh
    wget -q https://dot.net/v1/dotnet-install.sh -O "$SCRIPT"
    chmod +x "$SCRIPT"
    # Install to /usr/local so it's available to all users / systemd
    "$SCRIPT" --channel 10.0 --install-dir /usr/local/dotnet
    # Create symlink so 'dotnet' is on PATH
    ln -sf /usr/local/dotnet/dotnet /usr/local/bin/dotnet
    export DOTNET_ROOT=/usr/local/dotnet
    export PATH="$DOTNET_ROOT:$PATH"
}

check_and_install_dotnet() {
    if command -v dotnet &>/dev/null; then
        local VER
        VER=$(dotnet --version 2>/dev/null | cut -d. -f1)
        if [[ "$VER" -ge 10 ]]; then
            echo "==> .NET $(dotnet --version) already installed — OK"
            return
        fi
        echo "==> .NET found but version is too old ($(dotnet --version)). Need $DOTNET_REQUIRED+."
    else
        echo "==> .NET not found. Installing .NET SDK $DOTNET_REQUIRED..."
    fi

    case "$PKG_MGR" in
        apt) install_dotnet_apt ;;
        dnf|yum) install_dotnet_dnf ;;
        *) install_dotnet_script ;;
    esac

    # Final check
    if ! command -v dotnet &>/dev/null; then
        echo "ERROR: dotnet installation failed. Please install .NET $DOTNET_REQUIRED SDK manually:" >&2
        echo "  https://learn.microsoft.com/dotnet/core/install/linux" >&2
        exit 1
    fi
    echo "==> .NET $(dotnet --version) installed successfully"
}

check_and_install_dotnet

# Ensure curl/wget are available (needed for data downloads later)
if ! command -v wget &>/dev/null && ! command -v curl &>/dev/null; then
    echo "==> Installing wget..."
    case "$PKG_MGR" in
        apt) apt-get install -y wget ;;
        dnf|yum) $PKG_MGR install -y wget ;;
    esac
fi

# Ensure unzip is available
if ! command -v unzip &>/dev/null; then
    echo "==> Installing unzip..."
    case "$PKG_MGR" in
        apt) apt-get install -y unzip ;;
        dnf|yum) $PKG_MGR install -y unzip ;;
    esac
fi

# ── 1. Create service user ────────────────────────────────────────────────────
if ! id "$SERVICE_USER" &>/dev/null; then
    echo "==> Creating system user: $SERVICE_USER"
    useradd --system --no-create-home --shell /usr/sbin/nologin "$SERVICE_USER"
else
    echo "==> Service user '$SERVICE_USER' already exists — OK"
fi

# ── 2. Publish the application ────────────────────────────────────────────────
echo "==> Publishing application..."
cd "$(dirname "$0")/.."
dotnet publish src/OpenArcServer.Server/OpenArcServer.Server.csproj \
    -c Release -o "$INSTALL_DIR" --no-build 2>/dev/null || \
dotnet publish src/OpenArcServer.Server/OpenArcServer.Server.csproj \
    -c Release -o "$INSTALL_DIR"

# ── 3. Create data and log directories ───────────────────────────────────────
mkdir -p "$INSTALL_DIR/data" "$INSTALL_DIR/logs"
chown -R "$SERVICE_USER:$SERVICE_USER" "$INSTALL_DIR"
chmod 755 "$INSTALL_DIR/OpenArcServer.Server" 2>/dev/null || true

# ── 4. Install systemd unit file ─────────────────────────────────────────────
echo "==> Installing systemd service..."
sed "s|/opt/openarcserver|$INSTALL_DIR|g" deploy/openarcserver.service > "$SERVICE_FILE"
chmod 644 "$SERVICE_FILE"

# ── 5. Reload systemd and enable service ─────────────────────────────────────
systemctl daemon-reload
systemctl enable openarcserver.service
systemctl restart openarcserver.service

echo ""
echo "==> Installation complete!"
echo "    Status:  systemctl status openarcserver"
echo "    Logs:    journalctl -u openarcserver -f"
echo "    Config:  $INSTALL_DIR/appsettings.json"
echo "    Data:    $INSTALL_DIR/data/"
echo ""
echo "    IMPORTANT: Set an admin API key in appsettings.json:"
echo '    "Api": { "AdminKey": "your-secret-key" }'
