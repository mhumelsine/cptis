namespace Cptis.Core;

/// <summary>
/// Represents a Person's name
/// </summary>
/// <param name="First">First name</param>
/// <param name="Middle">Middle name</param>
/// <param name="Last">Last name</param>
/// <param name="Suffix">Suffix</param>
public record Name(string First, string? Middle, string Last, string? Suffix)
{
    /// <summary>
    /// Represents an uninitialized name
    /// </summary>
    public static readonly Name None = new Name("", null, "", null);
}