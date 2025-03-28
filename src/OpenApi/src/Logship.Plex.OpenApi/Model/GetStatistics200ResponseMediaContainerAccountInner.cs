// <auto-generated>
/*
 * Plex API
 *
 * Plex OpenAPI Spec 
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

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
using System.Text.Json.Serialization.Metadata;
using Logship.Plex.OpenApi.Client;

namespace Logship.Plex.OpenApi.Model
{
    /// <summary>
    /// GetStatistics200ResponseMediaContainerAccountInner
    /// </summary>
    public partial class GetStatistics200ResponseMediaContainerAccountInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatistics200ResponseMediaContainerAccountInner" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="key">key</param>
        /// <param name="name">name</param>
        /// <param name="defaultAudioLanguage">defaultAudioLanguage</param>
        /// <param name="autoSelectAudio">autoSelectAudio</param>
        /// <param name="defaultSubtitleLanguage">defaultSubtitleLanguage</param>
        /// <param name="subtitleMode">subtitleMode</param>
        /// <param name="thumb">thumb</param>
        [JsonConstructor]
        public GetStatistics200ResponseMediaContainerAccountInner(Option<int?> id = default, Option<string?> key = default, Option<string?> name = default, Option<string?> defaultAudioLanguage = default, Option<bool?> autoSelectAudio = default, Option<string?> defaultSubtitleLanguage = default, Option<int?> subtitleMode = default, Option<string?> thumb = default)
        {
            IdOption = id;
            KeyOption = key;
            NameOption = name;
            DefaultAudioLanguageOption = defaultAudioLanguage;
            AutoSelectAudioOption = autoSelectAudio;
            DefaultSubtitleLanguageOption = defaultSubtitleLanguage;
            SubtitleModeOption = subtitleMode;
            ThumbOption = thumb;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /* <example>238960586</example> */
        [JsonPropertyName("id")]
        public int? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Key
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> KeyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        /* <example>/accounts/238960586</example> */
        [JsonPropertyName("key")]
        public string? Key { get { return this.KeyOption; } set { this.KeyOption = new(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>Diane</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Used to track the state of DefaultAudioLanguage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DefaultAudioLanguageOption { get; private set; }

        /// <summary>
        /// Gets or Sets DefaultAudioLanguage
        /// </summary>
        /* <example>en</example> */
        [JsonPropertyName("defaultAudioLanguage")]
        public string? DefaultAudioLanguage { get { return this.DefaultAudioLanguageOption; } set { this.DefaultAudioLanguageOption = new(value); } }

        /// <summary>
        /// Used to track the state of AutoSelectAudio
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> AutoSelectAudioOption { get; private set; }

        /// <summary>
        /// Gets or Sets AutoSelectAudio
        /// </summary>
        /* <example>true</example> */
        [JsonPropertyName("autoSelectAudio")]
        public bool? AutoSelectAudio { get { return this.AutoSelectAudioOption; } set { this.AutoSelectAudioOption = new(value); } }

        /// <summary>
        /// Used to track the state of DefaultSubtitleLanguage
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DefaultSubtitleLanguageOption { get; private set; }

        /// <summary>
        /// Gets or Sets DefaultSubtitleLanguage
        /// </summary>
        /* <example>en</example> */
        [JsonPropertyName("defaultSubtitleLanguage")]
        public string? DefaultSubtitleLanguage { get { return this.DefaultSubtitleLanguageOption; } set { this.DefaultSubtitleLanguageOption = new(value); } }

        /// <summary>
        /// Used to track the state of SubtitleMode
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> SubtitleModeOption { get; private set; }

        /// <summary>
        /// Gets or Sets SubtitleMode
        /// </summary>
        /* <example>1</example> */
        [JsonPropertyName("subtitleMode")]
        public int? SubtitleMode { get { return this.SubtitleModeOption; } set { this.SubtitleModeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Thumb
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ThumbOption { get; private set; }

        /// <summary>
        /// Gets or Sets Thumb
        /// </summary>
        /* <example>https://plex.tv/users/50d83634246da1de/avatar?c&#x3D;1707110967</example> */
        [JsonPropertyName("thumb")]
        public string? Thumb { get { return this.ThumbOption; } set { this.ThumbOption = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetStatistics200ResponseMediaContainerAccountInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultAudioLanguage: ").Append(DefaultAudioLanguage).Append("\n");
            sb.Append("  AutoSelectAudio: ").Append(AutoSelectAudio).Append("\n");
            sb.Append("  DefaultSubtitleLanguage: ").Append(DefaultSubtitleLanguage).Append("\n");
            sb.Append("  SubtitleMode: ").Append(SubtitleMode).Append("\n");
            sb.Append("  Thumb: ").Append(Thumb).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
    /// A Json converter for type <see cref="GetStatistics200ResponseMediaContainerAccountInner" />
    /// </summary>
    public class GetStatistics200ResponseMediaContainerAccountInnerJsonConverter : JsonConverter<GetStatistics200ResponseMediaContainerAccountInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetStatistics200ResponseMediaContainerAccountInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetStatistics200ResponseMediaContainerAccountInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> id = default;
            Option<string?> key = default;
            Option<string?> name = default;
            Option<string?> defaultAudioLanguage = default;
            Option<bool?> autoSelectAudio = default;
            Option<string?> defaultSubtitleLanguage = default;
            Option<int?> subtitleMode = default;
            Option<string?> thumb = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "key":
                            key = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "defaultAudioLanguage":
                            defaultAudioLanguage = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "autoSelectAudio":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                autoSelectAudio = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "defaultSubtitleLanguage":
                            defaultSubtitleLanguage = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "subtitleMode":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                subtitleMode = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "thumb":
                            thumb = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (key.IsSet && key.Value == null)
                throw new ArgumentNullException(nameof(key), "Property is not nullable for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (defaultAudioLanguage.IsSet && defaultAudioLanguage.Value == null)
                throw new ArgumentNullException(nameof(defaultAudioLanguage), "Property is not nullable for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (autoSelectAudio.IsSet && autoSelectAudio.Value == null)
                throw new ArgumentNullException(nameof(autoSelectAudio), "Property is not nullable for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (defaultSubtitleLanguage.IsSet && defaultSubtitleLanguage.Value == null)
                throw new ArgumentNullException(nameof(defaultSubtitleLanguage), "Property is not nullable for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (subtitleMode.IsSet && subtitleMode.Value == null)
                throw new ArgumentNullException(nameof(subtitleMode), "Property is not nullable for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (thumb.IsSet && thumb.Value == null)
                throw new ArgumentNullException(nameof(thumb), "Property is not nullable for class GetStatistics200ResponseMediaContainerAccountInner.");

            return new GetStatistics200ResponseMediaContainerAccountInner(id, key, name, defaultAudioLanguage, autoSelectAudio, defaultSubtitleLanguage, subtitleMode, thumb);
        }

        /// <summary>
        /// Serializes a <see cref="GetStatistics200ResponseMediaContainerAccountInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getStatistics200ResponseMediaContainerAccountInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetStatistics200ResponseMediaContainerAccountInner getStatistics200ResponseMediaContainerAccountInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getStatistics200ResponseMediaContainerAccountInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetStatistics200ResponseMediaContainerAccountInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getStatistics200ResponseMediaContainerAccountInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetStatistics200ResponseMediaContainerAccountInner getStatistics200ResponseMediaContainerAccountInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getStatistics200ResponseMediaContainerAccountInner.KeyOption.IsSet && getStatistics200ResponseMediaContainerAccountInner.Key == null)
                throw new ArgumentNullException(nameof(getStatistics200ResponseMediaContainerAccountInner.Key), "Property is required for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (getStatistics200ResponseMediaContainerAccountInner.NameOption.IsSet && getStatistics200ResponseMediaContainerAccountInner.Name == null)
                throw new ArgumentNullException(nameof(getStatistics200ResponseMediaContainerAccountInner.Name), "Property is required for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (getStatistics200ResponseMediaContainerAccountInner.DefaultAudioLanguageOption.IsSet && getStatistics200ResponseMediaContainerAccountInner.DefaultAudioLanguage == null)
                throw new ArgumentNullException(nameof(getStatistics200ResponseMediaContainerAccountInner.DefaultAudioLanguage), "Property is required for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (getStatistics200ResponseMediaContainerAccountInner.DefaultSubtitleLanguageOption.IsSet && getStatistics200ResponseMediaContainerAccountInner.DefaultSubtitleLanguage == null)
                throw new ArgumentNullException(nameof(getStatistics200ResponseMediaContainerAccountInner.DefaultSubtitleLanguage), "Property is required for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (getStatistics200ResponseMediaContainerAccountInner.ThumbOption.IsSet && getStatistics200ResponseMediaContainerAccountInner.Thumb == null)
                throw new ArgumentNullException(nameof(getStatistics200ResponseMediaContainerAccountInner.Thumb), "Property is required for class GetStatistics200ResponseMediaContainerAccountInner.");

            if (getStatistics200ResponseMediaContainerAccountInner.IdOption.IsSet)
                writer.WriteNumber("id", getStatistics200ResponseMediaContainerAccountInner.IdOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerAccountInner.KeyOption.IsSet)
                writer.WriteString("key", getStatistics200ResponseMediaContainerAccountInner.Key);

            if (getStatistics200ResponseMediaContainerAccountInner.NameOption.IsSet)
                writer.WriteString("name", getStatistics200ResponseMediaContainerAccountInner.Name);

            if (getStatistics200ResponseMediaContainerAccountInner.DefaultAudioLanguageOption.IsSet)
                writer.WriteString("defaultAudioLanguage", getStatistics200ResponseMediaContainerAccountInner.DefaultAudioLanguage);

            if (getStatistics200ResponseMediaContainerAccountInner.AutoSelectAudioOption.IsSet)
                writer.WriteBoolean("autoSelectAudio", getStatistics200ResponseMediaContainerAccountInner.AutoSelectAudioOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerAccountInner.DefaultSubtitleLanguageOption.IsSet)
                writer.WriteString("defaultSubtitleLanguage", getStatistics200ResponseMediaContainerAccountInner.DefaultSubtitleLanguage);

            if (getStatistics200ResponseMediaContainerAccountInner.SubtitleModeOption.IsSet)
                writer.WriteNumber("subtitleMode", getStatistics200ResponseMediaContainerAccountInner.SubtitleModeOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerAccountInner.ThumbOption.IsSet)
                writer.WriteString("thumb", getStatistics200ResponseMediaContainerAccountInner.Thumb);
        }
    }

    /// <summary>
    /// The GetStatistics200ResponseMediaContainerAccountInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetStatistics200ResponseMediaContainerAccountInner))]
    public partial class GetStatistics200ResponseMediaContainerAccountInnerSerializationContext : JsonSerializerContext { }
}
