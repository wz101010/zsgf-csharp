/*
 * 全部  API 文档
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Security.Cryptography;
using ZSGF.Client.Client;
using ZSGF.Client.Api;
using ZSGF.Client.Extensions;
using Xunit;

namespace ZSGF.Client.Test.Api
{
    /// <summary>
    ///  Tests the dependency injection.
    /// </summary>
    public class DependencyInjectionTest
    {
        private readonly IHost _hostUsingConfigureWithoutAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureApi((context, services, options) =>
            {
                BearerToken bearerToken1 = new BearerToken("<token>", timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(bearerToken1);
            })
            .Build();

        private readonly IHost _hostUsingConfigureWithAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureApi((context, services, options) =>
            {
                BearerToken bearerToken1 = new BearerToken("<token>", timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(bearerToken1);
                options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
            })
            .Build();

        private readonly IHost _hostUsingAddWithoutAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    BearerToken bearerToken1 = new BearerToken("<token>", timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(bearerToken1);
                });
            })
            .Build();

        private readonly IHost _hostUsingAddWithAClient =
            Host.CreateDefaultBuilder(Array.Empty<string>()).ConfigureServices((host, services) =>
            {
                services.AddApi(options =>
                {
                    BearerToken bearerToken1 = new BearerToken("<token>", timeout: TimeSpan.FromSeconds(1));
                    options.AddTokens(bearerToken1);
                    options.AddApiHttpClients(client => client.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS));
                });
            })
            .Build();

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithAClientTest()
        {
            var accessTokenApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IAccessTokenApi>();
            Assert.True(accessTokenApi.HttpClient.BaseAddress != null);

            var alipayApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IAlipayApi>();
            Assert.True(alipayApi.HttpClient.BaseAddress != null);

            var appApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IAppApi>();
            Assert.True(appApi.HttpClient.BaseAddress != null);

            var appSettingApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IAppSettingApi>();
            Assert.True(appSettingApi.HttpClient.BaseAddress != null);

            var authorizePolicyApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IAuthorizePolicyApi>();
            Assert.True(authorizePolicyApi.HttpClient.BaseAddress != null);

            var currencyApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ICurrencyApi>();
            Assert.True(currencyApi.HttpClient.BaseAddress != null);

            var dingTalkApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IDingTalkApi>();
            Assert.True(dingTalkApi.HttpClient.BaseAddress != null);

            var fileApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IFileApi>();
            Assert.True(fileApi.HttpClient.BaseAddress != null);

            var oAuthApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IOAuthApi>();
            Assert.True(oAuthApi.HttpClient.BaseAddress != null);

            var orderApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IOrderApi>();
            Assert.True(orderApi.HttpClient.BaseAddress != null);

            var projectApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IProjectApi>();
            Assert.True(projectApi.HttpClient.BaseAddress != null);

            var serviceSettingApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IServiceSettingApi>();
            Assert.True(serviceSettingApi.HttpClient.BaseAddress != null);

            var storageApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IStorageApi>();
            Assert.True(storageApi.HttpClient.BaseAddress != null);

            var systemFileApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ISystemFileApi>();
            Assert.True(systemFileApi.HttpClient.BaseAddress != null);

            var teamApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<ITeamApi>();
            Assert.True(teamApi.HttpClient.BaseAddress != null);

            var userApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IUserApi>();
            Assert.True(userApi.HttpClient.BaseAddress != null);

            var userCurrencyApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IUserCurrencyApi>();
            Assert.True(userCurrencyApi.HttpClient.BaseAddress != null);

            var userSettingApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IUserSettingApi>();
            Assert.True(userSettingApi.HttpClient.BaseAddress != null);

            var wechatApi = _hostUsingConfigureWithAClient.Services.GetRequiredService<IWechatApi>();
            Assert.True(wechatApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the configure method
        /// </summary>
        [Fact]
        public void ConfigureApiWithoutAClientTest()
        {
            var accessTokenApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IAccessTokenApi>();
            Assert.True(accessTokenApi.HttpClient.BaseAddress != null);

            var alipayApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IAlipayApi>();
            Assert.True(alipayApi.HttpClient.BaseAddress != null);

            var appApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IAppApi>();
            Assert.True(appApi.HttpClient.BaseAddress != null);

            var appSettingApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IAppSettingApi>();
            Assert.True(appSettingApi.HttpClient.BaseAddress != null);

            var authorizePolicyApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IAuthorizePolicyApi>();
            Assert.True(authorizePolicyApi.HttpClient.BaseAddress != null);

            var currencyApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ICurrencyApi>();
            Assert.True(currencyApi.HttpClient.BaseAddress != null);

            var dingTalkApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IDingTalkApi>();
            Assert.True(dingTalkApi.HttpClient.BaseAddress != null);

            var fileApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IFileApi>();
            Assert.True(fileApi.HttpClient.BaseAddress != null);

            var oAuthApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IOAuthApi>();
            Assert.True(oAuthApi.HttpClient.BaseAddress != null);

            var orderApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IOrderApi>();
            Assert.True(orderApi.HttpClient.BaseAddress != null);

            var projectApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IProjectApi>();
            Assert.True(projectApi.HttpClient.BaseAddress != null);

            var serviceSettingApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IServiceSettingApi>();
            Assert.True(serviceSettingApi.HttpClient.BaseAddress != null);

            var storageApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IStorageApi>();
            Assert.True(storageApi.HttpClient.BaseAddress != null);

            var systemFileApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ISystemFileApi>();
            Assert.True(systemFileApi.HttpClient.BaseAddress != null);

            var teamApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<ITeamApi>();
            Assert.True(teamApi.HttpClient.BaseAddress != null);

            var userApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IUserApi>();
            Assert.True(userApi.HttpClient.BaseAddress != null);

            var userCurrencyApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IUserCurrencyApi>();
            Assert.True(userCurrencyApi.HttpClient.BaseAddress != null);

            var userSettingApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IUserSettingApi>();
            Assert.True(userSettingApi.HttpClient.BaseAddress != null);

            var wechatApi = _hostUsingConfigureWithoutAClient.Services.GetRequiredService<IWechatApi>();
            Assert.True(wechatApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithAClientTest()
        {
            var accessTokenApi = _hostUsingAddWithAClient.Services.GetRequiredService<IAccessTokenApi>();
            Assert.True(accessTokenApi.HttpClient.BaseAddress != null);
            
            var alipayApi = _hostUsingAddWithAClient.Services.GetRequiredService<IAlipayApi>();
            Assert.True(alipayApi.HttpClient.BaseAddress != null);
            
            var appApi = _hostUsingAddWithAClient.Services.GetRequiredService<IAppApi>();
            Assert.True(appApi.HttpClient.BaseAddress != null);
            
            var appSettingApi = _hostUsingAddWithAClient.Services.GetRequiredService<IAppSettingApi>();
            Assert.True(appSettingApi.HttpClient.BaseAddress != null);
            
            var authorizePolicyApi = _hostUsingAddWithAClient.Services.GetRequiredService<IAuthorizePolicyApi>();
            Assert.True(authorizePolicyApi.HttpClient.BaseAddress != null);
            
            var currencyApi = _hostUsingAddWithAClient.Services.GetRequiredService<ICurrencyApi>();
            Assert.True(currencyApi.HttpClient.BaseAddress != null);
            
            var dingTalkApi = _hostUsingAddWithAClient.Services.GetRequiredService<IDingTalkApi>();
            Assert.True(dingTalkApi.HttpClient.BaseAddress != null);
            
            var fileApi = _hostUsingAddWithAClient.Services.GetRequiredService<IFileApi>();
            Assert.True(fileApi.HttpClient.BaseAddress != null);
            
            var oAuthApi = _hostUsingAddWithAClient.Services.GetRequiredService<IOAuthApi>();
            Assert.True(oAuthApi.HttpClient.BaseAddress != null);
            
            var orderApi = _hostUsingAddWithAClient.Services.GetRequiredService<IOrderApi>();
            Assert.True(orderApi.HttpClient.BaseAddress != null);
            
            var projectApi = _hostUsingAddWithAClient.Services.GetRequiredService<IProjectApi>();
            Assert.True(projectApi.HttpClient.BaseAddress != null);
            
            var serviceSettingApi = _hostUsingAddWithAClient.Services.GetRequiredService<IServiceSettingApi>();
            Assert.True(serviceSettingApi.HttpClient.BaseAddress != null);
            
            var storageApi = _hostUsingAddWithAClient.Services.GetRequiredService<IStorageApi>();
            Assert.True(storageApi.HttpClient.BaseAddress != null);
            
            var systemFileApi = _hostUsingAddWithAClient.Services.GetRequiredService<ISystemFileApi>();
            Assert.True(systemFileApi.HttpClient.BaseAddress != null);
            
            var teamApi = _hostUsingAddWithAClient.Services.GetRequiredService<ITeamApi>();
            Assert.True(teamApi.HttpClient.BaseAddress != null);
            
            var userApi = _hostUsingAddWithAClient.Services.GetRequiredService<IUserApi>();
            Assert.True(userApi.HttpClient.BaseAddress != null);
            
            var userCurrencyApi = _hostUsingAddWithAClient.Services.GetRequiredService<IUserCurrencyApi>();
            Assert.True(userCurrencyApi.HttpClient.BaseAddress != null);
            
            var userSettingApi = _hostUsingAddWithAClient.Services.GetRequiredService<IUserSettingApi>();
            Assert.True(userSettingApi.HttpClient.BaseAddress != null);
            
            var wechatApi = _hostUsingAddWithAClient.Services.GetRequiredService<IWechatApi>();
            Assert.True(wechatApi.HttpClient.BaseAddress != null);
        }

        /// <summary>
        /// Test dependency injection when using the add method
        /// </summary>
        [Fact]
        public void AddApiWithoutAClientTest()
        {
            var accessTokenApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IAccessTokenApi>();
            Assert.True(accessTokenApi.HttpClient.BaseAddress != null);

            var alipayApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IAlipayApi>();
            Assert.True(alipayApi.HttpClient.BaseAddress != null);

            var appApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IAppApi>();
            Assert.True(appApi.HttpClient.BaseAddress != null);

            var appSettingApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IAppSettingApi>();
            Assert.True(appSettingApi.HttpClient.BaseAddress != null);

            var authorizePolicyApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IAuthorizePolicyApi>();
            Assert.True(authorizePolicyApi.HttpClient.BaseAddress != null);

            var currencyApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ICurrencyApi>();
            Assert.True(currencyApi.HttpClient.BaseAddress != null);

            var dingTalkApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IDingTalkApi>();
            Assert.True(dingTalkApi.HttpClient.BaseAddress != null);

            var fileApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IFileApi>();
            Assert.True(fileApi.HttpClient.BaseAddress != null);

            var oAuthApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IOAuthApi>();
            Assert.True(oAuthApi.HttpClient.BaseAddress != null);

            var orderApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IOrderApi>();
            Assert.True(orderApi.HttpClient.BaseAddress != null);

            var projectApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IProjectApi>();
            Assert.True(projectApi.HttpClient.BaseAddress != null);

            var serviceSettingApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IServiceSettingApi>();
            Assert.True(serviceSettingApi.HttpClient.BaseAddress != null);

            var storageApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IStorageApi>();
            Assert.True(storageApi.HttpClient.BaseAddress != null);

            var systemFileApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ISystemFileApi>();
            Assert.True(systemFileApi.HttpClient.BaseAddress != null);

            var teamApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<ITeamApi>();
            Assert.True(teamApi.HttpClient.BaseAddress != null);

            var userApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IUserApi>();
            Assert.True(userApi.HttpClient.BaseAddress != null);

            var userCurrencyApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IUserCurrencyApi>();
            Assert.True(userCurrencyApi.HttpClient.BaseAddress != null);

            var userSettingApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IUserSettingApi>();
            Assert.True(userSettingApi.HttpClient.BaseAddress != null);

            var wechatApi = _hostUsingAddWithoutAClient.Services.GetRequiredService<IWechatApi>();
            Assert.True(wechatApi.HttpClient.BaseAddress != null);
        }
    }
}
