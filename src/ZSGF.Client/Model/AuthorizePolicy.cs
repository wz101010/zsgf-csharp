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
    /// 鉴权策略实体，用于定义和管理系统的鉴权规则。
    /// </summary>
    public partial class AuthorizePolicy : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizePolicy" /> class.
        /// </summary>
        /// <param name="id">鉴权策略的唯一标识符。</param>
        /// <param name="policyName">鉴权策略的名称。根据鉴权类型填写不同的名称：角色类型填写角色名称，用户类型填写用户ID，访问令牌类型填写令牌ID。</param>
        /// <param name="authorizeType">鉴权策略的类型，可选值为 &#39;access_token&#39;, &#39;user&#39;, 或 &#39;role&#39;。</param>
        /// <param name="policyValue">与鉴权策略关联的权限集合，多个权限可以用逗号分隔。</param>
        /// <param name="createDate">鉴权策略的创建日期，默认为当前时间。</param>
        /// <param name="lastUpdate">鉴权策略的最后更新日期，默认为当前时间。</param>
        [JsonConstructor]
        public AuthorizePolicy(Option<long?> id = default, Option<string> policyName = default, Option<string> authorizeType = default, Option<string> policyValue = default, Option<DateTime?> createDate = default, Option<DateTime?> lastUpdate = default)
        {
            IdOption = id;
            PolicyNameOption = policyName;
            AuthorizeTypeOption = authorizeType;
            PolicyValueOption = policyValue;
            CreateDateOption = createDate;
            LastUpdateOption = lastUpdate;
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
        /// 鉴权策略的唯一标识符。
        /// </summary>
        /// <value>鉴权策略的唯一标识符。</value>
        [JsonPropertyName("id")]
        public long? Id { get { return this.IdOption; } set { this.IdOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of PolicyName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PolicyNameOption { get; private set; }

        /// <summary>
        /// 鉴权策略的名称。根据鉴权类型填写不同的名称：角色类型填写角色名称，用户类型填写用户ID，访问令牌类型填写令牌ID。
        /// </summary>
        /// <value>鉴权策略的名称。根据鉴权类型填写不同的名称：角色类型填写角色名称，用户类型填写用户ID，访问令牌类型填写令牌ID。</value>
        [JsonPropertyName("policyName")]
        public string PolicyName { get { return this.PolicyNameOption; } set { this.PolicyNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of AuthorizeType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> AuthorizeTypeOption { get; private set; }

        /// <summary>
        /// 鉴权策略的类型，可选值为 &#39;access_token&#39;, &#39;user&#39;, 或 &#39;role&#39;。
        /// </summary>
        /// <value>鉴权策略的类型，可选值为 &#39;access_token&#39;, &#39;user&#39;, 或 &#39;role&#39;。</value>
        [JsonPropertyName("authorizeType")]
        public string AuthorizeType { get { return this.AuthorizeTypeOption; } set { this.AuthorizeTypeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of PolicyValue
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PolicyValueOption { get; private set; }

        /// <summary>
        /// 与鉴权策略关联的权限集合，多个权限可以用逗号分隔。
        /// </summary>
        /// <value>与鉴权策略关联的权限集合，多个权限可以用逗号分隔。</value>
        [JsonPropertyName("policyValue")]
        public string PolicyValue { get { return this.PolicyValueOption; } set { this.PolicyValueOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CreateDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreateDateOption { get; private set; }

        /// <summary>
        /// 鉴权策略的创建日期，默认为当前时间。
        /// </summary>
        /// <value>鉴权策略的创建日期，默认为当前时间。</value>
        [JsonPropertyName("createDate")]
        public DateTime? CreateDate { get { return this.CreateDateOption; } set { this.CreateDateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// 鉴权策略的最后更新日期，默认为当前时间。
        /// </summary>
        /// <value>鉴权策略的最后更新日期，默认为当前时间。</value>
        [JsonPropertyName("lastUpdate")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizePolicy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  AuthorizeType: ").Append(AuthorizeType).Append("\n");
            sb.Append("  PolicyValue: ").Append(PolicyValue).Append("\n");
            sb.Append("  CreateDate: ").Append(CreateDate).Append("\n");
            sb.Append("  LastUpdate: ").Append(LastUpdate).Append("\n");
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
            // AuthorizeType (string) maxLength
            if (this.AuthorizeType != null && this.AuthorizeType.Length > 50)
            {
                yield return new ValidationResult("Invalid value for AuthorizeType, length must be less than 50.", new [] { "AuthorizeType" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="AuthorizePolicy" />
    /// </summary>
    public class AuthorizePolicyJsonConverter : JsonConverter<AuthorizePolicy>
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
        /// Deserializes json to <see cref="AuthorizePolicy" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AuthorizePolicy Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<string> policyName = default;
            Option<string> authorizeType = default;
            Option<string> policyValue = default;
            Option<DateTime?> createDate = default;
            Option<DateTime?> lastUpdate = default;

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
                        case "policyName":
                            policyName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "authorizeType":
                            authorizeType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "policyValue":
                            policyValue = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "createDate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createDate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "lastUpdate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lastUpdate = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class AuthorizePolicy.");

            if (createDate.IsSet && createDate.Value == null)
                throw new ArgumentNullException(nameof(createDate), "Property is not nullable for class AuthorizePolicy.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class AuthorizePolicy.");

            return new AuthorizePolicy(id, policyName, authorizeType, policyValue, createDate, lastUpdate);
        }

        /// <summary>
        /// Serializes a <see cref="AuthorizePolicy" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="authorizePolicy"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AuthorizePolicy authorizePolicy, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, authorizePolicy, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AuthorizePolicy" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="authorizePolicy"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AuthorizePolicy authorizePolicy, JsonSerializerOptions jsonSerializerOptions)
        {
            if (authorizePolicy.IdOption.IsSet)
                writer.WriteNumber("id", authorizePolicy.IdOption.Value.Value);

            if (authorizePolicy.PolicyNameOption.IsSet)
                if (authorizePolicy.PolicyNameOption.Value != null)
                    writer.WriteString("policyName", authorizePolicy.PolicyName);
                else
                    writer.WriteNull("policyName");

            if (authorizePolicy.AuthorizeTypeOption.IsSet)
                if (authorizePolicy.AuthorizeTypeOption.Value != null)
                    writer.WriteString("authorizeType", authorizePolicy.AuthorizeType);
                else
                    writer.WriteNull("authorizeType");

            if (authorizePolicy.PolicyValueOption.IsSet)
                if (authorizePolicy.PolicyValueOption.Value != null)
                    writer.WriteString("policyValue", authorizePolicy.PolicyValue);
                else
                    writer.WriteNull("policyValue");

            if (authorizePolicy.CreateDateOption.IsSet)
                writer.WriteString("createDate", authorizePolicy.CreateDateOption.Value.Value.ToString(CreateDateFormat));

            if (authorizePolicy.LastUpdateOption.IsSet)
                writer.WriteString("lastUpdate", authorizePolicy.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));
        }
    }
}
