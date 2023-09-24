namespace Poker.Domain.Implementations;

public record class EmptyVariant
{
    public static Variant GetVariant() =>
        new()
        {
            Name = GlobalConstants.Empty,
            Phases = new()
        };
}
