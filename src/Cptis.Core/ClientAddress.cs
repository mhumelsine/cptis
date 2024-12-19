namespace Cptis.Core;

public class ClientAddress()
{
    public int ClientAddressKey { get; set; }
    public Address Address { get; set; } = new();

    public Audit Audit { get; set; } = new();
}