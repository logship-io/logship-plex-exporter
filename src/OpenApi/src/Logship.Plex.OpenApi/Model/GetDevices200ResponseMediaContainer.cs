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
    /// GetDevices200ResponseMediaContainer
    /// </summary>
    public partial class GetDevices200ResponseMediaContainer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDevices200ResponseMediaContainer" /> class.
        /// </summary>
        /// <param name="size">size</param>
        /// <param name="identifier">identifier</param>
        /// <param name="device">device</param>
        [JsonConstructor]
        public GetDevices200ResponseMediaContainer(Option<decimal?> size = default, Option<string?> identifier = default, Option<List<GetDevices200ResponseMediaContainerDeviceInner>?> device = default)
        {
            SizeOption = size;
            IdentifierOption = identifier;
            DeviceOption = device;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Size
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> SizeOption { get; private set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        /* <example>151</example> */
        [JsonPropertyName("size")]
        public decimal? Size { get { return this.SizeOption; } set { this.SizeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Identifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> IdentifierOption { get; private set; }

        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        /* <example>com.plexapp.system.devices</example> */
        [JsonPropertyName("identifier")]
        public string? Identifier { get { return this.IdentifierOption; } set { this.IdentifierOption = new(value); } }

        /// <summary>
        /// Used to track the state of Device
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetDevices200ResponseMediaContainerDeviceInner>?> DeviceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [JsonPropertyName("Device")]
        public List<GetDevices200ResponseMediaContainerDeviceInner>? Device { get { return this.DeviceOption; } set { this.DeviceOption = new(value); } }

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
            sb.Append("class GetDevices200ResponseMediaContainer {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
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
    /// A Json converter for type <see cref="GetDevices200ResponseMediaContainer" />
    /// </summary>
    public class GetDevices200ResponseMediaContainerJsonConverter : JsonConverter<GetDevices200ResponseMediaContainer>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetDevices200ResponseMediaContainer" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetDevices200ResponseMediaContainer Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<decimal?> size = default;
            Option<string?> identifier = default;
            Option<List<GetDevices200ResponseMediaContainerDeviceInner>?> device = default;

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
                        case "size":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                size = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "identifier":
                            identifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "Device":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                device = new Option<List<GetDevices200ResponseMediaContainerDeviceInner>?>(JsonSerializer.Deserialize<List<GetDevices200ResponseMediaContainerDeviceInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (size.IsSet && size.Value == null)
                throw new ArgumentNullException(nameof(size), "Property is not nullable for class GetDevices200ResponseMediaContainer.");

            if (identifier.IsSet && identifier.Value == null)
                throw new ArgumentNullException(nameof(identifier), "Property is not nullable for class GetDevices200ResponseMediaContainer.");

            if (device.IsSet && device.Value == null)
                throw new ArgumentNullException(nameof(device), "Property is not nullable for class GetDevices200ResponseMediaContainer.");

            return new GetDevices200ResponseMediaContainer(size, identifier, device);
        }

        /// <summary>
        /// Serializes a <see cref="GetDevices200ResponseMediaContainer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getDevices200ResponseMediaContainer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetDevices200ResponseMediaContainer getDevices200ResponseMediaContainer, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getDevices200ResponseMediaContainer, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetDevices200ResponseMediaContainer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getDevices200ResponseMediaContainer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetDevices200ResponseMediaContainer getDevices200ResponseMediaContainer, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getDevices200ResponseMediaContainer.IdentifierOption.IsSet && getDevices200ResponseMediaContainer.Identifier == null)
                throw new ArgumentNullException(nameof(getDevices200ResponseMediaContainer.Identifier), "Property is required for class GetDevices200ResponseMediaContainer.");

            if (getDevices200ResponseMediaContainer.DeviceOption.IsSet && getDevices200ResponseMediaContainer.Device == null)
                throw new ArgumentNullException(nameof(getDevices200ResponseMediaContainer.Device), "Property is required for class GetDevices200ResponseMediaContainer.");

            if (getDevices200ResponseMediaContainer.SizeOption.IsSet)
                writer.WriteNumber("size", getDevices200ResponseMediaContainer.SizeOption.Value!.Value);

            if (getDevices200ResponseMediaContainer.IdentifierOption.IsSet)
                writer.WriteString("identifier", getDevices200ResponseMediaContainer.Identifier);

            if (getDevices200ResponseMediaContainer.DeviceOption.IsSet)
            {
                writer.WritePropertyName("Device");
                JsonSerializer.Serialize(writer, getDevices200ResponseMediaContainer.Device, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetDevices200ResponseMediaContainerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetDevices200ResponseMediaContainer))]
    public partial class GetDevices200ResponseMediaContainerSerializationContext : JsonSerializerContext { }
}
