namespace Cptis.Core;

/// <summary>
/// Represents a client
/// </summary>
public class Client
{
    /// <summary>
    /// The system assigned unique identifier for the client
    /// </summary>
    public int ClientKey { get; set; }
    
    /// <summary>
    /// The client id
    /// </summary>
    public ClientId ClientId { get; set; }
    
    /// <summary>
    /// The client's name
    /// </summary>
    public Name Name { get; set; }
    
    /// <summary>
    /// The client's date of birth
    /// </summary>
    public BirthDate BirthDate { get; set; }
    
    /// <summary>
    /// The client's date of death, if death has occurred
    /// </summary>
    public DateTime? DeathDate { get; set; }
    
    /// <summary>
    /// Audit details about when the client was created and modified
    /// </summary>
    public Audit Audit { get; set; } = new();
    
    /// <summary>
    /// The client's current address
    /// </summary>
    public Address Address { get; set; } = new();

    /// <summary>
    /// The client's address history
    /// </summary>
    public ICollection<ClientAddress> AddressHistory { get; set; } = [];

    /// <summary>
    /// Creates a new client
    /// </summary>
    /// <param name="id">Client's ID</param>
    /// <param name="name">Client's name</param>
    /// <param name="birthDate">Client's birthdate</param>
    public Client(ClientId id, Name name, BirthDate birthDate)
    {
        ClientId = id;
        Name = name;
        BirthDate = birthDate;
    }
    
    /// <summary>
    /// To support EF
    /// </summary>
    private Client()
    {
        ClientId = ClientId.None;
        Name = Name.None;
        BirthDate = BirthDate.None;
    }
}