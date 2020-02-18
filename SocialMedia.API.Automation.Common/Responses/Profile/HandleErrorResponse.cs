using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses.Profile
{
    public class HandleErrorResponse
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }

        public HandleErrorResponse(string handle)
        {
            Handle = handle;
        }
    }
}
