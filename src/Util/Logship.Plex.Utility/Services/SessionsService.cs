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
                            { "AddedAt", metadata.AddedAt ?? default(int) },
                            { "Art", metadata.Art ?? string.Empty },
                            { "AudienceRating", metadata.AudienceRating },
                            { "AudienceRatingImage", metadata.AudienceRatingImage ?? string.Empty },
                            { "ChapterSource", metadata.ChapterSource ?? string.Empty },
                            { "ContentRating", metadata.ContentRating ?? string.Empty },
                            { "Duration", metadata.Duration ?? default(int) },
                            { "Guid", metadata.Guid ?? string.Empty },
                            { "Key", metadata.Key ?? string.Empty },
                            { "LibrarySectionID", metadata.LibrarySectionID ?? string.Empty },
                            { "LibrarySectionTitle", metadata.LibrarySectionTitle ?? string.Empty },
                            { "OriginallyAvailableAt", metadata.OriginallyAvailableAt },
                            { "RatingKey", metadata.RatingKey ?? string.Empty },
                            { "SessionKey", metadata.SessionKey ?? string.Empty },
                            { "Summary", metadata.Summary ?? string.Empty },
                            { "Title", metadata.Title ?? string.Empty },
                            { "Type", metadata.Type ?? string.Empty },
                            { "UpdatedAt", metadata.UpdatedAt ?? default(int) },
                            { "ViewOffset", metadata.ViewOffset ?? default(int) },
                            { "Year", metadata.Year ?? default(int) }
                        };

                        results.Add(new LogshipLogEntrySchema("Plex.Sessions.Video", timestamp, data));
                    }

                }
            }

            return results;
        }
    }
}
