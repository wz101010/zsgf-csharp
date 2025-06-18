# ZSGF.Client.Model.UserAccessToken
用户令牌实体，用于管理用户的访问令牌及其相关信息。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | 用户令牌的唯一标识符。 | [optional] 
**UserID** | **long** | 与令牌关联的用户ID。 | [optional] 
**Enable** | **bool** | 指示令牌是否处于启用状态。 | [optional] 
**Permissions** | **string** | 令牌拥有的权限列表，多个权限以逗号分隔。 | [optional] 
**Title** | **string** | 令牌的标题或名称，用于标识令牌。 | [optional] 
**AccessToken** | **string** | 访问令牌的具体值，用于身份验证。 | [optional] 
**Tags** | **string** | 用于分类或标记令牌的标签。 | [optional] 
**Description** | **string** | 令牌的详细描述信息。 | [optional] 
**ExpireTime** | **DateTime** | 令牌的过期时间，超过该时间令牌将失效。 | [optional] 
**CreateDate** | **DateTime** | 令牌的创建日期，默认为当前时间。 | [optional] 
**LastUpdate** | **DateTime** | 令牌的最后更新日期，默认为当前时间。 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

