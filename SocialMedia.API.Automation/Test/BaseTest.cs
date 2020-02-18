using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using SocialMedia.API.Automation.Client;
using SocialMedia.API.Automation.Client.Endpoints;
using SocialMedia.API.Automation.Common.Model;
using SocialMedia.API.Automation.Common.Responses;

namespace SocialMedia.API.Automation
{
    public class BaseTest
    {
        protected RestClient client;
        protected string sessionToken;

        public BaseTest()
        {
            client = APIClient.NewClient();
        }

        [SetUp]
        public void BaseSetup()
        {
            UserEndpoints.UserRegister(client, User.TestUser);
            Login(User.NewUser);
            ProfileEndpoints.DeleteCurrentUserProfile(client, sessionToken);
            sessionToken = string.Empty;
        }

        [TearDown]
        public void Cleanup()
        {
            var loginResponse = UserEndpoints.UserLogin(client, User.TestUser);
            sessionToken = JsonConvert.DeserializeObject<LoginResponse>(loginResponse.Content).Token;

            ProfileEndpoints.DeleteCurrentUserProfile(client, sessionToken);
        }

        protected void Login(User user)
        {
            var loginResponse = UserEndpoints.UserLogin(client, user);
            sessionToken = JsonConvert.DeserializeObject<LoginResponse>(loginResponse.Content).Token;
        }
    }
}
