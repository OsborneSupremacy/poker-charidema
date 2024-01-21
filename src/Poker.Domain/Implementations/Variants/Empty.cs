namespace Poker.Domain.Implementations.Variants;

public static class EmptyVariant
{
    public static Variant GetVariant() =>
        new()
        {
            Name = GlobalConstants.Empty,
            Phases = []
        };
}
