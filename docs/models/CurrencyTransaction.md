# ZSGF.Client.Model.CurrencyTransaction
货币交易记录实体，用于记录用户的货币交易详情。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | 货币交易记录的唯一标识符。 | [optional] 
**FromUserID** | **long** | 发起交易的发送方用户ID，若为转账交易时必填。 | [optional] 
**UserID** | **long** | 进行货币交易的用户ID。 | [optional] 
**TransactionType** | **string** | 货币交易的类型，例如 &#39;消费&#39;, &#39;奖励&#39;, &#39;兑换&#39;, &#39;转账&#39; 等。 | [optional] 
**CurrencyType** | **string** | 交易的货币类型，例如 &#39;USD&#39;, &#39;CNY&#39; 等。 | [optional] 
**CurrencyChange** | **long** | 货币的变动数量，正数表示增加，负数表示减少。 | [optional] 
**CurrencyBalance** | **double** | 交易完成后的货币余额。 | [optional] 
**Description** | **string** | 描述货币变动的具体原因或相关交易详情。 | [optional] 
**Status** | **string** | 货币交易的当前状态，例如 &#39;成功&#39;, &#39;失败&#39;, &#39;待审核&#39; 等。 | [optional] 
**Remark** | **string** | 交易的额外信息或管理员的备注。 | [optional] 
**Tags** | **string** | 用于分类或标记交易的标签。 | [optional] 
**CreateDate** | **DateTime** | 货币交易发生的时间，默认为当前时间。 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

