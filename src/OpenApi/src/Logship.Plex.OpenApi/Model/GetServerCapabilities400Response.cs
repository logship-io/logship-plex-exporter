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
    /// GetServerCapabilities400Response
    /// </summary>
    public partial class GetServerCapabilities400Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServerCapabilities400Response" /> class.
        /// </summary>
        /// <param name="errors">errors</param>
        [JsonConstructor]
        public GetServerCapabilities400Response(Option<List<GetServerCapabilities400ResponseErrorsInner>?> errors = default)
        {
            ErrorsOption = errors;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Errors
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetServerCapabilities400ResponseErrorsInner>?> ErrorsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [JsonPropertyName("errors")]
        public List<GetServerCapabilities400ResponseErrorsInner>? Errors { get { return this.ErrorsOption; } set { this.ErrorsOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetServerCapabilities400Response {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
    /// A Json converter for type <see cref="GetServerCapabilities400Response" />
    /// </summary>
    public class GetServerCapabilities400ResponseJsonConverter : JsonConverter<GetServerCapabilities400Response>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetServerCapabilities400Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetServerCapabilities400Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetServerCapabilities400ResponseErrorsInner>?> errors = default;

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
                        case "errors":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                errors = new Option<List<GetServerCapabilities400ResponseErrorsInner>?>(JsonSerializer.Deserialize<List<GetServerCapabilities400ResponseErrorsInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (errors.IsSet && errors.Value == null)
                throw new ArgumentNullException(nameof(errors), "Property is not nullable for class GetServerCapabilities400Response.");

            return new GetServerCapabilities400Response(errors);
        }

        /// <summary>
        /// Serializes a <see cref="GetServerCapabilities400Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getServerCapabilities400Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetServerCapabilities400Response getServerCapabilities400Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getServerCapabilities400Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetServerCapabilities400Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getServerCapabilities400Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetServerCapabilities400Response getServerCapabilities400Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getServerCapabilities400Response.ErrorsOption.IsSet && getServerCapabilities400Response.Errors == null)
                throw new ArgumentNullException(nameof(getServerCapabilities400Response.Errors), "Property is required for class GetServerCapabilities400Response.");

            if (getServerCapabilities400Response.ErrorsOption.IsSet)
            {
                writer.WritePropertyName("errors");
                JsonSerializer.Serialize(writer, getServerCapabilities400Response.Errors, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetServerCapabilities400ResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetServerCapabilities400Response))]
    public partial class GetServerCapabilities400ResponseSerializationContext : JsonSerializerContext { }
}
