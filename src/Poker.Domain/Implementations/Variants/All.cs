namespace Poker.Domain.Implementations.Variants;

public static class AllVariants
{
    /// <summary>
    /// The variants a match can be played as.
    /// </summary>
    public static IReadOnlyList<Variant> All { get; } =
    [
        FiveCardDraw.GetVariant(),
        SevenCardStud.GetVariant(),
        TexasHoldEm.GetVariant()
    ];
}
