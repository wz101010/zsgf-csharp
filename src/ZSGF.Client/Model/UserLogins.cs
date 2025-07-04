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
    /// 用户外部账号
    /// </summary>
    public partial class UserLogins : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserLogins" /> class.
        /// </summary>
        /// <param name="id">唯一标识符</param>
        /// <param name="userID">关联的用户ID</param>
        /// <param name="platformName">第三方平台名称</param>
        /// <param name="platform">第三方平台</param>
        /// <param name="unionID">第三方平台唯一标识</param>
        /// <param name="avatar">用户头像</param>
        /// <param name="data">扩展数据</param>
        /// <param name="enable">启用</param>
        /// <param name="createDate">创建时间</param>
        /// <param name="lastUpdate">最后更新时间</param>
        [JsonConstructor]
        public UserLogins(Option<long?> id = default, Option<long?> userID = default, Option<string> platformName = default, Option<string> platform = default, Option<string> unionID = default, Option<string> avatar = default, Option<string> data = default, Option<bool?> enable = default, Option<DateTime?> createDate = default, Option<DateTime?> lastUpdate = default)
        {
            IdOption = id;
            UserIDOption = userID;
            PlatformNameOption = platformName;
            PlatformOption = platform;
            UnionIDOption = unionID;
            AvatarOption = avatar;
            DataOption = data;
            EnableOption = enable;
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
        /// 唯一标识符
        /// </summary>
        /// <value>唯一标识符</value>
        [JsonPropertyName("id")]
        public long? Id { get { return this.IdOption; } set { this.IdOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of UserID
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> UserIDOption { get; private set; }

        /// <summary>
        /// 关联的用户ID
        /// </summary>
        /// <value>关联的用户ID</value>
        [JsonPropertyName("userID")]
        public long? UserID { get { return this.UserIDOption; } set { this.UserIDOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of PlatformName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PlatformNameOption { get; private set; }

        /// <summary>
        /// 第三方平台名称
        /// </summary>
        /// <value>第三方平台名称</value>
        [JsonPropertyName("platformName")]
        public string PlatformName { get { return this.PlatformNameOption; } set { this.PlatformNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Platform
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PlatformOption { get; private set; }

        /// <summary>
        /// 第三方平台
        /// </summary>
        /// <value>第三方平台</value>
        [JsonPropertyName("platform")]
        public string Platform { get { return this.PlatformOption; } set { this.PlatformOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of UnionID
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> UnionIDOption { get; private set; }

        /// <summary>
        /// 第三方平台唯一标识
        /// </summary>
        /// <value>第三方平台唯一标识</value>
        [JsonPropertyName("unionID")]
        public string UnionID { get { return this.UnionIDOption; } set { this.UnionIDOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Avatar
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> AvatarOption { get; private set; }

        /// <summary>
        /// 用户头像
        /// </summary>
        /// <value>用户头像</value>
        [JsonPropertyName("avatar")]
        public string Avatar { get { return this.AvatarOption; } set { this.AvatarOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> DataOption { get; private set; }

        /// <summary>
        /// 扩展数据
        /// </summary>
        /// <value>扩展数据</value>
        [JsonPropertyName("data")]
        public string Data { get { return this.DataOption; } set { this.DataOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Enable
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> EnableOption { get; private set; }

        /// <summary>
        /// 启用
        /// </summary>
        /// <value>启用</value>
        [JsonPropertyName("enable")]
        public bool? Enable { get { return this.EnableOption; } set { this.EnableOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of CreateDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreateDateOption { get; private set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [JsonPropertyName("createDate")]
        public DateTime? CreateDate { get { return this.CreateDateOption; } set { this.CreateDateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        /// <value>最后更新时间</value>
        [JsonPropertyName("lastUpdate")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserLogins {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  PlatformName: ").Append(PlatformName).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  UnionID: ").Append(UnionID).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Enable: ").Append(Enable).Append("\n");
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
            // PlatformName (string) maxLength
            if (this.PlatformName != null && this.PlatformName.Length > 50)
            {
                yield return new ValidationResult("Invalid value for PlatformName, length must be less than 50.", new [] { "PlatformName" });
            }

            // Platform (string) maxLength
            if (this.Platform != null && this.Platform.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Platform, length must be less than 50.", new [] { "Platform" });
            }

            // UnionID (string) maxLength
            if (this.UnionID != null && this.UnionID.Length > 100)
            {
                yield return new ValidationResult("Invalid value for UnionID, length must be less than 100.", new [] { "UnionID" });
            }

            // Avatar (string) maxLength
            if (this.Avatar != null && this.Avatar.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Avatar, length must be less than 255.", new [] { "Avatar" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="UserLogins" />
    /// </summary>
    public class UserLoginsJsonConverter : JsonConverter<UserLogins>
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
        /// Deserializes json to <see cref="UserLogins" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UserLogins Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<long?> userID = default;
            Option<string> platformName = default;
            Option<string> platform = default;
            Option<string> unionID = default;
            Option<string> avatar = default;
            Option<string> data = default;
            Option<bool?> enable = default;
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
                        case "platformName":
                            platformName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "platform":
                            platform = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "unionID":
                            unionID = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "avatar":
                            avatar = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "data":
                            data = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "enable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                enable = new Option<bool?>(utf8JsonReader.GetBoolean());
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
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class UserLogins.");

            if (userID.IsSet && userID.Value == null)
                throw new ArgumentNullException(nameof(userID), "Property is not nullable for class UserLogins.");

            if (enable.IsSet && enable.Value == null)
                throw new ArgumentNullException(nameof(enable), "Property is not nullable for class UserLogins.");

            if (createDate.IsSet && createDate.Value == null)
                throw new ArgumentNullException(nameof(createDate), "Property is not nullable for class UserLogins.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class UserLogins.");

            return new UserLogins(id, userID, platformName, platform, unionID, avatar, data, enable, createDate, lastUpdate);
        }

        /// <summary>
        /// Serializes a <see cref="UserLogins" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userLogins"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UserLogins userLogins, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, userLogins, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UserLogins" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="userLogins"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UserLogins userLogins, JsonSerializerOptions jsonSerializerOptions)
        {
            if (userLogins.IdOption.IsSet)
                writer.WriteNumber("id", userLogins.IdOption.Value.Value);

            if (userLogins.UserIDOption.IsSet)
                writer.WriteNumber("userID", userLogins.UserIDOption.Value.Value);

            if (userLogins.PlatformNameOption.IsSet)
                if (userLogins.PlatformNameOption.Value != null)
                    writer.WriteString("platformName", userLogins.PlatformName);
                else
                    writer.WriteNull("platformName");

            if (userLogins.PlatformOption.IsSet)
                if (userLogins.PlatformOption.Value != null)
                    writer.WriteString("platform", userLogins.Platform);
                else
                    writer.WriteNull("platform");

            if (userLogins.UnionIDOption.IsSet)
                if (userLogins.UnionIDOption.Value != null)
                    writer.WriteString("unionID", userLogins.UnionID);
                else
                    writer.WriteNull("unionID");

            if (userLogins.AvatarOption.IsSet)
                if (userLogins.AvatarOption.Value != null)
                    writer.WriteString("avatar", userLogins.Avatar);
                else
                    writer.WriteNull("avatar");

            if (userLogins.DataOption.IsSet)
                if (userLogins.DataOption.Value != null)
                    writer.WriteString("data", userLogins.Data);
                else
                    writer.WriteNull("data");

            if (userLogins.EnableOption.IsSet)
                writer.WriteBoolean("enable", userLogins.EnableOption.Value.Value);

            if (userLogins.CreateDateOption.IsSet)
                writer.WriteString("createDate", userLogins.CreateDateOption.Value.Value.ToString(CreateDateFormat));

            if (userLogins.LastUpdateOption.IsSet)
                writer.WriteString("lastUpdate", userLogins.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));
        }
    }
}
