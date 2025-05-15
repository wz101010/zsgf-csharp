# ZSGF.Client.Api.UserSettingApi

All URIs are relative to *https://api.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserSetting**](UserSettingApi.md#usersetting) | **GET** /UserSetting/{appKey}/{id} | 获取用户配置项详情 |
| [**UserSettingDelete**](UserSettingApi.md#usersettingdelete) | **DELETE** /UserSetting/{appKey}/{id} | 删除用户配置项 |
| [**UserSettingPost**](UserSettingApi.md#usersettingpost) | **POST** /UserSetting/{appKey} | 添加用户配置项 |
| [**UserSettingPut**](UserSettingApi.md#usersettingput) | **PUT** /UserSetting/{appKey}/{id} | 更新用户配置项 |
| [**UserSettings**](UserSettingApi.md#usersettings) | **GET** /UserSetting/{appKey} | 获取用户配置列表 |

<a id="usersetting"></a>
# **UserSetting**
> UserSettingApiResponse UserSetting (long id, string appKey)

获取用户配置项详情

根据配置项ID获取用户配置项详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSettingApi(config);
            var id = 789L;  // long | 配置项ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取用户配置项详情
                UserSettingApiResponse result = apiInstance.UserSetting(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSettingApi.UserSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取用户配置项详情
    ApiResponse<UserSettingApiResponse> response = apiInstance.UserSettingWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSettingApi.UserSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 配置项ID |  |
| **appKey** | **string** |  |  |

### Return type

[**UserSettingApiResponse**](UserSettingApiResponse.md)

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

<a id="usersettingdelete"></a>
# **UserSettingDelete**
> BooleanApiResponse UserSettingDelete (long id, string appKey)

删除用户配置项

根据配置项ID删除用户配置项

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSettingDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSettingApi(config);
            var id = 789L;  // long | 配置项ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除用户配置项
                BooleanApiResponse result = apiInstance.UserSettingDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSettingApi.UserSettingDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSettingDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除用户配置项
    ApiResponse<BooleanApiResponse> response = apiInstance.UserSettingDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSettingApi.UserSettingDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 配置项ID |  |
| **appKey** | **string** |  |  |

### Return type

[**BooleanApiResponse**](BooleanApiResponse.md)

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

<a id="usersettingpost"></a>
# **UserSettingPost**
> UserSettingPostResultApiResponse UserSettingPost (string appKey, UserSetting userSetting = null)

添加用户配置项

添加新的用户配置项

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSettingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var userSetting = new UserSetting(); // UserSetting | 配置项内容 (optional) 

            try
            {
                // 添加用户配置项
                UserSettingPostResultApiResponse result = apiInstance.UserSettingPost(appKey, userSetting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSettingApi.UserSettingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSettingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加用户配置项
    ApiResponse<UserSettingPostResultApiResponse> response = apiInstance.UserSettingPostWithHttpInfo(appKey, userSetting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSettingApi.UserSettingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **userSetting** | [**UserSetting**](UserSetting.md) | 配置项内容 | [optional]  |

### Return type

[**UserSettingPostResultApiResponse**](UserSettingPostResultApiResponse.md)

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

<a id="usersettingput"></a>
# **UserSettingPut**
> BooleanApiResponse UserSettingPut (long id, string appKey, UserSetting userSetting = null)

更新用户配置项

根据配置项ID更新用户配置项内容

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSettingPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSettingApi(config);
            var id = 789L;  // long | 配置项ID
            var appKey = "appKey_example";  // string | 
            var userSetting = new UserSetting(); // UserSetting | 配置项内容 (optional) 

            try
            {
                // 更新用户配置项
                BooleanApiResponse result = apiInstance.UserSettingPut(id, appKey, userSetting);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSettingApi.UserSettingPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSettingPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新用户配置项
    ApiResponse<BooleanApiResponse> response = apiInstance.UserSettingPutWithHttpInfo(id, appKey, userSetting);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSettingApi.UserSettingPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 配置项ID |  |
| **appKey** | **string** |  |  |
| **userSetting** | [**UserSetting**](UserSetting.md) | 配置项内容 | [optional]  |

### Return type

[**BooleanApiResponse**](BooleanApiResponse.md)

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

<a id="usersettings"></a>
# **UserSettings**
> UserSettingListApiResponse UserSettings (string appKey, long userId = null, string code = null, string tag = null)

获取用户配置列表

根据用户ID、配置项代码和标签获取用户配置列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserSettingApi(config);
            var appKey = "appKey_example";  // string | 
            var userId = 789L;  // long | 用户ID (optional) 
            var code = "code_example";  // string | 配置项代码 (optional) 
            var tag = "tag_example";  // string | 配置项标签 (optional) 

            try
            {
                // 获取用户配置列表
                UserSettingListApiResponse result = apiInstance.UserSettings(appKey, userId, code, tag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSettingApi.UserSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取用户配置列表
    ApiResponse<UserSettingListApiResponse> response = apiInstance.UserSettingsWithHttpInfo(appKey, userId, code, tag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSettingApi.UserSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **userId** | **long** | 用户ID | [optional]  |
| **code** | **string** | 配置项代码 | [optional]  |
| **tag** | **string** | 配置项标签 | [optional]  |

### Return type

[**UserSettingListApiResponse**](UserSettingListApiResponse.md)

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

