/*
 * Plex Media Server API
 *
 * This is an unofficial OpenAPI specification for the Plex Media Server API. 
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using Logship.Plex.OpenApi.Api;
using Logship.Plex.OpenApi.Model;


/* *********************************************************************************
*              Follow these manual steps to construct tests.
*              This file will not be overwritten.
*  *********************************************************************************
* 1. Navigate to ApiTests.Base.cs and ensure any tokens are being created correctly.
*    Take care not to commit credentials to any repository.
*
* 2. Mocking is coordinated by ApiTestsBase#AddApiHttpClients.
*    To mock the client, use the generic AddApiHttpClients.
*    To mock the server, change the client's BaseAddress.
*
* 3. Locate the test you want below
*      - remove the skip property from the Fact attribute
*      - set the value of any variables if necessary
*
* 4. Run the tests and ensure they work.
*
*/


namespace Logship.Plex.OpenApi.Test.Api
{
    /// <summary>
    ///  Class for testing PlexApi
    /// </summary>
    public sealed class PlexApiTests : ApiTestsBase
    {
        private readonly IPlexApi _instance;

        public PlexApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IPlexApi>();
        }

        /// <summary>
        /// Test GetGeoData
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task GetGeoDataAsyncTest()
        {
            var response = await _instance.GetGeoDataAsync();
            var model = response.Ok();
            Assert.IsType<GeoData>(model);
        }
    }
}
