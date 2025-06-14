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
    ///  Class for testing UserApi
    /// </summary>
    public sealed class UserApiTests : ApiTestsBase
    {
        private readonly IUserApi _instance;

        public UserApiTests(): base(Array.Empty<string>())
        {
            _instance = _host.Services.GetRequiredService<IUserApi>();
        }

        /// <summary>
        /// Test User
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.UserAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<UserApiResponse>(model);
        }

        /// <summary>
        /// Test UserClear
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserClearAsyncTest()
        {
            string appKey = default;
            var response = await _instance.UserClearAsync(appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserCommonInterests
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserCommonInterestsAsyncTest()
        {
            string appKey = default;
            Client.Option<string> tag = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            var response = await _instance.UserCommonInterestsAsync(appKey, tag, skip, take);
            var model = response.Ok();
            Assert.IsType<UserCommonInterestsResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserDeactivateHard
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserDeactivateHardAsyncTest()
        {
            string appKey = default;
            var response = await _instance.UserDeactivateHardAsync(appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserDeleteAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.UserDeleteAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserEmailSignIn
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserEmailSignInAsyncTest()
        {
            string appKey = default;
            Client.Option<EmailSignInRequest> emailSignInRequest = default;
            var response = await _instance.UserEmailSignInAsync(appKey, emailSignInRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserEmailSignUp
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserEmailSignUpAsyncTest()
        {
            string appKey = default;
            Client.Option<EmailSignUpRequest> emailSignUpRequest = default;
            var response = await _instance.UserEmailSignUpAsync(appKey, emailSignUpRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserExport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserExportAsyncTest()
        {
            string appKey = default;
            var response = await _instance.UserExportAsync(appKey);
            var model = response.Ok();
            Assert.IsType<System.IO.Stream>(model);
        }

        /// <summary>
        /// Test UserFollowUser
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserFollowUserAsyncTest()
        {
            long userId = default;
            string appKey = default;
            var response = await _instance.UserFollowUserAsync(userId, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserFollowerPut
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserFollowerPutAsyncTest()
        {
            long id = default;
            string appKey = default;
            Client.Option<FollowerPutModel> followerPutModel = default;
            var response = await _instance.UserFollowerPutAsync(id, appKey, followerPutModel);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserFollowers
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserFollowersAsyncTest()
        {
            string appKey = default;
            Client.Option<string> tag = default;
            Client.Option<string> status = default;
            Client.Option<long> targetUserId = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            var response = await _instance.UserFollowersAsync(appKey, tag, status, targetUserId, skip, take);
            var model = response.Ok();
            Assert.IsType<UserFollowersResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserFollowing
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserFollowingAsyncTest()
        {
            string appKey = default;
            Client.Option<string> tag = default;
            Client.Option<string> status = default;
            Client.Option<long> targetUserId = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            Client.Option<long> checkUserId = default;
            Client.Option<bool> onlyIDs = default;
            var response = await _instance.UserFollowingAsync(appKey, tag, status, targetUserId, skip, take, checkUserId, onlyIDs);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserFriendsNearBy
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserFriendsNearByAsyncTest()
        {
            double longitude = default;
            double latitude = default;
            string appKey = default;
            Client.Option<string> country = default;
            Client.Option<string> state = default;
            Client.Option<string> city = default;
            Client.Option<string> district = default;
            Client.Option<string> gender = default;
            Client.Option<int> ageS = default;
            Client.Option<int> ageE = default;
            Client.Option<string> tag = default;
            Client.Option<long> distance = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            var response = await _instance.UserFriendsNearByAsync(longitude, latitude, appKey, country, state, city, district, gender, ageS, ageE, tag, distance, skip, take);
            var model = response.Ok();
            Assert.IsType<UserFriendsNearByResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserImport
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserImportAsyncTest()
        {
            string appKey = default;
            Client.Option<bool> check = default;
            Client.Option<System.IO.Stream> file = default;
            var response = await _instance.UserImportAsync(appKey, check, file);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserLocation
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserLocationAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.UserLocationAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<GeoLocationModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserLocationDelete
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserLocationDeleteAsyncTest()
        {
            long id = default;
            string appKey = default;
            var response = await _instance.UserLocationDeleteAsync(id, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserLocationPost
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserLocationPostAsyncTest()
        {
            string appKey = default;
            Client.Option<GeoLocationModel> geoLocationModel = default;
            var response = await _instance.UserLocationPostAsync(appKey, geoLocationModel);
            var model = response.Ok();
            Assert.IsType<UserLocationPostResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserLocationPut
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserLocationPutAsyncTest()
        {
            long id = default;
            string appKey = default;
            Client.Option<GeoLocationModel> geoLocationModel = default;
            var response = await _instance.UserLocationPutAsync(id, appKey, geoLocationModel);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserLocations
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserLocationsAsyncTest()
        {
            string appKey = default;
            Client.Option<string> tag = default;
            Client.Option<string> type = default;
            Client.Option<double> x = default;
            Client.Option<double> y = default;
            Client.Option<long> sphere = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            var response = await _instance.UserLocationsAsync(appKey, tag, type, x, y, sphere, skip, take);
            var model = response.Ok();
            Assert.IsType<UserLocationsResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserMutualFollowers
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserMutualFollowersAsyncTest()
        {
            string appKey = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            var response = await _instance.UserMutualFollowersAsync(appKey, skip, take);
            var model = response.Ok();
            Assert.IsType<UserMutualFollowersResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserMutualFollowings
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserMutualFollowingsAsyncTest()
        {
            string appKey = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            var response = await _instance.UserMutualFollowingsAsync(appKey, skip, take);
            var model = response.Ok();
            Assert.IsType<UserMutualFollowingsResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserOAuthAccountBind
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserOAuthAccountBindAsyncTest()
        {
            string appKey = default;
            Client.Option<OAuthAccountBindRequest> oAuthAccountBindRequest = default;
            var response = await _instance.UserOAuthAccountBindAsync(appKey, oAuthAccountBindRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserOAuthAccountSignIn
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserOAuthAccountSignInAsyncTest()
        {
            string appKey = default;
            Client.Option<OAuthAccountSignInRequest> oAuthAccountSignInRequest = default;
            var response = await _instance.UserOAuthAccountSignInAsync(appKey, oAuthAccountSignInRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
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
            Client.Option<OAuthAccountPutBindRequest> oAuthAccountPutBindRequest = default;
            var response = await _instance.UserOAuthAccountsPutBindAsync(id, appKey, oAuthAccountPutBindRequest);
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

        /// <summary>
        /// Test UserPhoneSignIn
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserPhoneSignInAsyncTest()
        {
            string appKey = default;
            Client.Option<PhoneSignInRequest> phoneSignInRequest = default;
            var response = await _instance.UserPhoneSignInAsync(appKey, phoneSignInRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserPhoneSignUp
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserPhoneSignUpAsyncTest()
        {
            string appKey = default;
            Client.Option<PhoneSignUpRequest> phoneSignUpRequest = default;
            var response = await _instance.UserPhoneSignUpAsync(appKey, phoneSignUpRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserProfile
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserProfileAsyncTest()
        {
            string appKey = default;
            var response = await _instance.UserProfileAsync(appKey);
            var model = response.Ok();
            Assert.IsType<UserProfileResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserProfileById
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserProfileByIdAsyncTest()
        {
            long userId = default;
            string appKey = default;
            var response = await _instance.UserProfileByIdAsync(userId, appKey);
            var model = response.Ok();
            Assert.IsType<GetUserProfileResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserPut
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserPutAsyncTest()
        {
            long id = default;
            string appKey = default;
            Client.Option<User> user = default;
            var response = await _instance.UserPutAsync(id, appKey, user);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserQRCodePreSignIn
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserQRCodePreSignInAsyncTest()
        {
            string appKey = default;
            Client.Option<QRCodePreSignInRequest> qRCodePreSignInRequest = default;
            var response = await _instance.UserQRCodePreSignInAsync(appKey, qRCodePreSignInRequest);
            var model = response.Ok();
            Assert.IsType<Int64ApiResponse>(model);
        }

        /// <summary>
        /// Test UserQRCodeScan
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserQRCodeScanAsyncTest()
        {
            string appKey = default;
            Client.Option<QRCodeScanRequest> qRCodeScanRequest = default;
            var response = await _instance.UserQRCodeScanAsync(appKey, qRCodeScanRequest);
            var model = response.Ok();
            Assert.IsType<UserQRCodeScanResultApiResponse>(model);
        }

        /// <summary>
        /// Test UserQRCodeSignIn
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserQRCodeSignInAsyncTest()
        {
            string appKey = default;
            Client.Option<QRCodeSignInRequest> qRCodeSignInRequest = default;
            var response = await _instance.UserQRCodeSignInAsync(appKey, qRCodeSignInRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserQRCodeSignUp
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserQRCodeSignUpAsyncTest()
        {
            string appKey = default;
            Client.Option<QRCodeSignUpRequest> qRCodeSignUpRequest = default;
            var response = await _instance.UserQRCodeSignUpAsync(appKey, qRCodeSignUpRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserResetEmail
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserResetEmailAsyncTest()
        {
            string appKey = default;
            Client.Option<AppUserResetEmailRequest> appUserResetEmailRequest = default;
            var response = await _instance.UserResetEmailAsync(appKey, appUserResetEmailRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserResetPhone
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserResetPhoneAsyncTest()
        {
            string appKey = default;
            Client.Option<AppUserResetPhoneRequest> appUserResetPhoneRequest = default;
            var response = await _instance.UserResetPhoneAsync(appKey, appUserResetPhoneRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserResetPwd
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserResetPwdAsyncTest()
        {
            string appKey = default;
            Client.Option<AppUserResetPwdRequest> appUserResetPwdRequest = default;
            var response = await _instance.UserResetPwdAsync(appKey, appUserResetPwdRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserSendEmailCode
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserSendEmailCodeAsyncTest()
        {
            string appKey = default;
            Client.Option<SendEmailCodeRequest> sendEmailCodeRequest = default;
            var response = await _instance.UserSendEmailCodeAsync(appKey, sendEmailCodeRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserSendSMSCode
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserSendSMSCodeAsyncTest()
        {
            string appKey = default;
            Client.Option<SendSMSCodeRequest> sendSMSCodeRequest = default;
            var response = await _instance.UserSendSMSCodeAsync(appKey, sendSMSCodeRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserSignIn
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserSignInAsyncTest()
        {
            string appKey = default;
            Client.Option<SignInRequest> signInRequest = default;
            var response = await _instance.UserSignInAsync(appKey, signInRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserSignUp
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserSignUpAsyncTest()
        {
            string appKey = default;
            Client.Option<SignUpRequest> signUpRequest = default;
            var response = await _instance.UserSignUpAsync(appKey, signUpRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserTwoFactorAuth
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserTwoFactorAuthAsyncTest()
        {
            string appKey = default;
            var response = await _instance.UserTwoFactorAuthAsync(appKey);
            var model = response.Ok();
            Assert.IsType<SetupCodeApiResponse>(model);
        }

        /// <summary>
        /// Test UserUnfollowUser
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserUnfollowUserAsyncTest()
        {
            long userId = default;
            string appKey = default;
            var response = await _instance.UserUnfollowUserAsync(userId, appKey);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test UserUnionIDSignIn
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserUnionIDSignInAsyncTest()
        {
            string appKey = default;
            Client.Option<UnionIDSignInRequest> unionIDSignInRequest = default;
            var response = await _instance.UserUnionIDSignInAsync(appKey, unionIDSignInRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserUnionIDSignUp
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserUnionIDSignUpAsyncTest()
        {
            string appKey = default;
            Client.Option<UnionIDSignUpRequest> unionIDSignUpRequest = default;
            var response = await _instance.UserUnionIDSignUpAsync(appKey, unionIDSignUpRequest);
            var model = response.Ok();
            Assert.IsType<TokenModelApiResponse>(model);
        }

        /// <summary>
        /// Test UserUpdateProfile
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UserUpdateProfileAsyncTest()
        {
            string appKey = default;
            Client.Option<UpdateProfileRequest> updateProfileRequest = default;
            var response = await _instance.UserUpdateProfileAsync(appKey, updateProfileRequest);
            var model = response.Ok();
            Assert.IsType<BooleanApiResponse>(model);
        }

        /// <summary>
        /// Test Users
        /// </summary>
        [Fact (Skip = "not implemented")]
        public async Task UsersAsyncTest()
        {
            string appKey = default;
            Client.Option<string> userName = default;
            Client.Option<string> email = default;
            Client.Option<string> phone = default;
            Client.Option<string> platform = default;
            Client.Option<string> unionId = default;
            Client.Option<string> role = default;
            Client.Option<int> skip = default;
            Client.Option<int> take = default;
            var response = await _instance.UsersAsync(appKey, userName, email, phone, platform, unionId, role, skip, take);
            var model = response.Ok();
            Assert.IsType<UserListResultApiResponse>(model);
        }
    }
}
