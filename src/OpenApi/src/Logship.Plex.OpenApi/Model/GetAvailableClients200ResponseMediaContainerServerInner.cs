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
    /// GetAvailableClients200ResponseMediaContainerServerInner
    /// </summary>
    public partial class GetAvailableClients200ResponseMediaContainerServerInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableClients200ResponseMediaContainerServerInner" /> class.
        /// </summary>
        /// <param name="name">name</param>
        /// <param name="host">host</param>
        /// <param name="address">address</param>
        /// <param name="port">port</param>
        /// <param name="machineIdentifier">machineIdentifier</param>
        /// <param name="varVersion">varVersion</param>
        /// <param name="protocol">protocol</param>
        /// <param name="product">product</param>
        /// <param name="deviceClass">deviceClass</param>
        /// <param name="protocolVersion">protocolVersion</param>
        /// <param name="protocolCapabilities">protocolCapabilities</param>
        [JsonConstructor]
        public GetAvailableClients200ResponseMediaContainerServerInner(Option<string?> name = default, Option<string?> host = default, Option<string?> address = default, Option<decimal?> port = default, Option<string?> machineIdentifier = default, Option<string?> varVersion = default, Option<string?> protocol = default, Option<string?> product = default, Option<string?> deviceClass = default, Option<string?> protocolVersion = default, Option<string?> protocolCapabilities = default)
        {
            NameOption = name;
            HostOption = host;
            AddressOption = address;
            PortOption = port;
            MachineIdentifierOption = machineIdentifier;
            VarVersionOption = varVersion;
            ProtocolOption = protocol;
            ProductOption = product;
            DeviceClassOption = deviceClass;
            ProtocolVersionOption = protocolVersion;
            ProtocolCapabilitiesOption = protocolCapabilities;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Name
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> NameOption { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /* <example>iPad</example> */
        [JsonPropertyName("name")]
        public string? Name { get { return this.NameOption; } set { this.NameOption = new(value); } }

        /// <summary>
        /// Used to track the state of Host
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> HostOption { get; private set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        /* <example>10.10.10.102</example> */
        [JsonPropertyName("host")]
        public string? Host { get { return this.HostOption; } set { this.HostOption = new(value); } }

        /// <summary>
        /// Used to track the state of Address
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AddressOption { get; private set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        /* <example>10.10.10.102</example> */
        [JsonPropertyName("address")]
        public string? Address { get { return this.AddressOption; } set { this.AddressOption = new(value); } }

        /// <summary>
        /// Used to track the state of Port
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<decimal?> PortOption { get; private set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        /* <example>32500</example> */
        [JsonPropertyName("port")]
        public decimal? Port { get { return this.PortOption; } set { this.PortOption = new(value); } }

        /// <summary>
        /// Used to track the state of MachineIdentifier
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> MachineIdentifierOption { get; private set; }

        /// <summary>
        /// Gets or Sets MachineIdentifier
        /// </summary>
        /* <example>A2E901F8-E016-43A7-ADFB-EF8CA8A4AC05</example> */
        [JsonPropertyName("machineIdentifier")]
        public string? MachineIdentifier { get { return this.MachineIdentifierOption; } set { this.MachineIdentifierOption = new(value); } }

        /// <summary>
        /// Used to track the state of VarVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VarVersionOption { get; private set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        /* <example>8.17</example> */
        [JsonPropertyName("version")]
        public string? VarVersion { get { return this.VarVersionOption; } set { this.VarVersionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Protocol
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ProtocolOption { get; private set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        /* <example>plex</example> */
        [JsonPropertyName("protocol")]
        public string? Protocol { get { return this.ProtocolOption; } set { this.ProtocolOption = new(value); } }

        /// <summary>
        /// Used to track the state of Product
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ProductOption { get; private set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        /* <example>Plex for iOS</example> */
        [JsonPropertyName("product")]
        public string? Product { get { return this.ProductOption; } set { this.ProductOption = new(value); } }

        /// <summary>
        /// Used to track the state of DeviceClass
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> DeviceClassOption { get; private set; }

        /// <summary>
        /// Gets or Sets DeviceClass
        /// </summary>
        /* <example>tablet</example> */
        [JsonPropertyName("deviceClass")]
        public string? DeviceClass { get { return this.DeviceClassOption; } set { this.DeviceClassOption = new(value); } }

        /// <summary>
        /// Used to track the state of ProtocolVersion
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ProtocolVersionOption { get; private set; }

        /// <summary>
        /// Gets or Sets ProtocolVersion
        /// </summary>
        /* <example>2</example> */
        [JsonPropertyName("protocolVersion")]
        public string? ProtocolVersion { get { return this.ProtocolVersionOption; } set { this.ProtocolVersionOption = new(value); } }

        /// <summary>
        /// Used to track the state of ProtocolCapabilities
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ProtocolCapabilitiesOption { get; private set; }

        /// <summary>
        /// Gets or Sets ProtocolCapabilities
        /// </summary>
        /* <example>playback,playqueues,timeline,provider-playback</example> */
        [JsonPropertyName("protocolCapabilities")]
        public string? ProtocolCapabilities { get { return this.ProtocolCapabilitiesOption; } set { this.ProtocolCapabilitiesOption = new(value); } }

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
            sb.Append("class GetAvailableClients200ResponseMediaContainerServerInner {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  MachineIdentifier: ").Append(MachineIdentifier).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  DeviceClass: ").Append(DeviceClass).Append("\n");
            sb.Append("  ProtocolVersion: ").Append(ProtocolVersion).Append("\n");
            sb.Append("  ProtocolCapabilities: ").Append(ProtocolCapabilities).Append("\n");
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
    /// A Json converter for type <see cref="GetAvailableClients200ResponseMediaContainerServerInner" />
    /// </summary>
    public class GetAvailableClients200ResponseMediaContainerServerInnerJsonConverter : JsonConverter<GetAvailableClients200ResponseMediaContainerServerInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetAvailableClients200ResponseMediaContainerServerInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetAvailableClients200ResponseMediaContainerServerInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> name = default;
            Option<string?> host = default;
            Option<string?> address = default;
            Option<decimal?> port = default;
            Option<string?> machineIdentifier = default;
            Option<string?> varVersion = default;
            Option<string?> protocol = default;
            Option<string?> product = default;
            Option<string?> deviceClass = default;
            Option<string?> protocolVersion = default;
            Option<string?> protocolCapabilities = default;

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
                        case "name":
                            name = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "host":
                            host = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "address":
                            address = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "port":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                port = new Option<decimal?>(utf8JsonReader.GetDecimal());
                            break;
                        case "machineIdentifier":
                            machineIdentifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "version":
                            varVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "protocol":
                            protocol = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "product":
                            product = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "deviceClass":
                            deviceClass = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "protocolVersion":
                            protocolVersion = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "protocolCapabilities":
                            protocolCapabilities = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (name.IsSet && name.Value == null)
                throw new ArgumentNullException(nameof(name), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (host.IsSet && host.Value == null)
                throw new ArgumentNullException(nameof(host), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (address.IsSet && address.Value == null)
                throw new ArgumentNullException(nameof(address), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (port.IsSet && port.Value == null)
                throw new ArgumentNullException(nameof(port), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (machineIdentifier.IsSet && machineIdentifier.Value == null)
                throw new ArgumentNullException(nameof(machineIdentifier), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (varVersion.IsSet && varVersion.Value == null)
                throw new ArgumentNullException(nameof(varVersion), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (protocol.IsSet && protocol.Value == null)
                throw new ArgumentNullException(nameof(protocol), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (product.IsSet && product.Value == null)
                throw new ArgumentNullException(nameof(product), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (deviceClass.IsSet && deviceClass.Value == null)
                throw new ArgumentNullException(nameof(deviceClass), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (protocolVersion.IsSet && protocolVersion.Value == null)
                throw new ArgumentNullException(nameof(protocolVersion), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (protocolCapabilities.IsSet && protocolCapabilities.Value == null)
                throw new ArgumentNullException(nameof(protocolCapabilities), "Property is not nullable for class GetAvailableClients200ResponseMediaContainerServerInner.");

            return new GetAvailableClients200ResponseMediaContainerServerInner(name, host, address, port, machineIdentifier, varVersion, protocol, product, deviceClass, protocolVersion, protocolCapabilities);
        }

        /// <summary>
        /// Serializes a <see cref="GetAvailableClients200ResponseMediaContainerServerInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAvailableClients200ResponseMediaContainerServerInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetAvailableClients200ResponseMediaContainerServerInner getAvailableClients200ResponseMediaContainerServerInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getAvailableClients200ResponseMediaContainerServerInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetAvailableClients200ResponseMediaContainerServerInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getAvailableClients200ResponseMediaContainerServerInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetAvailableClients200ResponseMediaContainerServerInner getAvailableClients200ResponseMediaContainerServerInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getAvailableClients200ResponseMediaContainerServerInner.NameOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.Name == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.Name), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.HostOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.Host == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.Host), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.AddressOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.Address == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.Address), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.MachineIdentifierOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.MachineIdentifier == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.MachineIdentifier), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.VarVersionOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.VarVersion == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.VarVersion), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.ProtocolOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.Protocol == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.Protocol), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.ProductOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.Product == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.Product), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.DeviceClassOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.DeviceClass == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.DeviceClass), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.ProtocolVersionOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.ProtocolVersion == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.ProtocolVersion), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.ProtocolCapabilitiesOption.IsSet && getAvailableClients200ResponseMediaContainerServerInner.ProtocolCapabilities == null)
                throw new ArgumentNullException(nameof(getAvailableClients200ResponseMediaContainerServerInner.ProtocolCapabilities), "Property is required for class GetAvailableClients200ResponseMediaContainerServerInner.");

            if (getAvailableClients200ResponseMediaContainerServerInner.NameOption.IsSet)
                writer.WriteString("name", getAvailableClients200ResponseMediaContainerServerInner.Name);

            if (getAvailableClients200ResponseMediaContainerServerInner.HostOption.IsSet)
                writer.WriteString("host", getAvailableClients200ResponseMediaContainerServerInner.Host);

            if (getAvailableClients200ResponseMediaContainerServerInner.AddressOption.IsSet)
                writer.WriteString("address", getAvailableClients200ResponseMediaContainerServerInner.Address);

            if (getAvailableClients200ResponseMediaContainerServerInner.PortOption.IsSet)
                writer.WriteNumber("port", getAvailableClients200ResponseMediaContainerServerInner.PortOption.Value!.Value);

            if (getAvailableClients200ResponseMediaContainerServerInner.MachineIdentifierOption.IsSet)
                writer.WriteString("machineIdentifier", getAvailableClients200ResponseMediaContainerServerInner.MachineIdentifier);

            if (getAvailableClients200ResponseMediaContainerServerInner.VarVersionOption.IsSet)
                writer.WriteString("version", getAvailableClients200ResponseMediaContainerServerInner.VarVersion);

            if (getAvailableClients200ResponseMediaContainerServerInner.ProtocolOption.IsSet)
                writer.WriteString("protocol", getAvailableClients200ResponseMediaContainerServerInner.Protocol);

            if (getAvailableClients200ResponseMediaContainerServerInner.ProductOption.IsSet)
                writer.WriteString("product", getAvailableClients200ResponseMediaContainerServerInner.Product);

            if (getAvailableClients200ResponseMediaContainerServerInner.DeviceClassOption.IsSet)
                writer.WriteString("deviceClass", getAvailableClients200ResponseMediaContainerServerInner.DeviceClass);

            if (getAvailableClients200ResponseMediaContainerServerInner.ProtocolVersionOption.IsSet)
                writer.WriteString("protocolVersion", getAvailableClients200ResponseMediaContainerServerInner.ProtocolVersion);

            if (getAvailableClients200ResponseMediaContainerServerInner.ProtocolCapabilitiesOption.IsSet)
                writer.WriteString("protocolCapabilities", getAvailableClients200ResponseMediaContainerServerInner.ProtocolCapabilities);
        }
    }

    /// <summary>
    /// The GetAvailableClients200ResponseMediaContainerServerInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetAvailableClients200ResponseMediaContainerServerInner))]
    public partial class GetAvailableClients200ResponseMediaContainerServerInnerSerializationContext : JsonSerializerContext { }
}
