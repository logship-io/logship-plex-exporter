using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class ServerCapabilitiesService : BaseIntervalService
    {
        private readonly IServerApi serverApi;
        
        public ServerCapabilitiesService(IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerCapabilitiesService> logger) : base(serverApi, exporter, logger)
        {
            this.serverApi = serverApi;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var capabilities = await this.serverApi.GetServerCapabilitiesAsync(cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (capabilities.TryOk(out var result))
            {
                var data = new Dictionary<string, object?>()
                {
                    ["Size"] = result.MediaContainer!.Size,
                    ["AllowCameraUpload"] = result.MediaContainer.AllowCameraUpload ?? false,
                    ["EventStream"] = result.MediaContainer.EventStream ?? false,
                    ["MyPlexSigninState"] = result.MediaContainer.MyPlexSigninState ?? string.Empty,
                    ["AllowChannelAccess"] = result.MediaContainer.AllowChannelAccess ?? false,
                    ["AllowMediaDeletion"] = result.MediaContainer.AllowMediaDeletion ?? false,
                    ["AllowSharing"] = result.MediaContainer.AllowSharing ?? false,
                    ["AllowSync"] = result.MediaContainer.AllowSync ?? false,
                    ["AllowTuners"] = result.MediaContainer.AllowTuners ?? false,
                    ["BackgroundProcessing"] = result.MediaContainer.BackgroundProcessing ?? false,
                    ["Certificate"] = result.MediaContainer.Certificate ?? false,
                    ["CompanionProxy"] = result.MediaContainer.CompanionProxy ?? false,
                    ["CountryCode"] = result.MediaContainer.CountryCode ?? string.Empty,
                    ["Diagnostics"] = result.MediaContainer.Diagnostics ?? string.Empty,
                    ["FriendlyName"] = result.MediaContainer.FriendlyName ?? string.Empty,
                    ["HubSearch"] = result.MediaContainer.HubSearch ?? false,
                    ["ItemClusters"] = result.MediaContainer.ItemClusters ?? false,
                    ["Livetv"] = result.MediaContainer.Livetv,
                    ["MachineIdentifier"] = result.MediaContainer.MachineIdentifier ?? string.Empty,
                    ["MediaProviders"] = result.MediaContainer.MediaProviders ?? false,
                    ["Multiuser"] = result.MediaContainer.Multiuser ?? false,
                    ["MusicAnalysis"] = result.MediaContainer.MusicAnalysis,
                    ["MyPlex"] = result.MediaContainer.MyPlex ?? false,
                    ["MyPlexMappingState"] = result.MediaContainer.MyPlexMappingState ?? string.Empty,
                    ["MyPlexSubscription"] = result.MediaContainer.MyPlexSubscription ?? false,
                    ["MyPlexUsername"] = result.MediaContainer.MyPlexUsername ?? string.Empty,
                    ["OfflineTranscode"] = result.MediaContainer.OfflineTranscode,
                    ["OwnerFeatures"] = result.MediaContainer.OwnerFeatures ?? string.Empty,
                    ["PhotoAutoTag"] = result.MediaContainer.PhotoAutoTag ?? false,
                    ["Platform"] = result.MediaContainer.Platform ?? string.Empty,
                    ["PlatformVersion"] = result.MediaContainer.PlatformVersion ?? string.Empty,
                    ["PluginHost"] = result.MediaContainer.PluginHost ?? false,
                    ["PushNotifications"] = result.MediaContainer.PushNotifications ?? false,
                    ["ReadOnlyLibraries"] = result.MediaContainer.ReadOnlyLibraries ?? false,
                    ["StreamingBrainABRVersion"] = result.MediaContainer.StreamingBrainABRVersion,
                    ["Sync"] = result.MediaContainer.Sync ?? false,
                    ["TranscoderVideoBitrates"] = result.MediaContainer.TranscoderVideoBitrates ?? string.Empty,
                    ["TranscoderActiveVideoSessions"] = result.MediaContainer.TranscoderActiveVideoSessions,
                    ["TranscoderAudio"] = result.MediaContainer.TranscoderAudio ?? false,
                    ["TranscoderLyrics"] = result.MediaContainer.TranscoderLyrics ?? false,
                    ["TranscoderPhoto"] = result.MediaContainer.TranscoderPhoto ?? false,
                    ["TranscoderSubtitles"] = result.MediaContainer.TranscoderSubtitles ?? false,
                    ["TranscoderVideo"] = result.MediaContainer.TranscoderVideo ?? false,
                    ["TranscoderVideoQualities"] = result.MediaContainer.TranscoderVideoQualities ?? string.Empty,
                    ["TranscoderVideoResolutions"] = result.MediaContainer.TranscoderVideoResolutions ?? string.Empty,
                    ["UpdatedAt"] = result.MediaContainer.UpdatedAt,
                    ["Updater"] = result.MediaContainer.Updater ?? false,
                    ["VarVersion"] = result.MediaContainer.VarVersion ?? string.Empty,
                };

                results.Add(new LogshipLogEntrySchema("Plex.Server.Clients", timestamp, data));
            }
            return results;
        }
    }
}
