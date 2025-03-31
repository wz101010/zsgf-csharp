# ZSGF.Client.Api.AuthorizePolicyApi

All URIs are relative to *https://api.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorizePolicies**](AuthorizePolicyApi.md#authorizepolicies) | **GET** /AuthorizePolicy/{appKey} | 获取鉴权策略列表 |
| [**AuthorizePolicy**](AuthorizePolicyApi.md#authorizepolicy) | **GET** /AuthorizePolicy/{appKey}/{id} | 获取鉴权策略详情 |
| [**AuthorizePolicyDelete**](AuthorizePolicyApi.md#authorizepolicydelete) | **DELETE** /AuthorizePolicy/{appKey}/{id} | 删除鉴权策略 |
| [**AuthorizePolicyPost**](AuthorizePolicyApi.md#authorizepolicypost) | **POST** /AuthorizePolicy/{appKey} | 添加鉴权策略 |
| [**AuthorizePolicyPut**](AuthorizePolicyApi.md#authorizepolicyput) | **PUT** /AuthorizePolicy/{appKey}/{id} | 更新鉴权策略 |

<a id="authorizepolicies"></a>
# **AuthorizePolicies**
> AuthorizePolicyListApiResponse AuthorizePolicies (string appKey, string authType = null, string policyName = null)

获取鉴权策略列表

根据鉴权类型和策略名称获取鉴权策略列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AuthorizePoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthorizePolicyApi(config);
            var appKey = "appKey_example";  // string | 
            var authType = "authType_example";  // string | 鉴权类型（access_token、user、role） (optional) 
            var policyName = "policyName_example";  // string | 策略名称 (optional) 

            try
            {
                // 获取鉴权策略列表
                AuthorizePolicyListApiResponse result = apiInstance.AuthorizePolicies(appKey, authType, policyName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizePoliciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取鉴权策略列表
    ApiResponse<AuthorizePolicyListApiResponse> response = apiInstance.AuthorizePoliciesWithHttpInfo(appKey, authType, policyName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePoliciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **authType** | **string** | 鉴权类型（access_token、user、role） | [optional]  |
| **policyName** | **string** | 策略名称 | [optional]  |

### Return type

[**AuthorizePolicyListApiResponse**](AuthorizePolicyListApiResponse.md)

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

<a id="authorizepolicy"></a>
# **AuthorizePolicy**
> AuthorizePolicyApiResponse AuthorizePolicy (long id, string appKey)

获取鉴权策略详情

根据鉴权策略ID获取鉴权策略详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AuthorizePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthorizePolicyApi(config);
            var id = 789L;  // long | 鉴权策略ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取鉴权策略详情
                AuthorizePolicyApiResponse result = apiInstance.AuthorizePolicy(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizePolicyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取鉴权策略详情
    ApiResponse<AuthorizePolicyApiResponse> response = apiInstance.AuthorizePolicyWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 鉴权策略ID |  |
| **appKey** | **string** |  |  |

### Return type

[**AuthorizePolicyApiResponse**](AuthorizePolicyApiResponse.md)

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

<a id="authorizepolicydelete"></a>
# **AuthorizePolicyDelete**
> BooleanApiResponse AuthorizePolicyDelete (long id, string appKey)

删除鉴权策略

根据鉴权策略ID删除鉴权策略

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AuthorizePolicyDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthorizePolicyApi(config);
            var id = 789L;  // long | 鉴权策略ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除鉴权策略
                BooleanApiResponse result = apiInstance.AuthorizePolicyDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicyDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizePolicyDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除鉴权策略
    ApiResponse<BooleanApiResponse> response = apiInstance.AuthorizePolicyDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicyDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 鉴权策略ID |  |
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

<a id="authorizepolicypost"></a>
# **AuthorizePolicyPost**
> CreatePostResultApiResponse AuthorizePolicyPost (string appKey, AuthorizePolicy authorizePolicy = null)

添加鉴权策略

添加新的鉴权策略

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AuthorizePolicyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthorizePolicyApi(config);
            var appKey = "appKey_example";  // string | 
            var authorizePolicy = new AuthorizePolicy(); // AuthorizePolicy | 鉴权策略对象 (optional) 

            try
            {
                // 添加鉴权策略
                CreatePostResultApiResponse result = apiInstance.AuthorizePolicyPost(appKey, authorizePolicy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizePolicyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加鉴权策略
    ApiResponse<CreatePostResultApiResponse> response = apiInstance.AuthorizePolicyPostWithHttpInfo(appKey, authorizePolicy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **authorizePolicy** | [**AuthorizePolicy**](AuthorizePolicy.md) | 鉴权策略对象 | [optional]  |

### Return type

[**CreatePostResultApiResponse**](CreatePostResultApiResponse.md)

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

<a id="authorizepolicyput"></a>
# **AuthorizePolicyPut**
> BooleanApiResponse AuthorizePolicyPut (long id, string appKey, AuthorizePolicy authorizePolicy = null)

更新鉴权策略

根据鉴权策略ID更新鉴权策略

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AuthorizePolicyPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AuthorizePolicyApi(config);
            var id = 789L;  // long | 鉴权策略ID
            var appKey = "appKey_example";  // string | 
            var authorizePolicy = new AuthorizePolicy(); // AuthorizePolicy | 鉴权策略对象 (optional) 

            try
            {
                // 更新鉴权策略
                BooleanApiResponse result = apiInstance.AuthorizePolicyPut(id, appKey, authorizePolicy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizePolicyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新鉴权策略
    ApiResponse<BooleanApiResponse> response = apiInstance.AuthorizePolicyPutWithHttpInfo(id, appKey, authorizePolicy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizePolicyApi.AuthorizePolicyPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 鉴权策略ID |  |
| **appKey** | **string** |  |  |
| **authorizePolicy** | [**AuthorizePolicy**](AuthorizePolicy.md) | 鉴权策略对象 | [optional]  |

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

