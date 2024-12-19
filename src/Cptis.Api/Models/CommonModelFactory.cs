namespace Cptis.Api.Models;

public static class CommonModelFactory
{
    public static Core.Address Create(Address address) => new Core.Address(
        Street: address.Street,
        City: address.City,
        State: address.State,
        Zip: address.Zip
    );

    public static Address Create(Core.Address address) => new Address
    {
        Street = address.Street,
        City = address.City,
        State = address.State,
        Zip = address.Zip
    };
}