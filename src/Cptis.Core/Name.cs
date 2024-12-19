namespace Cptis.Core;

public record Name(string First, string? Middle, string Last, string? Suffix)
{
    public static Name None = new Name("", null, "", null);
}

public record Suffix
{
    private static HashSet<string> _validSuffixes = ["JR", "SR", "I", "II", "III", "IV", "V", "VI"];
    public static Suffix None = new(value: null);

    public readonly string? Value;

    public Suffix(string? value)
    {
        var ok = value == null || IsValidSuffix(value);
        if (!ok) throw new ArgumentException($"Value '{value}' is not a valid suffix", nameof(value));

        Value = value;
    }

    public static Suffix FromString(string? value) =>
        IsValidSuffix(value)
            ? new Suffix(value)
            : None;

    private static bool IsValidSuffix(string? value) =>
        value != null && _validSuffixes.Contains(value.ToUpper());
}