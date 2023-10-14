namespace Poker.Domain.Classic.Hands;

public record AllHands
{
    public static List<Hand> All { get; } =
        HighCards.AllHighCards
        .Concat(Pairs.All)
        .Concat(TwoPair.All)
        .Concat(ThreeOfAKind.All)
        .Concat(Straights.All)
        .Concat(Flushes.All)
        .Concat(FullHouses.All)
        .Concat(FourOfAKind.All)
        .Concat(StraightFlushes.All)
        .Concat(RoyalFlushes.All)
        .Concat(FiveOfAKind.All)
        .ToList();
}
