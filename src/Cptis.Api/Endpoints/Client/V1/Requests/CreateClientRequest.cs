using Cptis.Api.Models;
using FluentValidation;

namespace Cptis.Api.Endpoints.Client.V1.Requests;

/// <summary>
/// Represents a request to create a Client
/// </summary>
public record CreateClientRequest
{
    /// <summary>
    /// The Client ID
    /// </summary>
    public required string ClientId { get; init; }
    
    /// <summary>
    /// The Address of the client
    /// </summary>
    public required Address Address { get; init; }
}

/// <summary>
/// Describes the CreateClientRequest validations
/// </summary>
public class CreateClientRequestValidator : AbstractValidator<CreateClientRequest>
{
    /// <summary>
    /// Creates an instance of the validator
    /// </summary>
    public CreateClientRequestValidator()
    {
        // reference the central address validator
        RuleFor(x => x.Address)
            .SetValidator(new AddressValidator());
        
        RuleFor(x => x.ClientId)
            .NotEmpty()
            .Length(6, 15); 
    }
}