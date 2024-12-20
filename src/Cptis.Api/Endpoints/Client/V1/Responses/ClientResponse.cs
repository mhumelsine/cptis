using Cptis.Api.Models;

namespace Cptis.Api.Endpoints.Client.V1.Responses;

/// <summary>
/// Represents a Client
/// </summary>
public record ClientResponse
{
    /// <summary>
    /// Client ID
    /// </summary>
    public string ClientId { get; set; }
    
    /// <summary>
    /// The Client's current address
    /// </summary>
    public Address Address { get; set; }
}