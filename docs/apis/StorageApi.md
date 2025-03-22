# ZSGF.Client.Api.StorageApi

All URIs are relative to *https://api-staging.paomo.fun*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**StorageAggregate**](StorageApi.md#storageaggregate) | **GET** /Storage/{appKey}/{table}/Aggregate | 聚合查询 |
| [**StorageClear**](StorageApi.md#storageclear) | **DELETE** /Storage/{appKey}/{table}/Clear | 清空表数据 |
| [**StorageDelete**](StorageApi.md#storagedelete) | **DELETE** /Storage/{appKey}/{table}/{id} | 删除数据 |
| [**StorageDeleteIndex**](StorageApi.md#storagedeleteindex) | **DELETE** /Storage/{appKey}/{table}/indexes | 删除索引 |
| [**StorageDetail**](StorageApi.md#storagedetail) | **GET** /Storage/{appKey}/{table}/{id} | 数据详情 |
| [**StorageExecuteFunction**](StorageApi.md#storageexecutefunction) | **GET** /Storage/{appKey}/ExecuteFunction | 执行函数 |
| [**StorageExport**](StorageApi.md#storageexport) | **GET** /Storage/{appKey}/{table}/Export | 导出数据 |
| [**StorageImport**](StorageApi.md#storageimport) | **POST** /Storage/{appKey}/{table}/Import | 导入数据 |
| [**StorageIndexes**](StorageApi.md#storageindexes) | **GET** /Storage/{appKey}/{table}/Indexes | 获取索引 |
| [**StorageList**](StorageApi.md#storagelist) | **GET** /Storage/{appKey}/{table} | 查询数据 |
| [**StoragePost**](StorageApi.md#storagepost) | **POST** /Storage/{appKey}/{table} | 添加数据 |
| [**StoragePostIndex**](StorageApi.md#storagepostindex) | **POST** /Storage/{appKey}/{table}/indexes | 添加索引 |
| [**StoragePut**](StorageApi.md#storageput) | **PUT** /Storage/{appKey}/{table}/{id} | 更新数据 |
| [**StorageRemove**](StorageApi.md#storageremove) | **DELETE** /Storage/{appKey}/{table}/Remove | 删除表 |
| [**StorageStats**](StorageApi.md#storagestats) | **GET** /Storage/{appKey}/{table}/Stats | 数据表统计 |
| [**StorageTables**](StorageApi.md#storagetables) | **GET** /Storage/{appKey}/Tables | 获取数据表 |

<a id="storageaggregate"></a>
# **StorageAggregate**
> JObjectApiResult StorageAggregate (string table, string appKey, string pipeline = null)

聚合查询

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var appKey = "appKey_example";  // string | 
            var pipeline = "pipeline_example";  // string | 构建聚合查询 (optional) 

            try
            {
                // 聚合查询
                JObjectApiResult result = apiInstance.StorageAggregate(table, appKey, pipeline);
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
    ApiResponse<JObjectApiResult> response = apiInstance.StorageAggregateWithHttpInfo(table, appKey, pipeline);
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

<a id="storageclear"></a>
# **StorageClear**
> JObjectApiResult StorageClear (string table, string appKey, string filter = null)

清空表数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageClearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var appKey = "appKey_example";  // string | 
            var filter = "filter_example";  // string | 筛选条件 (optional) 

            try
            {
                // 清空表数据
                JObjectApiResult result = apiInstance.StorageClear(table, appKey, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageClear: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageClearWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 清空表数据
    ApiResponse<JObjectApiResult> response = apiInstance.StorageClearWithHttpInfo(table, appKey, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageClearWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **appKey** | **string** |  |  |
| **filter** | **string** | 筛选条件 | [optional]  |

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

<a id="storagedelete"></a>
# **StorageDelete**
> JObjectApiResult StorageDelete (string table, string id, string appKey)

删除数据

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var id = "id_example";  // string | 数据ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除数据
                JObjectApiResult result = apiInstance.StorageDelete(table, id, appKey);
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
    ApiResponse<JObjectApiResult> response = apiInstance.StorageDeleteWithHttpInfo(table, id, appKey);
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

<a id="storagedeleteindex"></a>
# **StorageDeleteIndex**
> JObjectApiResult StorageDeleteIndex (string table, string appKey, string indexName = null)

删除索引

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageDeleteIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var appKey = "appKey_example";  // string | 
            var indexName = "indexName_example";  // string | 索引名称 (optional) 

            try
            {
                // 删除索引
                JObjectApiResult result = apiInstance.StorageDeleteIndex(table, appKey, indexName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageDeleteIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageDeleteIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除索引
    ApiResponse<JObjectApiResult> response = apiInstance.StorageDeleteIndexWithHttpInfo(table, appKey, indexName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageDeleteIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **appKey** | **string** |  |  |
| **indexName** | **string** | 索引名称 | [optional]  |

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

<a id="storagedetail"></a>
# **StorageDetail**
> JObjectApiResult StorageDetail (string table, string id, string appKey, string project = null)

数据详情

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
            config.BasePath = "https://api-staging.paomo.fun";
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
                JObjectApiResult result = apiInstance.StorageDetail(table, id, appKey, project);
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
    ApiResponse<JObjectApiResult> response = apiInstance.StorageDetailWithHttpInfo(table, id, appKey, project);
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

<a id="storageexecutefunction"></a>
# **StorageExecuteFunction**
> JObjectApiResult StorageExecuteFunction (string nonce, long timestamp, string signature, string appKey, ExecuteFunctionRequest executeFunctionRequest = null)

执行函数

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageExecuteFunctionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var nonce = "nonce_example";  // string | 
            var timestamp = 789L;  // long | 
            var signature = "signature_example";  // string | 
            var appKey = "appKey_example";  // string | 
            var executeFunctionRequest = new ExecuteFunctionRequest(); // ExecuteFunctionRequest |  (optional) 

            try
            {
                // 执行函数
                JObjectApiResult result = apiInstance.StorageExecuteFunction(nonce, timestamp, signature, appKey, executeFunctionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageExecuteFunction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageExecuteFunctionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 执行函数
    ApiResponse<JObjectApiResult> response = apiInstance.StorageExecuteFunctionWithHttpInfo(nonce, timestamp, signature, appKey, executeFunctionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageExecuteFunctionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nonce** | **string** |  |  |
| **timestamp** | **long** |  |  |
| **signature** | **string** |  |  |
| **appKey** | **string** |  |  |
| **executeFunctionRequest** | [**ExecuteFunctionRequest**](ExecuteFunctionRequest.md) |  | [optional]  |

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

<a id="storageexport"></a>
# **StorageExport**
> System.IO.Stream StorageExport (string table, string appKey, string filter = null, DateTime startTime = null, DateTime endTime = null)

导出数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 
            var appKey = "appKey_example";  // string | 
            var filter = "filter_example";  // string |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime |  (optional) 

            try
            {
                // 导出数据
                System.IO.Stream result = apiInstance.StorageExport(table, appKey, filter, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 导出数据
    ApiResponse<System.IO.Stream> response = apiInstance.StorageExportWithHttpInfo(table, appKey, filter, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** |  |  |
| **appKey** | **string** |  |  |
| **filter** | **string** |  | [optional]  |
| **startTime** | **DateTime** |  | [optional]  |
| **endTime** | **DateTime** |  | [optional]  |

### Return type

**System.IO.Stream**

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

<a id="storageimport"></a>
# **StorageImport**
> JObjectApiResult StorageImport (string table, string appKey, System.IO.Stream file = null)

导入数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var appKey = "appKey_example";  // string | 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 导入的文件 (optional) 

            try
            {
                // 导入数据
                JObjectApiResult result = apiInstance.StorageImport(table, appKey, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageImport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageImportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 导入数据
    ApiResponse<JObjectApiResult> response = apiInstance.StorageImportWithHttpInfo(table, appKey, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageImportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **appKey** | **string** |  |  |
| **file** | **System.IO.Stream****System.IO.Stream** | 导入的文件 | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="storageindexes"></a>
# **StorageIndexes**
> JObjectApiResult StorageIndexes (string table, string appKey)

获取索引

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageIndexesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取索引
                JObjectApiResult result = apiInstance.StorageIndexes(table, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageIndexes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageIndexesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取索引
    ApiResponse<JObjectApiResult> response = apiInstance.StorageIndexesWithHttpInfo(table, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageIndexesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** |  |  |
| **appKey** | **string** |  |  |

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

<a id="storagelist"></a>
# **StorageList**
> JObjectApiResult StorageList (string table, string appKey, string filter = null, string project = null, string sort = null, DateTime startTime = null, DateTime endTime = null, bool explain = null, int take = null, int skip = null)

查询数据

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
            config.BasePath = "https://api-staging.paomo.fun";
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
                JObjectApiResult result = apiInstance.StorageList(table, appKey, filter, project, sort, startTime, endTime, explain, take, skip);
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
    ApiResponse<JObjectApiResult> response = apiInstance.StorageListWithHttpInfo(table, appKey, filter, project, sort, startTime, endTime, explain, take, skip);
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

<a id="storagepost"></a>
# **StoragePost**
> JObjectApiResult StoragePost (string table, string appKey, List<Object> requestBody)

添加数据

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称（小写字母加数字,1-50位）
            var appKey = "appKey_example";  // string | 
            var requestBody = new List<Object>(); // List<Object> | json对象 / json数组

            try
            {
                // 添加数据
                JObjectApiResult result = apiInstance.StoragePost(table, appKey, requestBody);
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
    ApiResponse<JObjectApiResult> response = apiInstance.StoragePostWithHttpInfo(table, appKey, requestBody);
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

<a id="storagepostindex"></a>
# **StoragePostIndex**
> JObjectApiResult StoragePostIndex (string table, string appKey, PostIndexRequest postIndexRequest = null)

添加索引

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StoragePostIndexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称（小写字母加数字,1-50位）
            var appKey = "appKey_example";  // string | 
            var postIndexRequest = new PostIndexRequest(); // PostIndexRequest | json对象 / json数组 (optional) 

            try
            {
                // 添加索引
                JObjectApiResult result = apiInstance.StoragePostIndex(table, appKey, postIndexRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StoragePostIndex: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StoragePostIndexWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加索引
    ApiResponse<JObjectApiResult> response = apiInstance.StoragePostIndexWithHttpInfo(table, appKey, postIndexRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StoragePostIndexWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称（小写字母加数字,1-50位） |  |
| **appKey** | **string** |  |  |
| **postIndexRequest** | [**PostIndexRequest**](PostIndexRequest.md) | json对象 / json数组 | [optional]  |

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

<a id="storageput"></a>
# **StoragePut**
> JObjectApiResult StoragePut (string table, string id, string appKey, Object body, bool replace = null)

更新数据

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var id = "id_example";  // string | 数据ID
            var appKey = "appKey_example";  // string | 
            var body = null;  // Object | json格式
            var replace = false;  // bool | 是否为全量更新，默认为false (optional)  (default to false)

            try
            {
                // 更新数据
                JObjectApiResult result = apiInstance.StoragePut(table, id, appKey, body, replace);
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
    ApiResponse<JObjectApiResult> response = apiInstance.StoragePutWithHttpInfo(table, id, appKey, body, replace);
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
| **body** | **Object** | json格式 |  |
| **replace** | **bool** | 是否为全量更新，默认为false | [optional] [default to false] |

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

<a id="storageremove"></a>
# **StorageRemove**
> JObjectApiResult StorageRemove (string table, string appKey)

删除表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageRemoveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除表
                JObjectApiResult result = apiInstance.StorageRemove(table, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageRemove: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageRemoveWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除表
    ApiResponse<JObjectApiResult> response = apiInstance.StorageRemoveWithHttpInfo(table, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageRemoveWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **appKey** | **string** |  |  |

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

<a id="storagestats"></a>
# **StorageStats**
> JObjectApiResult StorageStats (string table, string appKey)

数据表统计

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageStatsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var table = "table_example";  // string | 表名称
            var appKey = "appKey_example";  // string | 

            try
            {
                // 数据表统计
                JObjectApiResult result = apiInstance.StorageStats(table, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageStats: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageStatsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 数据表统计
    ApiResponse<JObjectApiResult> response = apiInstance.StorageStatsWithHttpInfo(table, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageStatsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **table** | **string** | 表名称 |  |
| **appKey** | **string** |  |  |

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

<a id="storagetables"></a>
# **StorageTables**
> JObjectApiResult StorageTables (string appKey)

获取数据表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class StorageTablesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new StorageApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取数据表
                JObjectApiResult result = apiInstance.StorageTables(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StorageApi.StorageTables: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StorageTablesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取数据表
    ApiResponse<JObjectApiResult> response = apiInstance.StorageTablesWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StorageApi.StorageTablesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

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

