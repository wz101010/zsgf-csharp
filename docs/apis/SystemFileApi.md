# ZSGF.Client.Api.SystemFileApi

All URIs are relative to *https://api.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SystemFileCreateFolder**](SystemFileApi.md#systemfilecreatefolder) | **POST** /SystemFile/CreateFolder | 创建文件夹 |
| [**SystemFileDelete**](SystemFileApi.md#systemfiledelete) | **DELETE** /SystemFile | 删除文件 |
| [**SystemFileRename**](SystemFileApi.md#systemfilerename) | **POST** /SystemFile/Rename | 重命名文件 |
| [**SystemFileUpload**](SystemFileApi.md#systemfileupload) | **POST** /SystemFile | 上传文件 |
| [**SystemFiles**](SystemFileApi.md#systemfiles) | **GET** /SystemFile | 获取文件列表 |

<a id="systemfilecreatefolder"></a>
# **SystemFileCreateFolder**
> BooleanApiResponse SystemFileCreateFolder (string path = null)

创建文件夹

根据指定路径创建文件夹

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class SystemFileCreateFolderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemFileApi(config);
            var path = "path_example";  // string | 文件夹路径 (optional) 

            try
            {
                // 创建文件夹
                BooleanApiResponse result = apiInstance.SystemFileCreateFolder(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemFileApi.SystemFileCreateFolder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemFileCreateFolderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建文件夹
    ApiResponse<BooleanApiResponse> response = apiInstance.SystemFileCreateFolderWithHttpInfo(path);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemFileApi.SystemFileCreateFolderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="systemfiledelete"></a>
# **SystemFileDelete**
> BooleanApiResponse SystemFileDelete (string path = null)

删除文件

根据指定路径删除文件

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class SystemFileDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemFileApi(config);
            var path = "path_example";  // string | 文件路径 (optional) 

            try
            {
                // 删除文件
                BooleanApiResponse result = apiInstance.SystemFileDelete(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemFileApi.SystemFileDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemFileDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除文件
    ApiResponse<BooleanApiResponse> response = apiInstance.SystemFileDeleteWithHttpInfo(path);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemFileApi.SystemFileDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | 文件路径 | [optional]  |

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

<a id="systemfilerename"></a>
# **SystemFileRename**
> BooleanApiResponse SystemFileRename (string sourceName = null, string destName = null)

重命名文件

根据指定的源文件名和目标文件名重命名文件

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class SystemFileRenameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemFileApi(config);
            var sourceName = "sourceName_example";  // string | 源文件名 (optional) 
            var destName = "destName_example";  // string | 目标文件名 (optional) 

            try
            {
                // 重命名文件
                BooleanApiResponse result = apiInstance.SystemFileRename(sourceName, destName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemFileApi.SystemFileRename: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemFileRenameWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 重命名文件
    ApiResponse<BooleanApiResponse> response = apiInstance.SystemFileRenameWithHttpInfo(sourceName, destName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemFileApi.SystemFileRenameWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sourceName** | **string** | 源文件名 | [optional]  |
| **destName** | **string** | 目标文件名 | [optional]  |

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

<a id="systemfileupload"></a>
# **SystemFileUpload**
> StringApiResponse SystemFileUpload (string path = null, System.IO.Stream file = null)

上传文件

根据指定路径上传文件

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class SystemFileUploadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemFileApi(config);
            var path = "path_example";  // string | 上传的路径 (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 上传的文件 (optional) 

            try
            {
                // 上传文件
                StringApiResponse result = apiInstance.SystemFileUpload(path, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemFileApi.SystemFileUpload: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemFileUploadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 上传文件
    ApiResponse<StringApiResponse> response = apiInstance.SystemFileUploadWithHttpInfo(path, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemFileApi.SystemFileUploadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | 上传的路径 | [optional]  |
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

<a id="systemfiles"></a>
# **SystemFiles**
> SystemFileListResultApiResponse SystemFiles (string path = null)

获取文件列表

根据指定路径获取文件列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class SystemFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SystemFileApi(config);
            var path = "path_example";  // string | 文件路径 (optional) 

            try
            {
                // 获取文件列表
                SystemFileListResultApiResponse result = apiInstance.SystemFiles(path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemFileApi.SystemFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SystemFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取文件列表
    ApiResponse<SystemFileListResultApiResponse> response = apiInstance.SystemFilesWithHttpInfo(path);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemFileApi.SystemFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **path** | **string** | 文件路径 | [optional]  |

### Return type

[**SystemFileListResultApiResponse**](SystemFileListResultApiResponse.md)

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

