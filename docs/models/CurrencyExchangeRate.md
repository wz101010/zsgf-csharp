# ZSGF.Client.Model.CurrencyExchangeRate
货币兑换比率实体，用于表示不同货币之间的兑换关系。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | 货币兑换比率的唯一标识符。 | [optional] 
**FromCurrencyCode** | **string** | 兑换的源货币代码，例如 &#39;USD&#39;。 | [optional] 
**ToCurrencyCode** | **string** | 兑换的目标货币代码，例如 &#39;CNY&#39;。 | [optional] 
**ExchangeRate** | **long** | 从源货币到目标货币的兑换比率。例如，1 USD &#x3D; 6.5 CNY。 | [optional] 
**Description** | **string** | 兑换比率的详细描述信息。 | [optional] 
**CreateDate** | **DateTime** | 货币兑换比率的创建日期，默认为当前时间。 | [optional] 
**LastUpdate** | **DateTime** | 货币兑换比率的最后更新日期，默认为当前时间。 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

