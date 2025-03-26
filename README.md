# Logship Plex Exporter

A simple application to export Plex metrics and metadata to [https://logship.io](https://logship.io).

# Configuration

Update `appsettings.json` with your endpoints and authentication for logship and plex.

```json
{
  "logshipEndpoint": "{logship endpoint}",
  "logshipAccount": "{logship account guid}",
  "logshipBearerToken": "{logship inflow token}",
  "plexHost": "{plex endpoint}",
  "plexToken": "{plex admin token}"
}
```

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