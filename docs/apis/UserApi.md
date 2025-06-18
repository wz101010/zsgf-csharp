# ZSGF.Client.Api.UserApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserDeactivateHard**](UserApi.md#userdeactivatehard) | **DELETE** /User/{appKey}/DeactivateHard | 注销账号 |
| [**UserEmailSignIn**](UserApi.md#useremailsignin) | **POST** /User/{appKey}/EmailSignIn | 邮箱登录 |
| [**UserEmailSignUp**](UserApi.md#useremailsignup) | **POST** /User/{appKey}/EmailSignUp | 邮箱注册 |
| [**UserPhoneSignIn**](UserApi.md#userphonesignin) | **POST** /User/{appKey}/PhoneSignIn | 手机登录 |
| [**UserPhoneSignUp**](UserApi.md#userphonesignup) | **POST** /User/{appKey}/PhoneSignUp | 手机注册 |
| [**UserProfile**](UserApi.md#userprofile) | **GET** /User/{appKey}/Profile | 获取个人资料 |
| [**UserResetEmail**](UserApi.md#userresetemail) | **PUT** /User/{appKey}/ResetEmail | 重置邮箱 |
| [**UserResetPhone**](UserApi.md#userresetphone) | **PUT** /User/{appKey}/ResetPhone | 重置手机号 |
| [**UserResetPwd**](UserApi.md#userresetpwd) | **POST** /User/{appKey}/ResetPwd | 重置密码 |
| [**UserSendEmailCode**](UserApi.md#usersendemailcode) | **POST** /User/{appKey}/SendEmailCode | 发送邮箱验证码 |
| [**UserSendSMSCode**](UserApi.md#usersendsmscode) | **POST** /User/{appKey}/SendSMSCode | 发送手机验证码 |
| [**UserSignIn**](UserApi.md#usersignin) | **POST** /User/{appKey}/SignIn | 密码登录 |
| [**UserSignUp**](UserApi.md#usersignup) | **POST** /User/{appKey}/SignUp | 账号注册 |
| [**UserTwoFactorAuth**](UserApi.md#usertwofactorauth) | **GET** /User/{appKey}/TwoFactorAuth | 二次验证 |
| [**UserUnionIDSignIn**](UserApi.md#userunionidsignin) | **POST** /User/{appKey}/UnionIDSignIn | UnionID登录 |
| [**UserUnionIDSignUp**](UserApi.md#userunionidsignup) | **POST** /User/{appKey}/UnionIDSignUp | UnionID注册 |
| [**UserUpdateProfile**](UserApi.md#userupdateprofile) | **PUT** /User/{appKey}/Profile | 更新个人资料 |

<a id="userdeactivatehard"></a>
# **UserDeactivateHard**
> BooleanApiResponse UserDeactivateHard (string appKey)

注销账号

清除用户所有附属数据，并注销账号

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserDeactivateHardExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 注销账号
                BooleanApiResponse result = apiInstance.UserDeactivateHard(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserDeactivateHard: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserDeactivateHardWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 注销账号
    ApiResponse<BooleanApiResponse> response = apiInstance.UserDeactivateHardWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserDeactivateHardWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="useremailsignin"></a>
# **UserEmailSignIn**
> TokenModelApiResponse UserEmailSignIn (string appKey, EmailSignInRequest emailSignInRequest = null)

邮箱登录

使用邮箱进行登录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserEmailSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var emailSignInRequest = new EmailSignInRequest(); // EmailSignInRequest | 登录请求参数 (optional) 

            try
            {
                // 邮箱登录
                TokenModelApiResponse result = apiInstance.UserEmailSignIn(appKey, emailSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserEmailSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserEmailSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 邮箱登录
    ApiResponse<TokenModelApiResponse> response = apiInstance.UserEmailSignInWithHttpInfo(appKey, emailSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserEmailSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **emailSignInRequest** | [**EmailSignInRequest**](EmailSignInRequest.md) | 登录请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="useremailsignup"></a>
# **UserEmailSignUp**
> TokenModelApiResponse UserEmailSignUp (string appKey, EmailSignUpRequest emailSignUpRequest = null)

邮箱注册

使用邮箱进行注册

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserEmailSignUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var emailSignUpRequest = new EmailSignUpRequest(); // EmailSignUpRequest | 注册请求参数 (optional) 

            try
            {
                // 邮箱注册
                TokenModelApiResponse result = apiInstance.UserEmailSignUp(appKey, emailSignUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserEmailSignUp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserEmailSignUpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 邮箱注册
    ApiResponse<TokenModelApiResponse> response = apiInstance.UserEmailSignUpWithHttpInfo(appKey, emailSignUpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserEmailSignUpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **emailSignUpRequest** | [**EmailSignUpRequest**](EmailSignUpRequest.md) | 注册请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="userphonesignin"></a>
# **UserPhoneSignIn**
> TokenModelApiResponse UserPhoneSignIn (string appKey, PhoneSignInRequest phoneSignInRequest = null)

手机登录

使用手机号码进行登录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserPhoneSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var phoneSignInRequest = new PhoneSignInRequest(); // PhoneSignInRequest | 登录请求参数 (optional) 

            try
            {
                // 手机登录
                TokenModelApiResponse result = apiInstance.UserPhoneSignIn(appKey, phoneSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserPhoneSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPhoneSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 手机登录
    ApiResponse<TokenModelApiResponse> response = apiInstance.UserPhoneSignInWithHttpInfo(appKey, phoneSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserPhoneSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **phoneSignInRequest** | [**PhoneSignInRequest**](PhoneSignInRequest.md) | 登录请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="userphonesignup"></a>
# **UserPhoneSignUp**
> TokenModelApiResponse UserPhoneSignUp (string appKey, PhoneSignUpRequest phoneSignUpRequest = null)

手机注册

使用手机号码进行注册

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserPhoneSignUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var phoneSignUpRequest = new PhoneSignUpRequest(); // PhoneSignUpRequest | 注册请求参数 (optional) 

            try
            {
                // 手机注册
                TokenModelApiResponse result = apiInstance.UserPhoneSignUp(appKey, phoneSignUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserPhoneSignUp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPhoneSignUpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 手机注册
    ApiResponse<TokenModelApiResponse> response = apiInstance.UserPhoneSignUpWithHttpInfo(appKey, phoneSignUpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserPhoneSignUpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **phoneSignUpRequest** | [**PhoneSignUpRequest**](PhoneSignUpRequest.md) | 注册请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="userprofile"></a>
# **UserProfile**
> UserProfileResultApiResponse UserProfile (string appKey)

获取个人资料

获取当前用户的个人资料

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取个人资料
                UserProfileResultApiResponse result = apiInstance.UserProfile(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取个人资料
    ApiResponse<UserProfileResultApiResponse> response = apiInstance.UserProfileWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

### Return type

[**UserProfileResultApiResponse**](UserProfileResultApiResponse.md)

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

<a id="userresetemail"></a>
# **UserResetEmail**
> BooleanApiResponse UserResetEmail (string appKey, AppUserResetEmailRequest appUserResetEmailRequest = null)

重置邮箱

通过邮箱验证码重置邮箱

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserResetEmailExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var appUserResetEmailRequest = new AppUserResetEmailRequest(); // AppUserResetEmailRequest | 重置邮箱的请求参数 (optional) 

            try
            {
                // 重置邮箱
                BooleanApiResponse result = apiInstance.UserResetEmail(appKey, appUserResetEmailRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserResetEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserResetEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 重置邮箱
    ApiResponse<BooleanApiResponse> response = apiInstance.UserResetEmailWithHttpInfo(appKey, appUserResetEmailRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserResetEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **appUserResetEmailRequest** | [**AppUserResetEmailRequest**](AppUserResetEmailRequest.md) | 重置邮箱的请求参数 | [optional]  |

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

<a id="userresetphone"></a>
# **UserResetPhone**
> BooleanApiResponse UserResetPhone (string appKey, AppUserResetPhoneRequest appUserResetPhoneRequest = null)

重置手机号

通过手机号验证码重置手机号

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserResetPhoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var appUserResetPhoneRequest = new AppUserResetPhoneRequest(); // AppUserResetPhoneRequest | 重置手机号的请求参数 (optional) 

            try
            {
                // 重置手机号
                BooleanApiResponse result = apiInstance.UserResetPhone(appKey, appUserResetPhoneRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserResetPhone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserResetPhoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 重置手机号
    ApiResponse<BooleanApiResponse> response = apiInstance.UserResetPhoneWithHttpInfo(appKey, appUserResetPhoneRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserResetPhoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **appUserResetPhoneRequest** | [**AppUserResetPhoneRequest**](AppUserResetPhoneRequest.md) | 重置手机号的请求参数 | [optional]  |

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

<a id="userresetpwd"></a>
# **UserResetPwd**
> BooleanApiResponse UserResetPwd (string appKey, AppUserResetPwdRequest appUserResetPwdRequest = null)

重置密码

通过手机号或邮箱重置密码

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserResetPwdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var appUserResetPwdRequest = new AppUserResetPwdRequest(); // AppUserResetPwdRequest | 重置密码的请求参数 (optional) 

            try
            {
                // 重置密码
                BooleanApiResponse result = apiInstance.UserResetPwd(appKey, appUserResetPwdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserResetPwd: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserResetPwdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 重置密码
    ApiResponse<BooleanApiResponse> response = apiInstance.UserResetPwdWithHttpInfo(appKey, appUserResetPwdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserResetPwdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **appUserResetPwdRequest** | [**AppUserResetPwdRequest**](AppUserResetPwdRequest.md) | 重置密码的请求参数 | [optional]  |

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

<a id="usersendemailcode"></a>
# **UserSendEmailCode**
> BooleanApiResponse UserSendEmailCode (string appKey, SendEmailCodeRequest sendEmailCodeRequest = null)

发送邮箱验证码

发送邮箱验证码用于注册或找回密码

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSendEmailCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var sendEmailCodeRequest = new SendEmailCodeRequest(); // SendEmailCodeRequest | 发送邮箱验证码的请求参数 (optional) 

            try
            {
                // 发送邮箱验证码
                BooleanApiResponse result = apiInstance.UserSendEmailCode(appKey, sendEmailCodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSendEmailCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSendEmailCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发送邮箱验证码
    ApiResponse<BooleanApiResponse> response = apiInstance.UserSendEmailCodeWithHttpInfo(appKey, sendEmailCodeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSendEmailCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **sendEmailCodeRequest** | [**SendEmailCodeRequest**](SendEmailCodeRequest.md) | 发送邮箱验证码的请求参数 | [optional]  |

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

<a id="usersendsmscode"></a>
# **UserSendSMSCode**
> BooleanApiResponse UserSendSMSCode (string appKey, SendSMSCodeRequest sendSMSCodeRequest = null)

发送手机验证码

发送手机验证码用于注册或找回密码

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSendSMSCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var sendSMSCodeRequest = new SendSMSCodeRequest(); // SendSMSCodeRequest | 发送手机验证码的请求参数 (optional) 

            try
            {
                // 发送手机验证码
                BooleanApiResponse result = apiInstance.UserSendSMSCode(appKey, sendSMSCodeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSendSMSCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSendSMSCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 发送手机验证码
    ApiResponse<BooleanApiResponse> response = apiInstance.UserSendSMSCodeWithHttpInfo(appKey, sendSMSCodeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSendSMSCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **sendSMSCodeRequest** | [**SendSMSCodeRequest**](SendSMSCodeRequest.md) | 发送手机验证码的请求参数 | [optional]  |

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

<a id="usersignin"></a>
# **UserSignIn**
> TokenModelApiResponse UserSignIn (string appKey, SignInRequest signInRequest = null)

密码登录

使用账号密码进行登录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var signInRequest = new SignInRequest(); // SignInRequest | 登录请求参数 (optional) 

            try
            {
                // 密码登录
                TokenModelApiResponse result = apiInstance.UserSignIn(appKey, signInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 密码登录
    ApiResponse<TokenModelApiResponse> response = apiInstance.UserSignInWithHttpInfo(appKey, signInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **signInRequest** | [**SignInRequest**](SignInRequest.md) | 登录请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="usersignup"></a>
# **UserSignUp**
> TokenModelApiResponse UserSignUp (string appKey, SignUpRequest signUpRequest = null)

账号注册

使用账号密码进行注册

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserSignUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var signUpRequest = new SignUpRequest(); // SignUpRequest | 注册请求参数 (optional) 

            try
            {
                // 账号注册
                TokenModelApiResponse result = apiInstance.UserSignUp(appKey, signUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSignUp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSignUpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 账号注册
    ApiResponse<TokenModelApiResponse> response = apiInstance.UserSignUpWithHttpInfo(appKey, signUpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSignUpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **signUpRequest** | [**SignUpRequest**](SignUpRequest.md) | 注册请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="usertwofactorauth"></a>
# **UserTwoFactorAuth**
> SetupCodeApiResponse UserTwoFactorAuth (string appKey)

二次验证

获取当前用户在指定应用下启用二次验证（2FA）所需的设置信息，主要包括二维码链接和手动密钥，用户可以将其录入在 Google Authenticator 等 TOTP 应用中，用于后续动态验证码验证。

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserTwoFactorAuthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 二次验证
                SetupCodeApiResponse result = apiInstance.UserTwoFactorAuth(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserTwoFactorAuth: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserTwoFactorAuthWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 二次验证
    ApiResponse<SetupCodeApiResponse> response = apiInstance.UserTwoFactorAuthWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserTwoFactorAuthWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

### Return type

[**SetupCodeApiResponse**](SetupCodeApiResponse.md)

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

<a id="userunionidsignin"></a>
# **UserUnionIDSignIn**
> TokenModelApiResponse UserUnionIDSignIn (string appKey, UnionIDSignInRequest unionIDSignInRequest = null)

UnionID登录

使用UnionID进行登录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserUnionIDSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var unionIDSignInRequest = new UnionIDSignInRequest(); // UnionIDSignInRequest | 登录请求参数 (optional) 

            try
            {
                // UnionID登录
                TokenModelApiResponse result = apiInstance.UserUnionIDSignIn(appKey, unionIDSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserUnionIDSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserUnionIDSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UnionID登录
    ApiResponse<TokenModelApiResponse> response = apiInstance.UserUnionIDSignInWithHttpInfo(appKey, unionIDSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserUnionIDSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **unionIDSignInRequest** | [**UnionIDSignInRequest**](UnionIDSignInRequest.md) | 登录请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="userunionidsignup"></a>
# **UserUnionIDSignUp**
> TokenModelApiResponse UserUnionIDSignUp (string appKey, UnionIDSignUpRequest unionIDSignUpRequest = null)

UnionID注册

使用UnionID进行注册

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserUnionIDSignUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var unionIDSignUpRequest = new UnionIDSignUpRequest(); // UnionIDSignUpRequest | 注册请求参数 (optional) 

            try
            {
                // UnionID注册
                TokenModelApiResponse result = apiInstance.UserUnionIDSignUp(appKey, unionIDSignUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserUnionIDSignUp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserUnionIDSignUpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UnionID注册
    ApiResponse<TokenModelApiResponse> response = apiInstance.UserUnionIDSignUpWithHttpInfo(appKey, unionIDSignUpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserUnionIDSignUpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **unionIDSignUpRequest** | [**UnionIDSignUpRequest**](UnionIDSignUpRequest.md) | 注册请求参数 | [optional]  |

### Return type

[**TokenModelApiResponse**](TokenModelApiResponse.md)

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

<a id="userupdateprofile"></a>
# **UserUpdateProfile**
> BooleanApiResponse UserUpdateProfile (string appKey, UpdateProfileRequest updateProfileRequest = null)

更新个人资料

更新当前用户的个人资料

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserUpdateProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var updateProfileRequest = new UpdateProfileRequest(); // UpdateProfileRequest | 更新个人资料的请求参数 (optional) 

            try
            {
                // 更新个人资料
                BooleanApiResponse result = apiInstance.UserUpdateProfile(appKey, updateProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserUpdateProfile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserUpdateProfileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新个人资料
    ApiResponse<BooleanApiResponse> response = apiInstance.UserUpdateProfileWithHttpInfo(appKey, updateProfileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserUpdateProfileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **updateProfileRequest** | [**UpdateProfileRequest**](UpdateProfileRequest.md) | 更新个人资料的请求参数 | [optional]  |

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

