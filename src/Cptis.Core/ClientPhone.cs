namespace Cptis.Core;

/// <summary>
/// Represents a client's phone information
/// </summary>
public class ClientPhone
{
    /// <summary>
    /// Unique identifier for the client phone entry
    /// </summary>
    public int ClientPhoneId { get; set; }

    /// <summary>
    /// The first date and time the address is active
    /// </summary>
    public DateTime ValidFrom { get; set; } = DateTime.Now;
    
    /// <summary>
    /// The date and time the address stopped being active
    /// </summary>
    public DateTime ValidTo { get; set; } = DateTime.MaxValue;

    /// <summary>
    /// The phone number
    /// </summary>
    public PhoneNumber Phone { get; set; } = PhoneNumber.None;

    /// <summary>
    /// A description of the phone number like "Dad's work" or "home"
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Audit details about when the phone was created and modified
    /// </summary>
    public Audit Audit { get; set; } = new();

    //Navigation Properties
    /// <summary>
    /// Client who has the phone
    /// </summary>
    public ClientDemographic ClientDemographic { get; set; }
}