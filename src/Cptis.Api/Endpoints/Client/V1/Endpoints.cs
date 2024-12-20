using Cptis.Api.Endpoints.Client.V1.Requests;
using Cptis.Api.Endpoints.Client.V1.Responses;
using Cptis.Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Cptis.Application.Client.V1;
using Cptis.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Cptis.Api.Endpoints.Client.V1;

/// <summary>
/// Holds all V1 client endpoints
/// </summary>
public static class Endpoints
{
    /// <summary>
    /// Adds V1 endpoints
    /// </summary>
    /// <param name="group">Route group with prefix client</param>
    /// <returns>Builder</returns>
    public static RouteGroupBuilder V1(this RouteGroupBuilder group)
    {
        group.MapGet("/{clientKey:int}", GetAsync)
            .WithOpenApi(opt =>
            {
                opt.OperationId = "v1-get-client";
                opt.Description = "Returns Client based on client key";
                opt.Parameters[0].Example = new OpenApiInteger(12);

                return opt;
            })
            .WithName(nameof(GetAsync)) // name the route so it can be referenced in the 201-Created response
            .Produces<ClientResponse>() // describe the return type of the API
            .ProducesValidationProblem(); // describe the return type of the API
        
        group.MapPost("/", PostAsync)
            .Validate<CreateClientRequest>() // Add the validation middleware to the endpoint to find the validator for the model in the request body
            .WithOpenApi(opt =>
            {
                opt.OperationId = "v1-post-client";
                opt.Description = "Creates a new client";

                return opt;
            })
            .WithName(nameof(PostAsync))
            .Produces<ClientResponse>() // describe the return type of the API
            .ProducesValidationProblem(); // describe the return type of the API

        return group;
    }
    
    /// <summary>
    /// Handles get using the unique client key
    /// </summary>
    /// <param name="clientKey">The unique client identifier</param>
    /// <param name="db">Readonly DbContext</param>
    /// <param name="cancel">If the user aborts the request</param>
    /// <returns>Http.Result</returns>
    public static async Task<IResult> GetAsync([FromRoute] int clientKey, [FromServices] CptisReadContext db, CancellationToken cancel)
    {
        var client = await db.Clients
            .FirstOrDefaultAsync(x => x.ClientKey == clientKey, cancel);

        return client is null 
            ? Results.NotFound() 
            : Results.Ok(ModelFactory.Create(client));
    }
    
    /// <summary>
    /// Handles adding new clients
    /// </summary>
    /// <param name="body">The CreateClient command</param>
    /// <param name="service">The Application Service that will handle the command</param>
    /// <param name="cancel">If the user aborts the request</param>
    /// <returns>Http.Result</returns>
    public static async Task<IResult> PostAsync(
        [FromBody] CreateClientRequest body,
        [FromServices] ClientService service,
        CancellationToken cancel
    )
    {
        var created = await service.Execute(ModelFactory.Create(body), cancel);

        return Results.CreatedAtRoute(
            routeName: nameof(GetAsync),
            routeValues: new { id = created.ClientId },
            value: ModelFactory.Create(created)
        );
    }
}