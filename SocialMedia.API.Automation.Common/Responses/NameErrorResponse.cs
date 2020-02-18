using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses
{
    public class NameErrorResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public NameErrorResponse(string name)
        {
            Name = name;
        }
    }
}
