namespace Cptis.Core;
public record UserId(int Value)
{
    public static UserId None = new(0);
}