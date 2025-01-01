namespace Cptis.Core;

/// <summary>
/// Represents a client address
/// </summary>
public class ClientAddress()
{
    /// <summary>
    /// Unique identifier of the address entry
    /// </summary>
    public int ClientAddressId { get; set; }
    
    /// <summary>
    /// The first date and time the address is active
    /// </summary>
    public DateTime ValidFrom { get; set; } = DateTime.Now;
    
    /// <summary>
    /// The date and time the address stopped being active
    /// </summary>
    public DateTime ValidTo { get; set; } = DateTime.MaxValue;
    
    /// <summary>
    /// The address
    /// </summary>
    public Address Address { get; set; } = new();

    /// <summary>
    /// Audit details about when the address was created and modified
    /// </summary>
    public Audit Audit { get; set; } = new();
}