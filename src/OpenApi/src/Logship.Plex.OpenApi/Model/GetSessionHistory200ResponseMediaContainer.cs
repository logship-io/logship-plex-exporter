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
    /// GetSessionHistory200ResponseMediaContainer
    /// </summary>
    public partial class GetSessionHistory200ResponseMediaContainer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessionHistory200ResponseMediaContainer" /> class.
        /// </summary>
        /// <param name="size">size</param>
        /// <param name="metadata">metadata</param>
        [JsonConstructor]
        public GetSessionHistory200ResponseMediaContainer(Option<long?> size = default, Option<List<GetSessionHistory200ResponseMediaContainerMetadataInner>?> metadata = default)
        {
            SizeOption = size;
            MetadataOption = metadata;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Size
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> SizeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [JsonPropertyName("size")]
        public long? Size { get { return this.SizeOption; } set { this.SizeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Metadata
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetSessionHistory200ResponseMediaContainerMetadataInner>?> MetadataOption { get; private set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [JsonPropertyName("Metadata")]
        public List<GetSessionHistory200ResponseMediaContainerMetadataInner>? Metadata { get { return this.MetadataOption; } set { this.MetadataOption = new(value); } }

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
            sb.Append("class GetSessionHistory200ResponseMediaContainer {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
    /// A Json converter for type <see cref="GetSessionHistory200ResponseMediaContainer" />
    /// </summary>
    public class GetSessionHistory200ResponseMediaContainerJsonConverter : JsonConverter<GetSessionHistory200ResponseMediaContainer>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessionHistory200ResponseMediaContainer" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessionHistory200ResponseMediaContainer Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> size = default;
            Option<List<GetSessionHistory200ResponseMediaContainerMetadataInner>?> metadata = default;

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
                        case "size":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                size = new Option<long?>(JsonSerializer.Deserialize<long>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "Metadata":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                metadata = new Option<List<GetSessionHistory200ResponseMediaContainerMetadataInner>?>(JsonSerializer.Deserialize<List<GetSessionHistory200ResponseMediaContainerMetadataInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (size.IsSet && size.Value == null)
                throw new ArgumentNullException(nameof(size), "Property is not nullable for class GetSessionHistory200ResponseMediaContainer.");

            if (metadata.IsSet && metadata.Value == null)
                throw new ArgumentNullException(nameof(metadata), "Property is not nullable for class GetSessionHistory200ResponseMediaContainer.");

            return new GetSessionHistory200ResponseMediaContainer(size, metadata);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessionHistory200ResponseMediaContainer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessionHistory200ResponseMediaContainer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessionHistory200ResponseMediaContainer getSessionHistory200ResponseMediaContainer, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessionHistory200ResponseMediaContainer, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessionHistory200ResponseMediaContainer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessionHistory200ResponseMediaContainer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessionHistory200ResponseMediaContainer getSessionHistory200ResponseMediaContainer, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessionHistory200ResponseMediaContainer.MetadataOption.IsSet && getSessionHistory200ResponseMediaContainer.Metadata == null)
                throw new ArgumentNullException(nameof(getSessionHistory200ResponseMediaContainer.Metadata), "Property is required for class GetSessionHistory200ResponseMediaContainer.");

            if (getSessionHistory200ResponseMediaContainer.SizeOption.IsSet)
            {
                writer.WritePropertyName("size");
                JsonSerializer.Serialize(writer, getSessionHistory200ResponseMediaContainer.Size, jsonSerializerOptions);
            }
            if (getSessionHistory200ResponseMediaContainer.MetadataOption.IsSet)
            {
                writer.WritePropertyName("Metadata");
                JsonSerializer.Serialize(writer, getSessionHistory200ResponseMediaContainer.Metadata, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetSessionHistory200ResponseMediaContainerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessionHistory200ResponseMediaContainer))]
    public partial class GetSessionHistory200ResponseMediaContainerSerializationContext : JsonSerializerContext { }
}
