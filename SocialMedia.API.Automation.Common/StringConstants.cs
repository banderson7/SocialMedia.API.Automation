using System;
namespace SocialMedia.API.Automaiton.Common
{
    public class StringConstants
    {
        #region Endpoint Paths
        public const string BasePath = "/api";
        public const string LoginPath = "/users/login";
        public const string RegisterPath = "/users/register";
        public const string CurrentUserPath = "/users/current";
        public const string ProfilePath = "/profile";
        #endregion

        #region Parameters
        public const string ApplicationJson = "application/json";
        #endregion

        #region Error Messages
        public const string InvalidEmailError = "Email is invalid";
        public const string NameLengthError = "Name must be between 2 and 30 characters";
        public const string PasswordLengthError = "Password must be between 6 and 30 characters";
        public const string IncorrectPasswordError = "Password is incorrect";
        public const string UserNotFoundError = "User not found";
        public const string HandleIsRequiredError = "Handle is required";
        public const string StatusIsRequiredError = "Status is required";
        public const string SkillsAreRequiredError = "Skills is required";
        #endregion
    }
}
