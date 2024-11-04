# Logship.Plex.OpenApi.Api.ActivitiesApi

All URIs are relative to *http://localhost32400*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetServerActivities**](ActivitiesApi.md#getserveractivities) | **GET** /activities | Get Server Activities |

<a id="getserveractivities"></a>
# **GetServerActivities**
> GetServerActivities200Response GetServerActivities ()

Get Server Activities

Get Server Activities

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetServerActivitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new ActivitiesApi(config);

            try
            {
                // Get Server Activities
                GetServerActivities200Response result = apiInstance.GetServerActivities();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActivitiesApi.GetServerActivities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerActivitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Server Activities
    ApiResponse<GetServerActivities200Response> response = apiInstance.GetServerActivitiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActivitiesApi.GetServerActivitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetServerActivities200Response**](GetServerActivities200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Server Activities |  -  |
| **400** | Bad Request - A parameter was not specified, or was specified incorrectly. |  -  |
| **401** | Unauthorized - Returned if the X-Plex-Token is missing from the header or query. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

