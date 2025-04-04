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
    /// 服务商实体，用于表示和管理系统中的服务提供方信息。
    /// </summary>
    public partial class ServiceProvider : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProvider" /> class.
        /// </summary>
        /// <param name="id">服务商的唯一标识符。</param>
        /// <param name="bizCode">服务商的业务代码，用于标识其所属业务领域。</param>
        /// <param name="name">服务商的名称。</param>
        /// <param name="code">服务商的唯一代码，用于系统内部标识。</param>
        /// <param name="icon">服务商图标的URL或路径。</param>
        /// <param name="description">服务商的详细描述信息。</param>
        /// <param name="tags">用于分类或标记服务商的标签。</param>
        /// <param name="show">指示服务商是否在界面上显示。</param>
        /// <param name="showIndex">服务商在界面上的显示顺序。</param>
        /// <param name="createDate">服务商记录的创建日期，默认为当前时间。</param>
        /// <param name="lastUpdate">服务商记录的最后更新日期，默认为当前时间。</param>
        [JsonConstructor]
        public ServiceProvider(Option<long?> id = default, Option<string> bizCode = default, Option<string> name = default, Option<string> code = default, Option<string> icon = default, Option<string> description = default, Option<string> tags = default, Option<bool?> show = default, Option<int?> showIndex = default, Option<DateTime?> createDate = default, Option<DateTime?> lastUpdate = default)
        {
            IdOption = id;
            BizCodeOption = bizCode;
            NameOption = name;
            CodeOption = code;
            IconOption = icon;
            DescriptionOption = description;
            TagsOption = tags;
            ShowOption = show;
            ShowIndexOption = showIndex;
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
        /// 服务商的唯一标识符。
        /// </summary>
        /// <value>服务商的唯一标识符。</value>
        [JsonPropertyName("id")]
        public long? Id { get { return this.IdOption; } set { this.IdOption = new Option<long?>(value); } }

        /// <summary>
        /// Used to track the state of BizCode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> BizCodeOption { get; private set; }

        /// <summary>
        /// 服务商的业务代码，用于标识其所属业务领域。
        /// </summary>
        /// <value>服务商的业务代码，用于标识其所属业务领域。</value>
        [JsonPropertyName("bizCode")]
        public string BizCode { get { return this.BizCodeOption; } set { this.BizCodeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NameOption { get; private set; }

        /// <summary>
        /// 服务商的名称。
        /// </summary>
        /// <value>服务商的名称。</value>
        [JsonPropertyName("name")]
        public string Name { get { return this.NameOption; } set { this.NameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Code
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CodeOption { get; private set; }

        /// <summary>
        /// 服务商的唯一代码，用于系统内部标识。
        /// </summary>
        /// <value>服务商的唯一代码，用于系统内部标识。</value>
        [JsonPropertyName("code")]
        public string Code { get { return this.CodeOption; } set { this.CodeOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Icon
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> IconOption { get; private set; }

        /// <summary>
        /// 服务商图标的URL或路径。
        /// </summary>
        /// <value>服务商图标的URL或路径。</value>
        [JsonPropertyName("icon")]
        public string Icon { get { return this.IconOption; } set { this.IconOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Description
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> DescriptionOption { get; private set; }

        /// <summary>
        /// 服务商的详细描述信息。
        /// </summary>
        /// <value>服务商的详细描述信息。</value>
        [JsonPropertyName("description")]
        public string Description { get { return this.DescriptionOption; } set { this.DescriptionOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Tags
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> TagsOption { get; private set; }

        /// <summary>
        /// 用于分类或标记服务商的标签。
        /// </summary>
        /// <value>用于分类或标记服务商的标签。</value>
        [JsonPropertyName("tags")]
        public string Tags { get { return this.TagsOption; } set { this.TagsOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Show
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> ShowOption { get; private set; }

        /// <summary>
        /// 指示服务商是否在界面上显示。
        /// </summary>
        /// <value>指示服务商是否在界面上显示。</value>
        [JsonPropertyName("show")]
        public bool? Show { get { return this.ShowOption; } set { this.ShowOption = new Option<bool?>(value); } }

        /// <summary>
        /// Used to track the state of ShowIndex
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> ShowIndexOption { get; private set; }

        /// <summary>
        /// 服务商在界面上的显示顺序。
        /// </summary>
        /// <value>服务商在界面上的显示顺序。</value>
        [JsonPropertyName("showIndex")]
        public int? ShowIndex { get { return this.ShowIndexOption; } set { this.ShowIndexOption = new Option<int?>(value); } }

        /// <summary>
        /// Used to track the state of CreateDate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> CreateDateOption { get; private set; }

        /// <summary>
        /// 服务商记录的创建日期，默认为当前时间。
        /// </summary>
        /// <value>服务商记录的创建日期，默认为当前时间。</value>
        [JsonPropertyName("createDate")]
        public DateTime? CreateDate { get { return this.CreateDateOption; } set { this.CreateDateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of LastUpdate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> LastUpdateOption { get; private set; }

        /// <summary>
        /// 服务商记录的最后更新日期，默认为当前时间。
        /// </summary>
        /// <value>服务商记录的最后更新日期，默认为当前时间。</value>
        [JsonPropertyName("lastUpdate")]
        public DateTime? LastUpdate { get { return this.LastUpdateOption; } set { this.LastUpdateOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceProvider {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BizCode: ").Append(BizCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Show: ").Append(Show).Append("\n");
            sb.Append("  ShowIndex: ").Append(ShowIndex).Append("\n");
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
            // BizCode (string) maxLength
            if (this.BizCode != null && this.BizCode.Length > 50)
            {
                yield return new ValidationResult("Invalid value for BizCode, length must be less than 50.", new [] { "BizCode" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Code, length must be less than 50.", new [] { "Code" });
            }

            // Icon (string) maxLength
            if (this.Icon != null && this.Icon.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Icon, length must be less than 255.", new [] { "Icon" });
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
    /// A Json converter for type <see cref="ServiceProvider" />
    /// </summary>
    public class ServiceProviderJsonConverter : JsonConverter<ServiceProvider>
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
        /// Deserializes json to <see cref="ServiceProvider" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ServiceProvider Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> id = default;
            Option<string> bizCode = default;
            Option<string> name = default;
            Option<string> code = default;
            Option<string> icon = default;
            Option<string> description = default;
            Option<string> tags = default;
            Option<bool?> show = default;
            Option<int?> showIndex = default;
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
                        case "bizCode":
                            bizCode = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "name":
                            name = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "code":
                            code = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "icon":
                            icon = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "description":
                            description = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "tags":
                            tags = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "show":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                show = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "showIndex":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                showIndex = new Option<int?>(utf8JsonReader.GetInt32());
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
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class ServiceProvider.");

            if (show.IsSet && show.Value == null)
                throw new ArgumentNullException(nameof(show), "Property is not nullable for class ServiceProvider.");

            if (showIndex.IsSet && showIndex.Value == null)
                throw new ArgumentNullException(nameof(showIndex), "Property is not nullable for class ServiceProvider.");

            if (createDate.IsSet && createDate.Value == null)
                throw new ArgumentNullException(nameof(createDate), "Property is not nullable for class ServiceProvider.");

            if (lastUpdate.IsSet && lastUpdate.Value == null)
                throw new ArgumentNullException(nameof(lastUpdate), "Property is not nullable for class ServiceProvider.");

            return new ServiceProvider(id, bizCode, name, code, icon, description, tags, show, showIndex, createDate, lastUpdate);
        }

        /// <summary>
        /// Serializes a <see cref="ServiceProvider" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ServiceProvider serviceProvider, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, serviceProvider, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ServiceProvider" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="serviceProvider"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ServiceProvider serviceProvider, JsonSerializerOptions jsonSerializerOptions)
        {
            if (serviceProvider.IdOption.IsSet)
                writer.WriteNumber("id", serviceProvider.IdOption.Value.Value);

            if (serviceProvider.BizCodeOption.IsSet)
                if (serviceProvider.BizCodeOption.Value != null)
                    writer.WriteString("bizCode", serviceProvider.BizCode);
                else
                    writer.WriteNull("bizCode");

            if (serviceProvider.NameOption.IsSet)
                if (serviceProvider.NameOption.Value != null)
                    writer.WriteString("name", serviceProvider.Name);
                else
                    writer.WriteNull("name");

            if (serviceProvider.CodeOption.IsSet)
                if (serviceProvider.CodeOption.Value != null)
                    writer.WriteString("code", serviceProvider.Code);
                else
                    writer.WriteNull("code");

            if (serviceProvider.IconOption.IsSet)
                if (serviceProvider.IconOption.Value != null)
                    writer.WriteString("icon", serviceProvider.Icon);
                else
                    writer.WriteNull("icon");

            if (serviceProvider.DescriptionOption.IsSet)
                if (serviceProvider.DescriptionOption.Value != null)
                    writer.WriteString("description", serviceProvider.Description);
                else
                    writer.WriteNull("description");

            if (serviceProvider.TagsOption.IsSet)
                if (serviceProvider.TagsOption.Value != null)
                    writer.WriteString("tags", serviceProvider.Tags);
                else
                    writer.WriteNull("tags");

            if (serviceProvider.ShowOption.IsSet)
                writer.WriteBoolean("show", serviceProvider.ShowOption.Value.Value);

            if (serviceProvider.ShowIndexOption.IsSet)
                writer.WriteNumber("showIndex", serviceProvider.ShowIndexOption.Value.Value);

            if (serviceProvider.CreateDateOption.IsSet)
                writer.WriteString("createDate", serviceProvider.CreateDateOption.Value.Value.ToString(CreateDateFormat));

            if (serviceProvider.LastUpdateOption.IsSet)
                writer.WriteString("lastUpdate", serviceProvider.LastUpdateOption.Value.Value.ToString(LastUpdateFormat));
        }
    }
}
