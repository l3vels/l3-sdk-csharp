# L3vels.Sdk.Api.CollectionApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CountCollectionsByGameId**](CollectionApi.md#countcollectionsbygameid) | **GET** /v1/collection/count/{project_id} | Count collections |
| [**GetCollectionById**](CollectionApi.md#getcollectionbyid) | **GET** /v1/collection/{project_id}/{id} | Retrieve collection by ID |
| [**GetCollections**](CollectionApi.md#getcollections) | **GET** /v1/collection | Retrieve collections |

<a name="countcollectionsbygameid"></a>
# **CountCollectionsByGameId**
> decimal CountCollectionsByGameId (string authorization, string projectId)

Count collections

Count total collections in game.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class CountCollectionsByGameIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new CollectionApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var projectId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game/project ID to count collections in

            try
            {
                // Count collections
                decimal result = apiInstance.CountCollectionsByGameId(authorization, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.CountCollectionsByGameId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CountCollectionsByGameIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Count collections
    ApiResponse<decimal> response = apiInstance.CountCollectionsByGameIdWithHttpInfo(authorization, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionApi.CountCollectionsByGameIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **projectId** | **string** | Game/project ID to count collections in |  |

### Return type

**decimal**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The collections has been counted. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollectionbyid"></a>
# **GetCollectionById**
> Collection GetCollectionById (string authorization, string id, string projectId)

Retrieve collection by ID

This API method retrieves a specific collection based on the unique identifier provided in the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetCollectionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new CollectionApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var id = 229fd9e0-b51f-4b20-9203-9db60995e6b1;  // string | Collection ID to find
            var projectId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game/project ID to find collection in

            try
            {
                // Retrieve collection by ID
                Collection result = apiInstance.GetCollectionById(authorization, id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.GetCollectionById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCollectionByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve collection by ID
    ApiResponse<Collection> response = apiInstance.GetCollectionByIdWithHttpInfo(authorization, id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionApi.GetCollectionByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **id** | **string** | Collection ID to find |  |
| **projectId** | **string** | Game/project ID to find collection in |  |

### Return type

**Collection**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The collection has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcollections"></a>
# **GetCollections**
> List&lt;Collection&gt; GetCollections (string authorization, string projectId, string sort = null, string order = null, string searchText = null, decimal? limit = null, decimal? page = null)

Retrieve collections

This API method retrieves a list of collections that match the specified filter criteria. Developers can use this method to retrieve collections by name, category, status, or other properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetCollectionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new CollectionApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var projectId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game/project ID to find collections in your game. Example: Fortnite, Minecraft, etc.
            var sort = name;  // string | Collection field to sort by. You can sort by name, created_on and etc. (optional) 
            var order = ASC;  // string | Sort order (ASC for ascending or DESC for descending) (optional) 
            var searchText = Weapons;  // string | Search collections by name (optional) 
            var limit = 10;  // decimal? | Number of collections to return per page (optional) 
            var page = 1;  // decimal? | Page number (optional) 

            try
            {
                // Retrieve collections
                List<Collection> result = apiInstance.GetCollections(authorization, projectId, sort, order, searchText, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CollectionApi.GetCollections: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCollectionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve collections
    ApiResponse<List<Collection>> response = apiInstance.GetCollectionsWithHttpInfo(authorization, projectId, sort, order, searchText, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CollectionApi.GetCollectionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **projectId** | **string** | Game/project ID to find collections in your game. Example: Fortnite, Minecraft, etc. |  |
| **sort** | **string** | Collection field to sort by. You can sort by name, created_on and etc. | [optional]  |
| **order** | **string** | Sort order (ASC for ascending or DESC for descending) | [optional]  |
| **searchText** | **string** | Search collections by name | [optional]  |
| **limit** | **decimal?** | Number of collections to return per page | [optional]  |
| **page** | **decimal?** | Page number | [optional]  |

### Return type

**List<Collection>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The collections has been found |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

