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
    /// UserFriendsNearByResult
    /// </summary>
    public partial class UserFriendsNearByResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFriendsNearByResult" /> class.
        /// </summary>
        /// <param name="totalFollowers">totalFollowers</param>
        /// <param name="data">data</param>
        [JsonConstructor]
        public UserFriendsNearByResult(Option<long?> totalFollowers = default, Option<List<RecommendFriend>> data = default)
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
        public Option<List<RecommendFriend>> DataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [JsonPropertyName("data")]
        public List<RecommendFriend> Data { get { return this.DataOption; } set { this.DataOption = new Option<List<RecommendFriend>>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserFriendsNearByResult {\n");
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
    /// A Json converter for type <see cref="UserFriendsNearByResult" />
    /// </summary>
    public class UserFriendsNearByResultJsonConverter : JsonConverter<UserFriendsNearByResult>
    {
        /// <summary>
        /// Deserializes json to <see cref="UserFriendsNearByResult" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserFriendsNearByResult Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> totalFollowers = default;
            Option<List<RecommendFriend>> data = default;

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
                                data = new Option<List<RecommendFriend>>(JsonSerializer.Deserialize<List<RecommendFriend>>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (totalFollowers.IsSet && totalFollowers.Value == null)
                throw new ArgumentNullException(nameof(totalFollowers), "Property is not nullable for class UserFriendsNearByResult.");

            return new UserFriendsNearByResult(totalFollowers, data);
        }

        /// <summary>
        /// Serializes a <see cref="UserFriendsNearByResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userFriendsNearByResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserFriendsNearByResult userFriendsNearByResult, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userFriendsNearByResult, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserFriendsNearByResult" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userFriendsNearByResult"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserFriendsNearByResult userFriendsNearByResult, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userFriendsNearByResult.TotalFollowersOption.IsSet)
                writer.WriteNumber("totalFollowers", userFriendsNearByResult.TotalFollowersOption.Value.Value);

            if (userFriendsNearByResult.DataOption.IsSet)
                if (userFriendsNearByResult.DataOption.Value != null)
                {
                    writer.WritePropertyName("data");
                    JsonSerializer.Serialize(writer, userFriendsNearByResult.Data, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("data");
        }
    }
}
