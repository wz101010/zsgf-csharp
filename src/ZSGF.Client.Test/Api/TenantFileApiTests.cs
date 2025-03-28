/*
 * 全部  API 文档
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
    ///  Class for testing TenantFileApi
    /// </summary>
    public sealed class TenantFileApiTests : ApiTestsBase
    {
        private readonly ITenantFileApi _instance;

        public TenantFileApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ITenantFileApi>();
        }

        /// <summary>
        /// Test TenantFileCreateFolder
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TenantFileCreateFolderAsyncTest()
        {
            Client.Option<string> path = default;
            var response = await _instance.TenantFileCreateFolderAsync(path);
            var model = response.Ok();
            Assert.IsType<JObjectApiResult>(model);
        }

        /// <summary>
        /// Test TenantFileDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TenantFileDeleteAsyncTest()
        {
            Client.Option<string> path = default;
            var response = await _instance.TenantFileDeleteAsync(path);
            var model = response.Ok();
            Assert.IsType<JObjectApiResult>(model);
        }

        /// <summary>
        /// Test TenantFileRename
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TenantFileRenameAsyncTest()
        {
            Client.Option<string> sourceName = default;
            Client.Option<string> destName = default;
            var response = await _instance.TenantFileRenameAsync(sourceName, destName);
            var model = response.Ok();
            Assert.IsType<JObjectApiResult>(model);
        }

        /// <summary>
        /// Test TenantFileUpload
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TenantFileUploadAsyncTest()
        {
            Client.Option<string> path = default;
            Client.Option<System.IO.Stream> file = default;
            var response = await _instance.TenantFileUploadAsync(path, file);
            var model = response.Ok();
            Assert.IsType<JObjectApiResult>(model);
        }

        /// <summary>
        /// Test TenantFiles
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task TenantFilesAsyncTest()
        {
            Client.Option<string> path = default;
            var response = await _instance.TenantFilesAsync(path);
            var model = response.Ok();
            Assert.IsType<JObjectApiResult>(model);
        }
    }
}
