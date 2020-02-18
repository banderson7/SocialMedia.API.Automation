using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses.Profile
{
    public class StatusErrorResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        public StatusErrorResponse(string status)
        {
            Status = status;
        }
    }
}
