# ZSGF.Client.Api.WechatApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ConfirmQRCodeLogin**](WechatApi.md#confirmqrcodelogin) | **POST** /Wechat/{appKey}/QR-Auth/Confirm-Login | 确认二维码登录请求 |
| [**ConfirmQRCodeRegistration**](WechatApi.md#confirmqrcoderegistration) | **POST** /Wechat/{appKey}/QR-Auth/Confirm-Register | 确认二维码注册请求 |
| [**InitiateQRAuthSession**](WechatApi.md#initiateqrauthsession) | **POST** /Wechat/{appKey}/QR-Auth/Initiate | 初始化二维码认证会话 |
| [**ScanQRCodeForAuth**](WechatApi.md#scanqrcodeforauth) | **POST** /Wechat/{appKey}/QR-Auth/Scan | 验证二维码扫描结果 |
| [**WechatDecrypt**](WechatApi.md#wechatdecrypt) | **GET** /Wechat/{appKey}/Decrypt | 解密小程序用户数据 |
| [**WechatGenerateScheme**](WechatApi.md#wechatgeneratescheme) | **POST** /Wechat/{appKey}/GenerateScheme | 生成小程序Scheme码 |
| [**WechatJSCode2Session**](WechatApi.md#wechatjscode2session) | **GET** /Wechat/{appKey}/JSCode2Session | 校验小程序登录状态 |
| [**WechatJSConfig**](WechatApi.md#wechatjsconfig) | **GET** /Wechat/{appKey}/JSConfig | 配置公众号JS SDK |
| [**WechatMsgSecCheck**](WechatApi.md#wechatmsgseccheck) | **POST** /Wechat/{appKey}/MsgSecCheck | 小程序内容安全检测 |
| [**WechatSubscribeMSG**](WechatApi.md#wechatsubscribemsg) | **POST** /Wechat/{appKey}/SubscribeMSG | 发送公众号一次性订阅消息 |
| [**WechatSubscribeSend**](WechatApi.md#wechatsubscribesend) | **POST** /Wechat/{appKey}/SubscribeSend | 发送小程序订阅消息 |
| [**WechatUrlLinkGenerate**](WechatApi.md#wechaturllinkgenerate) | **POST** /Wechat/{appKey}/UrlLinkGenerate | 生成小程序URL跳转链接 |
| [**WechatUserInfo**](WechatApi.md#wechatuserinfo) | **GET** /Wechat/{appKey}/UserInfo | 获取公众号H5 UnionID |
| [**WechatWXACodeGet**](WechatApi.md#wechatwxacodeget) | **POST** /Wechat/{appKey}/WXACodeGet | 获取小程序码（普通） |
| [**WechatWXACodeGetUnlimited**](WechatApi.md#wechatwxacodegetunlimited) | **POST** /Wechat/{appKey}/WXACodeGetUnlimited | 获取小程序码（无限制） |

<a id="confirmqrcodelogin"></a>
# **ConfirmQRCodeLogin**
> TokenModelApiResponse ConfirmQRCodeLogin (string appKey, QRCodeSignInRequest qRCodeSignInRequest = null)

确认二维码登录请求

微信小程序用户确认二维码登录并获取访问令牌

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ConfirmQRCodeLoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var qRCodeSignInRequest = new QRCodeSignInRequest(); // QRCodeSignInRequest | 登录确认请求参数 (optional) 

            try
            {
                // 确认二维码登录请求
                TokenModelApiResponse result = apiInstance.ConfirmQRCodeLogin(appKey, qRCodeSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.ConfirmQRCodeLogin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfirmQRCodeLoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 确认二维码登录请求
    ApiResponse<TokenModelApiResponse> response = apiInstance.ConfirmQRCodeLoginWithHttpInfo(appKey, qRCodeSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.ConfirmQRCodeLoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **qRCodeSignInRequest** | [**QRCodeSignInRequest**](QRCodeSignInRequest.md) | 登录确认请求参数 | [optional]  |

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

<a id="confirmqrcoderegistration"></a>
# **ConfirmQRCodeRegistration**
> TokenModelApiResponse ConfirmQRCodeRegistration (string appKey, QRCodeSignUpRequest qRCodeSignUpRequest = null)

确认二维码注册请求

微信小程序用户通过二维码完成注册并获取访问令牌

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ConfirmQRCodeRegistrationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var qRCodeSignUpRequest = new QRCodeSignUpRequest(); // QRCodeSignUpRequest | 注册确认请求参数 (optional) 

            try
            {
                // 确认二维码注册请求
                TokenModelApiResponse result = apiInstance.ConfirmQRCodeRegistration(appKey, qRCodeSignUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.ConfirmQRCodeRegistration: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ConfirmQRCodeRegistrationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 确认二维码注册请求
    ApiResponse<TokenModelApiResponse> response = apiInstance.ConfirmQRCodeRegistrationWithHttpInfo(appKey, qRCodeSignUpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.ConfirmQRCodeRegistrationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **qRCodeSignUpRequest** | [**QRCodeSignUpRequest**](QRCodeSignUpRequest.md) | 注册确认请求参数 | [optional]  |

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

<a id="initiateqrauthsession"></a>
# **InitiateQRAuthSession**
> Int64ApiResponse InitiateQRAuthSession (string appKey, QRCodePreSignInRequest qRCodePreSignInRequest = null)

初始化二维码认证会话

创建用于微信小程序扫码登录/注册的认证会话

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class InitiateQRAuthSessionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var qRCodePreSignInRequest = new QRCodePreSignInRequest(); // QRCodePreSignInRequest | 认证会话初始化请求参数 (optional) 

            try
            {
                // 初始化二维码认证会话
                Int64ApiResponse result = apiInstance.InitiateQRAuthSession(appKey, qRCodePreSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.InitiateQRAuthSession: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the InitiateQRAuthSessionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 初始化二维码认证会话
    ApiResponse<Int64ApiResponse> response = apiInstance.InitiateQRAuthSessionWithHttpInfo(appKey, qRCodePreSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.InitiateQRAuthSessionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **qRCodePreSignInRequest** | [**QRCodePreSignInRequest**](QRCodePreSignInRequest.md) | 认证会话初始化请求参数 | [optional]  |

### Return type

[**Int64ApiResponse**](Int64ApiResponse.md)

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

<a id="scanqrcodeforauth"></a>
# **ScanQRCodeForAuth**
> UserQRCodeScanResultApiResponse ScanQRCodeForAuth (string appKey, QRCodeScanRequest qRCodeScanRequest = null)

验证二维码扫描结果

微信小程序扫描二维码并获取应用授权信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ScanQRCodeForAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var qRCodeScanRequest = new QRCodeScanRequest(); // QRCodeScanRequest | 二维码扫描请求参数 (optional) 

            try
            {
                // 验证二维码扫描结果
                UserQRCodeScanResultApiResponse result = apiInstance.ScanQRCodeForAuth(appKey, qRCodeScanRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.ScanQRCodeForAuth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScanQRCodeForAuthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 验证二维码扫描结果
    ApiResponse<UserQRCodeScanResultApiResponse> response = apiInstance.ScanQRCodeForAuthWithHttpInfo(appKey, qRCodeScanRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.ScanQRCodeForAuthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **qRCodeScanRequest** | [**QRCodeScanRequest**](QRCodeScanRequest.md) | 二维码扫描请求参数 | [optional]  |

### Return type

[**UserQRCodeScanResultApiResponse**](UserQRCodeScanResultApiResponse.md)

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

<a id="wechatdecrypt"></a>
# **WechatDecrypt**
> StringApiResponse WechatDecrypt (string appKey, string encryptedData = null, string iv = null, string sessionKey = null)

解密小程序用户数据

解密小程序加密数据

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var encryptedData = "encryptedData_example";  // string | 加密的数据 (optional) 
            var iv = "iv_example";  // string | 加密算法的初始向量 (optional) 
            var sessionKey = "sessionKey_example";  // string | 会话密钥 (optional) 

            try
            {
                // 解密小程序用户数据
                StringApiResponse result = apiInstance.WechatDecrypt(appKey, encryptedData, iv, sessionKey);
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
    // 解密小程序用户数据
    ApiResponse<StringApiResponse> response = apiInstance.WechatDecryptWithHttpInfo(appKey, encryptedData, iv, sessionKey);
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
| **iv** | **string** | 加密算法的初始向量 | [optional]  |
| **sessionKey** | **string** | 会话密钥 | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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
> StringApiResponse WechatGenerateScheme (string appKey, List<Object> requestBody = null)

生成小程序Scheme码

生成小程序的scheme码

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | scheme码数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/qrcode-link/url-scheme/generateScheme.html (optional) 

            try
            {
                // 生成小程序Scheme码
                StringApiResponse result = apiInstance.WechatGenerateScheme(appKey, requestBody);
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
    // 生成小程序Scheme码
    ApiResponse<StringApiResponse> response = apiInstance.WechatGenerateSchemeWithHttpInfo(appKey, requestBody);
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
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | scheme码数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/qrcode-link/url-scheme/generateScheme.html | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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
> StringApiResponse WechatJSCode2Session (string appKey, string jsCode = null)

校验小程序登录状态

校验小程序登录凭证

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var jsCode = "jsCode_example";  // string | 登录凭证，开发参考：https://dwz.cn/icNajFh7 (optional) 

            try
            {
                // 校验小程序登录状态
                StringApiResponse result = apiInstance.WechatJSCode2Session(appKey, jsCode);
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
    // 校验小程序登录状态
    ApiResponse<StringApiResponse> response = apiInstance.WechatJSCode2SessionWithHttpInfo(appKey, jsCode);
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
| **jsCode** | **string** | 登录凭证，开发参考：https://dwz.cn/icNajFh7 | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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
> WechatJSConfigResultApiResponse WechatJSConfig (string appKey, string url = null)

配置公众号JS SDK

获取公众号H5的JS SDK配置

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var url = "url_example";  // string | 当前网页的URL (optional) 

            try
            {
                // 配置公众号JS SDK
                WechatJSConfigResultApiResponse result = apiInstance.WechatJSConfig(appKey, url);
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
    // 配置公众号JS SDK
    ApiResponse<WechatJSConfigResultApiResponse> response = apiInstance.WechatJSConfigWithHttpInfo(appKey, url);
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
| **url** | **string** | 当前网页的URL | [optional]  |

### Return type

[**WechatJSConfigResultApiResponse**](WechatJSConfigResultApiResponse.md)

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

<a id="wechatmsgseccheck"></a>
# **WechatMsgSecCheck**
> Object WechatMsgSecCheck (string appKey, List<Object> requestBody = null)

小程序内容安全检测

检测消息内容是否含有违法违规信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class WechatMsgSecCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | 消息内容数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/sec-center/sec-check/msgSecCheck.html (optional) 

            try
            {
                // 小程序内容安全检测
                Object result = apiInstance.WechatMsgSecCheck(appKey, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WechatApi.WechatMsgSecCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WechatMsgSecCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 小程序内容安全检测
    ApiResponse<Object> response = apiInstance.WechatMsgSecCheckWithHttpInfo(appKey, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WechatApi.WechatMsgSecCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | 消息内容数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/OpenApiDoc/sec-center/sec-check/msgSecCheck.html | [optional]  |

### Return type

**Object**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="wechatsubscribemsg"></a>
# **WechatSubscribeMSG**
> StringApiResponse WechatSubscribeMSG (string appKey, List<Object> requestBody = null)

发送公众号一次性订阅消息

发送公众号H5一次性订阅消息

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | 订阅消息数据，开发参考：https://dwz.cn/IXptek5n (optional) 

            try
            {
                // 发送公众号一次性订阅消息
                StringApiResponse result = apiInstance.WechatSubscribeMSG(appKey, requestBody);
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
    // 发送公众号一次性订阅消息
    ApiResponse<StringApiResponse> response = apiInstance.WechatSubscribeMSGWithHttpInfo(appKey, requestBody);
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
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | 订阅消息数据，开发参考：https://dwz.cn/IXptek5n | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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
> StringApiResponse WechatSubscribeSend (string appKey, List<Object> requestBody = null)

发送小程序订阅消息

发送小程序订阅消息

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | 订阅消息数据，开发参考：https://dwz.cn/bohXaCnp (optional) 

            try
            {
                // 发送小程序订阅消息
                StringApiResponse result = apiInstance.WechatSubscribeSend(appKey, requestBody);
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
    // 发送小程序订阅消息
    ApiResponse<StringApiResponse> response = apiInstance.WechatSubscribeSendWithHttpInfo(appKey, requestBody);
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
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | 订阅消息数据，开发参考：https://dwz.cn/bohXaCnp | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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
> StringApiResponse WechatUrlLinkGenerate (string appKey, List<Object> requestBody = null)

生成小程序URL跳转链接

生成小程序的网页跳转地址

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | 跳转地址数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/url-link/urllink.generate.html (optional) 

            try
            {
                // 生成小程序URL跳转链接
                StringApiResponse result = apiInstance.WechatUrlLinkGenerate(appKey, requestBody);
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
    // 生成小程序URL跳转链接
    ApiResponse<StringApiResponse> response = apiInstance.WechatUrlLinkGenerateWithHttpInfo(appKey, requestBody);
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
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | 跳转地址数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/url-link/urllink.generate.html | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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
> StringApiResponse WechatUserInfo (string appKey, string openid = null)

获取公众号H5 UnionID

获取公众号H5用户的UnionID

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var openid = "openid_example";  // string | 用户的OpenID (optional) 

            try
            {
                // 获取公众号H5 UnionID
                StringApiResponse result = apiInstance.WechatUserInfo(appKey, openid);
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
    // 获取公众号H5 UnionID
    ApiResponse<StringApiResponse> response = apiInstance.WechatUserInfoWithHttpInfo(appKey, openid);
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
| **openid** | **string** | 用户的OpenID | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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
> System.IO.Stream WechatWXACodeGet (string appKey, List<Object> requestBody = null)

获取小程序码（普通）

获取小程序码

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | 小程序码数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.get.html (optional) 

            try
            {
                // 获取小程序码（普通）
                System.IO.Stream result = apiInstance.WechatWXACodeGet(appKey, requestBody);
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
    // 获取小程序码（普通）
    ApiResponse<System.IO.Stream> response = apiInstance.WechatWXACodeGetWithHttpInfo(appKey, requestBody);
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
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | 小程序码数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.get.html | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: image/jpeg


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="wechatwxacodegetunlimited"></a>
# **WechatWXACodeGetUnlimited**
> System.IO.Stream WechatWXACodeGetUnlimited (string appKey, List<Object> requestBody = null)

获取小程序码（无限制）

获取无限制的小程序码

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new WechatApi(config);
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | 小程序码数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.getUnlimited.html (optional) 

            try
            {
                // 获取小程序码（无限制）
                System.IO.Stream result = apiInstance.WechatWXACodeGetUnlimited(appKey, requestBody);
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
    // 获取小程序码（无限制）
    ApiResponse<System.IO.Stream> response = apiInstance.WechatWXACodeGetUnlimitedWithHttpInfo(appKey, requestBody);
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
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | 小程序码数据，开发参考：https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/qr-code/wxacode.getUnlimited.html | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: image/jpeg


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

