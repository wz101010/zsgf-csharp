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
    /// AppCheckVersionResult
    /// </summary>
    public partial class AppCheckVersionResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppCheckVersionResult" /> class.
        /// </summary>
        /// <param name="versions">versions</param>
        /// <param name="newVersions">newVersions</param>
        [JsonConstructor]
        public AppCheckVersionResult(Option<List<string>> versions = default, Option<List<string>> newVersions = default)
        {
            VersionsOption = versions;
            NewVersionsOption = newVersions;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Versions
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>> VersionsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Versions
        /// </summary>
        [JsonPropertyName("versions")]
        public List<string> Versions { get { return this.VersionsOption; } set { this.VersionsOption = new Option<List<string>>(value); } }

        /// <summary>
        /// Used to track the state of NewVersions
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<string>> NewVersionsOption { get; private set; }

        /// <summary>
        /// Gets or Sets NewVersions
        /// </summary>
        [JsonPropertyName("newVersions")]
        public List<string> NewVersions { get { return this.NewVersionsOption; } set { this.NewVersionsOption = new Option<List<string>>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppCheckVersionResult {\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
            sb.Append("  NewVersions: ").Append(NewVersions).Append("\n");
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
    /// A Json converter for type <see cref="AppCheckVersionResult" />
    /// </summary>
    public class AppCheckVersionResultJsonConverter : JsonConverter<AppCheckVersionResult>
    {
        /// <summary>
        /// Deserializes json to <see cref="AppCheckVersionResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AppCheckVersionResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<string>> versions = default;
            Option<List<string>> newVersions = default;

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
                        case "versions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                versions = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "newVersions":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                newVersions = new Option<List<string>>(JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            return new AppCheckVersionResult(versions, newVersions);
        }

        /// <summary>
        /// Serializes a <see cref="AppCheckVersionResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appCheckVersionResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AppCheckVersionResult appCheckVersionResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, appCheckVersionResult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AppCheckVersionResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appCheckVersionResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AppCheckVersionResult appCheckVersionResult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (appCheckVersionResult.VersionsOption.IsSet)
                if (appCheckVersionResult.VersionsOption.Value != null)
                {
                    writer.WritePropertyName("versions");
                    JsonSerializer.Serialize(writer, appCheckVersionResult.Versions, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("versions");
            if (appCheckVersionResult.NewVersionsOption.IsSet)
                if (appCheckVersionResult.NewVersionsOption.Value != null)
                {
                    writer.WritePropertyName("newVersions");
                    JsonSerializer.Serialize(writer, appCheckVersionResult.NewVersions, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("newVersions");
        }
    }
}
