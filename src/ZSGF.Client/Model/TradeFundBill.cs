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
    /// TradeFundBill
    /// </summary>
    public partial class TradeFundBill : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeFundBill" /> class.
        /// </summary>
        /// <param name="amount">amount</param>
        /// <param name="bankCode">bankCode</param>
        /// <param name="fundChannel">fundChannel</param>
        /// <param name="fundType">fundType</param>
        /// <param name="realAmount">realAmount</param>
        [JsonConstructor]
        public TradeFundBill(Option<string> amount = default, Option<string> bankCode = default, Option<string> fundChannel = default, Option<string> fundType = default, Option<string> realAmount = default)
        {
            AmountOption = amount;
            BankCodeOption = bankCode;
            FundChannelOption = fundChannel;
            FundTypeOption = fundType;
            RealAmountOption = realAmount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Amount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> AmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get { return this.AmountOption; } set { this.AmountOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of BankCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> BankCodeOption { get; private set; }

        /// <summary>
        /// Gets or Sets BankCode
        /// </summary>
        [JsonPropertyName("bankCode")]
        public string BankCode { get { return this.BankCodeOption; } set { this.BankCodeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of FundChannel
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FundChannelOption { get; private set; }

        /// <summary>
        /// Gets or Sets FundChannel
        /// </summary>
        [JsonPropertyName("fundChannel")]
        public string FundChannel { get { return this.FundChannelOption; } set { this.FundChannelOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of FundType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FundTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets FundType
        /// </summary>
        [JsonPropertyName("fundType")]
        public string FundType { get { return this.FundTypeOption; } set { this.FundTypeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of RealAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> RealAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets RealAmount
        /// </summary>
        [JsonPropertyName("realAmount")]
        public string RealAmount { get { return this.RealAmountOption; } set { this.RealAmountOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeFundBill {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  FundChannel: ").Append(FundChannel).Append("\n");
            sb.Append("  FundType: ").Append(FundType).Append("\n");
            sb.Append("  RealAmount: ").Append(RealAmount).Append("\n");
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
    /// A Json converter for type <see cref="TradeFundBill" />
    /// </summary>
    public class TradeFundBillJsonConverter : JsonConverter<TradeFundBill>
    {
        /// <summary>
        /// Deserializes json to <see cref="TradeFundBill" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TradeFundBill Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> amount = default;
            Option<string> bankCode = default;
            Option<string> fundChannel = default;
            Option<string> fundType = default;
            Option<string> realAmount = default;

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
                        case "amount":
                            amount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "bankCode":
                            bankCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "fundChannel":
                            fundChannel = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "fundType":
                            fundType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "realAmount":
                            realAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new TradeFundBill(amount, bankCode, fundChannel, fundType, realAmount);
        }

        /// <summary>
        /// Serializes a <see cref="TradeFundBill" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tradeFundBill"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TradeFundBill tradeFundBill, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, tradeFundBill, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TradeFundBill" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tradeFundBill"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TradeFundBill tradeFundBill, JsonSerializerOptions jsonSerializerOptions)
        {
            if (tradeFundBill.AmountOption.IsSet)
                if (tradeFundBill.AmountOption.Value != null)
                    writer.WriteString("amount", tradeFundBill.Amount);
                else
                    writer.WriteNull("amount");

            if (tradeFundBill.BankCodeOption.IsSet)
                if (tradeFundBill.BankCodeOption.Value != null)
                    writer.WriteString("bankCode", tradeFundBill.BankCode);
                else
                    writer.WriteNull("bankCode");

            if (tradeFundBill.FundChannelOption.IsSet)
                if (tradeFundBill.FundChannelOption.Value != null)
                    writer.WriteString("fundChannel", tradeFundBill.FundChannel);
                else
                    writer.WriteNull("fundChannel");

            if (tradeFundBill.FundTypeOption.IsSet)
                if (tradeFundBill.FundTypeOption.Value != null)
                    writer.WriteString("fundType", tradeFundBill.FundType);
                else
                    writer.WriteNull("fundType");

            if (tradeFundBill.RealAmountOption.IsSet)
                if (tradeFundBill.RealAmountOption.Value != null)
                    writer.WriteString("realAmount", tradeFundBill.RealAmount);
                else
                    writer.WriteNull("realAmount");
        }
    }
}
