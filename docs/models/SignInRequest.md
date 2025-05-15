# ZSGF.Client.Model.SignInRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | 用户名，长度必须在6到32个字符之间，只能包含字母、数字、下划线和连字符 | 
**Pwd** | **string** | 用户密码，长度必须在6到50个字符之间，可以包含数字、大小写字母、下划线、连字符和特殊符号 | 
**TwoFactorCode** | **string** | 双因素认证代码，如果启用双因素认证登录，则必填，长度必须为6个字符，只能包含数字 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

