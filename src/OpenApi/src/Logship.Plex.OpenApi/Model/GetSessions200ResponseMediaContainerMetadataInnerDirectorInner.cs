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
    /// GetSessions200ResponseMediaContainerMetadataInnerDirectorInner
    /// </summary>
    public partial class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessions200ResponseMediaContainerMetadataInnerDirectorInner" /> class.
        /// </summary>
        /// <param name="filter">filter</param>
        /// <param name="id">id</param>
        /// <param name="tag">tag</param>
        /// <param name="tagKey">tagKey</param>
        /// <param name="thumb">thumb</param>
        [JsonConstructor]
        public GetSessions200ResponseMediaContainerMetadataInnerDirectorInner(Option<string?> filter = default, Option<string?> id = default, Option<string?> tag = default, Option<string?> tagKey = default, Option<string?> thumb = default)
        {
            FilterOption = filter;
            IdOption = id;
            TagOption = tag;
            TagKeyOption = tagKey;
            ThumbOption = thumb;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Filter
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FilterOption { get; private set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [JsonPropertyName("filter")]
        public string? Filter { get { return this.FilterOption; } set { this.FilterOption = new(value); } }

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        public string? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Tag
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TagOption { get; private set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [JsonPropertyName("tag")]
        public string? Tag { get { return this.TagOption; } set { this.TagOption = new(value); } }

        /// <summary>
        /// Used to track the state of TagKey
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TagKeyOption { get; private set; }

        /// <summary>
        /// Gets or Sets TagKey
        /// </summary>
        [JsonPropertyName("tagKey")]
        public string? TagKey { get { return this.TagKeyOption; } set { this.TagKeyOption = new(value); } }

        /// <summary>
        /// Used to track the state of Thumb
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ThumbOption { get; private set; }

        /// <summary>
        /// Gets or Sets Thumb
        /// </summary>
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
            sb.Append("class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  TagKey: ").Append(TagKey).Append("\n");
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
    /// A Json converter for type <see cref="GetSessions200ResponseMediaContainerMetadataInnerDirectorInner" />
    /// </summary>
    public class GetSessions200ResponseMediaContainerMetadataInnerDirectorInnerJsonConverter : JsonConverter<GetSessions200ResponseMediaContainerMetadataInnerDirectorInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessions200ResponseMediaContainerMetadataInnerDirectorInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessions200ResponseMediaContainerMetadataInnerDirectorInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> filter = default;
            Option<string?> id = default;
            Option<string?> tag = default;
            Option<string?> tagKey = default;
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
                        case "filter":
                            filter = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tag":
                            tag = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "tagKey":
                            tagKey = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "thumb":
                            thumb = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (filter.IsSet && filter.Value == null)
                throw new ArgumentNullException(nameof(filter), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (tag.IsSet && tag.Value == null)
                throw new ArgumentNullException(nameof(tag), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (tagKey.IsSet && tagKey.Value == null)
                throw new ArgumentNullException(nameof(tagKey), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (thumb.IsSet && thumb.Value == null)
                throw new ArgumentNullException(nameof(thumb), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            return new GetSessions200ResponseMediaContainerMetadataInnerDirectorInner(filter, id, tag, tagKey, thumb);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessions200ResponseMediaContainerMetadataInnerDirectorInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerDirectorInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerDirectorInner getSessions200ResponseMediaContainerMetadataInnerDirectorInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessions200ResponseMediaContainerMetadataInnerDirectorInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessions200ResponseMediaContainerMetadataInnerDirectorInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerDirectorInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerDirectorInner getSessions200ResponseMediaContainerMetadataInnerDirectorInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.FilterOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Filter == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Filter), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.IdOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Id == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Id), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.TagOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Tag == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Tag), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.TagKeyOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerDirectorInner.TagKey == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerDirectorInner.TagKey), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.ThumbOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Thumb == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Thumb), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerDirectorInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.FilterOption.IsSet)
                writer.WriteString("filter", getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Filter);

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.IdOption.IsSet)
                writer.WriteString("id", getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Id);

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.TagOption.IsSet)
                writer.WriteString("tag", getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Tag);

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.TagKeyOption.IsSet)
                writer.WriteString("tagKey", getSessions200ResponseMediaContainerMetadataInnerDirectorInner.TagKey);

            if (getSessions200ResponseMediaContainerMetadataInnerDirectorInner.ThumbOption.IsSet)
                writer.WriteString("thumb", getSessions200ResponseMediaContainerMetadataInnerDirectorInner.Thumb);
        }
    }

    /// <summary>
    /// The GetSessions200ResponseMediaContainerMetadataInnerDirectorInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessions200ResponseMediaContainerMetadataInnerDirectorInner))]
    public partial class GetSessions200ResponseMediaContainerMetadataInnerDirectorInnerSerializationContext : JsonSerializerContext { }
}
