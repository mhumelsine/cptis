
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

namespace cptis.api.Configuration
{
    public class AddAuthentication : IInjectableConfiguration
    {
        public void Register(IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                        .AddMicrosoftIdentityWebApi(options =>
                        {
                            configuration.Bind("AzureAd", options);
                            options.Events = new JwtBearerEvents();

                            /// <summary>
                            /// Below you can do extended token validation and check for additional claims, such as:
                            ///
                            /// - check if the caller's tenant is in the allowed tenants list via the 'tid' claim (for multi-tenant applications)
                            /// - check if the caller's account is homed or guest via the 'acct' optional claim
                            /// - check if the caller belongs to right roles or groups via the 'roles' or 'groups' claim, respectively
                            ///
                            /// Bear in mind that you can do any of the above checks within the individual routes and/or controllers as well.
                            /// For more information, visit: https://docs.microsoft.com/azure/active-directory/develop/access-tokens#validate-the-user-has-permission-to-access-this-data
                            /// </summary>

                            options.Events.OnTokenValidated = context =>
                            {
                                //string[] allowedClientApps = { /* list of client ids to allow */ };

                                //string clientappId = context?.Principal?.Claims
                                //    .FirstOrDefault(x => x.Type == "azp" || x.Type == "appid")?.Value;

                                //if (!allowedClientApps.Contains(clientappId))
                                //{
                                // throw new System.Exception("This client is not authorized");
                                // }
                                return Task.CompletedTask;
                            };
                        }, options => { configuration.Bind("AzureAd", options); });

        }
    }
}
