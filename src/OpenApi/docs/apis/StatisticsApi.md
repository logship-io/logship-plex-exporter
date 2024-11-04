# Logship.Plex.OpenApi.Api.StatisticsApi

All URIs are relative to *http://localhost32400*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBandwidthStatistics**](StatisticsApi.md#getbandwidthstatistics) | **GET** /statistics/bandwidth | Get Bandwidth Statistics |
| [**GetResourcesStatistics**](StatisticsApi.md#getresourcesstatistics) | **GET** /statistics/resources | Get Resources Statistics |
| [**GetStatistics**](StatisticsApi.md#getstatistics) | **GET** /statistics/media | Get Media Statistics |

<a id="getbandwidthstatistics"></a>
# **GetBandwidthStatistics**
> GetBandwidthStatistics200Response GetBandwidthStatistics (int timespan = null)

Get Bandwidth Statistics

This will return the bandwidth statistics for the server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetBandwidthStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new StatisticsApi(config);
            var timespan = 4;  // int | The timespan to retrieve statistics for the exact meaning of this parameter is not known  (optional) 

            try
            {
                // Get Bandwidth Statistics
                GetBandwidthStatistics200Response result = apiInstance.GetBandwidthStatistics(timespan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetBandwidthStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBandwidthStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Bandwidth Statistics
    ApiResponse<GetBandwidthStatistics200Response> response = apiInstance.GetBandwidthStatisticsWithHttpInfo(timespan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetBandwidthStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timespan** | **int** | The timespan to retrieve statistics for the exact meaning of this parameter is not known  | [optional]  |

### Return type

[**GetBandwidthStatistics200Response**](GetBandwidthStatistics200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bandwidth Statistics |  -  |
| **400** | Bad Request - A parameter was not specified, or was specified incorrectly. |  -  |
| **401** | Unauthorized - Returned if the X-Plex-Token is missing from the header or query. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getresourcesstatistics"></a>
# **GetResourcesStatistics**
> GetResourcesStatistics200Response GetResourcesStatistics (int timespan = null)

Get Resources Statistics

This will return the resources for the server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetResourcesStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new StatisticsApi(config);
            var timespan = 4;  // int | The timespan to retrieve statistics for the exact meaning of this parameter is not known  (optional) 

            try
            {
                // Get Resources Statistics
                GetResourcesStatistics200Response result = apiInstance.GetResourcesStatistics(timespan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetResourcesStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetResourcesStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Resources Statistics
    ApiResponse<GetResourcesStatistics200Response> response = apiInstance.GetResourcesStatisticsWithHttpInfo(timespan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetResourcesStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timespan** | **int** | The timespan to retrieve statistics for the exact meaning of this parameter is not known  | [optional]  |

### Return type

[**GetResourcesStatistics200Response**](GetResourcesStatistics200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Resource Statistics |  -  |
| **400** | Bad Request - A parameter was not specified, or was specified incorrectly. |  -  |
| **401** | Unauthorized - Returned if the X-Plex-Token is missing from the header or query. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getstatistics"></a>
# **GetStatistics**
> GetStatistics200Response GetStatistics (int timespan = null)

Get Media Statistics

This will return the media statistics for the server

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new StatisticsApi(config);
            var timespan = 4;  // int | The timespan to retrieve statistics for the exact meaning of this parameter is not known  (optional) 

            try
            {
                // Get Media Statistics
                GetStatistics200Response result = apiInstance.GetStatistics(timespan);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StatisticsApi.GetStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Media Statistics
    ApiResponse<GetStatistics200Response> response = apiInstance.GetStatisticsWithHttpInfo(timespan);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StatisticsApi.GetStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timespan** | **int** | The timespan to retrieve statistics for the exact meaning of this parameter is not known  | [optional]  |

### Return type

[**GetStatistics200Response**](GetStatistics200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Media Statistics |  -  |
| **400** | Bad Request - A parameter was not specified, or was specified incorrectly. |  -  |
| **401** | Unauthorized - Returned if the X-Plex-Token is missing from the header or query. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

