using System;
using Newtonsoft.Json;
using SocialMedia.API.Automation.Common.Model;

namespace SocialMedia.API.Automation.Tests.Utility
{
    public static class ConfigReader
    {
        static Config config;

        static ConfigReader()
        {
            var rawConfig = System.IO.File.ReadAllText("./config.json");
            config = JsonConvert.DeserializeObject<Config>(rawConfig);
        }

        public static string GetBaseURL() => config.BaseUrl;
    }
}
