# ZSGF.Client.Api.UserCurrencyApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserCurrencies**](UserCurrencyApi.md#usercurrencies) | **GET** /UserCurrency/{appKey}/{id} | 获取用户资产 |
| [**UserCurrencyConsume**](UserCurrencyApi.md#usercurrencyconsume) | **POST** /UserCurrency/{appKey}/CurrencyConsume | 消费虚拟币 |
| [**UserCurrencyExchange**](UserCurrencyApi.md#usercurrencyexchange) | **POST** /UserCurrency/{appKey}/CurrencyExchange | 兑换虚拟币 |
| [**UserCurrencyRecharge**](UserCurrencyApi.md#usercurrencyrecharge) | **POST** /UserCurrency/{appKey}/CurrencyRecharge | 充值虚拟币 |
| [**UserCurrencyTransactions**](UserCurrencyApi.md#usercurrencytransactions) | **GET** /UserCurrency/{appKey}/CurrencyTransactions | 虚拟币交易记录 |

<a id="usercurrencies"></a>
# **UserCurrencies**
> UserCurrencyListApiResponse UserCurrencies (string appKey, string id, string userId = null)

获取用户资产

获取用户的资产列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserCurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserCurrencyApi(config);
            var appKey = "appKey_example";  // string | 
            var id = "id_example";  // string | 
            var userId = "userId_example";  // string |  (optional) 

            try
            {
                // 获取用户资产
                UserCurrencyListApiResponse result = apiInstance.UserCurrencies(appKey, id, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserCurrencyApi.UserCurrencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取用户资产
    ApiResponse<UserCurrencyListApiResponse> response = apiInstance.UserCurrenciesWithHttpInfo(appKey, id, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserCurrencyApi.UserCurrenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **id** | **string** |  |  |
| **userId** | **string** |  | [optional]  |

### Return type

[**UserCurrencyListApiResponse**](UserCurrencyListApiResponse.md)

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

<a id="usercurrencyconsume"></a>
# **UserCurrencyConsume**
> BooleanApiResponse UserCurrencyConsume (string nonce, long timestamp, string signature, string appKey, string userId = null, CurrencyConsumeRequest currencyConsumeRequest = null)

消费虚拟币

根据提供的参数进行虚拟币消费

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserCurrencyConsumeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserCurrencyApi(config);
            var nonce = "nonce_example";  // string | 随机数
            var timestamp = 789L;  // long | 时间戳（允许与服务器时间误差在1分钟内）
            var signature = "signature_example";  // string | 签名
            var appKey = "appKey_example";  // string | 
            var userId = "userId_example";  // string |  (optional) 
            var currencyConsumeRequest = new CurrencyConsumeRequest(); // CurrencyConsumeRequest | 消费请求参数 (optional) 

            try
            {
                // 消费虚拟币
                BooleanApiResponse result = apiInstance.UserCurrencyConsume(nonce, timestamp, signature, appKey, userId, currencyConsumeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserCurrencyApi.UserCurrencyConsume: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrencyConsumeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 消费虚拟币
    ApiResponse<BooleanApiResponse> response = apiInstance.UserCurrencyConsumeWithHttpInfo(nonce, timestamp, signature, appKey, userId, currencyConsumeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserCurrencyApi.UserCurrencyConsumeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nonce** | **string** | 随机数 |  |
| **timestamp** | **long** | 时间戳（允许与服务器时间误差在1分钟内） |  |
| **signature** | **string** | 签名 |  |
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional]  |
| **currencyConsumeRequest** | [**CurrencyConsumeRequest**](CurrencyConsumeRequest.md) | 消费请求参数 | [optional]  |

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

<a id="usercurrencyexchange"></a>
# **UserCurrencyExchange**
> BooleanApiResponse UserCurrencyExchange (string nonce, long timestamp, string signature, string appKey, string userId = null, ExchangeCurrencyRequest exchangeCurrencyRequest = null)

兑换虚拟币

根据提供的参数进行虚拟币兑换

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserCurrencyExchangeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserCurrencyApi(config);
            var nonce = "nonce_example";  // string | 随机数
            var timestamp = 789L;  // long | 时间戳（允许与服务器时间误差在1分钟内）
            var signature = "signature_example";  // string | 签名
            var appKey = "appKey_example";  // string | 
            var userId = "userId_example";  // string |  (optional) 
            var exchangeCurrencyRequest = new ExchangeCurrencyRequest(); // ExchangeCurrencyRequest | 兑换请求参数 (optional) 

            try
            {
                // 兑换虚拟币
                BooleanApiResponse result = apiInstance.UserCurrencyExchange(nonce, timestamp, signature, appKey, userId, exchangeCurrencyRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserCurrencyApi.UserCurrencyExchange: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrencyExchangeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 兑换虚拟币
    ApiResponse<BooleanApiResponse> response = apiInstance.UserCurrencyExchangeWithHttpInfo(nonce, timestamp, signature, appKey, userId, exchangeCurrencyRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserCurrencyApi.UserCurrencyExchangeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nonce** | **string** | 随机数 |  |
| **timestamp** | **long** | 时间戳（允许与服务器时间误差在1分钟内） |  |
| **signature** | **string** | 签名 |  |
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional]  |
| **exchangeCurrencyRequest** | [**ExchangeCurrencyRequest**](ExchangeCurrencyRequest.md) | 兑换请求参数 | [optional]  |

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

<a id="usercurrencyrecharge"></a>
# **UserCurrencyRecharge**
> BooleanApiResponse UserCurrencyRecharge (string nonce, long timestamp, string signature, string appKey, string userId = null, RechargePointRequest rechargePointRequest = null)

充值虚拟币

根据提供的参数进行虚拟币充值

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserCurrencyRechargeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserCurrencyApi(config);
            var nonce = "nonce_example";  // string | 随机数
            var timestamp = 789L;  // long | 时间戳（允许与服务器时间误差在1分钟内）
            var signature = "signature_example";  // string | 签名
            var appKey = "appKey_example";  // string | 
            var userId = "userId_example";  // string |  (optional) 
            var rechargePointRequest = new RechargePointRequest(); // RechargePointRequest | 充值请求参数 (optional) 

            try
            {
                // 充值虚拟币
                BooleanApiResponse result = apiInstance.UserCurrencyRecharge(nonce, timestamp, signature, appKey, userId, rechargePointRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserCurrencyApi.UserCurrencyRecharge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrencyRechargeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 充值虚拟币
    ApiResponse<BooleanApiResponse> response = apiInstance.UserCurrencyRechargeWithHttpInfo(nonce, timestamp, signature, appKey, userId, rechargePointRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserCurrencyApi.UserCurrencyRechargeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **nonce** | **string** | 随机数 |  |
| **timestamp** | **long** | 时间戳（允许与服务器时间误差在1分钟内） |  |
| **signature** | **string** | 签名 |  |
| **appKey** | **string** |  |  |
| **userId** | **string** |  | [optional]  |
| **rechargePointRequest** | [**RechargePointRequest**](RechargePointRequest.md) | 充值请求参数 | [optional]  |

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

<a id="usercurrencytransactions"></a>
# **UserCurrencyTransactions**
> UserCurrencyCurrencyTransResultApiResponse UserCurrencyTransactions (string appKey, string transType = null, string curCode = null, DateTime startTime = null, DateTime endTime = null, int skip = null, int take = null, string userId = null)

虚拟币交易记录

根据提供的参数获取虚拟币交易记录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserCurrencyTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserCurrencyApi(config);
            var appKey = "appKey_example";  // string | 
            var transType = "transType_example";  // string | 交易类型 (optional) 
            var curCode = "curCode_example";  // string | 货币代码 (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 开始时间 (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 结束时间 (optional) 
            var skip = 56;  // int | 跳过的条数 (optional) 
            var take = 56;  // int | 拉取的条数 (optional) 
            var userId = "userId_example";  // string |  (optional) 

            try
            {
                // 虚拟币交易记录
                UserCurrencyCurrencyTransResultApiResponse result = apiInstance.UserCurrencyTransactions(appKey, transType, curCode, startTime, endTime, skip, take, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserCurrencyApi.UserCurrencyTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrencyTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 虚拟币交易记录
    ApiResponse<UserCurrencyCurrencyTransResultApiResponse> response = apiInstance.UserCurrencyTransactionsWithHttpInfo(appKey, transType, curCode, startTime, endTime, skip, take, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserCurrencyApi.UserCurrencyTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **transType** | **string** | 交易类型 | [optional]  |
| **curCode** | **string** | 货币代码 | [optional]  |
| **startTime** | **DateTime** | 开始时间 | [optional]  |
| **endTime** | **DateTime** | 结束时间 | [optional]  |
| **skip** | **int** | 跳过的条数 | [optional]  |
| **take** | **int** | 拉取的条数 | [optional]  |
| **userId** | **string** |  | [optional]  |

### Return type

[**UserCurrencyCurrencyTransResultApiResponse**](UserCurrencyCurrencyTransResultApiResponse.md)

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

