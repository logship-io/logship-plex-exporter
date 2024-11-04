# Logship.Plex.OpenApi.Api.PlexApi

All URIs are relative to *http://localhost32400*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGeoData**](PlexApi.md#getgeodata) | **GET** /geoip | Get Geo Data |

<a id="getgeodata"></a>
# **GetGeoData**
> GeoData GetGeoData ()

Get Geo Data

Returns the geolocation and locale data of the caller

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetGeoDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            var apiInstance = new PlexApi(config);

            try
            {
                // Get Geo Data
                GeoData result = apiInstance.GetGeoData();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlexApi.GetGeoData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGeoDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Geo Data
    ApiResponse<GeoData> response = apiInstance.GetGeoDataWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlexApi.GetGeoDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GeoData**](GeoData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Gets the geo location data of the user |  -  |
| **400** | Bad Request - A parameter was not specified, or was specified incorrectly. |  -  |
| **401** | Unauthorized - Returned if the X-Plex-Token is missing from the header or query. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

