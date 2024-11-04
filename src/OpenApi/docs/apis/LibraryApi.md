# Logship.Plex.OpenApi.Api.LibraryApi

All URIs are relative to *http://localhost32400*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LibrarySectionsGet**](LibraryApi.md#librarysectionsget) | **GET** /library/sections | Get Media Libraries |
| [**LibrarySectionsLibraryKeyAllGet**](LibraryApi.md#librarysectionslibrarykeyallget) | **GET** /library/sections/{libraryKey}/all | Get All Media in a Library |

<a id="librarysectionsget"></a>
# **LibrarySectionsGet**
> LibrarySectionsGet200Response LibrarySectionsGet ()

Get Media Libraries

Get a list of all media libraries on the Plex server.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class LibrarySectionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new LibraryApi(config);

            try
            {
                // Get Media Libraries
                LibrarySectionsGet200Response result = apiInstance.LibrarySectionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LibraryApi.LibrarySectionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LibrarySectionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Media Libraries
    ApiResponse<LibrarySectionsGet200Response> response = apiInstance.LibrarySectionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LibraryApi.LibrarySectionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LibrarySectionsGet200Response**](LibrarySectionsGet200Response.md)

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

<a id="librarysectionslibrarykeyallget"></a>
# **LibrarySectionsLibraryKeyAllGet**
> LibrarySectionsLibraryKeyAllGet200Response LibrarySectionsLibraryKeyAllGet (string libraryKey)

Get All Media in a Library

Get a list of all media in a specified library.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Model;

namespace Example
{
    public class LibrarySectionsLibraryKeyAllGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost32400";
            // Configure API key authorization: PlexAuth
            config.AddApiKey("X-Plex-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-Plex-Token", "Bearer");

            var apiInstance = new LibraryApi(config);
            var libraryKey = "libraryKey_example";  // string | Key for the media library

            try
            {
                // Get All Media in a Library
                LibrarySectionsLibraryKeyAllGet200Response result = apiInstance.LibrarySectionsLibraryKeyAllGet(libraryKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LibraryApi.LibrarySectionsLibraryKeyAllGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LibrarySectionsLibraryKeyAllGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Media in a Library
    ApiResponse<LibrarySectionsLibraryKeyAllGet200Response> response = apiInstance.LibrarySectionsLibraryKeyAllGetWithHttpInfo(libraryKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LibraryApi.LibrarySectionsLibraryKeyAllGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **libraryKey** | **string** | Key for the media library |  |

### Return type

[**LibrarySectionsLibraryKeyAllGet200Response**](LibrarySectionsLibraryKeyAllGet200Response.md)

### Authorization

[PlexAuth](../README.md#PlexAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | Library not found |  -  |
| **401** | Unauthorized. Invalid or missing Plex token. |  -  |
| **500** | Server error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

