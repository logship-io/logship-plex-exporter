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
    /// GetSessions200ResponseMediaContainerMetadataInnerFieldInner
    /// </summary>
    public partial class GetSessions200ResponseMediaContainerMetadataInnerFieldInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessions200ResponseMediaContainerMetadataInnerFieldInner" /> class.
        /// </summary>
        /// <param name="locked">locked</param>
        /// <param name="name">name</param>
        [JsonConstructor]
        public GetSessions200ResponseMediaContainerMetadataInnerFieldInner(Option<bool?> locked = default, Option<string?> name = default)
        {
            LockedOption = locked;
            NameOption = name;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Locked
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> LockedOption { get; private set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [JsonPropertyName("locked")]
        public bool? Locked { get { return this.LockedOption; } set { this.LockedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

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
            sb.Append("class GetSessions200ResponseMediaContainerMetadataInnerFieldInner {\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
    /// A Json converter for type <see cref="GetSessions200ResponseMediaContainerMetadataInnerFieldInner" />
    /// </summary>
    public class GetSessions200ResponseMediaContainerMetadataInnerFieldInnerJsonConverter : JsonConverter<GetSessions200ResponseMediaContainerMetadataInnerFieldInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessions200ResponseMediaContainerMetadataInnerFieldInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessions200ResponseMediaContainerMetadataInnerFieldInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<bool?> locked = default;
            Option<string?> name = default;

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
                        case "locked":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                locked = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (locked.IsSet && locked.Value == null)
                throw new ArgumentNullException(nameof(locked), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerFieldInner.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerFieldInner.");

            return new GetSessions200ResponseMediaContainerMetadataInnerFieldInner(locked, name);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessions200ResponseMediaContainerMetadataInnerFieldInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerFieldInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerFieldInner getSessions200ResponseMediaContainerMetadataInnerFieldInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessions200ResponseMediaContainerMetadataInnerFieldInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessions200ResponseMediaContainerMetadataInnerFieldInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerFieldInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerFieldInner getSessions200ResponseMediaContainerMetadataInnerFieldInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessions200ResponseMediaContainerMetadataInnerFieldInner.NameOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerFieldInner.Name == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerFieldInner.Name), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerFieldInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerFieldInner.LockedOption.IsSet)
                writer.WriteBoolean("locked", getSessions200ResponseMediaContainerMetadataInnerFieldInner.LockedOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerFieldInner.NameOption.IsSet)
                writer.WriteString("name", getSessions200ResponseMediaContainerMetadataInnerFieldInner.Name);
        }
    }

    /// <summary>
    /// The GetSessions200ResponseMediaContainerMetadataInnerFieldInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessions200ResponseMediaContainerMetadataInnerFieldInner))]
    public partial class GetSessions200ResponseMediaContainerMetadataInnerFieldInnerSerializationContext : JsonSerializerContext { }
}
