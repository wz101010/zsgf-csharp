# ZSGF.Client.Api.AlipayApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AlipayCreateOrder**](AlipayApi.md#alipaycreateorder) | **POST** /Alipay/{appKey}/CreateOrder | 创建当面付订单 |
| [**AlipayCreateOrderPagePay**](AlipayApi.md#alipaycreateorderpagepay) | **POST** /Alipay/{appKey}/CreateOrderPagePay | 创建PC支付订单 |
| [**AlipayCreateOrderWapPay**](AlipayApi.md#alipaycreateorderwappay) | **POST** /Alipay/{appKey}/CreateOrderWapPay | 创建WAP支付订单 |
| [**AlipayOrderDetail**](AlipayApi.md#alipayorderdetail) | **GET** /Alipay/{appKey}/OrderDetail | 获取订单详情 |
| [**AlipayOrderRefund**](AlipayApi.md#alipayorderrefund) | **POST** /Alipay/{appKey}/OrderRefund | 发起订单退款 |
| [**AlipayReturnPageNotify**](AlipayApi.md#alipayreturnpagenotify) | **POST** /Alipay/{appKey}/ReturnPageNotify | 支付成功回调通知 |

<a id="alipaycreateorder"></a>
# **AlipayCreateOrder**
> StringApiResponse AlipayCreateOrder (string appKey, AlipayCreateOrderRequest alipayCreateOrderRequest = null)

创建当面付订单

创建一个当面付订单，并返回支付二维码。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AlipayCreateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var alipayCreateOrderRequest = new AlipayCreateOrderRequest(); // AlipayCreateOrderRequest |  (optional) 

            try
            {
                // 创建当面付订单
                StringApiResponse result = apiInstance.AlipayCreateOrder(appKey, alipayCreateOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayApi.AlipayCreateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlipayCreateOrderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建当面付订单
    ApiResponse<StringApiResponse> response = apiInstance.AlipayCreateOrderWithHttpInfo(appKey, alipayCreateOrderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlipayApi.AlipayCreateOrderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **alipayCreateOrderRequest** | [**AlipayCreateOrderRequest**](AlipayCreateOrderRequest.md) |  | [optional]  |

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

<a id="alipaycreateorderpagepay"></a>
# **AlipayCreateOrderPagePay**
> StringApiResponse AlipayCreateOrderPagePay (string appKey, AlipayCreateOrderPagePayRequest alipayCreateOrderPagePayRequest = null)

创建PC支付订单

创建一个PC支付订单，并返回支付页面。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AlipayCreateOrderPagePayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var alipayCreateOrderPagePayRequest = new AlipayCreateOrderPagePayRequest(); // AlipayCreateOrderPagePayRequest |  (optional) 

            try
            {
                // 创建PC支付订单
                StringApiResponse result = apiInstance.AlipayCreateOrderPagePay(appKey, alipayCreateOrderPagePayRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayApi.AlipayCreateOrderPagePay: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlipayCreateOrderPagePayWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建PC支付订单
    ApiResponse<StringApiResponse> response = apiInstance.AlipayCreateOrderPagePayWithHttpInfo(appKey, alipayCreateOrderPagePayRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlipayApi.AlipayCreateOrderPagePayWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **alipayCreateOrderPagePayRequest** | [**AlipayCreateOrderPagePayRequest**](AlipayCreateOrderPagePayRequest.md) |  | [optional]  |

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

<a id="alipaycreateorderwappay"></a>
# **AlipayCreateOrderWapPay**
> StringApiResponse AlipayCreateOrderWapPay (string appKey, AlipayCreateOrderWapPayRequest alipayCreateOrderWapPayRequest = null)

创建WAP支付订单

创建一个WAP支付订单，并返回支付页面。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AlipayCreateOrderWapPayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var alipayCreateOrderWapPayRequest = new AlipayCreateOrderWapPayRequest(); // AlipayCreateOrderWapPayRequest |  (optional) 

            try
            {
                // 创建WAP支付订单
                StringApiResponse result = apiInstance.AlipayCreateOrderWapPay(appKey, alipayCreateOrderWapPayRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayApi.AlipayCreateOrderWapPay: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlipayCreateOrderWapPayWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建WAP支付订单
    ApiResponse<StringApiResponse> response = apiInstance.AlipayCreateOrderWapPayWithHttpInfo(appKey, alipayCreateOrderWapPayRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlipayApi.AlipayCreateOrderWapPayWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **alipayCreateOrderWapPayRequest** | [**AlipayCreateOrderWapPayRequest**](AlipayCreateOrderWapPayRequest.md) |  | [optional]  |

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

<a id="alipayorderdetail"></a>
# **AlipayOrderDetail**
> AlipayTradeQueryResponseApiResponse AlipayOrderDetail (string appKey, string orderNo = null)

获取订单详情

查询订单详情，包括订单状态和支付信息。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AlipayOrderDetailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var orderNo = "orderNo_example";  // string | 订单号 (optional) 

            try
            {
                // 获取订单详情
                AlipayTradeQueryResponseApiResponse result = apiInstance.AlipayOrderDetail(appKey, orderNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayApi.AlipayOrderDetail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlipayOrderDetailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取订单详情
    ApiResponse<AlipayTradeQueryResponseApiResponse> response = apiInstance.AlipayOrderDetailWithHttpInfo(appKey, orderNo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlipayApi.AlipayOrderDetailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **orderNo** | **string** | 订单号 | [optional]  |

### Return type

[**AlipayTradeQueryResponseApiResponse**](AlipayTradeQueryResponseApiResponse.md)

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

<a id="alipayorderrefund"></a>
# **AlipayOrderRefund**
> AlipayTradeRefundResponseApiResponse AlipayOrderRefund (string appKey, string amount = null, string orderNo = null)

发起订单退款

对指定订单进行退款操作。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AlipayOrderRefundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var amount = "amount_example";  // string | 退款金额 (optional) 
            var orderNo = "orderNo_example";  // string | 订单号 (optional) 

            try
            {
                // 发起订单退款
                AlipayTradeRefundResponseApiResponse result = apiInstance.AlipayOrderRefund(appKey, amount, orderNo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayApi.AlipayOrderRefund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlipayOrderRefundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发起订单退款
    ApiResponse<AlipayTradeRefundResponseApiResponse> response = apiInstance.AlipayOrderRefundWithHttpInfo(appKey, amount, orderNo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlipayApi.AlipayOrderRefundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **amount** | **string** | 退款金额 | [optional]  |
| **orderNo** | **string** | 订单号 | [optional]  |

### Return type

[**AlipayTradeRefundResponseApiResponse**](AlipayTradeRefundResponseApiResponse.md)

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

<a id="alipayreturnpagenotify"></a>
# **AlipayReturnPageNotify**
> BooleanApiResponse AlipayReturnPageNotify (string appKey, ReturnPageNotifyRequest returnPageNotifyRequest = null)

支付成功回调通知

处理支付宝支付成功的同步通知。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class AlipayReturnPageNotifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var returnPageNotifyRequest = new ReturnPageNotifyRequest(); // ReturnPageNotifyRequest |  (optional) 

            try
            {
                // 支付成功回调通知
                BooleanApiResponse result = apiInstance.AlipayReturnPageNotify(appKey, returnPageNotifyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlipayApi.AlipayReturnPageNotify: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlipayReturnPageNotifyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 支付成功回调通知
    ApiResponse<BooleanApiResponse> response = apiInstance.AlipayReturnPageNotifyWithHttpInfo(appKey, returnPageNotifyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlipayApi.AlipayReturnPageNotifyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **returnPageNotifyRequest** | [**ReturnPageNotifyRequest**](ReturnPageNotifyRequest.md) |  | [optional]  |

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

