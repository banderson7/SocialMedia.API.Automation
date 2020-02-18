using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses
{
    public class CurrentUserResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

        public CurrentUserResponse(string id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
