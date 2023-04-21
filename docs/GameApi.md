# L3vels.Sdk.Api.GameApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGameById**](GameApi.md#getgamebyid) | **GET** /v1/game/{id} | Retrieve Game |

<a name="getgamebyid"></a>
# **GetGameById**
> Project GetGameById (string authorization, string id)

Retrieve Game

Get game/project by ID created on the platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetGameByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new GameApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var id = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game or Project Id

            try
            {
                // Retrieve Game
                Project result = apiInstance.GetGameById(authorization, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetGameById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGameByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Game
    ApiResponse<Project> response = apiInstance.GetGameByIdWithHttpInfo(authorization, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameApi.GetGameByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **id** | **string** | Game or Project Id |  |

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The game/project has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

