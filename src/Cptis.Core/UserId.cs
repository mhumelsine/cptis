namespace Cptis.Core;

/// <summary>
/// Represents a User's ID
/// </summary>
/// <param name="Value">Integer UserId</param>
public record UserId(int Value)
{
    /// <summary>
    /// Represents an invalid or uninitialized UserId
    /// </summary>
    public static readonly UserId None = new(0);
}