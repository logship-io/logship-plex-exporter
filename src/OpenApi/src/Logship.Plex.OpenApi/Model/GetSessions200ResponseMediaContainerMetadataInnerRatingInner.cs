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
    /// GetSessions200ResponseMediaContainerMetadataInnerRatingInner
    /// </summary>
    public partial class GetSessions200ResponseMediaContainerMetadataInnerRatingInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessions200ResponseMediaContainerMetadataInnerRatingInner" /> class.
        /// </summary>
        /// <param name="count">count</param>
        /// <param name="image">image</param>
        /// <param name="type">type</param>
        /// <param name="value">value</param>
        [JsonConstructor]
        public GetSessions200ResponseMediaContainerMetadataInnerRatingInner(Option<string?> count = default, Option<string?> image = default, Option<string?> type = default, Option<string?> value = default)
        {
            CountOption = count;
            ImageOption = image;
            TypeOption = type;
            ValueOption = value;
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
        /// Used to track the state of Image
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ImageOption { get; private set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [JsonPropertyName("image")]
        public string? Image { get { return this.ImageOption; } set { this.ImageOption = new(value); } }

        /// <summary>
        /// Used to track the state of Type
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get { return this.TypeOption; } set { this.TypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Value
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ValueOption { get; private set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [JsonPropertyName("value")]
        public string? Value { get { return this.ValueOption; } set { this.ValueOption = new(value); } }

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
            sb.Append("class GetSessions200ResponseMediaContainerMetadataInnerRatingInner {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
    /// A Json converter for type <see cref="GetSessions200ResponseMediaContainerMetadataInnerRatingInner" />
    /// </summary>
    public class GetSessions200ResponseMediaContainerMetadataInnerRatingInnerJsonConverter : JsonConverter<GetSessions200ResponseMediaContainerMetadataInnerRatingInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessions200ResponseMediaContainerMetadataInnerRatingInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessions200ResponseMediaContainerMetadataInnerRatingInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> count = default;
            Option<string?> image = default;
            Option<string?> type = default;
            Option<string?> value = default;

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
                        case "image":
                            image = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "value":
                            value = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (count.IsSet && count.Value == null)
                throw new ArgumentNullException(nameof(count), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerRatingInner.");

            if (image.IsSet && image.Value == null)
                throw new ArgumentNullException(nameof(image), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerRatingInner.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerRatingInner.");

            if (value.IsSet && value.Value == null)
                throw new ArgumentNullException(nameof(value), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerRatingInner.");

            return new GetSessions200ResponseMediaContainerMetadataInnerRatingInner(count, image, type, value);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessions200ResponseMediaContainerMetadataInnerRatingInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerRatingInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerRatingInner getSessions200ResponseMediaContainerMetadataInnerRatingInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessions200ResponseMediaContainerMetadataInnerRatingInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessions200ResponseMediaContainerMetadataInnerRatingInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerRatingInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerRatingInner getSessions200ResponseMediaContainerMetadataInnerRatingInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessions200ResponseMediaContainerMetadataInnerRatingInner.CountOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerRatingInner.Count == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerRatingInner.Count), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerRatingInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerRatingInner.ImageOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerRatingInner.Image == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerRatingInner.Image), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerRatingInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerRatingInner.TypeOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerRatingInner.Type == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerRatingInner.Type), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerRatingInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerRatingInner.ValueOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerRatingInner.Value == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerRatingInner.Value), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerRatingInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerRatingInner.CountOption.IsSet)
                writer.WriteString("count", getSessions200ResponseMediaContainerMetadataInnerRatingInner.Count);

            if (getSessions200ResponseMediaContainerMetadataInnerRatingInner.ImageOption.IsSet)
                writer.WriteString("image", getSessions200ResponseMediaContainerMetadataInnerRatingInner.Image);

            if (getSessions200ResponseMediaContainerMetadataInnerRatingInner.TypeOption.IsSet)
                writer.WriteString("type", getSessions200ResponseMediaContainerMetadataInnerRatingInner.Type);

            if (getSessions200ResponseMediaContainerMetadataInnerRatingInner.ValueOption.IsSet)
                writer.WriteString("value", getSessions200ResponseMediaContainerMetadataInnerRatingInner.Value);
        }
    }

    /// <summary>
    /// The GetSessions200ResponseMediaContainerMetadataInnerRatingInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessions200ResponseMediaContainerMetadataInnerRatingInner))]
    public partial class GetSessions200ResponseMediaContainerMetadataInnerRatingInnerSerializationContext : JsonSerializerContext { }
}
