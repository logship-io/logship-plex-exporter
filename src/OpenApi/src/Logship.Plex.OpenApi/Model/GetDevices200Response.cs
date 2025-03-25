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
    /// GetDevices200Response
    /// </summary>
    public partial class GetDevices200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDevices200Response" /> class.
        /// </summary>
        /// <param name="mediaContainer">mediaContainer</param>
        [JsonConstructor]
        public GetDevices200Response(Option<GetDevices200ResponseMediaContainer?> mediaContainer = default)
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
        public Option<GetDevices200ResponseMediaContainer?> MediaContainerOption { get; private set; }

        /// <summary>
        /// Gets or Sets MediaContainer
        /// </summary>
        [JsonPropertyName("MediaContainer")]
        public GetDevices200ResponseMediaContainer? MediaContainer { get { return this.MediaContainerOption; } set { this.MediaContainerOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetDevices200Response {\n");
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
    /// A Json converter for type <see cref="GetDevices200Response" />
    /// </summary>
    public class GetDevices200ResponseJsonConverter : JsonConverter<GetDevices200Response>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetDevices200Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetDevices200Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<GetDevices200ResponseMediaContainer?> mediaContainer = default;

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
                            mediaContainer = new Option<GetDevices200ResponseMediaContainer?>(JsonSerializer.Deserialize<GetDevices200ResponseMediaContainer>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (mediaContainer.IsSet && mediaContainer.Value == null)
                throw new ArgumentNullException(nameof(mediaContainer), "Property is not nullable for class GetDevices200Response.");

            return new GetDevices200Response(mediaContainer);
        }

        /// <summary>
        /// Serializes a <see cref="GetDevices200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getDevices200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetDevices200Response getDevices200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getDevices200Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetDevices200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getDevices200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetDevices200Response getDevices200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getDevices200Response.MediaContainerOption.IsSet && getDevices200Response.MediaContainer == null)
                throw new ArgumentNullException(nameof(getDevices200Response.MediaContainer), "Property is required for class GetDevices200Response.");

            if (getDevices200Response.MediaContainerOption.IsSet)
            {
                writer.WritePropertyName("MediaContainer");
                JsonSerializer.Serialize(writer, getDevices200Response.MediaContainer, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetDevices200ResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetDevices200Response))]
    public partial class GetDevices200ResponseSerializationContext : JsonSerializerContext { }
}
