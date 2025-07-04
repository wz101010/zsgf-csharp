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
    /// StorageListResult
    /// </summary>
    public partial class StorageListResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageListResult" /> class.
        /// </summary>
        /// <param name="take">take</param>
        /// <param name="skip">skip</param>
        /// <param name="total">total</param>
        /// <param name="data">data</param>
        /// <param name="explain">explain</param>
        [JsonConstructor]
        public StorageListResult(Option<int?> take = default, Option<int?> skip = default, Option<long?> total = default, Option<Object> data = default, Option<Object> explain = default)
        {
            TakeOption = take;
            SkipOption = skip;
            TotalOption = total;
            DataOption = data;
            ExplainOption = explain;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Take
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> TakeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Take
        /// </summary>
        [JsonPropertyName("take")]
        public int? Take { get { return this.TakeOption; } set { this.TakeOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Skip
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> SkipOption { get; private set; }

        /// <summary>
        /// Gets or Sets Skip
        /// </summary>
        [JsonPropertyName("skip")]
        public int? Skip { get { return this.SkipOption; } set { this.SkipOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Total
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> TotalOption { get; private set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [JsonPropertyName("total")]
        public long? Total { get { return this.TotalOption; } set { this.TotalOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public Object Data { get { return this.DataOption; } set { this.DataOption = new Option<Object>(value); } }

        /// <summary>
        /// Used to track the state of Explain
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object> ExplainOption { get; private set; }

        /// <summary>
        /// Gets or Sets Explain
        /// </summary>
        [JsonPropertyName("explain")]
        public Object Explain { get { return this.ExplainOption; } set { this.ExplainOption = new Option<Object>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StorageListResult {\n");
            sb.Append("  Take: ").Append(Take).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Explain: ").Append(Explain).Append("\n");
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
    /// A Json converter for type <see cref="StorageListResult" />
    /// </summary>
    public class StorageListResultJsonConverter : JsonConverter<StorageListResult>
    {
        /// <summary>
        /// Deserializes json to <see cref="StorageListResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override StorageListResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> take = default;
            Option<int?> skip = default;
            Option<long?> total = default;
            Option<Object> data = default;
            Option<Object> explain = default;

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
                        case "take":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                take = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "skip":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                skip = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "total":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                total = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "explain":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                explain = new Option<Object>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (take.IsSet && take.Value == null)
                throw new ArgumentNullException(nameof(take), "Property is not nullable for class StorageListResult.");

            if (skip.IsSet && skip.Value == null)
                throw new ArgumentNullException(nameof(skip), "Property is not nullable for class StorageListResult.");

            if (total.IsSet && total.Value == null)
                throw new ArgumentNullException(nameof(total), "Property is not nullable for class StorageListResult.");

            return new StorageListResult(take, skip, total, data, explain);
        }

        /// <summary>
        /// Serializes a <see cref="StorageListResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="storageListResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, StorageListResult storageListResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, storageListResult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="StorageListResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="storageListResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, StorageListResult storageListResult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (storageListResult.TakeOption.IsSet)
                writer.WriteNumber("take", storageListResult.TakeOption.Value.Value);

            if (storageListResult.SkipOption.IsSet)
                writer.WriteNumber("skip", storageListResult.SkipOption.Value.Value);

            if (storageListResult.TotalOption.IsSet)
                writer.WriteNumber("total", storageListResult.TotalOption.Value.Value);

            if (storageListResult.DataOption.IsSet)
                if (storageListResult.DataOption.Value != null)
                {
                    writer.WritePropertyName("data");
                    JsonSerializer.Serialize(writer, storageListResult.Data, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("data");
            if (storageListResult.ExplainOption.IsSet)
                if (storageListResult.ExplainOption.Value != null)
                {
                    writer.WritePropertyName("explain");
                    JsonSerializer.Serialize(writer, storageListResult.Explain, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("explain");
        }
    }
}
