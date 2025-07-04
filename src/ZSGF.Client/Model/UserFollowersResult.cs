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
    /// UserFollowersResult
    /// </summary>
    public partial class UserFollowersResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFollowersResult" /> class.
        /// </summary>
        /// <param name="totalFollowers">totalFollowers</param>
        /// <param name="data">data</param>
        [JsonConstructor]
        public UserFollowersResult(Option<long?> totalFollowers = default, Option<List<FollowerModel>> data = default)
        {
            TotalFollowersOption = totalFollowers;
            DataOption = data;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of TotalFollowers
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> TotalFollowersOption { get; private set; }

        /// <summary>
        /// Gets or Sets TotalFollowers
        /// </summary>
        [JsonPropertyName("totalFollowers")]
        public long? TotalFollowers { get { return this.TotalFollowersOption; } set { this.TotalFollowersOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<FollowerModel>> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<FollowerModel> Data { get { return this.DataOption; } set { this.DataOption = new Option<List<FollowerModel>>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserFollowersResult {\n");
            sb.Append("  TotalFollowers: ").Append(TotalFollowers).Append("\n");
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
    /// A Json converter for type <see cref="UserFollowersResult" />
    /// </summary>
    public class UserFollowersResultJsonConverter : JsonConverter<UserFollowersResult>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserFollowersResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserFollowersResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> totalFollowers = default;
            Option<List<FollowerModel>> data = default;

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
                        case "totalFollowers":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                totalFollowers = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "data":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                data = new Option<List<FollowerModel>>(JsonSerializer.Deserialize<List<FollowerModel>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (totalFollowers.IsSet && totalFollowers.Value == null)
                throw new ArgumentNullException(nameof(totalFollowers), "Property is not nullable for class UserFollowersResult.");

            return new UserFollowersResult(totalFollowers, data);
        }

        /// <summary>
        /// Serializes a <see cref="UserFollowersResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userFollowersResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserFollowersResult userFollowersResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userFollowersResult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserFollowersResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userFollowersResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserFollowersResult userFollowersResult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userFollowersResult.TotalFollowersOption.IsSet)
                writer.WriteNumber("totalFollowers", userFollowersResult.TotalFollowersOption.Value.Value);

            if (userFollowersResult.DataOption.IsSet)
                if (userFollowersResult.DataOption.Value != null)
                {
                    writer.WritePropertyName("data");
                    JsonSerializer.Serialize(writer, userFollowersResult.Data, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("data");
        }
    }
}
