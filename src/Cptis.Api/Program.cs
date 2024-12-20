using Cptis.Api.Endpoints.Client;
using Cptis.Api.Startup;

var builder = WebApplication.CreateBuilder(args);

// Configure the application services
builder
    .AddAuthentication()
    .AddOpenApi()
    .AddDatabase()
    .AddClientEndpoints();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

//add handlers to the request pipeline
app
    .UseAuthenticationAndAuthorization()
    .UseOpenApi()
    .UseClientEndpoints();

app.Run();


// Make the implicit Program class public so test projects can access it
public partial class Program { }