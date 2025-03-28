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
    /// GetStatistics200ResponseMediaContainerStatisticsMediaInner
    /// </summary>
    public partial class GetStatistics200ResponseMediaContainerStatisticsMediaInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatistics200ResponseMediaContainerStatisticsMediaInner" /> class.
        /// </summary>
        /// <param name="accountID">accountID</param>
        /// <param name="deviceID">deviceID</param>
        /// <param name="timespan">timespan</param>
        /// <param name="at">at</param>
        /// <param name="metadataType">metadataType</param>
        /// <param name="count">count</param>
        /// <param name="duration">duration</param>
        [JsonConstructor]
        public GetStatistics200ResponseMediaContainerStatisticsMediaInner(Option<int?> accountID = default, Option<int?> deviceID = default, Option<int?> timespan = default, Option<int?> at = default, Option<int?> metadataType = default, Option<int?> count = default, Option<int?> duration = default)
        {
            AccountIDOption = accountID;
            DeviceIDOption = deviceID;
            TimespanOption = timespan;
            AtOption = at;
            MetadataTypeOption = metadataType;
            CountOption = count;
            DurationOption = duration;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of AccountID
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> AccountIDOption { get; private set; }

        /// <summary>
        /// Gets or Sets AccountID
        /// </summary>
        /* <example>1</example> */
        [JsonPropertyName("accountID")]
        public int? AccountID { get { return this.AccountIDOption; } set { this.AccountIDOption = new(value); } }

        /// <summary>
        /// Used to track the state of DeviceID
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> DeviceIDOption { get; private set; }

        /// <summary>
        /// Gets or Sets DeviceID
        /// </summary>
        /* <example>13</example> */
        [JsonPropertyName("deviceID")]
        public int? DeviceID { get { return this.DeviceIDOption; } set { this.DeviceIDOption = new(value); } }

        /// <summary>
        /// Used to track the state of Timespan
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> TimespanOption { get; private set; }

        /// <summary>
        /// Gets or Sets Timespan
        /// </summary>
        /* <example>4</example> */
        [JsonPropertyName("timespan")]
        public int? Timespan { get { return this.TimespanOption; } set { this.TimespanOption = new(value); } }

        /// <summary>
        /// Used to track the state of At
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> AtOption { get; private set; }

        /// <summary>
        /// Gets or Sets At
        /// </summary>
        /* <example>1707141600</example> */
        [JsonPropertyName("at")]
        public int? At { get { return this.AtOption; } set { this.AtOption = new(value); } }

        /// <summary>
        /// Used to track the state of MetadataType
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> MetadataTypeOption { get; private set; }

        /// <summary>
        /// Gets or Sets MetadataType
        /// </summary>
        /* <example>4</example> */
        [JsonPropertyName("metadataType")]
        public int? MetadataType { get { return this.MetadataTypeOption; } set { this.MetadataTypeOption = new(value); } }

        /// <summary>
        /// Used to track the state of Count
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> CountOption { get; private set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        /* <example>1</example> */
        [JsonPropertyName("count")]
        public int? Count { get { return this.CountOption; } set { this.CountOption = new(value); } }

        /// <summary>
        /// Used to track the state of Duration
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> DurationOption { get; private set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        /* <example>1555</example> */
        [JsonPropertyName("duration")]
        public int? Duration { get { return this.DurationOption; } set { this.DurationOption = new(value); } }

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
            sb.Append("class GetStatistics200ResponseMediaContainerStatisticsMediaInner {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  DeviceID: ").Append(DeviceID).Append("\n");
            sb.Append("  Timespan: ").Append(Timespan).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  MetadataType: ").Append(MetadataType).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
    /// A Json converter for type <see cref="GetStatistics200ResponseMediaContainerStatisticsMediaInner" />
    /// </summary>
    public class GetStatistics200ResponseMediaContainerStatisticsMediaInnerJsonConverter : JsonConverter<GetStatistics200ResponseMediaContainerStatisticsMediaInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetStatistics200ResponseMediaContainerStatisticsMediaInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetStatistics200ResponseMediaContainerStatisticsMediaInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<int?> accountID = default;
            Option<int?> deviceID = default;
            Option<int?> timespan = default;
            Option<int?> at = default;
            Option<int?> metadataType = default;
            Option<int?> count = default;
            Option<int?> duration = default;

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
                        case "accountID":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                accountID = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "deviceID":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                deviceID = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "timespan":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                timespan = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                at = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "metadataType":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                metadataType = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                count = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "duration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                duration = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (accountID.IsSet && accountID.Value == null)
                throw new ArgumentNullException(nameof(accountID), "Property is not nullable for class GetStatistics200ResponseMediaContainerStatisticsMediaInner.");

            if (deviceID.IsSet && deviceID.Value == null)
                throw new ArgumentNullException(nameof(deviceID), "Property is not nullable for class GetStatistics200ResponseMediaContainerStatisticsMediaInner.");

            if (timespan.IsSet && timespan.Value == null)
                throw new ArgumentNullException(nameof(timespan), "Property is not nullable for class GetStatistics200ResponseMediaContainerStatisticsMediaInner.");

            if (at.IsSet && at.Value == null)
                throw new ArgumentNullException(nameof(at), "Property is not nullable for class GetStatistics200ResponseMediaContainerStatisticsMediaInner.");

            if (metadataType.IsSet && metadataType.Value == null)
                throw new ArgumentNullException(nameof(metadataType), "Property is not nullable for class GetStatistics200ResponseMediaContainerStatisticsMediaInner.");

            if (count.IsSet && count.Value == null)
                throw new ArgumentNullException(nameof(count), "Property is not nullable for class GetStatistics200ResponseMediaContainerStatisticsMediaInner.");

            if (duration.IsSet && duration.Value == null)
                throw new ArgumentNullException(nameof(duration), "Property is not nullable for class GetStatistics200ResponseMediaContainerStatisticsMediaInner.");

            return new GetStatistics200ResponseMediaContainerStatisticsMediaInner(accountID, deviceID, timespan, at, metadataType, count, duration);
        }

        /// <summary>
        /// Serializes a <see cref="GetStatistics200ResponseMediaContainerStatisticsMediaInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getStatistics200ResponseMediaContainerStatisticsMediaInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetStatistics200ResponseMediaContainerStatisticsMediaInner getStatistics200ResponseMediaContainerStatisticsMediaInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getStatistics200ResponseMediaContainerStatisticsMediaInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetStatistics200ResponseMediaContainerStatisticsMediaInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getStatistics200ResponseMediaContainerStatisticsMediaInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetStatistics200ResponseMediaContainerStatisticsMediaInner getStatistics200ResponseMediaContainerStatisticsMediaInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getStatistics200ResponseMediaContainerStatisticsMediaInner.AccountIDOption.IsSet)
                writer.WriteNumber("accountID", getStatistics200ResponseMediaContainerStatisticsMediaInner.AccountIDOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerStatisticsMediaInner.DeviceIDOption.IsSet)
                writer.WriteNumber("deviceID", getStatistics200ResponseMediaContainerStatisticsMediaInner.DeviceIDOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerStatisticsMediaInner.TimespanOption.IsSet)
                writer.WriteNumber("timespan", getStatistics200ResponseMediaContainerStatisticsMediaInner.TimespanOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerStatisticsMediaInner.AtOption.IsSet)
                writer.WriteNumber("at", getStatistics200ResponseMediaContainerStatisticsMediaInner.AtOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerStatisticsMediaInner.MetadataTypeOption.IsSet)
                writer.WriteNumber("metadataType", getStatistics200ResponseMediaContainerStatisticsMediaInner.MetadataTypeOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerStatisticsMediaInner.CountOption.IsSet)
                writer.WriteNumber("count", getStatistics200ResponseMediaContainerStatisticsMediaInner.CountOption.Value!.Value);

            if (getStatistics200ResponseMediaContainerStatisticsMediaInner.DurationOption.IsSet)
                writer.WriteNumber("duration", getStatistics200ResponseMediaContainerStatisticsMediaInner.DurationOption.Value!.Value);
        }
    }

    /// <summary>
    /// The GetStatistics200ResponseMediaContainerStatisticsMediaInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetStatistics200ResponseMediaContainerStatisticsMediaInner))]
    public partial class GetStatistics200ResponseMediaContainerStatisticsMediaInnerSerializationContext : JsonSerializerContext { }
}
