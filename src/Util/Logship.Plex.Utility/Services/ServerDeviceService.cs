using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class ServerDeviceService : BaseIntervalService
    {
        private readonly IServerApi serverApi;
        
        public ServerDeviceService(IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerDeviceService> logger) : base(serverApi, exporter, logger)
        {
            this.serverApi = serverApi;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var devices = await this.serverApi.GetDevicesAsync(cancellationToken);
            var timestamp = DateTime.UtcNow;

            if (devices.TryOk(out var devicesResult)
                && devicesResult.MediaContainer?.Device != null
                && devicesResult.MediaContainer.Device.Count > 0)
            {
                var baseData = new Dictionary<string, object?>()
                {
                    ["Size"] = devicesResult.MediaContainer?.Size,
                    ["Identifier"] = devicesResult.MediaContainer?.Identifier ?? string.Empty,
                    ["MachineIdentifier"] = machine,
                };

                foreach (var device in devicesResult.MediaContainer!.Device)
                {
                    var data = new Dictionary<string, object?>(baseData)
                    {
                        ["Name"] = device.Name ?? string.Empty,
                        ["ClientIdentifier"] = device.ClientIdentifier ?? string.Empty,
                        ["Platform"] = device.Platform ?? string.Empty,
                        ["CreatedAt"] = device.CreatedAt,
                        ["Id"] = device.Id,
                    };

                    results.Add(new LogshipLogEntrySchema("Plex.Server.Devices", timestamp, data));
                }
            }

            return results;
        }
    }
}
