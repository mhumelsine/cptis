using Cptis.Api.Endpoints.Client.V1.Requests;
using Cptis.Api.Endpoints.Client.V1.Responses;
using Cptis.Api.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using Cptis.Application.Client.V1;
using Cptis.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Cptis.Api.Endpoints.Client.V1;

public static class Endpoints
{
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
            .WithName(nameof(GetAsync))
            .Produces<ClientResponse>()
            .ProducesValidationProblem();
        
        group.MapPost("/", PostAsync)
            .Validate<CreateClientRequest>()
            .WithOpenApi(opt =>
            {
                opt.OperationId = "v1-post-client";
                opt.Description = "Creates a new client";

                return opt;
            })
            .WithName(nameof(PostAsync))
            .Produces<ClientResponse>()
            .ProducesValidationProblem();

        return group;
    }
    
    public static async Task<IResult> GetAsync([FromRoute] int clientKey, [FromServices] CptisReadContext db, CancellationToken cancel)
    {
        var client = await db.Clients.FirstOrDefaultAsync(x => x.ClientKey == clientKey, cancel);

        return client is null 
            ? Results.NotFound() 
            : Results.Ok(ModelFactory.Create(client));
    }


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