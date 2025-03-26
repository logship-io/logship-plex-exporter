

To regenerate openapi:

```sh
podman pull openapitools/openapi-generator-cli:latest
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