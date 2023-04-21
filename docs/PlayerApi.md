# L3vels.Sdk.Api.PlayerApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PlayerAssetControllerPlayerAssetById**](PlayerApi.md#playerassetcontrollerplayerassetbyid) | **GET** /v1/player-asset/{project_id}/{id} | Retrieve player asset by ID |
| [**PlayerAssetControllerPlayerAssets**](PlayerApi.md#playerassetcontrollerplayerassets) | **GET** /v1/player-asset | Retrieve player assets |
| [**PlayerControllerCreatePlayer**](PlayerApi.md#playercontrollercreateplayer) | **POST** /v1/player | Create new player |
| [**PlayerControllerDeletePlayer**](PlayerApi.md#playercontrollerdeleteplayer) | **DELETE** /v1/player | Delete a Player |
| [**PlayerControllerGetPlayers**](PlayerApi.md#playercontrollergetplayers) | **GET** /v1/player | Retrieve players |
| [**PlayerControllerPlayerById**](PlayerApi.md#playercontrollerplayerbyid) | **GET** /v1/player/{project_id}/{id} | Retrieve player by ID |
| [**PlayerControllerPlayersCountByGameId**](PlayerApi.md#playercontrollerplayerscountbygameid) | **GET** /v1/player/count/{project_id} | Count players |
| [**PlayerControllerUpdatePlayer**](PlayerApi.md#playercontrollerupdateplayer) | **PUT** /v1/player | Update an existing Player |

<a name="playerassetcontrollerplayerassetbyid"></a>
# **PlayerAssetControllerPlayerAssetById**
> PlayerAsset PlayerAssetControllerPlayerAssetById (string authorization, string id, string projectId)

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
    public class PlayerAssetControllerPlayerAssetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var id = "id_example";  // string | 
            var projectId = "projectId_example";  // string | 

            try
            {
                // Retrieve player asset by ID
                PlayerAsset result = apiInstance.PlayerAssetControllerPlayerAssetById(authorization, id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerAssetControllerPlayerAssetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerAssetControllerPlayerAssetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve player asset by ID
    ApiResponse<PlayerAsset> response = apiInstance.PlayerAssetControllerPlayerAssetByIdWithHttpInfo(authorization, id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerAssetControllerPlayerAssetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **id** | **string** |  |  |
| **projectId** | **string** |  |  |

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

<a name="playerassetcontrollerplayerassets"></a>
# **PlayerAssetControllerPlayerAssets**
> List&lt;PlayerAsset&gt; PlayerAssetControllerPlayerAssets (string authorization, string projectId, string assetId = null, string playerId = null, string sort = null, string order = null, decimal? limit = null, decimal? page = null)

Retrieve player assets

This API method retrieves a list of Player assets that match the specified filter criteria. Developers can use this method to retrieve Player assets by player, game/project or other properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class PlayerAssetControllerPlayerAssetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var projectId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game/project ID to find player assets in your game. Example: Fortnite, Minecraft, etc.
            var assetId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game/project ID to find player assets in your game. Example: Fortnite, Minecraft, etc. (optional) 
            var playerId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game/project ID to find player assets in your game. Example: Fortnite, Minecraft, etc. (optional) 
            var sort = name;  // string | Player asset field to sort by. You can sort by name, created_on and etc. (optional) 
            var order = ASC;  // string | Sort order (ASC for ascending or DESC for descending) (optional) 
            var limit = 10;  // decimal? | Number of player assets to return per page (optional) 
            var page = 1;  // decimal? | Page number (optional) 

            try
            {
                // Retrieve player assets
                List<PlayerAsset> result = apiInstance.PlayerAssetControllerPlayerAssets(authorization, projectId, assetId, playerId, sort, order, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerAssetControllerPlayerAssets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerAssetControllerPlayerAssetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve player assets
    ApiResponse<List<PlayerAsset>> response = apiInstance.PlayerAssetControllerPlayerAssetsWithHttpInfo(authorization, projectId, assetId, playerId, sort, order, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerAssetControllerPlayerAssetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **projectId** | **string** | Game/project ID to find player assets in your game. Example: Fortnite, Minecraft, etc. |  |
| **assetId** | **string** | Game/project ID to find player assets in your game. Example: Fortnite, Minecraft, etc. | [optional]  |
| **playerId** | **string** | Game/project ID to find player assets in your game. Example: Fortnite, Minecraft, etc. | [optional]  |
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

<a name="playercontrollercreateplayer"></a>
# **PlayerControllerCreatePlayer**
> Player PlayerControllerCreatePlayer (string authorization, CreatePlayerDto createPlayerDto)

Create new player

Create new player for game/project. Example: Create new player Jack in game Call of Duty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class PlayerControllerCreatePlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var createPlayerDto = new CreatePlayerDto(); // CreatePlayerDto | 

            try
            {
                // Create new player
                Player result = apiInstance.PlayerControllerCreatePlayer(authorization, createPlayerDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerControllerCreatePlayer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerControllerCreatePlayerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create new player
    ApiResponse<Player> response = apiInstance.PlayerControllerCreatePlayerWithHttpInfo(authorization, createPlayerDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerControllerCreatePlayerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **createPlayerDto** | [**CreatePlayerDto**](CreatePlayerDto.md) |  |  |

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

<a name="playercontrollerdeleteplayer"></a>
# **PlayerControllerDeletePlayer**
> void PlayerControllerDeletePlayer (string authorization)

Delete a Player

This API method allows developers to delete a Player by providing the ID of the Player. Once deleted, the Player and all associated assets will be removed from the system.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class PlayerControllerDeletePlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.

            try
            {
                // Delete a Player
                apiInstance.PlayerControllerDeletePlayer(authorization);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerControllerDeletePlayer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerControllerDeletePlayerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Player
    apiInstance.PlayerControllerDeletePlayerWithHttpInfo(authorization);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerControllerDeletePlayerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |

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
| **200** | The players has successful deleted. |  -  |
| **400** | Bad Request, The request was unacceptable, often due to missing a required parameter. |  -  |
| **401** | Unauthorized, No valid API key provided. |  -  |
| **404** | Not Found, The requested resource doesn&#39;t exist. |  -  |
| **409** | Conflict, The request conflicts with another request (perhaps due to using the same idempotent key). |  -  |
| **429** | Too Many Requests, Too many requests hit the API too quickly. We recommend an exponential backoff of your requests. |  -  |
| **500** | Server Errors, Something went wrong on L3vels&#39;s end. |  -  |
| **504** | Gateway Timeout, Your request took too long. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="playercontrollergetplayers"></a>
# **PlayerControllerGetPlayers**
> List&lt;Player&gt; PlayerControllerGetPlayers (string authorization, string projectId, string sort = null, string order = null, string searchText = null, decimal? limit = null, decimal? page = null)

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
    public class PlayerControllerGetPlayersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var projectId = a44b646a-ae14-4e05-ae09-b12d5e7269bf;  // string | Game/project ID to find player in your game. Example: Fortnite, Minecraft, etc.
            var sort = name;  // string | Player field to sort by. You can sort by name, created_on and etc. (optional) 
            var order = ASC;  // string | Sort order (ASC for ascending or DESC for descending) (optional) 
            var searchText = Jack;  // string | Search player by name (optional) 
            var limit = 10;  // decimal? | Number of players to return per page (optional) 
            var page = 1;  // decimal? | Page number (optional) 

            try
            {
                // Retrieve players
                List<Player> result = apiInstance.PlayerControllerGetPlayers(authorization, projectId, sort, order, searchText, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerControllerGetPlayers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerControllerGetPlayersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve players
    ApiResponse<List<Player>> response = apiInstance.PlayerControllerGetPlayersWithHttpInfo(authorization, projectId, sort, order, searchText, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerControllerGetPlayersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **projectId** | **string** | Game/project ID to find player in your game. Example: Fortnite, Minecraft, etc. |  |
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

<a name="playercontrollerplayerbyid"></a>
# **PlayerControllerPlayerById**
> Player PlayerControllerPlayerById (string authorization, string id, string projectId)

Retrieve player by ID

Retrieves a specific player by ID associated with game/project. Example: retrieve player Jack from game Call of Duty.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class PlayerControllerPlayerByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var id = 9abd57ce-b11c-4828-ab6a-19f568a8081a;  // string | Player ID that you created in your game/project. Example: Jack, George, etc.
            var projectId = 556a2843-b302-4b9d-916c-cefcb5d66053;  // string | Game/project ID to find asset in. Example: Call of Duty, Fortnite, etc.

            try
            {
                // Retrieve player by ID
                Player result = apiInstance.PlayerControllerPlayerById(authorization, id, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerControllerPlayerById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerControllerPlayerByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve player by ID
    ApiResponse<Player> response = apiInstance.PlayerControllerPlayerByIdWithHttpInfo(authorization, id, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerControllerPlayerByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **id** | **string** | Player ID that you created in your game/project. Example: Jack, George, etc. |  |
| **projectId** | **string** | Game/project ID to find asset in. Example: Call of Duty, Fortnite, etc. |  |

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

<a name="playercontrollerplayerscountbygameid"></a>
# **PlayerControllerPlayersCountByGameId**
> decimal PlayerControllerPlayersCountByGameId (string authorization, string projectId)

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
    public class PlayerControllerPlayersCountByGameIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.
            var projectId = 1;  // string | Game Id

            try
            {
                // Count players
                decimal result = apiInstance.PlayerControllerPlayersCountByGameId(authorization, projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerControllerPlayersCountByGameId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerControllerPlayersCountByGameIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Count players
    ApiResponse<decimal> response = apiInstance.PlayerControllerPlayersCountByGameIdWithHttpInfo(authorization, projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerControllerPlayersCountByGameIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |
| **projectId** | **string** | Game Id |  |

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

<a name="playercontrollerupdateplayer"></a>
# **PlayerControllerUpdatePlayer**
> Player PlayerControllerUpdatePlayer (string authorization)

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
    public class PlayerControllerUpdatePlayerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new PlayerApi(config);
            var authorization = "authorization_example";  // string | API key is associated with multiple projects. Please include it in to use developers API.

            try
            {
                // Update an existing Player
                Player result = apiInstance.PlayerControllerUpdatePlayer(authorization);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PlayerApi.PlayerControllerUpdatePlayer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PlayerControllerUpdatePlayerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an existing Player
    ApiResponse<Player> response = apiInstance.PlayerControllerUpdatePlayerWithHttpInfo(authorization);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PlayerApi.PlayerControllerUpdatePlayerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | API key is associated with multiple projects. Please include it in to use developers API. |  |

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

