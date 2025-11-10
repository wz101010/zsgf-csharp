# ZSGF.Client.Api.UserFriendsApi

All URIs are relative to *https://api-dev.zashigaofa.cn*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UserCommonInterests**](UserFriendsApi.md#usercommoninterests) | **GET** /UserFriends/{appKey}/CommonInterests | 推荐相似兴趣用户 |
| [**UserFollowUser**](UserFriendsApi.md#userfollowuser) | **POST** /UserFriends/{appKey}/Follower/{userId} | 添加关注 |
| [**UserFollowerPut**](UserFriendsApi.md#userfollowerput) | **PUT** /UserFriends/{appKey}/Follower/{id} | 刷新粉丝数据 |
| [**UserFollowers**](UserFriendsApi.md#userfollowers) | **GET** /UserFriends/{appKey}/Followers | 获取粉丝列表 |
| [**UserFollowing**](UserFriendsApi.md#userfollowing) | **GET** /UserFriends/{appKey}/Following | 获取关注列表 / 判断是否关注 |
| [**UserFriendsNearBy**](UserFriendsApi.md#userfriendsnearby) | **GET** /UserFriends/{appKey}/NearBy | 推荐附近用户 |
| [**UserMutualFollowers**](UserFriendsApi.md#usermutualfollowers) | **GET** /UserFriends/{appKey}/MutualFollowers | 推荐共同粉丝用户 |
| [**UserMutualFollowings**](UserFriendsApi.md#usermutualfollowings) | **GET** /UserFriends/{appKey}/MutualFollowings | 推荐共同关注用户 |
| [**UserProfileById**](UserFriendsApi.md#userprofilebyid) | **GET** /UserFriends/{appKey}/Profile/{userId} | 获取用户资料 |
| [**UserUnfollowUser**](UserFriendsApi.md#userunfollowuser) | **DELETE** /UserFriends/{appKey}/Follower/{userId} | 取消关注 |

<a id="usercommoninterests"></a>
# **UserCommonInterests**
> UserCommonInterestsResultApiResponse UserCommonInterests (string appKey, string tag = null, int skip = null, int take = null, string userId = null)

推荐相似兴趣用户

推荐有共同爱好的用户

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var appKey = "appKey_example";  // string | 
            var tag = "tag_example";  // string | 兴趣标签 (optional) 
            var skip = 0;  // int | 跳过的记录数 (optional)  (default to 0)
            var take = 10;  // int | 获取的记录数 (optional)  (default to 10)
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 推荐相似兴趣用户
                UserCommonInterestsResultApiResponse result = apiInstance.UserCommonInterests(appKey, tag, skip, take, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserCommonInterests: " + e.Message);
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
    // 推荐相似兴趣用户
    ApiResponse<UserCommonInterestsResultApiResponse> response = apiInstance.UserCommonInterestsWithHttpInfo(appKey, tag, skip, take, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserCommonInterestsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **tag** | **string** | 兴趣标签 | [optional]  |
| **skip** | **int** | 跳过的记录数 | [optional] [default to 0] |
| **take** | **int** | 获取的记录数 | [optional] [default to 10] |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

[**UserCommonInterestsResultApiResponse**](UserCommonInterestsResultApiResponse.md)

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

<a id="userfollowuser"></a>
# **UserFollowUser**
> BooleanApiResponse UserFollowUser (long userId, string appKey, string fromUserId = null)

添加关注

关注指定用户

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var userId = 789L;  // long | 要关注的用户ID
            var appKey = "appKey_example";  // string | 
            var fromUserId = "fromUserId_example";  // string |  (optional) 

            try
            {
                // 添加关注
                BooleanApiResponse result = apiInstance.UserFollowUser(userId, appKey, fromUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserFollowUser: " + e.Message);
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
    // 添加关注
    ApiResponse<BooleanApiResponse> response = apiInstance.UserFollowUserWithHttpInfo(userId, appKey, fromUserId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserFollowUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | 要关注的用户ID |  |
| **appKey** | **string** |  |  |
| **fromUserId** | **string** |  | [optional]  |

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

<a id="userfollowerput"></a>
# **UserFollowerPut**
> BooleanApiResponse UserFollowerPut (long id, string appKey, FollowerPutModel followerPutModel = null)

刷新粉丝数据

根据粉丝ID更新粉丝信息

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var id = 789L;  // long | 粉丝ID
            var appKey = "appKey_example";  // string | 
            var followerPutModel = new FollowerPutModel(); // FollowerPutModel | 更新粉丝的请求参数 (optional) 

            try
            {
                // 刷新粉丝数据
                BooleanApiResponse result = apiInstance.UserFollowerPut(id, appKey, followerPutModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserFollowerPut: " + e.Message);
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
    // 刷新粉丝数据
    ApiResponse<BooleanApiResponse> response = apiInstance.UserFollowerPutWithHttpInfo(id, appKey, followerPutModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserFollowerPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | 粉丝ID |  |
| **appKey** | **string** |  |  |
| **followerPutModel** | [**FollowerPutModel**](FollowerPutModel.md) | 更新粉丝的请求参数 | [optional]  |

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

<a id="userfollowers"></a>
# **UserFollowers**
> UserFollowersResultApiResponse UserFollowers (string appKey, string tag = null, string status = null, long targetUserId = null, int skip = null, int take = null, string userId = null)

获取粉丝列表

根据条件获取我的粉丝列表

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var appKey = "appKey_example";  // string | 
            var tag = "tag_example";  // string | 标签 (optional) 
            var status = "status_example";  // string | 状态 (optional) 
            var targetUserId = 0L;  // long | 指定用户的粉丝 (optional)  (default to 0)
            var skip = 0;  // int | 跳过的记录数 (optional)  (default to 0)
            var take = 10;  // int | 获取的记录数 (optional)  (default to 10)
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 获取粉丝列表
                UserFollowersResultApiResponse result = apiInstance.UserFollowers(appKey, tag, status, targetUserId, skip, take, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserFollowers: " + e.Message);
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
    // 获取粉丝列表
    ApiResponse<UserFollowersResultApiResponse> response = apiInstance.UserFollowersWithHttpInfo(appKey, tag, status, targetUserId, skip, take, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **tag** | **string** | 标签 | [optional]  |
| **status** | **string** | 状态 | [optional]  |
| **targetUserId** | **long** | 指定用户的粉丝 | [optional] [default to 0] |
| **skip** | **int** | 跳过的记录数 | [optional] [default to 0] |
| **take** | **int** | 获取的记录数 | [optional] [default to 10] |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

[**UserFollowersResultApiResponse**](UserFollowersResultApiResponse.md)

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
> BooleanApiResponse UserFollowing (string appKey, string tag = null, string status = null, long targetUserId = null, int skip = null, int take = null, long checkUserId = null, bool onlyIDs = null, string userId = null)

获取关注列表 / 判断是否关注

根据条件获取我的关注列表，或判断是否关注某个用户

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var appKey = "appKey_example";  // string | 
            var tag = "tag_example";  // string | 用于过滤关注列表的标签（可选）。 (optional) 
            var status = "status_example";  // string | 用于过滤关注列表的状态（可选）。 (optional) 
            var targetUserId = 0L;  // long | 指定用户的关注记录，如果不提供则默认为当前用户的关注。 (optional)  (default to 0)
            var skip = 0;  // int | 跳过的记录数，用于分页（默认0）。 (optional)  (default to 0)
            var take = 10;  // int | 获取的记录数，用于分页（默认10）。 (optional)  (default to 10)
            var checkUserId = 789L;  // long | 要判断是否关注的目标用户ID。如果提供此参数，方法将返回一个布尔值，表示当前用户是否关注该目标用户。 (optional) 
            var onlyIDs = false;  // bool | 是否只返回关注用户的ID集合，默认为false（即返回完整的关注用户信息）。 (optional)  (default to false)
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 获取关注列表 / 判断是否关注
                BooleanApiResponse result = apiInstance.UserFollowing(appKey, tag, status, targetUserId, skip, take, checkUserId, onlyIDs, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserFollowing: " + e.Message);
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
    // 获取关注列表 / 判断是否关注
    ApiResponse<BooleanApiResponse> response = apiInstance.UserFollowingWithHttpInfo(appKey, tag, status, targetUserId, skip, take, checkUserId, onlyIDs, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserFollowingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **tag** | **string** | 用于过滤关注列表的标签（可选）。 | [optional]  |
| **status** | **string** | 用于过滤关注列表的状态（可选）。 | [optional]  |
| **targetUserId** | **long** | 指定用户的关注记录，如果不提供则默认为当前用户的关注。 | [optional] [default to 0] |
| **skip** | **int** | 跳过的记录数，用于分页（默认0）。 | [optional] [default to 0] |
| **take** | **int** | 获取的记录数，用于分页（默认10）。 | [optional] [default to 10] |
| **checkUserId** | **long** | 要判断是否关注的目标用户ID。如果提供此参数，方法将返回一个布尔值，表示当前用户是否关注该目标用户。 | [optional]  |
| **onlyIDs** | **bool** | 是否只返回关注用户的ID集合，默认为false（即返回完整的关注用户信息）。 | [optional] [default to false] |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

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

<a id="userfriendsnearby"></a>
# **UserFriendsNearBy**
> UserFriendsNearByResultApiResponse UserFriendsNearBy (double longitude, double latitude, string appKey, string country = null, string state = null, string city = null, string district = null, string gender = null, int ageS = null, int ageE = null, string tag = null, long distance = null, int skip = null, int take = null, string userId = null)

推荐附近用户

根据地理位置坐标和多种筛选条件，查询附近满足条件的用户列表，支持分页和按距离排序。 地理位置查询使用MySQL的ST_Distance_Sphere函数计算球面距离。 注意：longitude为经度(X轴)，latitude为纬度(Y轴)，参数顺序与常规坐标系一致

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var longitude = 1.2D;  // double | 当前用户经度坐标(WGS84坐标系)
            var latitude = 1.2D;  // double | 当前用户纬度坐标(WGS84坐标系)
            var appKey = "appKey_example";  // string | 
            var country = "country_example";  // string | 国家过滤条件（精确匹配） (optional) 
            var state = "state_example";  // string | 省份过滤条件（精确匹配） (optional) 
            var city = "city_example";  // string | 城市过滤条件（精确匹配） (optional) 
            var district = "district_example";  // string | 区县过滤条件（精确匹配） (optional) 
            var gender = "gender_example";  // string | 性别过滤条件（可选值示例：Male/Female/Other） (optional) 
            var ageS = 56;  // int | 年龄起始范围（包含，0表示不限制） (optional) 
            var ageE = 56;  // int | 年龄结束范围（包含，0表示不限制） (optional) 
            var tag = "tag_example";  // string | 兴趣标签过滤（支持模糊匹配，如：\"运动\"） (optional) 
            var distance = 0L;  // long | 搜索半径（单位：米，0表示不限制距离） (optional)  (default to 0)
            var skip = 0;  // int | 跳过的记录数（分页起始位置，默认0） (optional)  (default to 0)
            var take = 10;  // int | 获取的记录数（分页大小，默认10，最大100） (optional)  (default to 10)
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 推荐附近用户
                UserFriendsNearByResultApiResponse result = apiInstance.UserFriendsNearBy(longitude, latitude, appKey, country, state, city, district, gender, ageS, ageE, tag, distance, skip, take, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserFriendsNearBy: " + e.Message);
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
    // 推荐附近用户
    ApiResponse<UserFriendsNearByResultApiResponse> response = apiInstance.UserFriendsNearByWithHttpInfo(longitude, latitude, appKey, country, state, city, district, gender, ageS, ageE, tag, distance, skip, take, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserFriendsNearByWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **longitude** | **double** | 当前用户经度坐标(WGS84坐标系) |  |
| **latitude** | **double** | 当前用户纬度坐标(WGS84坐标系) |  |
| **appKey** | **string** |  |  |
| **country** | **string** | 国家过滤条件（精确匹配） | [optional]  |
| **state** | **string** | 省份过滤条件（精确匹配） | [optional]  |
| **city** | **string** | 城市过滤条件（精确匹配） | [optional]  |
| **district** | **string** | 区县过滤条件（精确匹配） | [optional]  |
| **gender** | **string** | 性别过滤条件（可选值示例：Male/Female/Other） | [optional]  |
| **ageS** | **int** | 年龄起始范围（包含，0表示不限制） | [optional]  |
| **ageE** | **int** | 年龄结束范围（包含，0表示不限制） | [optional]  |
| **tag** | **string** | 兴趣标签过滤（支持模糊匹配，如：\&quot;运动\&quot;） | [optional]  |
| **distance** | **long** | 搜索半径（单位：米，0表示不限制距离） | [optional] [default to 0] |
| **skip** | **int** | 跳过的记录数（分页起始位置，默认0） | [optional] [default to 0] |
| **take** | **int** | 获取的记录数（分页大小，默认10，最大100） | [optional] [default to 10] |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

[**UserFriendsNearByResultApiResponse**](UserFriendsNearByResultApiResponse.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 返回推荐用户列表数据 |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="usermutualfollowers"></a>
# **UserMutualFollowers**
> UserMutualFollowersResultApiResponse UserMutualFollowers (string appKey, int skip = null, int take = null, string userId = null)

推荐共同粉丝用户

推荐有共同粉丝的用户

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var appKey = "appKey_example";  // string | 
            var skip = 0;  // int | 跳过的记录数 (optional)  (default to 0)
            var take = 10;  // int | 获取的记录数 (optional)  (default to 10)
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 推荐共同粉丝用户
                UserMutualFollowersResultApiResponse result = apiInstance.UserMutualFollowers(appKey, skip, take, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserMutualFollowers: " + e.Message);
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
    // 推荐共同粉丝用户
    ApiResponse<UserMutualFollowersResultApiResponse> response = apiInstance.UserMutualFollowersWithHttpInfo(appKey, skip, take, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserMutualFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **skip** | **int** | 跳过的记录数 | [optional] [default to 0] |
| **take** | **int** | 获取的记录数 | [optional] [default to 10] |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

[**UserMutualFollowersResultApiResponse**](UserMutualFollowersResultApiResponse.md)

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
> UserMutualFollowingsResultApiResponse UserMutualFollowings (string appKey, int skip = null, int take = null, string userId = null)

推荐共同关注用户

推荐有共同关注的用户

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var appKey = "appKey_example";  // string | 
            var skip = 0;  // int | 跳过的记录数 (optional)  (default to 0)
            var take = 10;  // int | 获取的记录数 (optional)  (default to 10)
            var userId = "\"\"";  // string |  (optional)  (default to "")

            try
            {
                // 推荐共同关注用户
                UserMutualFollowingsResultApiResponse result = apiInstance.UserMutualFollowings(appKey, skip, take, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserMutualFollowings: " + e.Message);
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
    // 推荐共同关注用户
    ApiResponse<UserMutualFollowingsResultApiResponse> response = apiInstance.UserMutualFollowingsWithHttpInfo(appKey, skip, take, userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserMutualFollowingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appKey** | **string** |  |  |
| **skip** | **int** | 跳过的记录数 | [optional] [default to 0] |
| **take** | **int** | 获取的记录数 | [optional] [default to 10] |
| **userId** | **string** |  | [optional] [default to &quot;&quot;] |

### Return type

[**UserMutualFollowingsResultApiResponse**](UserMutualFollowingsResultApiResponse.md)

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

<a id="userprofilebyid"></a>
# **UserProfileById**
> GetUserProfileResultApiResponse UserProfileById (long userId, string appKey)

获取用户资料

用于他人主页展示

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using ZSGF.Client.Api;
using ZSGF.Client.Client;
using ZSGF.Client.Model;

namespace Example
{
    public class UserProfileByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var userId = 789L;  // long | 用户ID
            var appKey = "appKey_example";  // string | 

            try
            {
                // 获取用户资料
                GetUserProfileResultApiResponse result = apiInstance.UserProfileById(userId, appKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserProfileById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserProfileByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // 获取用户资料
    ApiResponse<GetUserProfileResultApiResponse> response = apiInstance.UserProfileByIdWithHttpInfo(userId, appKey);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserProfileByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | 用户ID |  |
| **appKey** | **string** |  |  |

### Return type

[**GetUserProfileResultApiResponse**](GetUserProfileResultApiResponse.md)

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
> BooleanApiResponse UserUnfollowUser (long userId, string appKey, string fromUserId = null)

取消关注

取消关注指定用户

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
            config.BasePath = "https://api-dev.zashigaofa.cn";
            // Configure Bearer token for authorization: Bearer
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new UserFriendsApi(config);
            var userId = 789L;  // long | 要取消关注的用户ID
            var appKey = "appKey_example";  // string | 
            var fromUserId = "fromUserId_example";  // string |  (optional) 

            try
            {
                // 取消关注
                BooleanApiResponse result = apiInstance.UserUnfollowUser(userId, appKey, fromUserId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserFriendsApi.UserUnfollowUser: " + e.Message);
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
    ApiResponse<BooleanApiResponse> response = apiInstance.UserUnfollowUserWithHttpInfo(userId, appKey, fromUserId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserFriendsApi.UserUnfollowUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | 要取消关注的用户ID |  |
| **appKey** | **string** |  |  |
| **fromUserId** | **string** |  | [optional]  |

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

