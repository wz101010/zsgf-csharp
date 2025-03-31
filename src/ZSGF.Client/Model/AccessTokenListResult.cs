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
    /// AccessTokenListResult
    /// </summary>
    public partial class AccessTokenListResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenListResult" /> class.
        /// </summary>
        /// <param name="total">total</param>
        /// <param name="data">data</param>
        [JsonConstructor]
        public AccessTokenListResult(Option<int?> total = default, Option<List<UserAccessToken>> data = default)
        {
            TotalOption = total;
            DataOption = data;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Total
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> TotalOption { get; private set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [JsonPropertyName("total")]
        public int? Total { get { return this.TotalOption; } set { this.TotalOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<UserAccessToken>> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<UserAccessToken> Data { get { return this.DataOption; } set { this.DataOption = new Option<List<UserAccessToken>>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccessTokenListResult {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
    /// A Json converter for type <see cref="AccessTokenListResult" />
    /// </summary>
    public class AccessTokenListResultJsonConverter : JsonConverter<AccessTokenListResult>
    {
        /// <summary>
        /// Deserializes json to <see cref="AccessTokenListResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AccessTokenListResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> total = default;
            Option<List<UserAccessToken>> data = default;

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
                        case "total":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                total = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<List<UserAccessToken>>(JsonSerializer.Deserialize<List<UserAccessToken>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (total.IsSet && total.Value == null)
                throw new ArgumentNullException(nameof(total), "Property is not nullable for class AccessTokenListResult.");

            return new AccessTokenListResult(total, data);
        }

        /// <summary>
        /// Serializes a <see cref="AccessTokenListResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="accessTokenListResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AccessTokenListResult accessTokenListResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, accessTokenListResult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AccessTokenListResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="accessTokenListResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AccessTokenListResult accessTokenListResult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (accessTokenListResult.TotalOption.IsSet)
                writer.WriteNumber("total", accessTokenListResult.TotalOption.Value.Value);

            if (accessTokenListResult.DataOption.IsSet)
                if (accessTokenListResult.DataOption.Value != null)
                {
                    writer.WritePropertyName("data");
                    JsonSerializer.Serialize(writer, accessTokenListResult.Data, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("data");
        }
    }
}
