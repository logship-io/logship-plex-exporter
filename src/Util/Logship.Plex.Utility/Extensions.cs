using Logship.Plex.Utility.Internal;
using Logship.Plex.Utility.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Logship.Plex.Utility
{
    public static class Extensions
    {
        public static IServiceCollection AddPlexServices(this IServiceCollection services, IConfiguration config)
        {
            var endpoint = config.GetValue<string>("logshipEndpoint")!.TrimEnd('/');
            var account = config.GetValue<Guid>("logshipAccount")!;
            var bearerToken = config.GetValue<string>("logshipBearerToken")!;
            return services
                .AddSingleton<ILogshipExporter, LogshipExporter>(_ =>
                {
                    return new LogshipExporter(_.GetRequiredService<IHttpClientFactory>(), endpoint, account, bearerToken);
                })
                .AddHostedService<BandwidthStatisticsService>()
                .AddHostedService<GeoDataService>()
                .AddHostedService<LibraryService>()
                .AddHostedService<ResourceStatisticsService>()
                .AddHostedService<ServerCapabilitiesService>()
                .AddHostedService<ServerClientsService>()
                .AddHostedService<ServerDeviceService>()
                .AddHostedService<ServerIdentityService>()
                .AddHostedService<SessionsService>()
                .AddHostedService<StatisticsService>();
        }
    }
}
