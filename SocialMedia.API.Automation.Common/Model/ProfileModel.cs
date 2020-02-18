using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Model
{
    public class ProfileModel
    {
        public static ProfileModel TestProfile = new ProfileModel(
            "AutoHandle", "automation", "skill1,skill2", "Test Co", "www.test.com", "www.twitter.com", "www.youtube.com", "www.linkedin.com", "Test Bio", "banderson7", "St Paul");
        public static ProfileModel NoHandleProfile = new ProfileModel(
            "", "automation", "skills,skills2");
        public static ProfileModel NoStatusProfile = new ProfileModel(
            "NoStatus", "", "skills,skills2");
        public static ProfileModel NoSkillsProfile = new ProfileModel(
            "NoSkills", "automation", "");
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
        [JsonProperty("bio")]
        public string Bio { get; set; }
        [JsonProperty("githubusername")]
        public string GithubUsername { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }

        public ProfileModel(string handle, string status, string skills, string company, string website, string twitter, string youTube, string linkedIn, string bio, string githubusername, string location)
        {
            Handle = handle;
            Status = status;
            Skills = skills;
            Company = company;
            Website = website;
            Twitter = twitter;
            YouTube = youTube;
            LinkedIn = linkedIn;
            Bio = bio;
            GithubUsername = githubusername;
            Location = location;
        }
        public ProfileModel(string handle, string status, string skills)
        {
            Handle = handle;
            Status = status;
            Skills = skills;
        }

        public string CreateProfileBody()
        {
            return JsonConvert.SerializeObject(this,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });
        }
    }
}
