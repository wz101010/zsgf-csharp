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
    /// AppSettingProviderPostResult
    /// </summary>
    public partial class AppSettingProviderPostResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppSettingProviderPostResult" /> class.
        /// </summary>
        /// <param name="id">id</param>
        [JsonConstructor]
        public AppSettingProviderPostResult(Option<long?> id = default)
        {
            IdOption = id;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get { return this.IdOption; } set { this.IdOption = new Option<long?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppSettingProviderPostResult {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
    /// A Json converter for type <see cref="AppSettingProviderPostResult" />
    /// </summary>
    public class AppSettingProviderPostResultJsonConverter : JsonConverter<AppSettingProviderPostResult>
    {
        /// <summary>
        /// Deserializes json to <see cref="AppSettingProviderPostResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AppSettingProviderPostResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;

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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AppSettingProviderPostResult.");

            return new AppSettingProviderPostResult(id);
        }

        /// <summary>
        /// Serializes a <see cref="AppSettingProviderPostResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appSettingProviderPostResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AppSettingProviderPostResult appSettingProviderPostResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, appSettingProviderPostResult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AppSettingProviderPostResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appSettingProviderPostResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AppSettingProviderPostResult appSettingProviderPostResult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (appSettingProviderPostResult.IdOption.IsSet)
                writer.WriteNumber("id", appSettingProviderPostResult.IdOption.Value.Value);
        }
    }
}
