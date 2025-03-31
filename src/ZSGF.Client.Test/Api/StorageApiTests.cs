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
    ///  Class for testing StorageApi
    /// </summary>
    public sealed class StorageApiTests : ApiTestsBase
    {
        private readonly IStorageApi _instance;

        public StorageApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IStorageApi>();
        }

        /// <summary>
        /// Test StorageAggregate
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageAggregateAsyncTest()
        {
            string table = default;
            string appKey = default;
            Client.Option<string> pipeline = default;
            var response = await _instance.StorageAggregateAsync(table, appKey, pipeline);
            var model = response.Ok();
            Assert.IsType<ObjectListApiResponse>(model);
        }

        /// <summary>
        /// Test StorageClear
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageClearAsyncTest()
        {
            string table = default;
            string appKey = default;
            Client.Option<string> filter = default;
            var response = await _instance.StorageClearAsync(table, appKey, filter);
            var model = response.Ok();
            Assert.IsType<Int64ApiResponse>(model);
        }

        /// <summary>
        /// Test StorageDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageDeleteAsyncTest()
        {
            string table = default;
            string id = default;
            string appKey = default;
            var response = await _instance.StorageDeleteAsync(table, id, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test StorageDeleteIndex
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageDeleteIndexAsyncTest()
        {
            string table = default;
            string appKey = default;
            Client.Option<string> indexName = default;
            var response = await _instance.StorageDeleteIndexAsync(table, appKey, indexName);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test StorageDetail
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageDetailAsyncTest()
        {
            string table = default;
            string id = default;
            string appKey = default;
            Client.Option<string> project = default;
            var response = await _instance.StorageDetailAsync(table, id, appKey, project);
            var model = response.Ok();
            Assert.IsType<ObjectApiResponse>(model);
        }

        /// <summary>
        /// Test StorageExecuteFunction
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageExecuteFunctionAsyncTest()
        {
            string nonce = default;
            long timestamp = default;
            string signature = default;
            string appKey = default;
            Client.Option<ExecuteFunctionRequest> executeFunctionRequest = default;
            var response = await _instance.StorageExecuteFunctionAsync(nonce, timestamp, signature, appKey, executeFunctionRequest);
            var model = response.Ok();
            Assert.IsType<ObjectApiResponse>(model);
        }

        /// <summary>
        /// Test StorageExport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageExportAsyncTest()
        {
            string table = default;
            string appKey = default;
            Client.Option<string> filter = default;
            Client.Option<DateTime> startTime = default;
            Client.Option<DateTime> endTime = default;
            var response = await _instance.StorageExportAsync(table, appKey, filter, startTime, endTime);
            var model = response.Ok();
            Assert.IsType<System.IO.Stream>(model);
        }

        /// <summary>
        /// Test StorageImport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageImportAsyncTest()
        {
            string table = default;
            string appKey = default;
            Client.Option<System.IO.Stream> file = default;
            var response = await _instance.StorageImportAsync(table, appKey, file);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test StorageIndexes
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageIndexesAsyncTest()
        {
            string table = default;
            string appKey = default;
            var response = await _instance.StorageIndexesAsync(table, appKey);
            var model = response.Ok();
            Assert.IsType<ObjectListApiResponse>(model);
        }

        /// <summary>
        /// Test StorageList
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageListAsyncTest()
        {
            string table = default;
            string appKey = default;
            Client.Option<string> filter = default;
            Client.Option<string> project = default;
            Client.Option<string> sort = default;
            Client.Option<DateTime> startTime = default;
            Client.Option<DateTime> endTime = default;
            Client.Option<bool> explain = default;
            Client.Option<int> take = default;
            Client.Option<int> skip = default;
            var response = await _instance.StorageListAsync(table, appKey, filter, project, sort, startTime, endTime, explain, take, skip);
            var model = response.Ok();
            Assert.IsType<StorageListResultApiResponse>(model);
        }

        /// <summary>
        /// Test StoragePost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StoragePostAsyncTest()
        {
            string table = default;
            string appKey = default;
            List<Object> requestBody = default;
            var response = await _instance.StoragePostAsync(table, appKey, requestBody);
            var model = response.Ok();
            Assert.IsType<StringApiResponse>(model);
        }

        /// <summary>
        /// Test StoragePostIndex
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StoragePostIndexAsyncTest()
        {
            string table = default;
            string appKey = default;
            Client.Option<PostIndexRequest> postIndexRequest = default;
            var response = await _instance.StoragePostIndexAsync(table, appKey, postIndexRequest);
            var model = response.Ok();
            Assert.IsType<StringApiResponse>(model);
        }

        /// <summary>
        /// Test StoragePut
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StoragePutAsyncTest()
        {
            string table = default;
            string id = default;
            string appKey = default;
            Object body = default;
            Client.Option<bool> replace = default;
            var response = await _instance.StoragePutAsync(table, id, appKey, body, replace);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test StorageRemove
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageRemoveAsyncTest()
        {
            string table = default;
            string appKey = default;
            var response = await _instance.StorageRemoveAsync(table, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test StorageStats
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageStatsAsyncTest()
        {
            string table = default;
            string appKey = default;
            var response = await _instance.StorageStatsAsync(table, appKey);
            var model = response.Ok();
            Assert.IsType<ObjectApiResponse>(model);
        }

        /// <summary>
        /// Test StorageTables
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task StorageTablesAsyncTest()
        {
            string appKey = default;
            var response = await _instance.StorageTablesAsync(appKey);
            var model = response.Ok();
            Assert.IsType<StringListApiResponse>(model);
        }
    }
}
