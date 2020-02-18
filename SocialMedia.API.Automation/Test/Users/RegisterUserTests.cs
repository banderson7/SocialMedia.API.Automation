using System;
using Newtonsoft.Json;
using NUnit.Framework;
using SocialMedia.API.Automaiton.Common;
using SocialMedia.API.Automation.Client.Endpoints;
using SocialMedia.API.Automation.Common.Model;
using SocialMedia.API.Automation.Common.Responses;

namespace SocialMedia.API.Automation.Test.Users
{
    public class RegisterUserTests : BaseTest
    {
        [Test]
        public void POST_Register_Successful()
        {
            var registerResponse = UserEndpoints.UserRegister(client, User.NewUser);
            var responseMessage = JsonConvert.DeserializeObject<RegisterUserResponse>(registerResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(200, (int)registerResponse.StatusCode);
                Assert.AreEqual(User.NewUser.Name, responseMessage.Name);
                Assert.AreEqual(User.NewUser.Email, responseMessage.Email);
                Assert.AreEqual(DateTime.Now.Date, responseMessage.Date.Date);
            });
        }

        [Test]
        public void POST_Register_InvalidEmail()
        {
            var registerResponse = UserEndpoints.UserRegister(client, User.InvalidEmailUser);
            var responseMessage = JsonConvert.DeserializeObject<EmailErrorResponse>(registerResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)registerResponse.StatusCode);
                Assert.AreEqual(responseMessage.Email, StringConstants.InvalidEmailError);
            });
        }

        [Test]
        public void POST_Register_NameTooShort()
        {
            var registerResponse = UserEndpoints.UserRegister(client, User.ShortNameUser);
            var responseMessage = JsonConvert.DeserializeObject<NameErrorResponse>(registerResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)registerResponse.StatusCode);
                Assert.AreEqual(responseMessage.Name, StringConstants.NameLengthError);
            });
        }

        [Test]
        public void POST_Register_NameTooLong()
        {
            var registerResponse = UserEndpoints.UserRegister(client, User.LongNameUser);
            var responseMessage = JsonConvert.DeserializeObject<NameErrorResponse>(registerResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)registerResponse.StatusCode);
                Assert.AreEqual(responseMessage.Name, StringConstants.NameLengthError);
            });
        }

        [Test]
        public void POST_Register_PasswordTooShort()
        {
            var registerResponse = UserEndpoints.UserRegister(client, User.ShortPasswordUser);
            var responseMessage = JsonConvert.DeserializeObject<PasswordErrorResponse>(registerResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)registerResponse.StatusCode);
                Assert.AreEqual(responseMessage.Password, StringConstants.PasswordLengthError);
            });
        }

        [Test]
        public void POST_Register_PasswordTooLong()
        {
            var registerResponse = UserEndpoints.UserRegister(client, User.LongPasswordUser);
            var responseMessage = JsonConvert.DeserializeObject<PasswordErrorResponse>(registerResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)registerResponse.StatusCode);
                Assert.AreEqual(responseMessage.Password, StringConstants.PasswordLengthError);
            });
        }
    }
}
