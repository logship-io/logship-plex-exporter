/*
 * Plex API
 *
 * Plex OpenAPI Spec 
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Model;

namespace Logship.Plex.OpenApi.Client
{
    /// <summary>
    /// Provides hosting configuration for Logship.Plex.OpenApi
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());
            _jsonOptions.Converters.Add(new DateOnlyNullableJsonConverter());
            _jsonOptions.Converters.Add(new GeoDataJsonConverter());
            _jsonOptions.Converters.Add(new GetAvailableClients200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAvailableClients200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetAvailableClients200ResponseMediaContainerServerInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetBandwidthStatistics200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetBandwidthStatistics200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetBandwidthStatistics200ResponseMediaContainerStatisticsBandwidthInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetButlerTasks200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetButlerTasks200ResponseButlerTasksJsonConverter());
            _jsonOptions.Converters.Add(new GetButlerTasks200ResponseButlerTasksButlerTaskInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetDevices200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetDevices200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetDevices200ResponseMediaContainerDeviceInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetResourcesStatistics200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetResourcesStatistics200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetResourcesStatistics200ResponseMediaContainerStatisticsResourcesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetServerActivities200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetServerActivities200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetServerActivities200ResponseMediaContainerActivityInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetServerActivities200ResponseMediaContainerActivityInnerContextJsonConverter());
            _jsonOptions.Converters.Add(new GetServerCapabilities200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetServerCapabilities200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetServerCapabilities200ResponseMediaContainerDirectoryInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetServerCapabilities400ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetServerCapabilities400ResponseErrorsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetServerCapabilities401ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetServerCapabilities401ResponseErrorsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetServerIdentity200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetServerIdentity200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetServerIdentity408ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetSessionHistory200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetSessionHistory200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessionHistory200ResponseMediaContainerMetadataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerDirectorInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerFieldInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerGenreInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerMediaInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerStreamInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerPlayerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerProducerInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerRatingInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerRoleInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerSessionJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerUltraBlurColorsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerUserJsonConverter());
            _jsonOptions.Converters.Add(new GetSessions200ResponseMediaContainerMetadataInnerWriterInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetStatistics200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetStatistics200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetStatistics200ResponseMediaContainerAccountInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetStatistics200ResponseMediaContainerDeviceInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetStatistics200ResponseMediaContainerStatisticsMediaInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetTranscodeSessions200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetTranscodeSessions200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new GetTranscodeSessions200ResponseMediaContainerTranscodeSessionInnerJsonConverter());
            _jsonOptions.Converters.Add(new LibrarySectionsGet200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new LibrarySectionsGet200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new LibrarySectionsGet200ResponseMediaContainerDirectoryInnerJsonConverter());
            _jsonOptions.Converters.Add(new LibrarySectionsLibraryKeyAllGet200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new LibrarySectionsLibraryKeyAllGet200ResponseMediaContainerJsonConverter());
            _jsonOptions.Converters.Add(new LibrarySectionsLibraryKeyAllGet200ResponseMediaContainerMetadataInnerJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);

            _jsonOptions.TypeInfoResolver = System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
                new GeoDataSerializationContext(),
                new GetAvailableClients200ResponseSerializationContext(),
                new GetAvailableClients200ResponseMediaContainerSerializationContext(),
                new GetAvailableClients200ResponseMediaContainerServerInnerSerializationContext(),
                new GetBandwidthStatistics200ResponseSerializationContext(),
                new GetBandwidthStatistics200ResponseMediaContainerSerializationContext(),
                new GetBandwidthStatistics200ResponseMediaContainerStatisticsBandwidthInnerSerializationContext(),
                new GetButlerTasks200ResponseSerializationContext(),
                new GetButlerTasks200ResponseButlerTasksSerializationContext(),
                new GetButlerTasks200ResponseButlerTasksButlerTaskInnerSerializationContext(),
                new GetDevices200ResponseSerializationContext(),
                new GetDevices200ResponseMediaContainerSerializationContext(),
                new GetDevices200ResponseMediaContainerDeviceInnerSerializationContext(),
                new GetResourcesStatistics200ResponseSerializationContext(),
                new GetResourcesStatistics200ResponseMediaContainerSerializationContext(),
                new GetResourcesStatistics200ResponseMediaContainerStatisticsResourcesInnerSerializationContext(),
                new GetServerActivities200ResponseSerializationContext(),
                new GetServerActivities200ResponseMediaContainerSerializationContext(),
                new GetServerActivities200ResponseMediaContainerActivityInnerSerializationContext(),
                new GetServerActivities200ResponseMediaContainerActivityInnerContextSerializationContext(),
                new GetServerCapabilities200ResponseSerializationContext(),
                new GetServerCapabilities200ResponseMediaContainerSerializationContext(),
                new GetServerCapabilities200ResponseMediaContainerDirectoryInnerSerializationContext(),
                new GetServerCapabilities400ResponseSerializationContext(),
                new GetServerCapabilities400ResponseErrorsInnerSerializationContext(),
                new GetServerCapabilities401ResponseSerializationContext(),
                new GetServerCapabilities401ResponseErrorsInnerSerializationContext(),
                new GetServerIdentity200ResponseSerializationContext(),
                new GetServerIdentity200ResponseMediaContainerSerializationContext(),
                new GetServerIdentity408ResponseSerializationContext(),
                new GetSessionHistory200ResponseSerializationContext(),
                new GetSessionHistory200ResponseMediaContainerSerializationContext(),
                new GetSessionHistory200ResponseMediaContainerMetadataInnerSerializationContext(),
                new GetSessions200ResponseSerializationContext(),
                new GetSessions200ResponseMediaContainerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerDirectorInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerFieldInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerGenreInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerMediaInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerMediaInnerPartInnerStreamInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerPlayerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerProducerInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerRatingInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerRoleInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerSessionSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerUltraBlurColorsInnerSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerUserSerializationContext(),
                new GetSessions200ResponseMediaContainerMetadataInnerWriterInnerSerializationContext(),
                new GetStatistics200ResponseSerializationContext(),
                new GetStatistics200ResponseMediaContainerSerializationContext(),
                new GetStatistics200ResponseMediaContainerAccountInnerSerializationContext(),
                new GetStatistics200ResponseMediaContainerDeviceInnerSerializationContext(),
                new GetStatistics200ResponseMediaContainerStatisticsMediaInnerSerializationContext(),
                new GetTranscodeSessions200ResponseSerializationContext(),
                new GetTranscodeSessions200ResponseMediaContainerSerializationContext(),
                new GetTranscodeSessions200ResponseMediaContainerTranscodeSessionInnerSerializationContext(),
                new LibrarySectionsGet200ResponseSerializationContext(),
                new LibrarySectionsGet200ResponseMediaContainerSerializationContext(),
                new LibrarySectionsGet200ResponseMediaContainerDirectoryInnerSerializationContext(),
                new LibrarySectionsLibraryKeyAllGet200ResponseSerializationContext(),
                new LibrarySectionsLibraryKeyAllGet200ResponseMediaContainerSerializationContext(),
                new LibrarySectionsLibraryKeyAllGet200ResponseMediaContainerMetadataInnerSerializationContext(),
                new System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver()
            );

            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<ActivitiesApiEvents>();
            _services.AddTransient<IActivitiesApi, ActivitiesApi>();
            _services.AddSingleton<ButlerApiEvents>();
            _services.AddTransient<IButlerApi, ButlerApi>();
            _services.AddSingleton<LibraryApiEvents>();
            _services.AddTransient<ILibraryApi, LibraryApi>();
            _services.AddSingleton<PlexApiEvents>();
            _services.AddTransient<IPlexApi, PlexApi>();
            _services.AddSingleton<ServerApiEvents>();
            _services.AddTransient<IServerApi, ServerApi>();
            _services.AddSingleton<SessionsApiEvents>();
            _services.AddTransient<ISessionsApi, SessionsApi>();
            _services.AddSingleton<StatisticsApiEvents>();
            _services.AddTransient<IStatisticsApi, StatisticsApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients
        (
            Action<HttpClient>? client = null, Action<IHttpClientBuilder>? builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IActivitiesApi, ActivitiesApi>(client));
            builders.Add(_services.AddHttpClient<IButlerApi, ButlerApi>(client));
            builders.Add(_services.AddHttpClient<ILibraryApi, LibraryApi>(client));
            builders.Add(_services.AddHttpClient<IPlexApi, PlexApi>(client));
            builders.Add(_services.AddHttpClient<IServerApi, ServerApi>(client));
            builders.Add(_services.AddHttpClient<ISessionsApi, SessionsApi>(client));
            builders.Add(_services.AddHttpClient<IStatisticsApi, StatisticsApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}