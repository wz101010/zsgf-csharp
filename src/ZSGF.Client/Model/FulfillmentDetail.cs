// <auto-generated>
/*
 * 用户全部 API 文档
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
    /// FulfillmentDetail
    /// </summary>
    public partial class FulfillmentDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentDetail" /> class.
        /// </summary>
        /// <param name="fulfillmentAmount">fulfillmentAmount</param>
        /// <param name="gmtPayment">gmtPayment</param>
        /// <param name="outRequestNo">outRequestNo</param>
        [JsonConstructor]
        public FulfillmentDetail(Option<string> fulfillmentAmount = default, Option<string> gmtPayment = default, Option<string> outRequestNo = default)
        {
            FulfillmentAmountOption = fulfillmentAmount;
            GmtPaymentOption = gmtPayment;
            OutRequestNoOption = outRequestNo;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of FulfillmentAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FulfillmentAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets FulfillmentAmount
        /// </summary>
        [JsonPropertyName("fulfillmentAmount")]
        public string FulfillmentAmount { get { return this.FulfillmentAmountOption; } set { this.FulfillmentAmountOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of GmtPayment
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> GmtPaymentOption { get; private set; }

        /// <summary>
        /// Gets or Sets GmtPayment
        /// </summary>
        [JsonPropertyName("gmtPayment")]
        public string GmtPayment { get { return this.GmtPaymentOption; } set { this.GmtPaymentOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of OutRequestNo
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> OutRequestNoOption { get; private set; }

        /// <summary>
        /// Gets or Sets OutRequestNo
        /// </summary>
        [JsonPropertyName("outRequestNo")]
        public string OutRequestNo { get { return this.OutRequestNoOption; } set { this.OutRequestNoOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FulfillmentDetail {\n");
            sb.Append("  FulfillmentAmount: ").Append(FulfillmentAmount).Append("\n");
            sb.Append("  GmtPayment: ").Append(GmtPayment).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
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
    /// A Json converter for type <see cref="FulfillmentDetail" />
    /// </summary>
    public class FulfillmentDetailJsonConverter : JsonConverter<FulfillmentDetail>
    {
        /// <summary>
        /// Deserializes json to <see cref="FulfillmentDetail" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FulfillmentDetail Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> fulfillmentAmount = default;
            Option<string> gmtPayment = default;
            Option<string> outRequestNo = default;

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
                        case "fulfillmentAmount":
                            fulfillmentAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "gmtPayment":
                            gmtPayment = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "outRequestNo":
                            outRequestNo = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new FulfillmentDetail(fulfillmentAmount, gmtPayment, outRequestNo);
        }

        /// <summary>
        /// Serializes a <see cref="FulfillmentDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fulfillmentDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FulfillmentDetail fulfillmentDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, fulfillmentDetail, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FulfillmentDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fulfillmentDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, FulfillmentDetail fulfillmentDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            if (fulfillmentDetail.FulfillmentAmountOption.IsSet)
                if (fulfillmentDetail.FulfillmentAmountOption.Value != null)
                    writer.WriteString("fulfillmentAmount", fulfillmentDetail.FulfillmentAmount);
                else
                    writer.WriteNull("fulfillmentAmount");

            if (fulfillmentDetail.GmtPaymentOption.IsSet)
                if (fulfillmentDetail.GmtPaymentOption.Value != null)
                    writer.WriteString("gmtPayment", fulfillmentDetail.GmtPayment);
                else
                    writer.WriteNull("gmtPayment");

            if (fulfillmentDetail.OutRequestNoOption.IsSet)
                if (fulfillmentDetail.OutRequestNoOption.Value != null)
                    writer.WriteString("outRequestNo", fulfillmentDetail.OutRequestNo);
                else
                    writer.WriteNull("outRequestNo");
        }
    }
}
