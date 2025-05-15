# ZSGF.Client.Model.Settings
公共配置存储实体，用于集中管理系统的配置项。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | 配置项的唯一标识符。 | [optional] 
**BizCode** | **string** | 配置项所属的业务代码，用于分类管理。 | [optional] 
**BizIdentity** | **string** | 配置项所属的业务标识，用于唯一标识业务。 | [optional] 
**ProviderCode** | **string** | 配置项的提供者代码，用于标识配置来源。 | [optional] 
**GroupCode** | **string** | 配置项的分组代码，用于组织和管理相关配置。 | [optional] 
**Code** | **string** | 配置项的唯一代码，用于标识具体的配置项。 | [optional] 
**Value** | **string** | 配置项的具体值，存储配置内容。 | [optional] 
**Tags** | **string** | 用于分类或标记配置项的标签。 | [optional] 
**Description** | **string** | 配置项的详细描述，说明其用途和作用。 | [optional] 
**FrontendUsable** | **bool** | 指示该配置项是否可供前端使用。 | [optional] 
**CreateDate** | **DateTime** | 配置项的创建日期，默认为当前时间。 | [optional] 
**LastUpdate** | **DateTime** | 配置项的最后更新日期，默认为当前时间。 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

