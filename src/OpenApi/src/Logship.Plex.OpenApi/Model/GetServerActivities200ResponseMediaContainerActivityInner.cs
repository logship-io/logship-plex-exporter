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
    /// GetServerActivities200ResponseMediaContainerActivityInner
    /// </summary>
    public partial class GetServerActivities200ResponseMediaContainerActivityInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetServerActivities200ResponseMediaContainerActivityInner" /> class.
        /// </summary>
        /// <param name="uuid">uuid</param>
        /// <param name="type">type</param>
        /// <param name="cancellable">cancellable</param>
        /// <param name="userID">userID</param>
        /// <param name="title">title</param>
        /// <param name="subtitle">subtitle</param>
        /// <param name="progress">progress</param>
        /// <param name="context">context</param>
        [JsonConstructor]
        public GetServerActivities200ResponseMediaContainerActivityInner(Option<string?> uuid = default, Option<string?> type = default, Option<bool?> cancellable = default, Option<decimal?> userID = default, Option<string?> title = default, Option<string?> subtitle = default, Option<decimal?> progress = default, Option<GetServerActivities200ResponseMediaContainerActivityInnerContext?> context = default)
        {
            UuidOption = uuid;
            TypeOption = type;
            CancellableOption = cancellable;
            UserIDOption = userID;
            TitleOption = title;
            SubtitleOption = subtitle;
            ProgressOption = progress;
            ContextOption = context;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Uuid
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> UuidOption { get; private set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [JsonPropertyName("uuid")]
        public string? Uuid { get { return this.UuidOption; } set { this.UuidOption = new(value); } }

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
        /// Used to track the state of Cancellable
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> CancellableOption { get; private set; }

        /// <summary>
        /// Gets or Sets Cancellable
        /// </summary>
        [JsonPropertyName("cancellable")]
        public bool? Cancellable { get { return this.CancellableOption; } set { this.CancellableOption = new(value); } }

        /// <summary>
        /// Used to track the state of UserID
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> UserIDOption { get; private set; }

        /// <summary>
        /// Gets or Sets UserID
        /// </summary>
        [JsonPropertyName("userID")]
        public decimal? UserID { get { return this.UserIDOption; } set { this.UserIDOption = new(value); } }

        /// <summary>
        /// Used to track the state of Title
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> TitleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [JsonPropertyName("title")]
        public string? Title { get { return this.TitleOption; } set { this.TitleOption = new(value); } }

        /// <summary>
        /// Used to track the state of Subtitle
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SubtitleOption { get; private set; }

        /// <summary>
        /// Gets or Sets Subtitle
        /// </summary>
        [JsonPropertyName("subtitle")]
        public string? Subtitle { get { return this.SubtitleOption; } set { this.SubtitleOption = new(value); } }

        /// <summary>
        /// Used to track the state of Progress
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> ProgressOption { get; private set; }

        /// <summary>
        /// Gets or Sets Progress
        /// </summary>
        [JsonPropertyName("progress")]
        public decimal? Progress { get { return this.ProgressOption; } set { this.ProgressOption = new(value); } }

        /// <summary>
        /// Used to track the state of Context
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<GetServerActivities200ResponseMediaContainerActivityInnerContext?> ContextOption { get; private set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [JsonPropertyName("Context")]
        public GetServerActivities200ResponseMediaContainerActivityInnerContext? Context { get { return this.ContextOption; } set { this.ContextOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetServerActivities200ResponseMediaContainerActivityInner {\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Cancellable: ").Append(Cancellable).Append("\n");
            sb.Append("  UserID: ").Append(UserID).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
    /// A Json converter for type <see cref="GetServerActivities200ResponseMediaContainerActivityInner" />
    /// </summary>
    public class GetServerActivities200ResponseMediaContainerActivityInnerJsonConverter : JsonConverter<GetServerActivities200ResponseMediaContainerActivityInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetServerActivities200ResponseMediaContainerActivityInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetServerActivities200ResponseMediaContainerActivityInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> uuid = default;
            Option<string?> type = default;
            Option<bool?> cancellable = default;
            Option<decimal?> userID = default;
            Option<string?> title = default;
            Option<string?> subtitle = default;
            Option<decimal?> progress = default;
            Option<GetServerActivities200ResponseMediaContainerActivityInnerContext?> context = default;

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
                        case "uuid":
                            uuid = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "cancellable":
                            cancellable = new Option<bool?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (bool?)null : utf8JsonReader.GetBoolean());
                            break;
                        case "userID":
                            userID = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "title":
                            title = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "subtitle":
                            subtitle = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "progress":
                            progress = new Option<decimal?>(utf8JsonReader.TokenType == JsonTokenType.Null ? (decimal?)null : utf8JsonReader.GetDecimal());
                            break;
                        case "Context":
                            context = new Option<GetServerActivities200ResponseMediaContainerActivityInnerContext?>(JsonSerializer.Deserialize<GetServerActivities200ResponseMediaContainerActivityInnerContext>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (uuid.IsSet && uuid.Value == null)
                throw new ArgumentNullException(nameof(uuid), "Property is not nullable for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (cancellable.IsSet && cancellable.Value == null)
                throw new ArgumentNullException(nameof(cancellable), "Property is not nullable for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (userID.IsSet && userID.Value == null)
                throw new ArgumentNullException(nameof(userID), "Property is not nullable for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (title.IsSet && title.Value == null)
                throw new ArgumentNullException(nameof(title), "Property is not nullable for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (subtitle.IsSet && subtitle.Value == null)
                throw new ArgumentNullException(nameof(subtitle), "Property is not nullable for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (progress.IsSet && progress.Value == null)
                throw new ArgumentNullException(nameof(progress), "Property is not nullable for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (context.IsSet && context.Value == null)
                throw new ArgumentNullException(nameof(context), "Property is not nullable for class GetServerActivities200ResponseMediaContainerActivityInner.");

            return new GetServerActivities200ResponseMediaContainerActivityInner(uuid, type, cancellable, userID, title, subtitle, progress, context);
        }

        /// <summary>
        /// Serializes a <see cref="GetServerActivities200ResponseMediaContainerActivityInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getServerActivities200ResponseMediaContainerActivityInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetServerActivities200ResponseMediaContainerActivityInner getServerActivities200ResponseMediaContainerActivityInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getServerActivities200ResponseMediaContainerActivityInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetServerActivities200ResponseMediaContainerActivityInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getServerActivities200ResponseMediaContainerActivityInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetServerActivities200ResponseMediaContainerActivityInner getServerActivities200ResponseMediaContainerActivityInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getServerActivities200ResponseMediaContainerActivityInner.UuidOption.IsSet && getServerActivities200ResponseMediaContainerActivityInner.Uuid == null)
                throw new ArgumentNullException(nameof(getServerActivities200ResponseMediaContainerActivityInner.Uuid), "Property is required for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (getServerActivities200ResponseMediaContainerActivityInner.TypeOption.IsSet && getServerActivities200ResponseMediaContainerActivityInner.Type == null)
                throw new ArgumentNullException(nameof(getServerActivities200ResponseMediaContainerActivityInner.Type), "Property is required for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (getServerActivities200ResponseMediaContainerActivityInner.TitleOption.IsSet && getServerActivities200ResponseMediaContainerActivityInner.Title == null)
                throw new ArgumentNullException(nameof(getServerActivities200ResponseMediaContainerActivityInner.Title), "Property is required for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (getServerActivities200ResponseMediaContainerActivityInner.SubtitleOption.IsSet && getServerActivities200ResponseMediaContainerActivityInner.Subtitle == null)
                throw new ArgumentNullException(nameof(getServerActivities200ResponseMediaContainerActivityInner.Subtitle), "Property is required for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (getServerActivities200ResponseMediaContainerActivityInner.ContextOption.IsSet && getServerActivities200ResponseMediaContainerActivityInner.Context == null)
                throw new ArgumentNullException(nameof(getServerActivities200ResponseMediaContainerActivityInner.Context), "Property is required for class GetServerActivities200ResponseMediaContainerActivityInner.");

            if (getServerActivities200ResponseMediaContainerActivityInner.UuidOption.IsSet)
                writer.WriteString("uuid", getServerActivities200ResponseMediaContainerActivityInner.Uuid);

            if (getServerActivities200ResponseMediaContainerActivityInner.TypeOption.IsSet)
                writer.WriteString("type", getServerActivities200ResponseMediaContainerActivityInner.Type);

            if (getServerActivities200ResponseMediaContainerActivityInner.CancellableOption.IsSet)
                writer.WriteBoolean("cancellable", getServerActivities200ResponseMediaContainerActivityInner.CancellableOption.Value!.Value);

            if (getServerActivities200ResponseMediaContainerActivityInner.UserIDOption.IsSet)
                writer.WriteNumber("userID", getServerActivities200ResponseMediaContainerActivityInner.UserIDOption.Value!.Value);

            if (getServerActivities200ResponseMediaContainerActivityInner.TitleOption.IsSet)
                writer.WriteString("title", getServerActivities200ResponseMediaContainerActivityInner.Title);

            if (getServerActivities200ResponseMediaContainerActivityInner.SubtitleOption.IsSet)
                writer.WriteString("subtitle", getServerActivities200ResponseMediaContainerActivityInner.Subtitle);

            if (getServerActivities200ResponseMediaContainerActivityInner.ProgressOption.IsSet)
                writer.WriteNumber("progress", getServerActivities200ResponseMediaContainerActivityInner.ProgressOption.Value!.Value);

            if (getServerActivities200ResponseMediaContainerActivityInner.ContextOption.IsSet)
            {
                writer.WritePropertyName("Context");
                JsonSerializer.Serialize(writer, getServerActivities200ResponseMediaContainerActivityInner.Context, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetServerActivities200ResponseMediaContainerActivityInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetServerActivities200ResponseMediaContainerActivityInner))]
    public partial class GetServerActivities200ResponseMediaContainerActivityInnerSerializationContext : JsonSerializerContext { }
}
