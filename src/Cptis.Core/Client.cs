namespace Cptis.Core;

public class Client
{
    public int ClientKey { get; set; }
    public ClientId ClientId { get; set; }
    public Name Name { get; set; }
    public BirthDate BirthDate { get; set; }
    public DateTime? DeathDate { get; set; }
    public Audit Audit { get; set; } = new();
    public Address Address { get; set; } = new();

    public ICollection<ClientAddress> PreviousAddresses { get; set; } = [];

    public Client(ClientId id, Name name, BirthDate birthDate)
    {
        ClientId = id;
        Name = name;
        BirthDate = birthDate;
    }

    public Client()
    {
        ClientId = ClientId.None;
        Name = Name.None;
        BirthDate = BirthDate.None;
    }
}