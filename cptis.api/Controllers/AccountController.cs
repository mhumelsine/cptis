using Microsoft.AspNetCore.Mvc;

namespace cptis.api.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly IConfiguration configuration;

        public AccountController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("auth-config")]
        [HttpGet]
        public IActionResult GetConfig()
        {
            var response = new
            {
                msalConfig = new
                {
                    auth = new
                    {
                        clientId = $"{configuration["AzureAd:ClientId"]}",
                        authority = $"https://login.microsoftonline.com/{configuration["AzureAd:TenantId"]}",
                        redirectUri = "/",
                        postLogoutRedirectUri = "/"
                    },
                    cache = new
                    {
                        cacheLocation = "localStorage",
                        storeAuthStateInCookie = false // Set to true if needed for IE11/Edge issues
                    }
                },
                loginRequest = new
                {
                    scopes = new List<string> { $"api://{configuration["AzureAd:ClientId"]}/user_impersonation" }
                },
                logoutRequest = new
                {
                    postLogoutRedirectUri = "/"
                }
            };

            return Ok(response);
        }
    }
}
