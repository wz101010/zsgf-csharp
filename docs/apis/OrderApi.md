# ZSGF.Client.Api.OrderApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Order**](OrderApi.md#order) | **GET** /Order/{appKey}/{id} | 获取订单详情 |
| [**OrderCreate**](OrderApi.md#ordercreate) | **POST** /Order/{appKey}/Create | 创建订单 |
| [**Orders**](OrderApi.md#orders) | **GET** /Order/{appKey} | 获取订单列表 |

<a id="order"></a>
# **Order**
> OrderApiResponse Order (long id, string appKey)

获取订单详情

根据订单ID获取订单详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class OrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var id = 789L;  // long | 订单ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取订单详情
                OrderApiResponse result = apiInstance.Order(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.Order: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取订单详情
    ApiResponse<OrderApiResponse> response = apiInstance.OrderWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 订单ID |  |
| **appKey** | **string** |  |  |

### Return type

[**OrderApiResponse**](OrderApiResponse.md)

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

<a id="ordercreate"></a>
# **OrderCreate**
> CreateOrderResultApiResponse OrderCreate (string appKey, CreateOrderRequest createOrderRequest = null)

创建订单

根据请求参数创建订单

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class OrderCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var appKey = "appKey_example";  // string | 
            var createOrderRequest = new CreateOrderRequest(); // CreateOrderRequest | 订单创建请求 (optional) 

            try
            {
                // 创建订单
                CreateOrderResultApiResponse result = apiInstance.OrderCreate(appKey, createOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.OrderCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrderCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建订单
    ApiResponse<CreateOrderResultApiResponse> response = apiInstance.OrderCreateWithHttpInfo(appKey, createOrderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrderCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **createOrderRequest** | [**CreateOrderRequest**](CreateOrderRequest.md) | 订单创建请求 | [optional]  |

### Return type

[**CreateOrderResultApiResponse**](CreateOrderResultApiResponse.md)

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

<a id="orders"></a>
# **Orders**
> OrderListResultApiResponse Orders (string appKey, string status = null, string orderNo = null, string tradeNo = null, long userId = null, string pctType = null, string pctId = null, string pctName = null, int skip = null, int take = null)

获取订单列表

根据查询条件获取订单列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class OrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new OrderApi(config);
            var appKey = "appKey_example";  // string | 
            var status = "status_example";  // string | 订单状态 (optional) 
            var orderNo = "orderNo_example";  // string | 系统订单号 (optional) 
            var tradeNo = "tradeNo_example";  // string | 支付平台单号 (optional) 
            var userId = 789L;  // long | 用户ID (optional) 
            var pctType = "pctType_example";  // string | 商品类型 (optional) 
            var pctId = "pctId_example";  // string | 商品ID (optional) 
            var pctName = "pctName_example";  // string | 商品名称 (optional) 
            var skip = 56;  // int | 跳过的条数 (optional) 
            var take = 56;  // int | 拉取的条数 (optional) 

            try
            {
                // 获取订单列表
                OrderListResultApiResponse result = apiInstance.Orders(appKey, status, orderNo, tradeNo, userId, pctType, pctId, pctName, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrderApi.Orders: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取订单列表
    ApiResponse<OrderListResultApiResponse> response = apiInstance.OrdersWithHttpInfo(appKey, status, orderNo, tradeNo, userId, pctType, pctId, pctName, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrderApi.OrdersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **status** | **string** | 订单状态 | [optional]  |
| **orderNo** | **string** | 系统订单号 | [optional]  |
| **tradeNo** | **string** | 支付平台单号 | [optional]  |
| **userId** | **long** | 用户ID | [optional]  |
| **pctType** | **string** | 商品类型 | [optional]  |
| **pctId** | **string** | 商品ID | [optional]  |
| **pctName** | **string** | 商品名称 | [optional]  |
| **skip** | **int** | 跳过的条数 | [optional]  |
| **take** | **int** | 拉取的条数 | [optional]  |

### Return type

[**OrderListResultApiResponse**](OrderListResultApiResponse.md)

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

