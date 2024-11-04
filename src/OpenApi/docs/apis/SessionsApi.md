# Logship.Plex.OpenApi.Api.SessionsApi

All URIs are relative to *http://localhost32400*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSessionHistory**](SessionsApi.md#getsessionhistory) | **GET** /status/sessions/history/all | Get Session History |
| [**GetSessions**](SessionsApi.md#getsessions) | **GET** /status/sessions | Get Active Sessions |
| [**GetTranscodeSessions**](SessionsApi.md#gettranscodesessions) | **GET** /transcode/sessions | Get Transcode Sessions |

<a id="getsessionhistory"></a>
# **GetSessionHistory**
> GetSessionHistory200Response GetSessionHistory (string sort = null, int accountId = null, Object filter = null, int librarySectionID = null)

Get Session History

This will Retrieve a listing of all history views.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetSessionHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new SessionsApi(config);
            var sort = viewedAt:desc;  // string | Sorts the results by the specified field followed by the direction (asc, desc)  (optional) 
            var accountId = 1;  // int | Filter results by those that are related to a specific users id  (optional) 
            var filter = new Object(); // Object | Filters content by field and direction/equality (Unknown if viewedAt is the only supported column)  (optional) 
            var librarySectionID = 12;  // int | Filters the results based on the id of a valid library section  (optional) 

            try
            {
                // Get Session History
                GetSessionHistory200Response result = apiInstance.GetSessionHistory(sort, accountId, filter, librarySectionID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.GetSessionHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSessionHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Session History
    ApiResponse<GetSessionHistory200Response> response = apiInstance.GetSessionHistoryWithHttpInfo(sort, accountId, filter, librarySectionID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.GetSessionHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sort** | **string** | Sorts the results by the specified field followed by the direction (asc, desc)  | [optional]  |
| **accountId** | **int** | Filter results by those that are related to a specific users id  | [optional]  |
| **filter** | [**Object**](Object.md) | Filters content by field and direction/equality (Unknown if viewedAt is the only supported column)  | [optional]  |
| **librarySectionID** | **int** | Filters the results based on the id of a valid library section  | [optional]  |

### Return type

[**GetSessionHistory200Response**](GetSessionHistory200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Plex Sessions |  -  |
| **400** | Bad Request - A parameter was not specified, or was specified incorrectly. |  -  |
| **401** | Unauthorized - Returned if the X-Plex-Token is missing from the header or query. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsessions"></a>
# **GetSessions**
> GetSessions200Response GetSessions ()

Get Active Sessions

Get information about currently active media sessions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new SessionsApi(config);

            try
            {
                // Get Active Sessions
                GetSessions200Response result = apiInstance.GetSessions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.GetSessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Active Sessions
    ApiResponse<GetSessions200Response> response = apiInstance.GetSessionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.GetSessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetSessions200Response**](GetSessions200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Unauthorized. Invalid or missing Plex token. |  -  |
| **500** | Server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="gettranscodesessions"></a>
# **GetTranscodeSessions**
> GetTranscodeSessions200Response GetTranscodeSessions ()

Get Transcode Sessions

Get Transcode Sessions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class GetTranscodeSessionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new SessionsApi(config);

            try
            {
                // Get Transcode Sessions
                GetTranscodeSessions200Response result = apiInstance.GetTranscodeSessions();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SessionsApi.GetTranscodeSessions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTranscodeSessionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transcode Sessions
    ApiResponse<GetTranscodeSessions200Response> response = apiInstance.GetTranscodeSessionsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SessionsApi.GetTranscodeSessionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetTranscodeSessions200Response**](GetTranscodeSessions200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Transcode Sessions |  -  |
| **400** | Bad Request - A parameter was not specified, or was specified incorrectly. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

