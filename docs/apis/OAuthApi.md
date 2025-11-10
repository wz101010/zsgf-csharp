# ZSGF.Client.Api.OAuthApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OAuthAuthorize**](OAuthApi.md#oauthauthorize) | **POST** /OAuth/{appKey}/Authorize | 获取访问令牌 |
| [**OAuthConsents**](OAuthApi.md#oauthconsents) | **GET** /OAuth/{appKey}/Consents | 获取授权记录 |
| [**OAuthDeleteConsent**](OAuthApi.md#oauthdeleteconsent) | **DELETE** /OAuth/{appKey}/Consents/{id} | 删除授权记录 |
| [**OAuthGrantCode**](OAuthApi.md#oauthgrantcode) | **POST** /OAuth/{appKey}/GrantCode | 获取授权码 |
| [**OAuthProfile**](OAuthApi.md#oauthprofile) | **GET** /OAuth/{appKey}/Profile | 获取用户资料 |

<a id="oauthauthorize"></a>
# **OAuthAuthorize**
> AuthorizeResultApiResponse OAuthAuthorize (string appKey, string scheme = null, string code = null)

获取访问令牌

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class OAuthAuthorizeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OAuthApi(config);
            var appKey = "appKey_example";  // string | 
            var scheme = "scheme_example";  // string | 身份源 (optional) 
            var code = "code_example";  // string | 授权码 (optional) 

            try
            {
                // 获取访问令牌
                AuthorizeResultApiResponse result = apiInstance.OAuthAuthorize(appKey, scheme, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OAuthAuthorize: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OAuthAuthorizeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取访问令牌
    ApiResponse<AuthorizeResultApiResponse> response = apiInstance.OAuthAuthorizeWithHttpInfo(appKey, scheme, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuthApi.OAuthAuthorizeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **scheme** | **string** | 身份源 | [optional]  |
| **code** | **string** | 授权码 | [optional]  |

### Return type

[**AuthorizeResultApiResponse**](AuthorizeResultApiResponse.md)

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

<a id="oauthconsents"></a>
# **OAuthConsents**
> AppUserConsentModelListApiResponse OAuthConsents (string appKey)

获取授权记录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class OAuthConsentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OAuthApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取授权记录
                AppUserConsentModelListApiResponse result = apiInstance.OAuthConsents(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OAuthConsents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OAuthConsentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取授权记录
    ApiResponse<AppUserConsentModelListApiResponse> response = apiInstance.OAuthConsentsWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuthApi.OAuthConsentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

### Return type

[**AppUserConsentModelListApiResponse**](AppUserConsentModelListApiResponse.md)

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

<a id="oauthdeleteconsent"></a>
# **OAuthDeleteConsent**
> BooleanApiResponse OAuthDeleteConsent (long id, string appKey)

删除授权记录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class OAuthDeleteConsentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OAuthApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除授权记录
                BooleanApiResponse result = apiInstance.OAuthDeleteConsent(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OAuthDeleteConsent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OAuthDeleteConsentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除授权记录
    ApiResponse<BooleanApiResponse> response = apiInstance.OAuthDeleteConsentWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuthApi.OAuthDeleteConsentWithHttpInfo: " + e.Message);
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

<a id="oauthgrantcode"></a>
# **OAuthGrantCode**
> GrantResultApiResponse OAuthGrantCode (string appKey, string scheme = null, GrantRequest grantRequest = null)

获取授权码

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class OAuthGrantCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OAuthApi(config);
            var appKey = "appKey_example";  // string | 
            var scheme = "scheme_example";  // string | 身份源，固定填：app (optional) 
            var grantRequest = new GrantRequest(); // GrantRequest | 授权详情 (optional) 

            try
            {
                // 获取授权码
                GrantResultApiResponse result = apiInstance.OAuthGrantCode(appKey, scheme, grantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OAuthGrantCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OAuthGrantCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取授权码
    ApiResponse<GrantResultApiResponse> response = apiInstance.OAuthGrantCodeWithHttpInfo(appKey, scheme, grantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuthApi.OAuthGrantCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **scheme** | **string** | 身份源，固定填：app | [optional]  |
| **grantRequest** | [**GrantRequest**](GrantRequest.md) | 授权详情 | [optional]  |

### Return type

[**GrantResultApiResponse**](GrantResultApiResponse.md)

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

<a id="oauthprofile"></a>
# **OAuthProfile**
> ProfileResultApiResponse OAuthProfile (string appKey)

获取用户资料

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class OAuthProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OAuthApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取用户资料
                ProfileResultApiResponse result = apiInstance.OAuthProfile(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OAuthApi.OAuthProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OAuthProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取用户资料
    ApiResponse<ProfileResultApiResponse> response = apiInstance.OAuthProfileWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OAuthApi.OAuthProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

### Return type

[**ProfileResultApiResponse**](ProfileResultApiResponse.md)

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

