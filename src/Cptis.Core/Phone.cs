using System.Text.RegularExpressions;

namespace Cptis.Core;

/// <summary>
/// Represents a domestic phone number
/// </summary>
public record PhoneNumber
{
    private static readonly Regex __phoneNumberPattern =
        new(@"\(?(?<areaCode>\d{3})\)?[-\.\s]?(?<phone3>\d{3})[-\.\s]?(?<phone4>\d{4})((\s*[xX\s]\s*)(?<ext>\d+))?");

    private static readonly Regex __digitsPattern =
        new(@"^\d+$");

    /// <summary>
    /// The 3-digit area code
    /// </summary>
    public readonly string AreaCode;
    
    /// <summary>
    /// The 7-digit phone number
    /// </summary>
    public readonly string Number;
    
    /// <summary>
    /// The extension if applicable
    /// </summary>
    public readonly string? Extension;

    /// <summary>
    /// Represents invalid or uninitialized phone number
    /// </summary>
    public static readonly PhoneNumber None = new();

    /// <summary>
    /// Creates a default empty instance of phone #
    /// </summary>
    private PhoneNumber()
    {
        AreaCode = string.Empty;
        Number = string.Empty;
        Extension = null;
    }
    
    /// <summary>
    /// Create a phone number instance from the parts
    /// </summary>
    /// <param name="areaCode">3-digit area code</param>
    /// <param name="number">7-digit number</param>
    /// <param name="extension">number only extension</param>
    /// <exception cref="ArgumentException">Thrown when one of the parts is missing or in an invalid format</exception>
    private PhoneNumber(string areaCode, string number, string? extension)
    {
        if (!IsValid(areaCode, 3))
        {
            throw new ArgumentException($"Invalid area code: '{areaCode}'", nameof(areaCode));
        }

        if (!IsValid(number, 7))
        {
            throw new ArgumentException($"Invalid phone number: '{number}'", nameof(number));
        }
        
        if (extension != null && !__digitsPattern.IsMatch(extension))
        {
            throw new ArgumentException($"Invalid extension: '{extension}'", nameof(extension));
        }

        AreaCode = areaCode;
        Number = number;
        Extension = extension;
    }

    /// <summary>
    /// Creates an instance of PhoneNumber from a string
    /// </summary>
    /// <param name="phoneNumberString">The string containing the phone#</param>
    /// <returns>A new PhoneNumber instance or PhoneNumber.None is missing or invalid value</returns>
    public static PhoneNumber FromString(string? phoneNumberString)
    {
        if(phoneNumberString == null) return None;
        
        var match = __phoneNumberPattern.Match(phoneNumberString);

        if (!match.Success) return None;

        var area = match.Groups["areaCode"].Value;
        var phone3 = match.Groups["phone3"].Value;
        var phone4 = match.Groups["phone4"].Value;
        var ext = match.Groups["ext"].Value;

        return new PhoneNumber(area, $"{phone3}{phone4}", ext);
    }

    private bool IsValid(string number, int expectedLength) =>
        __digitsPattern.IsMatch(number)
        && number.Length == expectedLength;
}