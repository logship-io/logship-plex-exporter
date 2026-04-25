#!/bin/bash
set -euo pipefail

if [[ $EUID -ne 0 ]]; then
    echo "undeploy.sh must be run as root" >&2
    exit 1
fi

service_name=logship-plex-exporter
unit_path="/etc/systemd/system/$service_name.service"

echo "Beginning uninstallation of service $service_name"

if systemctl cat "$service_name.service" >/dev/null 2>&1; then
    echo "Service $service_name found"

    systemctl stop "$service_name" || true
    systemctl disable "$service_name" || true

    if [[ -f "$unit_path" ]]; then
        rm "$unit_path"
    fi

    systemctl daemon-reload
    systemctl reset-failed "$service_name" 2>/dev/null || true
else
    echo "Service $service_name not found"
fi
