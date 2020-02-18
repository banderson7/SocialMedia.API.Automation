using System;
using Newtonsoft.Json;
using NUnit.Framework;
using SocialMedia.API.Automaiton.Common;
using SocialMedia.API.Automation.Client.Endpoints;
using SocialMedia.API.Automation.Common.Model;
using SocialMedia.API.Automation.Common.Responses.Profile;

namespace SocialMedia.API.Automation.Test.Profile
{
    public class CreateProfileTests : BaseTest
    {
        [Test]
        public void POST_CreateProfile_SuccessfulWithAllValues()
        {
            Login(User.TestUser);
            var createUserResponse = ProfileEndpoints.CreateProfile(client, sessionToken, ProfileModel.TestProfile);
            var responseMessage = JsonConvert.DeserializeObject<CreateProfileResponse>(createUserResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(200, (int)createUserResponse.StatusCode);
                Assert.AreEqual(ProfileModel.TestProfile.Handle, responseMessage.Handle);
                Assert.AreEqual(ProfileModel.TestProfile.Status, responseMessage.Status);
                Assert.AreEqual(ProfileModel.TestProfile.Skills, responseMessage.GetSkills());
                Assert.AreEqual(ProfileModel.TestProfile.Company, responseMessage.Company);
                Assert.AreEqual(ProfileModel.TestProfile.Website, responseMessage.Website);
                Assert.AreEqual(ProfileModel.TestProfile.Twitter, responseMessage.Social.Twitter);
                Assert.AreEqual(ProfileModel.TestProfile.YouTube, responseMessage.Social.YouTube);
                Assert.AreEqual(ProfileModel.TestProfile.LinkedIn, responseMessage.Social.LinkedIn);
                Assert.AreEqual(ProfileModel.TestProfile.Bio, responseMessage.Bio);
                Assert.AreEqual(ProfileModel.TestProfile.GithubUsername, responseMessage.GithubUsername);
                Assert.AreEqual(ProfileModel.TestProfile.Location, responseMessage.Location);

            });
        }
        [Test]
        public void POST_CreateProfile_NoHandle()
        {
            Login(User.TestUser);
            var createUserResponse = ProfileEndpoints.CreateProfile(client, sessionToken, ProfileModel.NoHandleProfile);
            var responseMessage = JsonConvert.DeserializeObject<HandleErrorResponse>(createUserResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)createUserResponse.StatusCode);
                Assert.AreEqual(StringConstants.HandleIsRequiredError, responseMessage.Handle);
            });
        }
        [Test]
        public void POST_CreateProfile_NoStatus()
        {
            Login(User.TestUser);
            var createUserResponse = ProfileEndpoints.CreateProfile(client, sessionToken, ProfileModel.NoStatusProfile);
            var responseMessage = JsonConvert.DeserializeObject<StatusErrorResponse>(createUserResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)createUserResponse.StatusCode);
                Assert.AreEqual(StringConstants.StatusIsRequiredError, responseMessage.Status);
            });
        }
        [Test]
        public void POST_CreateProfile_NoSkills()
        {
            Login(User.TestUser);
            var createUserResponse = ProfileEndpoints.CreateProfile(client, sessionToken, ProfileModel.NoSkillsProfile);
            var responseMessage = JsonConvert.DeserializeObject<SkillsErrorResponse>(createUserResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)createUserResponse.StatusCode);
                Assert.AreEqual(StringConstants.SkillsAreRequiredError, responseMessage.Skills);
            });
        }
    }
}
