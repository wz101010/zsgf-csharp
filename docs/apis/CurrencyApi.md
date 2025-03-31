# ZSGF.Client.Api.CurrencyApi

All URIs are relative to *https://api.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Currencies**](CurrencyApi.md#currencies) | **GET** /Currency/{appKey} | 获取货币列表 |
| [**Currency**](CurrencyApi.md#currency) | **GET** /Currency/{appKey}/{id} | 获取货币详情 |
| [**CurrencyDelete**](CurrencyApi.md#currencydelete) | **DELETE** /Currency/{appKey}/{id} | 删除货币 |
| [**CurrencyExchangeRateDelete**](CurrencyApi.md#currencyexchangeratedelete) | **DELETE** /Currency/{appKey}/ExchangeRates/{id} | 删除汇率 |
| [**CurrencyExchangeRatePut**](CurrencyApi.md#currencyexchangerateput) | **PUT** /Currency/{appKey}/ExchangeRates/{code} | 更新汇率 |
| [**CurrencyExchangeRates**](CurrencyApi.md#currencyexchangerates) | **GET** /Currency/{appKey}/ExchangeRates/{code} | 获取汇率列表 |
| [**CurrencyPost**](CurrencyApi.md#currencypost) | **POST** /Currency/{appKey} | 创建新货币 |
| [**CurrencyPut**](CurrencyApi.md#currencyput) | **PUT** /Currency/{appKey}/{id} | 更新货币信息 |
| [**CurrencyTransactions**](CurrencyApi.md#currencytransactions) | **GET** /Currency/{appKey}/Transactions | 获取货币交易记录 |

<a id="currencies"></a>
# **Currencies**
> CurrencyListApiResponse Currencies (string appKey)

获取货币列表

获取所有货币的列表，按ID降序排列。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取货币列表
                CurrencyListApiResponse result = apiInstance.Currencies(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.Currencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取货币列表
    ApiResponse<CurrencyListApiResponse> response = apiInstance.CurrenciesWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

### Return type

[**CurrencyListApiResponse**](CurrencyListApiResponse.md)

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

<a id="currency"></a>
# **Currency**
> CurrencyApiResponse Currency (long id, string appKey)

获取货币详情

根据货币ID获取货币的详细信息。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrencyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var id = 789L;  // long | 货币ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取货币详情
                CurrencyApiResponse result = apiInstance.Currency(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.Currency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取货币详情
    ApiResponse<CurrencyApiResponse> response = apiInstance.CurrencyWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrencyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 货币ID |  |
| **appKey** | **string** |  |  |

### Return type

[**CurrencyApiResponse**](CurrencyApiResponse.md)

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

<a id="currencydelete"></a>
# **CurrencyDelete**
> BooleanApiResponse CurrencyDelete (long id, string appKey)

删除货币

根据货币ID删除货币。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrencyDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var id = 789L;  // long | 货币ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除货币
                BooleanApiResponse result = apiInstance.CurrencyDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.CurrencyDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除货币
    ApiResponse<BooleanApiResponse> response = apiInstance.CurrencyDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrencyDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 货币ID |  |
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

<a id="currencyexchangeratedelete"></a>
# **CurrencyExchangeRateDelete**
> BooleanApiResponse CurrencyExchangeRateDelete (long id, string appKey)

删除汇率

根据汇率ID删除汇率。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrencyExchangeRateDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var id = 789L;  // long | 汇率ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除汇率
                BooleanApiResponse result = apiInstance.CurrencyExchangeRateDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.CurrencyExchangeRateDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyExchangeRateDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除汇率
    ApiResponse<BooleanApiResponse> response = apiInstance.CurrencyExchangeRateDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrencyExchangeRateDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 汇率ID |  |
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

<a id="currencyexchangerateput"></a>
# **CurrencyExchangeRatePut**
> Int64ApiResponse CurrencyExchangeRatePut (string code, string appKey, ExchangeRatePutRequest exchangeRatePutRequest = null)

更新汇率

根据货币代码更新汇率信息。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrencyExchangeRatePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var code = "code_example";  // string | 货币代码
            var appKey = "appKey_example";  // string | 
            var exchangeRatePutRequest = new ExchangeRatePutRequest(); // ExchangeRatePutRequest | 汇率信息 (optional) 

            try
            {
                // 更新汇率
                Int64ApiResponse result = apiInstance.CurrencyExchangeRatePut(code, appKey, exchangeRatePutRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.CurrencyExchangeRatePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyExchangeRatePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新汇率
    ApiResponse<Int64ApiResponse> response = apiInstance.CurrencyExchangeRatePutWithHttpInfo(code, appKey, exchangeRatePutRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrencyExchangeRatePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | 货币代码 |  |
| **appKey** | **string** |  |  |
| **exchangeRatePutRequest** | [**ExchangeRatePutRequest**](ExchangeRatePutRequest.md) | 汇率信息 | [optional]  |

### Return type

[**Int64ApiResponse**](Int64ApiResponse.md)

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

<a id="currencyexchangerates"></a>
# **CurrencyExchangeRates**
> CurrencyExchangeRateApiResponse CurrencyExchangeRates (string code, string appKey)

获取汇率列表

根据货币代码获取该货币的汇率列表。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrencyExchangeRatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var code = "code_example";  // string | 货币代码
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取汇率列表
                CurrencyExchangeRateApiResponse result = apiInstance.CurrencyExchangeRates(code, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.CurrencyExchangeRates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyExchangeRatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取汇率列表
    ApiResponse<CurrencyExchangeRateApiResponse> response = apiInstance.CurrencyExchangeRatesWithHttpInfo(code, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrencyExchangeRatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** | 货币代码 |  |
| **appKey** | **string** |  |  |

### Return type

[**CurrencyExchangeRateApiResponse**](CurrencyExchangeRateApiResponse.md)

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

<a id="currencypost"></a>
# **CurrencyPost**
> Int64ApiResponse CurrencyPost (string appKey, Currency currency = null)

创建新货币

创建一个新的货币并返回其ID。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrencyPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var appKey = "appKey_example";  // string | 
            var currency = new Currency(); // Currency | 货币信息 (optional) 

            try
            {
                // 创建新货币
                Int64ApiResponse result = apiInstance.CurrencyPost(appKey, currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.CurrencyPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 创建新货币
    ApiResponse<Int64ApiResponse> response = apiInstance.CurrencyPostWithHttpInfo(appKey, currency);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrencyPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **currency** | [**Currency**](Currency.md) | 货币信息 | [optional]  |

### Return type

[**Int64ApiResponse**](Int64ApiResponse.md)

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

<a id="currencyput"></a>
# **CurrencyPut**
> BooleanApiResponse CurrencyPut (long id, string appKey, Currency currency = null)

更新货币信息

根据货币ID更新货币的详细信息。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrencyPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var id = 789L;  // long | 货币ID
            var appKey = "appKey_example";  // string | 
            var currency = new Currency(); // Currency | 货币信息 (optional) 

            try
            {
                // 更新货币信息
                BooleanApiResponse result = apiInstance.CurrencyPut(id, appKey, currency);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.CurrencyPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新货币信息
    ApiResponse<BooleanApiResponse> response = apiInstance.CurrencyPutWithHttpInfo(id, appKey, currency);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrencyPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 货币ID |  |
| **appKey** | **string** |  |  |
| **currency** | [**Currency**](Currency.md) | 货币信息 | [optional]  |

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

<a id="currencytransactions"></a>
# **CurrencyTransactions**
> CurrencyTransactionListApiResponse CurrencyTransactions (string appKey, long userId = null, string transType = null, string curCode = null, DateTime startTime = null, DateTime endTime = null, int skip = null, int take = null)

获取货币交易记录

根据用户ID、交易类型、货币代码、时间范围等条件获取货币交易记录。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class CurrencyTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CurrencyApi(config);
            var appKey = "appKey_example";  // string | 
            var userId = 789L;  // long | 用户ID (optional) 
            var transType = "transType_example";  // string | 交易类型 (optional) 
            var curCode = "curCode_example";  // string | 货币代码 (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 开始时间 (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 结束时间 (optional) 
            var skip = 56;  // int | 跳过的条数 (optional) 
            var take = 56;  // int | 拉取的条数 (optional) 

            try
            {
                // 获取货币交易记录
                CurrencyTransactionListApiResponse result = apiInstance.CurrencyTransactions(appKey, userId, transType, curCode, startTime, endTime, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrencyApi.CurrencyTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CurrencyTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取货币交易记录
    ApiResponse<CurrencyTransactionListApiResponse> response = apiInstance.CurrencyTransactionsWithHttpInfo(appKey, userId, transType, curCode, startTime, endTime, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrencyApi.CurrencyTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **userId** | **long** | 用户ID | [optional]  |
| **transType** | **string** | 交易类型 | [optional]  |
| **curCode** | **string** | 货币代码 | [optional]  |
| **startTime** | **DateTime** | 开始时间 | [optional]  |
| **endTime** | **DateTime** | 结束时间 | [optional]  |
| **skip** | **int** | 跳过的条数 | [optional]  |
| **take** | **int** | 拉取的条数 | [optional]  |

### Return type

[**CurrencyTransactionListApiResponse**](CurrencyTransactionListApiResponse.md)

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

