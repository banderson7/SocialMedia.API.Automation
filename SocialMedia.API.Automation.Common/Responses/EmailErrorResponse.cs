using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses
{
    public class EmailErrorResponse
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        public EmailErrorResponse(string email)
        {
            Email = email;
        }
    }
}
