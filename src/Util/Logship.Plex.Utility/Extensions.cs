using Logship.Plex.Utility.Internal;
using Logship.Plex.Utility.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace Logship.Plex.Utility
{
    public static class Extensions
    {
        [UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "<Pending>")]
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
                .AddHostedService<ServerAccountsService>()
                .AddHostedService<ServerCapabilitiesService>()
                .AddHostedService<ServerClientsService>()
                .AddHostedService<ServerDeviceService>()
                .AddHostedService<ServerIdentityService>()
                .AddHostedService<SessionsService>()
                .AddHostedService<StatisticsService>();
        }
    }
}
