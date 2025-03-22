# ZSGF.Client.Api.AppSettingApi

All URIs are relative to *https://api-staging.paomo.fun*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AppServiceSettingGroup**](AppSettingApi.md#appservicesettinggroup) | **GET** /AppSetting/{appKey}/Groups/{id} | 服务分组详情 |
| [**AppServiceSettingGroupDelete**](AppSettingApi.md#appservicesettinggroupdelete) | **DELETE** /AppSetting/{appKey}/Groups/{id} | 删除服务分组 |
| [**AppServiceSettingGroupPost**](AppSettingApi.md#appservicesettinggrouppost) | **POST** /AppSetting/{appKey}/Groups | 添加服务分组 |
| [**AppServiceSettingGroupPut**](AppSettingApi.md#appservicesettinggroupput) | **PUT** /AppSetting/{appKey}/Groups/{id} | 更新服务分组 |
| [**AppServiceSettingGroups**](AppSettingApi.md#appservicesettinggroups) | **GET** /AppSetting/{appKey}/Groups | 服务分组 |
| [**AppServiceSettingItem**](AppSettingApi.md#appservicesettingitem) | **GET** /AppSetting/{appKey}/Items/{id} | 服务配置项详情 |
| [**AppServiceSettingItemDelete**](AppSettingApi.md#appservicesettingitemdelete) | **DELETE** /AppSetting/{appKey}/Items/{id} | 删除服务配置项 |
| [**AppServiceSettingItemPost**](AppSettingApi.md#appservicesettingitempost) | **POST** /AppSetting/{appKey}/Items | 添加服务配置项 |
| [**AppServiceSettingItemPut**](AppSettingApi.md#appservicesettingitemput) | **PUT** /AppSetting/{appKey}/Items/{id} | 更新服务配置项 |
| [**AppServiceSettingItems**](AppSettingApi.md#appservicesettingitems) | **GET** /AppSetting/{appKey}/Items | 服务配置项列表 |
| [**AppServiceSettingProvider**](AppSettingApi.md#appservicesettingprovider) | **GET** /AppSetting/{appKey}/Providers/{id} | 服务商详情 |
| [**AppServiceSettingProviderDelete**](AppSettingApi.md#appservicesettingproviderdelete) | **DELETE** /AppSetting/{appKey}/Providers/{id} | 删除服务商 |
| [**AppServiceSettingProviderPost**](AppSettingApi.md#appservicesettingproviderpost) | **POST** /AppSetting/{appKey}/Providers | 添加服务商 |
| [**AppServiceSettingProviderPut**](AppSettingApi.md#appservicesettingproviderput) | **PUT** /AppSetting/{appKey}/Providers/{id} | 更新服务商 |
| [**AppServiceSettingProviders**](AppSettingApi.md#appservicesettingproviders) | **GET** /AppSetting/{appKey}/Providers | 服务商列表 |
| [**AppSetting**](AppSettingApi.md#appsetting) | **GET** /AppSetting/{appKey}/{id} | 配置详情 |
| [**AppSettingDelete**](AppSettingApi.md#appsettingdelete) | **DELETE** /AppSetting/{appKey}/{id} | 删除配置 |
| [**AppSettingPost**](AppSettingApi.md#appsettingpost) | **POST** /AppSetting/{appKey} | 增加配置 |
| [**AppSettingPut**](AppSettingApi.md#appsettingput) | **PUT** /AppSetting/{appKey}/{id} | 更新配置 |
| [**AppSettings**](AppSettingApi.md#appsettings) | **GET** /AppSetting/{appKey} | 配置列表 |

<a id="appservicesettinggroup"></a>
# **AppServiceSettingGroup**
> JObjectApiResult AppServiceSettingGroup (long id, string appKey)

服务分组详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 服务分组详情
                JObjectApiResult result = apiInstance.AppServiceSettingGroup(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 服务分组详情
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingGroupWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettinggroupdelete"></a>
# **AppServiceSettingGroupDelete**
> JObjectApiResult AppServiceSettingGroupDelete (long id, string appKey)

删除服务分组

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingGroupDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除服务分组
                JObjectApiResult result = apiInstance.AppServiceSettingGroupDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroupDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingGroupDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除服务分组
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingGroupDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroupDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettinggrouppost"></a>
# **AppServiceSettingGroupPost**
> JObjectApiResult AppServiceSettingGroupPost (string appKey, ServiceGroup serviceGroup = null)

添加服务分组

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var serviceGroup = new ServiceGroup(); // ServiceGroup |  (optional) 

            try
            {
                // 添加服务分组
                JObjectApiResult result = apiInstance.AppServiceSettingGroupPost(appKey, serviceGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加服务分组
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingGroupPostWithHttpInfo(appKey, serviceGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **serviceGroup** | [**ServiceGroup**](ServiceGroup.md) |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettinggroupput"></a>
# **AppServiceSettingGroupPut**
> JObjectApiResult AppServiceSettingGroupPut (long id, string appKey, ServiceGroup serviceGroup = null)

更新服务分组

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingGroupPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var serviceGroup = new ServiceGroup(); // ServiceGroup |  (optional) 

            try
            {
                // 更新服务分组
                JObjectApiResult result = apiInstance.AppServiceSettingGroupPut(id, appKey, serviceGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroupPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingGroupPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新服务分组
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingGroupPutWithHttpInfo(id, appKey, serviceGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroupPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **serviceGroup** | [**ServiceGroup**](ServiceGroup.md) |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettinggroups"></a>
# **AppServiceSettingGroups**
> JObjectApiResult AppServiceSettingGroups (string appKey, long providerId = null, bool showFlag = null)

服务分组

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var providerId = 789L;  // long |  (optional) 
            var showFlag = false;  // bool |  (optional)  (default to false)

            try
            {
                // 服务分组
                JObjectApiResult result = apiInstance.AppServiceSettingGroups(appKey, providerId, showFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 服务分组
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingGroupsWithHttpInfo(appKey, providerId, showFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **providerId** | **long** |  | [optional]  |
| **showFlag** | **bool** |  | [optional] [default to false] |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingitem"></a>
# **AppServiceSettingItem**
> JObjectApiResult AppServiceSettingItem (long id, string appKey)

服务配置项详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 服务配置项详情
                JObjectApiResult result = apiInstance.AppServiceSettingItem(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 服务配置项详情
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingItemWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingitemdelete"></a>
# **AppServiceSettingItemDelete**
> JObjectApiResult AppServiceSettingItemDelete (long id, string appKey)

删除服务配置项

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingItemDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除服务配置项
                JObjectApiResult result = apiInstance.AppServiceSettingItemDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItemDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingItemDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除服务配置项
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingItemDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItemDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingitempost"></a>
# **AppServiceSettingItemPost**
> JObjectApiResult AppServiceSettingItemPost (string appKey, ServiceItem serviceItem = null)

添加服务配置项

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingItemPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var serviceItem = new ServiceItem(); // ServiceItem |  (optional) 

            try
            {
                // 添加服务配置项
                JObjectApiResult result = apiInstance.AppServiceSettingItemPost(appKey, serviceItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItemPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingItemPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加服务配置项
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingItemPostWithHttpInfo(appKey, serviceItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItemPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **serviceItem** | [**ServiceItem**](ServiceItem.md) |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingitemput"></a>
# **AppServiceSettingItemPut**
> JObjectApiResult AppServiceSettingItemPut (long id, string appKey, ServiceItem serviceItem = null)

更新服务配置项

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingItemPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var serviceItem = new ServiceItem(); // ServiceItem |  (optional) 

            try
            {
                // 更新服务配置项
                JObjectApiResult result = apiInstance.AppServiceSettingItemPut(id, appKey, serviceItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItemPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingItemPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新服务配置项
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingItemPutWithHttpInfo(id, appKey, serviceItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItemPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **serviceItem** | [**ServiceItem**](ServiceItem.md) |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingitems"></a>
# **AppServiceSettingItems**
> JObjectApiResult AppServiceSettingItems (string appKey, string bizCode = null, string providerCode = null, string groupCode = null, bool showFlag = null)

服务配置项列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var bizCode = "bizCode_example";  // string |  (optional) 
            var providerCode = "providerCode_example";  // string |  (optional) 
            var groupCode = "groupCode_example";  // string |  (optional) 
            var showFlag = false;  // bool |  (optional)  (default to false)

            try
            {
                // 服务配置项列表
                JObjectApiResult result = apiInstance.AppServiceSettingItems(appKey, bizCode, providerCode, groupCode, showFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 服务配置项列表
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingItemsWithHttpInfo(appKey, bizCode, providerCode, groupCode, showFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **bizCode** | **string** |  | [optional]  |
| **providerCode** | **string** |  | [optional]  |
| **groupCode** | **string** |  | [optional]  |
| **showFlag** | **bool** |  | [optional] [default to false] |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingprovider"></a>
# **AppServiceSettingProvider**
> JObjectApiResult AppServiceSettingProvider (long id, string appKey)

服务商详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 服务商详情
                JObjectApiResult result = apiInstance.AppServiceSettingProvider(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 服务商详情
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingProviderWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingproviderdelete"></a>
# **AppServiceSettingProviderDelete**
> JObjectApiResult AppServiceSettingProviderDelete (long id, string appKey)

删除服务商

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingProviderDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除服务商
                JObjectApiResult result = apiInstance.AppServiceSettingProviderDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProviderDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingProviderDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除服务商
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingProviderDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProviderDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingproviderpost"></a>
# **AppServiceSettingProviderPost**
> JObjectApiResult AppServiceSettingProviderPost (string appKey, ServiceProvider serviceProvider = null)

添加服务商

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingProviderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var serviceProvider = new ServiceProvider(); // ServiceProvider |  (optional) 

            try
            {
                // 添加服务商
                JObjectApiResult result = apiInstance.AppServiceSettingProviderPost(appKey, serviceProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProviderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingProviderPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加服务商
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingProviderPostWithHttpInfo(appKey, serviceProvider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProviderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **serviceProvider** | [**ServiceProvider**](ServiceProvider.md) |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingproviderput"></a>
# **AppServiceSettingProviderPut**
> JObjectApiResult AppServiceSettingProviderPut (long id, string appKey, ServiceProvider serviceProvider = null)

更新服务商

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingProviderPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var serviceProvider = new ServiceProvider(); // ServiceProvider |  (optional) 

            try
            {
                // 更新服务商
                JObjectApiResult result = apiInstance.AppServiceSettingProviderPut(id, appKey, serviceProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProviderPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingProviderPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新服务商
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingProviderPutWithHttpInfo(id, appKey, serviceProvider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProviderPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **serviceProvider** | [**ServiceProvider**](ServiceProvider.md) |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appservicesettingproviders"></a>
# **AppServiceSettingProviders**
> JObjectApiResult AppServiceSettingProviders (string appKey, string bizCode = null, bool showFlag = null)

服务商列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppServiceSettingProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var bizCode = "bizCode_example";  // string |  (optional) 
            var showFlag = false;  // bool |  (optional)  (default to false)

            try
            {
                // 服务商列表
                JObjectApiResult result = apiInstance.AppServiceSettingProviders(appKey, bizCode, showFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProviders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppServiceSettingProvidersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 服务商列表
    ApiResponse<JObjectApiResult> response = apiInstance.AppServiceSettingProvidersWithHttpInfo(appKey, bizCode, showFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppServiceSettingProvidersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **bizCode** | **string** |  | [optional]  |
| **showFlag** | **bool** |  | [optional] [default to false] |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appsetting"></a>
# **AppSetting**
> JObjectApiResult AppSetting (long id, string appKey)

配置详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 配置详情
                JObjectApiResult result = apiInstance.AppSetting(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 配置详情
    ApiResponse<JObjectApiResult> response = apiInstance.AppSettingWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appsettingdelete"></a>
# **AppSettingDelete**
> JObjectApiResult AppSettingDelete (long id, string appKey)

删除配置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppSettingDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除配置
                JObjectApiResult result = apiInstance.AppSettingDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppSettingDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppSettingDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除配置
    ApiResponse<JObjectApiResult> response = apiInstance.AppSettingDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppSettingDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appsettingpost"></a>
# **AppSettingPost**
> JObjectApiResult AppSettingPost (string appKey, AppSetting appSetting = null)

增加配置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppSettingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var appSetting = new AppSetting(); // AppSetting |  (optional) 

            try
            {
                // 增加配置
                JObjectApiResult result = apiInstance.AppSettingPost(appKey, appSetting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppSettingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppSettingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 增加配置
    ApiResponse<JObjectApiResult> response = apiInstance.AppSettingPostWithHttpInfo(appKey, appSetting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppSettingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **appSetting** | [**AppSetting**](AppSetting.md) |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appsettingput"></a>
# **AppSettingPut**
> JObjectApiResult AppSettingPut (long id, string appKey, AppSetting appSetting = null)

更新配置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppSettingPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var appSetting = new AppSetting(); // AppSetting |  (optional) 

            try
            {
                // 更新配置
                JObjectApiResult result = apiInstance.AppSettingPut(id, appKey, appSetting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppSettingPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppSettingPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新配置
    ApiResponse<JObjectApiResult> response = apiInstance.AppSettingPutWithHttpInfo(id, appKey, appSetting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppSettingPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **appSetting** | [**AppSetting**](AppSetting.md) |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="appsettings"></a>
# **AppSettings**
> JObjectApiResult AppSettings (string appKey, string providerCode = null, string groupCode = null, string tag = null, string code = null)

配置列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AppSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AppSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var providerCode = "providerCode_example";  // string | 服务商代码 (optional) 
            var groupCode = "groupCode_example";  // string | 服务代码 (optional) 
            var tag = "tag_example";  // string | 标签 (optional) 
            var code = "code_example";  // string | 配置项代码 (optional) 

            try
            {
                // 配置列表
                JObjectApiResult result = apiInstance.AppSettings(appKey, providerCode, groupCode, tag, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AppSettingApi.AppSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AppSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 配置列表
    ApiResponse<JObjectApiResult> response = apiInstance.AppSettingsWithHttpInfo(appKey, providerCode, groupCode, tag, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AppSettingApi.AppSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **providerCode** | **string** | 服务商代码 | [optional]  |
| **groupCode** | **string** | 服务代码 | [optional]  |
| **tag** | **string** | 标签 | [optional]  |
| **code** | **string** | 配置项代码 | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

