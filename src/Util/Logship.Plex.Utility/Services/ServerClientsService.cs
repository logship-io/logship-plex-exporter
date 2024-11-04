using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class ServerClientsService : BaseIntervalService
    {
        private readonly IServerApi serverApi;
        
        public ServerClientsService(IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerClientsService> logger) : base(serverApi, exporter, logger)
        {
            this.serverApi = serverApi;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var clients = await this.serverApi.GetAvailableClientsAsync(cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (clients.TryOk(out var clientResult))
            {
                var root = new Dictionary<string, object?>()
                {
                    ["Size"] = clientResult.MediaContainer?.Size,
                    ["MachineIdentifier"] = machine,

                };

                if (clientResult.MediaContainer?.Server != null)
                {
                    foreach (var server in clientResult.MediaContainer.Server!)
                    {
                        var s = new Dictionary<string, object?>(root)
                        {
                            ["Address"] = server.Address ?? string.Empty,
                            ["Name"] = server.Name ?? string.Empty,
                            ["VarVersion"] = server.VarVersion ?? string.Empty,
                            ["DeviceClass"] = server.DeviceClass ?? string.Empty,
                            ["MachineIdentifier"] = server.MachineIdentifier ?? string.Empty,
                            ["Host"] = server.Host ?? string.Empty,
                            ["Port"] = server.Port,
                            ["Product"] = server.Product ?? string.Empty,
                            ["Protocol"] = server.Protocol ?? string.Empty,
                            ["ProtocolCapabilities"] = server.ProtocolCapabilities ?? string.Empty,
                            ["ProtocolVersion"] = server.ProtocolVersion,
                        };

                        results.Add(new LogshipLogEntrySchema("Plex.Server.Clients", timestamp, s));
                    }
                }
            }

            return results;
        }
    }
}
