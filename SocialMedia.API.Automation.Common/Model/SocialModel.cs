using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Model
{
    public class SocialModel
    {
        [JsonProperty("youtube")]
        public string YouTube { get; set; }
        [JsonProperty("twitter")]
        public string Twitter { get; set; }
        [JsonProperty("linkedin")]
        public string LinkedIn { get; set; }
    }
}
