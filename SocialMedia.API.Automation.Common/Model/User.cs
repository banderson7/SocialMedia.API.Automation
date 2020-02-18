using System;
using Newtonsoft.Json;

namespace SocialMedia.API.Automation.Common.Model
{
    public class User
    {
        public static User TestUser = new User("test@test.com", "Automation User", "password", "password");
        public static User NewUser = new User("NewAutomation@User.com", "Test User", "dkhge12", "dkhge12");
        public static User InvalidEmailUser = new User("invalid@invalid", "Invalid Email", "password", "password");
        public static User ShortNameUser = new User("short@name.com", "T", "password", "password");
        public static User LongNameUser = new User("short@name.com", "EmailEmailEmailEmailEmailEmail@Long.com", "password", "password");
        public static User ShortPasswordUser = new User("short@pass.com", "Short Password", "short", "short");
        public static User LongPasswordUser = new User("long@pass.com", "Long Password", "passwordpasswordpasswordpasswor", "passwordpasswordpasswordpasswor");
        public static User InvalidPasswordUser = new User("test@test.com", "Automation User", "invalid", "invalid");
        public static User MismatchPasswordUser = new User("mismatch@password.com", "Password Test", "first", "second");

        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("password2")]
        public string Password2 { get; set; }

        public User(string password)
        {
            Password = password;
        }
        public User (string email, string password)
        {
            Email = email;
            Password = password;
        }
        public User (string email, string name, string password, string password2)
        {
            Email = email;
            Name = name;
            Password = password;
            Password2 = password2;
        }

        public string LoginUserBody()
        {
            User loginUser = new User(Email, Password);
            return JsonConvert.SerializeObject(loginUser, Formatting.Indented);
        }
        public string RegisterUserBody()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
