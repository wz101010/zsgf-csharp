/*
 * 用户全部 API 文档
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using ZSGF.Client.Api;
using ZSGF.Client.Model;


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


namespace ZSGF.Client.Test.Api
{
    /// <summary>
    ///  Class for testing OAuthApi
    /// </summary>
    public sealed class OAuthApiTests : ApiTestsBase
    {
        private readonly IOAuthApi _instance;

        public OAuthApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IOAuthApi>();
        }

        /// <summary>
        /// Test OAuthAuthorize
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task OAuthAuthorizeAsyncTest()
        {
            string appKey = default;
            Client.Option<string> scheme = default;
            Client.Option<string> code = default;
            var response = await _instance.OAuthAuthorizeAsync(appKey, scheme, code);
            var model = response.Ok();
            Assert.IsType<AuthorizeResultApiResponse>(model);
        }

        /// <summary>
        /// Test OAuthConsents
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task OAuthConsentsAsyncTest()
        {
            string appKey = default;
            var response = await _instance.OAuthConsentsAsync(appKey);
            var model = response.Ok();
            Assert.IsType<AppUserConsentModelListApiResponse>(model);
        }

        /// <summary>
        /// Test OAuthDeleteConsent
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task OAuthDeleteConsentAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.OAuthDeleteConsentAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test OAuthGrantCode
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task OAuthGrantCodeAsyncTest()
        {
            string appKey = default;
            Client.Option<string> scheme = default;
            Client.Option<GrantRequest> grantRequest = default;
            var response = await _instance.OAuthGrantCodeAsync(appKey, scheme, grantRequest);
            var model = response.Ok();
            Assert.IsType<GrantResultApiResponse>(model);
        }

        /// <summary>
        /// Test OAuthProfile
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task OAuthProfileAsyncTest()
        {
            string appKey = default;
            var response = await _instance.OAuthProfileAsync(appKey);
            var model = response.Ok();
            Assert.IsType<ProfileResultApiResponse>(model);
        }
    }
}
