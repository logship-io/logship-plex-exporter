using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class LibraryService : BaseIntervalService
    {
        private readonly ILibraryApi api;
        
        public LibraryService(ILibraryApi api, IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerCapabilitiesService> logger) : base(serverApi, exporter, logger)
        {
            this.api = api;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var stats = await this.api.LibrarySectionsGetAsync(cancellationToken: cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (stats.TryOk(out var result))
            {
                var root = new Dictionary<string, object?>()
                {
                    ["MachineIdentifier"] = machine,
                };

                if (result.MediaContainer!.Directory != null
                    && result.MediaContainer.Directory.Count > 0)
                {
                    foreach (var directory in result.MediaContainer.Directory)
                    {
                        var dir = new Dictionary<string, object?>(root)
                        {
                            ["Library"] = directory.Title ?? string.Empty,
                            ["LibraryAgent"] = directory.Agent ?? string.Empty,
                            ["LibraryScanner"] = directory.Scanner ?? string.Empty,
                            ["LibraryType"] = directory.Type ?? string.Empty,
                            ["LibraryKey"] = directory.Key ?? string.Empty,
                        };

                        if (false == string.IsNullOrEmpty(directory.Key))
                        {
                            var library = await this.api.LibrarySectionsLibraryKeyAllGetAsync(directory.Key, cancellationToken);
                            if (library.TryOk(out var lib)
                                && lib.MediaContainer?.Metadata != null)
                            {
                                foreach (var meta in lib.MediaContainer.Metadata)
                                {
                                    var data = new Dictionary<string, object?>(dir)
                                    {
                                        ["Type"] = meta.Type ?? string.Empty,
                                        ["Summary"] = meta.Summary ?? string.Empty,
                                        ["Title"] = meta.Title ?? string.Empty,
                                        ["Duration"] = meta.Duration,
                                        ["RatingKey"] = meta.RatingKey ?? string.Empty,
                                    };
                                    results.Add(new LogshipLogEntrySchema("Plex.Media", timestamp, data));
                                }
                            }
                        }
                    }
                }
            }

            return results;
        }
    }
}
