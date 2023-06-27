# L3vels.Sdk.Api.GameApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateGame**](GameApi.md#creategame) | **POST** /v1/game | Create Game |
| [**GameControllerGetGames**](GameApi.md#gamecontrollergetgames) | **GET** /v1/game | Retrieve all games |
| [**GetGameById**](GameApi.md#getgamebyid) | **GET** /v1/game/{game_id} | Retrieve Game |
| [**GetGameByName**](GameApi.md#getgamebyname) | **GET** /v1/game/name/{name} | Retrieve Game By Name |

<a name="creategame"></a>
# **CreateGame**
> Game CreateGame (string authorization, Object body)

Create Game

Create game on platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class CreateGameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new GameApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var body = null;  // Object | 

            try
            {
                // Create Game
                Game result = apiInstance.CreateGame(authorization, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.CreateGame: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Game
    ApiResponse<Game> response = apiInstance.CreateGameWithHttpInfo(authorization, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameApi.CreateGameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **body** | **Object** |  |  |

### Return type

[**Game**](Game.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Game has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gamecontrollergetgames"></a>
# **GameControllerGetGames**
> Game GameControllerGetGames (string authorization, string gameId, string sort = null, string searchText = null, decimal? limit = null, decimal? page = null)

Retrieve all games

Retrieve all your games/games created on the platform. You can filter games by name, description. You can sort games by field

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GameControllerGetGamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new GameApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var gameId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game ID
            var sort = ASC;  // string | In which order to sort the results. Can be ASC for ascending or DESC for descending order (optional) 
            var searchText = Call of Duty;  // string | Filter by game name or description (optional) 
            var limit = 10;  // decimal? | Number of players to return per page (optional) 
            var page = 1;  // decimal? | Page number (optional) 

            try
            {
                // Retrieve all games
                Game result = apiInstance.GameControllerGetGames(authorization, gameId, sort, searchText, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GameControllerGetGames: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GameControllerGetGamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve all games
    ApiResponse<Game> response = apiInstance.GameControllerGetGamesWithHttpInfo(authorization, gameId, sort, searchText, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameApi.GameControllerGetGamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **gameId** | **string** | Game ID |  |
| **sort** | **string** | In which order to sort the results. Can be ASC for ascending or DESC for descending order | [optional]  |
| **searchText** | **string** | Filter by game name or description | [optional]  |
| **limit** | **decimal?** | Number of players to return per page | [optional]  |
| **page** | **decimal?** | Page number | [optional]  |

### Return type

[**Game**](Game.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The games has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgamebyid"></a>
# **GetGameById**
> Game GetGameById (string authorization, string gameId)

Retrieve Game

Get Game by ID created on the platform.

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
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var gameId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game ID

            try
            {
                // Retrieve Game
                Game result = apiInstance.GetGameById(authorization, gameId);
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
    ApiResponse<Game> response = apiInstance.GetGameByIdWithHttpInfo(authorization, gameId);
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
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **gameId** | **string** | Game ID |  |

### Return type

[**Game**](Game.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Game has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgamebyname"></a>
# **GetGameByName**
> Game GetGameByName (string authorization, string name)

Retrieve Game By Name

Get Game by Name created on the platform.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetGameByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new GameApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var name = "name_example";  // string | 

            try
            {
                // Retrieve Game By Name
                Game result = apiInstance.GetGameByName(authorization, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GameApi.GetGameByName: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGameByNameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve Game By Name
    ApiResponse<Game> response = apiInstance.GetGameByNameWithHttpInfo(authorization, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GameApi.GetGameByNameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **name** | **string** |  |  |

### Return type

[**Game**](Game.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Game has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

