using Logship.Plex.Exporter.ConsoleHost.Internal;
using Logship.Plex.OpenApi;
using Logship.Plex.OpenApi.Client;
using Logship.Plex.OpenApi.Extensions;
using Logship.Plex.Utility;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net;

namespace Logship.Plex.Exporter.ConsoleHost
{
    internal sealed class Program
    {
        static async Task<int> Main(string[] args)
        {
            using var cts = new CancellationTokenSource();
            var builder = Host.CreateEmptyApplicationBuilder(new HostApplicationBuilderSettings()
            {
                ApplicationName = "Logship.Plex.Exporter",
                Args = args,
                DisableDefaults = true,
            });

            var config = builder.Configuration
                .AddCommandLine(args)
                .AddEnvironmentVariables()
                .AddJsonFile("appsettings.json")
                .Build();

            builder.Logging.AddConsole();

            var host = config.GetValue<string>("plexHost")!.TrimEnd('/');
            var token = config.GetValue<string>("plexToken")!;

            builder.Services
                .AddHttpClient()
                .AddPlexServices(config)
                .AddApi(_ =>
                {
                    _.AddApiHttpClients(client =>
                    {
                        client.BaseAddress = new Uri(host, UriKind.Absolute);
                    });
                    _.AddTokens(new ApiKeyToken(token!, ClientUtils.ApiKeyHeader.X_Plex_Token, prefix: string.Empty));
                    _.UseProvider<RateLimitProvider<ApiKeyToken>, ApiKeyToken>();
                });

            using var app = builder.Build();
            var logger = app.Services.GetRequiredService<ILogger<Program>>();
            try
            {
                await app.RunAsync();

            }
            catch (OperationCanceledException) when (cts.IsCancellationRequested)
            {
                // noop
            }
            catch (Exception ex)
            {
                Log.UncaughtException(logger, ex);
                return 1;
            }

            return 0;
        }
    }
}
