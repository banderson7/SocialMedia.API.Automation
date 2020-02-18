using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Model
{
    public class ProfileModel
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("skills")]
        public string Skills { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("website")]
        public string Website { get; set; }
        [JsonProperty("twitter")]
        public string Twitter { get; set; }
        [JsonProperty("youtube")]
        public string YouTube { get; set; }
        [JsonProperty("linkedin")]
        public string LinkedIn { get; set; }

        public ProfileModel(string handle, string status, string skills, string company, string website, string twitter, string youTube, string linkedIn)
        {
            Handle = handle;
            Status = status;
            Skills = skills;
            Company = company;
            Website = website;
            Twitter = twitter;
            YouTube = youTube;
            LinkedIn = linkedIn;
        }
    }
}
