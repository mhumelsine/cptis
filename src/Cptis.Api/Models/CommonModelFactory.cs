using Cptis.Core;

namespace Cptis.Api.Models;

/// <summary>
/// Maps objects common across endpoints from their http representations to the domain/value object representations and vice-versa
/// </summary>
public static class CommonModelFactory
{
    /// <summary>
    /// Maps a https representation of an address to the Address value object
    /// </summary>
    /// <param name="address">The http representation of the address</param>
    /// <returns>Address value object</returns>
    public static Core.Address Create(Address address) => new Core.Address(
        Street: address.Street,
        City: address.City,
        State: State.FromString(address.State),
        Zip: Zip.FromString(address.Zip)
    );

    /// <summary>
    /// Maps an Address value object ot a http representation of an address
    /// </summary>
    /// <param name="address">Address value object</param>
    /// <returns>The http representation of the address</returns>
    public static Address Create(Core.Address address) => new Address
    {
        Street = address.Street,
        City = address.City,
        State = address.State?.Code,
        Zip = address.Zip?.Value
    };
}