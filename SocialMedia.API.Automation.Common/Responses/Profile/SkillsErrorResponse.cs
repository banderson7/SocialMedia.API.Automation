using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Responses.Profile
{
    public class SkillsErrorResponse
    {
        [JsonProperty("skills")]
        public string Skills { get; set; }

        public SkillsErrorResponse(string skills)
        {
            Skills = skills;
        }
    }
}
