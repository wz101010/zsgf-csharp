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
    /// 用户令牌实体，用于管理用户的访问令牌及其相关信息。
    /// </summary>
    public partial class UserAccessToken : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccessToken" /> class.
        /// </summary>
        /// <param name="id">用户令牌的唯一标识符。</param>
        /// <param name="userID">与令牌关联的用户ID。</param>
        /// <param name="enable">指示令牌是否处于启用状态。</param>
        /// <param name="permissions">令牌拥有的权限列表，多个权限以逗号分隔。</param>
        /// <param name="title">令牌的标题或名称，用于标识令牌。</param>
        /// <param name="accessToken">访问令牌的具体值，用于身份验证。</param>
        /// <param name="tags">用于分类或标记令牌的标签。</param>
        /// <param name="description">令牌的详细描述信息。</param>
        /// <param name="expireTime">令牌的过期时间，超过该时间令牌将失效。</param>
        /// <param name="createDate">令牌的创建日期，默认为当前时间。</param>
        /// <param name="lastUpdate">令牌的最后更新日期，默认为当前时间。</param>
        [JsonConstructor]
        public UserAccessToken(Option<long?> id = default, Option<long?> userID = default, Option<bool?> enable = default, Option<string> permissions = default, Option<string> title = default, Option<string> accessToken = default, Option<string> tags = default, Option<string> description = default, Option<DateTime?> expireTime = default, Option<DateTime?> createDate = default, Option<DateTime?> lastUpdate = default)
        {
            IdOption = id;
            UserIDOption = userID;
            EnableOption = enable;
            PermissionsOption = permissions;
            TitleOption = title;
            AccessTokenOption = accessToken;
            TagsOption = tags;
            DescriptionOption = description;
            ExpireTimeOption = expireTime;
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
        /// 用户令牌的唯一标识符。
        /// </summary>
        /// <value>用户令牌的唯一标识符。</value>
        [JsonPropertyName("id")]
        public long? Id { get { return this.IdOption; } set { this.IdOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of UserID
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> UserIDOption { get; private set; }

        /// <summary>
        /// 与令牌关联的用户ID。
        /// </summary>
        /// <value>与令牌关联的用户ID。</value>
        [JsonPropertyName("userID")]
        public long? UserID { get { return this.UserIDOption; } set { this.UserIDOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of Enable
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> EnableOption { get; private set; }

        /// <summary>
        /// 指示令牌是否处于启用状态。
        /// </summary>
        /// <value>指示令牌是否处于启用状态。</value>
        [JsonPropertyName("enable")]
        public bool? Enable { get { return this.EnableOption; } set { this.EnableOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of Permissions
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PermissionsOption { get; private set; }

        /// <summary>
        /// 令牌拥有的权限列表，多个权限以逗号分隔。
        /// </summary>
        /// <value>令牌拥有的权限列表，多个权限以逗号分隔。</value>
        [JsonPropertyName("permissions")]
        public string Permissions { get { return this.PermissionsOption; } set { this.PermissionsOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Title
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TitleOption { get; private set; }

        /// <summary>
        /// 令牌的标题或名称，用于标识令牌。
        /// </summary>
        /// <value>令牌的标题或名称，用于标识令牌。</value>
        [JsonPropertyName("title")]
        public string Title { get { return this.TitleOption; } set { this.TitleOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of AccessToken
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> AccessTokenOption { get; private set; }

        /// <summary>
        /// 访问令牌的具体值，用于身份验证。
        /// </summary>
        /// <value>访问令牌的具体值，用于身份验证。</value>
        [JsonPropertyName("accessToken")]
        public string AccessToken { get { return this.AccessTokenOption; } set { this.AccessTokenOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Tags
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TagsOption { get; private set; }

        /// <summary>
        /// 用于分类或标记令牌的标签。
        /// </summary>
        /// <value>用于分类或标记令牌的标签。</value>
        [JsonPropertyName("tags")]
        public string Tags { get { return this.TagsOption; } set { this.TagsOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> DescriptionOption { get; private set; }

        /// <summary>
        /// 令牌的详细描述信息。
        /// </summary>
        /// <value>令牌的详细描述信息。</value>
        [JsonPropertyName("description")]
        public string Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of ExpireTime
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> ExpireTimeOption { get; private set; }

        /// <summary>
        /// 令牌的过期时间，超过该时间令牌将失效。
        /// </summary>
        /// <value>令牌的过期时间，超过该时间令牌将失效。</value>
        [JsonPropertyName("expireTime")]
        public DateTime? ExpireTime { get { return this.ExpireTimeOption; } set { this.ExpireTimeOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of CreateDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreateDateOption { get; private set; }

        /// <summary>
        /// 令牌的创建日期，默认为当前时间。
        /// </summary>
        /// <value>令牌的创建日期，默认为当前时间。</value>
        [JsonPropertyName("createDate")]
        public DateTime? CreateDate { get { return this.CreateDateOption; } set { this.CreateDateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// 令牌的最后更新日期，默认为当前时间。
        /// </summary>
        /// <value>令牌的最后更新日期，默认为当前时间。</value>
        [JsonPropertyName("lastUpdate")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAccessToken {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpireTime: ").Append(ExpireTime).Append("\n");
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
            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Title, length must be less than 255.", new [] { "Title" });
            }

            // Tags (string) maxLength
            if (this.Tags != null && this.Tags.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Tags, length must be less than 255.", new [] { "Tags" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="UserAccessToken" />
    /// </summary>
    public class UserAccessTokenJsonConverter : JsonConverter<UserAccessToken>
    {
        /// <summary>
        /// The format to use to serialize ExpireTime
        /// </summary>
        public static string ExpireTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize CreateDate
        /// </summary>
        public static string CreateDateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize LastUpdate
        /// </summary>
        public static string LastUpdateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="UserAccessToken" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserAccessToken Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<long?> userID = default;
            Option<bool?> enable = default;
            Option<string> permissions = default;
            Option<string> title = default;
            Option<string> accessToken = default;
            Option<string> tags = default;
            Option<string> description = default;
            Option<DateTime?> expireTime = default;
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
                        case "userID":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                userID = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "enable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enable = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "permissions":
                            permissions = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "title":
                            title = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "accessToken":
                            accessToken = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "tags":
                            tags = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "description":
                            description = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "expireTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                expireTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
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
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class UserAccessToken.");

            if (userID.IsSet && userID.Value == null)
                throw new ArgumentNullException(nameof(userID), "Property is not nullable for class UserAccessToken.");

            if (enable.IsSet && enable.Value == null)
                throw new ArgumentNullException(nameof(enable), "Property is not nullable for class UserAccessToken.");

            if (expireTime.IsSet && expireTime.Value == null)
                throw new ArgumentNullException(nameof(expireTime), "Property is not nullable for class UserAccessToken.");

            if (createDate.IsSet && createDate.Value == null)
                throw new ArgumentNullException(nameof(createDate), "Property is not nullable for class UserAccessToken.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class UserAccessToken.");

            return new UserAccessToken(id, userID, enable, permissions, title, accessToken, tags, description, expireTime, createDate, lastUpdate);
        }

        /// <summary>
        /// Serializes a <see cref="UserAccessToken" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAccessToken"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserAccessToken userAccessToken, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userAccessToken, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserAccessToken" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userAccessToken"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserAccessToken userAccessToken, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userAccessToken.IdOption.IsSet)
                writer.WriteNumber("id", userAccessToken.IdOption.Value.Value);

            if (userAccessToken.UserIDOption.IsSet)
                writer.WriteNumber("userID", userAccessToken.UserIDOption.Value.Value);

            if (userAccessToken.EnableOption.IsSet)
                writer.WriteBoolean("enable", userAccessToken.EnableOption.Value.Value);

            if (userAccessToken.PermissionsOption.IsSet)
                if (userAccessToken.PermissionsOption.Value != null)
                    writer.WriteString("permissions", userAccessToken.Permissions);
                else
                    writer.WriteNull("permissions");

            if (userAccessToken.TitleOption.IsSet)
                if (userAccessToken.TitleOption.Value != null)
                    writer.WriteString("title", userAccessToken.Title);
                else
                    writer.WriteNull("title");

            if (userAccessToken.AccessTokenOption.IsSet)
                if (userAccessToken.AccessTokenOption.Value != null)
                    writer.WriteString("accessToken", userAccessToken.AccessToken);
                else
                    writer.WriteNull("accessToken");

            if (userAccessToken.TagsOption.IsSet)
                if (userAccessToken.TagsOption.Value != null)
                    writer.WriteString("tags", userAccessToken.Tags);
                else
                    writer.WriteNull("tags");

            if (userAccessToken.DescriptionOption.IsSet)
                if (userAccessToken.DescriptionOption.Value != null)
                    writer.WriteString("description", userAccessToken.Description);
                else
                    writer.WriteNull("description");

            if (userAccessToken.ExpireTimeOption.IsSet)
                writer.WriteString("expireTime", userAccessToken.ExpireTimeOption.Value.Value.ToString(ExpireTimeFormat));

            if (userAccessToken.CreateDateOption.IsSet)
                writer.WriteString("createDate", userAccessToken.CreateDateOption.Value.Value.ToString(CreateDateFormat));

            if (userAccessToken.LastUpdateOption.IsSet)
                writer.WriteString("lastUpdate", userAccessToken.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));
        }
    }
}
