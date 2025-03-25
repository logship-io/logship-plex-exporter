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
    /// GetButlerTasks200ResponseButlerTasks
    /// </summary>
    public partial class GetButlerTasks200ResponseButlerTasks : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetButlerTasks200ResponseButlerTasks" /> class.
        /// </summary>
        /// <param name="butlerTask">butlerTask</param>
        [JsonConstructor]
        public GetButlerTasks200ResponseButlerTasks(Option<List<GetButlerTasks200ResponseButlerTasksButlerTaskInner>?> butlerTask = default)
        {
            ButlerTaskOption = butlerTask;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of ButlerTask
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetButlerTasks200ResponseButlerTasksButlerTaskInner>?> ButlerTaskOption { get; private set; }

        /// <summary>
        /// Gets or Sets ButlerTask
        /// </summary>
        [JsonPropertyName("ButlerTask")]
        public List<GetButlerTasks200ResponseButlerTasksButlerTaskInner>? ButlerTask { get { return this.ButlerTaskOption; } set { this.ButlerTaskOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetButlerTasks200ResponseButlerTasks {\n");
            sb.Append("  ButlerTask: ").Append(ButlerTask).Append("\n");
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
    /// A Json converter for type <see cref="GetButlerTasks200ResponseButlerTasks" />
    /// </summary>
    public class GetButlerTasks200ResponseButlerTasksJsonConverter : JsonConverter<GetButlerTasks200ResponseButlerTasks>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetButlerTasks200ResponseButlerTasks" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetButlerTasks200ResponseButlerTasks Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<List<GetButlerTasks200ResponseButlerTasksButlerTaskInner>?> butlerTask = default;

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
                        case "ButlerTask":
                            butlerTask = new Option<List<GetButlerTasks200ResponseButlerTasksButlerTaskInner>?>(JsonSerializer.Deserialize<List<GetButlerTasks200ResponseButlerTasksButlerTaskInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (butlerTask.IsSet && butlerTask.Value == null)
                throw new ArgumentNullException(nameof(butlerTask), "Property is not nullable for class GetButlerTasks200ResponseButlerTasks.");

            return new GetButlerTasks200ResponseButlerTasks(butlerTask);
        }

        /// <summary>
        /// Serializes a <see cref="GetButlerTasks200ResponseButlerTasks" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getButlerTasks200ResponseButlerTasks"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetButlerTasks200ResponseButlerTasks getButlerTasks200ResponseButlerTasks, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getButlerTasks200ResponseButlerTasks, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetButlerTasks200ResponseButlerTasks" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getButlerTasks200ResponseButlerTasks"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetButlerTasks200ResponseButlerTasks getButlerTasks200ResponseButlerTasks, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getButlerTasks200ResponseButlerTasks.ButlerTaskOption.IsSet && getButlerTasks200ResponseButlerTasks.ButlerTask == null)
                throw new ArgumentNullException(nameof(getButlerTasks200ResponseButlerTasks.ButlerTask), "Property is required for class GetButlerTasks200ResponseButlerTasks.");

            if (getButlerTasks200ResponseButlerTasks.ButlerTaskOption.IsSet)
            {
                writer.WritePropertyName("ButlerTask");
                JsonSerializer.Serialize(writer, getButlerTasks200ResponseButlerTasks.ButlerTask, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetButlerTasks200ResponseButlerTasksSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetButlerTasks200ResponseButlerTasks))]
    public partial class GetButlerTasks200ResponseButlerTasksSerializationContext : JsonSerializerContext { }
}
