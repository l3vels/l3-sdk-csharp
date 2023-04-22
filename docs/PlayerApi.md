# L3vels.Sdk.Api.PlayerApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CountPlayersByGameId**](PlayerApi.md#countplayersbygameid) | **GET** /v1/player/count/{game_id} | Count players |
| [**CreatePlayer**](PlayerApi.md#createplayer) | **POST** /v1/player | Create new player |
| [**GetPlayerAssetById**](PlayerApi.md#getplayerassetbyid) | **GET** /v1/player-asset/{game_id}/{id} | Retrieve player asset by ID |
| [**GetPlayerById**](PlayerApi.md#getplayerbyid) | **GET** /v1/player/{game_id}/{id} | Retrieve player by ID |
| [**GetPlayers**](PlayerApi.md#getplayers) | **GET** /v1/player | Retrieve players |
| [**PlayerAssets**](PlayerApi.md#playerassets) | **GET** /v1/player-asset | Retrieve player assets |
| [**UpdatePlayer**](PlayerApi.md#updateplayer) | **PUT** /v1/player | Update an existing Player |

<a name="countplayersbygameid"></a>
# **CountPlayersByGameId**
> decimal CountPlayersByGameId (string authorization, string gameId)

Count players

Count players in game. Example: count players in game Call of Duty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class CountPlayersByGameIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var gameId = 1;  // string | Game Id

            try
            {
                // Count players
                decimal result = apiInstance.CountPlayersByGameId(authorization, gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.CountPlayersByGameId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CountPlayersByGameIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Count players
    ApiResponse<decimal> response = apiInstance.CountPlayersByGameIdWithHttpInfo(authorization, gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.CountPlayersByGameIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **gameId** | **string** | Game Id |  |

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
| **200** | The players has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createplayer"></a>
# **CreatePlayer**
> Player CreatePlayer (string authorization, CreatePlayerInput createPlayerInput)

Create new player

Create new player for Game. Example: Create new player Jack in game Call of Duty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class CreatePlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var createPlayerInput = new CreatePlayerInput(); // CreatePlayerInput | 

            try
            {
                // Create new player
                Player result = apiInstance.CreatePlayer(authorization, createPlayerInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.CreatePlayer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePlayerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create new player
    ApiResponse<Player> response = apiInstance.CreatePlayerWithHttpInfo(authorization, createPlayerInput);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.CreatePlayerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **createPlayerInput** | [**CreatePlayerInput**](CreatePlayerInput.md) |  |  |

### Return type

[**Player**](Player.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The players has successfully created. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayerassetbyid"></a>
# **GetPlayerAssetById**
> PlayerAsset GetPlayerAssetById (string authorization, string id, string gameId)

Retrieve player asset by ID

Retrieve player asset by ID. Player asset represents a single asset that a player owns. It has amount field that represents how many of this asset player owns.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetPlayerAssetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var id = "id_example";  // string | 
            var gameId = "gameId_example";  // string | 

            try
            {
                // Retrieve player asset by ID
                PlayerAsset result = apiInstance.GetPlayerAssetById(authorization, id, gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayerAssetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlayerAssetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve player asset by ID
    ApiResponse<PlayerAsset> response = apiInstance.GetPlayerAssetByIdWithHttpInfo(authorization, id, gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.GetPlayerAssetByIdWithHttpInfo: " + e.Message);
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

[**PlayerAsset**](PlayerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The player asset has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayerbyid"></a>
# **GetPlayerById**
> Player GetPlayerById (string authorization, string id, string gameId)

Retrieve player by ID

Retrieves a specific player by ID associated with Game. Example: retrieve player Jack from game Call of Duty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetPlayerByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var id = 9abd57ce-b11c-4828-ab6a-19f568a8081a;  // string | Player ID that you created in your Game. Example: Jack, George, etc.
            var gameId = 556a2843-b302-4b9d-916c-cefcb5d66053;  // string | Game ID to find asset in. Example: Call of Duty, Fortnite, etc.

            try
            {
                // Retrieve player by ID
                Player result = apiInstance.GetPlayerById(authorization, id, gameId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayerById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlayerByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve player by ID
    ApiResponse<Player> response = apiInstance.GetPlayerByIdWithHttpInfo(authorization, id, gameId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.GetPlayerByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **id** | **string** | Player ID that you created in your Game. Example: Jack, George, etc. |  |
| **gameId** | **string** | Game ID to find asset in. Example: Call of Duty, Fortnite, etc. |  |

### Return type

[**Player**](Player.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The player has been found. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getplayers"></a>
# **GetPlayers**
> List&lt;Player&gt; GetPlayers (string authorization, string gameId, string sort = null, string order = null, string searchText = null, decimal? limit = null, decimal? page = null)

Retrieve players

Retrieve a list of players that match the specified filter criteria. Developers can use this method to retrieve players by name, category, status, or other properties. Example: Retrieve players from game Call of Duty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class GetPlayersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var gameId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game ID to find player in your game. Example: Fortnite, Minecraft, etc.
            var sort = name;  // string | Player field to sort by. You can sort by name, created_on and etc. (optional) 
            var order = ASC;  // string | Sort order (ASC for ascending or DESC for descending) (optional) 
            var searchText = Jack;  // string | Search player by name (optional) 
            var limit = 10;  // decimal? | Number of players to return per page (optional) 
            var page = 1;  // decimal? | Page number (optional) 

            try
            {
                // Retrieve players
                List<Player> result = apiInstance.GetPlayers(authorization, gameId, sort, order, searchText, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.GetPlayers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPlayersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve players
    ApiResponse<List<Player>> response = apiInstance.GetPlayersWithHttpInfo(authorization, gameId, sort, order, searchText, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.GetPlayersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **gameId** | **string** | Game ID to find player in your game. Example: Fortnite, Minecraft, etc. |  |
| **sort** | **string** | Player field to sort by. You can sort by name, created_on and etc. | [optional]  |
| **order** | **string** | Sort order (ASC for ascending or DESC for descending) | [optional]  |
| **searchText** | **string** | Search player by name | [optional]  |
| **limit** | **decimal?** | Number of players to return per page | [optional]  |
| **page** | **decimal?** | Page number | [optional]  |

### Return type

[**List&lt;Player&gt;**](Player.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The players has been found |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playerassets"></a>
# **PlayerAssets**
> List&lt;PlayerAsset&gt; PlayerAssets (string authorization, string gameId, string assetId = null, string playerId = null, string sort = null, string order = null, decimal? limit = null, decimal? page = null)

Retrieve player assets

This API method retrieves a list of Player assets that match the specified filter criteria. Developers can use this method to retrieve Player assets by player, Game or other properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class PlayerAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.
            var gameId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game ID to find player assets in your game. Example: Fortnite, Minecraft, etc.
            var assetId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game ID to find player assets in your game. Example: Fortnite, Minecraft, etc. (optional) 
            var playerId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game ID to find player assets in your game. Example: Fortnite, Minecraft, etc. (optional) 
            var sort = name;  // string | Player asset field to sort by. You can sort by name, created_on and etc. (optional) 
            var order = ASC;  // string | Sort order (ASC for ascending or DESC for descending) (optional) 
            var limit = 10;  // decimal? | Number of player assets to return per page (optional) 
            var page = 1;  // decimal? | Page number (optional) 

            try
            {
                // Retrieve player assets
                List<PlayerAsset> result = apiInstance.PlayerAssets(authorization, gameId, assetId, playerId, sort, order, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve player assets
    ApiResponse<List<PlayerAsset>> response = apiInstance.PlayerAssetsWithHttpInfo(authorization, gameId, assetId, playerId, sort, order, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |
| **gameId** | **string** | Game ID to find player assets in your game. Example: Fortnite, Minecraft, etc. |  |
| **assetId** | **string** | Game ID to find player assets in your game. Example: Fortnite, Minecraft, etc. | [optional]  |
| **playerId** | **string** | Game ID to find player assets in your game. Example: Fortnite, Minecraft, etc. | [optional]  |
| **sort** | **string** | Player asset field to sort by. You can sort by name, created_on and etc. | [optional]  |
| **order** | **string** | Sort order (ASC for ascending or DESC for descending) | [optional]  |
| **limit** | **decimal?** | Number of player assets to return per page | [optional]  |
| **page** | **decimal?** | Page number | [optional]  |

### Return type

[**List&lt;PlayerAsset&gt;**](PlayerAsset.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The player assets has been found |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateplayer"></a>
# **UpdatePlayer**
> Player UpdatePlayer (string authorization)

Update an existing Player

This API method allows developers to update an existing Player by providing the ID of the Player and the updated properties and associated assets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class UpdatePlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple games. Please include it in to use developers API.

            try
            {
                // Update an existing Player
                Player result = apiInstance.UpdatePlayer(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.UpdatePlayer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePlayerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing Player
    ApiResponse<Player> response = apiInstance.UpdatePlayerWithHttpInfo(authorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.UpdatePlayerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple games. Please include it in to use developers API. |  |

### Return type

[**Player**](Player.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The players has successful updated. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

