using Poker.Domain.Implementations;

namespace Poker.Domain.Classic;

public record HandDefinitions
{
    public static HandDefinition NoHand { get; } = new HandDefinition
    {
        Name = "Empty",
        Value = 0,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.NoHandQualifier
    };

    public static HandDefinition HighCard { get; } = new HandDefinition
    {
        Name = "High Card",
        Value = 1,
        PrimaryMatchesCount = 1,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static HandDefinition Pair { get; } = new HandDefinition
    {
        Name = "Pair",
        Value = 2,
        PrimaryMatchesCount = 2,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static HandDefinition TwoPair { get; } = new HandDefinition
    {
        Name = "Two Pair",
        Value = 3,
        PrimaryMatchesCount = 2,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.TwoPairHandQualifier
    };

    public static HandDefinition ThreeOfAKind { get; } = new HandDefinition
    {
        Name = "Three of a Kind",
        Value = 4,
        PrimaryMatchesCount = 3,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static HandDefinition Straight { get; } = new HandDefinition
    {
        Name = "Straight",
        Value = 5,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.StraightHandQualifier
    };

    public static HandDefinition Flush { get; } = new HandDefinition
    {
        Name = "Flush",
        Value = 6,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.FlushHandQualifier
    };

    public static HandDefinition FullHouse { get; } = new HandDefinition
    {
        Name = "Full House",
        Value = 7,
        PrimaryMatchesCount = 3,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.FullHouseHandQualifier
    };

    public static HandDefinition FourOfAKind { get; } = new HandDefinition
    {
        Name = "Four of a Kind",
        Value = 8,
        PrimaryMatchesCount = 4,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static HandDefinition StraightFlush { get; } = new HandDefinition
    {
        Name = "Straight Flush",
        Value = 9,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.StraightFlushHandQualifier
    };

    public static HandDefinition RoyalFlush { get; } = new HandDefinition
    {
        Name = "Royal Flush",
        Value = 10,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.RoyalFlushHandQualifier
    };

    public static HandDefinition FiveOfAKind { get; } = new HandDefinition
    {
        Name = "Five of a Kind",
        Value = 11,
        PrimaryMatchesCount = 5,
        ImpersonateContributing = true,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
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
