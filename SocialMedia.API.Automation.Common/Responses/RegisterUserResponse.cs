using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses
{
    public class RegisterUserResponse
    {

        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        public RegisterUserResponse(string id, string name, string email, string avatar, string password, string date)
        {
            Id = id;
            Name = name;
            Email = email;
            Avatar = avatar;
            Password = password;
            Date = DateTime.Parse(date);
        }
    }
}
