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
    /// UserSettingListApiResponse
    /// </summary>
    public partial class UserSettingListApiResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSettingListApiResponse" /> class.
        /// </summary>
        /// <param name="code">状态码 (default to 200)</param>
        /// <param name="data">响应数据</param>
        /// <param name="error">错误信息 (default to &quot;&quot;)</param>
        [JsonConstructor]
        public UserSettingListApiResponse(Option<int?> code = default, Option<List<UserSetting>> data = default, Option<string> error = default)
        {
            CodeOption = code;
            DataOption = data;
            ErrorOption = error;
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
        /// 状态码
        /// </summary>
        /// <value>状态码</value>
        [JsonPropertyName("code")]
        public int? Code { get { return this.CodeOption; } set { this.CodeOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<UserSetting>> DataOption { get; private set; }

        /// <summary>
        /// 响应数据
        /// </summary>
        /// <value>响应数据</value>
        [JsonPropertyName("data")]
        public List<UserSetting> Data { get { return this.DataOption; } set { this.DataOption = new Option<List<UserSetting>>(value); } }

        /// <summary>
        /// Used to track the state of Error
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ErrorOption { get; private set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        /// <value>错误信息</value>
        [JsonPropertyName("error")]
        public string Error { get { return this.ErrorOption; } set { this.ErrorOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserSettingListApiResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
    /// A Json converter for type <see cref="UserSettingListApiResponse" />
    /// </summary>
    public class UserSettingListApiResponseJsonConverter : JsonConverter<UserSettingListApiResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserSettingListApiResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserSettingListApiResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> code = default;
            Option<List<UserSetting>> data = default;
            Option<string> error = default;

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
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<List<UserSetting>>(JsonSerializer.Deserialize<List<UserSetting>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "error":
                            error = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (code.IsSet && code.Value == null)
                throw new ArgumentNullException(nameof(code), "Property is not nullable for class UserSettingListApiResponse.");

            return new UserSettingListApiResponse(code, data, error);
        }

        /// <summary>
        /// Serializes a <see cref="UserSettingListApiResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userSettingListApiResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserSettingListApiResponse userSettingListApiResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userSettingListApiResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserSettingListApiResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userSettingListApiResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserSettingListApiResponse userSettingListApiResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userSettingListApiResponse.CodeOption.IsSet)
                writer.WriteNumber("code", userSettingListApiResponse.CodeOption.Value.Value);

            if (userSettingListApiResponse.DataOption.IsSet)
                if (userSettingListApiResponse.DataOption.Value != null)
                {
                    writer.WritePropertyName("data");
                    JsonSerializer.Serialize(writer, userSettingListApiResponse.Data, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("data");
            if (userSettingListApiResponse.ErrorOption.IsSet)
                if (userSettingListApiResponse.ErrorOption.Value != null)
                    writer.WriteString("error", userSettingListApiResponse.Error);
                else
                    writer.WriteNull("error");
        }
    }
}
