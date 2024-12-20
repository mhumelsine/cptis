using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;

namespace Cptis.Api.Startup;

/// <summary>
/// Registers OpenAPI
/// </summary>
public static class OpenApi
{
    /// <summary>
    /// Registers OpenAPI and it's dependencies with the provided services collection
    /// </summary>
    public static WebApplicationBuilder AddOpenApi(this WebApplicationBuilder builder)
    {
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        //TODO:  Is this better than swagger?
        //builder.Services.AddOpenApi();

        builder.Services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen(opt =>
            {
                const string jwtAuthName = "JWT Access Token";

                opt.AddSecurityDefinition(jwtAuthName, new OpenApiSecurityScheme
                {
                    Description = $"{JwtBearerDefaults.AuthenticationScheme} in {HeaderNames.Authorization} header",
                    Name = HeaderNames.Authorization,
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = JwtBearerDefaults.AuthenticationScheme
                });

                opt.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = jwtAuthName
                            }
                        },
                        new List<string>()
                    }
                });
            })
            .AddFluentValidationRulesToSwagger();

        return builder;
    }

    /// <summary>
    /// Configures our web application to use OpenAPI
    /// </summary>
    /// <param name="app">The web application we are configuring</param>
    /// <returns>The web application this extension was called on (For builder pattern)</returns>
    public static WebApplication UseOpenApi(this WebApplication app)
    {
        app.UseSwagger();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwaggerUI();
        }

        //TODO:  Is this better than swagger?
        //app.MapOpenApi();

        return app;
    }
}