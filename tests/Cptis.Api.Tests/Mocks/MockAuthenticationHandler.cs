using System.Security.Claims;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Cptis.Api.Tests.Mocks;

/// <summary>
/// Mocks authentication by always returning an authenticated user with full permissions
/// </summary>
public class MockAuthenticationHandler(
    IOptionsMonitor<AuthenticationSchemeOptions> options,
    ILoggerFactory logger,
    UrlEncoder encoder,
    ISystemClock clock)
    : AuthenticationHandler<AuthenticationSchemeOptions>(options, logger, encoder, clock)
{
    /// <summary>
    /// The authentication scheme
    /// </summary>
    public const string AuthenticationScheme = "MockAuthentication";
    
    /// <summary>
    /// The authentication type
    /// </summary>
    public const string AuthenticationType = "MockAuth";

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name, "Donald Duck"),
            new Claim(ClaimTypes.Role, "admin")
        };
        
        var identity = new ClaimsIdentity(claims, AuthenticationType);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, AuthenticationScheme);

        var result = AuthenticateResult.Success(ticket);

        return Task.FromResult(result);
    }
}