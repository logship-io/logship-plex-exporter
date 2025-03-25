using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class ServerAccountsService : BaseIntervalService
    {
        private readonly IServerApi serverApi;

        protected override TimeSpan Interval => TimeSpan.FromMinutes(15);

        public ServerAccountsService(IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerAccountsService> logger) : base(serverApi, exporter, logger)
        {
            this.serverApi = serverApi;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var capabilities = await this.serverApi.GetServerAccountsAsync(cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (capabilities.TryOk(out var result) && result.MediaContainer?.Account != null)
            {
                foreach (var account in result.MediaContainer.Account)
                {
                    var data = new Dictionary<string, object?>()
                    {
                        ["Name"] = account.Name,
                        ["Key"] = account.Key,
                        ["SubtitleMode"] = account.SubtitleMode,
                        ["AutoSelectAudio"] = account.AutoSelectAudio,
                        ["DefaultAudioLanguage"] = account.DefaultAudioLanguage,
                        ["Thumb"] = account.Thumb,
                    };

                    results.Add(new LogshipLogEntrySchema("Plex.Server.Accounts", timestamp, data));
                }
            }
            return results;
        }
    }
}
