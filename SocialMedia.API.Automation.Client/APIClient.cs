using RestSharp;

namespace SocialMedia.API.Automation.Client
{
    public static class APIClient
    {
        public static RestClient NewClient()
        {
            return new RestClient("http://localhost:3000");
        }
    }
}
