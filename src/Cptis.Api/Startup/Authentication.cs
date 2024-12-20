using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;

namespace Cptis.Api.Startup;

public static class Authentication
{
    /// <summary>
    /// Adds authentication and authorization services
    /// </summary>
    /// <param name="builder">The web application builder instance</param>
    /// <returns>The web application builder instance</returns>
    public static WebApplicationBuilder AddAuthentication(this WebApplicationBuilder builder)
    {
        builder.Services
            .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

        builder.Services.AddAuthorization();
        
        return builder;
    }

    /// <summary>
    /// Configures our web application to use authentication in the request pipeline
    /// </summary>
    /// <param name="app">The web application we are configuring</param>
    /// <returns>The web application this extension was called on (For builder pattern)</returns>
    public static WebApplication UseAuthenticationAndAuthorization(this WebApplication app)
    {
        //TODO:  Enable later
        //app.UseAuthentication()
            //.UseAuthorization();
        
        return app;
    }
}