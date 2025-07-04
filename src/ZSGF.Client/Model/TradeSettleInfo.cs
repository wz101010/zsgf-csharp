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
    /// TradeSettleInfo
    /// </summary>
    public partial class TradeSettleInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeSettleInfo" /> class.
        /// </summary>
        /// <param name="tradeSettleDetailList">tradeSettleDetailList</param>
        /// <param name="tradeUnsettledAmount">tradeUnsettledAmount</param>
        [JsonConstructor]
        public TradeSettleInfo(Option<List<TradeSettleDetail>> tradeSettleDetailList = default, Option<string> tradeUnsettledAmount = default)
        {
            TradeSettleDetailListOption = tradeSettleDetailList;
            TradeUnsettledAmountOption = tradeUnsettledAmount;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of TradeSettleDetailList
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<TradeSettleDetail>> TradeSettleDetailListOption { get; private set; }

        /// <summary>
        /// Gets or Sets TradeSettleDetailList
        /// </summary>
        [JsonPropertyName("tradeSettleDetailList")]
        public List<TradeSettleDetail> TradeSettleDetailList { get { return this.TradeSettleDetailListOption; } set { this.TradeSettleDetailListOption = new Option<List<TradeSettleDetail>>(value); } }

        /// <summary>
        /// Used to track the state of TradeUnsettledAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TradeUnsettledAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets TradeUnsettledAmount
        /// </summary>
        [JsonPropertyName("tradeUnsettledAmount")]
        public string TradeUnsettledAmount { get { return this.TradeUnsettledAmountOption; } set { this.TradeUnsettledAmountOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeSettleInfo {\n");
            sb.Append("  TradeSettleDetailList: ").Append(TradeSettleDetailList).Append("\n");
            sb.Append("  TradeUnsettledAmount: ").Append(TradeUnsettledAmount).Append("\n");
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
    /// A Json converter for type <see cref="TradeSettleInfo" />
    /// </summary>
    public class TradeSettleInfoJsonConverter : JsonConverter<TradeSettleInfo>
    {
        /// <summary>
        /// Deserializes json to <see cref="TradeSettleInfo" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override TradeSettleInfo Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<TradeSettleDetail>> tradeSettleDetailList = default;
            Option<string> tradeUnsettledAmount = default;

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
                        case "tradeSettleDetailList":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                tradeSettleDetailList = new Option<List<TradeSettleDetail>>(JsonSerializer.Deserialize<List<TradeSettleDetail>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "tradeUnsettledAmount":
                            tradeUnsettledAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new TradeSettleInfo(tradeSettleDetailList, tradeUnsettledAmount);
        }

        /// <summary>
        /// Serializes a <see cref="TradeSettleInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tradeSettleInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, TradeSettleInfo tradeSettleInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, tradeSettleInfo, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="TradeSettleInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tradeSettleInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, TradeSettleInfo tradeSettleInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            if (tradeSettleInfo.TradeSettleDetailListOption.IsSet)
                if (tradeSettleInfo.TradeSettleDetailListOption.Value != null)
                {
                    writer.WritePropertyName("tradeSettleDetailList");
                    JsonSerializer.Serialize(writer, tradeSettleInfo.TradeSettleDetailList, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("tradeSettleDetailList");
            if (tradeSettleInfo.TradeUnsettledAmountOption.IsSet)
                if (tradeSettleInfo.TradeUnsettledAmountOption.Value != null)
                    writer.WriteString("tradeUnsettledAmount", tradeSettleInfo.TradeUnsettledAmount);
                else
                    writer.WriteNull("tradeUnsettledAmount");
        }
    }
}
