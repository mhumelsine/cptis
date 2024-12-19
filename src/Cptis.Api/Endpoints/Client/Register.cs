using Cptis.Api.Endpoints.Client.V1;
using Cptis.Application.Client.V1;

namespace Cptis.Api.Endpoints.Client;

/// <summary>
/// Registers the Client endpoints
/// </summary>
public static class Register
{
    /// <summary>
    /// Adds configuration required for Client endpoints
    /// </summary>
    /// <param name="builder">The app builder</param>
    /// <returns>The builder this extension was called on (for builder pattern)</returns>
    public static WebApplicationBuilder AddClientEndpoints(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<ClientService>();
        
        return builder;
    }

    /// <summary>
    /// Registers our autocomplete endpoint
    /// </summary>
    /// <param name="app">The web application to configure</param>
    /// <returns>The web application this extension was called on</returns>
    public static WebApplication UseClientEndpoints(this WebApplication app)
    {
        app.MapGroup("v1/clients").V1();

        return app;
    }
}