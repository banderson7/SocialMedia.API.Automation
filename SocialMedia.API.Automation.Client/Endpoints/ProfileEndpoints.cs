using System;
using RestSharp;
using SocialMedia.API.Automaiton.Common;
using SocialMedia.API.Automation.Common.Model;

namespace SocialMedia.API.Automation.Client.Endpoints
{
    public class ProfileEndpoints
    {
        public static IRestResponse DeleteCurrentUserProfile(RestClient client, string token)
        {
            IRestRequest request = new RequestBuilder(
                StringConstants.ProfilePath,
                Method.DELETE)
                .AddHeader("Authorization", token)
                .Create();

            return client.Execute(request);
        }

        public static IRestResponse CreateProfile(RestClient client, string token, ProfileModel profile)
        {
            IRestRequest request = new RequestBuilder(
                StringConstants.ProfilePath,
                Method.POST)
                .AddHeader("Authorization", token)
                .AddBody(profile.CreateProfileBody())
                .Create();

            return client.Execute(request);
        }
    }
}
