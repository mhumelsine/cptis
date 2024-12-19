namespace Cptis.Core;

public record BirthDate
{
    public static BirthDate None = new(DateTime.Now);
    public readonly DateTime? Date;
    public readonly bool Verified;

    private const int MaximumYearsInDays = 130 * 365; //approximately 130 years old

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