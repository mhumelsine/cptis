using Cptis.Api.Tests.Mocks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Cptis.Api.Tests.Setup;

/// <summary>
/// Creates an instance of the application for integration testing.
/// </summary>
public class ApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        //override or remove/replace services registered in program and replace them with mocks here
        builder.ConfigureServices(services =>
        {
            services.AddAuthentication(defaultScheme: MockAuthenticationHandler.AuthenticationScheme)
                .AddScheme<AuthenticationSchemeOptions, MockAuthenticationHandler>(
                    MockAuthenticationHandler.AuthenticationScheme, options => { });
        });

        // use the app settings and logging configuration from development
        builder.UseEnvironment("Development");
    }
}