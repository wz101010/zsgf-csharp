# ZSGF.Client.Api.AlipayApi

All URIs are relative to *https://api-staging.paomo.fun*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AlipayCreateOrder**](AlipayApi.md#alipaycreateorder) | **POST** /Alipay/{appKey}/CreateOrder | 创建订单 - 当面付 |
| [**AlipayCreateOrderPagePay**](AlipayApi.md#alipaycreateorderpagepay) | **POST** /Alipay/{appKey}/CreateOrderPagePay | 创建订单 - PC支付 |
| [**AlipayCreateOrderWapPay**](AlipayApi.md#alipaycreateorderwappay) | **POST** /Alipay/{appKey}/CreateOrderWapPay | 创建订单 - WAP支付 |
| [**AlipayOrderDetail**](AlipayApi.md#alipayorderdetail) | **GET** /Alipay/{appKey}/OrderDetail | 订单详情 |
| [**AlipayOrderRefund**](AlipayApi.md#alipayorderrefund) | **POST** /Alipay/{appKey}/OrderRefund | 订单退款 |
| [**AlipayReturnPageNotify**](AlipayApi.md#alipayreturnpagenotify) | **POST** /Alipay/{appKey}/ReturnPageNotify | 支付成功同步通知 |

<a id="alipaycreateorder"></a>
# **AlipayCreateOrder**
> JObjectApiResult AlipayCreateOrder (string appKey, AlipayCreateOrderRequest alipayCreateOrderRequest = null)

创建订单 - 当面付

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var alipayCreateOrderRequest = new AlipayCreateOrderRequest(); // AlipayCreateOrderRequest |  (optional) 

            try
            {
                // 创建订单 - 当面付
                JObjectApiResult result = apiInstance.AlipayCreateOrder(appKey, alipayCreateOrderRequest);
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
    // 创建订单 - 当面付
    ApiResponse<JObjectApiResult> response = apiInstance.AlipayCreateOrderWithHttpInfo(appKey, alipayCreateOrderRequest);
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

<a id="alipaycreateorderpagepay"></a>
# **AlipayCreateOrderPagePay**
> JObjectApiResult AlipayCreateOrderPagePay (string appKey, AlipayCreateOrderPagePayRequest alipayCreateOrderPagePayRequest = null)

创建订单 - PC支付

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var alipayCreateOrderPagePayRequest = new AlipayCreateOrderPagePayRequest(); // AlipayCreateOrderPagePayRequest |  (optional) 

            try
            {
                // 创建订单 - PC支付
                JObjectApiResult result = apiInstance.AlipayCreateOrderPagePay(appKey, alipayCreateOrderPagePayRequest);
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
    // 创建订单 - PC支付
    ApiResponse<JObjectApiResult> response = apiInstance.AlipayCreateOrderPagePayWithHttpInfo(appKey, alipayCreateOrderPagePayRequest);
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

<a id="alipaycreateorderwappay"></a>
# **AlipayCreateOrderWapPay**
> JObjectApiResult AlipayCreateOrderWapPay (string appKey, AlipayCreateOrderWapPayRequest alipayCreateOrderWapPayRequest = null)

创建订单 - WAP支付

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var alipayCreateOrderWapPayRequest = new AlipayCreateOrderWapPayRequest(); // AlipayCreateOrderWapPayRequest |  (optional) 

            try
            {
                // 创建订单 - WAP支付
                JObjectApiResult result = apiInstance.AlipayCreateOrderWapPay(appKey, alipayCreateOrderWapPayRequest);
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
    // 创建订单 - WAP支付
    ApiResponse<JObjectApiResult> response = apiInstance.AlipayCreateOrderWapPayWithHttpInfo(appKey, alipayCreateOrderWapPayRequest);
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

<a id="alipayorderdetail"></a>
# **AlipayOrderDetail**
> JObjectApiResult AlipayOrderDetail (string appKey, string orderNo = null)

订单详情

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var orderNo = "orderNo_example";  // string | 订单号 (optional) 

            try
            {
                // 订单详情
                JObjectApiResult result = apiInstance.AlipayOrderDetail(appKey, orderNo);
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
    // 订单详情
    ApiResponse<JObjectApiResult> response = apiInstance.AlipayOrderDetailWithHttpInfo(appKey, orderNo);
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

<a id="alipayorderrefund"></a>
# **AlipayOrderRefund**
> JObjectApiResult AlipayOrderRefund (string appKey, string amount = null, string orderNo = null)

订单退款

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var amount = "amount_example";  // string | 退款金额 (optional) 
            var orderNo = "orderNo_example";  // string | 订单号 (optional) 

            try
            {
                // 订单退款
                JObjectApiResult result = apiInstance.AlipayOrderRefund(appKey, amount, orderNo);
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
    // 订单退款
    ApiResponse<JObjectApiResult> response = apiInstance.AlipayOrderRefundWithHttpInfo(appKey, amount, orderNo);
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

<a id="alipayreturnpagenotify"></a>
# **AlipayReturnPageNotify**
> JObjectApiResult AlipayReturnPageNotify (string appKey, ReturnPageNotifyRequest returnPageNotifyRequest = null)

支付成功同步通知

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AlipayApi(config);
            var appKey = "appKey_example";  // string | 
            var returnPageNotifyRequest = new ReturnPageNotifyRequest(); // ReturnPageNotifyRequest |  (optional) 

            try
            {
                // 支付成功同步通知
                JObjectApiResult result = apiInstance.AlipayReturnPageNotify(appKey, returnPageNotifyRequest);
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
    // 支付成功同步通知
    ApiResponse<JObjectApiResult> response = apiInstance.AlipayReturnPageNotifyWithHttpInfo(appKey, returnPageNotifyRequest);
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

