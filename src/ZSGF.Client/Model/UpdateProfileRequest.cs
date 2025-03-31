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
    /// UpdateProfileRequest
    /// </summary>
    public partial class UpdateProfileRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProfileRequest" /> class.
        /// </summary>
        /// <param name="avatar">用户头像的链接或路径</param>
        /// <param name="data">用户的其他数据，可以是序列化后的对象或JSON字符串</param>
        /// <param name="nickName">用户的昵称</param>
        /// <param name="interestTags">兴趣标签</param>
        /// <param name="biography">个人简介</param>
        /// <param name="gender">性别</param>
        /// <param name="birthday">生日</param>
        /// <param name="occupation">职业</param>
        /// <param name="education">学历</param>
        /// <param name="contact">联系方式</param>
        /// <param name="languages">语言</param>
        /// <param name="socialLinks">社交网络链接</param>
        /// <param name="relationshipStatus">婚姻状态</param>
        /// <param name="company">公司</param>
        /// <param name="industry">行业</param>
        /// <param name="companyPosition">行业职位</param>
        /// <param name="privateSettings">私密设置</param>
        [JsonConstructor]
        public UpdateProfileRequest(Option<string> avatar = default, Option<string> data = default, Option<string> nickName = default, Option<string> interestTags = default, Option<string> biography = default, Option<string> gender = default, Option<DateTime?> birthday = default, Option<string> occupation = default, Option<string> education = default, Option<string> contact = default, Option<string> languages = default, Option<string> socialLinks = default, Option<string> relationshipStatus = default, Option<string> company = default, Option<string> industry = default, Option<string> companyPosition = default, Option<string> privateSettings = default)
        {
            AvatarOption = avatar;
            DataOption = data;
            NickNameOption = nickName;
            InterestTagsOption = interestTags;
            BiographyOption = biography;
            GenderOption = gender;
            BirthdayOption = birthday;
            OccupationOption = occupation;
            EducationOption = education;
            ContactOption = contact;
            LanguagesOption = languages;
            SocialLinksOption = socialLinks;
            RelationshipStatusOption = relationshipStatus;
            CompanyOption = company;
            IndustryOption = industry;
            CompanyPositionOption = companyPosition;
            PrivateSettingsOption = privateSettings;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Avatar
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> AvatarOption { get; private set; }

        /// <summary>
        /// 用户头像的链接或路径
        /// </summary>
        /// <value>用户头像的链接或路径</value>
        [JsonPropertyName("avatar")]
        public string Avatar { get { return this.AvatarOption; } set { this.AvatarOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Data
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> DataOption { get; private set; }

        /// <summary>
        /// 用户的其他数据，可以是序列化后的对象或JSON字符串
        /// </summary>
        /// <value>用户的其他数据，可以是序列化后的对象或JSON字符串</value>
        [JsonPropertyName("data")]
        public string Data { get { return this.DataOption; } set { this.DataOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of NickName
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> NickNameOption { get; private set; }

        /// <summary>
        /// 用户的昵称
        /// </summary>
        /// <value>用户的昵称</value>
        [JsonPropertyName("nickName")]
        public string NickName { get { return this.NickNameOption; } set { this.NickNameOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of InterestTags
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> InterestTagsOption { get; private set; }

        /// <summary>
        /// 兴趣标签
        /// </summary>
        /// <value>兴趣标签</value>
        [JsonPropertyName("interestTags")]
        public string InterestTags { get { return this.InterestTagsOption; } set { this.InterestTagsOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Biography
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> BiographyOption { get; private set; }

        /// <summary>
        /// 个人简介
        /// </summary>
        /// <value>个人简介</value>
        [JsonPropertyName("biography")]
        public string Biography { get { return this.BiographyOption; } set { this.BiographyOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Gender
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> GenderOption { get; private set; }

        /// <summary>
        /// 性别
        /// </summary>
        /// <value>性别</value>
        [JsonPropertyName("gender")]
        public string Gender { get { return this.GenderOption; } set { this.GenderOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Birthday
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> BirthdayOption { get; private set; }

        /// <summary>
        /// 生日
        /// </summary>
        /// <value>生日</value>
        [JsonPropertyName("birthday")]
        public DateTime? Birthday { get { return this.BirthdayOption; } set { this.BirthdayOption = new Option<DateTime?>(value); } }

        /// <summary>
        /// Used to track the state of Occupation
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> OccupationOption { get; private set; }

        /// <summary>
        /// 职业
        /// </summary>
        /// <value>职业</value>
        [JsonPropertyName("occupation")]
        public string Occupation { get { return this.OccupationOption; } set { this.OccupationOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Education
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> EducationOption { get; private set; }

        /// <summary>
        /// 学历
        /// </summary>
        /// <value>学历</value>
        [JsonPropertyName("education")]
        public string Education { get { return this.EducationOption; } set { this.EducationOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Contact
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> ContactOption { get; private set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        /// <value>联系方式</value>
        [JsonPropertyName("contact")]
        public string Contact { get { return this.ContactOption; } set { this.ContactOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Languages
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> LanguagesOption { get; private set; }

        /// <summary>
        /// 语言
        /// </summary>
        /// <value>语言</value>
        [JsonPropertyName("languages")]
        public string Languages { get { return this.LanguagesOption; } set { this.LanguagesOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of SocialLinks
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> SocialLinksOption { get; private set; }

        /// <summary>
        /// 社交网络链接
        /// </summary>
        /// <value>社交网络链接</value>
        [JsonPropertyName("socialLinks")]
        public string SocialLinks { get { return this.SocialLinksOption; } set { this.SocialLinksOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of RelationshipStatus
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> RelationshipStatusOption { get; private set; }

        /// <summary>
        /// 婚姻状态
        /// </summary>
        /// <value>婚姻状态</value>
        [JsonPropertyName("relationshipStatus")]
        public string RelationshipStatus { get { return this.RelationshipStatusOption; } set { this.RelationshipStatusOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Company
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CompanyOption { get; private set; }

        /// <summary>
        /// 公司
        /// </summary>
        /// <value>公司</value>
        [JsonPropertyName("company")]
        public string Company { get { return this.CompanyOption; } set { this.CompanyOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of Industry
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> IndustryOption { get; private set; }

        /// <summary>
        /// 行业
        /// </summary>
        /// <value>行业</value>
        [JsonPropertyName("industry")]
        public string Industry { get { return this.IndustryOption; } set { this.IndustryOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of CompanyPosition
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> CompanyPositionOption { get; private set; }

        /// <summary>
        /// 行业职位
        /// </summary>
        /// <value>行业职位</value>
        [JsonPropertyName("companyPosition")]
        public string CompanyPosition { get { return this.CompanyPositionOption; } set { this.CompanyPositionOption = new Option<string>(value); } }

        /// <summary>
        /// Used to track the state of PrivateSettings
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string> PrivateSettingsOption { get; private set; }

        /// <summary>
        /// 私密设置
        /// </summary>
        /// <value>私密设置</value>
        [JsonPropertyName("privateSettings")]
        public string PrivateSettings { get { return this.PrivateSettingsOption; } set { this.PrivateSettingsOption = new Option<string>(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateProfileRequest {\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  InterestTags: ").Append(InterestTags).Append("\n");
            sb.Append("  Biography: ").Append(Biography).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Birthday: ").Append(Birthday).Append("\n");
            sb.Append("  Occupation: ").Append(Occupation).Append("\n");
            sb.Append("  Education: ").Append(Education).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  SocialLinks: ").Append(SocialLinks).Append("\n");
            sb.Append("  RelationshipStatus: ").Append(RelationshipStatus).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  CompanyPosition: ").Append(CompanyPosition).Append("\n");
            sb.Append("  PrivateSettings: ").Append(PrivateSettings).Append("\n");
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
            // Avatar (string) maxLength
            if (this.Avatar != null && this.Avatar.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Avatar, length must be less than 255.", new [] { "Avatar" });
            }

            // NickName (string) maxLength
            if (this.NickName != null && this.NickName.Length > 50)
            {
                yield return new ValidationResult("Invalid value for NickName, length must be less than 50.", new [] { "NickName" });
            }

            // Biography (string) maxLength
            if (this.Biography != null && this.Biography.Length > 500)
            {
                yield return new ValidationResult("Invalid value for Biography, length must be less than 500.", new [] { "Biography" });
            }

            // Gender (string) maxLength
            if (this.Gender != null && this.Gender.Length > 15)
            {
                yield return new ValidationResult("Invalid value for Gender, length must be less than 15.", new [] { "Gender" });
            }

            // Occupation (string) maxLength
            if (this.Occupation != null && this.Occupation.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Occupation, length must be less than 50.", new [] { "Occupation" });
            }

            // Education (string) maxLength
            if (this.Education != null && this.Education.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Education, length must be less than 50.", new [] { "Education" });
            }

            // Contact (string) maxLength
            if (this.Contact != null && this.Contact.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Contact, length must be less than 255.", new [] { "Contact" });
            }

            // Languages (string) maxLength
            if (this.Languages != null && this.Languages.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Languages, length must be less than 50.", new [] { "Languages" });
            }

            // SocialLinks (string) maxLength
            if (this.SocialLinks != null && this.SocialLinks.Length > 255)
            {
                yield return new ValidationResult("Invalid value for SocialLinks, length must be less than 255.", new [] { "SocialLinks" });
            }

            // RelationshipStatus (string) maxLength
            if (this.RelationshipStatus != null && this.RelationshipStatus.Length > 20)
            {
                yield return new ValidationResult("Invalid value for RelationshipStatus, length must be less than 20.", new [] { "RelationshipStatus" });
            }

            // Company (string) maxLength
            if (this.Company != null && this.Company.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Company, length must be less than 100.", new [] { "Company" });
            }

            // Industry (string) maxLength
            if (this.Industry != null && this.Industry.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Industry, length must be less than 50.", new [] { "Industry" });
            }

            // CompanyPosition (string) maxLength
            if (this.CompanyPosition != null && this.CompanyPosition.Length > 50)
            {
                yield return new ValidationResult("Invalid value for CompanyPosition, length must be less than 50.", new [] { "CompanyPosition" });
            }

            // PrivateSettings (string) maxLength
            if (this.PrivateSettings != null && this.PrivateSettings.Length > 500)
            {
                yield return new ValidationResult("Invalid value for PrivateSettings, length must be less than 500.", new [] { "PrivateSettings" });
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="UpdateProfileRequest" />
    /// </summary>
    public class UpdateProfileRequestJsonConverter : JsonConverter<UpdateProfileRequest>
    {
        /// <summary>
        /// The format to use to serialize Birthday
        /// </summary>
        public static string BirthdayFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="UpdateProfileRequest" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override UpdateProfileRequest Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string> avatar = default;
            Option<string> data = default;
            Option<string> nickName = default;
            Option<string> interestTags = default;
            Option<string> biography = default;
            Option<string> gender = default;
            Option<DateTime?> birthday = default;
            Option<string> occupation = default;
            Option<string> education = default;
            Option<string> contact = default;
            Option<string> languages = default;
            Option<string> socialLinks = default;
            Option<string> relationshipStatus = default;
            Option<string> company = default;
            Option<string> industry = default;
            Option<string> companyPosition = default;
            Option<string> privateSettings = default;

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
                        case "avatar":
                            avatar = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "data":
                            data = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "nickName":
                            nickName = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "interestTags":
                            interestTags = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "biography":
                            biography = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "gender":
                            gender = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "birthday":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                birthday = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime?>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "occupation":
                            occupation = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "education":
                            education = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "contact":
                            contact = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "languages":
                            languages = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "socialLinks":
                            socialLinks = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "relationshipStatus":
                            relationshipStatus = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "company":
                            company = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "industry":
                            industry = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "companyPosition":
                            companyPosition = new Option<string>(utf8JsonReader.GetString());
                            break;
                        case "privateSettings":
                            privateSettings = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            return new UpdateProfileRequest(avatar, data, nickName, interestTags, biography, gender, birthday, occupation, education, contact, languages, socialLinks, relationshipStatus, company, industry, companyPosition, privateSettings);
        }

        /// <summary>
        /// Serializes a <see cref="UpdateProfileRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateProfileRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, UpdateProfileRequest updateProfileRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, updateProfileRequest, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="UpdateProfileRequest" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="updateProfileRequest"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, UpdateProfileRequest updateProfileRequest, JsonSerializerOptions jsonSerializerOptions)
        {
            if (updateProfileRequest.AvatarOption.IsSet)
                if (updateProfileRequest.AvatarOption.Value != null)
                    writer.WriteString("avatar", updateProfileRequest.Avatar);
                else
                    writer.WriteNull("avatar");

            if (updateProfileRequest.DataOption.IsSet)
                if (updateProfileRequest.DataOption.Value != null)
                    writer.WriteString("data", updateProfileRequest.Data);
                else
                    writer.WriteNull("data");

            if (updateProfileRequest.NickNameOption.IsSet)
                if (updateProfileRequest.NickNameOption.Value != null)
                    writer.WriteString("nickName", updateProfileRequest.NickName);
                else
                    writer.WriteNull("nickName");

            if (updateProfileRequest.InterestTagsOption.IsSet)
                if (updateProfileRequest.InterestTagsOption.Value != null)
                    writer.WriteString("interestTags", updateProfileRequest.InterestTags);
                else
                    writer.WriteNull("interestTags");

            if (updateProfileRequest.BiographyOption.IsSet)
                if (updateProfileRequest.BiographyOption.Value != null)
                    writer.WriteString("biography", updateProfileRequest.Biography);
                else
                    writer.WriteNull("biography");

            if (updateProfileRequest.GenderOption.IsSet)
                if (updateProfileRequest.GenderOption.Value != null)
                    writer.WriteString("gender", updateProfileRequest.Gender);
                else
                    writer.WriteNull("gender");

            if (updateProfileRequest.BirthdayOption.IsSet)
                if (updateProfileRequest.BirthdayOption.Value != null)
                    writer.WriteString("birthday", updateProfileRequest.BirthdayOption.Value.Value.ToString(BirthdayFormat));
                else
                    writer.WriteNull("birthday");

            if (updateProfileRequest.OccupationOption.IsSet)
                if (updateProfileRequest.OccupationOption.Value != null)
                    writer.WriteString("occupation", updateProfileRequest.Occupation);
                else
                    writer.WriteNull("occupation");

            if (updateProfileRequest.EducationOption.IsSet)
                if (updateProfileRequest.EducationOption.Value != null)
                    writer.WriteString("education", updateProfileRequest.Education);
                else
                    writer.WriteNull("education");

            if (updateProfileRequest.ContactOption.IsSet)
                if (updateProfileRequest.ContactOption.Value != null)
                    writer.WriteString("contact", updateProfileRequest.Contact);
                else
                    writer.WriteNull("contact");

            if (updateProfileRequest.LanguagesOption.IsSet)
                if (updateProfileRequest.LanguagesOption.Value != null)
                    writer.WriteString("languages", updateProfileRequest.Languages);
                else
                    writer.WriteNull("languages");

            if (updateProfileRequest.SocialLinksOption.IsSet)
                if (updateProfileRequest.SocialLinksOption.Value != null)
                    writer.WriteString("socialLinks", updateProfileRequest.SocialLinks);
                else
                    writer.WriteNull("socialLinks");

            if (updateProfileRequest.RelationshipStatusOption.IsSet)
                if (updateProfileRequest.RelationshipStatusOption.Value != null)
                    writer.WriteString("relationshipStatus", updateProfileRequest.RelationshipStatus);
                else
                    writer.WriteNull("relationshipStatus");

            if (updateProfileRequest.CompanyOption.IsSet)
                if (updateProfileRequest.CompanyOption.Value != null)
                    writer.WriteString("company", updateProfileRequest.Company);
                else
                    writer.WriteNull("company");

            if (updateProfileRequest.IndustryOption.IsSet)
                if (updateProfileRequest.IndustryOption.Value != null)
                    writer.WriteString("industry", updateProfileRequest.Industry);
                else
                    writer.WriteNull("industry");

            if (updateProfileRequest.CompanyPositionOption.IsSet)
                if (updateProfileRequest.CompanyPositionOption.Value != null)
                    writer.WriteString("companyPosition", updateProfileRequest.CompanyPosition);
                else
                    writer.WriteNull("companyPosition");

            if (updateProfileRequest.PrivateSettingsOption.IsSet)
                if (updateProfileRequest.PrivateSettingsOption.Value != null)
                    writer.WriteString("privateSettings", updateProfileRequest.PrivateSettings);
                else
                    writer.WriteNull("privateSettings");
        }
    }
}
