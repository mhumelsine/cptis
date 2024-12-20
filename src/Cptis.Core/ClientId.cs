namespace Cptis.Core;

/// <summary>
/// The client ID
/// </summary>
/// <param name="Value">Id value</param>
public record ClientId(string Value)
{
    /// <summary>
    /// Represents a invalid or uninitialized ClientId
    /// </summary>
    public static readonly ClientId None = new(Value: "");
}