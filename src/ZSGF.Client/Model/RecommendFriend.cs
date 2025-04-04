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
    /// RecommendFriend
    /// </summary>
    public partial class RecommendFriend : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendFriend" /> class.
        /// </summary>
        /// <param name="userID">userID</param>
        /// <param name="nickName">nickName</param>
        /// <param name="avatar">avatar</param>
        /// <param name="gender">gender</param>
        /// <param name="age">age</param>
        /// <param name="interestTags">interestTags</param>
        /// <param name="locationName">locationName</param>
        /// <param name="latitude">latitude</param>
        /// <param name="longitude">longitude</param>
        /// <param name="distance">distance</param>
        [JsonConstructor]
        public RecommendFriend(Option<long?> userID = default, Option<string> nickName = default, Option<string> avatar = default, Option<string> gender = default, Option<int?> age = default, Option<string> interestTags = default, Option<string> locationName = default, Option<double?> latitude = default, Option<double?> longitude = default, Option<long?> distance = default)
        {
            UserIDOption = userID;
            NickNameOption = nickName;
            AvatarOption = avatar;
            GenderOption = gender;
            AgeOption = age;
            InterestTagsOption = interestTags;
            LocationNameOption = locationName;
            LatitudeOption = latitude;
            LongitudeOption = longitude;
            DistanceOption = distance;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of UserID
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> UserIDOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [JsonPropertyName("userID")]
        public long? UserID { get { return this.UserIDOption; } set { this.UserIDOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of NickName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NickNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets NickName
        /// </summary>
        [JsonPropertyName("nickName")]
        public string NickName { get { return this.NickNameOption; } set { this.NickNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Avatar
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> AvatarOption { get; private set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [JsonPropertyName("avatar")]
        public string Avatar { get { return this.AvatarOption; } set { this.AvatarOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Gender
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> GenderOption { get; private set; }

        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get { return this.GenderOption; } set { this.GenderOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Age
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> AgeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [JsonPropertyName("age")]
        public int? Age { get { return this.AgeOption; } set { this.AgeOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of InterestTags
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> InterestTagsOption { get; private set; }

        /// <summary>
        /// Gets or Sets InterestTags
        /// </summary>
        [JsonPropertyName("interestTags")]
        public string InterestTags { get { return this.InterestTagsOption; } set { this.InterestTagsOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of LocationName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> LocationNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets LocationName
        /// </summary>
        [JsonPropertyName("locationName")]
        public string LocationName { get { return this.LocationNameOption; } set { this.LocationNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Latitude
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> LatitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [JsonPropertyName("latitude")]
        public double? Latitude { get { return this.LatitudeOption; } set { this.LatitudeOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of Longitude
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<double?> LongitudeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [JsonPropertyName("longitude")]
        public double? Longitude { get { return this.LongitudeOption; } set { this.LongitudeOption = new Option<double?>(value); } }

        /// <summary>
        /// Used to track the state of Distance
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> DistanceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [JsonPropertyName("distance")]
        public long? Distance { get { return this.DistanceOption; } set { this.DistanceOption = new Option<long?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecommendFriend {\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  InterestTags: ").Append(InterestTags).Append("\n");
            sb.Append("  LocationName: ").Append(LocationName).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
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
    /// A Json converter for type <see cref="RecommendFriend" />
    /// </summary>
    public class RecommendFriendJsonConverter : JsonConverter<RecommendFriend>
    {
        /// <summary>
        /// Deserializes json to <see cref="RecommendFriend" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override RecommendFriend Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> userID = default;
            Option<string> nickName = default;
            Option<string> avatar = default;
            Option<string> gender = default;
            Option<int?> age = default;
            Option<string> interestTags = default;
            Option<string> locationName = default;
            Option<double?> latitude = default;
            Option<double?> longitude = default;
            Option<long?> distance = default;

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
                        case "userID":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userID = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "nickName":
                            nickName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "avatar":
                            avatar = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "gender":
                            gender = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "age":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                age = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "interestTags":
                            interestTags = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "locationName":
                            locationName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "latitude":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                latitude = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "longitude":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                longitude = new Option<double?>(utf8JsonReader.GetDouble());
                            break;
                        case "distance":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                distance = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (userID.IsSet && userID.Value == null)
                throw new ArgumentNullException(nameof(userID), "Property is not nullable for class RecommendFriend.");

            if (age.IsSet && age.Value == null)
                throw new ArgumentNullException(nameof(age), "Property is not nullable for class RecommendFriend.");

            if (latitude.IsSet && latitude.Value == null)
                throw new ArgumentNullException(nameof(latitude), "Property is not nullable for class RecommendFriend.");

            if (longitude.IsSet && longitude.Value == null)
                throw new ArgumentNullException(nameof(longitude), "Property is not nullable for class RecommendFriend.");

            if (distance.IsSet && distance.Value == null)
                throw new ArgumentNullException(nameof(distance), "Property is not nullable for class RecommendFriend.");

            return new RecommendFriend(userID, nickName, avatar, gender, age, interestTags, locationName, latitude, longitude, distance);
        }

        /// <summary>
        /// Serializes a <see cref="RecommendFriend" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="recommendFriend"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, RecommendFriend recommendFriend, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, recommendFriend, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="RecommendFriend" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="recommendFriend"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, RecommendFriend recommendFriend, JsonSerializerOptions jsonSerializerOptions)
        {
            if (recommendFriend.UserIDOption.IsSet)
                writer.WriteNumber("userID", recommendFriend.UserIDOption.Value.Value);

            if (recommendFriend.NickNameOption.IsSet)
                if (recommendFriend.NickNameOption.Value != null)
                    writer.WriteString("nickName", recommendFriend.NickName);
                else
                    writer.WriteNull("nickName");

            if (recommendFriend.AvatarOption.IsSet)
                if (recommendFriend.AvatarOption.Value != null)
                    writer.WriteString("avatar", recommendFriend.Avatar);
                else
                    writer.WriteNull("avatar");

            if (recommendFriend.GenderOption.IsSet)
                if (recommendFriend.GenderOption.Value != null)
                    writer.WriteString("gender", recommendFriend.Gender);
                else
                    writer.WriteNull("gender");

            if (recommendFriend.AgeOption.IsSet)
                writer.WriteNumber("age", recommendFriend.AgeOption.Value.Value);

            if (recommendFriend.InterestTagsOption.IsSet)
                if (recommendFriend.InterestTagsOption.Value != null)
                    writer.WriteString("interestTags", recommendFriend.InterestTags);
                else
                    writer.WriteNull("interestTags");

            if (recommendFriend.LocationNameOption.IsSet)
                if (recommendFriend.LocationNameOption.Value != null)
                    writer.WriteString("locationName", recommendFriend.LocationName);
                else
                    writer.WriteNull("locationName");

            if (recommendFriend.LatitudeOption.IsSet)
                writer.WriteNumber("latitude", recommendFriend.LatitudeOption.Value.Value);

            if (recommendFriend.LongitudeOption.IsSet)
                writer.WriteNumber("longitude", recommendFriend.LongitudeOption.Value.Value);

            if (recommendFriend.DistanceOption.IsSet)
                writer.WriteNumber("distance", recommendFriend.DistanceOption.Value.Value);
        }
    }
}
