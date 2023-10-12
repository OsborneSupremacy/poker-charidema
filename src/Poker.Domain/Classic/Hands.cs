using Poker.Domain.Implementations;

namespace Poker.Domain.Classic;

public record Hands
{
    public static Hand NoHand { get; } = new Hand
    {
        Name = "Empty",
        Value = 0,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.NoHandQualifier
    };

    public static Hand HighCard { get; } = new Hand
    {
        Name = "High Card",
        Value = 1,
        PrimaryMatchesCount = 1,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static Hand Pair { get; } = new Hand
    {
        Name = "Pair",
        Value = 2,
        PrimaryMatchesCount = 2,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static Hand TwoPair { get; } = new Hand
    {
        Name = "Two Pair",
        Value = 3,
        PrimaryMatchesCount = 2,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.TwoPairHandQualifier
    };

    public static Hand ThreeOfAKind { get; } = new Hand
    {
        Name = "Three of a Kind",
        Value = 4,
        PrimaryMatchesCount = 3,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static Hand Straight { get; } = new Hand
    {
        Name = "Straight",
        Value = 5,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.StraightHandQualifier
    };

    public static Hand Flush { get; } = new Hand
    {
        Name = "Flush",
        Value = 6,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.FlushHandQualifier
    };

    public static Hand FullHouse { get; } = new Hand
    {
        Name = "Full House",
        Value = 7,
        PrimaryMatchesCount = 3,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.FullHouseHandQualifier
    };

    public static Hand FourOfAKind { get; } = new Hand
    {
        Name = "Four of a Kind",
        Value = 8,
        PrimaryMatchesCount = 4,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static Hand StraightFlush { get; } = new Hand
    {
        Name = "Straight Flush",
        Value = 9,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.StraightFlushHandQualifier
    };

    public static Hand RoyalFlush { get; } = new Hand
    {
        Name = "Royal Flush",
        Value = 10,
        PrimaryMatchesCount = 0,
        ImpersonateContributing = false,
        HandQualifier = HandQualifierDelegates.RoyalFlushHandQualifier
    };

    public static Hand FiveOfAKind { get; } = new Hand
    {
        Name = "Five of a Kind",
        Value = 11,
        PrimaryMatchesCount = 5,
        ImpersonateContributing = true,
        HandQualifier = HandQualifierDelegates.MatchingRankHandQualifier
    };

    public static List<Hand> All { get; } = new(){
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
