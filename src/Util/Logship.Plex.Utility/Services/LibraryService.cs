using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
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

                                    if (meta.AdditionalProperties != null)
                                    {
                                        foreach (var property in meta.AdditionalProperties)
                                        {
                                            data[property.Key] = property.Value.ToString();
                                        }
                                    }

                                    // Handle TV shows - drill down to get episodes
                                    if (meta.Type == "show")
                                    {
                                        await ProcessTvShowAsync(meta, dir, timestamp, results, cancellationToken);
                                    }

                                    results.Add(new LogshipLogEntrySchema("Plex.Media", timestamp, data));
                                }
                            }
                        }
                    }
                }
            }

            return results;
        }

        private async Task ProcessTvShowAsync(
            Logship.Plex.OpenApi.Model.LibrarySectionsLibraryKeyAllGet200ResponseMediaContainerMetadataInner show,
            Dictionary<string, object?> baseData,
            DateTime timestamp,
            List<LogshipLogEntrySchema> results,
            CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(show.RatingKey))
            {
                return;
            }

            // Now get the seasons
            var seasonsResponse = await this.api.LibraryMetadataMetadataIdChildrenGetAsync(show.RatingKey, cancellationToken);
            if (seasonsResponse.TryOk(out var seasons)
                && seasons.MediaContainer?.Metadata != null)
            {
                foreach (var season in seasons.MediaContainer.Metadata)
                {
                    if (season.Type == "season" && !string.IsNullOrEmpty(season.RatingKey))
                    {
                        // Add season data
                        var seasonData = new Dictionary<string, object?>(baseData)
                        {
                            ["Type"] = "season",
                            ["Summary"] = season.Summary ?? string.Empty,
                            ["Title"] = season.Title ?? string.Empty,
                            ["Duration"] = season.Duration,
                            ["RatingKey"] = season.RatingKey,
                            ["ShowTitle"] = show.Title ?? string.Empty,
                            ["ShowRatingKey"] = show.RatingKey,
                            ["SeasonIndex"] = season.Index,
                        };

                        if (season.AdditionalProperties != null)
                        {
                            foreach (var property in season.AdditionalProperties)
                            {
                                seasonData[property.Key] = property.Value.ToString();
                            }
                        }

                        results.Add(new LogshipLogEntrySchema("Plex.Media", timestamp, seasonData));

                        // Now get the episodes for this season
                        var episodesResponse = await this.api.LibraryMetadataMetadataIdChildrenGetAsync(season.RatingKey, cancellationToken);
                        if (episodesResponse.TryOk(out var episodes)
                            && episodes.MediaContainer?.Metadata != null)
                        {
                            foreach (var episode in episodes.MediaContainer.Metadata)
                            {
                                if (episode.Type == "episode")
                                {
                                    var episodeData = new Dictionary<string, object?>(baseData)
                                    {
                                        ["Type"] = "episode",
                                        ["Summary"] = episode.Summary ?? string.Empty,
                                        ["Title"] = episode.Title ?? string.Empty,
                                        ["Duration"] = episode.Duration,
                                        ["RatingKey"] = episode.RatingKey ?? string.Empty,
                                        ["ShowTitle"] = show.Title ?? string.Empty,
                                        ["ShowRatingKey"] = show.RatingKey,
                                        ["SeasonTitle"] = season.Title ?? string.Empty,
                                        ["SeasonRatingKey"] = season.RatingKey,
                                        ["SeasonIndex"] = season.Index,
                                        ["EpisodeIndex"] = episode.Index,
                                        ["ParentRatingKey"] = episode.ParentRatingKey ?? string.Empty,
                                        ["GrandparentRatingKey"] = episode.GrandparentRatingKey ?? string.Empty,
                                        ["ParentTitle"] = episode.ParentTitle ?? string.Empty,
                                        ["GrandparentTitle"] = episode.GrandparentTitle ?? string.Empty,
                                    };

                                    if (episode.AdditionalProperties != null)
                                    {
                                        foreach (var property in episode.AdditionalProperties)
                                        {
                                            episodeData[property.Key] = property.Value.ToString();
                                        }
                                    }

                                    results.Add(new LogshipLogEntrySchema("Plex.Media", timestamp, episodeData));
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
