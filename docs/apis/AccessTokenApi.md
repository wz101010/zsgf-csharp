# ZSGF.Client.Api.AccessTokenApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccessTokenDelete**](AccessTokenApi.md#accesstokendelete) | **DELETE** /AccessToken/{appKey}/{id} | 删除令牌 |
| [**AccessTokenPost**](AccessTokenApi.md#accesstokenpost) | **POST** /AccessToken/{appKey} | 创建令牌 |
| [**AccessTokenPut**](AccessTokenApi.md#accesstokenput) | **PUT** /AccessToken/{appKey}/{id} | 更新令牌 |
| [**AccessTokens**](AccessTokenApi.md#accesstokens) | **GET** /AccessToken/{appKey} | 令牌列表 |

<a id="accesstokendelete"></a>
# **AccessTokenDelete**
> BooleanApiResponse AccessTokenDelete (long id, string appKey, string userId = null)

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessTokenApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var userId = "userId_example";  // string |  (optional) 

            try
            {
                // 删除令牌
                BooleanApiResponse result = apiInstance.AccessTokenDelete(id, appKey, userId);
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
    ApiResponse<BooleanApiResponse> response = apiInstance.AccessTokenDeleteWithHttpInfo(id, appKey, userId);
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
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional]  |

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
> TokenModelApiResponse AccessTokenPost (string appKey, string userId = null, AccessTokenPostRequest accessTokenPostRequest = null)

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessTokenApi(config);
            var appKey = "appKey_example";  // string | 
            var userId = "userId_example";  // string |  (optional) 
            var accessTokenPostRequest = new AccessTokenPostRequest(); // AccessTokenPostRequest |  (optional) 

            try
            {
                // 创建令牌
                TokenModelApiResponse result = apiInstance.AccessTokenPost(appKey, userId, accessTokenPostRequest);
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
    ApiResponse<TokenModelApiResponse> response = apiInstance.AccessTokenPostWithHttpInfo(appKey, userId, accessTokenPostRequest);
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
| **userId** | **string** |  | [optional]  |
| **accessTokenPostRequest** | [**AccessTokenPostRequest**](AccessTokenPostRequest.md) |  | [optional]  |

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
> BooleanApiResponse AccessTokenPut (long id, string appKey, string userId = null, AccessTokenPutRequest accessTokenPutRequest = null)

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessTokenApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var userId = "userId_example";  // string |  (optional) 
            var accessTokenPutRequest = new AccessTokenPutRequest(); // AccessTokenPutRequest |  (optional) 

            try
            {
                // 更新令牌
                BooleanApiResponse result = apiInstance.AccessTokenPut(id, appKey, userId, accessTokenPutRequest);
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
    ApiResponse<BooleanApiResponse> response = apiInstance.AccessTokenPutWithHttpInfo(id, appKey, userId, accessTokenPutRequest);
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
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional]  |
| **accessTokenPutRequest** | [**AccessTokenPutRequest**](AccessTokenPutRequest.md) |  | [optional]  |

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
> AccessTokenListResultApiResponse AccessTokens (string appKey, int skip = null, int take = null, string userId = null)

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccessTokenApi(config);
            var appKey = "appKey_example";  // string | 
            var skip = 56;  // int |  (optional) 
            var take = 56;  // int |  (optional) 
            var userId = "userId_example";  // string |  (optional) 

            try
            {
                // 令牌列表
                AccessTokenListResultApiResponse result = apiInstance.AccessTokens(appKey, skip, take, userId);
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
    ApiResponse<AccessTokenListResultApiResponse> response = apiInstance.AccessTokensWithHttpInfo(appKey, skip, take, userId);
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
| **skip** | **int** |  | [optional]  |
| **take** | **int** |  | [optional]  |
| **userId** | **string** |  | [optional]  |

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

