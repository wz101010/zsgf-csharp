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
    /// HbFqPayInfo
    /// </summary>
    public partial class HbFqPayInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HbFqPayInfo" /> class.
        /// </summary>
        /// <param name="fqAmount">fqAmount</param>
        /// <param name="userInstallNum">userInstallNum</param>
        [JsonConstructor]
        public HbFqPayInfo(Option<string> fqAmount = default, Option<string> userInstallNum = default)
        {
            FqAmountOption = fqAmount;
            UserInstallNumOption = userInstallNum;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of FqAmount
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> FqAmountOption { get; private set; }

        /// <summary>
        /// Gets or Sets FqAmount
        /// </summary>
        [JsonPropertyName("fqAmount")]
        public string FqAmount { get { return this.FqAmountOption; } set { this.FqAmountOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of UserInstallNum
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> UserInstallNumOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserInstallNum
        /// </summary>
        [JsonPropertyName("userInstallNum")]
        public string UserInstallNum { get { return this.UserInstallNumOption; } set { this.UserInstallNumOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HbFqPayInfo {\n");
            sb.Append("  FqAmount: ").Append(FqAmount).Append("\n");
            sb.Append("  UserInstallNum: ").Append(UserInstallNum).Append("\n");
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
    /// A Json converter for type <see cref="HbFqPayInfo" />
    /// </summary>
    public class HbFqPayInfoJsonConverter : JsonConverter<HbFqPayInfo>
    {
        /// <summary>
        /// Deserializes json to <see cref="HbFqPayInfo" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override HbFqPayInfo Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> fqAmount = default;
            Option<string> userInstallNum = default;

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
                        case "fqAmount":
                            fqAmount = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "userInstallNum":
                            userInstallNum = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new HbFqPayInfo(fqAmount, userInstallNum);
        }

        /// <summary>
        /// Serializes a <see cref="HbFqPayInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hbFqPayInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, HbFqPayInfo hbFqPayInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, hbFqPayInfo, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="HbFqPayInfo" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="hbFqPayInfo"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, HbFqPayInfo hbFqPayInfo, JsonSerializerOptions jsonSerializerOptions)
        {
            if (hbFqPayInfo.FqAmountOption.IsSet)
                if (hbFqPayInfo.FqAmountOption.Value != null)
                    writer.WriteString("fqAmount", hbFqPayInfo.FqAmount);
                else
                    writer.WriteNull("fqAmount");

            if (hbFqPayInfo.UserInstallNumOption.IsSet)
                if (hbFqPayInfo.UserInstallNumOption.Value != null)
                    writer.WriteString("userInstallNum", hbFqPayInfo.UserInstallNum);
                else
                    writer.WriteNull("userInstallNum");
        }
    }
}
