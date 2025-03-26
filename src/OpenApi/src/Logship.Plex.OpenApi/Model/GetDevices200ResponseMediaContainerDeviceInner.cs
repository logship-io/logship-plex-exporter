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
    /// GetDevices200ResponseMediaContainerDeviceInner
    /// </summary>
    public partial class GetDevices200ResponseMediaContainerDeviceInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDevices200ResponseMediaContainerDeviceInner" /> class.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">name</param>
        /// <param name="platform">platform</param>
        /// <param name="clientIdentifier">clientIdentifier</param>
        /// <param name="createdAt">createdAt</param>
        [JsonConstructor]
        public GetDevices200ResponseMediaContainerDeviceInner(Option<decimal?> id = default, Option<string?> name = default, Option<string?> platform = default, Option<string?> clientIdentifier = default, Option<decimal?> createdAt = default)
        {
            IdOption = id;
            NameOption = name;
            PlatformOption = platform;
            ClientIdentifierOption = clientIdentifier;
            CreatedAtOption = createdAt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Id
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> IdOption { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /* <example>1</example> */
        [JsonPropertyName("id")]
        public decimal? Id { get { return this.IdOption; } set { this.IdOption = new(value); } }

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>iPhone</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Used to track the state of Platform
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PlatformOption { get; private set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        /* <example>iOS</example> */
        [JsonPropertyName("platform")]
        public string? Platform { get { return this.PlatformOption; } set { this.PlatformOption = new(value); } }

        /// <summary>
        /// Used to track the state of ClientIdentifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ClientIdentifierOption { get; private set; }

        /// <summary>
        /// Gets or Sets ClientIdentifier
        /// </summary>
        [JsonPropertyName("clientIdentifier")]
        public string? ClientIdentifier { get { return this.ClientIdentifierOption; } set { this.ClientIdentifierOption = new(value); } }

        /// <summary>
        /// Used to track the state of CreatedAt
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> CreatedAtOption { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /* <example>1654131230</example> */
        [JsonPropertyName("createdAt")]
        public decimal? CreatedAt { get { return this.CreatedAtOption; } set { this.CreatedAtOption = new(value); } }

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
            sb.Append("class GetDevices200ResponseMediaContainerDeviceInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ClientIdentifier: ").Append(ClientIdentifier).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
    /// A Json converter for type <see cref="GetDevices200ResponseMediaContainerDeviceInner" />
    /// </summary>
    public class GetDevices200ResponseMediaContainerDeviceInnerJsonConverter : JsonConverter<GetDevices200ResponseMediaContainerDeviceInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetDevices200ResponseMediaContainerDeviceInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetDevices200ResponseMediaContainerDeviceInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> id = default;
            Option<string?> name = default;
            Option<string?> platform = default;
            Option<string?> clientIdentifier = default;
            Option<decimal?> createdAt = default;

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
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "platform":
                            platform = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "clientIdentifier":
                            clientIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "createdAt":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetDevices200ResponseMediaContainerDeviceInner.");

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GetDevices200ResponseMediaContainerDeviceInner.");

            if (platform.IsSet && platform.Value == null)
                throw new ArgumentNullException(nameof(platform), "Property is not nullable for class GetDevices200ResponseMediaContainerDeviceInner.");

            if (clientIdentifier.IsSet && clientIdentifier.Value == null)
                throw new ArgumentNullException(nameof(clientIdentifier), "Property is not nullable for class GetDevices200ResponseMediaContainerDeviceInner.");

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class GetDevices200ResponseMediaContainerDeviceInner.");

            return new GetDevices200ResponseMediaContainerDeviceInner(id, name, platform, clientIdentifier, createdAt);
        }

        /// <summary>
        /// Serializes a <see cref="GetDevices200ResponseMediaContainerDeviceInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getDevices200ResponseMediaContainerDeviceInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetDevices200ResponseMediaContainerDeviceInner getDevices200ResponseMediaContainerDeviceInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getDevices200ResponseMediaContainerDeviceInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetDevices200ResponseMediaContainerDeviceInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getDevices200ResponseMediaContainerDeviceInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetDevices200ResponseMediaContainerDeviceInner getDevices200ResponseMediaContainerDeviceInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getDevices200ResponseMediaContainerDeviceInner.NameOption.IsSet && getDevices200ResponseMediaContainerDeviceInner.Name == null)
                throw new ArgumentNullException(nameof(getDevices200ResponseMediaContainerDeviceInner.Name), "Property is required for class GetDevices200ResponseMediaContainerDeviceInner.");

            if (getDevices200ResponseMediaContainerDeviceInner.PlatformOption.IsSet && getDevices200ResponseMediaContainerDeviceInner.Platform == null)
                throw new ArgumentNullException(nameof(getDevices200ResponseMediaContainerDeviceInner.Platform), "Property is required for class GetDevices200ResponseMediaContainerDeviceInner.");

            if (getDevices200ResponseMediaContainerDeviceInner.ClientIdentifierOption.IsSet && getDevices200ResponseMediaContainerDeviceInner.ClientIdentifier == null)
                throw new ArgumentNullException(nameof(getDevices200ResponseMediaContainerDeviceInner.ClientIdentifier), "Property is required for class GetDevices200ResponseMediaContainerDeviceInner.");

            if (getDevices200ResponseMediaContainerDeviceInner.IdOption.IsSet)
                writer.WriteNumber("id", getDevices200ResponseMediaContainerDeviceInner.IdOption.Value!.Value);

            if (getDevices200ResponseMediaContainerDeviceInner.NameOption.IsSet)
                writer.WriteString("name", getDevices200ResponseMediaContainerDeviceInner.Name);

            if (getDevices200ResponseMediaContainerDeviceInner.PlatformOption.IsSet)
                writer.WriteString("platform", getDevices200ResponseMediaContainerDeviceInner.Platform);

            if (getDevices200ResponseMediaContainerDeviceInner.ClientIdentifierOption.IsSet)
                writer.WriteString("clientIdentifier", getDevices200ResponseMediaContainerDeviceInner.ClientIdentifier);

            if (getDevices200ResponseMediaContainerDeviceInner.CreatedAtOption.IsSet)
                writer.WriteNumber("createdAt", getDevices200ResponseMediaContainerDeviceInner.CreatedAtOption.Value!.Value);
        }
    }

    /// <summary>
    /// The GetDevices200ResponseMediaContainerDeviceInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetDevices200ResponseMediaContainerDeviceInner))]
    public partial class GetDevices200ResponseMediaContainerDeviceInnerSerializationContext : JsonSerializerContext { }
}
