// <auto-generated>
/*
 * 全部  API 文档
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using ZSGF.Client.Client;

namespace ZSGF.Client.Model
{
    /// <summary>
    /// IntactChargeInfo
    /// </summary>
    public partial class IntactChargeInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntactChargeInfo" /> class.
        /// </summary>
        /// <param name="actualAmount">actualAmount</param>
        /// <param name="billType">billType</param>
        /// <param name="gmtPay">gmtPay</param>
        /// <param name="isRefund">isRefund</param>
        /// <param name="outBizNo">outBizNo</param>
        /// <param name="planAmount">planAmount</param>
        /// <param name="productName">productName</param>
        /// <param name="serviceTarget">serviceTarget</param>
        /// <param name="serviceType">serviceType</param>
        /// <param name="status">status</param>
        /// <param name="targetAccountNo">targetAccountNo</param>
        /// <param name="targetUserId">targetUserId</param>
        [JsonConstructor]
        public IntactChargeInfo(Option<string> actualAmount = default, Option<string> billType = default, Option<string> gmtPay = default, Option<bool?> isRefund = default, Option<string> outBizNo = default, Option<string> planAmount = default, Option<string> productName = default, Option<string> serviceTarget = default, Option<string> serviceType = default, Option<string> status = default, Option<string> targetAccountNo = default, Option<string> targetUserId = default)
        {
            ActualAmountOption = actualAmount;
            BillTypeOption = billType;
            GmtPayOption = gmtPay;
            IsRefundOption = isRefund;
            OutBizNoOption = outBizNo;
            PlanAmountOption = planAmount;
            ProductNameOption = productName;
            ServiceTargetOption = serviceTarget;
            ServiceTypeOption = serviceType;
            StatusOption = status;
            TargetAccountNoOption = targetAccountNo;
            TargetUserIdOption = targetUserId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ActualAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ActualAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets ActualAmount
        /// </summary>
        [JsonPropertyName("actualAmount")]
        public string ActualAmount { get { return this.ActualAmountOption; } set { this.ActualAmountOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of BillType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> BillTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets BillType
        /// </summary>
        [JsonPropertyName("billType")]
        public string BillType { get { return this.BillTypeOption; } set { this.BillTypeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of GmtPay
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> GmtPayOption { get; private set; }

        /// <summary>
        /// Gets or Sets GmtPay
        /// </summary>
        [JsonPropertyName("gmtPay")]
        public string GmtPay { get { return this.GmtPayOption; } set { this.GmtPayOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of IsRefund
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> IsRefundOption { get; private set; }

        /// <summary>
        /// Gets or Sets IsRefund
        /// </summary>
        [JsonPropertyName("isRefund")]
        public bool? IsRefund { get { return this.IsRefundOption; } set { this.IsRefundOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of OutBizNo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> OutBizNoOption { get; private set; }

        /// <summary>
        /// Gets or Sets OutBizNo
        /// </summary>
        [JsonPropertyName("outBizNo")]
        public string OutBizNo { get { return this.OutBizNoOption; } set { this.OutBizNoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of PlanAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PlanAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets PlanAmount
        /// </summary>
        [JsonPropertyName("planAmount")]
        public string PlanAmount { get { return this.PlanAmountOption; } set { this.PlanAmountOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ProductName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ProductNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [JsonPropertyName("productName")]
        public string ProductName { get { return this.ProductNameOption; } set { this.ProductNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ServiceTarget
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ServiceTargetOption { get; private set; }

        /// <summary>
        /// Gets or Sets ServiceTarget
        /// </summary>
        [JsonPropertyName("serviceTarget")]
        public string ServiceTarget { get { return this.ServiceTargetOption; } set { this.ServiceTargetOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ServiceType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ServiceTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ServiceType
        /// </summary>
        [JsonPropertyName("serviceType")]
        public string ServiceType { get { return this.ServiceTypeOption; } set { this.ServiceTypeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> StatusOption { get; private set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get { return this.StatusOption; } set { this.StatusOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of TargetAccountNo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TargetAccountNoOption { get; private set; }

        /// <summary>
        /// Gets or Sets TargetAccountNo
        /// </summary>
        [JsonPropertyName("targetAccountNo")]
        public string TargetAccountNo { get { return this.TargetAccountNoOption; } set { this.TargetAccountNoOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of TargetUserId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TargetUserIdOption { get; private set; }

        /// <summary>
        /// Gets or Sets TargetUserId
        /// </summary>
        [JsonPropertyName("targetUserId")]
        public string TargetUserId { get { return this.TargetUserIdOption; } set { this.TargetUserIdOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IntactChargeInfo {\n");
            sb.Append("  ActualAmount: ").Append(ActualAmount).Append("\n");
            sb.Append("  BillType: ").Append(BillType).Append("\n");
            sb.Append("  GmtPay: ").Append(GmtPay).Append("\n");
            sb.Append("  IsRefund: ").Append(IsRefund).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PlanAmount: ").Append(PlanAmount).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ServiceTarget: ").Append(ServiceTarget).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TargetAccountNo: ").Append(TargetAccountNo).Append("\n");
            sb.Append("  TargetUserId: ").Append(TargetUserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="IntactChargeInfo" />
    /// </summary>
    public class IntactChargeInfoJsonConverter : JsonConverter<IntactChargeInfo>
    {
        /// <summary>
        /// Deserializes json to <see cref="IntactChargeInfo" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override IntactChargeInfo Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> actualAmount = default;
            Option<string> billType = default;
            Option<string> gmtPay = default;
            Option<bool?> isRefund = default;
            Option<string> outBizNo = default;
            Option<string> planAmount = default;
            Option<string> productName = default;
            Option<string> serviceTarget = default;
            Option<string> serviceType = default;
            Option<string> status = default;
            Option<string> targetAccountNo = default;
            Option<string> targetUserId = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "actualAmount":
                            actualAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "billType":
                            billType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "gmtPay":
                            gmtPay = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "isRefund":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                isRefund = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "outBizNo":
                            outBizNo = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "planAmount":
                            planAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "productName":
                            productName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "serviceTarget":
                            serviceTarget = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "serviceType":
                            serviceType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "status":
                            status = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "targetAccountNo":
                            targetAccountNo = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "targetUserId":
                            targetUserId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (isRefund.IsSet && isRefund.Value == null)
                throw new ArgumentNullException(nameof(isRefund), "Property is not nullable for class IntactChargeInfo.");

            return new IntactChargeInfo(actualAmount, billType, gmtPay, isRefund, outBizNo, planAmount, productName, serviceTarget, serviceType, status, targetAccountNo, targetUserId);
        }

        /// <summary>
        /// Serializes a <see cref="IntactChargeInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="intactChargeInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, IntactChargeInfo intactChargeInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, intactChargeInfo, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="IntactChargeInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="intactChargeInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, IntactChargeInfo intactChargeInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            if (intactChargeInfo.ActualAmountOption.IsSet)
                if (intactChargeInfo.ActualAmountOption.Value != null)
                    writer.WriteString("actualAmount", intactChargeInfo.ActualAmount);
                else
                    writer.WriteNull("actualAmount");

            if (intactChargeInfo.BillTypeOption.IsSet)
                if (intactChargeInfo.BillTypeOption.Value != null)
                    writer.WriteString("billType", intactChargeInfo.BillType);
                else
                    writer.WriteNull("billType");

            if (intactChargeInfo.GmtPayOption.IsSet)
                if (intactChargeInfo.GmtPayOption.Value != null)
                    writer.WriteString("gmtPay", intactChargeInfo.GmtPay);
                else
                    writer.WriteNull("gmtPay");

            if (intactChargeInfo.IsRefundOption.IsSet)
                writer.WriteBoolean("isRefund", intactChargeInfo.IsRefundOption.Value.Value);

            if (intactChargeInfo.OutBizNoOption.IsSet)
                if (intactChargeInfo.OutBizNoOption.Value != null)
                    writer.WriteString("outBizNo", intactChargeInfo.OutBizNo);
                else
                    writer.WriteNull("outBizNo");

            if (intactChargeInfo.PlanAmountOption.IsSet)
                if (intactChargeInfo.PlanAmountOption.Value != null)
                    writer.WriteString("planAmount", intactChargeInfo.PlanAmount);
                else
                    writer.WriteNull("planAmount");

            if (intactChargeInfo.ProductNameOption.IsSet)
                if (intactChargeInfo.ProductNameOption.Value != null)
                    writer.WriteString("productName", intactChargeInfo.ProductName);
                else
                    writer.WriteNull("productName");

            if (intactChargeInfo.ServiceTargetOption.IsSet)
                if (intactChargeInfo.ServiceTargetOption.Value != null)
                    writer.WriteString("serviceTarget", intactChargeInfo.ServiceTarget);
                else
                    writer.WriteNull("serviceTarget");

            if (intactChargeInfo.ServiceTypeOption.IsSet)
                if (intactChargeInfo.ServiceTypeOption.Value != null)
                    writer.WriteString("serviceType", intactChargeInfo.ServiceType);
                else
                    writer.WriteNull("serviceType");

            if (intactChargeInfo.StatusOption.IsSet)
                if (intactChargeInfo.StatusOption.Value != null)
                    writer.WriteString("status", intactChargeInfo.Status);
                else
                    writer.WriteNull("status");

            if (intactChargeInfo.TargetAccountNoOption.IsSet)
                if (intactChargeInfo.TargetAccountNoOption.Value != null)
                    writer.WriteString("targetAccountNo", intactChargeInfo.TargetAccountNo);
                else
                    writer.WriteNull("targetAccountNo");

            if (intactChargeInfo.TargetUserIdOption.IsSet)
                if (intactChargeInfo.TargetUserIdOption.Value != null)
                    writer.WriteString("targetUserId", intactChargeInfo.TargetUserId);
                else
                    writer.WriteNull("targetUserId");
        }
    }
}
