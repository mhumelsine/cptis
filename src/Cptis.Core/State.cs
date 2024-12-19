namespace Cptis.Core;

/// <summary>
/// Represents a US State
/// </summary>
public record State
{
    /// <summary>
    /// Static lookup for state abbreviations to state names
    /// </summary>
    private static readonly Dictionary<string, string> Lookup = new()
    {
        {"AL", "Alabama"},
        {"AK", "Alaska"},
        {"AZ", "Arizona"},
        {"AR", "Arkansas"},
        {"CA", "California"},
        {"CO", "Colorado"},
        {"CT", "Connecticut"},
        {"DE", "Delaware"},
        {"DC", "District of Columbia"},
        {"FL", "Florida"},
        {"GA", "Georgia"},
        {"HI", "Hawaii"},
        {"ID", "Idaho"},
        {"IL", "Illinois"},
        {"IN", "Indiana"},
        {"IA", "Iowa"},
        {"KS", "Kansas"},
        {"KY", "Kentucky"},
        {"LA", "Louisiana"},
        {"ME", "Maine"},
        {"MD", "Maryland"},
        {"MA", "Massachusetts"},
        {"MI", "Michigan"},
        {"MN", "Minnesota"},
        {"MS", "Mississippi"},
        {"MO", "Missouri"},
        {"MT", "Montana"},
        {"NE", "Nebraska"},
        {"NV", "Nevada"},
        {"NH", "New Hampshire"},
        {"NJ", "New Jersey"},
        {"NM", "New Mexico"},
        {"NY", "New York"},
        {"NC", "North Carolina"},
        {"ND", "North Dakota"},
        {"OH", "Ohio"},
        {"OK", "Oklahoma"},
        {"OR", "Oregon"},
        {"PA", "Pennsylvania"},
        {"RI", "Rhode Island"},
        {"SC", "South Carolina"},
        {"SD", "South Dakota"},
        {"TN", "Tennessee"},
        {"TX", "Texas"},
        {"UT", "Utah"},
        {"VT", "Vermont"},
        {"VA", "Virginia"},
        {"WA", "Washington"},
        {"WV", "West Virginia"},
        {"WI", "Wisconsin"},
        {"WY", "Wyoming"},
        {"", ""} //missing/invalid
    };
    
    /// <summary>
    /// Represents a missing or invalid State
    /// </summary>
    public static State None = new(string.Empty, string.Empty);

    /// <summary>
    /// Create a representation of a US State
    /// </summary>
    /// <param name="code">The 2 character state code</param>
    /// <param name="name">The full name of the state</param>
    public State(string code, string name)
    {
        if (!Lookup.TryGetValue(code, out var nameLookup)) throw new ArgumentOutOfRangeException($"Invalid state code '{code}'");
        Code = code;
        Name = nameLookup;
    }

    /// <summary>
    /// The 2 character state code
    /// </summary>
    public readonly string Code;

    // /// <summary>
    // /// The name of the state
    // /// </summary>
    public readonly string Name;

    /// <summary>
    /// Creates an instance of state using the 2 character state code
    /// </summary>
    /// <param name="code">The two character state code</param>
    /// <returns>Instance of state when valid state code; State.None otherwise</returns>
    public static State FromCode(string? code)
    {
        if (string.IsNullOrWhiteSpace(code)) return None;

        if (!Lookup.TryGetValue(code, out var name)) return None;

        return new State(code, name);
    }
}