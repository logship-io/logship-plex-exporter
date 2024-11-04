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
    /// GetSessions200Response
    /// </summary>
    public partial class GetSessions200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessions200Response" /> class.
        /// </summary>
        /// <param name="mediaContainer">mediaContainer</param>
        [JsonConstructor]
        public GetSessions200Response(Option<GetSessions200ResponseMediaContainer?> mediaContainer = default)
        {
            MediaContainerOption = mediaContainer;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of MediaContainer
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GetSessions200ResponseMediaContainer?> MediaContainerOption { get; private set; }

        /// <summary>
        /// Gets or Sets MediaContainer
        /// </summary>
        [JsonPropertyName("MediaContainer")]
        public GetSessions200ResponseMediaContainer? MediaContainer { get { return this.MediaContainerOption; } set { this.MediaContainerOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSessions200Response {\n");
            sb.Append("  MediaContainer: ").Append(MediaContainer).Append("\n");
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
    /// A Json converter for type <see cref="GetSessions200Response" />
    /// </summary>
    public class GetSessions200ResponseJsonConverter : JsonConverter<GetSessions200Response>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessions200Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessions200Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<GetSessions200ResponseMediaContainer?> mediaContainer = default;

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
                        case "MediaContainer":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                mediaContainer = new Option<GetSessions200ResponseMediaContainer?>(JsonSerializer.Deserialize<GetSessions200ResponseMediaContainer>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (mediaContainer.IsSet && mediaContainer.Value == null)
                throw new ArgumentNullException(nameof(mediaContainer), "Property is not nullable for class GetSessions200Response.");

            return new GetSessions200Response(mediaContainer);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessions200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessions200Response getSessions200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessions200Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessions200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessions200Response getSessions200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessions200Response.MediaContainerOption.IsSet && getSessions200Response.MediaContainer == null)
                throw new ArgumentNullException(nameof(getSessions200Response.MediaContainer), "Property is required for class GetSessions200Response.");

            if (getSessions200Response.MediaContainerOption.IsSet)
            {
                writer.WritePropertyName("MediaContainer");
                JsonSerializer.Serialize(writer, getSessions200Response.MediaContainer, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetSessions200ResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessions200Response))]
    public partial class GetSessions200ResponseSerializationContext : JsonSerializerContext { }
}
