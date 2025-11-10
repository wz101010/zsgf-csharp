# ZSGF.Client.Api.DingTalkApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DingTalkUserInfo**](DingTalkApi.md#dingtalkuserinfo) | **GET** /DingTalk/{appKey}/UserInfo | 获取用户资料 |

<a id="dingtalkuserinfo"></a>
# **DingTalkUserInfo**
> StringApiResponse DingTalkUserInfo (string appKey, string code = null)

获取用户资料

根据钉钉用户授权码获取用户的详细资料。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class DingTalkUserInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DingTalkApi(config);
            var appKey = "appKey_example";  // string | 
            var code = "code_example";  // string | 钉钉用户授权码 (optional) 

            try
            {
                // 获取用户资料
                StringApiResponse result = apiInstance.DingTalkUserInfo(appKey, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DingTalkApi.DingTalkUserInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DingTalkUserInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取用户资料
    ApiResponse<StringApiResponse> response = apiInstance.DingTalkUserInfoWithHttpInfo(appKey, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DingTalkApi.DingTalkUserInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **code** | **string** | 钉钉用户授权码 | [optional]  |

### Return type

[**StringApiResponse**](StringApiResponse.md)

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

