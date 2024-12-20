using FluentValidation;

namespace Cptis.Api.Models;

/// <summary>
/// Represents an US address
/// </summary>
public record Address
{
    /// <summary>
    /// Street line 1
    /// </summary>
    public string? Street { get; init; }

    /// <summary>
    /// City name
    /// </summary>
    public string? City { get; init; }

    /// <summary>
    /// 2 character state code
    /// </summary>
    public string? State { get; init; }

    /// <summary>
    /// The 5 or 9-digit zip code
    /// </summary>
    public string? Zip { get; init; }
}

/// <summary>
/// Represents a validator to enforce requirements on address fields for validation
/// </summary>
public class AddressValidator : AbstractValidator<Address>
{
    /// <summary>
    /// Standard constructor, configures FluentValidation for our IAddress model
    /// </summary>
    public AddressValidator()
    {
        RuleFor(e => e.Street)
            .MaximumLength(120);

        RuleFor(e => e.City)
            .MaximumLength(64);

        RuleFor(e => e.State)
            .MaximumLength(2);

        RuleFor(e => e.Zip)
            .MaximumLength(10)
            .Matches(@"\d{5}-\d{4}");

        When(x => string.IsNullOrWhiteSpace(x.Zip), () =>
        {
            RuleFor(x => x.City)
                .NotEmpty();

            RuleFor(x => x.State)
                .NotEmpty();
        });

        When(x => string.IsNullOrWhiteSpace(x.City) || string.IsNullOrWhiteSpace(x.State), () =>
        {
            RuleFor(x => x.Zip)
                .NotEmpty();
        });
    }
}