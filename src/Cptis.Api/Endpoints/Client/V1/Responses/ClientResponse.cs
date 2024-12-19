using Cptis.Api.Models;

namespace Cptis.Api.Endpoints.Client.V1.Responses;

public record ClientResponse
{
    public string ClientId { get; set; }
    public Address Address { get; set; }
}