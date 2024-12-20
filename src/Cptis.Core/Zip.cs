using System.Text.RegularExpressions;

namespace Cptis.Core;

/// <summary>
/// Represents a US Postal Code (Zip Code).
/// </summary>
/// <param name="Code">The primary 5 digits</param>
/// <param name="Plus4">The additional 4 digits of precision</param>
public record Zip(string? Code, string? Plus4)
{
    /// <summary>
    /// Validate zip code pattern used for parsing zip codes from string
    /// </summary>
    private static Regex _pattern = new(@"^(?<zip>\d{5})(-?(?<plus4>\d{4}))?$", RegexOptions.Compiled);
    
    /// <summary>
    /// Represents a missing or invalid Zip Code
    /// </summary>
    public static Zip None = new(null, null);

    /// <summary>
    /// The full value of the zip.  9-digit zip if available; otherwise the 5-digit zip
    /// </summary>
    public string? Value => Plus4 != null ? $"{Code}-{Plus4}" : Code;
    
    /// <summary>
    /// Creates an instance of ZipCode from the input string.  Supported formats are:
    /// 32309, 32309-1234, 323091234
    /// </summary>
    /// <param name="zip">The string representation of the zip code</param>
    /// <returns>Instance of ZipCode when the format is valid; ZipCode.None otherwise.</returns>
    public static Zip FromString(string? zip)
    {
        if (string.IsNullOrWhiteSpace(zip)) return None;

        var match = _pattern.Match(zip);

        if (!match.Success) return None;

        var plus4 = match.Groups["plus4"].Value;

        return new Zip(match.Groups["zip"].Value, string.IsNullOrWhiteSpace(plus4) ? null : plus4);
    }

    private Zip() : this(null, null)
    {
    }
}