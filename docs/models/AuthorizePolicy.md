# ZSGF.Client.Model.AuthorizePolicy
鉴权策略实体，用于定义和管理系统的鉴权规则。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | 鉴权策略的唯一标识符。 | [optional] 
**PolicyName** | **string** | 鉴权策略的名称。根据鉴权类型填写不同的名称：角色类型填写角色名称，用户类型填写用户ID，访问令牌类型填写令牌ID。 | [optional] 
**AuthorizeType** | **string** | 鉴权策略的类型，可选值为 &#39;access_token&#39;, &#39;user&#39;, 或 &#39;role&#39;。 | [optional] 
**PolicyValue** | **string** | 与鉴权策略关联的权限集合，多个权限可以用逗号分隔。 | [optional] 
**CreateDate** | **DateTime** | 鉴权策略的创建日期，默认为当前时间。 | [optional] 
**LastUpdate** | **DateTime** | 鉴权策略的最后更新日期，默认为当前时间。 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

