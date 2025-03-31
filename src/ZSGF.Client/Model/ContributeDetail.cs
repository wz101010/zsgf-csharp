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
    /// ContributeDetail
    /// </summary>
    public partial class ContributeDetail : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContributeDetail" /> class.
        /// </summary>
        /// <param name="contributeAmount">contributeAmount</param>
        /// <param name="contributeType">contributeType</param>
        [JsonConstructor]
        public ContributeDetail(Option<string> contributeAmount = default, Option<string> contributeType = default)
        {
            ContributeAmountOption = contributeAmount;
            ContributeTypeOption = contributeType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ContributeAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ContributeAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets ContributeAmount
        /// </summary>
        [JsonPropertyName("contributeAmount")]
        public string ContributeAmount { get { return this.ContributeAmountOption; } set { this.ContributeAmountOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ContributeType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ContributeTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets ContributeType
        /// </summary>
        [JsonPropertyName("contributeType")]
        public string ContributeType { get { return this.ContributeTypeOption; } set { this.ContributeTypeOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContributeDetail {\n");
            sb.Append("  ContributeAmount: ").Append(ContributeAmount).Append("\n");
            sb.Append("  ContributeType: ").Append(ContributeType).Append("\n");
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
    /// A Json converter for type <see cref="ContributeDetail" />
    /// </summary>
    public class ContributeDetailJsonConverter : JsonConverter<ContributeDetail>
    {
        /// <summary>
        /// Deserializes json to <see cref="ContributeDetail" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ContributeDetail Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> contributeAmount = default;
            Option<string> contributeType = default;

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
                        case "contributeAmount":
                            contributeAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "contributeType":
                            contributeType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ContributeDetail(contributeAmount, contributeType);
        }

        /// <summary>
        /// Serializes a <see cref="ContributeDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="contributeDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ContributeDetail contributeDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, contributeDetail, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ContributeDetail" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="contributeDetail"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ContributeDetail contributeDetail, JsonSerializerOptions jsonSerializerOptions)
        {
            if (contributeDetail.ContributeAmountOption.IsSet)
                if (contributeDetail.ContributeAmountOption.Value != null)
                    writer.WriteString("contributeAmount", contributeDetail.ContributeAmount);
                else
                    writer.WriteNull("contributeAmount");

            if (contributeDetail.ContributeTypeOption.IsSet)
                if (contributeDetail.ContributeTypeOption.Value != null)
                    writer.WriteString("contributeType", contributeDetail.ContributeType);
                else
                    writer.WriteNull("contributeType");
        }
    }
}
