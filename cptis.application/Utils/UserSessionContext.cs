using cptis.application.Interfaces;

namespace cptis.application.Utils
{
    public class UserSessionProvider : IUserSessionProvider
    {
        private readonly UserSessionContext userContext;


        public UserSessionProvider(UserSessionContext userContext)
        {
            this.userContext = userContext;
        }

        public string GetUsername()
        {
            return userContext.Username;
        }
    }

    public class UserSessionContext
    {
        public string Username { get; set; } = "SYSTEM";
        public string Email { get; set; }
        public string Name { get; set; }
        public string IpAddress { get; set; }
    }
}