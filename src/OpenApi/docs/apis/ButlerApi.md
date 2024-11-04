# Logship.Plex.OpenApi.Api.ButlerApi

All URIs are relative to *http://localhost32400*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetButlerTasks**](ButlerApi.md#getbutlertasks) | **GET** /butler | Get Butler tasks |

<a id="getbutlertasks"></a>
# **GetButlerTasks**
> GetButlerTasks200Response GetButlerTasks ()

Get Butler tasks

Returns a list of butler tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetButlerTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new ButlerApi(config);

            try
            {
                // Get Butler tasks
                GetButlerTasks200Response result = apiInstance.GetButlerTasks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ButlerApi.GetButlerTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetButlerTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Butler tasks
    ApiResponse<GetButlerTasks200Response> response = apiInstance.GetButlerTasksWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ButlerApi.GetButlerTasksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetButlerTasks200Response**](GetButlerTasks200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All butler tasks |  -  |
| **400** | Bad Request - A parameter was not specified, or was specified incorrectly. |  -  |
| **401** | Unauthorized - Returned if the X-Plex-Token is missing from the header or query. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

