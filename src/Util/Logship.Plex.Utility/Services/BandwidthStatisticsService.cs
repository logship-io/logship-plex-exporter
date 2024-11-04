using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logship.Plex.Utility.Services
{
    internal sealed class BandwidthStatisticsService : BaseIntervalService
    {
        private readonly IStatisticsApi api;
        
        public BandwidthStatisticsService(IStatisticsApi api, IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerCapabilitiesService> logger) : base(serverApi, exporter, logger)
        {
            this.api = api;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var stats = await this.api.GetBandwidthStatisticsAsync(cancellationToken: cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (stats.TryOk(out var result))
            {
                var data = new Dictionary<string, object?>()
                {
                    ["MachineIdentifier"] = machine,
                };

                if (result.MediaContainer!.Account != null
                    && result.MediaContainer.Account.Count > 0)
                {
                    var account = result.MediaContainer.Account[0];
                    data["AccountName"] = account.Name;
                    data["AutoSelectAudio"] = account.AutoSelectAudio;
                    data["DefaultAudioLanguage"] = account.DefaultAudioLanguage;
                    data["DefaultSubtitleLanguage"] = account.DefaultSubtitleLanguage;
                    data["AccountId"] = account.Id;
                    data["Key"] = account.Key;
                    data["SubtitleMode"] = account.SubtitleMode;
                    data["Thumb"] = account.Thumb;
                    
                }

                if (result.MediaContainer.Device != null
                    && result.MediaContainer.Device.Count > 0)
                {
                    var device = result.MediaContainer.Device[0];
                    data["DeviceName"] = device.Name;
                    data["ClientIdentifier"] = device.ClientIdentifier;
                    data["DeviceCreatedAt"] = device.CreatedAt;
                    data["DeviceId"] = device.Id;
                    data["Platform"] = device.Platform;
                }

                if (result.MediaContainer.StatisticsBandwidth != null)
                {
                    foreach (var b in result.MediaContainer.StatisticsBandwidth)
                    {
                        var s = new Dictionary<string, object?>(data)
                        {
                            ["Lan"] = b.Lan,
                            ["Timespan"] = b.Timespan,
                            ["Bytes"] = b.Bytes,
                            ["At"] = b.At,
                        };
                        
                        results.Add(new LogshipLogEntrySchema("Plex.Statistics.Bandwidth", timestamp, s));
                    }
                }

            }

            return results;
        }
    }
}
