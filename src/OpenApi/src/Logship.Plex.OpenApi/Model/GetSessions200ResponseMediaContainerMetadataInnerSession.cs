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
    /// GetSessions200ResponseMediaContainerMetadataInnerSession
    /// </summary>
    public partial class GetSessions200ResponseMediaContainerMetadataInnerSession : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessions200ResponseMediaContainerMetadataInnerSession" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="bandwidth">bandwidth</param>
        /// <param name="location">location</param>
        [JsonConstructor]
        public GetSessions200ResponseMediaContainerMetadataInnerSession(Option<string?> id = default, Option<int?> bandwidth = default, Option<string?> location = default)
        {
            IdOption = id;
            BandwidthOption = bandwidth;
            LocationOption = location;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Used to track the state of Bandwidth
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> BandwidthOption { get; private set; }

        /// <summary>
        /// Gets or Sets Bandwidth
        /// </summary>
        [JsonPropertyName("bandwidth")]
        public int? Bandwidth { get { return this.BandwidthOption; } set { this.BandwidthOption = new(value); } }

        /// <summary>
        /// Used to track the state of Location
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> LocationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [JsonPropertyName("location")]
        public string? Location { get { return this.LocationOption; } set { this.LocationOption = new(value); } }

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
            sb.Append("class GetSessions200ResponseMediaContainerMetadataInnerSession {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
    /// A Json converter for type <see cref="GetSessions200ResponseMediaContainerMetadataInnerSession" />
    /// </summary>
    public class GetSessions200ResponseMediaContainerMetadataInnerSessionJsonConverter : JsonConverter<GetSessions200ResponseMediaContainerMetadataInnerSession>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessions200ResponseMediaContainerMetadataInnerSession" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessions200ResponseMediaContainerMetadataInnerSession Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;
            Option<int?> bandwidth = default;
            Option<string?> location = default;

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
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "bandwidth":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                bandwidth = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "location":
                            location = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerSession.");

            if (bandwidth.IsSet && bandwidth.Value == null)
                throw new ArgumentNullException(nameof(bandwidth), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerSession.");

            if (location.IsSet && location.Value == null)
                throw new ArgumentNullException(nameof(location), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerSession.");

            return new GetSessions200ResponseMediaContainerMetadataInnerSession(id, bandwidth, location);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessions200ResponseMediaContainerMetadataInnerSession" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerSession"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerSession getSessions200ResponseMediaContainerMetadataInnerSession, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessions200ResponseMediaContainerMetadataInnerSession, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessions200ResponseMediaContainerMetadataInnerSession" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerSession"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerSession getSessions200ResponseMediaContainerMetadataInnerSession, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessions200ResponseMediaContainerMetadataInnerSession.IdOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerSession.Id == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerSession.Id), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerSession.");

            if (getSessions200ResponseMediaContainerMetadataInnerSession.LocationOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerSession.Location == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerSession.Location), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerSession.");

            if (getSessions200ResponseMediaContainerMetadataInnerSession.IdOption.IsSet)
                writer.WriteString("id", getSessions200ResponseMediaContainerMetadataInnerSession.Id);

            if (getSessions200ResponseMediaContainerMetadataInnerSession.BandwidthOption.IsSet)
                writer.WriteNumber("bandwidth", getSessions200ResponseMediaContainerMetadataInnerSession.BandwidthOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerSession.LocationOption.IsSet)
                writer.WriteString("location", getSessions200ResponseMediaContainerMetadataInnerSession.Location);
        }
    }

    /// <summary>
    /// The GetSessions200ResponseMediaContainerMetadataInnerSessionSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessions200ResponseMediaContainerMetadataInnerSession))]
    public partial class GetSessions200ResponseMediaContainerMetadataInnerSessionSerializationContext : JsonSerializerContext { }
}
