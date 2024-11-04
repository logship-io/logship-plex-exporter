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
    /// GetButlerTasks200Response
    /// </summary>
    public partial class GetButlerTasks200Response : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetButlerTasks200Response" /> class.
        /// </summary>
        /// <param name="butlerTasks">butlerTasks</param>
        [JsonConstructor]
        public GetButlerTasks200Response(Option<GetButlerTasks200ResponseButlerTasks?> butlerTasks = default)
        {
            ButlerTasksOption = butlerTasks;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ButlerTasks
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GetButlerTasks200ResponseButlerTasks?> ButlerTasksOption { get; private set; }

        /// <summary>
        /// Gets or Sets ButlerTasks
        /// </summary>
        [JsonPropertyName("ButlerTasks")]
        public GetButlerTasks200ResponseButlerTasks? ButlerTasks { get { return this.ButlerTasksOption; } set { this.ButlerTasksOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetButlerTasks200Response {\n");
            sb.Append("  ButlerTasks: ").Append(ButlerTasks).Append("\n");
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
    /// A Json converter for type <see cref="GetButlerTasks200Response" />
    /// </summary>
    public class GetButlerTasks200ResponseJsonConverter : JsonConverter<GetButlerTasks200Response>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetButlerTasks200Response" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetButlerTasks200Response Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<GetButlerTasks200ResponseButlerTasks?> butlerTasks = default;

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
                        case "ButlerTasks":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                butlerTasks = new Option<GetButlerTasks200ResponseButlerTasks?>(JsonSerializer.Deserialize<GetButlerTasks200ResponseButlerTasks>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (butlerTasks.IsSet && butlerTasks.Value == null)
                throw new ArgumentNullException(nameof(butlerTasks), "Property is not nullable for class GetButlerTasks200Response.");

            return new GetButlerTasks200Response(butlerTasks);
        }

        /// <summary>
        /// Serializes a <see cref="GetButlerTasks200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getButlerTasks200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetButlerTasks200Response getButlerTasks200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getButlerTasks200Response, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetButlerTasks200Response" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getButlerTasks200Response"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetButlerTasks200Response getButlerTasks200Response, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getButlerTasks200Response.ButlerTasksOption.IsSet && getButlerTasks200Response.ButlerTasks == null)
                throw new ArgumentNullException(nameof(getButlerTasks200Response.ButlerTasks), "Property is required for class GetButlerTasks200Response.");

            if (getButlerTasks200Response.ButlerTasksOption.IsSet)
            {
                writer.WritePropertyName("ButlerTasks");
                JsonSerializer.Serialize(writer, getButlerTasks200Response.ButlerTasks, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetButlerTasks200ResponseSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetButlerTasks200Response))]
    public partial class GetButlerTasks200ResponseSerializationContext : JsonSerializerContext { }
}