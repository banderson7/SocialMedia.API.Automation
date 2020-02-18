using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses
{
    public class PasswordErrorResponse
    {
        [JsonProperty("password")]
        public string Password { get; set; }

        public PasswordErrorResponse(string password)
        {
            Password = password;
        }

    }
}
