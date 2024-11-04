using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class ServerIdentityService : BaseIntervalService
    {
        private readonly IServerApi serverApi;
        
        public ServerIdentityService(IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerIdentityService> logger) : base(serverApi, exporter, logger)
        {
            this.serverApi = serverApi;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string _machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var identity = await this.serverApi.GetServerIdentityAsync(cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (identity.TryOk(out var identityResult))
            {
                var data = new Dictionary<string, object?>()
                {
                    ["MachineIdentifier"] = identityResult.MediaContainer?.MachineIdentifier ?? string.Empty,
                    ["Size"] = identityResult.MediaContainer?.Size,
                    ["Claimed"] = identityResult.MediaContainer?.Claimed ?? false,
                    ["VarVersion"] = identityResult.MediaContainer?.VarVersion ?? string.Empty,
                };

                results.Add(new LogshipLogEntrySchema("Plex.Server.Identity", timestamp, data));
            }

            return results;
        }
    }
}
