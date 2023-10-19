namespace Poker.Domain.Classic;

public static class HandDefinitions
{
    public static HandDefinition NoHand { get; } = new HandDefinition
    {
        Name = "Empty",
        Value = 0,
        ImpersonateContributing = false
    };

    public static HandDefinition HighCard { get; } = new HandDefinition
    {
        Name = "High Card",
        Value = 1,
        ImpersonateContributing = false
    };

    public static HandDefinition Pair { get; } = new HandDefinition
    {
        Name = "Pair",
        Value = 2,
        ImpersonateContributing = false
    };

    public static HandDefinition TwoPair { get; } = new HandDefinition
    {
        Name = "Two Pair",
        Value = 3,
        ImpersonateContributing = false
    };

    public static HandDefinition ThreeOfAKind { get; } = new HandDefinition
    {
        Name = "Three of a Kind",
        Value = 4,
        ImpersonateContributing = false
    };

    public static HandDefinition Straight { get; } = new HandDefinition
    {
        Name = "Straight",
        Value = 5,
        ImpersonateContributing = false
    };

    public static HandDefinition Flush { get; } = new HandDefinition
    {
        Name = "Flush",
        Value = 6,
        ImpersonateContributing = false
    };

    public static HandDefinition FullHouse { get; } = new HandDefinition
    {
        Name = "Full House",
        Value = 7,
        ImpersonateContributing = false
    };

    public static HandDefinition FourOfAKind { get; } = new HandDefinition
    {
        Name = "Four of a Kind",
        Value = 8,
        ImpersonateContributing = false
    };

    public static HandDefinition StraightFlush { get; } = new HandDefinition
    {
        Name = "Straight Flush",
        Value = 9,
        ImpersonateContributing = false
    };

    public static HandDefinition RoyalFlush { get; } = new HandDefinition
    {
        Name = "Royal Flush",
        Value = 10,
        ImpersonateContributing = false
    };

    public static HandDefinition FiveOfAKind { get; } = new HandDefinition
    {
        Name = "Five of a Kind",
        Value = 11,
        ImpersonateContributing = true
    };

    public static List<HandDefinition> All { get; } = new(){
        HighCard,
        Pair,
        TwoPair,
        ThreeOfAKind,
        Straight,
        Flush,
        FullHouse,
        FourOfAKind,
        StraightFlush,
        RoyalFlush,
        FiveOfAKind
    };
}
