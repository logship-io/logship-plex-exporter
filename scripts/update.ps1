#Requires -RunAsAdministrator

[CmdletBinding()]
param(
    [string]$Version = 'latest'
)

$ErrorActionPreference = 'Stop'

$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
if ((Split-Path -Leaf $scriptDir) -eq 'scripts') {
    $installDir = Split-Path -Parent $scriptDir
}
else {
    $installDir = $scriptDir
}
if ($env:INSTALL_DIR) { $installDir = $env:INSTALL_DIR }

$serviceName = 'logship-plex-exporter'
$executable  = 'Logship.Plex.Exporter.ConsoleHost.exe'
$exePath     = Join-Path $installDir $executable

switch ($env:PROCESSOR_ARCHITECTURE) {
    'AMD64' { $asset = 'LogshipPlexExporter-win-x64.zip' }
    'ARM64' { $asset = 'LogshipPlexExporter-win-arm64.zip' }
    default { throw "Unsupported architecture: $env:PROCESSOR_ARCHITECTURE" }
}

if ($Version -eq 'latest') {
    $downloadUrl = "https://github.com/logship-io/logship-plex-exporter/releases/latest/download/$asset"
}
else {
    $tag = if ($Version.StartsWith('v')) { $Version } else { "v$Version" }
    $downloadUrl = "https://github.com/logship-io/logship-plex-exporter/releases/download/$tag/$asset"
}

Write-Host "Updating $serviceName to version: $Version"
Write-Host "Source: $downloadUrl"

$service = Get-Service -Name $serviceName -ErrorAction SilentlyContinue
if ($service -and $service.Status -ne 'Stopped') {
    Write-Host "Stopping service $serviceName"
    Stop-Service -Name $serviceName
    $service.WaitForStatus('Stopped', '00:00:30')
}

$tempDir = Join-Path ([System.IO.Path]::GetTempPath()) ("installer-plex-exporter-" + [Guid]::NewGuid().ToString('N'))
New-Item -ItemType Directory -Path $tempDir | Out-Null
try {
    $zipPath = Join-Path $tempDir $asset
    Write-Host "Downloading $asset"
    Invoke-WebRequest -Uri $downloadUrl -OutFile $zipPath -UseBasicParsing

    $extractDir = Join-Path $tempDir 'extract'
    Expand-Archive -Path $zipPath -DestinationPath $extractDir -Force

    $sourceExe = Join-Path $extractDir $executable
    if (-not (Test-Path $sourceExe)) {
        throw "Expected $executable not found in archive"
    }

    Copy-Item -Path $sourceExe -Destination $exePath -Force

    $sourceConfig = Join-Path $extractDir 'appsettings.json'
    if (Test-Path $sourceConfig) {
        $defaultConfig = Join-Path $installDir 'appsettings.default.json'
        Copy-Item -Path $sourceConfig -Destination $defaultConfig -Force

        $userConfig = Join-Path $installDir 'appsettings.json'
        if (-not (Test-Path $userConfig)) {
            Write-Host "No appsettings.json found. To configure:"
            Write-Host "  Copy-Item '$defaultConfig' '$userConfig'"
            Write-Host "  edit $userConfig"
        }
        else {
            Write-Host "Existing appsettings.json preserved"
        }
    }
}
finally {
    Remove-Item -Recurse -Force -Path $tempDir -ErrorAction SilentlyContinue
}

if ($service) {
    Write-Host "Starting service $serviceName"
    Start-Service -Name $serviceName
}
else {
    Write-Host "Service $serviceName is not installed; binary updated at $exePath."
    Write-Host "Install the service with sc.exe create $serviceName binPath= `"$exePath`" start= auto"
}
