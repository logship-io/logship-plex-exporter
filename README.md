# Logship Plex Exporter

A simple application to export Plex Media Server metrics and metadata to [https://logship.io](https://logship.io).

## Getting Started

The Logship Plex Exporter continuously monitors your Plex Media Server and exports detailed metrics about media consumption, library contents, user sessions, bandwidth usage, and server performance.

### Prerequisites

1. **Plex Media Server** - You need a running Plex Media Server with administrative access
2. **Plex Admin Token** - Required to access the Plex API (see [Getting a Plex Admin Token](#getting-a-plex-admin-token) below)
3. **Logship Account** - For direct mode, or a Logship agent endpoint for agent mode

### Quick Start

1. Download the latest release or build from source
2. Configure `appsettings.json` with your settings (see [Configuration](#configuration))
3. Run the executable: `Logship.Plex.Exporter.ConsoleHost.exe`

The exporter will begin collecting data immediately and report metrics according to your configured output mode.

## Configuration

The exporter supports two output modes: **agent** (default) and **direct**.

### Agent Mode (Recommended)

Agent mode sends JSON events via UDP packets to a Logship agent. This is the preferred method for production deployments.

```json
{
  "outputMode": "agent",
  "logshipEndpoint": "udp://logship-agent:49999",
  "plexHost": "http://your-plex-server:32400",
  "plexToken": "your-plex-admin-token"
}
```

**Required for agent mode:**
- `logshipEndpoint` - UDP endpoint of your Logship agent

### Direct Mode

Direct mode sends data directly to the Logship API.

```json
{
  "outputMode": "direct", 
  "logshipEndpoint": "https://logship-backend:5000",
  "logshipAccount": "00000000-0000-0000-0000-000000000000",
  "logshipBearerToken": "your-logship-inflow-token",
  "plexHost": "http://your-plex-server:32400",
  "plexToken": "your-plex-admin-token"
}
```

**Required for direct mode:**
- `logshipEndpoint` - Logship API endpoint
- `logshipAccount` - Your Logship account GUID  
- `logshipBearerToken` - Your Logship inflow token

### Getting a Plex Admin Token

A Plex admin token is required to access the Plex Media Server API. Here's how you can obtain one:
1. Open your Plex Web App in a browser
2. Go to any media item and click the "..." menu → "Get Info"
3. Click "View XML" in the media info dialog
4. Find the `X-Plex-Token` parameter in the request URL

# Maintenance

To regenerate openapi:

```sh
podman pull openapitools/openapi-generator-cli:v7.12.0
podman run --rm -v ${PWD}/src:/local openapitools/openapi-generator-cli:v7.12.0 generate -i /local/openapi.yaml -g csharp -o /local/OpenApi --additional-properties=useFrameworkReference=false,library=generichost,useSourceGeneration=true,optionalProjectFile=true,packageName=Logship.Plex.OpenApi,disallowAdditionalPropertiesIfNotPresent=false
```

Basic powershell testing
```pwsh
$plexUrl = ""                                                                                                                                             
$plexToken = ""                                                                                                                                                     
$headers = @{                                                                                                    
    "X-Plex-Token" = $plexToken
    "Accept"       = "application/json"
}
$response = Invoke-RestMethod -Uri "$plexUrl/accounts" -Method Get -Headers $headers
$response | ConvertTo-Json -Depth 100
```