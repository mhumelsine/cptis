using Cptis.Api.Endpoints.Client.V1.Requests;
using Cptis.Api.Endpoints.Client.V1.Responses;
using Cptis.Api.Models;
using Cptis.Application.Client.V1;
using Cptis.Core;

namespace Cptis.Api.Endpoints.Client;

public static class ModelFactory
{
    public static CreateClient Create(CreateClientRequest command) => new(
        ClientId: new ClientId(command.ClientId),
        Address: CommonModelFactory.Create(command.Address)
    );
    
    public static ClientResponse Create(Core.Client client) => new ClientResponse
    {
        ClientId = client.ClientId.Value,
        Address = CommonModelFactory.Create(client.Address)
    };
}