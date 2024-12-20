namespace Cptis.Core;

public record NameSuffix
{
    private static readonly HashSet<string> __validSuffixes = ["JR", "SR", "I", "II", "III", "IV", "V", "VI"];
    
    /// <summary>
    /// Represents an invalid or uninitialized suffix
    /// </summary>
    public static readonly NameSuffix None = new(value: null);

    /// <summary>
    /// The suffix value
    /// </summary>
    public readonly string? Value;

    /// <summary>
    /// Creates a suffix from a string
    /// </summary>
    /// <param name="value">The string value of the suffix</param>
    /// <exception cref="ArgumentException">Thrown if the string value does not represent a valid suffix.</exception>
    public NameSuffix(string? value)
    {
        var ok = value == null || IsValidSuffix(value);
        if (!ok) throw new ArgumentException($"Value '{value}' is not a valid suffix", nameof(value));

        Value = value;
    }

    /// <summary>
    /// Safely creates an instance of NameSuffix from a string.  Results NameSuffix.None if value is invalid or missing.
    /// </summary>
    /// <param name="value">The string representation of the suffix</param>
    /// <returns>NameSuffix instance; NameSuffix.None if value is invalid or missing.</returns>
    public static NameSuffix FromString(string? value) =>
        IsValidSuffix(value)
            ? new NameSuffix(value)
            : None;

    private static bool IsValidSuffix(string? value) =>
        value != null && __validSuffixes.Contains(value.ToUpper());
}