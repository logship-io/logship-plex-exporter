using Logship.Plex.OpenApi.Api;
using Logship.Plex.Utility.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Logship.Plex.Utility.Services
{
    internal sealed class GeoDataService : BaseIntervalService
    {
        private readonly IPlexApi api;
        
        public GeoDataService(IPlexApi api, IServerApi serverApi, ILogshipExporter exporter, ILogger<ServerCapabilitiesService> logger) : base(serverApi, exporter, logger)
        {
            this.api = api;
        }

        protected override async Task<IReadOnlyList<LogshipLogEntrySchema>> FetchDataAsync(string machine, CancellationToken cancellationToken)
        {
            var results = new List<LogshipLogEntrySchema>();
            var geoData = await this.api.GetGeoDataAsync(cancellationToken);
            var timestamp = DateTime.UtcNow;
            if (geoData.TryOk(out var result))
            {
                var data = new Dictionary<string, object?>()
                {
                    ["City"] = result.City,
                    ["Code"] = result.Code,
                    ["ContinentCode"] = result.ContinentCode,
                    ["Coordinates"] = result.Coordinates,
                    ["Country"] = result.Country,
                    ["EuropeanUnionMember"] = result.EuropeanUnionMember,
                    ["InPrivacyRestrictedCountry"] = result.InPrivacyRestrictedCountry,
                    ["InPrivacyRestrictedRegion"] = result.InPrivacyRestrictedRegion,
                    ["PostalCode"] = result.PostalCode,
                    ["Subdivisions"] = result.Subdivisions,
                    ["VarTimeZone"] = result.VarTimeZone,
                    ["MachineIdentifier"] = machine,

                };

                results.Add(new LogshipLogEntrySchema("Plex.GeoData", timestamp, data));
            }
            return results;
        }
    }
}
