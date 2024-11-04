using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class StatisticsService : BaseIntervalService
    {
        private readonly IStatisticsApi api;
        
        public StatisticsService(IStatisticsApi api, IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerCapabilitiesService> logger) : base(serverApi, exporter, logger)
        {
            this.api = api;
        }

        protected override TimeSpan Interval => TimeSpan.FromSeconds(15);

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var stats = await this.api.GetStatisticsAsync(cancellationToken: cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (stats.TryOk(out var result))
            {
                var root = new Dictionary<string, object?>()
                {
                    ["Size"] = result.MediaContainer?.Size,
                    ["MachineIdentifier"] = machine,
                };

                if (result.MediaContainer?.StatisticsMedia != null)
                {
                    foreach (var media in result.MediaContainer.StatisticsMedia)
                    {
                        var data = new Dictionary<string, object?>(root)
                        {
                            ["AccountID"] = media.AccountID,
                            ["At"] = media.At,
                            ["Count"] = media.Count,
                            ["DeviceID"] = media.DeviceID,
                            ["Timespan"] = media.Timespan,
                            ["MetadataType"] = media.MetadataType,
                            ["Duration"] = media.Duration,
                        };

                        results.Add(new LogshipLogEntrySchema("Plex.Statistics", timestamp, data));

                    }

                }

            }
            return results;
        }
    }
}
