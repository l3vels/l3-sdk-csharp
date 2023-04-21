# L3vels.Sdk.Api.ContractApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContractControllerCollectionSize**](ContractApi.md#contractcontrollercollectionsize) | **GET** /v1/contract/collection-size | Collection size |
| [**ContractControllerContractUri**](ContractApi.md#contractcontrollercontracturi) | **GET** /v1/contract/contract-uri | Get Contract URI |
| [**ContractControllerSetContractUri**](ContractApi.md#contractcontrollersetcontracturi) | **PUT** /v1/contract/contract-uri | Update Contract URI |
| [**ContractControllerSetSaleStatus**](ContractApi.md#contractcontrollersetsalestatus) | **PUT** /v1/contract/sale-status | Update Sale status |

<a name="contractcontrollercollectionsize"></a>
# **ContractControllerCollectionSize**
> void ContractControllerCollectionSize (string authorization, string collectionId, string projectId)

Collection size

Get size of collection

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class ContractControllerCollectionSizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new ContractApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var collectionId = "collectionId_example";  // string | 
            var projectId = "projectId_example";  // string | 

            try
            {
                // Collection size
                apiInstance.ContractControllerCollectionSize(authorization, collectionId, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractApi.ContractControllerCollectionSize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractControllerCollectionSizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Collection size
    apiInstance.ContractControllerCollectionSizeWithHttpInfo(authorization, collectionId, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractApi.ContractControllerCollectionSizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **collectionId** | **string** |  |  |
| **projectId** | **string** |  |  |

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
| **200** | Collection size |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="contractcontrollercontracturi"></a>
# **ContractControllerContractUri**
> void ContractControllerContractUri (string authorization, string collectionId, string projectId)

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
    public class ContractControllerContractUriExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new ContractApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var collectionId = "collectionId_example";  // string | 
            var projectId = "projectId_example";  // string | 

            try
            {
                // Get Contract URI
                apiInstance.ContractControllerContractUri(authorization, collectionId, projectId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractApi.ContractControllerContractUri: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractControllerContractUriWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Contract URI
    apiInstance.ContractControllerContractUriWithHttpInfo(authorization, collectionId, projectId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractApi.ContractControllerContractUriWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **collectionId** | **string** |  |  |
| **projectId** | **string** |  |  |

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

<a name="contractcontrollersetcontracturi"></a>
# **ContractControllerSetContractUri**
> void ContractControllerSetContractUri (string authorization, SetContractUriDto setContractUriDto)

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
    public class ContractControllerSetContractUriExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new ContractApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var setContractUriDto = new SetContractUriDto(); // SetContractUriDto | 

            try
            {
                // Update Contract URI
                apiInstance.ContractControllerSetContractUri(authorization, setContractUriDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractApi.ContractControllerSetContractUri: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractControllerSetContractUriWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Contract URI
    apiInstance.ContractControllerSetContractUriWithHttpInfo(authorization, setContractUriDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractApi.ContractControllerSetContractUriWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **setContractUriDto** | [**SetContractUriDto**](SetContractUriDto.md) |  |  |

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

<a name="contractcontrollersetsalestatus"></a>
# **ContractControllerSetSaleStatus**
> void ContractControllerSetSaleStatus (string authorization, SetSaleStatusDto setSaleStatusDto)

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
    public class ContractControllerSetSaleStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new ContractApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var setSaleStatusDto = new SetSaleStatusDto(); // SetSaleStatusDto | 

            try
            {
                // Update Sale status
                apiInstance.ContractControllerSetSaleStatus(authorization, setSaleStatusDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ContractApi.ContractControllerSetSaleStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractControllerSetSaleStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Sale status
    apiInstance.ContractControllerSetSaleStatusWithHttpInfo(authorization, setSaleStatusDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ContractApi.ContractControllerSetSaleStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **setSaleStatusDto** | [**SetSaleStatusDto**](SetSaleStatusDto.md) |  |  |

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

