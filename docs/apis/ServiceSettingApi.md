# ZSGF.Client.Api.ServiceSettingApi

All URIs are relative to *https://api.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ServiceSetting**](ServiceSettingApi.md#servicesetting) | **GET** /ServiceSetting/{id} | 获取配置详情 |
| [**ServiceSettingDelete**](ServiceSettingApi.md#servicesettingdelete) | **DELETE** /ServiceSetting/{id} | 删除配置 |
| [**ServiceSettingGroup**](ServiceSettingApi.md#servicesettinggroup) | **GET** /ServiceSetting/Groups/{id} | 获取服务分组详情 |
| [**ServiceSettingGroupDelete**](ServiceSettingApi.md#servicesettinggroupdelete) | **DELETE** /ServiceSetting/Groups/{id} | 删除服务分组 |
| [**ServiceSettingGroupPost**](ServiceSettingApi.md#servicesettinggrouppost) | **POST** /ServiceSetting/Groups | 添加服务分组 |
| [**ServiceSettingGroupPut**](ServiceSettingApi.md#servicesettinggroupput) | **PUT** /ServiceSetting/Groups/{id} | 更新服务分组 |
| [**ServiceSettingGroups**](ServiceSettingApi.md#servicesettinggroups) | **GET** /ServiceSetting/Groups | 获取服务分组列表 |
| [**ServiceSettingItem**](ServiceSettingApi.md#servicesettingitem) | **GET** /ServiceSetting/Items/{id} | 服务配置详情 |
| [**ServiceSettingItemDelete**](ServiceSettingApi.md#servicesettingitemdelete) | **DELETE** /ServiceSetting/Items/{id} | 删除服务配置 |
| [**ServiceSettingItemPost**](ServiceSettingApi.md#servicesettingitempost) | **POST** /ServiceSetting/Items | 添加服务配置 |
| [**ServiceSettingItemPut**](ServiceSettingApi.md#servicesettingitemput) | **PUT** /ServiceSetting/Items/{id} | 更新服务配置 |
| [**ServiceSettingItems**](ServiceSettingApi.md#servicesettingitems) | **GET** /ServiceSetting/Items | 服务配置列表 |
| [**ServiceSettingPost**](ServiceSettingApi.md#servicesettingpost) | **POST** /ServiceSetting | 增加配置 |
| [**ServiceSettingProvider**](ServiceSettingApi.md#servicesettingprovider) | **GET** /ServiceSetting/Providers/{id} | 获取服务商详情 |
| [**ServiceSettingProviderDelete**](ServiceSettingApi.md#servicesettingproviderdelete) | **DELETE** /ServiceSetting/Providers/{id} | 删除服务商 |
| [**ServiceSettingProviderPost**](ServiceSettingApi.md#servicesettingproviderpost) | **POST** /ServiceSetting/Providers | 添加服务商 |
| [**ServiceSettingProviderPut**](ServiceSettingApi.md#servicesettingproviderput) | **PUT** /ServiceSetting/Providers/{id} | 更新服务商 |
| [**ServiceSettingProviders**](ServiceSettingApi.md#servicesettingproviders) | **GET** /ServiceSetting/Providers | 获取服务商列表 |
| [**ServiceSettingPut**](ServiceSettingApi.md#servicesettingput) | **PUT** /ServiceSetting/{id} | 更新配置 |
| [**ServiceSettings**](ServiceSettingApi.md#servicesettings) | **GET** /ServiceSetting | 获取配置列表 |

<a id="servicesetting"></a>
# **ServiceSetting**
> SettingsApiResponse ServiceSetting (long id)

获取配置详情

根据配置ID获取配置详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 配置ID

            try
            {
                // 获取配置详情
                SettingsApiResponse result = apiInstance.ServiceSetting(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSetting: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取配置详情
    ApiResponse<SettingsApiResponse> response = apiInstance.ServiceSettingWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 配置ID |  |

### Return type

[**SettingsApiResponse**](SettingsApiResponse.md)

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

<a id="servicesettingdelete"></a>
# **ServiceSettingDelete**
> BooleanApiResponse ServiceSettingDelete (long id)

删除配置

根据配置ID删除配置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 配置ID

            try
            {
                // 删除配置
                BooleanApiResponse result = apiInstance.ServiceSettingDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除配置
    ApiResponse<BooleanApiResponse> response = apiInstance.ServiceSettingDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 配置ID |  |

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

<a id="servicesettinggroup"></a>
# **ServiceSettingGroup**
> ServiceGroupApiResponse ServiceSettingGroup (long id)

获取服务分组详情

根据服务分组ID获取服务分组详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务分组ID

            try
            {
                // 获取服务分组详情
                ServiceGroupApiResponse result = apiInstance.ServiceSettingGroup(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取服务分组详情
    ApiResponse<ServiceGroupApiResponse> response = apiInstance.ServiceSettingGroupWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务分组ID |  |

### Return type

[**ServiceGroupApiResponse**](ServiceGroupApiResponse.md)

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

<a id="servicesettinggroupdelete"></a>
# **ServiceSettingGroupDelete**
> BooleanApiResponse ServiceSettingGroupDelete (long id)

删除服务分组

根据服务分组ID删除服务分组

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingGroupDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务分组ID

            try
            {
                // 删除服务分组
                BooleanApiResponse result = apiInstance.ServiceSettingGroupDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroupDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingGroupDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除服务分组
    ApiResponse<BooleanApiResponse> response = apiInstance.ServiceSettingGroupDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroupDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务分组ID |  |

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

<a id="servicesettinggrouppost"></a>
# **ServiceSettingGroupPost**
> ServiceSettingGroupPostResultApiResponse ServiceSettingGroupPost (ServiceGroup serviceGroup = null)

添加服务分组

添加新的服务分组

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var serviceGroup = new ServiceGroup(); // ServiceGroup | 服务分组实体 (optional) 

            try
            {
                // 添加服务分组
                ServiceSettingGroupPostResultApiResponse result = apiInstance.ServiceSettingGroupPost(serviceGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加服务分组
    ApiResponse<ServiceSettingGroupPostResultApiResponse> response = apiInstance.ServiceSettingGroupPostWithHttpInfo(serviceGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceGroup** | [**ServiceGroup**](ServiceGroup.md) | 服务分组实体 | [optional]  |

### Return type

[**ServiceSettingGroupPostResultApiResponse**](ServiceSettingGroupPostResultApiResponse.md)

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

<a id="servicesettinggroupput"></a>
# **ServiceSettingGroupPut**
> BooleanApiResponse ServiceSettingGroupPut (long id, ServiceGroup serviceGroup = null)

更新服务分组

根据服务分组ID更新服务分组信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingGroupPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务分组ID
            var serviceGroup = new ServiceGroup(); // ServiceGroup | 服务分组实体 (optional) 

            try
            {
                // 更新服务分组
                BooleanApiResponse result = apiInstance.ServiceSettingGroupPut(id, serviceGroup);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroupPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingGroupPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新服务分组
    ApiResponse<BooleanApiResponse> response = apiInstance.ServiceSettingGroupPutWithHttpInfo(id, serviceGroup);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroupPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务分组ID |  |
| **serviceGroup** | [**ServiceGroup**](ServiceGroup.md) | 服务分组实体 | [optional]  |

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

<a id="servicesettinggroups"></a>
# **ServiceSettingGroups**
> ServiceGroupListApiResponse ServiceSettingGroups (long providerId = null, bool showFlag = null)

获取服务分组列表

根据服务商ID和显示标志获取服务分组列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var providerId = 789L;  // long | 服务商ID (optional) 
            var showFlag = false;  // bool | 是否显示 (optional)  (default to false)

            try
            {
                // 获取服务分组列表
                ServiceGroupListApiResponse result = apiInstance.ServiceSettingGroups(providerId, showFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取服务分组列表
    ApiResponse<ServiceGroupListApiResponse> response = apiInstance.ServiceSettingGroupsWithHttpInfo(providerId, showFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **long** | 服务商ID | [optional]  |
| **showFlag** | **bool** | 是否显示 | [optional] [default to false] |

### Return type

[**ServiceGroupListApiResponse**](ServiceGroupListApiResponse.md)

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

<a id="servicesettingitem"></a>
# **ServiceSettingItem**
> ServiceItemApiResponse ServiceSettingItem (long id)

服务配置详情

根据服务配置ID获取服务配置详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingItemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务配置ID

            try
            {
                // 服务配置详情
                ServiceItemApiResponse result = apiInstance.ServiceSettingItem(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItem: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingItemWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 服务配置详情
    ApiResponse<ServiceItemApiResponse> response = apiInstance.ServiceSettingItemWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItemWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务配置ID |  |

### Return type

[**ServiceItemApiResponse**](ServiceItemApiResponse.md)

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

<a id="servicesettingitemdelete"></a>
# **ServiceSettingItemDelete**
> BooleanApiResponse ServiceSettingItemDelete (long id)

删除服务配置

根据服务配置ID删除服务配置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingItemDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务配置ID

            try
            {
                // 删除服务配置
                BooleanApiResponse result = apiInstance.ServiceSettingItemDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItemDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingItemDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除服务配置
    ApiResponse<BooleanApiResponse> response = apiInstance.ServiceSettingItemDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItemDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务配置ID |  |

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

<a id="servicesettingitempost"></a>
# **ServiceSettingItemPost**
> ServiceSettingItemPostResultApiResponse ServiceSettingItemPost (ServiceItem serviceItem = null)

添加服务配置

添加新的服务配置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingItemPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var serviceItem = new ServiceItem(); // ServiceItem | 服务配置实体 (optional) 

            try
            {
                // 添加服务配置
                ServiceSettingItemPostResultApiResponse result = apiInstance.ServiceSettingItemPost(serviceItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItemPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingItemPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加服务配置
    ApiResponse<ServiceSettingItemPostResultApiResponse> response = apiInstance.ServiceSettingItemPostWithHttpInfo(serviceItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItemPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceItem** | [**ServiceItem**](ServiceItem.md) | 服务配置实体 | [optional]  |

### Return type

[**ServiceSettingItemPostResultApiResponse**](ServiceSettingItemPostResultApiResponse.md)

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

<a id="servicesettingitemput"></a>
# **ServiceSettingItemPut**
> BooleanApiResponse ServiceSettingItemPut (long id, ServiceItem serviceItem = null)

更新服务配置

根据服务配置ID更新服务配置信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingItemPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务配置ID
            var serviceItem = new ServiceItem(); // ServiceItem | 服务配置实体 (optional) 

            try
            {
                // 更新服务配置
                BooleanApiResponse result = apiInstance.ServiceSettingItemPut(id, serviceItem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItemPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingItemPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新服务配置
    ApiResponse<BooleanApiResponse> response = apiInstance.ServiceSettingItemPutWithHttpInfo(id, serviceItem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItemPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务配置ID |  |
| **serviceItem** | [**ServiceItem**](ServiceItem.md) | 服务配置实体 | [optional]  |

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

<a id="servicesettingitems"></a>
# **ServiceSettingItems**
> ServiceItemListApiResponse ServiceSettingItems (string bizCode = null, string providerCode = null, string groupCode = null, bool showFlag = null)

服务配置列表

根据业务代码、服务商代码、分组代码和显示标志获取服务配置列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var bizCode = "bizCode_example";  // string | 业务代码 (optional) 
            var providerCode = "providerCode_example";  // string | 服务商代码 (optional) 
            var groupCode = "groupCode_example";  // string | 分组代码 (optional) 
            var showFlag = false;  // bool | 是否显示 (optional)  (default to false)

            try
            {
                // 服务配置列表
                ServiceItemListApiResponse result = apiInstance.ServiceSettingItems(bizCode, providerCode, groupCode, showFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 服务配置列表
    ApiResponse<ServiceItemListApiResponse> response = apiInstance.ServiceSettingItemsWithHttpInfo(bizCode, providerCode, groupCode, showFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bizCode** | **string** | 业务代码 | [optional]  |
| **providerCode** | **string** | 服务商代码 | [optional]  |
| **groupCode** | **string** | 分组代码 | [optional]  |
| **showFlag** | **bool** | 是否显示 | [optional] [default to false] |

### Return type

[**ServiceItemListApiResponse**](ServiceItemListApiResponse.md)

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

<a id="servicesettingpost"></a>
# **ServiceSettingPost**
> ServiceSettingSettingPostResultApiResponse ServiceSettingPost (Settings settings = null)

增加配置

添加新的配置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var settings = new Settings(); // Settings | 配置实体 (optional) 

            try
            {
                // 增加配置
                ServiceSettingSettingPostResultApiResponse result = apiInstance.ServiceSettingPost(settings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 增加配置
    ApiResponse<ServiceSettingSettingPostResultApiResponse> response = apiInstance.ServiceSettingPostWithHttpInfo(settings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **settings** | [**Settings**](Settings.md) | 配置实体 | [optional]  |

### Return type

[**ServiceSettingSettingPostResultApiResponse**](ServiceSettingSettingPostResultApiResponse.md)

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

<a id="servicesettingprovider"></a>
# **ServiceSettingProvider**
> ServiceProviderApiResponse ServiceSettingProvider (long id)

获取服务商详情

根据服务商ID获取服务商详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingProviderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务商ID

            try
            {
                // 获取服务商详情
                ServiceProviderApiResponse result = apiInstance.ServiceSettingProvider(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProvider: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingProviderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取服务商详情
    ApiResponse<ServiceProviderApiResponse> response = apiInstance.ServiceSettingProviderWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProviderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务商ID |  |

### Return type

[**ServiceProviderApiResponse**](ServiceProviderApiResponse.md)

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

<a id="servicesettingproviderdelete"></a>
# **ServiceSettingProviderDelete**
> BooleanApiResponse ServiceSettingProviderDelete (long id)

删除服务商

根据服务商ID删除服务商

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingProviderDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务商ID

            try
            {
                // 删除服务商
                BooleanApiResponse result = apiInstance.ServiceSettingProviderDelete(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProviderDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingProviderDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除服务商
    ApiResponse<BooleanApiResponse> response = apiInstance.ServiceSettingProviderDeleteWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProviderDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务商ID |  |

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

<a id="servicesettingproviderpost"></a>
# **ServiceSettingProviderPost**
> ServiceSettingProviderPostResultApiResponse ServiceSettingProviderPost (ServiceProvider serviceProvider = null)

添加服务商

添加新的服务商

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingProviderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var serviceProvider = new ServiceProvider(); // ServiceProvider | 服务商实体 (optional) 

            try
            {
                // 添加服务商
                ServiceSettingProviderPostResultApiResponse result = apiInstance.ServiceSettingProviderPost(serviceProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProviderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingProviderPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加服务商
    ApiResponse<ServiceSettingProviderPostResultApiResponse> response = apiInstance.ServiceSettingProviderPostWithHttpInfo(serviceProvider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProviderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serviceProvider** | [**ServiceProvider**](ServiceProvider.md) | 服务商实体 | [optional]  |

### Return type

[**ServiceSettingProviderPostResultApiResponse**](ServiceSettingProviderPostResultApiResponse.md)

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

<a id="servicesettingproviderput"></a>
# **ServiceSettingProviderPut**
> BooleanApiResponse ServiceSettingProviderPut (long id, ServiceProvider serviceProvider = null)

更新服务商

根据服务商ID更新服务商信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingProviderPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 服务商ID
            var serviceProvider = new ServiceProvider(); // ServiceProvider | 服务商实体 (optional) 

            try
            {
                // 更新服务商
                BooleanApiResponse result = apiInstance.ServiceSettingProviderPut(id, serviceProvider);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProviderPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingProviderPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新服务商
    ApiResponse<BooleanApiResponse> response = apiInstance.ServiceSettingProviderPutWithHttpInfo(id, serviceProvider);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProviderPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 服务商ID |  |
| **serviceProvider** | [**ServiceProvider**](ServiceProvider.md) | 服务商实体 | [optional]  |

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

<a id="servicesettingproviders"></a>
# **ServiceSettingProviders**
> ServiceProviderListApiResponse ServiceSettingProviders (string bizCode = null, bool showFlag = null)

获取服务商列表

根据业务代码和显示标志获取服务商列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingProvidersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var bizCode = "bizCode_example";  // string | 业务代码 (optional) 
            var showFlag = false;  // bool | 是否显示 (optional)  (default to false)

            try
            {
                // 获取服务商列表
                ServiceProviderListApiResponse result = apiInstance.ServiceSettingProviders(bizCode, showFlag);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProviders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingProvidersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取服务商列表
    ApiResponse<ServiceProviderListApiResponse> response = apiInstance.ServiceSettingProvidersWithHttpInfo(bizCode, showFlag);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingProvidersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bizCode** | **string** | 业务代码 | [optional]  |
| **showFlag** | **bool** | 是否显示 | [optional] [default to false] |

### Return type

[**ServiceProviderListApiResponse**](ServiceProviderListApiResponse.md)

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

<a id="servicesettingput"></a>
# **ServiceSettingPut**
> BooleanApiResponse ServiceSettingPut (long id, Settings settings = null)

更新配置

根据配置ID更新配置信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var id = 789L;  // long | 配置ID
            var settings = new Settings(); // Settings | 配置实体 (optional) 

            try
            {
                // 更新配置
                BooleanApiResponse result = apiInstance.ServiceSettingPut(id, settings);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新配置
    ApiResponse<BooleanApiResponse> response = apiInstance.ServiceSettingPutWithHttpInfo(id, settings);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 配置ID |  |
| **settings** | [**Settings**](Settings.md) | 配置实体 | [optional]  |

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

<a id="servicesettings"></a>
# **ServiceSettings**
> SettingsListApiResponse ServiceSettings (string bizCode, string bizId, string providerCode = null, string groupCode = null, string tag = null, string code = null)

获取配置列表

根据业务代码、业务标识、服务商代码、分组代码、标签和配置项代码获取配置列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class ServiceSettingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ServiceSettingApi(config);
            var bizCode = "bizCode_example";  // string | 业务代码
            var bizId = "bizId_example";  // string | 业务标识
            var providerCode = "providerCode_example";  // string | 服务商代码 (optional) 
            var groupCode = "groupCode_example";  // string | 分组代码 (optional) 
            var tag = "tag_example";  // string | 标签 (optional) 
            var code = "code_example";  // string | 配置项代码 (optional) 

            try
            {
                // 获取配置列表
                SettingsListApiResponse result = apiInstance.ServiceSettings(bizCode, bizId, providerCode, groupCode, tag, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServiceSettingApi.ServiceSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ServiceSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取配置列表
    ApiResponse<SettingsListApiResponse> response = apiInstance.ServiceSettingsWithHttpInfo(bizCode, bizId, providerCode, groupCode, tag, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServiceSettingApi.ServiceSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bizCode** | **string** | 业务代码 |  |
| **bizId** | **string** | 业务标识 |  |
| **providerCode** | **string** | 服务商代码 | [optional]  |
| **groupCode** | **string** | 分组代码 | [optional]  |
| **tag** | **string** | 标签 | [optional]  |
| **code** | **string** | 配置项代码 | [optional]  |

### Return type

[**SettingsListApiResponse**](SettingsListApiResponse.md)

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

