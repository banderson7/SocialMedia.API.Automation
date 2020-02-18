using Newtonsoft.Json;
using NUnit.Framework;
using SocialMedia.API.Automation.Client.Endpoints;
using SocialMedia.API.Automation.Common.Model;
using SocialMedia.API.Automation.Common.Responses;

namespace SocialMedia.API.Automation.Test
{
    public class CurrentUserTests : BaseTest
    {
        [Test]
        public void GET_CurrentUser_Success()
        {
            Login(User.TestUser);

            var currentUserResponse = UserEndpoints.UserCurrent(client, sessionToken);
            var responseMessage = JsonConvert.DeserializeObject<CurrentUserResponse>(currentUserResponse.Content);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(200, (int)currentUserResponse.StatusCode);
                Assert.AreEqual(User.TestUser.Email, responseMessage.Email);
                Assert.AreEqual(User.TestUser.Name, responseMessage.Name);
            });
        }

        [Test]
        public void GET_CurrentUser_Unauthorized()
        {
            var currentUserResponse = UserEndpoints.UserCurrent(client, sessionToken);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(401, (int)currentUserResponse.StatusCode);
            });
        }
    }
}
