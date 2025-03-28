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
    /// JObjectApiResult
    /// </summary>
    public partial class JObjectApiResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JObjectApiResult" /> class.
        /// </summary>
        /// <param name="code">业务状态码 (default to 200)</param>
        /// <param name="err">错误消息 (default to &quot;&quot;)</param>
        /// <param name="data">业务数据</param>
        [JsonConstructor]
        public JObjectApiResult(Option<int?> code = default, Option<string> err = default, Option<Dictionary<string, List<Object>>> data = default)
        {
            CodeOption = code;
            ErrOption = err;
            DataOption = data;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> CodeOption { get; private set; }

        /// <summary>
        /// 业务状态码
        /// </summary>
        /// <value>业务状态码</value>
        [JsonPropertyName("code")]
        public int? Code { get { return this.CodeOption; } set { this.CodeOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Err
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ErrOption { get; private set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        /// <value>错误消息</value>
        [JsonPropertyName("err")]
        public string Err { get { return this.ErrOption; } set { this.ErrOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Dictionary<string, List<Object>>> DataOption { get; private set; }

        /// <summary>
        /// 业务数据
        /// </summary>
        /// <value>业务数据</value>
        [JsonPropertyName("data")]
        public Dictionary<string, List<Object>> Data { get { return this.DataOption; } set { this.DataOption = new Option<Dictionary<string, List<Object>>>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JObjectApiResult {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Err: ").Append(Err).Append("\n");
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
    /// A Json converter for type <see cref="JObjectApiResult" />
    /// </summary>
    public class JObjectApiResultJsonConverter : JsonConverter<JObjectApiResult>
    {
        /// <summary>
        /// Deserializes json to <see cref="JObjectApiResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override JObjectApiResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> code = default;
            Option<string> err = default;
            Option<Dictionary<string, List<Object>>> data = default;

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
                        case "code":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                code = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "err":
                            err = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<Dictionary<string, List<Object>>>(JsonSerializer.Deserialize<Dictionary<string, List<Object>>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class JObjectApiResult.");

            return new JObjectApiResult(code, err, data);
        }

        /// <summary>
        /// Serializes a <see cref="JObjectApiResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="jObjectApiResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, JObjectApiResult jObjectApiResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, jObjectApiResult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="JObjectApiResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="jObjectApiResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, JObjectApiResult jObjectApiResult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (jObjectApiResult.CodeOption.IsSet)
                writer.WriteNumber("code", jObjectApiResult.CodeOption.Value.Value);

            if (jObjectApiResult.ErrOption.IsSet)
                if (jObjectApiResult.ErrOption.Value != null)
                    writer.WriteString("err", jObjectApiResult.Err);
                else
                    writer.WriteNull("err");

            if (jObjectApiResult.DataOption.IsSet)
                if (jObjectApiResult.DataOption.Value != null)
                {
                    writer.WritePropertyName("data");
                    JsonSerializer.Serialize(writer, jObjectApiResult.Data, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("data");
        }
    }
}
