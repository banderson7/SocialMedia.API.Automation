using Newtonsoft.Json;
using NUnit.Framework;
using SocialMedia.API.Automaiton.Common;
using SocialMedia.API.Automation.Client.Endpoints;
using SocialMedia.API.Automation.Common.Model;
using SocialMedia.API.Automation.Common.Responses;

namespace SocialMedia.API.Automation.Test
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void POST_Login_ValidLogin()
        {
            var loginResponse = UserEndpoints.UserLogin(client, User.TestUser);
            LoginResponse responseMessage = JsonConvert.DeserializeObject<LoginResponse>(loginResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(200, (int)loginResponse.StatusCode);
                Assert.AreEqual(true, responseMessage.Success);
                Assert.True(responseMessage.Token.Contains("Bearer "));
            });
        }

        [Test]
        public void POST_Login_InvalidPassword()
        {
            var loginResponse = UserEndpoints.UserLogin(client, User.InvalidPasswordUser);
            PasswordErrorResponse responseMessage = JsonConvert.DeserializeObject<PasswordErrorResponse>(loginResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(400, (int)loginResponse.StatusCode);
                Assert.True(responseMessage.Password == (StringConstants.IncorrectPasswordError));
            });
        }

        [Test]
        public void POST_Login_InvalidEmail()
        {
            var loginResponse = UserEndpoints.UserLogin(client, User.NewUser);
            EmailErrorResponse responseMessage = JsonConvert.DeserializeObject<EmailErrorResponse>(loginResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(404, (int)loginResponse.StatusCode);
                Assert.True(responseMessage.Email == (StringConstants.UserNotFoundError));
            });
        }
    }
}
