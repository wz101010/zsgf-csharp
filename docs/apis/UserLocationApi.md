# ZSGF.Client.Api.UserLocationApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserLocation**](UserLocationApi.md#userlocation) | **GET** /UserLocation/{appKey}/{id} | 获取位置详情 |
| [**UserLocationDelete**](UserLocationApi.md#userlocationdelete) | **DELETE** /UserLocation/{appKey}/{id} | 删除位置 |
| [**UserLocationPost**](UserLocationApi.md#userlocationpost) | **POST** /UserLocation/{appKey} | 添加位置 |
| [**UserLocationPut**](UserLocationApi.md#userlocationput) | **PUT** /UserLocation/{appKey}/{id} | 更新位置 |
| [**UserLocations**](UserLocationApi.md#userlocations) | **GET** /UserLocation/{appKey} | 获取位置列表 |

<a id="userlocation"></a>
# **UserLocation**
> GeoLocationModelApiResponse UserLocation (long id, string appKey, string userId = null)

获取位置详情

根据位置ID获取位置详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocationApi(config);
            var id = 789L;  // long | 位置ID
            var appKey = "appKey_example";  // string | 
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 获取位置详情
                GeoLocationModelApiResponse result = apiInstance.UserLocation(id, appKey, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocationApi.UserLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取位置详情
    ApiResponse<GeoLocationModelApiResponse> response = apiInstance.UserLocationWithHttpInfo(id, appKey, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocationApi.UserLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 位置ID |  |
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

[**GeoLocationModelApiResponse**](GeoLocationModelApiResponse.md)

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

<a id="userlocationdelete"></a>
# **UserLocationDelete**
> BooleanApiResponse UserLocationDelete (long id, string appKey, string userId = null)

删除位置

根据位置ID删除位置信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocationApi(config);
            var id = 789L;  // long | 位置ID
            var appKey = "appKey_example";  // string | 
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 删除位置
                BooleanApiResponse result = apiInstance.UserLocationDelete(id, appKey, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocationApi.UserLocationDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除位置
    ApiResponse<BooleanApiResponse> response = apiInstance.UserLocationDeleteWithHttpInfo(id, appKey, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocationApi.UserLocationDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 位置ID |  |
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

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

<a id="userlocationpost"></a>
# **UserLocationPost**
> UserLocationPostResultApiResponse UserLocationPost (string appKey, string userId = null, GeoLocationModel geoLocationModel = null)

添加位置

添加新的位置信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocationApi(config);
            var appKey = "appKey_example";  // string | 
            var userId = "\"\"";  // string |  (optional)  (default to "")
            var geoLocationModel = new GeoLocationModel(); // GeoLocationModel | 位置信息 (optional) 

            try
            {
                // 添加位置
                UserLocationPostResultApiResponse result = apiInstance.UserLocationPost(appKey, userId, geoLocationModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocationApi.UserLocationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加位置
    ApiResponse<UserLocationPostResultApiResponse> response = apiInstance.UserLocationPostWithHttpInfo(appKey, userId, geoLocationModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocationApi.UserLocationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |
| **geoLocationModel** | [**GeoLocationModel**](GeoLocationModel.md) | 位置信息 | [optional]  |

### Return type

[**UserLocationPostResultApiResponse**](UserLocationPostResultApiResponse.md)

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

<a id="userlocationput"></a>
# **UserLocationPut**
> BooleanApiResponse UserLocationPut (long id, string appKey, string userId = null, GeoLocationModel geoLocationModel = null)

更新位置

此方法用于更新指定位置ID的位置信息。如果位置不存在，则创建一个新的位置。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocationApi(config);
            var id = 789L;  // long | 位置ID
            var appKey = "appKey_example";  // string | 
            var userId = "\"\"";  // string |  (optional)  (default to "")
            var geoLocationModel = new GeoLocationModel(); // GeoLocationModel | 位置信息 (optional) 

            try
            {
                // 更新位置
                BooleanApiResponse result = apiInstance.UserLocationPut(id, appKey, userId, geoLocationModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocationApi.UserLocationPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新位置
    ApiResponse<BooleanApiResponse> response = apiInstance.UserLocationPutWithHttpInfo(id, appKey, userId, geoLocationModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocationApi.UserLocationPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 位置ID |  |
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |
| **geoLocationModel** | [**GeoLocationModel**](GeoLocationModel.md) | 位置信息 | [optional]  |

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

<a id="userlocations"></a>
# **UserLocations**
> UserLocationsResultApiResponse UserLocations (string appKey, string tag = null, string type = null, double x = null, double y = null, long sphere = null, int skip = null, int take = null, string userId = null)

获取位置列表

根据条件获取位置列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserLocationApi(config);
            var appKey = "appKey_example";  // string | 
            var tag = "tag_example";  // string | 标签 (optional) 
            var type = "type_example";  // string | 分类 (optional) 
            var x = 1.2D;  // double | 纬度 (optional) 
            var y = 1.2D;  // double | 经度 (optional) 
            var sphere = 789L;  // long | 附近距离，单位：米 (optional) 
            var skip = 56;  // int | 跳过的记录数 (optional) 
            var take = 10;  // int | 获取的记录数 (optional)  (default to 10)
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 获取位置列表
                UserLocationsResultApiResponse result = apiInstance.UserLocations(appKey, tag, type, x, y, sphere, skip, take, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserLocationApi.UserLocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取位置列表
    ApiResponse<UserLocationsResultApiResponse> response = apiInstance.UserLocationsWithHttpInfo(appKey, tag, type, x, y, sphere, skip, take, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserLocationApi.UserLocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **tag** | **string** | 标签 | [optional]  |
| **type** | **string** | 分类 | [optional]  |
| **x** | **double** | 纬度 | [optional]  |
| **y** | **double** | 经度 | [optional]  |
| **sphere** | **long** | 附近距离，单位：米 | [optional]  |
| **skip** | **int** | 跳过的记录数 | [optional]  |
| **take** | **int** | 获取的记录数 | [optional] [default to 10] |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

[**UserLocationsResultApiResponse**](UserLocationsResultApiResponse.md)

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

