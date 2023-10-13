namespace Poker.Domain.Classic;

public partial record Hands
{
    /// <summary>
    /// The null-forgiving operator shouldn't be necessary here, since these are all static methods.
    /// The compiler, for some reason, doesn't recognize that, but only for some of the "all" methods.
    /// I'm using the null-forgiving operator on all of them, for consistency..
    /// </summary>
    public static List<Hand> All { get; } =
        AllHighCards!
        .Union(AllPairs!)
        .Union(AllTwoPair!)
        .Union(AllThreeOfAKind!)
        .Union(AllStraights!)
        .Union(AllFlushes!)
        .Union(AllFullHouses!)
        .Union(AllFourOfAKind!)
        .Union(AllStraightFlushes!)
        .Union(AllRoyalFlushes!)
        .Union(AllFiveOfAKind!)
        .ToList();
}
