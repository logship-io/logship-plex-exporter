using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class ResourceStatisticsService : BaseIntervalService
    {
        private readonly IStatisticsApi api;
        
        public ResourceStatisticsService(IStatisticsApi api, IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerCapabilitiesService> logger) : base(serverApi, exporter, logger)
        {
            this.api = api;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var resources = await this.api.GetResourcesStatisticsAsync(cancellationToken: cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (resources.TryOk(out var result))
            {
                var root = new Dictionary<string, object?>()
                {
                    ["MachineIdentifier"] = machine,
                };

                if (result.MediaContainer!.StatisticsResources != null)
                {
                    foreach (var r in result.MediaContainer.StatisticsResources)
                    {
                        var data = new Dictionary<string, object?>(root)
                        {
                            ["At"] = r.At,
                            ["Timespan"] = r.Timespan,
                            ["HostCpuUtilization"] = r.HostCpuUtilization,
                            ["HostMemoryUtilization"] = r.HostMemoryUtilization,
                            ["ProcessCpuUtilization"] = r.ProcessCpuUtilization,
                            ["ProcessMemoryUtilization"] = r.ProcessMemoryUtilization,

                        };
                        results.Add(new LogshipLogEntrySchema("Plex.Statistics.Resources", timestamp, data));

                    }

                }
            }

            return results;
        }
    }
}
