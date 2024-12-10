using NLog.Web;
using cptis.api.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.OpenApi.Models;
using cptis.api.Filters;
using cptis.application.Utils;
using cptis.application.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Warning);
builder.Host.UseNLog();
builder.Services.AddControllers();
builder.Services.AddMemoryCache();
builder.Services.AddResponseCaching();

var configuration = builder.Configuration;

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Type = SecuritySchemeType.OAuth2,
        Flows = new OpenApiOAuthFlows
        {
            AuthorizationCode = new OpenApiOAuthFlow
            {
                AuthorizationUrl = new Uri(builder.Configuration["AzureAd:Instance"]
                                           + builder.Configuration["AzureAd:TenantId"]
                                           + "/oauth2/v2.0/authorize"),
                TokenUrl = new Uri(builder.Configuration["AzureAd:Instance"]
                                   + builder.Configuration["AzureAd:TenantId"]
                                   + "/oauth2/v2.0/token"),
                Scopes = new Dictionary<string, string>
                {
                    { "api://d616a281-9ab1-45c3-bc55-d771ba43a117/User.Read", "Access API" }
                }
            }
        }
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" },
                 Scheme = "oauth2",
                Name = "oauth2",
                In = ParameterLocation.Header
            },
            new[] { "api://d616a281-9ab1-45c3-bc55-d771ba43a117/User.Read" }
        }
    });
});
builder.Services.AddScoped<UserSessionContext>();
builder.Services.AddScoped<UserSessionFilter>();
builder.Services.AddScoped<IUserSessionProvider>(p => new UserSessionProvider(p.GetRequiredService<UserSessionContext>()));
builder.Services.AddControllers(options =>
{
    options.Filters.AddService<UserSessionFilter>();
});

builder.Services
       .RegisterServices(
            builder.Configuration,
            typeof(IInjectableConfiguration).Assembly);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy => policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

app.UseCors("AllowAllOrigins");
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    IdentityModelEventSource.ShowPII = true;
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.OAuthScopes($"api://{builder.Configuration["AzureAd:ClientId"]}/User.Read");
        c.OAuthClientId(builder.Configuration["AzureAd:ClientId"]);
        c.OAuthUsePkce();
    });
}

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapControllers();

app.Run();
