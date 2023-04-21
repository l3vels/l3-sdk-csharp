# L3vels.Sdk.Api.MintApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MintControllerAirdrop**](MintApi.md#mintcontrollerairdrop) | **POST** /v1/mint/airdrop | Airdrop asset to player |
| [**MintControllerAward**](MintApi.md#mintcontrolleraward) | **POST** /v1/mint/award | Award asset to player |
| [**MintControllerMint**](MintApi.md#mintcontrollermint) | **POST** /v1/mint | Mint asset |
| [**MintControllerMintBatch**](MintApi.md#mintcontrollermintbatch) | **POST** /v1/mint/batch | Batch mint assets |
| [**MintControllerPlayerMint**](MintApi.md#mintcontrollerplayermint) | **POST** /v1/mint/player | Mint asset by player |
| [**MintControllerPlayerMintBatch**](MintApi.md#mintcontrollerplayermintbatch) | **POST** /v1/mint/batch-player | Batch mint assets by player |

<a name="mintcontrollerairdrop"></a>
# **MintControllerAirdrop**
> void MintControllerAirdrop (string authorization, MintDto mintDto)

Airdrop asset to player

Airdrop asset to player

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class MintControllerAirdropExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new MintApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var mintDto = new MintDto(); // MintDto | 

            try
            {
                // Airdrop asset to player
                apiInstance.MintControllerAirdrop(authorization, mintDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintApi.MintControllerAirdrop: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MintControllerAirdropWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Airdrop asset to player
    apiInstance.MintControllerAirdropWithHttpInfo(authorization, mintDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintApi.MintControllerAirdropWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **mintDto** | [**MintDto**](MintDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully awarded asset to player |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mintcontrolleraward"></a>
# **MintControllerAward**
> void MintControllerAward (string authorization, MintDto mintDto)

Award asset to player

Award asset to player

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class MintControllerAwardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new MintApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var mintDto = new MintDto(); // MintDto | 

            try
            {
                // Award asset to player
                apiInstance.MintControllerAward(authorization, mintDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintApi.MintControllerAward: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MintControllerAwardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Award asset to player
    apiInstance.MintControllerAwardWithHttpInfo(authorization, mintDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintApi.MintControllerAwardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **mintDto** | [**MintDto**](MintDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully awarded asset to player |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mintcontrollermint"></a>
# **MintControllerMint**
> void MintControllerMint (string authorization, MintDto mintDto)

Mint asset

Mint an asset by admin to player

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class MintControllerMintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new MintApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var mintDto = new MintDto(); // MintDto | 

            try
            {
                // Mint asset
                apiInstance.MintControllerMint(authorization, mintDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintApi.MintControllerMint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MintControllerMintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mint asset
    apiInstance.MintControllerMintWithHttpInfo(authorization, mintDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintApi.MintControllerMintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **mintDto** | [**MintDto**](MintDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully minted asset to player |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mintcontrollermintbatch"></a>
# **MintControllerMintBatch**
> void MintControllerMintBatch (string authorization, MintBatchDto mintBatchDto)

Batch mint assets

Batch mint assets by admin to player

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class MintControllerMintBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new MintApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var mintBatchDto = new MintBatchDto(); // MintBatchDto | 

            try
            {
                // Batch mint assets
                apiInstance.MintControllerMintBatch(authorization, mintBatchDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintApi.MintControllerMintBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MintControllerMintBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch mint assets
    apiInstance.MintControllerMintBatchWithHttpInfo(authorization, mintBatchDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintApi.MintControllerMintBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **mintBatchDto** | [**MintBatchDto**](MintBatchDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully minted assets to player |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mintcontrollerplayermint"></a>
# **MintControllerPlayerMint**
> void MintControllerPlayerMint (string authorization, MintDto mintDto)

Mint asset by player

Mint asset by player. Player must have enough balance to mint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class MintControllerPlayerMintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new MintApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var mintDto = new MintDto(); // MintDto | 

            try
            {
                // Mint asset by player
                apiInstance.MintControllerPlayerMint(authorization, mintDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintApi.MintControllerPlayerMint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MintControllerPlayerMintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Mint asset by player
    apiInstance.MintControllerPlayerMintWithHttpInfo(authorization, mintDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintApi.MintControllerPlayerMintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **mintDto** | [**MintDto**](MintDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully minted asset by player |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mintcontrollerplayermintbatch"></a>
# **MintControllerPlayerMintBatch**
> void MintControllerPlayerMintBatch (string authorization, MintBatchDto mintBatchDto)

Batch mint assets by player

Batch mint assets by player. Player must have enough balance to mint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class MintControllerPlayerMintBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new MintApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var mintBatchDto = new MintBatchDto(); // MintBatchDto | 

            try
            {
                // Batch mint assets by player
                apiInstance.MintControllerPlayerMintBatch(authorization, mintBatchDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MintApi.MintControllerPlayerMintBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MintControllerPlayerMintBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Batch mint assets by player
    apiInstance.MintControllerPlayerMintBatchWithHttpInfo(authorization, mintBatchDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MintApi.MintControllerPlayerMintBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **mintBatchDto** | [**MintBatchDto**](MintBatchDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully minted assets by player |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

