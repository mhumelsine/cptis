namespace Cptis.Core;

/// <summary>
/// Represents a birthdate
/// </summary>
public record BirthDate
{
    /// <summary>
    /// Represents an uninitialized birthdate
    /// </summary>
    public static BirthDate None = new(DateTime.MinValue);
    
    /// <summary>
    /// The Date
    /// </summary>
    public readonly DateTime? Date;
    
    /// <summary>
    /// Has the BirthDate been verified
    /// </summary>
    public readonly bool Verified;

    //approximately 130 years old - the maximum span we think is valid
    private const int MaximumYearsInDays = 130 * 365;

    /// <summary>
    /// Only to support None
    /// </summary>
    /// <param name="date">Date value</param>
    private BirthDate(DateTime? date)
    {
        Date = date;
        Verified = false;
    }

    /// <summary>
    /// Creates a BirthDate from DateTime
    /// </summary>
    /// <param name="date">The date of birth</param>
    /// <param name="verified">If the date of birth has been verified</param>
    /// <exception cref="ArgumentException">Thrown when the date violates business rules</exception>
    public BirthDate(DateTime? date, bool verified = false)
    {
        var diff = DateTime.Now.Subtract(date ?? DateTime.Now).Days;

        Date = diff switch
        {
            > MaximumYearsInDays => throw new ArgumentException($"Birth Date puts age at '{diff / 365}' years old"),
            < 0 => throw new ArgumentException($"Birth Date cannot be in the future"),
            _ => date
        };
        
        Verified = verified;
    }
}