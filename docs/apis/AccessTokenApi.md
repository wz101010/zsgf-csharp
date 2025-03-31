# ZSGF.Client.Api.AccessTokenApi

All URIs are relative to *https://api.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccessTokenDelete**](AccessTokenApi.md#accesstokendelete) | **DELETE** /AccessToken/{appKey}/{id} | 删除令牌 |
| [**AccessTokenPost**](AccessTokenApi.md#accesstokenpost) | **POST** /AccessToken/{appKey} | 创建令牌 |
| [**AccessTokenPut**](AccessTokenApi.md#accesstokenput) | **PUT** /AccessToken/{appKey}/{id} | 更新令牌 |
| [**AccessTokens**](AccessTokenApi.md#accesstokens) | **GET** /AccessToken/{appKey} | 令牌列表 |

<a id="accesstokendelete"></a>
# **AccessTokenDelete**
> BooleanApiResponse AccessTokenDelete (long id, string appKey)

删除令牌

删除用户令牌

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AccessTokenDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessTokenApi(config);
            var id = 789L;  // long | 令牌ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除令牌
                BooleanApiResponse result = apiInstance.AccessTokenDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessTokenApi.AccessTokenDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccessTokenDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除令牌
    ApiResponse<BooleanApiResponse> response = apiInstance.AccessTokenDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessTokenApi.AccessTokenDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 令牌ID |  |
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

<a id="accesstokenpost"></a>
# **AccessTokenPost**
> TokenModelApiResponse AccessTokenPost (string appKey, AccessTokenPostRequest accessTokenPostRequest = null)

创建令牌

创建新的用户令牌

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AccessTokenPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessTokenApi(config);
            var appKey = "appKey_example";  // string | 
            var accessTokenPostRequest = new AccessTokenPostRequest(); // AccessTokenPostRequest | 令牌创建请求参数 (optional) 

            try
            {
                // 创建令牌
                TokenModelApiResponse result = apiInstance.AccessTokenPost(appKey, accessTokenPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessTokenApi.AccessTokenPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccessTokenPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建令牌
    ApiResponse<TokenModelApiResponse> response = apiInstance.AccessTokenPostWithHttpInfo(appKey, accessTokenPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessTokenApi.AccessTokenPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **accessTokenPostRequest** | [**AccessTokenPostRequest**](AccessTokenPostRequest.md) | 令牌创建请求参数 | [optional]  |

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

<a id="accesstokenput"></a>
# **AccessTokenPut**
> BooleanApiResponse AccessTokenPut (long id, string appKey, AccessTokenPutRequest accessTokenPutRequest = null)

更新令牌

更新现有的用户令牌

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AccessTokenPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessTokenApi(config);
            var id = 789L;  // long | 令牌ID
            var appKey = "appKey_example";  // string | 
            var accessTokenPutRequest = new AccessTokenPutRequest(); // AccessTokenPutRequest | 令牌更新请求参数 (optional) 

            try
            {
                // 更新令牌
                BooleanApiResponse result = apiInstance.AccessTokenPut(id, appKey, accessTokenPutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessTokenApi.AccessTokenPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccessTokenPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新令牌
    ApiResponse<BooleanApiResponse> response = apiInstance.AccessTokenPutWithHttpInfo(id, appKey, accessTokenPutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessTokenApi.AccessTokenPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 令牌ID |  |
| **appKey** | **string** |  |  |
| **accessTokenPutRequest** | [**AccessTokenPutRequest**](AccessTokenPutRequest.md) | 令牌更新请求参数 | [optional]  |

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

<a id="accesstokens"></a>
# **AccessTokens**
> AccessTokenListResultApiResponse AccessTokens (string appKey, long userId = null, int skip = null, int take = null)

令牌列表

获取用户令牌列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AccessTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessTokenApi(config);
            var appKey = "appKey_example";  // string | 
            var userId = 789L;  // long | 用户ID (optional) 
            var skip = 56;  // int | 跳过的记录数 (optional) 
            var take = 56;  // int | 获取的记录数 (optional) 

            try
            {
                // 令牌列表
                AccessTokenListResultApiResponse result = apiInstance.AccessTokens(appKey, userId, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccessTokenApi.AccessTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccessTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 令牌列表
    ApiResponse<AccessTokenListResultApiResponse> response = apiInstance.AccessTokensWithHttpInfo(appKey, userId, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccessTokenApi.AccessTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **userId** | **long** | 用户ID | [optional]  |
| **skip** | **int** | 跳过的记录数 | [optional]  |
| **take** | **int** | 获取的记录数 | [optional]  |

### Return type

[**AccessTokenListResultApiResponse**](AccessTokenListResultApiResponse.md)

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

