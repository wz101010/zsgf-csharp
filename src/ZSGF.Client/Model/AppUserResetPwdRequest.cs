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
    /// AppUserResetPwdRequest
    /// </summary>
    public partial class AppUserResetPwdRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppUserResetPwdRequest" /> class.
        /// </summary>
        /// <param name="pwd">新的密码</param>
        /// <param name="oldpwd">旧的密码</param>
        [JsonConstructor]
        public AppUserResetPwdRequest(string pwd, string oldpwd)
        {
            Pwd = pwd;
            Oldpwd = oldpwd;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// 新的密码
        /// </summary>
        /// <value>新的密码</value>
        [JsonPropertyName("pwd")]
        public string Pwd { get; set; }

        /// <summary>
        /// 旧的密码
        /// </summary>
        /// <value>旧的密码</value>
        [JsonPropertyName("oldpwd")]
        public string Oldpwd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppUserResetPwdRequest {\n");
            sb.Append("  Pwd: ").Append(Pwd).Append("\n");
            sb.Append("  Oldpwd: ").Append(Oldpwd).Append("\n");
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
            // Pwd (string) minLength
            if (this.Pwd != null && this.Pwd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Pwd, length must be greater than 1.", new [] { "Pwd" });
            }

            if (this.Pwd != null) {
                // Pwd (string) pattern
                Regex regexPwd = new Regex(@"^.{6,32}$", RegexOptions.CultureInvariant);

                if (!regexPwd.Match(this.Pwd).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pwd, must match a pattern of " + regexPwd, new [] { "Pwd" });
                }
            }

            // Oldpwd (string) minLength
            if (this.Oldpwd != null && this.Oldpwd.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Oldpwd, length must be greater than 1.", new [] { "Oldpwd" });
            }

            if (this.Oldpwd != null) {
                // Oldpwd (string) pattern
                Regex regexOldpwd = new Regex(@"^.{6,32}$", RegexOptions.CultureInvariant);

                if (!regexOldpwd.Match(this.Oldpwd).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Oldpwd, must match a pattern of " + regexOldpwd, new [] { "Oldpwd" });
                }
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="AppUserResetPwdRequest" />
    /// </summary>
    public class AppUserResetPwdRequestJsonConverter : JsonConverter<AppUserResetPwdRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="AppUserResetPwdRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override AppUserResetPwdRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> pwd = default;
            Option<string> oldpwd = default;

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
                        case "pwd":
                            pwd = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "oldpwd":
                            oldpwd = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!pwd.IsSet)
                throw new ArgumentException("Property is required for class AppUserResetPwdRequest.", nameof(pwd));

            if (!oldpwd.IsSet)
                throw new ArgumentException("Property is required for class AppUserResetPwdRequest.", nameof(oldpwd));

            if (pwd.IsSet && pwd.Value == null)
                throw new ArgumentNullException(nameof(pwd), "Property is not nullable for class AppUserResetPwdRequest.");

            if (oldpwd.IsSet && oldpwd.Value == null)
                throw new ArgumentNullException(nameof(oldpwd), "Property is not nullable for class AppUserResetPwdRequest.");

            return new AppUserResetPwdRequest(pwd.Value, oldpwd.Value);
        }

        /// <summary>
        /// Serializes a <see cref="AppUserResetPwdRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appUserResetPwdRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, AppUserResetPwdRequest appUserResetPwdRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, appUserResetPwdRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="AppUserResetPwdRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="appUserResetPwdRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, AppUserResetPwdRequest appUserResetPwdRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (appUserResetPwdRequest.Pwd == null)
                throw new ArgumentNullException(nameof(appUserResetPwdRequest.Pwd), "Property is required for class AppUserResetPwdRequest.");

            if (appUserResetPwdRequest.Oldpwd == null)
                throw new ArgumentNullException(nameof(appUserResetPwdRequest.Oldpwd), "Property is required for class AppUserResetPwdRequest.");

            writer.WriteString("pwd", appUserResetPwdRequest.Pwd);

            writer.WriteString("oldpwd", appUserResetPwdRequest.Oldpwd);
        }
    }
}
