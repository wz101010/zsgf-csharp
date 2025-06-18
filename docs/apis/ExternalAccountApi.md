# ZSGF.Client.Api.ExternalAccountApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExternalAccountSignIn**](ExternalAccountApi.md#externalaccountsignin) | **POST** /ExternalAccount/{appKey}/SignIn | 外部账号登录 |
| [**UserExternalAccountBind**](ExternalAccountApi.md#userexternalaccountbind) | **POST** /ExternalAccount/{appKey} | 绑定外部账号 |
| [**UserOAuthAccounts**](ExternalAccountApi.md#useroauthaccounts) | **GET** /ExternalAccount/{appKey} | 外部账号列表 |
| [**UserOAuthAccountsPutBind**](ExternalAccountApi.md#useroauthaccountsputbind) | **PUT** /ExternalAccount/{appKey}/{id} | 更新绑定账号 |
| [**UserOAuthAccountsUnBind**](ExternalAccountApi.md#useroauthaccountsunbind) | **DELETE** /ExternalAccount/{appKey}/{id} | 删除绑定账号 |

<a id="externalaccountsignin"></a>
# **ExternalAccountSignIn**
> TokenModelApiResponse ExternalAccountSignIn (string appKey, ExternalAccountSignInRequest externalAccountSignInRequest = null)

外部账号登录

使用外部账号登录应用

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ExternalAccountSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ExternalAccountApi(config);
            var appKey = "appKey_example";  // string | 
            var externalAccountSignInRequest = new ExternalAccountSignInRequest(); // ExternalAccountSignInRequest | 登录请求参数 (optional) 

            try
            {
                // 外部账号登录
                TokenModelApiResponse result = apiInstance.ExternalAccountSignIn(appKey, externalAccountSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalAccountApi.ExternalAccountSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExternalAccountSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部账号登录
    ApiResponse<TokenModelApiResponse> response = apiInstance.ExternalAccountSignInWithHttpInfo(appKey, externalAccountSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalAccountApi.ExternalAccountSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **externalAccountSignInRequest** | [**ExternalAccountSignInRequest**](ExternalAccountSignInRequest.md) | 登录请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="userexternalaccountbind"></a>
# **UserExternalAccountBind**
> BooleanApiResponse UserExternalAccountBind (string appKey, ExternalAccountBindRequest externalAccountBindRequest = null)

绑定外部账号

绑定外部账号，如果已存在绑定则直接返回成功

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserExternalAccountBindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ExternalAccountApi(config);
            var appKey = "appKey_example";  // string | 
            var externalAccountBindRequest = new ExternalAccountBindRequest(); // ExternalAccountBindRequest | 绑定请求参数 (optional) 

            try
            {
                // 绑定外部账号
                BooleanApiResponse result = apiInstance.UserExternalAccountBind(appKey, externalAccountBindRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalAccountApi.UserExternalAccountBind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserExternalAccountBindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 绑定外部账号
    ApiResponse<BooleanApiResponse> response = apiInstance.UserExternalAccountBindWithHttpInfo(appKey, externalAccountBindRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalAccountApi.UserExternalAccountBindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **externalAccountBindRequest** | [**ExternalAccountBindRequest**](ExternalAccountBindRequest.md) | 绑定请求参数 | [optional]  |

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

<a id="useroauthaccounts"></a>
# **UserOAuthAccounts**
> UserLoginsListApiResponse UserOAuthAccounts (string appKey)

外部账号列表

获取绑定成功的外部账号列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserOAuthAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ExternalAccountApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 外部账号列表
                UserLoginsListApiResponse result = apiInstance.UserOAuthAccounts(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalAccountApi.UserOAuthAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserOAuthAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部账号列表
    ApiResponse<UserLoginsListApiResponse> response = apiInstance.UserOAuthAccountsWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalAccountApi.UserOAuthAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

### Return type

[**UserLoginsListApiResponse**](UserLoginsListApiResponse.md)

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

<a id="useroauthaccountsputbind"></a>
# **UserOAuthAccountsPutBind**
> BooleanApiResponse UserOAuthAccountsPutBind (long id, string appKey, ExternalAccountPutRequest externalAccountPutRequest = null)

更新绑定账号

更新绑定的账号信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserOAuthAccountsPutBindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ExternalAccountApi(config);
            var id = 789L;  // long | 绑定ID
            var appKey = "appKey_example";  // string | 
            var externalAccountPutRequest = new ExternalAccountPutRequest(); // ExternalAccountPutRequest | 更新请求参数 (optional) 

            try
            {
                // 更新绑定账号
                BooleanApiResponse result = apiInstance.UserOAuthAccountsPutBind(id, appKey, externalAccountPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalAccountApi.UserOAuthAccountsPutBind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserOAuthAccountsPutBindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新绑定账号
    ApiResponse<BooleanApiResponse> response = apiInstance.UserOAuthAccountsPutBindWithHttpInfo(id, appKey, externalAccountPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalAccountApi.UserOAuthAccountsPutBindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 绑定ID |  |
| **appKey** | **string** |  |  |
| **externalAccountPutRequest** | [**ExternalAccountPutRequest**](ExternalAccountPutRequest.md) | 更新请求参数 | [optional]  |

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

<a id="useroauthaccountsunbind"></a>
# **UserOAuthAccountsUnBind**
> BooleanApiResponse UserOAuthAccountsUnBind (long id, string appKey)

删除绑定账号

删除绑定的外部账号

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserOAuthAccountsUnBindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ExternalAccountApi(config);
            var id = 789L;  // long | 绑定ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除绑定账号
                BooleanApiResponse result = apiInstance.UserOAuthAccountsUnBind(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ExternalAccountApi.UserOAuthAccountsUnBind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserOAuthAccountsUnBindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除绑定账号
    ApiResponse<BooleanApiResponse> response = apiInstance.UserOAuthAccountsUnBindWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ExternalAccountApi.UserOAuthAccountsUnBindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 绑定ID |  |
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

