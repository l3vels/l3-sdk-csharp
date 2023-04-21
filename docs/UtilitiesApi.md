# L3vels.Sdk.Api.UtilitiesApi

All URIs are relative to *https://api-dev.l3vels.xyz*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UtilityControllerHealth**](UtilitiesApi.md#utilitycontrollerhealth) | **GET** /v1/utilities/health |  |

<a name="utilitycontrollerhealth"></a>
# **UtilityControllerHealth**
> void UtilityControllerHealth ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using L3vels.Sdk.Api;
using L3vels.Sdk.Client;
using L3vels.Sdk.Model;

namespace Example
{
    public class UtilityControllerHealthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.l3vels.xyz";
            var apiInstance = new UtilitiesApi(config);

            try
            {
                apiInstance.UtilityControllerHealth();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UtilitiesApi.UtilityControllerHealth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UtilityControllerHealthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UtilityControllerHealthWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UtilitiesApi.UtilityControllerHealthWithHttpInfo: " + e.Message);
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
| **400** | Account or User was not found. |  -  |
| **403** | Forbidden. Session is closed  or expired  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

