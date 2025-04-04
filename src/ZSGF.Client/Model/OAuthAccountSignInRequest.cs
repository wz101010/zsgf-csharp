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
    /// OAuthAccountSignInRequest
    /// </summary>
    public partial class OAuthAccountSignInRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthAccountSignInRequest" /> class.
        /// </summary>
        /// <param name="unionID">unionID</param>
        /// <param name="platform">platform</param>
        /// <param name="twoFactorCode">如果启用双因素认证登录，则必填</param>
        [JsonConstructor]
        public OAuthAccountSignInRequest(string unionID, string platform, Option<string> twoFactorCode = default)
        {
            UnionID = unionID;
            Platform = platform;
            TwoFactorCodeOption = twoFactorCode;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets UnionID
        /// </summary>
        [JsonPropertyName("unionID")]
        public string UnionID { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

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
            sb.Append("class OAuthAccountSignInRequest {\n");
            sb.Append("  UnionID: ").Append(UnionID).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
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
            // UnionID (string) minLength
            if (this.UnionID != null && this.UnionID.Length < 1)
            {
                yield return new ValidationResult("Invalid value for UnionID, length must be greater than 1.", new [] { "UnionID" });
            }

            // Platform (string) minLength
            if (this.Platform != null && this.Platform.Length < 1)
            {
                yield return new ValidationResult("Invalid value for Platform, length must be greater than 1.", new [] { "Platform" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="OAuthAccountSignInRequest" />
    /// </summary>
    public class OAuthAccountSignInRequestJsonConverter : JsonConverter<OAuthAccountSignInRequest>
    {
        /// <summary>
        /// Deserializes json to <see cref="OAuthAccountSignInRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override OAuthAccountSignInRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> unionID = default;
            Option<string> platform = default;
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
                        case "unionID":
                            unionID = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "platform":
                            platform = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "twoFactorCode":
                            twoFactorCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!unionID.IsSet)
                throw new ArgumentException("Property is required for class OAuthAccountSignInRequest.", nameof(unionID));

            if (!platform.IsSet)
                throw new ArgumentException("Property is required for class OAuthAccountSignInRequest.", nameof(platform));

            if (unionID.IsSet && unionID.Value == null)
                throw new ArgumentNullException(nameof(unionID), "Property is not nullable for class OAuthAccountSignInRequest.");

            if (platform.IsSet && platform.Value == null)
                throw new ArgumentNullException(nameof(platform), "Property is not nullable for class OAuthAccountSignInRequest.");

            return new OAuthAccountSignInRequest(unionID.Value, platform.Value, twoFactorCode);
        }

        /// <summary>
        /// Serializes a <see cref="OAuthAccountSignInRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="oAuthAccountSignInRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, OAuthAccountSignInRequest oAuthAccountSignInRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, oAuthAccountSignInRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="OAuthAccountSignInRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="oAuthAccountSignInRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, OAuthAccountSignInRequest oAuthAccountSignInRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (oAuthAccountSignInRequest.UnionID == null)
                throw new ArgumentNullException(nameof(oAuthAccountSignInRequest.UnionID), "Property is required for class OAuthAccountSignInRequest.");

            if (oAuthAccountSignInRequest.Platform == null)
                throw new ArgumentNullException(nameof(oAuthAccountSignInRequest.Platform), "Property is required for class OAuthAccountSignInRequest.");

            writer.WriteString("unionID", oAuthAccountSignInRequest.UnionID);

            writer.WriteString("platform", oAuthAccountSignInRequest.Platform);

            if (oAuthAccountSignInRequest.TwoFactorCodeOption.IsSet)
                if (oAuthAccountSignInRequest.TwoFactorCodeOption.Value != null)
                    writer.WriteString("twoFactorCode", oAuthAccountSignInRequest.TwoFactorCode);
                else
                    writer.WriteNull("twoFactorCode");
        }
    }
}
