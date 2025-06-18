# ZSGF.Client.Api.StorageApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StorageAggregate**](StorageApi.md#storageaggregate) | **GET** /Storage/{appKey}/{table}/Aggregate | 聚合查询 |
| [**StorageDelete**](StorageApi.md#storagedelete) | **DELETE** /Storage/{appKey}/{table}/{id} | 删除数据 |
| [**StorageDetail**](StorageApi.md#storagedetail) | **GET** /Storage/{appKey}/{table}/{id} | 数据详情 |
| [**StorageList**](StorageApi.md#storagelist) | **GET** /Storage/{appKey}/{table} | 查询数据 |
| [**StoragePost**](StorageApi.md#storagepost) | **POST** /Storage/{appKey}/{table} | 添加数据 |
| [**StoragePut**](StorageApi.md#storageput) | **PUT** /Storage/{appKey}/{table}/{id} | 更新数据 |

<a id="storageaggregate"></a>
# **StorageAggregate**
> ObjectListApiResponse StorageAggregate (string table, string appKey, string pipeline = null)

聚合查询

根据聚合管道查询指定表中的数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageAggregateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var appKey = "appKey_example";  // string | 
            var pipeline = "pipeline_example";  // string | 构建聚合查询 (optional) 

            try
            {
                // 聚合查询
                ObjectListApiResponse result = apiInstance.StorageAggregate(table, appKey, pipeline);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageAggregate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageAggregateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 聚合查询
    ApiResponse<ObjectListApiResponse> response = apiInstance.StorageAggregateWithHttpInfo(table, appKey, pipeline);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageAggregateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **appKey** | **string** |  |  |
| **pipeline** | **string** | 构建聚合查询 | [optional]  |

### Return type

[**ObjectListApiResponse**](ObjectListApiResponse.md)

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

<a id="storagedelete"></a>
# **StorageDelete**
> BooleanApiResponse StorageDelete (string table, string id, string appKey)

删除数据

删除指定表中指定ID的数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var id = "id_example";  // string | 数据ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除数据
                BooleanApiResponse result = apiInstance.StorageDelete(table, id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除数据
    ApiResponse<BooleanApiResponse> response = apiInstance.StorageDeleteWithHttpInfo(table, id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **id** | **string** | 数据ID |  |
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

<a id="storagedetail"></a>
# **StorageDetail**
> ObjectApiResponse StorageDetail (string table, string id, string appKey, string project = null)

数据详情

获取指定表中指定ID的数据详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var id = "id_example";  // string | 数据ID
            var appKey = "appKey_example";  // string | 
            var project = "project_example";  // string | json格式 (optional) 

            try
            {
                // 数据详情
                ObjectApiResponse result = apiInstance.StorageDetail(table, id, appKey, project);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 数据详情
    ApiResponse<ObjectApiResponse> response = apiInstance.StorageDetailWithHttpInfo(table, id, appKey, project);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **id** | **string** | 数据ID |  |
| **appKey** | **string** |  |  |
| **project** | **string** | json格式 | [optional]  |

### Return type

[**ObjectApiResponse**](ObjectApiResponse.md)

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

<a id="storagelist"></a>
# **StorageList**
> StorageListResultApiResponse StorageList (string table, string appKey, string filter = null, string project = null, string sort = null, DateTime startTime = null, DateTime endTime = null, bool explain = null, int take = null, int skip = null)

查询数据

根据条件查询指定表中的数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var appKey = "appKey_example";  // string | 
            var filter = "filter_example";  // string | 过滤，json格式 (optional) 
            var project = "project_example";  // string | 字段映射，json格式 (optional) 
            var sort = "sort_example";  // string | 排序，json格式 (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 开始时间 (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 结束时间 (optional) 
            var explain = false;  // bool | 查看执行计划 (optional)  (default to false)
            var take = 10;  // int | 默认为10 (optional)  (default to 10)
            var skip = 0;  // int | 默认为0 (optional)  (default to 0)

            try
            {
                // 查询数据
                StorageListResultApiResponse result = apiInstance.StorageList(table, appKey, filter, project, sort, startTime, endTime, explain, take, skip);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 查询数据
    ApiResponse<StorageListResultApiResponse> response = apiInstance.StorageListWithHttpInfo(table, appKey, filter, project, sort, startTime, endTime, explain, take, skip);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **appKey** | **string** |  |  |
| **filter** | **string** | 过滤，json格式 | [optional]  |
| **project** | **string** | 字段映射，json格式 | [optional]  |
| **sort** | **string** | 排序，json格式 | [optional]  |
| **startTime** | **DateTime** | 开始时间 | [optional]  |
| **endTime** | **DateTime** | 结束时间 | [optional]  |
| **explain** | **bool** | 查看执行计划 | [optional] [default to false] |
| **take** | **int** | 默认为10 | [optional] [default to 10] |
| **skip** | **int** | 默认为0 | [optional] [default to 0] |

### Return type

[**StorageListResultApiResponse**](StorageListResultApiResponse.md)

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

<a id="storagepost"></a>
# **StoragePost**
> StringApiResponse StoragePost (string table, string appKey, List<Object> requestBody)

添加数据

向指定表中添加数据，可以是单个json对象或json数组

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StoragePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称（小写字母加数字,1-50位）
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | json对象 / json数组

            try
            {
                // 添加数据
                StringApiResponse result = apiInstance.StoragePost(table, appKey, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StoragePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StoragePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加数据
    ApiResponse<StringApiResponse> response = apiInstance.StoragePostWithHttpInfo(table, appKey, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StoragePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称（小写字母加数字,1-50位） |  |
| **appKey** | **string** |  |  |
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | json对象 / json数组 |  |

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

<a id="storageput"></a>
# **StoragePut**
> BooleanApiResponse StoragePut (string table, string id, string appKey, List<Object> requestBody, bool replace = null)

更新数据

更新指定表中指定ID的数据，可以选择全量更新或部分更新

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StoragePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var id = "id_example";  // string | 数据ID
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | json格式
            var replace = false;  // bool | 是否为全量更新，默认为false (optional)  (default to false)

            try
            {
                // 更新数据
                BooleanApiResponse result = apiInstance.StoragePut(table, id, appKey, requestBody, replace);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StoragePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StoragePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新数据
    ApiResponse<BooleanApiResponse> response = apiInstance.StoragePutWithHttpInfo(table, id, appKey, requestBody, replace);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StoragePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **id** | **string** | 数据ID |  |
| **appKey** | **string** |  |  |
| **requestBody** | [**List&lt;Object&gt;**](Object.md) | json格式 |  |
| **replace** | **bool** | 是否为全量更新，默认为false | [optional] [default to false] |

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

