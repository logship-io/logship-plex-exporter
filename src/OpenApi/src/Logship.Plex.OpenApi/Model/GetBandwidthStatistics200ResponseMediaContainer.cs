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
    /// GetBandwidthStatistics200ResponseMediaContainer
    /// </summary>
    public partial class GetBandwidthStatistics200ResponseMediaContainer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetBandwidthStatistics200ResponseMediaContainer" /> class.
        /// </summary>
        /// <param name="size">size</param>
        /// <param name="device">device</param>
        /// <param name="account">account</param>
        /// <param name="statisticsBandwidth">statisticsBandwidth</param>
        [JsonConstructor]
        public GetBandwidthStatistics200ResponseMediaContainer(Option<long?> size = default, Option<List<GetStatistics200ResponseMediaContainerDeviceInner>?> device = default, Option<List<GetStatistics200ResponseMediaContainerAccountInner>?> account = default, Option<List<GetBandwidthStatistics200ResponseMediaContainerStatisticsBandwidthInner>?> statisticsBandwidth = default)
        {
            SizeOption = size;
            DeviceOption = device;
            AccountOption = account;
            StatisticsBandwidthOption = statisticsBandwidth;
            OnCreated();
        }

        partial void OnCreated();

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
        /// Used to track the state of Device
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetStatistics200ResponseMediaContainerDeviceInner>?> DeviceOption { get; private set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [JsonPropertyName("Device")]
        public List<GetStatistics200ResponseMediaContainerDeviceInner>? Device { get { return this.DeviceOption; } set { this.DeviceOption = new(value); } }

        /// <summary>
        /// Used to track the state of Account
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetStatistics200ResponseMediaContainerAccountInner>?> AccountOption { get; private set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [JsonPropertyName("Account")]
        public List<GetStatistics200ResponseMediaContainerAccountInner>? Account { get { return this.AccountOption; } set { this.AccountOption = new(value); } }

        /// <summary>
        /// Used to track the state of StatisticsBandwidth
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetBandwidthStatistics200ResponseMediaContainerStatisticsBandwidthInner>?> StatisticsBandwidthOption { get; private set; }

        /// <summary>
        /// Gets or Sets StatisticsBandwidth
        /// </summary>
        [JsonPropertyName("StatisticsBandwidth")]
        public List<GetBandwidthStatistics200ResponseMediaContainerStatisticsBandwidthInner>? StatisticsBandwidth { get { return this.StatisticsBandwidthOption; } set { this.StatisticsBandwidthOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetBandwidthStatistics200ResponseMediaContainer {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  StatisticsBandwidth: ").Append(StatisticsBandwidth).Append("\n");
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
    /// A Json converter for type <see cref="GetBandwidthStatistics200ResponseMediaContainer" />
    /// </summary>
    public class GetBandwidthStatistics200ResponseMediaContainerJsonConverter : JsonConverter<GetBandwidthStatistics200ResponseMediaContainer>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetBandwidthStatistics200ResponseMediaContainer" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetBandwidthStatistics200ResponseMediaContainer Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> size = default;
            Option<List<GetStatistics200ResponseMediaContainerDeviceInner>?> device = default;
            Option<List<GetStatistics200ResponseMediaContainerAccountInner>?> account = default;
            Option<List<GetBandwidthStatistics200ResponseMediaContainerStatisticsBandwidthInner>?> statisticsBandwidth = default;

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
                            size = new Option<long?>(JsonSerializer.Deserialize<long>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "Device":
                            device = new Option<List<GetStatistics200ResponseMediaContainerDeviceInner>?>(JsonSerializer.Deserialize<List<GetStatistics200ResponseMediaContainerDeviceInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "Account":
                            account = new Option<List<GetStatistics200ResponseMediaContainerAccountInner>?>(JsonSerializer.Deserialize<List<GetStatistics200ResponseMediaContainerAccountInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "StatisticsBandwidth":
                            statisticsBandwidth = new Option<List<GetBandwidthStatistics200ResponseMediaContainerStatisticsBandwidthInner>?>(JsonSerializer.Deserialize<List<GetBandwidthStatistics200ResponseMediaContainerStatisticsBandwidthInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (size.IsSet && size.Value == null)
                throw new ArgumentNullException(nameof(size), "Property is not nullable for class GetBandwidthStatistics200ResponseMediaContainer.");

            if (device.IsSet && device.Value == null)
                throw new ArgumentNullException(nameof(device), "Property is not nullable for class GetBandwidthStatistics200ResponseMediaContainer.");

            if (account.IsSet && account.Value == null)
                throw new ArgumentNullException(nameof(account), "Property is not nullable for class GetBandwidthStatistics200ResponseMediaContainer.");

            if (statisticsBandwidth.IsSet && statisticsBandwidth.Value == null)
                throw new ArgumentNullException(nameof(statisticsBandwidth), "Property is not nullable for class GetBandwidthStatistics200ResponseMediaContainer.");

            return new GetBandwidthStatistics200ResponseMediaContainer(size, device, account, statisticsBandwidth);
        }

        /// <summary>
        /// Serializes a <see cref="GetBandwidthStatistics200ResponseMediaContainer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getBandwidthStatistics200ResponseMediaContainer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetBandwidthStatistics200ResponseMediaContainer getBandwidthStatistics200ResponseMediaContainer, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getBandwidthStatistics200ResponseMediaContainer, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetBandwidthStatistics200ResponseMediaContainer" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getBandwidthStatistics200ResponseMediaContainer"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetBandwidthStatistics200ResponseMediaContainer getBandwidthStatistics200ResponseMediaContainer, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getBandwidthStatistics200ResponseMediaContainer.DeviceOption.IsSet && getBandwidthStatistics200ResponseMediaContainer.Device == null)
                throw new ArgumentNullException(nameof(getBandwidthStatistics200ResponseMediaContainer.Device), "Property is required for class GetBandwidthStatistics200ResponseMediaContainer.");

            if (getBandwidthStatistics200ResponseMediaContainer.AccountOption.IsSet && getBandwidthStatistics200ResponseMediaContainer.Account == null)
                throw new ArgumentNullException(nameof(getBandwidthStatistics200ResponseMediaContainer.Account), "Property is required for class GetBandwidthStatistics200ResponseMediaContainer.");

            if (getBandwidthStatistics200ResponseMediaContainer.StatisticsBandwidthOption.IsSet && getBandwidthStatistics200ResponseMediaContainer.StatisticsBandwidth == null)
                throw new ArgumentNullException(nameof(getBandwidthStatistics200ResponseMediaContainer.StatisticsBandwidth), "Property is required for class GetBandwidthStatistics200ResponseMediaContainer.");

            if (getBandwidthStatistics200ResponseMediaContainer.SizeOption.IsSet)
            {
                writer.WritePropertyName("size");
                JsonSerializer.Serialize(writer, getBandwidthStatistics200ResponseMediaContainer.Size, jsonSerializerOptions);
            }
            if (getBandwidthStatistics200ResponseMediaContainer.DeviceOption.IsSet)
            {
                writer.WritePropertyName("Device");
                JsonSerializer.Serialize(writer, getBandwidthStatistics200ResponseMediaContainer.Device, jsonSerializerOptions);
            }
            if (getBandwidthStatistics200ResponseMediaContainer.AccountOption.IsSet)
            {
                writer.WritePropertyName("Account");
                JsonSerializer.Serialize(writer, getBandwidthStatistics200ResponseMediaContainer.Account, jsonSerializerOptions);
            }
            if (getBandwidthStatistics200ResponseMediaContainer.StatisticsBandwidthOption.IsSet)
            {
                writer.WritePropertyName("StatisticsBandwidth");
                JsonSerializer.Serialize(writer, getBandwidthStatistics200ResponseMediaContainer.StatisticsBandwidth, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetBandwidthStatistics200ResponseMediaContainerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetBandwidthStatistics200ResponseMediaContainer))]
    public partial class GetBandwidthStatistics200ResponseMediaContainerSerializationContext : JsonSerializerContext { }
}
