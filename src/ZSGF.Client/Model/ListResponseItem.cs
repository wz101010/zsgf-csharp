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
    /// ListResponseItem
    /// </summary>
    public partial class ListResponseItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseItem" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="userID">userID</param>
        /// <param name="userName">userName</param>
        /// <param name="nickName">nickName</param>
        /// <param name="avatar">avatar</param>
        /// <param name="email">email</param>
        /// <param name="phone">phone</param>
        /// <param name="role">role</param>
        /// <param name="permission">permission</param>
        /// <param name="lastUpdate">lastUpdate</param>
        [JsonConstructor]
        public ListResponseItem(Option<long?> id = default, Option<long?> userID = default, Option<string> userName = default, Option<string> nickName = default, Option<string> avatar = default, Option<string> email = default, Option<string> phone = default, Option<string> role = default, Option<string> permission = default, Option<DateTime?> lastUpdate = default)
        {
            IdOption = id;
            UserIDOption = userID;
            UserNameOption = userName;
            NickNameOption = nickName;
            AvatarOption = avatar;
            EmailOption = email;
            PhoneOption = phone;
            RoleOption = role;
            PermissionOption = permission;
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
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public long? Id { get { return this.IdOption; } set { this.IdOption = new Option<long?>(value); } }

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
        /// Used to track the state of UserName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> UserNameOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get { return this.UserNameOption; } set { this.UserNameOption = new Option<string>(value); } }

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
        /// Used to track the state of Email
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> EmailOption { get; private set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get { return this.EmailOption; } set { this.EmailOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Phone
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PhoneOption { get; private set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [JsonPropertyName("phone")]
        public string Phone { get { return this.PhoneOption; } set { this.PhoneOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Role
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> RoleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get { return this.RoleOption; } set { this.RoleOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Permission
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PermissionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [JsonPropertyName("permission")]
        public string Permission { get { return this.PermissionOption; } set { this.PermissionOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// Gets or Sets LastUpdate
        /// </summary>
        [JsonPropertyName("lastUpdate")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListResponseItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
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
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ListResponseItem" />
    /// </summary>
    public class ListResponseItemJsonConverter : JsonConverter<ListResponseItem>
    {
        /// <summary>
        /// The format to use to serialize LastUpdate
        /// </summary>
        public static string LastUpdateFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="ListResponseItem" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ListResponseItem Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<long?> userID = default;
            Option<string> userName = default;
            Option<string> nickName = default;
            Option<string> avatar = default;
            Option<string> email = default;
            Option<string> phone = default;
            Option<string> role = default;
            Option<string> permission = default;
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
                        case "userName":
                            userName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "nickName":
                            nickName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "avatar":
                            avatar = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "email":
                            email = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "phone":
                            phone = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "role":
                            role = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "permission":
                            permission = new Option<string>(utf8JsonReader.GetString());
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
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ListResponseItem.");

            if (userID.IsSet && userID.Value == null)
                throw new ArgumentNullException(nameof(userID), "Property is not nullable for class ListResponseItem.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class ListResponseItem.");

            return new ListResponseItem(id, userID, userName, nickName, avatar, email, phone, role, permission, lastUpdate);
        }

        /// <summary>
        /// Serializes a <see cref="ListResponseItem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="listResponseItem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ListResponseItem listResponseItem, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, listResponseItem, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ListResponseItem" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="listResponseItem"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ListResponseItem listResponseItem, JsonSerializerOptions jsonSerializerOptions)
        {
            if (listResponseItem.IdOption.IsSet)
                writer.WriteNumber("id", listResponseItem.IdOption.Value.Value);

            if (listResponseItem.UserIDOption.IsSet)
                writer.WriteNumber("userID", listResponseItem.UserIDOption.Value.Value);

            if (listResponseItem.UserNameOption.IsSet)
                if (listResponseItem.UserNameOption.Value != null)
                    writer.WriteString("userName", listResponseItem.UserName);
                else
                    writer.WriteNull("userName");

            if (listResponseItem.NickNameOption.IsSet)
                if (listResponseItem.NickNameOption.Value != null)
                    writer.WriteString("nickName", listResponseItem.NickName);
                else
                    writer.WriteNull("nickName");

            if (listResponseItem.AvatarOption.IsSet)
                if (listResponseItem.AvatarOption.Value != null)
                    writer.WriteString("avatar", listResponseItem.Avatar);
                else
                    writer.WriteNull("avatar");

            if (listResponseItem.EmailOption.IsSet)
                if (listResponseItem.EmailOption.Value != null)
                    writer.WriteString("email", listResponseItem.Email);
                else
                    writer.WriteNull("email");

            if (listResponseItem.PhoneOption.IsSet)
                if (listResponseItem.PhoneOption.Value != null)
                    writer.WriteString("phone", listResponseItem.Phone);
                else
                    writer.WriteNull("phone");

            if (listResponseItem.RoleOption.IsSet)
                if (listResponseItem.RoleOption.Value != null)
                    writer.WriteString("role", listResponseItem.Role);
                else
                    writer.WriteNull("role");

            if (listResponseItem.PermissionOption.IsSet)
                if (listResponseItem.PermissionOption.Value != null)
                    writer.WriteString("permission", listResponseItem.Permission);
                else
                    writer.WriteNull("permission");

            if (listResponseItem.LastUpdateOption.IsSet)
                writer.WriteString("lastUpdate", listResponseItem.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));
        }
    }
}
