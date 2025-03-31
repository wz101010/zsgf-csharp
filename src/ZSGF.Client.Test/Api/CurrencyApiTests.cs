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
    ///  Class for testing CurrencyApi
    /// </summary>
    public sealed class CurrencyApiTests : ApiTestsBase
    {
        private readonly ICurrencyApi _instance;

        public CurrencyApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<ICurrencyApi>();
        }

        /// <summary>
        /// Test Currencies
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrenciesAsyncTest()
        {
            string appKey = default;
            var response = await _instance.CurrenciesAsync(appKey);
            var model = response.Ok();
            Assert.IsType<CurrencyListApiResponse>(model);
        }

        /// <summary>
        /// Test Currency
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrencyAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.CurrencyAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<CurrencyApiResponse>(model);
        }

        /// <summary>
        /// Test CurrencyDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrencyDeleteAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.CurrencyDeleteAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test CurrencyExchangeRateDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrencyExchangeRateDeleteAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.CurrencyExchangeRateDeleteAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test CurrencyExchangeRatePut
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrencyExchangeRatePutAsyncTest()
        {
            string code = default;
            string appKey = default;
            Client.Option<ExchangeRatePutRequest> exchangeRatePutRequest = default;
            var response = await _instance.CurrencyExchangeRatePutAsync(code, appKey, exchangeRatePutRequest);
            var model = response.Ok();
            Assert.IsType<Int64ApiResponse>(model);
        }

        /// <summary>
        /// Test CurrencyExchangeRates
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrencyExchangeRatesAsyncTest()
        {
            string code = default;
            string appKey = default;
            var response = await _instance.CurrencyExchangeRatesAsync(code, appKey);
            var model = response.Ok();
            Assert.IsType<CurrencyExchangeRateApiResponse>(model);
        }

        /// <summary>
        /// Test CurrencyPost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrencyPostAsyncTest()
        {
            string appKey = default;
            Client.Option<Currency> currency = default;
            var response = await _instance.CurrencyPostAsync(appKey, currency);
            var model = response.Ok();
            Assert.IsType<Int64ApiResponse>(model);
        }

        /// <summary>
        /// Test CurrencyPut
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrencyPutAsyncTest()
        {
            long id = default;
            string appKey = default;
            Client.Option<Currency> currency = default;
            var response = await _instance.CurrencyPutAsync(id, appKey, currency);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test CurrencyTransactions
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task CurrencyTransactionsAsyncTest()
        {
            string appKey = default;
            Client.Option<long> userId = default;
            Client.Option<string> transType = default;
            Client.Option<string> curCode = default;
            Client.Option<DateTime> startTime = default;
            Client.Option<DateTime> endTime = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            var response = await _instance.CurrencyTransactionsAsync(appKey, userId, transType, curCode, startTime, endTime, skip, take);
            var model = response.Ok();
            Assert.IsType<CurrencyTransactionListApiResponse>(model);
        }
    }
}
