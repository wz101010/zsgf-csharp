# ZSGF.Client.Model.Currency
货币实体，用于表示和管理不同类型的货币信息。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | 货币的唯一标识符。 | [optional] 
**Name** | **string** | 货币的名称，例如 &#39;人民币&#39;, &#39;美元&#39; 等。 | [optional] 
**Code** | **string** | 货币的ISO标准代码，例如 &#39;CNY&#39;, &#39;USD&#39; 等。 | [optional] 
**Symbol** | **string** | 货币的符号，例如 &#39;$&#39;, &#39;€&#39;, &#39;¥&#39; 等。 | [optional] 
**Issuer** | **string** | 发行该货币的机构或国家名称。 | [optional] 
**CurrencyType** | **string** | 货币的类型，例如 &#39;法定货币&#39;, &#39;加密货币&#39; 等。 | [optional] 
**Tags** | **string** | 用于分类或标记货币的标签。 | [optional] 
**Status** | **bool** | 指示货币当前是否可用。 | [optional] 
**EnableVirtualRecharge** | **bool** | 指示该货币是否允许进行虚拟充值。 | [optional] 
**EnableVirtualConsume** | **bool** | 指示该货币是否允许进行虚拟消费。 | [optional] 
**Description** | **string** | 货币的详细描述信息。 | [optional] 
**FiatExchangeRate** | **long** | 该货币与法定货币的兑换比率。 | [optional] 
**FiatDailyRechargeLimit** | **long** | 每日通过法定货币充值的最大限额。 | [optional] 
**TotalSupply** | **long** | 货币的总供应量，0 表示无限制。 | [optional] 
**CreateDate** | **DateTime** | 货币记录的创建日期，默认为当前时间。 | [optional] 
**LastUpdate** | **DateTime** | 货币记录的最后更新日期，默认为当前时间。 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

