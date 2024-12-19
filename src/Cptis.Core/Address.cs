namespace Cptis.Core;

/// <summary>
/// 
/// </summary>
/// <param name="Street"></param>
/// <param name="City"></param>
/// <param name="State"></param>
/// <param name="Zip"></param>
/// <param name="County"></param>
/// <param name="Country"></param>
public record Address(
    string? Street = null, 
    string? City = null, 
    string? State = null, 
    string? Zip = null, 
    string? County = null, 
    string? Country = null
);