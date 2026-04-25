#!/bin/bash
set -euo pipefail

if [[ $EUID -ne 0 ]]; then
    echo "update.sh must be run as root" >&2
    exit 1
fi

version="${1:-latest}"

script_dir="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
if [[ "$(basename "$script_dir")" == "scripts" ]]; then
    install_dir="$(dirname "$script_dir")"
else
    install_dir="$script_dir"
fi
install_dir="${INSTALL_DIR:-$install_dir}"
export INSTALL_DIR="$install_dir"

executable=Logship.Plex.Exporter.ConsoleHost
arch="$(uname -m)"
case "$arch" in
    x86_64)  asset="LogshipPlexExporter-linux-x64.zip" ;;
    aarch64) asset="LogshipPlexExporter-linux-arm64.zip" ;;
    *) echo "Unsupported architecture: $arch" >&2; exit 1 ;;
esac

if [[ "$version" == "latest" ]]; then
    download_url="https://github.com/logship-io/logship-plex-exporter/releases/latest/download/$asset"
else
    # Accept "1.2.3" or "v1.2.3"
    tag="$version"
    [[ "$tag" =~ ^v ]] || tag="v$tag"
    download_url="https://github.com/logship-io/logship-plex-exporter/releases/download/$tag/$asset"
fi

echo "Updating $executable to version: $version"
echo "Source: $download_url"

"$script_dir/undeploy.sh"

tempdir="$(mktemp -d -t "installer-plex-exporter-XXXXXXXXXXXXXXXX")"
trap 'rm -rf "$tempdir"' EXIT

wget -O "$tempdir/$asset" --show-progress "$download_url"
unzip -qq "$tempdir/$asset" -d "$tempdir/extract"

rm -f "$install_dir/$executable"
cp -f "$tempdir/extract/$executable" "$install_dir/$executable"

# Refresh the bundled defaults; never overwrite the user's appsettings.json.
if [[ -f "$tempdir/extract/appsettings.json" ]]; then
    cp -f "$tempdir/extract/appsettings.json" "$install_dir/appsettings.default.json"
    if [[ ! -e "$install_dir/appsettings.json" ]]; then
        echo "No appsettings.json found. To configure:"
        echo "  cp $install_dir/appsettings.default.json $install_dir/appsettings.json"
        echo "  edit $install_dir/appsettings.json"
    else
        echo "Existing appsettings.json preserved"
    fi
fi

"$script_dir/deploy.sh"
