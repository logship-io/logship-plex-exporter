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
    /// GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner
    /// </summary>
    public partial class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner" /> class.
        /// </summary>
        /// <param name="container">container</param>
        /// <param name="duration">duration</param>
        /// <param name="file">file</param>
        /// <param name="id">id</param>
        /// <param name="key">key</param>
        /// <param name="size">size</param>
        /// <param name="videoProfile">videoProfile</param>
        /// <param name="decision">decision</param>
        /// <param name="selected">selected</param>
        /// <param name="stream">stream</param>
        [JsonConstructor]
        public GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner(Option<string?> container = default, Option<int?> duration = default, Option<string?> file = default, Option<string?> id = default, Option<string?> key = default, Option<long?> size = default, Option<string?> videoProfile = default, Option<string?> decision = default, Option<bool?> selected = default, Option<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerStreamInner>?> stream = default)
        {
            ContainerOption = container;
            DurationOption = duration;
            FileOption = file;
            IdOption = id;
            KeyOption = key;
            SizeOption = size;
            VideoProfileOption = videoProfile;
            DecisionOption = decision;
            SelectedOption = selected;
            StreamOption = stream;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Container
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ContainerOption { get; private set; }

        /// <summary>
        /// Gets or Sets Container
        /// </summary>
        [JsonPropertyName("container")]
        public string? Container { get { return this.ContainerOption; } set { this.ContainerOption = new(value); } }

        /// <summary>
        /// Used to track the state of Duration
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> DurationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [JsonPropertyName("duration")]
        public int? Duration { get { return this.DurationOption; } set { this.DurationOption = new(value); } }

        /// <summary>
        /// Used to track the state of File
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FileOption { get; private set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [JsonPropertyName("file")]
        public string? File { get { return this.FileOption; } set { this.FileOption = new(value); } }

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
        /// Used to track the state of Key
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> KeyOption { get; private set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [JsonPropertyName("key")]
        public string? Key { get { return this.KeyOption; } set { this.KeyOption = new(value); } }

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
        /// Used to track the state of VideoProfile
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VideoProfileOption { get; private set; }

        /// <summary>
        /// Gets or Sets VideoProfile
        /// </summary>
        [JsonPropertyName("videoProfile")]
        public string? VideoProfile { get { return this.VideoProfileOption; } set { this.VideoProfileOption = new(value); } }

        /// <summary>
        /// Used to track the state of Decision
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DecisionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Decision
        /// </summary>
        [JsonPropertyName("decision")]
        public string? Decision { get { return this.DecisionOption; } set { this.DecisionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Selected
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> SelectedOption { get; private set; }

        /// <summary>
        /// Gets or Sets Selected
        /// </summary>
        [JsonPropertyName("selected")]
        public bool? Selected { get { return this.SelectedOption; } set { this.SelectedOption = new(value); } }

        /// <summary>
        /// Used to track the state of Stream
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerStreamInner>?> StreamOption { get; private set; }

        /// <summary>
        /// Gets or Sets Stream
        /// </summary>
        [JsonPropertyName("Stream")]
        public List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerStreamInner>? Stream { get { return this.StreamOption; } set { this.StreamOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner {\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  VideoProfile: ").Append(VideoProfile).Append("\n");
            sb.Append("  Decision: ").Append(Decision).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
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
    /// A Json converter for type <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner" />
    /// </summary>
    public class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerJsonConverter : JsonConverter<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> container = default;
            Option<int?> duration = default;
            Option<string?> file = default;
            Option<string?> id = default;
            Option<string?> key = default;
            Option<long?> size = default;
            Option<string?> videoProfile = default;
            Option<string?> decision = default;
            Option<bool?> selected = default;
            Option<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerStreamInner>?> stream = default;

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
                        case "container":
                            container = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "duration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                duration = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "file":
                            file = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "key":
                            key = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "size":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                size = new Option<long?>(JsonSerializer.Deserialize<long>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "videoProfile":
                            videoProfile = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "decision":
                            decision = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "selected":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                selected = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "Stream":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                stream = new Option<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerStreamInner>?>(JsonSerializer.Deserialize<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerStreamInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (container.IsSet && container.Value == null)
                throw new ArgumentNullException(nameof(container), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (duration.IsSet && duration.Value == null)
                throw new ArgumentNullException(nameof(duration), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (file.IsSet && file.Value == null)
                throw new ArgumentNullException(nameof(file), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (key.IsSet && key.Value == null)
                throw new ArgumentNullException(nameof(key), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (size.IsSet && size.Value == null)
                throw new ArgumentNullException(nameof(size), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (videoProfile.IsSet && videoProfile.Value == null)
                throw new ArgumentNullException(nameof(videoProfile), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (decision.IsSet && decision.Value == null)
                throw new ArgumentNullException(nameof(decision), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (selected.IsSet && selected.Value == null)
                throw new ArgumentNullException(nameof(selected), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (stream.IsSet && stream.Value == null)
                throw new ArgumentNullException(nameof(stream), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            return new GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner(container, duration, file, id, key, size, videoProfile, decision, selected, stream);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.ContainerOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Container == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Container), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.FileOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.File == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.File), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.IdOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Id == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Id), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.KeyOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Key == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Key), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.VideoProfileOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.VideoProfile == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.VideoProfile), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.DecisionOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Decision == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Decision), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.StreamOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Stream == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Stream), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.ContainerOption.IsSet)
                writer.WriteString("container", getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Container);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.DurationOption.IsSet)
                writer.WriteNumber("duration", getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.DurationOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.FileOption.IsSet)
                writer.WriteString("file", getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.File);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.IdOption.IsSet)
                writer.WriteString("id", getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Id);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.KeyOption.IsSet)
                writer.WriteString("key", getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Key);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.SizeOption.IsSet)
            {
                writer.WritePropertyName("size");
                JsonSerializer.Serialize(writer, getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Size, jsonSerializerOptions);
            }
            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.VideoProfileOption.IsSet)
                writer.WriteString("videoProfile", getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.VideoProfile);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.DecisionOption.IsSet)
                writer.WriteString("decision", getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Decision);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.SelectedOption.IsSet)
                writer.WriteBoolean("selected", getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.SelectedOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.StreamOption.IsSet)
            {
                writer.WritePropertyName("Stream");
                JsonSerializer.Serialize(writer, getSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner.Stream, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner))]
    public partial class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerSerializationContext : JsonSerializerContext { }
}
