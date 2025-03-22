# ZSGF.Client.Api.UserApi

All URIs are relative to *https://api-staging.paomo.fun*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**User**](UserApi.md#user) | **GET** /User/{appKey}/{id} | 用户详情 |
| [**UserClear**](UserApi.md#userclear) | **DELETE** /User/{appKey}/Clear | 清空用户数据 |
| [**UserCommonInterests**](UserApi.md#usercommoninterests) | **GET** /User/{appKey}/Friends/CommonInterests | 有共同爱好的用户推荐 |
| [**UserDelete**](UserApi.md#userdelete) | **DELETE** /User/{appKey}/{id} | 删除用户 |
| [**UserEmailSignIn**](UserApi.md#useremailsignin) | **POST** /User/{appKey}/EmailSignIn | 邮箱登录 |
| [**UserEmailSignUp**](UserApi.md#useremailsignup) | **POST** /User/{appKey}/EmailSignUp | 邮箱注册 |
| [**UserExport**](UserApi.md#userexport) | **GET** /User/{appKey}/Export | 导出用户数据 |
| [**UserFollowUser**](UserApi.md#userfollowuser) | **POST** /User/{appKey}/Follower/{userId} | 关注用户 |
| [**UserFollowerPut**](UserApi.md#userfollowerput) | **PUT** /User/{appKey}/Follower/{id} | 更新粉丝 |
| [**UserFollowers**](UserApi.md#userfollowers) | **GET** /User/{appKey}/Followers | 我的粉丝 |
| [**UserFollowing**](UserApi.md#userfollowing) | **GET** /User/{appKey}/Following | 我的关注 |
| [**UserFriendsNearBy**](UserApi.md#userfriendsnearby) | **GET** /User/{appKey}/Friends/NearBy | 附近的用户推荐 |
| [**UserImport**](UserApi.md#userimport) | **POST** /User/{appKey}/Import | 导入用户数据 |
| [**UserLocation**](UserApi.md#userlocation) | **GET** /User/{appKey}/Location/{id} | 位置详情 |
| [**UserLocationDelete**](UserApi.md#userlocationdelete) | **DELETE** /User/{appKey}/Location/{id} | 删除位置 |
| [**UserLocationPost**](UserApi.md#userlocationpost) | **POST** /User/{appKey}/Location | 添加位置 |
| [**UserLocationPut**](UserApi.md#userlocationput) | **PUT** /User/{appKey}/Location/{id} | 更新位置 |
| [**UserLocations**](UserApi.md#userlocations) | **GET** /User/{appKey}/Locations | 位置列表 |
| [**UserMutualFollowers**](UserApi.md#usermutualfollowers) | **GET** /User/{appKey}/Friends/MutualFollowers | 有共同粉丝的用户推荐 |
| [**UserMutualFollowings**](UserApi.md#usermutualfollowings) | **GET** /User/{appKey}/Friends/MutualFollowings | 有共同关注的用户推荐 |
| [**UserOAuthAccountBind**](UserApi.md#useroauthaccountbind) | **POST** /User/{appKey}/OAuthAccountBind | 外部账号 绑定 |
| [**UserOAuthAccountSignIn**](UserApi.md#useroauthaccountsignin) | **POST** /User/{appKey}/OAuthAccountSignIn | 外部账号 登录 |
| [**UserOAuthAccounts**](UserApi.md#useroauthaccounts) | **GET** /User/{appKey}/OAuthAccounts | 外部账号 绑定列表 |
| [**UserOAuthAccountsPutBind**](UserApi.md#useroauthaccountsputbind) | **PUT** /User/{appKey}/OAuthAccounts/{id} | 外部账号 更新绑定 |
| [**UserOAuthAccountsUnBind**](UserApi.md#useroauthaccountsunbind) | **DELETE** /User/{appKey}/OAuthAccounts/{id} | 外部账号 删除绑定 |
| [**UserPhoneSignIn**](UserApi.md#userphonesignin) | **POST** /User/{appKey}/PhoneSignIn | 手机登录 |
| [**UserPhoneSignUp**](UserApi.md#userphonesignup) | **POST** /User/{appKey}/PhoneSignUp | 手机注册 |
| [**UserProfile**](UserApi.md#userprofile) | **GET** /User/{appKey}/Profile | 获取个人资料 |
| [**UserPut**](UserApi.md#userput) | **PUT** /User/{appKey}/{id} | 更新用户 |
| [**UserQRCodePreSignIn**](UserApi.md#userqrcodepresignin) | **POST** /User/{appKey}/QRCodePreSignIn | 微信小程序 - 预登陆 |
| [**UserQRCodeScan**](UserApi.md#userqrcodescan) | **POST** /User/{appKey}/QRCodeScan | 微信小程序 - 扫码 |
| [**UserQRCodeSignIn**](UserApi.md#userqrcodesignin) | **POST** /User/{appKey}/QRCodeSignIn | 微信小程序 - 网页登录 |
| [**UserQRCodeSignUp**](UserApi.md#userqrcodesignup) | **POST** /User/{appKey}/QRCodeSignUp | 微信小程序 - 注册 |
| [**UserResetPwd**](UserApi.md#userresetpwd) | **POST** /User/{appKey}/ResetPwd | 重置密码 |
| [**UserSendEmailCode**](UserApi.md#usersendemailcode) | **POST** /User/{appKey}/SendEmailCode | 发送邮箱验证码 |
| [**UserSendSMSCode**](UserApi.md#usersendsmscode) | **POST** /User/{appKey}/SendSMSCode | 发送手机验证码 |
| [**UserSignIn**](UserApi.md#usersignin) | **POST** /User/{appKey}/SignIn | 账号密码 登录 |
| [**UserSignUp**](UserApi.md#usersignup) | **POST** /User/{appKey}/SignUp | 账号密码 注册 |
| [**UserTwoFactorAuth**](UserApi.md#usertwofactorauth) | **GET** /User/{appKey}/TwoFactorAuth | 双因素验证 |
| [**UserUnfollowUser**](UserApi.md#userunfollowuser) | **DELETE** /User/{appKey}/Follower/{userId} | 取消关注 |
| [**UserUnionIDSignIn**](UserApi.md#userunionidsignin) | **POST** /User/{appKey}/UnionIDSignIn | UnionID登录 |
| [**UserUnionIDSignUp**](UserApi.md#userunionidsignup) | **POST** /User/{appKey}/UnionIDSignUp | UnionID注册 |
| [**UserUpdateProfile**](UserApi.md#userupdateprofile) | **PUT** /User/{appKey}/Profile | 更新个人资料 |
| [**Users**](UserApi.md#users) | **GET** /User/{appKey} | 用户列表 |

<a id="user"></a>
# **User**
> JObjectApiResult User (long id, string appKey)

用户详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 用户详情
                JObjectApiResult result = apiInstance.User(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.User: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 用户详情
    ApiResponse<JObjectApiResult> response = apiInstance.UserWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

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

<a id="userclear"></a>
# **UserClear**
> JObjectApiResult UserClear (string appKey)

清空用户数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserClearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 清空用户数据
                JObjectApiResult result = apiInstance.UserClear(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserClear: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserClearWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 清空用户数据
    ApiResponse<JObjectApiResult> response = apiInstance.UserClearWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserClearWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

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

<a id="usercommoninterests"></a>
# **UserCommonInterests**
> JObjectApiResult UserCommonInterests (string appKey, string tag = null, int skip = null, int take = null)

有共同爱好的用户推荐

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserCommonInterestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var tag = "tag_example";  // string |  (optional) 
            var skip = 0;  // int |  (optional)  (default to 0)
            var take = 10;  // int |  (optional)  (default to 10)

            try
            {
                // 有共同爱好的用户推荐
                JObjectApiResult result = apiInstance.UserCommonInterests(appKey, tag, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCommonInterests: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCommonInterestsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 有共同爱好的用户推荐
    ApiResponse<JObjectApiResult> response = apiInstance.UserCommonInterestsWithHttpInfo(appKey, tag, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCommonInterestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **tag** | **string** |  | [optional]  |
| **skip** | **int** |  | [optional] [default to 0] |
| **take** | **int** |  | [optional] [default to 10] |

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

<a id="userdelete"></a>
# **UserDelete**
> JObjectApiResult UserDelete (long id, string appKey)

删除用户

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除用户
                JObjectApiResult result = apiInstance.UserDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除用户
    ApiResponse<JObjectApiResult> response = apiInstance.UserDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

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

<a id="useremailsignin"></a>
# **UserEmailSignIn**
> JObjectApiResult UserEmailSignIn (string appKey, EmailSignInRequest emailSignInRequest = null)

邮箱登录

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var emailSignInRequest = new EmailSignInRequest(); // EmailSignInRequest |  (optional) 

            try
            {
                // 邮箱登录
                JObjectApiResult result = apiInstance.UserEmailSignIn(appKey, emailSignInRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserEmailSignInWithHttpInfo(appKey, emailSignInRequest);
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
| **emailSignInRequest** | [**EmailSignInRequest**](EmailSignInRequest.md) |  | [optional]  |

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

<a id="useremailsignup"></a>
# **UserEmailSignUp**
> JObjectApiResult UserEmailSignUp (string appKey, EmailSignUpRequest emailSignUpRequest = null)

邮箱注册

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var emailSignUpRequest = new EmailSignUpRequest(); // EmailSignUpRequest |  (optional) 

            try
            {
                // 邮箱注册
                JObjectApiResult result = apiInstance.UserEmailSignUp(appKey, emailSignUpRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserEmailSignUpWithHttpInfo(appKey, emailSignUpRequest);
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
| **emailSignUpRequest** | [**EmailSignUpRequest**](EmailSignUpRequest.md) |  | [optional]  |

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

<a id="userexport"></a>
# **UserExport**
> System.IO.Stream UserExport (string appKey)

导出用户数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 导出用户数据
                System.IO.Stream result = apiInstance.UserExport(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 导出用户数据
    ApiResponse<System.IO.Stream> response = apiInstance.UserExportWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

### Return type

**System.IO.Stream**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.openxmlformats-officedocument.spreadsheetml.sheet


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="userfollowuser"></a>
# **UserFollowUser**
> JObjectApiResult UserFollowUser (long userId, string appKey)

关注用户

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserFollowUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var userId = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 关注用户
                JObjectApiResult result = apiInstance.UserFollowUser(userId, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserFollowUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserFollowUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 关注用户
    ApiResponse<JObjectApiResult> response = apiInstance.UserFollowUserWithHttpInfo(userId, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserFollowUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** |  |  |
| **appKey** | **string** |  |  |

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

<a id="userfollowerput"></a>
# **UserFollowerPut**
> JObjectApiResult UserFollowerPut (long id, string appKey, FollowerPutModel followerPutModel = null)

更新粉丝

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserFollowerPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var followerPutModel = new FollowerPutModel(); // FollowerPutModel |  (optional) 

            try
            {
                // 更新粉丝
                JObjectApiResult result = apiInstance.UserFollowerPut(id, appKey, followerPutModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserFollowerPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserFollowerPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新粉丝
    ApiResponse<JObjectApiResult> response = apiInstance.UserFollowerPutWithHttpInfo(id, appKey, followerPutModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserFollowerPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **followerPutModel** | [**FollowerPutModel**](FollowerPutModel.md) |  | [optional]  |

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

<a id="userfollowers"></a>
# **UserFollowers**
> JObjectApiResult UserFollowers (string appKey, string tag = null, string status = null, int skip = null, int take = null)

我的粉丝

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var tag = "tag_example";  // string |  (optional) 
            var status = "status_example";  // string |  (optional) 
            var skip = 0;  // int |  (optional)  (default to 0)
            var take = 10;  // int |  (optional)  (default to 10)

            try
            {
                // 我的粉丝
                JObjectApiResult result = apiInstance.UserFollowers(appKey, tag, status, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 我的粉丝
    ApiResponse<JObjectApiResult> response = apiInstance.UserFollowersWithHttpInfo(appKey, tag, status, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **tag** | **string** |  | [optional]  |
| **status** | **string** |  | [optional]  |
| **skip** | **int** |  | [optional] [default to 0] |
| **take** | **int** |  | [optional] [default to 10] |

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

<a id="userfollowing"></a>
# **UserFollowing**
> JObjectApiResult UserFollowing (string appKey, string tag = null, string status = null, int skip = null, int take = null)

我的关注

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserFollowingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var tag = "tag_example";  // string |  (optional) 
            var status = "status_example";  // string |  (optional) 
            var skip = 0;  // int |  (optional)  (default to 0)
            var take = 10;  // int |  (optional)  (default to 10)

            try
            {
                // 我的关注
                JObjectApiResult result = apiInstance.UserFollowing(appKey, tag, status, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserFollowing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserFollowingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 我的关注
    ApiResponse<JObjectApiResult> response = apiInstance.UserFollowingWithHttpInfo(appKey, tag, status, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserFollowingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **tag** | **string** |  | [optional]  |
| **status** | **string** |  | [optional]  |
| **skip** | **int** |  | [optional] [default to 0] |
| **take** | **int** |  | [optional] [default to 10] |

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

<a id="userfriendsnearby"></a>
# **UserFriendsNearBy**
> JObjectApiResult UserFriendsNearBy (double x, double y, long distance, string appKey, string gender = null, int ageS = null, int ageE = null, string tag = null, string type = null, int skip = null, int take = null)

附近的用户推荐

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserFriendsNearByExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var x = 1.2D;  // double | 纬度
            var y = 1.2D;  // double | 经度
            var distance = 789L;  // long | 附近距离，单位：米
            var appKey = "appKey_example";  // string | 
            var gender = "gender_example";  // string | 性别 (optional) 
            var ageS = 56;  // int | 年龄段 (optional) 
            var ageE = 56;  // int | 年龄段 (optional) 
            var tag = "tag_example";  // string | 标签 (optional) 
            var type = "type_example";  // string | 分类 (optional) 
            var skip = 0;  // int |  (optional)  (default to 0)
            var take = 10;  // int |  (optional)  (default to 10)

            try
            {
                // 附近的用户推荐
                JObjectApiResult result = apiInstance.UserFriendsNearBy(x, y, distance, appKey, gender, ageS, ageE, tag, type, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserFriendsNearBy: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserFriendsNearByWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 附近的用户推荐
    ApiResponse<JObjectApiResult> response = apiInstance.UserFriendsNearByWithHttpInfo(x, y, distance, appKey, gender, ageS, ageE, tag, type, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserFriendsNearByWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **x** | **double** | 纬度 |  |
| **y** | **double** | 经度 |  |
| **distance** | **long** | 附近距离，单位：米 |  |
| **appKey** | **string** |  |  |
| **gender** | **string** | 性别 | [optional]  |
| **ageS** | **int** | 年龄段 | [optional]  |
| **ageE** | **int** | 年龄段 | [optional]  |
| **tag** | **string** | 标签 | [optional]  |
| **type** | **string** | 分类 | [optional]  |
| **skip** | **int** |  | [optional] [default to 0] |
| **take** | **int** |  | [optional] [default to 10] |

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

<a id="userimport"></a>
# **UserImport**
> JObjectApiResult UserImport (string appKey, bool check = null, System.IO.Stream file = null)

导入用户数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserImportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var check = true;  // bool |  (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream |  (optional) 

            try
            {
                // 导入用户数据
                JObjectApiResult result = apiInstance.UserImport(appKey, check, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserImport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserImportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 导入用户数据
    ApiResponse<JObjectApiResult> response = apiInstance.UserImportWithHttpInfo(appKey, check, file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserImportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **check** | **bool** |  | [optional]  |
| **file** | **System.IO.Stream****System.IO.Stream** |  | [optional]  |

### Return type

[**JObjectApiResult**](JObjectApiResult.md)

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

<a id="userlocation"></a>
# **UserLocation**
> JObjectApiResult UserLocation (long id, string appKey)

位置详情

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 位置详情
                JObjectApiResult result = apiInstance.UserLocation(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserLocation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 位置详情
    ApiResponse<JObjectApiResult> response = apiInstance.UserLocationWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserLocationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

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

<a id="userlocationdelete"></a>
# **UserLocationDelete**
> JObjectApiResult UserLocationDelete (long id, string appKey)

删除位置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 删除位置
                JObjectApiResult result = apiInstance.UserLocationDelete(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserLocationDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 删除位置
    ApiResponse<JObjectApiResult> response = apiInstance.UserLocationDeleteWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserLocationDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

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

<a id="userlocationpost"></a>
# **UserLocationPost**
> JObjectApiResult UserLocationPost (string appKey, GeoLocationModel geoLocationModel = null)

添加位置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var geoLocationModel = new GeoLocationModel(); // GeoLocationModel |  (optional) 

            try
            {
                // 添加位置
                JObjectApiResult result = apiInstance.UserLocationPost(appKey, geoLocationModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserLocationPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 添加位置
    ApiResponse<JObjectApiResult> response = apiInstance.UserLocationPostWithHttpInfo(appKey, geoLocationModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserLocationPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **geoLocationModel** | [**GeoLocationModel**](GeoLocationModel.md) |  | [optional]  |

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

<a id="userlocationput"></a>
# **UserLocationPut**
> JObjectApiResult UserLocationPut (long id, string appKey, GeoLocationModel geoLocationModel = null)

更新位置

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var geoLocationModel = new GeoLocationModel(); // GeoLocationModel |  (optional) 

            try
            {
                // 更新位置
                JObjectApiResult result = apiInstance.UserLocationPut(id, appKey, geoLocationModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserLocationPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新位置
    ApiResponse<JObjectApiResult> response = apiInstance.UserLocationPutWithHttpInfo(id, appKey, geoLocationModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserLocationPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **geoLocationModel** | [**GeoLocationModel**](GeoLocationModel.md) |  | [optional]  |

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

<a id="userlocations"></a>
# **UserLocations**
> JObjectApiResult UserLocations (string appKey, string tag = null, string type = null, double x = null, double y = null, long sphere = null, int skip = null, int take = null)

位置列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserLocationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var tag = "tag_example";  // string | 标签 (optional) 
            var type = "type_example";  // string | 分类 (optional) 
            var x = 1.2D;  // double | 纬度 (optional) 
            var y = 1.2D;  // double | 经度 (optional) 
            var sphere = 789L;  // long | 附近距离，单位：米 (optional) 
            var skip = 56;  // int |  (optional) 
            var take = 10;  // int |  (optional)  (default to 10)

            try
            {
                // 位置列表
                JObjectApiResult result = apiInstance.UserLocations(appKey, tag, type, x, y, sphere, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserLocations: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserLocationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 位置列表
    ApiResponse<JObjectApiResult> response = apiInstance.UserLocationsWithHttpInfo(appKey, tag, type, x, y, sphere, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserLocationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **tag** | **string** | 标签 | [optional]  |
| **type** | **string** | 分类 | [optional]  |
| **x** | **double** | 纬度 | [optional]  |
| **y** | **double** | 经度 | [optional]  |
| **sphere** | **long** | 附近距离，单位：米 | [optional]  |
| **skip** | **int** |  | [optional]  |
| **take** | **int** |  | [optional] [default to 10] |

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

<a id="usermutualfollowers"></a>
# **UserMutualFollowers**
> JObjectApiResult UserMutualFollowers (string appKey, int skip = null, int take = null)

有共同粉丝的用户推荐

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserMutualFollowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var skip = 0;  // int |  (optional)  (default to 0)
            var take = 10;  // int |  (optional)  (default to 10)

            try
            {
                // 有共同粉丝的用户推荐
                JObjectApiResult result = apiInstance.UserMutualFollowers(appKey, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserMutualFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserMutualFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 有共同粉丝的用户推荐
    ApiResponse<JObjectApiResult> response = apiInstance.UserMutualFollowersWithHttpInfo(appKey, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserMutualFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **skip** | **int** |  | [optional] [default to 0] |
| **take** | **int** |  | [optional] [default to 10] |

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

<a id="usermutualfollowings"></a>
# **UserMutualFollowings**
> JObjectApiResult UserMutualFollowings (string appKey, int skip = null, int take = null)

有共同关注的用户推荐

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserMutualFollowingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var skip = 0;  // int |  (optional)  (default to 0)
            var take = 10;  // int |  (optional)  (default to 10)

            try
            {
                // 有共同关注的用户推荐
                JObjectApiResult result = apiInstance.UserMutualFollowings(appKey, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserMutualFollowings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserMutualFollowingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 有共同关注的用户推荐
    ApiResponse<JObjectApiResult> response = apiInstance.UserMutualFollowingsWithHttpInfo(appKey, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserMutualFollowingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **skip** | **int** |  | [optional] [default to 0] |
| **take** | **int** |  | [optional] [default to 10] |

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

<a id="useroauthaccountbind"></a>
# **UserOAuthAccountBind**
> JObjectApiResult UserOAuthAccountBind (string appKey, OAuthAccountBindRequest oAuthAccountBindRequest = null)

外部账号 绑定

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserOAuthAccountBindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var oAuthAccountBindRequest = new OAuthAccountBindRequest(); // OAuthAccountBindRequest |  (optional) 

            try
            {
                // 外部账号 绑定
                JObjectApiResult result = apiInstance.UserOAuthAccountBind(appKey, oAuthAccountBindRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserOAuthAccountBind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserOAuthAccountBindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部账号 绑定
    ApiResponse<JObjectApiResult> response = apiInstance.UserOAuthAccountBindWithHttpInfo(appKey, oAuthAccountBindRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserOAuthAccountBindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **oAuthAccountBindRequest** | [**OAuthAccountBindRequest**](OAuthAccountBindRequest.md) |  | [optional]  |

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

<a id="useroauthaccountsignin"></a>
# **UserOAuthAccountSignIn**
> JObjectApiResult UserOAuthAccountSignIn (string appKey, OAuthAccountSignInRequest oAuthAccountSignInRequest = null)

外部账号 登录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserOAuthAccountSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var oAuthAccountSignInRequest = new OAuthAccountSignInRequest(); // OAuthAccountSignInRequest |  (optional) 

            try
            {
                // 外部账号 登录
                JObjectApiResult result = apiInstance.UserOAuthAccountSignIn(appKey, oAuthAccountSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserOAuthAccountSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserOAuthAccountSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部账号 登录
    ApiResponse<JObjectApiResult> response = apiInstance.UserOAuthAccountSignInWithHttpInfo(appKey, oAuthAccountSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserOAuthAccountSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **oAuthAccountSignInRequest** | [**OAuthAccountSignInRequest**](OAuthAccountSignInRequest.md) |  | [optional]  |

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

<a id="useroauthaccounts"></a>
# **UserOAuthAccounts**
> JObjectApiResult UserOAuthAccounts (string appKey)

外部账号 绑定列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserOAuthAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 外部账号 绑定列表
                JObjectApiResult result = apiInstance.UserOAuthAccounts(appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserOAuthAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserOAuthAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部账号 绑定列表
    ApiResponse<JObjectApiResult> response = apiInstance.UserOAuthAccountsWithHttpInfo(appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserOAuthAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |

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

<a id="useroauthaccountsputbind"></a>
# **UserOAuthAccountsPutBind**
> JObjectApiResult UserOAuthAccountsPutBind (long id, string appKey, OAuthAccountPutBindRequest oAuthAccountPutBindRequest = null)

外部账号 更新绑定

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserOAuthAccountsPutBindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var oAuthAccountPutBindRequest = new OAuthAccountPutBindRequest(); // OAuthAccountPutBindRequest |  (optional) 

            try
            {
                // 外部账号 更新绑定
                JObjectApiResult result = apiInstance.UserOAuthAccountsPutBind(id, appKey, oAuthAccountPutBindRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserOAuthAccountsPutBind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserOAuthAccountsPutBindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部账号 更新绑定
    ApiResponse<JObjectApiResult> response = apiInstance.UserOAuthAccountsPutBindWithHttpInfo(id, appKey, oAuthAccountPutBindRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserOAuthAccountsPutBindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **oAuthAccountPutBindRequest** | [**OAuthAccountPutBindRequest**](OAuthAccountPutBindRequest.md) |  | [optional]  |

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

<a id="useroauthaccountsunbind"></a>
# **UserOAuthAccountsUnBind**
> JObjectApiResult UserOAuthAccountsUnBind (long id, string appKey)

外部账号 删除绑定

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserOAuthAccountsUnBindExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 外部账号 删除绑定
                JObjectApiResult result = apiInstance.UserOAuthAccountsUnBind(id, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserOAuthAccountsUnBind: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserOAuthAccountsUnBindWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 外部账号 删除绑定
    ApiResponse<JObjectApiResult> response = apiInstance.UserOAuthAccountsUnBindWithHttpInfo(id, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserOAuthAccountsUnBindWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |

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

<a id="userphonesignin"></a>
# **UserPhoneSignIn**
> JObjectApiResult UserPhoneSignIn (string appKey, PhoneSignInRequest phoneSignInRequest = null)

手机登录

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var phoneSignInRequest = new PhoneSignInRequest(); // PhoneSignInRequest |  (optional) 

            try
            {
                // 手机登录
                JObjectApiResult result = apiInstance.UserPhoneSignIn(appKey, phoneSignInRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserPhoneSignInWithHttpInfo(appKey, phoneSignInRequest);
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
| **phoneSignInRequest** | [**PhoneSignInRequest**](PhoneSignInRequest.md) |  | [optional]  |

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

<a id="userphonesignup"></a>
# **UserPhoneSignUp**
> JObjectApiResult UserPhoneSignUp (string appKey, PhoneSignUpRequest phoneSignUpRequest = null)

手机注册

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var phoneSignUpRequest = new PhoneSignUpRequest(); // PhoneSignUpRequest |  (optional) 

            try
            {
                // 手机注册
                JObjectApiResult result = apiInstance.UserPhoneSignUp(appKey, phoneSignUpRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserPhoneSignUpWithHttpInfo(appKey, phoneSignUpRequest);
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
| **phoneSignUpRequest** | [**PhoneSignUpRequest**](PhoneSignUpRequest.md) |  | [optional]  |

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

<a id="userprofile"></a>
# **UserProfile**
> JObjectApiResult UserProfile (string appKey)

获取个人资料

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取个人资料
                JObjectApiResult result = apiInstance.UserProfile(appKey);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserProfileWithHttpInfo(appKey);
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

<a id="userput"></a>
# **UserPut**
> JObjectApiResult UserPut (long id, string appKey, User user = null)

更新用户

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | 
            var appKey = "appKey_example";  // string | 
            var user = new User(); // User |  (optional) 

            try
            {
                // 更新用户
                JObjectApiResult result = apiInstance.UserPut(id, appKey, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 更新用户
    ApiResponse<JObjectApiResult> response = apiInstance.UserPutWithHttpInfo(id, appKey, user);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** |  |  |
| **appKey** | **string** |  |  |
| **user** | [**User**](User.md) |  | [optional]  |

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

<a id="userqrcodepresignin"></a>
# **UserQRCodePreSignIn**
> JObjectApiResult UserQRCodePreSignIn (string appKey, QRCodePreSignInRequest qRCodePreSignInRequest = null)

微信小程序 - 预登陆

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserQRCodePreSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var qRCodePreSignInRequest = new QRCodePreSignInRequest(); // QRCodePreSignInRequest |  (optional) 

            try
            {
                // 微信小程序 - 预登陆
                JObjectApiResult result = apiInstance.UserQRCodePreSignIn(appKey, qRCodePreSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserQRCodePreSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserQRCodePreSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 微信小程序 - 预登陆
    ApiResponse<JObjectApiResult> response = apiInstance.UserQRCodePreSignInWithHttpInfo(appKey, qRCodePreSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserQRCodePreSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **qRCodePreSignInRequest** | [**QRCodePreSignInRequest**](QRCodePreSignInRequest.md) |  | [optional]  |

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

<a id="userqrcodescan"></a>
# **UserQRCodeScan**
> JObjectApiResult UserQRCodeScan (string appKey, QRCodeScanRequest qRCodeScanRequest = null)

微信小程序 - 扫码

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserQRCodeScanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var qRCodeScanRequest = new QRCodeScanRequest(); // QRCodeScanRequest |  (optional) 

            try
            {
                // 微信小程序 - 扫码
                JObjectApiResult result = apiInstance.UserQRCodeScan(appKey, qRCodeScanRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserQRCodeScan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserQRCodeScanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 微信小程序 - 扫码
    ApiResponse<JObjectApiResult> response = apiInstance.UserQRCodeScanWithHttpInfo(appKey, qRCodeScanRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserQRCodeScanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **qRCodeScanRequest** | [**QRCodeScanRequest**](QRCodeScanRequest.md) |  | [optional]  |

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

<a id="userqrcodesignin"></a>
# **UserQRCodeSignIn**
> JObjectApiResult UserQRCodeSignIn (string appKey, QRCodeSignInRequest qRCodeSignInRequest = null)

微信小程序 - 网页登录

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserQRCodeSignInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var qRCodeSignInRequest = new QRCodeSignInRequest(); // QRCodeSignInRequest |  (optional) 

            try
            {
                // 微信小程序 - 网页登录
                JObjectApiResult result = apiInstance.UserQRCodeSignIn(appKey, qRCodeSignInRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserQRCodeSignIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserQRCodeSignInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 微信小程序 - 网页登录
    ApiResponse<JObjectApiResult> response = apiInstance.UserQRCodeSignInWithHttpInfo(appKey, qRCodeSignInRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserQRCodeSignInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **qRCodeSignInRequest** | [**QRCodeSignInRequest**](QRCodeSignInRequest.md) |  | [optional]  |

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

<a id="userqrcodesignup"></a>
# **UserQRCodeSignUp**
> JObjectApiResult UserQRCodeSignUp (string appKey, QRCodeSignUpRequest qRCodeSignUpRequest = null)

微信小程序 - 注册

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserQRCodeSignUpExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var qRCodeSignUpRequest = new QRCodeSignUpRequest(); // QRCodeSignUpRequest |  (optional) 

            try
            {
                // 微信小程序 - 注册
                JObjectApiResult result = apiInstance.UserQRCodeSignUp(appKey, qRCodeSignUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserQRCodeSignUp: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserQRCodeSignUpWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 微信小程序 - 注册
    ApiResponse<JObjectApiResult> response = apiInstance.UserQRCodeSignUpWithHttpInfo(appKey, qRCodeSignUpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserQRCodeSignUpWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **qRCodeSignUpRequest** | [**QRCodeSignUpRequest**](QRCodeSignUpRequest.md) |  | [optional]  |

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

<a id="userresetpwd"></a>
# **UserResetPwd**
> JObjectApiResult UserResetPwd (string appKey, AppUserResetPwdRequest appUserResetPwdRequest = null)

重置密码

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var appUserResetPwdRequest = new AppUserResetPwdRequest(); // AppUserResetPwdRequest |  (optional) 

            try
            {
                // 重置密码
                JObjectApiResult result = apiInstance.UserResetPwd(appKey, appUserResetPwdRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserResetPwdWithHttpInfo(appKey, appUserResetPwdRequest);
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
| **appUserResetPwdRequest** | [**AppUserResetPwdRequest**](AppUserResetPwdRequest.md) |  | [optional]  |

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

<a id="usersendemailcode"></a>
# **UserSendEmailCode**
> JObjectApiResult UserSendEmailCode (string appKey, SendEmailCodeRequest sendEmailCodeRequest = null)

发送邮箱验证码

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var sendEmailCodeRequest = new SendEmailCodeRequest(); // SendEmailCodeRequest |  (optional) 

            try
            {
                // 发送邮箱验证码
                JObjectApiResult result = apiInstance.UserSendEmailCode(appKey, sendEmailCodeRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserSendEmailCodeWithHttpInfo(appKey, sendEmailCodeRequest);
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
| **sendEmailCodeRequest** | [**SendEmailCodeRequest**](SendEmailCodeRequest.md) |  | [optional]  |

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

<a id="usersendsmscode"></a>
# **UserSendSMSCode**
> JObjectApiResult UserSendSMSCode (string appKey, SendSMSCodeRequest sendSMSCodeRequest = null)

发送手机验证码

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var sendSMSCodeRequest = new SendSMSCodeRequest(); // SendSMSCodeRequest |  (optional) 

            try
            {
                // 发送手机验证码
                JObjectApiResult result = apiInstance.UserSendSMSCode(appKey, sendSMSCodeRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserSendSMSCodeWithHttpInfo(appKey, sendSMSCodeRequest);
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
| **sendSMSCodeRequest** | [**SendSMSCodeRequest**](SendSMSCodeRequest.md) |  | [optional]  |

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

<a id="usersignin"></a>
# **UserSignIn**
> JObjectApiResult UserSignIn (string appKey, SignInRequest signInRequest = null)

账号密码 登录

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var signInRequest = new SignInRequest(); // SignInRequest |  (optional) 

            try
            {
                // 账号密码 登录
                JObjectApiResult result = apiInstance.UserSignIn(appKey, signInRequest);
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
    // 账号密码 登录
    ApiResponse<JObjectApiResult> response = apiInstance.UserSignInWithHttpInfo(appKey, signInRequest);
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
| **signInRequest** | [**SignInRequest**](SignInRequest.md) |  | [optional]  |

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

<a id="usersignup"></a>
# **UserSignUp**
> JObjectApiResult UserSignUp (string appKey, SignUpRequest signUpRequest = null)

账号密码 注册

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var signUpRequest = new SignUpRequest(); // SignUpRequest |  (optional) 

            try
            {
                // 账号密码 注册
                JObjectApiResult result = apiInstance.UserSignUp(appKey, signUpRequest);
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
    // 账号密码 注册
    ApiResponse<JObjectApiResult> response = apiInstance.UserSignUpWithHttpInfo(appKey, signUpRequest);
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
| **signUpRequest** | [**SignUpRequest**](SignUpRequest.md) |  | [optional]  |

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

<a id="usertwofactorauth"></a>
# **UserTwoFactorAuth**
> JObjectApiResult UserTwoFactorAuth (string appKey)

双因素验证

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 

            try
            {
                // 双因素验证
                JObjectApiResult result = apiInstance.UserTwoFactorAuth(appKey);
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
    // 双因素验证
    ApiResponse<JObjectApiResult> response = apiInstance.UserTwoFactorAuthWithHttpInfo(appKey);
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

<a id="userunfollowuser"></a>
# **UserUnfollowUser**
> JObjectApiResult UserUnfollowUser (long userId, string appKey)

取消关注

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserUnfollowUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var userId = 789L;  // long | 
            var appKey = "appKey_example";  // string | 

            try
            {
                // 取消关注
                JObjectApiResult result = apiInstance.UserUnfollowUser(userId, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserUnfollowUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserUnfollowUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 取消关注
    ApiResponse<JObjectApiResult> response = apiInstance.UserUnfollowUserWithHttpInfo(userId, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserUnfollowUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** |  |  |
| **appKey** | **string** |  |  |

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

<a id="userunionidsignin"></a>
# **UserUnionIDSignIn**
> JObjectApiResult UserUnionIDSignIn (string appKey, UnionIDSignInRequest unionIDSignInRequest = null)

UnionID登录

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var unionIDSignInRequest = new UnionIDSignInRequest(); // UnionIDSignInRequest |  (optional) 

            try
            {
                // UnionID登录
                JObjectApiResult result = apiInstance.UserUnionIDSignIn(appKey, unionIDSignInRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserUnionIDSignInWithHttpInfo(appKey, unionIDSignInRequest);
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
| **unionIDSignInRequest** | [**UnionIDSignInRequest**](UnionIDSignInRequest.md) |  | [optional]  |

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

<a id="userunionidsignup"></a>
# **UserUnionIDSignUp**
> JObjectApiResult UserUnionIDSignUp (string appKey, UnionIDSignUpRequest unionIDSignUpRequest = null)

UnionID注册

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var unionIDSignUpRequest = new UnionIDSignUpRequest(); // UnionIDSignUpRequest |  (optional) 

            try
            {
                // UnionID注册
                JObjectApiResult result = apiInstance.UserUnionIDSignUp(appKey, unionIDSignUpRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserUnionIDSignUpWithHttpInfo(appKey, unionIDSignUpRequest);
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
| **unionIDSignUpRequest** | [**UnionIDSignUpRequest**](UnionIDSignUpRequest.md) |  | [optional]  |

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

<a id="userupdateprofile"></a>
# **UserUpdateProfile**
> JObjectApiResult UserUpdateProfile (string appKey, UpdateProfileRequest updateProfileRequest = null)

更新个人资料

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
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var updateProfileRequest = new UpdateProfileRequest(); // UpdateProfileRequest |  (optional) 

            try
            {
                // 更新个人资料
                JObjectApiResult result = apiInstance.UserUpdateProfile(appKey, updateProfileRequest);
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
    ApiResponse<JObjectApiResult> response = apiInstance.UserUpdateProfileWithHttpInfo(appKey, updateProfileRequest);
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
| **updateProfileRequest** | [**UpdateProfileRequest**](UpdateProfileRequest.md) |  | [optional]  |

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

<a id="users"></a>
# **Users**
> JObjectApiResult Users (string appKey, string userName = null, string email = null, string phone = null, string platform = null, string unionId = null, string role = null, int skip = null, int take = null)

用户列表

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-staging.paomo.fun";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserApi(config);
            var appKey = "appKey_example";  // string | 
            var userName = "userName_example";  // string |  (optional) 
            var email = "email_example";  // string |  (optional) 
            var phone = "phone_example";  // string |  (optional) 
            var platform = "platform_example";  // string |  (optional) 
            var unionId = "unionId_example";  // string |  (optional) 
            var role = "role_example";  // string |  (optional) 
            var skip = 56;  // int |  (optional) 
            var take = 56;  // int |  (optional) 

            try
            {
                // 用户列表
                JObjectApiResult result = apiInstance.Users(appKey, userName, email, phone, platform, unionId, role, skip, take);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.Users: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 用户列表
    ApiResponse<JObjectApiResult> response = apiInstance.UsersWithHttpInfo(appKey, userName, email, phone, platform, unionId, role, skip, take);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **userName** | **string** |  | [optional]  |
| **email** | **string** |  | [optional]  |
| **phone** | **string** |  | [optional]  |
| **platform** | **string** |  | [optional]  |
| **unionId** | **string** |  | [optional]  |
| **role** | **string** |  | [optional]  |
| **skip** | **int** |  | [optional]  |
| **take** | **int** |  | [optional]  |

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

