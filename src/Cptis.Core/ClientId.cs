namespace Cptis.Core;
public record ClientId(string Value)
{
    public static ClientId None { get; set; } = new(Value: "");
}