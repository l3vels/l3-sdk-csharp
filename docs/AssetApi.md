# L3vels.Sdk.Api.AssetApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CountByGame**](AssetApi.md#countbygame) | **GET** /v1/asset/count/{game_id} | Count assets |
| [**GetAssetById**](AssetApi.md#getassetbyid) | **GET** /v1/asset/{game_id}/{id} | Retrieve asset by ID |
| [**GetAssets**](AssetApi.md#getassets) | **GET** /v1/asset | Retrieve assets |
| [**UpdateAsset**](AssetApi.md#updateasset) | **PATCH** /v1/asset/{id} | Update asset |

<a name="countbygame"></a>
# **CountByGame**
> decimal CountByGame (string authorization, string gameId)

Count assets

Counts total assets in game.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class CountByGameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new AssetApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var gameId = "gameId_example";  // string | 

            try
            {
                // Count assets
                decimal result = apiInstance.CountByGame(authorization, gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.CountByGame: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CountByGameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Count assets
    ApiResponse<decimal> response = apiInstance.CountByGameWithHttpInfo(authorization, gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.CountByGameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **gameId** | **string** |  |  |

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
| **200** | The assets has been counted. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassetbyid"></a>
# **GetAssetById**
> Asset GetAssetById (string authorization, string id, string gameId)

Retrieve asset by ID

Retrieve asset by ID in specific Game. Example: Find asset AK-47 in game Call of Duty

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetAssetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new AssetApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var id = 9abd57ce-b11c-4828-ab6a-19f568a8081a;  // string | Asset ID to find
            var gameId = 556a2843-b302-4b9d-916c-cefcb5d66053;  // string | Game ID to find asset in

            try
            {
                // Retrieve asset by ID
                Asset result = apiInstance.GetAssetById(authorization, id, gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve asset by ID
    ApiResponse<Asset> response = apiInstance.GetAssetByIdWithHttpInfo(authorization, id, gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.GetAssetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **id** | **string** | Asset ID to find |  |
| **gameId** | **string** | Game ID to find asset in |  |

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asset has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getassets"></a>
# **GetAssets**
> AssetsResponse GetAssets (string authorization, string gameId, string collectionId = null, string sort = null, string order = null, string searchText = null, decimal? limit = null, decimal? page = null)

Retrieve assets

This API method retrieves a list of assets that match the specified filter criteria. Developers can use this method to retrieve assets by name, description or other properties

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new AssetApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var gameId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game ID to find assets in your game. Example: Fortnite, Minecraft, etc.
            var collectionId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Filter assets by collection. Example: Get assets only from Weapons collection. (optional) 
            var sort = name;  // string | Asset field to sort by. You can sort by name, created_on and etc. (optional) 
            var order = ASC;  // string | Sort order (ASC for ascending or DESC for descending) (optional) 
            var searchText = Hammer;  // string | Search assets by name (optional) 
            var limit = 10;  // decimal? | Number of assets to return per page (optional) 
            var page = 1;  // decimal? | Page number (optional) 

            try
            {
                // Retrieve assets
                AssetsResponse result = apiInstance.GetAssets(authorization, gameId, collectionId, sort, order, searchText, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.GetAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve assets
    ApiResponse<AssetsResponse> response = apiInstance.GetAssetsWithHttpInfo(authorization, gameId, collectionId, sort, order, searchText, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.GetAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **gameId** | **string** | Game ID to find assets in your game. Example: Fortnite, Minecraft, etc. |  |
| **collectionId** | **string** | Filter assets by collection. Example: Get assets only from Weapons collection. | [optional]  |
| **sort** | **string** | Asset field to sort by. You can sort by name, created_on and etc. | [optional]  |
| **order** | **string** | Sort order (ASC for ascending or DESC for descending) | [optional]  |
| **searchText** | **string** | Search assets by name | [optional]  |
| **limit** | **decimal?** | Number of assets to return per page | [optional]  |
| **page** | **decimal?** | Page number | [optional]  |

### Return type

[**AssetsResponse**](AssetsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assets has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateasset"></a>
# **UpdateAsset**
> Asset UpdateAsset (string authorization, string id, UpdateAssetInput updateAssetInput)

Update asset

Update asset by ID in specific collection. Example: Update asset AK-47 in collection Weapons

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class UpdateAssetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new AssetApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var id = 353c69f6-76a6-4baa-b68b-852c1c531953;  // string | Asset ID to update
            var updateAssetInput = new UpdateAssetInput(); // UpdateAssetInput | 

            try
            {
                // Update asset
                Asset result = apiInstance.UpdateAsset(authorization, id, updateAssetInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AssetApi.UpdateAsset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAssetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update asset
    ApiResponse<Asset> response = apiInstance.UpdateAssetWithHttpInfo(authorization, id, updateAssetInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AssetApi.UpdateAssetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **id** | **string** | Asset ID to update |  |
| **updateAssetInput** | [**UpdateAssetInput**](UpdateAssetInput.md) |  |  |

### Return type

[**Asset**](Asset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The asset has been updated. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

