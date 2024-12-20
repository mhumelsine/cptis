namespace Cptis.Core;

/// <summary>
/// Represents a US address
/// </summary>
/// <param name="Street">The street address line 1</param>
/// <param name="City">The name of the city</param>
/// <param name="State">The 2 character state code</param>
/// <param name="Zip">The 5 or 9-digit zip code</param>
/// <param name="County">The county</param>
/// <param name="Country">The country</param>
public record Address(
    string? Street = null, 
    string? City = null, 
    string? State = null, 
    string? Zip = null, 
    string? County = null, 
    string? Country = null
);