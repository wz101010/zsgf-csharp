# ZSGF.Client.Api.WechatApi

All URIs are relative to *https://api-staging.paomo.fun*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WechatDecrypt**](WechatApi.md#wechatdecrypt) | **GET** /Wechat/{appKey}/Decrypt | 小程序-解密数据 |
| [**WechatGenerateScheme**](WechatApi.md#wechatgeneratescheme) | **POST** /Wechat/{appKey}/GenerateScheme | 小程序-生成scheme码(该接口用于获取小程序 scheme 码，适用于短信、邮件、外部网页、微信内等拉起小程序的业务场景) |
| [**WechatJSCode2Session**](WechatApi.md#wechatjscode2session) | **GET** /Wechat/{appKey}/JSCode2Session | 小程序-登录凭证校验 |
| [**WechatJSConfig**](WechatApi.md#wechatjsconfig) | **GET** /Wechat/{appKey}/JSConfig | 公众号H5-JS SDK Config |
| [**WechatSubscribeMSG**](WechatApi.md#wechatsubscribemsg) | **POST** /Wechat/{appKey}/SubscribeMSG | 公众号H5-发送一次性订阅消息 |
| [**WechatSubscribeSend**](WechatApi.md#wechatsubscribesend) | **POST** /Wechat/{appKey}/SubscribeSend | 小程序-发送订阅消息 |
| [**WechatUrlLinkGenerate**](WechatApi.md#wechaturllinkgenerate) | **POST** /Wechat/{appKey}/UrlLinkGenerate | 小程序-生成网页跳转地址(获取小程序 URL Link，适用于短信、邮件、网页、微信内等拉起小程序的业务场景) |
| [**WechatUserInfo**](WechatApi.md#wechatuserinfo) | **GET** /Wechat/{appKey}/UserInfo | 公众号H5-获取用户UnionID |
| [**WechatWXACodeGet**](WechatApi.md#wechatwxacodeget) | **POST** /Wechat/{appKey}/WXACodeGet | 小程序-获取小程序码 |
| [**WechatWXACodeGetUnlimited**](WechatApi.md#wechatwxacodegetunlimited) | **POST** /Wechat/{appKey}/WXACodeGetUnlimited | 小程序-获取小程序码(无限制) |

<a id="wechatdecrypt"></a>
# **WechatDecrypt**
> JObjectApiResult WechatDecrypt (string appKey, string encryptedData = null, string iv = null, string sessionKey = null)

小程序-解密数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatDecryptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var encryptedData = "encryptedData_example";  // string | 加密的数据 (optional) 
            var iv = "iv_example";  // string |  (optional) 
            var sessionKey = "sessionKey_example";  // string |  (optional) 

            try
            {
                // 小程序-解密数据
                JObjectApiResult result = apiInstance.WechatDecrypt(appKey, encryptedData, iv, sessionKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatDecrypt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatDecryptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 小程序-解密数据
    ApiResponse<JObjectApiResult> response = apiInstance.WechatDecryptWithHttpInfo(appKey, encryptedData, iv, sessionKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatDecryptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **encryptedData** | **string** | 加密的数据 | [optional]  |
| **iv** | **string** |  | [optional]  |
| **sessionKey** | **string** |  | [optional]  |

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

<a id="wechatgeneratescheme"></a>
# **WechatGenerateScheme**
> JObjectApiResult WechatGenerateScheme (string appKey, Object body = null)

小程序-生成scheme码(该接口用于获取小程序 scheme 码，适用于短信、邮件、外部网页、微信内等拉起小程序的业务场景)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatGenerateSchemeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var body = null;  // Object | 开发参考：https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/qrcode-link/url-scheme/generateScheme.html (optional) 

            try
            {
                // 小程序-生成scheme码(该接口用于获取小程序 scheme 码，适用于短信、邮件、外部网页、微信内等拉起小程序的业务场景)
                JObjectApiResult result = apiInstance.WechatGenerateScheme(appKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatGenerateScheme: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatGenerateSchemeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 小程序-生成scheme码(该接口用于获取小程序 scheme 码，适用于短信、邮件、外部网页、微信内等拉起小程序的业务场景)
    ApiResponse<JObjectApiResult> response = apiInstance.WechatGenerateSchemeWithHttpInfo(appKey, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatGenerateSchemeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **body** | **Object** | 开发参考：https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/qrcode-link/url-scheme/generateScheme.html | [optional]  |

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

<a id="wechatjscode2session"></a>
# **WechatJSCode2Session**
> JObjectApiResult WechatJSCode2Session (string appKey, string jsCode = null)

小程序-登录凭证校验

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatJSCode2SessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var jsCode = "jsCode_example";  // string | 开发参考：https://dwz.cn/icNajFh7 (optional) 

            try
            {
                // 小程序-登录凭证校验
                JObjectApiResult result = apiInstance.WechatJSCode2Session(appKey, jsCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatJSCode2Session: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatJSCode2SessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 小程序-登录凭证校验
    ApiResponse<JObjectApiResult> response = apiInstance.WechatJSCode2SessionWithHttpInfo(appKey, jsCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatJSCode2SessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **jsCode** | **string** | 开发参考：https://dwz.cn/icNajFh7 | [optional]  |

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

<a id="wechatjsconfig"></a>
# **WechatJSConfig**
> JObjectApiResult WechatJSConfig (string appKey, string url = null)

公众号H5-JS SDK Config

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatJSConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var url = "url_example";  // string |  (optional) 

            try
            {
                // 公众号H5-JS SDK Config
                JObjectApiResult result = apiInstance.WechatJSConfig(appKey, url);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatJSConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatJSConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 公众号H5-JS SDK Config
    ApiResponse<JObjectApiResult> response = apiInstance.WechatJSConfigWithHttpInfo(appKey, url);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatJSConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **url** | **string** |  | [optional]  |

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

<a id="wechatsubscribemsg"></a>
# **WechatSubscribeMSG**
> JObjectApiResult WechatSubscribeMSG (string appKey, Object body = null)

公众号H5-发送一次性订阅消息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatSubscribeMSGExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var body = null;  // Object | 开发参考：https://dwz.cn/IXptek5n (optional) 

            try
            {
                // 公众号H5-发送一次性订阅消息
                JObjectApiResult result = apiInstance.WechatSubscribeMSG(appKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatSubscribeMSG: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatSubscribeMSGWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 公众号H5-发送一次性订阅消息
    ApiResponse<JObjectApiResult> response = apiInstance.WechatSubscribeMSGWithHttpInfo(appKey, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatSubscribeMSGWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **body** | **Object** | 开发参考：https://dwz.cn/IXptek5n | [optional]  |

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

<a id="wechatsubscribesend"></a>
# **WechatSubscribeSend**
> JObjectApiResult WechatSubscribeSend (string appKey, Object body = null)

小程序-发送订阅消息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatSubscribeSendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var body = null;  // Object | 开发参考：https://dwz.cn/bohXaCnp (optional) 

            try
            {
                // 小程序-发送订阅消息
                JObjectApiResult result = apiInstance.WechatSubscribeSend(appKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatSubscribeSend: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatSubscribeSendWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 小程序-发送订阅消息
    ApiResponse<JObjectApiResult> response = apiInstance.WechatSubscribeSendWithHttpInfo(appKey, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatSubscribeSendWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **body** | **Object** | 开发参考：https://dwz.cn/bohXaCnp | [optional]  |

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

<a id="wechaturllinkgenerate"></a>
# **WechatUrlLinkGenerate**
> JObjectApiResult WechatUrlLinkGenerate (string appKey, Object body = null)

小程序-生成网页跳转地址(获取小程序 URL Link，适用于短信、邮件、网页、微信内等拉起小程序的业务场景)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatUrlLinkGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var body = null;  // Object | 开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/url-link/urllink.generate.html (optional) 

            try
            {
                // 小程序-生成网页跳转地址(获取小程序 URL Link，适用于短信、邮件、网页、微信内等拉起小程序的业务场景)
                JObjectApiResult result = apiInstance.WechatUrlLinkGenerate(appKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatUrlLinkGenerate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatUrlLinkGenerateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 小程序-生成网页跳转地址(获取小程序 URL Link，适用于短信、邮件、网页、微信内等拉起小程序的业务场景)
    ApiResponse<JObjectApiResult> response = apiInstance.WechatUrlLinkGenerateWithHttpInfo(appKey, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatUrlLinkGenerateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **body** | **Object** | 开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/url-link/urllink.generate.html | [optional]  |

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

<a id="wechatuserinfo"></a>
# **WechatUserInfo**
> JObjectApiResult WechatUserInfo (string appKey, string openid = null)

公众号H5-获取用户UnionID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var openid = "openid_example";  // string |  (optional) 

            try
            {
                // 公众号H5-获取用户UnionID
                JObjectApiResult result = apiInstance.WechatUserInfo(appKey, openid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatUserInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatUserInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 公众号H5-获取用户UnionID
    ApiResponse<JObjectApiResult> response = apiInstance.WechatUserInfoWithHttpInfo(appKey, openid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatUserInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **openid** | **string** |  | [optional]  |

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

<a id="wechatwxacodeget"></a>
# **WechatWXACodeGet**
> JObjectApiResult WechatWXACodeGet (string appKey, Object body = null)

小程序-获取小程序码

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatWXACodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var body = null;  // Object | 开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.get.html (optional) 

            try
            {
                // 小程序-获取小程序码
                JObjectApiResult result = apiInstance.WechatWXACodeGet(appKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatWXACodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatWXACodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 小程序-获取小程序码
    ApiResponse<JObjectApiResult> response = apiInstance.WechatWXACodeGetWithHttpInfo(appKey, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatWXACodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **body** | **Object** | 开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.get.html | [optional]  |

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

<a id="wechatwxacodegetunlimited"></a>
# **WechatWXACodeGetUnlimited**
> JObjectApiResult WechatWXACodeGetUnlimited (string appKey, Object body = null)

小程序-获取小程序码(无限制)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatWXACodeGetUnlimitedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var body = null;  // Object | 开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.getUnlimited.html (optional) 

            try
            {
                // 小程序-获取小程序码(无限制)
                JObjectApiResult result = apiInstance.WechatWXACodeGetUnlimited(appKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatWXACodeGetUnlimited: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatWXACodeGetUnlimitedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 小程序-获取小程序码(无限制)
    ApiResponse<JObjectApiResult> response = apiInstance.WechatWXACodeGetUnlimitedWithHttpInfo(appKey, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatWXACodeGetUnlimitedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **body** | **Object** | 开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.getUnlimited.html | [optional]  |

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

