using System;
using Newtonsoft.Json;
using SocialMedia.API.Automation.Common.Model;

namespace SocialMedia.API.Automation.Common.Responses.Profile
{
    public class CreateProfileResponse
    {
        [JsonProperty("social")]
        public SocialModel Social { get; set; }
        [JsonProperty("skills")]
        public string[] Skills { get; set; }
        [JsonProperty("_id")]
        public string Id { get; set; }
        [JsonProperty("user")]
        public string User { get; set; }
        [JsonProperty("handle")]
        public string Handle { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("experience")]
        public string[] Experience { get; set; }
        [JsonProperty("education")]
        public string[] Education { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [JsonProperty("bio")]
        public string Bio { get; set; }
        [JsonProperty("githubusername")]
        public string GithubUsername { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
