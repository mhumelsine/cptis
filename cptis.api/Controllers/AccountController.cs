using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace cptis.api.Controllers
{
    [Route("[controller]")]
    public class AccountController : Controller
    {
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        [Authorize(AuthenticationSchemes = OpenIdConnectDefaults.AuthenticationScheme)]
        [Route("sign-in/{base64Url}")]
        [HttpGet]
        public IActionResult SignIn([FromRoute] string base64Url)
        {
            string url = Encoding.UTF8.GetString(Convert.FromBase64String(base64Url));

            if (!Url.IsLocalUrl(url))
            {
                Uri uri = new Uri(url);
                url = uri.AbsolutePath;
            }

            return Redirect(url);
        }
    }
}
