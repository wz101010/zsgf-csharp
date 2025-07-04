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
    ///  Class for testing ExternalAccountApi
    /// </summary>
    public sealed class ExternalAccountApiTests : ApiTestsBase
    {
        private readonly IExternalAccountApi _instance;

        public ExternalAccountApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IExternalAccountApi>();
        }

        /// <summary>
        /// Test ExternalAccountSignIn
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task ExternalAccountSignInAsyncTest()
        {
            string appKey = default;
            Client.Option<ExternalAccountSignInRequest> externalAccountSignInRequest = default;
            var response = await _instance.ExternalAccountSignInAsync(appKey, externalAccountSignInRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserExternalAccountBind
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserExternalAccountBindAsyncTest()
        {
            string appKey = default;
            Client.Option<ExternalAccountBindRequest> externalAccountBindRequest = default;
            var response = await _instance.UserExternalAccountBindAsync(appKey, externalAccountBindRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserOAuthAccounts
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserOAuthAccountsAsyncTest()
        {
            string appKey = default;
            var response = await _instance.UserOAuthAccountsAsync(appKey);
            var model = response.Ok();
            Assert.IsType<UserLoginsListApiResponse>(model);
        }

        /// <summary>
        /// Test UserOAuthAccountsPutBind
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserOAuthAccountsPutBindAsyncTest()
        {
            long id = default;
            string appKey = default;
            Client.Option<ExternalAccountPutRequest> externalAccountPutRequest = default;
            var response = await _instance.UserOAuthAccountsPutBindAsync(id, appKey, externalAccountPutRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserOAuthAccountsUnBind
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserOAuthAccountsUnBindAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.UserOAuthAccountsUnBindAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }
    }
}
