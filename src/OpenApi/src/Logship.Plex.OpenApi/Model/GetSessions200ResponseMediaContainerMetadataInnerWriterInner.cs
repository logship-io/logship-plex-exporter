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
    /// GetSessions200ResponseMediaContainerMetadataInnerWriterInner
    /// </summary>
    public partial class GetSessions200ResponseMediaContainerMetadataInnerWriterInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessions200ResponseMediaContainerMetadataInnerWriterInner" /> class.
        /// </summary>
        /// <param name="count">count</param>
        /// <param name="filter">filter</param>
        /// <param name="id">id</param>
        /// <param name="tag">tag</param>
        /// <param name="tagKey">tagKey</param>
        [JsonConstructor]
        public GetSessions200ResponseMediaContainerMetadataInnerWriterInner(Option<string?> count = default, Option<string?> filter = default, Option<string?> id = default, Option<string?> tag = default, Option<string?> tagKey = default)
        {
            CountOption = count;
            FilterOption = filter;
            IdOption = id;
            TagOption = tag;
            TagKeyOption = tagKey;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Count
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CountOption { get; private set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [JsonPropertyName("count")]
        public string? Count { get { return this.CountOption; } set { this.CountOption = new(value); } }

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
            sb.Append("class GetSessions200ResponseMediaContainerMetadataInnerWriterInner {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  TagKey: ").Append(TagKey).Append("\n");
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
    /// A Json converter for type <see cref="GetSessions200ResponseMediaContainerMetadataInnerWriterInner" />
    /// </summary>
    public class GetSessions200ResponseMediaContainerMetadataInnerWriterInnerJsonConverter : JsonConverter<GetSessions200ResponseMediaContainerMetadataInnerWriterInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessions200ResponseMediaContainerMetadataInnerWriterInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessions200ResponseMediaContainerMetadataInnerWriterInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> count = default;
            Option<string?> filter = default;
            Option<string?> id = default;
            Option<string?> tag = default;
            Option<string?> tagKey = default;

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
                        case "count":
                            count = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
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
                        default:
                            break;
                    }
                }
            }

            if (count.IsSet && count.Value == null)
                throw new ArgumentNullException(nameof(count), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (filter.IsSet && filter.Value == null)
                throw new ArgumentNullException(nameof(filter), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (tag.IsSet && tag.Value == null)
                throw new ArgumentNullException(nameof(tag), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (tagKey.IsSet && tagKey.Value == null)
                throw new ArgumentNullException(nameof(tagKey), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            return new GetSessions200ResponseMediaContainerMetadataInnerWriterInner(count, filter, id, tag, tagKey);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessions200ResponseMediaContainerMetadataInnerWriterInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerWriterInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerWriterInner getSessions200ResponseMediaContainerMetadataInnerWriterInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessions200ResponseMediaContainerMetadataInnerWriterInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessions200ResponseMediaContainerMetadataInnerWriterInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerWriterInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerWriterInner getSessions200ResponseMediaContainerMetadataInnerWriterInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.CountOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerWriterInner.Count == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerWriterInner.Count), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.FilterOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerWriterInner.Filter == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerWriterInner.Filter), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.IdOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerWriterInner.Id == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerWriterInner.Id), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.TagOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerWriterInner.Tag == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerWriterInner.Tag), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.TagKeyOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerWriterInner.TagKey == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerWriterInner.TagKey), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerWriterInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.CountOption.IsSet)
                writer.WriteString("count", getSessions200ResponseMediaContainerMetadataInnerWriterInner.Count);

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.FilterOption.IsSet)
                writer.WriteString("filter", getSessions200ResponseMediaContainerMetadataInnerWriterInner.Filter);

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.IdOption.IsSet)
                writer.WriteString("id", getSessions200ResponseMediaContainerMetadataInnerWriterInner.Id);

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.TagOption.IsSet)
                writer.WriteString("tag", getSessions200ResponseMediaContainerMetadataInnerWriterInner.Tag);

            if (getSessions200ResponseMediaContainerMetadataInnerWriterInner.TagKeyOption.IsSet)
                writer.WriteString("tagKey", getSessions200ResponseMediaContainerMetadataInnerWriterInner.TagKey);
        }
    }

    /// <summary>
    /// The GetSessions200ResponseMediaContainerMetadataInnerWriterInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessions200ResponseMediaContainerMetadataInnerWriterInner))]
    public partial class GetSessions200ResponseMediaContainerMetadataInnerWriterInnerSerializationContext : JsonSerializerContext { }
}
