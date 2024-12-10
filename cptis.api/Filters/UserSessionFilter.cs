using cptis.application.Utils;
using Microsoft.AspNetCore.Mvc.Filters;

namespace cptis.api.Filters
{
    public class UserSessionFilter : ActionFilterAttribute
    {
        private readonly UserSessionContext userContext;
        private readonly IHttpContextAccessor httpContextAccessor;

        public UserSessionFilter(UserSessionContext userContext, IHttpContextAccessor httpContextAccessor)
        {
            this.userContext = userContext;
            this.httpContextAccessor = httpContextAccessor;
        }

        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var user = httpContextAccessor.HttpContext.User;

            if (user != null)
            {
                userContext.Username = this.GetUsername(user.Identity.Name);
                userContext.IpAddress = user.Claims.FirstOrDefault(c => c.Type == "ipaddr")?.Value ?? string.Empty;
                userContext.Email = user.Identity.Name;
                userContext.Name = user.Claims.FirstOrDefault(c => c.Type == "name")?.Value ?? string.Empty;
            }

            return next();
        }

        private string GetUsername(string email)
        {
            if (string.IsNullOrEmpty(email))
                return string.Empty;

            int atIndex = email.IndexOf('@');
            return atIndex > 0 ? email.Substring(0, atIndex) : email;
        }
    }
}
