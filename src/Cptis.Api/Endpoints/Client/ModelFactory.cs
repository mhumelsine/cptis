using Cptis.Api.Endpoints.Client.V1.Requests;
using Cptis.Api.Endpoints.Client.V1.Responses;
using Cptis.Api.Models;
using Cptis.Application.Client.V1;
using Cptis.Core;

namespace Cptis.Api.Endpoints.Client;

/// <summary>
/// Handles translating the HTTP representations of the commands into the Domain representations of the commands,
/// creating value objects and conversions where necessary.
/// </summary>
public static class ModelFactory
{
    /// <summary>
    /// Maps the HTTP POST body for creating a new client to the core command
    /// </summary>
    /// <param name="command">The http representation of the command</param>
    /// <returns>Domain representation of the command</returns>
    public static CreateClient Create(CreateClientRequest command) => new(
        ClientId: new ClientId(command.ClientId),
        Address: CommonModelFactory.Create(command.Address),
        Name: Name.None, //TODO
        BirthDate: BirthDate.None //TODO
    );
    
    /// <summary>
    /// Maps the Domain representation of the Client entity to the Http representation of the Client entity
    /// </summary>
    /// <param name="client">The Domain client entity</param>
    /// <returns>Https representation of the client entity</returns>
    public static ClientResponse Create(Core.Client client) => new ClientResponse
    {
        ClientId = client.ClientId.Value,
        Address = CommonModelFactory.Create(client.Address)
    };
}