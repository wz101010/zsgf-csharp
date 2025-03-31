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
    /// PhoneSignInRequest
    /// </summary>
    public partial class PhoneSignInRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneSignInRequest" /> class.
        /// </summary>
        /// <param name="phone">phone</param>
        /// <param name="verifyCode">verifyCode</param>
        /// <param name="twoFactorCode">如果启用双因素认证登录，则必填</param>
        [JsonConstructor]
        public PhoneSignInRequest(string phone, string verifyCode, Option<string> twoFactorCode = default)
        {
            Phone = phone;
            VerifyCode = verifyCode;
            TwoFactorCodeOption = twoFactorCode;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets VerifyCode
        /// </summary>
        [JsonPropertyName("verifyCode")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// Used to track the state of TwoFactorCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TwoFactorCodeOption { get; private set; }

        /// <summary>
        /// 如果启用双因素认证登录，则必填
        /// </summary>
        /// <value>如果启用双因素认证登录，则必填</value>
        [JsonPropertyName("twoFactorCode")]
        public string TwoFactorCode { get { return this.TwoFactorCodeOption; } set { this.TwoFactorCodeOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PhoneSignInRequest {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  VerifyCode: ").Append(VerifyCode).Append("\n");
            sb.Append("  TwoFactorCode: ").Append(TwoFactorCode).Append("\n");
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
            // Phone (string) minLength
            if (this.Phone != null && this.Phone.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Phone, length must be greater than 1.", new [] { "Phone" });
            }

            // VerifyCode (string) minLength
            if (this.VerifyCode != null && this.VerifyCode.Length < 1)
            {
                yield return new ValidationResult("Invalid value for VerifyCode, length must be greater than 1.", new [] { "VerifyCode" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="PhoneSignInRequest" />
    /// </summary>
    public class PhoneSignInRequestJsonConverter : JsonConverter<PhoneSignInRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="PhoneSignInRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override PhoneSignInRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> phone = default;
            Option<string> verifyCode = default;
            Option<string> twoFactorCode = default;

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
                        case "phone":
                            phone = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "verifyCode":
                            verifyCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "twoFactorCode":
                            twoFactorCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!phone.IsSet)
                throw new ArgumentException("Property is required for class PhoneSignInRequest.", nameof(phone));

            if (!verifyCode.IsSet)
                throw new ArgumentException("Property is required for class PhoneSignInRequest.", nameof(verifyCode));

            if (phone.IsSet && phone.Value == null)
                throw new ArgumentNullException(nameof(phone), "Property is not nullable for class PhoneSignInRequest.");

            if (verifyCode.IsSet && verifyCode.Value == null)
                throw new ArgumentNullException(nameof(verifyCode), "Property is not nullable for class PhoneSignInRequest.");

            return new PhoneSignInRequest(phone.Value, verifyCode.Value, twoFactorCode);
        }

        /// <summary>
        /// Serializes a <see cref="PhoneSignInRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="phoneSignInRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, PhoneSignInRequest phoneSignInRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, phoneSignInRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="PhoneSignInRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="phoneSignInRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, PhoneSignInRequest phoneSignInRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (phoneSignInRequest.Phone == null)
                throw new ArgumentNullException(nameof(phoneSignInRequest.Phone), "Property is required for class PhoneSignInRequest.");

            if (phoneSignInRequest.VerifyCode == null)
                throw new ArgumentNullException(nameof(phoneSignInRequest.VerifyCode), "Property is required for class PhoneSignInRequest.");

            writer.WriteString("phone", phoneSignInRequest.Phone);

            writer.WriteString("verifyCode", phoneSignInRequest.VerifyCode);

            if (phoneSignInRequest.TwoFactorCodeOption.IsSet)
                if (phoneSignInRequest.TwoFactorCodeOption.Value != null)
                    writer.WriteString("twoFactorCode", phoneSignInRequest.TwoFactorCode);
                else
                    writer.WriteNull("twoFactorCode");
        }
    }
}
