# L3vels.Sdk.Api.TransactionApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTransactionById**](TransactionApi.md#gettransactionbyid) | **GET** /v1/transaction/{game_id}/{id} | Retrieve Transaction by ID |
| [**GetTransactions**](TransactionApi.md#gettransactions) | **GET** /v1/transaction | Retrieve transactions |

<a name="gettransactionbyid"></a>
# **GetTransactionById**
> Transaction GetTransactionById (string authorization, string id, string gameId)

Retrieve Transaction by ID

Retrieve transaction by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetTransactionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new TransactionApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var id = "id_example";  // string | 
            var gameId = "gameId_example";  // string | 

            try
            {
                // Retrieve Transaction by ID
                Transaction result = apiInstance.GetTransactionById(authorization, id, gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.GetTransactionById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Transaction by ID
    ApiResponse<Transaction> response = apiInstance.GetTransactionByIdWithHttpInfo(authorization, id, gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionApi.GetTransactionByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **id** | **string** |  |  |
| **gameId** | **string** |  |  |

### Return type

[**Transaction**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The transaction has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactions"></a>
# **GetTransactions**
> Transaction GetTransactions (string authorization, string gameId, string collectionId = null, string playerId = null, string sort = null, string order = null, string searchText = null, decimal? limit = null, decimal? page = null)

Retrieve transactions

Retrieve all transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new TransactionApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var gameId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game ID to find transactions in your game. Example: Fortnite, Minecraft, etc.
            var collectionId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Filter transactions by collection. Example: Get transactions only from Weapons collection. (optional) 
            var playerId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Player ID to mint to. You can provide player ID or player address (optional) 
            var sort = name;  // string | Asset field to sort by. You can sort by name, created_on and etc. (optional) 
            var order = ASC;  // string | Sort order (ASC for ascending or DESC for descending) (optional) 
            var searchText = Hammer;  // string | Search transactions by name (optional) 
            var limit = 10;  // decimal? | Number of transactions to return per page (optional) 
            var page = 1;  // decimal? | Page number (optional) 

            try
            {
                // Retrieve transactions
                Transaction result = apiInstance.GetTransactions(authorization, gameId, collectionId, playerId, sort, order, searchText, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionApi.GetTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve transactions
    ApiResponse<Transaction> response = apiInstance.GetTransactionsWithHttpInfo(authorization, gameId, collectionId, playerId, sort, order, searchText, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionApi.GetTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **gameId** | **string** | Game ID to find transactions in your game. Example: Fortnite, Minecraft, etc. |  |
| **collectionId** | **string** | Filter transactions by collection. Example: Get transactions only from Weapons collection. | [optional]  |
| **playerId** | **string** | Player ID to mint to. You can provide player ID or player address | [optional]  |
| **sort** | **string** | Asset field to sort by. You can sort by name, created_on and etc. | [optional]  |
| **order** | **string** | Sort order (ASC for ascending or DESC for descending) | [optional]  |
| **searchText** | **string** | Search transactions by name | [optional]  |
| **limit** | **decimal?** | Number of transactions to return per page | [optional]  |
| **page** | **decimal?** | Page number | [optional]  |

### Return type

[**Transaction**](Transaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The transactions has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

