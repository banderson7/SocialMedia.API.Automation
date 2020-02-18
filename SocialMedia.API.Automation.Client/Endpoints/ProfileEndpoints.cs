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
    }
}
