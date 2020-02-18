using System;
using RestSharp;
using SocialMedia.API.Automaiton.Common;
using SocialMedia.API.Automation.Common.Model;

namespace SocialMedia.API.Automation.Client.Endpoints
{
    public class UserEndpoints
    {
        public static IRestResponse UserLogin(RestClient client, User user)
        {
            IRestRequest request = new RequestBuilder(
                StringConstants.LoginPath,
                Method.POST)
                .AddBody(user.LoginUserBody())
                .Create();

            return client.Execute(request);
        }

        public static IRestResponse UserRegister(RestClient client, User user)
        {
            IRestRequest request = new RequestBuilder(
                StringConstants.RegisterPath,
                Method.POST)
                .AddBody(user.RegisterUserBody())
                .Create();

            return client.Execute(request);
        }

        public static IRestResponse UserCurrent(RestClient client, string token)
        {
            IRestRequest request = new RequestBuilder(
                StringConstants.CurrentUserPath,
                Method.GET)
                .AddHeader("Authorization", token)
                .Create();

            return client.Get(request);
        }
    }
}
