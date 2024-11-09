using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class SessionsService : BaseIntervalService
    {
        private readonly ISessionsApi api;
        
        public SessionsService(ISessionsApi api, IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerCapabilitiesService> logger) : base(serverApi, exporter, logger)
        {
            this.api = api;
        }

        protected override TimeSpan Interval => TimeSpan.FromSeconds(15);

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var sessions = await this.api.GetSessionsAsync(cancellationToken: cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (sessions.TryOk(out var result))
            {
                var root = new Dictionary<string, object?>()
                {
                    ["MachineIdentifier"] = machine,
                };

                if (result.MediaContainer?.Metadata != null)
                {
                    foreach (var metadata in result.MediaContainer.Metadata)
                    {
                        var data = new Dictionary<string, object?>(root)
                        {
                            { "AddedAt", metadata.AddedAt },
                            { "Art", metadata.Art },
                            { "AudienceRating", metadata.AudienceRating },
                            { "AudienceRatingImage", metadata.AudienceRatingImage },
                            { "ChapterSource", metadata.ChapterSource },
                            { "ContentRating", metadata.ContentRating },
                            { "Duration", metadata.Duration },
                            { "Guid", metadata.Guid },
                            { "Key", metadata.Key },
                            { "LibrarySectionID", metadata.LibrarySectionID },
                            { "LibrarySectionTitle", metadata.LibrarySectionTitle },
                            { "OriginallyAvailableAt", metadata.OriginallyAvailableAt },
                            { "RatingKey", metadata.RatingKey },
                            { "SessionKey", metadata.SessionKey },
                            { "Summary", metadata.Summary },
                            { "Title", metadata.Title },
                            { "Type", metadata.Type },
                            { "UpdatedAt", metadata.UpdatedAt },
                            { "ViewOffset", metadata.ViewOffset },
                            { "Year", metadata.Year },
                            { "PlayerAddress", metadata.Player?.Address },
                            { "PlayerDevice", metadata.Player?.Device },
                            { "PlayerLocal", metadata.Player?.Local },
                            { "PlayerModel", metadata.Player?.Model },
                            { "PlayerPlatform", metadata.Player?.Platform },
                            { "PlayerProduct", metadata.Player?.Product },
                            { "PlayerRelayed", metadata.Player?.Relayed },
                            { "PlayerRemotePublicAddress", metadata.Player?.RemotePublicAddress },
                            { "PlayerSecure", metadata.Player?.Secure },
                            { "PlayerState", metadata.Player?.State },
                            { "PlayerTitle", metadata.Player?.Title },
                            { "PlayerUserId", metadata.Player?.UserID },
                            { "PlayerVendor", metadata.Player?.Vendor },
                            { "PlayerVarVersion", metadata.Player?.VarVersion },
                            { "SessionId", metadata.Session?.Id },
                            { "SessionLocation", metadata.Session?.Location },
                            { "SessionBandwidth", metadata.Session?.Bandwidth },
                        };

                        results.Add(new LogshipLogEntrySchema("Plex.Sessions.Video", timestamp, data));
                    }

                }
            }

            return results;
        }
    }
}
