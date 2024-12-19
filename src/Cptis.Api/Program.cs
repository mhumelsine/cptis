using Cptis.Api;
using Cptis.Api.Endpoints.Client;
using Cptis.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddAuthorization();

builder
    .AddOpenApi()
    .AddDatabase();

//Add services
builder.AddClientEndpoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

//hook the endpoints into the request pipeline
app
    .UseOpenApi()
    .UseClientEndpoints();

app.Run();