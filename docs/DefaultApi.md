# L3vels.Sdk.Api.DefaultApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ChatControllerGetSqlReport**](DefaultApi.md#chatcontrollergetsqlreport) | **GET** /v1/chat/report |  |
| [**ChatControllerWebhook**](DefaultApi.md#chatcontrollerwebhook) | **POST** /v1/chat/webhook |  |

<a name="chatcontrollergetsqlreport"></a>
# **ChatControllerGetSqlReport**
> void ChatControllerGetSqlReport (string sql)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class ChatControllerGetSqlReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new DefaultApi(config);
            var sql = "sql_example";  // string | 

            try
            {
                apiInstance.ChatControllerGetSqlReport(sql);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ChatControllerGetSqlReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatControllerGetSqlReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ChatControllerGetSqlReportWithHttpInfo(sql);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ChatControllerGetSqlReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sql** | **string** |  |  |

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
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="chatcontrollerwebhook"></a>
# **ChatControllerWebhook**
> void ChatControllerWebhook ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class ChatControllerWebhookExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.ChatControllerWebhook();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ChatControllerWebhook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChatControllerWebhookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ChatControllerWebhookWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ChatControllerWebhookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

