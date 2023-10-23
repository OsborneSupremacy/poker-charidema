namespace Poker.Domain.Classic;

public static class HandDefinitions
{
    public static HandDefinition NoHand { get; } = new()
    {
        Name = "Empty",
        Value = 0,
        ImpersonateContributing = false
    };

    public static HandDefinition HighCard { get; } = new()
    {
        Name = "High Card",
        Value = 1,
        ImpersonateContributing = false
    };

    public static HandDefinition Pair { get; } = new()
    {
        Name = "Pair",
        Value = 2,
        ImpersonateContributing = false
    };

    public static HandDefinition TwoPair { get; } = new()
    {
        Name = "Two Pair",
        Value = 3,
        ImpersonateContributing = false
    };

    public static HandDefinition ThreeOfAKind { get; } = new()
    {
        Name = "Three of a Kind",
        Value = 4,
        ImpersonateContributing = false
    };

    public static HandDefinition Straight { get; } = new()
    {
        Name = "Straight",
        Value = 5,
        ImpersonateContributing = false
    };

    public static HandDefinition Flush { get; } = new()
    {
        Name = "Flush",
        Value = 6,
        ImpersonateContributing = false
    };

    public static HandDefinition FullHouse { get; } = new()
    {
        Name = "Full House",
        Value = 7,
        ImpersonateContributing = false
    };

    public static HandDefinition FourOfAKind { get; } = new()
    {
        Name = "Four of a Kind",
        Value = 8,
        ImpersonateContributing = false
    };

    public static HandDefinition StraightFlush { get; } = new()
    {
        Name = "Straight Flush",
        Value = 9,
        ImpersonateContributing = false
    };

    public static HandDefinition RoyalFlush { get; } = new()
    {
        Name = "Royal Flush",
        Value = 10,
        ImpersonateContributing = false
    };

    public static HandDefinition FiveOfAKind { get; } = new()
    {
        Name = "Five of a Kind",
        Value = 11,
        ImpersonateContributing = true
    };

    public static List<HandDefinition> All { get; } = new(){
        NoHand,
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
