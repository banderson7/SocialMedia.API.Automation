using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses
{
    public class ConfirmPasswordErrorResponse
    {
        [JsonProperty("password2")]
        public string Password2 { get; set; }

        public ConfirmPasswordErrorResponse(string password2)
        {
            Password2 = password2;
        }
    }
}
