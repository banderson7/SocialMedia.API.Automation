using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses
{
    public class LoginResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }

        public LoginResponse(bool success, string token)
        {
            Success = success;
            Token = token;
        }
    }
}
