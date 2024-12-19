using Cptis.Api.Models;
using FluentValidation;

namespace Cptis.Api.Endpoints.Client.V1.Requests;

public record CreateClientRequest
{
    public required string ClientId { get; init; }
    public required Address Address { get; init; }
}


public class CreateClientRequestValidator : AbstractValidator<CreateClientRequest>
{
    public CreateClientRequestValidator()
    {
        RuleFor(x => x.Address)
            .SetValidator(new AddressValidator());
        
        RuleFor(x => x.ClientId)
            .NotEmpty()
            .Length(6, 15); 
    }
}