# ZSGF.Client.Api.FileApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FileCreateFolder**](FileApi.md#filecreatefolder) | **POST** /File/{appKey}/CreateFolder | 创建文件夹 |
| [**FileDelete**](FileApi.md#filedelete) | **DELETE** /File/{appKey} | 删除文件 / 文件夹 |
| [**FileRename**](FileApi.md#filerename) | **POST** /File/{appKey}/Rename | 重命名文件 / 文件夹 |
| [**FileUpload**](FileApi.md#fileupload) | **POST** /File/{appKey}/Upload | 上传文件 |
| [**Files**](FileApi.md#files) | **GET** /File/{appKey} | 获取文件列表 |

<a id="filecreatefolder"></a>
# **FileCreateFolder**
> BooleanApiResponse FileCreateFolder (string appKey, string path = null)

创建文件夹

在指定路径创建文件夹

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class FileCreateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FileApi(config);
            var appKey = "appKey_example";  // string | 
            var path = "path_example";  // string | 文件夹路径 (optional) 

            try
            {
                // 创建文件夹
                BooleanApiResponse result = apiInstance.FileCreateFolder(appKey, path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileCreateFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileCreateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建文件夹
    ApiResponse<BooleanApiResponse> response = apiInstance.FileCreateFolderWithHttpInfo(appKey, path);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileCreateFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **path** | **string** | 文件夹路径 | [optional]  |

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

<a id="filedelete"></a>
# **FileDelete**
> BooleanApiResponse FileDelete (string appKey, string path = null)

删除文件 / 文件夹

根据指定路径删除文件或文件夹

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class FileDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FileApi(config);
            var appKey = "appKey_example";  // string | 
            var path = "path_example";  // string | 文件 / 文件夹路径 (optional) 

            try
            {
                // 删除文件 / 文件夹
                BooleanApiResponse result = apiInstance.FileDelete(appKey, path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除文件 / 文件夹
    ApiResponse<BooleanApiResponse> response = apiInstance.FileDeleteWithHttpInfo(appKey, path);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **path** | **string** | 文件 / 文件夹路径 | [optional]  |

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

<a id="filerename"></a>
# **FileRename**
> BooleanApiResponse FileRename (string appKey, string sourceName = null, string destName = null)

重命名文件 / 文件夹

将指定的文件或文件夹重命名

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class FileRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FileApi(config);
            var appKey = "appKey_example";  // string | 
            var sourceName = "sourceName_example";  // string | 原文件 / 文件夹名称 (optional) 
            var destName = "destName_example";  // string | 新文件 / 文件夹名称 (optional) 

            try
            {
                // 重命名文件 / 文件夹
                BooleanApiResponse result = apiInstance.FileRename(appKey, sourceName, destName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileRename: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileRenameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 重命名文件 / 文件夹
    ApiResponse<BooleanApiResponse> response = apiInstance.FileRenameWithHttpInfo(appKey, sourceName, destName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileRenameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **sourceName** | **string** | 原文件 / 文件夹名称 | [optional]  |
| **destName** | **string** | 新文件 / 文件夹名称 | [optional]  |

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

<a id="fileupload"></a>
# **FileUpload**
> StringApiResponse FileUpload (string appKey, string path = null, System.IO.Stream file = null)

上传文件

将文件上传到指定路径

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class FileUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FileApi(config);
            var appKey = "appKey_example";  // string | 
            var path = "path_example";  // string | 文件夹路径 (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 上传的文件 (optional) 

            try
            {
                // 上传文件
                StringApiResponse result = apiInstance.FileUpload(appKey, path, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.FileUpload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FileUploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 上传文件
    ApiResponse<StringApiResponse> response = apiInstance.FileUploadWithHttpInfo(appKey, path, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FileUploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **path** | **string** | 文件夹路径 | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** | 上传的文件 | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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

<a id="files"></a>
# **Files**
> FileListResultApiResponse Files (string appKey, string path = null, int skip = null, int take = null)

获取文件列表

根据指定路径获取文件和文件夹列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class FilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new FileApi(config);
            var appKey = "appKey_example";  // string | 
            var path = "path_example";  // string | 文件路径 (optional) 
            var skip = 0;  // int | 跳过的记录数 (optional)  (default to 0)
            var take = 100;  // int | 获取的记录数 (optional)  (default to 100)

            try
            {
                // 获取文件列表
                FileListResultApiResponse result = apiInstance.Files(appKey, path, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.Files: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取文件列表
    ApiResponse<FileListResultApiResponse> response = apiInstance.FilesWithHttpInfo(appKey, path, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.FilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **path** | **string** | 文件路径 | [optional]  |
| **skip** | **int** | 跳过的记录数 | [optional] [default to 0] |
| **take** | **int** | 获取的记录数 | [optional] [default to 100] |

### Return type

[**FileListResultApiResponse**](FileListResultApiResponse.md)

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

