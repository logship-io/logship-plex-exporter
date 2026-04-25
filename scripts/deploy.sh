#!/bin/bash
set -euo pipefail

if [[ $EUID -ne 0 ]]; then
    echo "deploy.sh must be run as root" >&2
    exit 1
fi

script_dir="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
if [[ "$(basename "$script_dir")" == "scripts" ]]; then
    install_dir="$(dirname "$script_dir")"
else
    install_dir="$script_dir"
fi
install_dir="${INSTALL_DIR:-$install_dir}"

service_name=logship-plex-exporter
executable=Logship.Plex.Exporter.ConsoleHost
exe_path="$install_dir/$executable"

if [[ ! -x "$exe_path" && ! -f "$exe_path" ]]; then
    echo "Executable not found at $exe_path" >&2
    echo "Set INSTALL_DIR=/path/to/install or place the binary alongside the scripts." >&2
    exit 1
fi

echo "Beginning installation of service $service_name (install_dir=$install_dir)"

chmod 0755 "$exe_path"

unit_path="/etc/systemd/system/$service_name.service"

cat > "$unit_path" << EOF
[Unit]
Description=Logship Plex Exporter
Documentation=https://github.com/logship-io/logship-plex-exporter
After=network-online.target
Wants=network-online.target

[Service]
Type=simple
ExecStart=$exe_path
WorkingDirectory=$install_dir
Restart=on-failure
RestartSec=10s
TimeoutStopSec=30s

StandardOutput=journal
StandardError=journal
SyslogIdentifier=$service_name

NoNewPrivileges=true
RestrictRealtime=true
RestrictSUIDSGID=true
RestrictAddressFamilies=AF_UNIX AF_INET AF_INET6
RestrictNamespaces=true
LockPersonality=true
ProtectKernelModules=true
ProtectClock=true
KeyringMode=inherit

[Install]
WantedBy=multi-user.target
EOF

chmod 0644 "$unit_path"

systemctl daemon-reload
systemctl enable "$service_name"

echo "Service $service_name installed, now starting"
systemctl restart "$service_name"
