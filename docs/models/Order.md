# ZSGF.Client.Model.Order
订单实体，用于记录用户的订单信息。

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | 订单的唯一标识符。 | [optional] 
**UserID** | **long** | 创建订单的用户ID。 | [optional] 
**PayType** | **string** | 订单的支付类型，例如 &#39;信用卡&#39;, &#39;支付宝&#39;, &#39;微信支付&#39; 等。 | [optional] 
**Amount** | **double** | 订单的总金额。 | [optional] 
**OrderNo** | **string** | 订单的唯一编号，通常由系统生成。 | [optional] 
**TradeNo** | **string** | 与订单关联的交易编号，通常由支付平台提供。 | [optional] 
**Status** | **string** | 订单的当前状态，例如 &#39;待支付&#39;, &#39;已完成&#39;, &#39;已取消&#39; 等。 | [optional] 
**ProductType** | **string** | 订单中商品的类型分类。 | [optional] 
**ProductID** | **string** | 订单中商品的唯一标识符。 | [optional] 
**ProductName** | **string** | 订单中商品的名称。 | [optional] 
**AllowRefund** | **bool** | 指示订单是否允许进行退款操作。 | [optional] 
**AllowRefundUntil** | **DateTime** | 订单允许进行退款操作的截止时间。 | [optional] 
**Tags** | **string** | 用于分类或标记订单的标签。 | [optional] 
**Remark** | **string** | 订单的额外备注信息。 | [optional] 
**Description** | **string** | 订单的详细描述信息。 | [optional] 
**OrderPayTime** | **DateTime** | 订单完成支付的时间。 | [optional] 
**ExpireTime** | **DateTime** | 订单的过期时间，超过该时间订单将自动取消。 | [optional] 
**CreateDate** | **DateTime** | 订单的创建时间，默认为当前时间。 | [optional] 
**LastUpdate** | **DateTime** | 订单的最后更新时间，默认为当前时间。 | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

