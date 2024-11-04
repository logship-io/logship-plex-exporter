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
    /// GetSessions200ResponseMediaContainerMetadataInnerMediaInner
    /// </summary>
    public partial class GetSessions200ResponseMediaContainerMetadataInnerMediaInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInner" /> class.
        /// </summary>
        /// <param name="aspectRatio">aspectRatio</param>
        /// <param name="audioChannels">audioChannels</param>
        /// <param name="audioCodec">audioCodec</param>
        /// <param name="bitrate">bitrate</param>
        /// <param name="container">container</param>
        /// <param name="duration">duration</param>
        /// <param name="height">height</param>
        /// <param name="id">id</param>
        /// <param name="videoCodec">videoCodec</param>
        /// <param name="videoFrameRate">videoFrameRate</param>
        /// <param name="videoProfile">videoProfile</param>
        /// <param name="videoResolution">videoResolution</param>
        /// <param name="width">width</param>
        /// <param name="selected">selected</param>
        /// <param name="part">part</param>
        [JsonConstructor]
        public GetSessions200ResponseMediaContainerMetadataInnerMediaInner(Option<string?> aspectRatio = default, Option<int?> audioChannels = default, Option<string?> audioCodec = default, Option<int?> bitrate = default, Option<string?> container = default, Option<int?> duration = default, Option<int?> height = default, Option<string?> id = default, Option<string?> videoCodec = default, Option<string?> videoFrameRate = default, Option<string?> videoProfile = default, Option<string?> videoResolution = default, Option<int?> width = default, Option<bool?> selected = default, Option<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner>?> part = default)
        {
            AspectRatioOption = aspectRatio;
            AudioChannelsOption = audioChannels;
            AudioCodecOption = audioCodec;
            BitrateOption = bitrate;
            ContainerOption = container;
            DurationOption = duration;
            HeightOption = height;
            IdOption = id;
            VideoCodecOption = videoCodec;
            VideoFrameRateOption = videoFrameRate;
            VideoProfileOption = videoProfile;
            VideoResolutionOption = videoResolution;
            WidthOption = width;
            SelectedOption = selected;
            PartOption = part;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of AspectRatio
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AspectRatioOption { get; private set; }

        /// <summary>
        /// Gets or Sets AspectRatio
        /// </summary>
        [JsonPropertyName("aspectRatio")]
        public string? AspectRatio { get { return this.AspectRatioOption; } set { this.AspectRatioOption = new(value); } }

        /// <summary>
        /// Used to track the state of AudioChannels
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> AudioChannelsOption { get; private set; }

        /// <summary>
        /// Gets or Sets AudioChannels
        /// </summary>
        [JsonPropertyName("audioChannels")]
        public int? AudioChannels { get { return this.AudioChannelsOption; } set { this.AudioChannelsOption = new(value); } }

        /// <summary>
        /// Used to track the state of AudioCodec
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> AudioCodecOption { get; private set; }

        /// <summary>
        /// Gets or Sets AudioCodec
        /// </summary>
        [JsonPropertyName("audioCodec")]
        public string? AudioCodec { get { return this.AudioCodecOption; } set { this.AudioCodecOption = new(value); } }

        /// <summary>
        /// Used to track the state of Bitrate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> BitrateOption { get; private set; }

        /// <summary>
        /// Gets or Sets Bitrate
        /// </summary>
        [JsonPropertyName("bitrate")]
        public int? Bitrate { get { return this.BitrateOption; } set { this.BitrateOption = new(value); } }

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
        /// Used to track the state of Height
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> HeightOption { get; private set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [JsonPropertyName("height")]
        public int? Height { get { return this.HeightOption; } set { this.HeightOption = new(value); } }

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
        /// Used to track the state of VideoCodec
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VideoCodecOption { get; private set; }

        /// <summary>
        /// Gets or Sets VideoCodec
        /// </summary>
        [JsonPropertyName("videoCodec")]
        public string? VideoCodec { get { return this.VideoCodecOption; } set { this.VideoCodecOption = new(value); } }

        /// <summary>
        /// Used to track the state of VideoFrameRate
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VideoFrameRateOption { get; private set; }

        /// <summary>
        /// Gets or Sets VideoFrameRate
        /// </summary>
        [JsonPropertyName("videoFrameRate")]
        public string? VideoFrameRate { get { return this.VideoFrameRateOption; } set { this.VideoFrameRateOption = new(value); } }

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
        /// Used to track the state of VideoResolution
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> VideoResolutionOption { get; private set; }

        /// <summary>
        /// Gets or Sets VideoResolution
        /// </summary>
        [JsonPropertyName("videoResolution")]
        public string? VideoResolution { get { return this.VideoResolutionOption; } set { this.VideoResolutionOption = new(value); } }

        /// <summary>
        /// Used to track the state of Width
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<int?> WidthOption { get; private set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [JsonPropertyName("width")]
        public int? Width { get { return this.WidthOption; } set { this.WidthOption = new(value); } }

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
        /// Used to track the state of Part
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner>?> PartOption { get; private set; }

        /// <summary>
        /// Gets or Sets Part
        /// </summary>
        [JsonPropertyName("Part")]
        public List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner>? Part { get { return this.PartOption; } set { this.PartOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSessions200ResponseMediaContainerMetadataInnerMediaInner {\n");
            sb.Append("  AspectRatio: ").Append(AspectRatio).Append("\n");
            sb.Append("  AudioChannels: ").Append(AudioChannels).Append("\n");
            sb.Append("  AudioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  Bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  Container: ").Append(Container).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VideoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  VideoFrameRate: ").Append(VideoFrameRate).Append("\n");
            sb.Append("  VideoProfile: ").Append(VideoProfile).Append("\n");
            sb.Append("  VideoResolution: ").Append(VideoResolution).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Part: ").Append(Part).Append("\n");
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
    /// A Json converter for type <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInner" />
    /// </summary>
    public class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerJsonConverter : JsonConverter<GetSessions200ResponseMediaContainerMetadataInnerMediaInner>
    {
        /// <summary>
        /// Deserializes json to <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInner" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override GetSessions200ResponseMediaContainerMetadataInnerMediaInner Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> aspectRatio = default;
            Option<int?> audioChannels = default;
            Option<string?> audioCodec = default;
            Option<int?> bitrate = default;
            Option<string?> container = default;
            Option<int?> duration = default;
            Option<int?> height = default;
            Option<string?> id = default;
            Option<string?> videoCodec = default;
            Option<string?> videoFrameRate = default;
            Option<string?> videoProfile = default;
            Option<string?> videoResolution = default;
            Option<int?> width = default;
            Option<bool?> selected = default;
            Option<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner>?> part = default;

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
                        case "aspectRatio":
                            aspectRatio = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "audioChannels":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                audioChannels = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "audioCodec":
                            audioCodec = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "bitrate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                bitrate = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "container":
                            container = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "duration":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                duration = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "height":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                height = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "id":
                            id = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "videoCodec":
                            videoCodec = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "videoFrameRate":
                            videoFrameRate = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "videoProfile":
                            videoProfile = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "videoResolution":
                            videoResolution = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "width":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                width = new Option<int?>(utf8JsonReader.GetInt32());
                            break;
                        case "selected":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                selected = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "Part":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                part = new Option<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner>?>(JsonSerializer.Deserialize<List<GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInner>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (aspectRatio.IsSet && aspectRatio.Value == null)
                throw new ArgumentNullException(nameof(aspectRatio), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (audioChannels.IsSet && audioChannels.Value == null)
                throw new ArgumentNullException(nameof(audioChannels), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (audioCodec.IsSet && audioCodec.Value == null)
                throw new ArgumentNullException(nameof(audioCodec), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (bitrate.IsSet && bitrate.Value == null)
                throw new ArgumentNullException(nameof(bitrate), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (container.IsSet && container.Value == null)
                throw new ArgumentNullException(nameof(container), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (duration.IsSet && duration.Value == null)
                throw new ArgumentNullException(nameof(duration), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (height.IsSet && height.Value == null)
                throw new ArgumentNullException(nameof(height), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (videoCodec.IsSet && videoCodec.Value == null)
                throw new ArgumentNullException(nameof(videoCodec), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (videoFrameRate.IsSet && videoFrameRate.Value == null)
                throw new ArgumentNullException(nameof(videoFrameRate), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (videoProfile.IsSet && videoProfile.Value == null)
                throw new ArgumentNullException(nameof(videoProfile), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (videoResolution.IsSet && videoResolution.Value == null)
                throw new ArgumentNullException(nameof(videoResolution), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (width.IsSet && width.Value == null)
                throw new ArgumentNullException(nameof(width), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (selected.IsSet && selected.Value == null)
                throw new ArgumentNullException(nameof(selected), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (part.IsSet && part.Value == null)
                throw new ArgumentNullException(nameof(part), "Property is not nullable for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            return new GetSessions200ResponseMediaContainerMetadataInnerMediaInner(aspectRatio, audioChannels, audioCodec, bitrate, container, duration, height, id, videoCodec, videoFrameRate, videoProfile, videoResolution, width, selected, part);
        }

        /// <summary>
        /// Serializes a <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerMediaInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerMediaInner getSessions200ResponseMediaContainerMetadataInnerMediaInner, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, getSessions200ResponseMediaContainerMetadataInnerMediaInner, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="GetSessions200ResponseMediaContainerMetadataInnerMediaInner" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="getSessions200ResponseMediaContainerMetadataInnerMediaInner"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, GetSessions200ResponseMediaContainerMetadataInnerMediaInner getSessions200ResponseMediaContainerMetadataInnerMediaInner, JsonSerializerOptions jsonSerializerOptions)
        {
            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.AspectRatioOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.AspectRatio == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.AspectRatio), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.AudioCodecOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.AudioCodec == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.AudioCodec), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.ContainerOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.Container == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.Container), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.IdOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.Id == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.Id), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoCodecOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoCodec == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoCodec), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoFrameRateOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoFrameRate == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoFrameRate), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoProfileOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoProfile == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoProfile), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoResolutionOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoResolution == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoResolution), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.PartOption.IsSet && getSessions200ResponseMediaContainerMetadataInnerMediaInner.Part == null)
                throw new ArgumentNullException(nameof(getSessions200ResponseMediaContainerMetadataInnerMediaInner.Part), "Property is required for class GetSessions200ResponseMediaContainerMetadataInnerMediaInner.");

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.AspectRatioOption.IsSet)
                writer.WriteString("aspectRatio", getSessions200ResponseMediaContainerMetadataInnerMediaInner.AspectRatio);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.AudioChannelsOption.IsSet)
                writer.WriteNumber("audioChannels", getSessions200ResponseMediaContainerMetadataInnerMediaInner.AudioChannelsOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.AudioCodecOption.IsSet)
                writer.WriteString("audioCodec", getSessions200ResponseMediaContainerMetadataInnerMediaInner.AudioCodec);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.BitrateOption.IsSet)
                writer.WriteNumber("bitrate", getSessions200ResponseMediaContainerMetadataInnerMediaInner.BitrateOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.ContainerOption.IsSet)
                writer.WriteString("container", getSessions200ResponseMediaContainerMetadataInnerMediaInner.Container);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.DurationOption.IsSet)
                writer.WriteNumber("duration", getSessions200ResponseMediaContainerMetadataInnerMediaInner.DurationOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.HeightOption.IsSet)
                writer.WriteNumber("height", getSessions200ResponseMediaContainerMetadataInnerMediaInner.HeightOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.IdOption.IsSet)
                writer.WriteString("id", getSessions200ResponseMediaContainerMetadataInnerMediaInner.Id);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoCodecOption.IsSet)
                writer.WriteString("videoCodec", getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoCodec);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoFrameRateOption.IsSet)
                writer.WriteString("videoFrameRate", getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoFrameRate);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoProfileOption.IsSet)
                writer.WriteString("videoProfile", getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoProfile);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoResolutionOption.IsSet)
                writer.WriteString("videoResolution", getSessions200ResponseMediaContainerMetadataInnerMediaInner.VideoResolution);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.WidthOption.IsSet)
                writer.WriteNumber("width", getSessions200ResponseMediaContainerMetadataInnerMediaInner.WidthOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.SelectedOption.IsSet)
                writer.WriteBoolean("selected", getSessions200ResponseMediaContainerMetadataInnerMediaInner.SelectedOption.Value!.Value);

            if (getSessions200ResponseMediaContainerMetadataInnerMediaInner.PartOption.IsSet)
            {
                writer.WritePropertyName("Part");
                JsonSerializer.Serialize(writer, getSessions200ResponseMediaContainerMetadataInnerMediaInner.Part, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The GetSessions200ResponseMediaContainerMetadataInnerMediaInnerSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(GetSessions200ResponseMediaContainerMetadataInnerMediaInner))]
    public partial class GetSessions200ResponseMediaContainerMetadataInnerMediaInnerSerializationContext : JsonSerializerContext { }
}
