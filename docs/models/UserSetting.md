# ZSGF.Client.Model.UserSetting
用户配置实体，用于存储用户的个性化设置。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserID** | **long** | 关联的用户ID，表示该配置属于哪个用户。 | 
**Code** | **string** | 设置项的唯一代码或键名，用于标识具体的配置项。 | 
**Value** | **string** | 设置项的具体值或选项。 | 
**Id** | **long** | 用户的唯一标识符。 | [optional] 
**ProviderCode** | **string** | 提供商的唯一代码，用于标识服务提供者。 | [optional] 
**GroupCode** | **string** | 组的唯一代码，用于分类设置项。 | [optional] 
**Tags** | **string** | 用于对设置项进行分类或标记的标签。 | [optional] 
**Description** | **string** | 设置项的详细描述，说明其作用或用途。 | [optional] 
**FrontendUsable** | **bool** | 指示该设置项是否在前端界面中可用。 | [optional] 
**CreateDate** | **DateTime** | 设置项的创建时间。 | [optional] 
**LastUpdate** | **DateTime** | 设置项的最后更新时间。 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

