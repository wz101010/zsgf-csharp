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
    /// DirectoryItem
    /// </summary>
    public partial class DirectoryItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryItem" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="createDate">createDate</param>
        /// <param name="lastUpdate">lastUpdate</param>
        /// <param name="fileSize">fileSize</param>
        [JsonConstructor]
        public DirectoryItem(Option<string> name = default, Option<DateTime?> createDate = default, Option<DateTime?> lastUpdate = default, Option<long?> fileSize = default)
        {
            NameOption = name;
            CreateDateOption = createDate;
            LastUpdateOption = lastUpdate;
            FileSizeOption = fileSize;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get { return this.NameOption; } set { this.NameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CreateDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreateDateOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreateDate
        /// </summary>
        [JsonPropertyName("createDate")]
        public DateTime? CreateDate { get { return this.CreateDateOption; } set { this.CreateDateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [JsonPropertyName("lastUpdate")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of FileSize
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> FileSizeOption { get; private set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [JsonPropertyName("fileSize")]
        public long? FileSize { get { return this.FileSizeOption; } set { this.FileSizeOption = new Option<long?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DirectoryItem {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
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
    /// A Json converter for type <see cref="DirectoryItem" />
    /// </summary>
    public class DirectoryItemJsonConverter : JsonConverter<DirectoryItem>
    {
        /// <summary>
        /// The format to use to serialize CreateDate
        /// </summary>
        public static string CreateDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize LastUpdate
        /// </summary>
        public static string LastUpdateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="DirectoryItem" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override DirectoryItem Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> name = default;
            Option<DateTime?> createDate = default;
            Option<DateTime?> lastUpdate = default;
            Option<long?> fileSize = default;

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
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "createDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createDate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "lastUpdate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastUpdate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "fileSize":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                fileSize = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (createDate.IsSet && createDate.Value == null)
                throw new ArgumentNullException(nameof(createDate), "Property is not nullable for class DirectoryItem.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class DirectoryItem.");

            return new DirectoryItem(name, createDate, lastUpdate, fileSize);
        }

        /// <summary>
        /// Serializes a <see cref="DirectoryItem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="directoryItem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, DirectoryItem directoryItem, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, directoryItem, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="DirectoryItem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="directoryItem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, DirectoryItem directoryItem, JsonSerializerOptions jsonSerializerOptions)
        {
            if (directoryItem.NameOption.IsSet)
                if (directoryItem.NameOption.Value != null)
                    writer.WriteString("name", directoryItem.Name);
                else
                    writer.WriteNull("name");

            if (directoryItem.CreateDateOption.IsSet)
                writer.WriteString("createDate", directoryItem.CreateDateOption.Value.Value.ToString(CreateDateFormat));

            if (directoryItem.LastUpdateOption.IsSet)
                writer.WriteString("lastUpdate", directoryItem.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));

            if (directoryItem.FileSizeOption.IsSet)
                if (directoryItem.FileSizeOption.Value != null)
                    writer.WriteNumber("fileSize", directoryItem.FileSizeOption.Value.Value);
                else
                    writer.WriteNull("fileSize");
        }
    }
}
