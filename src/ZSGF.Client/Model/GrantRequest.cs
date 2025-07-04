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
    /// GrantRequest
    /// </summary>
    public partial class GrantRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GrantRequest" /> class.
        /// </summary>
        /// <param name="grantType">授权类型。可选：email、phone、unionid、account</param>
        /// <param name="scopes">自定义授权范围，用英文空格分隔</param>
        /// <param name="redirectUri">返回地址。默认无限制，也可在【安全-开放认证网址白名单】配置</param>
        /// <param name="userName">用户名。授权类型为：email/phone/account必填</param>
        /// <param name="password">登录密码。授权类型为：email/phone/account必填</param>
        /// <param name="unionId">unionId。授权类型为：unionid必填</param>
        /// <param name="platform">平台。授权类型为：unionid必填</param>
        /// <param name="expireInDays">授权有效期。1~99天</param>
        [JsonConstructor]
        public GrantRequest(string grantType, string scopes, Option<string> redirectUri = default, Option<string> userName = default, Option<string> password = default, Option<string> unionId = default, Option<string> platform = default, Option<int?> expireInDays = default)
        {
            GrantType = grantType;
            Scopes = scopes;
            RedirectUriOption = redirectUri;
            UserNameOption = userName;
            PasswordOption = password;
            UnionIdOption = unionId;
            PlatformOption = platform;
            ExpireInDaysOption = expireInDays;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// 授权类型。可选：email、phone、unionid、account
        /// </summary>
        /// <value>授权类型。可选：email、phone、unionid、account</value>
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 自定义授权范围，用英文空格分隔
        /// </summary>
        /// <value>自定义授权范围，用英文空格分隔</value>
        [JsonPropertyName("scopes")]
        public string Scopes { get; set; }

        /// <summary>
        /// Used to track the state of RedirectUri
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> RedirectUriOption { get; private set; }

        /// <summary>
        /// 返回地址。默认无限制，也可在【安全-开放认证网址白名单】配置
        /// </summary>
        /// <value>返回地址。默认无限制，也可在【安全-开放认证网址白名单】配置</value>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get { return this.RedirectUriOption; } set { this.RedirectUriOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of UserName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> UserNameOption { get; private set; }

        /// <summary>
        /// 用户名。授权类型为：email/phone/account必填
        /// </summary>
        /// <value>用户名。授权类型为：email/phone/account必填</value>
        [JsonPropertyName("userName")]
        public string UserName { get { return this.UserNameOption; } set { this.UserNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Password
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PasswordOption { get; private set; }

        /// <summary>
        /// 登录密码。授权类型为：email/phone/account必填
        /// </summary>
        /// <value>登录密码。授权类型为：email/phone/account必填</value>
        [JsonPropertyName("password")]
        public string Password { get { return this.PasswordOption; } set { this.PasswordOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of UnionId
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> UnionIdOption { get; private set; }

        /// <summary>
        /// unionId。授权类型为：unionid必填
        /// </summary>
        /// <value>unionId。授权类型为：unionid必填</value>
        [JsonPropertyName("unionId")]
        public string UnionId { get { return this.UnionIdOption; } set { this.UnionIdOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Platform
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PlatformOption { get; private set; }

        /// <summary>
        /// 平台。授权类型为：unionid必填
        /// </summary>
        /// <value>平台。授权类型为：unionid必填</value>
        [JsonPropertyName("platform")]
        public string Platform { get { return this.PlatformOption; } set { this.PlatformOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ExpireInDays
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ExpireInDaysOption { get; private set; }

        /// <summary>
        /// 授权有效期。1~99天
        /// </summary>
        /// <value>授权有效期。1~99天</value>
        [JsonPropertyName("expireInDays")]
        public int? ExpireInDays { get { return this.ExpireInDaysOption; } set { this.ExpireInDaysOption = new Option<int?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GrantRequest {\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  UnionId: ").Append(UnionId).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ExpireInDays: ").Append(ExpireInDays).Append("\n");
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
            // GrantType (string) minLength
            if (this.GrantType != null && this.GrantType.Length < 1)
            {
                yield return new ValidationResult("Invalid value for GrantType, length must be greater than 1.", new [] { "GrantType" });
            }

            if (this.GrantType != null) {
                // GrantType (string) pattern
                Regex regexGrantType = new Regex(@"^(email|phone|unionid|account)$", RegexOptions.CultureInvariant);

                if (!regexGrantType.Match(this.GrantType).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GrantType, must match a pattern of " + regexGrantType, new [] { "GrantType" });
                }
            }

            // Scopes (string) minLength
            if (this.Scopes != null && this.Scopes.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Scopes, length must be greater than 1.", new [] { "Scopes" });
            }

            // ExpireInDays (int) maximum
            if (this.ExpireInDaysOption.IsSet && this.ExpireInDaysOption.Value > (int)99)
            {
                yield return new ValidationResult("Invalid value for ExpireInDays, must be a value less than or equal to 99.", new [] { "ExpireInDays" });
            }

            // ExpireInDays (int) minimum
            if (this.ExpireInDaysOption.IsSet && this.ExpireInDaysOption.Value < (int)1)
            {
                yield return new ValidationResult("Invalid value for ExpireInDays, must be a value greater than or equal to 1.", new [] { "ExpireInDays" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="GrantRequest" />
    /// </summary>
    public class GrantRequestJsonConverter : JsonConverter<GrantRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="GrantRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GrantRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> grantType = default;
            Option<string> scopes = default;
            Option<string> redirectUri = default;
            Option<string> userName = default;
            Option<string> password = default;
            Option<string> unionId = default;
            Option<string> platform = default;
            Option<int?> expireInDays = default;

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
                        case "grant_type":
                            grantType = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "scopes":
                            scopes = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "redirect_uri":
                            redirectUri = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "userName":
                            userName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "password":
                            password = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "unionId":
                            unionId = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "platform":
                            platform = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "expireInDays":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                expireInDays = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!grantType.IsSet)
                throw new ArgumentException("Property is required for class GrantRequest.", nameof(grantType));

            if (!scopes.IsSet)
                throw new ArgumentException("Property is required for class GrantRequest.", nameof(scopes));

            if (grantType.IsSet && grantType.Value == null)
                throw new ArgumentNullException(nameof(grantType), "Property is not nullable for class GrantRequest.");

            if (scopes.IsSet && scopes.Value == null)
                throw new ArgumentNullException(nameof(scopes), "Property is not nullable for class GrantRequest.");

            if (expireInDays.IsSet && expireInDays.Value == null)
                throw new ArgumentNullException(nameof(expireInDays), "Property is not nullable for class GrantRequest.");

            return new GrantRequest(grantType.Value, scopes.Value, redirectUri, userName, password, unionId, platform, expireInDays);
        }

        /// <summary>
        /// Serializes a <see cref="GrantRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="grantRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GrantRequest grantRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, grantRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GrantRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="grantRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GrantRequest grantRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (grantRequest.GrantType == null)
                throw new ArgumentNullException(nameof(grantRequest.GrantType), "Property is required for class GrantRequest.");

            if (grantRequest.Scopes == null)
                throw new ArgumentNullException(nameof(grantRequest.Scopes), "Property is required for class GrantRequest.");

            writer.WriteString("grant_type", grantRequest.GrantType);

            writer.WriteString("scopes", grantRequest.Scopes);

            if (grantRequest.RedirectUriOption.IsSet)
                if (grantRequest.RedirectUriOption.Value != null)
                    writer.WriteString("redirect_uri", grantRequest.RedirectUri);
                else
                    writer.WriteNull("redirect_uri");

            if (grantRequest.UserNameOption.IsSet)
                if (grantRequest.UserNameOption.Value != null)
                    writer.WriteString("userName", grantRequest.UserName);
                else
                    writer.WriteNull("userName");

            if (grantRequest.PasswordOption.IsSet)
                if (grantRequest.PasswordOption.Value != null)
                    writer.WriteString("password", grantRequest.Password);
                else
                    writer.WriteNull("password");

            if (grantRequest.UnionIdOption.IsSet)
                if (grantRequest.UnionIdOption.Value != null)
                    writer.WriteString("unionId", grantRequest.UnionId);
                else
                    writer.WriteNull("unionId");

            if (grantRequest.PlatformOption.IsSet)
                if (grantRequest.PlatformOption.Value != null)
                    writer.WriteString("platform", grantRequest.Platform);
                else
                    writer.WriteNull("platform");

            if (grantRequest.ExpireInDaysOption.IsSet)
                writer.WriteNumber("expireInDays", grantRequest.ExpireInDaysOption.Value.Value);
        }
    }
}
