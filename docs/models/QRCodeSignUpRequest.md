# ZSGF.Client.Model.QRCodeSignUpRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnionID** | **string** | UnionID，长度必须在1到50个字符之间，只能包含字母、数字、下划线和连字符 | 
**SignInKey** | **long** | 登录密钥 | [optional] 
**NickName** | **string** | 用户昵称 | [optional] 
**Avatar** | **string** | 用户头像URL | [optional] 
**Data** | **string** | 自定义数据 | [optional] 
**Email** | **string** | 用户邮箱 | [optional] 
**EmailCode** | **string** | 邮箱验证码（只有启用的邮箱验证码功能时，才需要传入），长度为4到8位的数字 | [optional] 
**Phone** | **string** | 用户手机号，必须为11位数字 | [optional] 
**PhoneCode** | **string** | 手机验证码（只有启用的手机验证码功能时，才需要传入），长度为4到8位的数字 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

