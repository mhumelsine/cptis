using System.Text.RegularExpressions;

namespace Cptis.Core;

public record PhoneNumber
{
    private static Regex _phoneNumberPattern = new(@"(?<areaCode>\(\d{3}\))\d{3}-\d{4}(?<ext>x\d+)?");
    
    public readonly string AreaCode;
    public readonly string Number;
    public readonly string? Extension;

    /// <summary>
    /// Represents invalid or uninitialized phone number
    /// </summary>
    public static readonly PhoneNumber None = new();

    public PhoneNumber()
    {
        AreaCode = string.Empty;
        Number = string.Empty;
        Extension = null;
    }

    private PhoneNumber(string areaCode, string number, string? extension)
    {
        AreaCode = areaCode;
        Number = number;
        Extension = extension;
    }

    public static PhoneNumber FromString(string phoneNumberString)
    {
        //TODO:  use regex to test the phone number
        
        return new PhoneNumber(phoneNumberString, "todo", "todo");
    }
}