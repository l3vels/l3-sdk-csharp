# L3vels.Sdk.Api.ContractApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CountContractsByGameId**](ContractApi.md#countcontractsbygameid) | **GET** /v1/contract/collection-size | Collection size |
| [**GetContractURI**](ContractApi.md#getcontracturi) | **GET** /v1/contract/contract-uri | Get Contract URI |
| [**SetContractURI**](ContractApi.md#setcontracturi) | **PUT** /v1/contract/contract-uri | Update Contract URI |
| [**UpdateSaleStatus**](ContractApi.md#updatesalestatus) | **PUT** /v1/contract/sale-status | Update Sale status |

<a name="countcontractsbygameid"></a>
# **CountContractsByGameId**
> void CountContractsByGameId (string authorization, string collectionId, string gameId)

Collection size

Count total contract in game.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class CountContractsByGameIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new ContractApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var collectionId = "collectionId_example";  // string | 
            var gameId = "gameId_example";  // string | 

            try
            {
                // Collection size
                apiInstance.CountContractsByGameId(authorization, collectionId, gameId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractApi.CountContractsByGameId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CountContractsByGameIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection size
    apiInstance.CountContractsByGameIdWithHttpInfo(authorization, collectionId, gameId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractApi.CountContractsByGameIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **collectionId** | **string** |  |  |
| **gameId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contract size |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcontracturi"></a>
# **GetContractURI**
> void GetContractURI (string authorization, string collectionId, string gameId)

Get Contract URI

Gets contract uri of contract

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetContractURIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new ContractApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var collectionId = "collectionId_example";  // string | 
            var gameId = "gameId_example";  // string | 

            try
            {
                // Get Contract URI
                apiInstance.GetContractURI(authorization, collectionId, gameId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractApi.GetContractURI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContractURIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Contract URI
    apiInstance.GetContractURIWithHttpInfo(authorization, collectionId, gameId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractApi.GetContractURIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **collectionId** | **string** |  |  |
| **gameId** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contract URI |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcontracturi"></a>
# **SetContractURI**
> void SetContractURI (string authorization, SetContractUriInput setContractUriInput)

Update Contract URI

Update Contract URI

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class SetContractURIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new ContractApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var setContractUriInput = new SetContractUriInput(); // SetContractUriInput | 

            try
            {
                // Update Contract URI
                apiInstance.SetContractURI(authorization, setContractUriInput);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractApi.SetContractURI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetContractURIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Contract URI
    apiInstance.SetContractURIWithHttpInfo(authorization, setContractUriInput);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractApi.SetContractURIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **setContractUriInput** | [**SetContractUriInput**](SetContractUriInput.md) |  |  |

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
| **200** | Contract URI Updated |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesalestatus"></a>
# **UpdateSaleStatus**
> void UpdateSaleStatus (string authorization, SetSaleStatusInput setSaleStatusInput)

Update Sale status

Update Sale status to PAUSED, PRE_SALE or PUBLIC

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class UpdateSaleStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new ContractApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var setSaleStatusInput = new SetSaleStatusInput(); // SetSaleStatusInput | 

            try
            {
                // Update Sale status
                apiInstance.UpdateSaleStatus(authorization, setSaleStatusInput);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractApi.UpdateSaleStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSaleStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Sale status
    apiInstance.UpdateSaleStatusWithHttpInfo(authorization, setSaleStatusInput);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractApi.UpdateSaleStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **setSaleStatusInput** | [**SetSaleStatusInput**](SetSaleStatusInput.md) |  |  |

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
| **200** | Sale status updated |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

