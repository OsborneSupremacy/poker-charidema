namespace Poker.Domain.Classic;

public record Hands
{
    public static Hand NoHand { get; } = new Hand
    {
        Name = "Empty",
        Value = 0,
        PrimaryMatchesCount = 0,
        SecondaryMatchesCount = 0,
        Sequence = false,
        Uniform = false,
        SequenceMinRank = Ranks.Empty
    };

    public static Hand HighCard { get; } = new Hand
    {
        Name = "High Card",
        Value = 1,
        PrimaryMatchesCount = 1,
        SecondaryMatchesCount = 0,
        Sequence = false,
        Uniform = false,
        SequenceMinRank = Ranks.Empty
    };

    public static Hand Pair { get; } = new Hand
    {
        Name = "Pair",
        Value = 2,
        PrimaryMatchesCount = 2,
        SecondaryMatchesCount = 0,
        Sequence = false,
        Uniform = false,
        SequenceMinRank = Ranks.Empty
    };

    public static Hand TwoPair { get; } = new Hand
    {
        Name = "Two Pair",
        Value = 3,
        PrimaryMatchesCount = 2,
        SecondaryMatchesCount = 2,
        Sequence = false,
        Uniform = false,
        SequenceMinRank = Ranks.Empty
    };

    public static Hand ThreeOfAKind { get; } = new Hand
    {
        Name = "Three of a Kind",
        Value = 4,
        PrimaryMatchesCount = 3,
        SecondaryMatchesCount = 0,
        Sequence = false,
        Uniform = false,
        SequenceMinRank = Ranks.Empty
    };

    public static Hand Straight { get; } = new Hand
    {
        Name = "Straight",
        Value = 5,
        PrimaryMatchesCount = 0,
        SecondaryMatchesCount = 0,
        Sequence = true,
        Uniform = false,
        SequenceMinRank = Ranks.Two
    };

    public static Hand Flush { get; } = new Hand
    {
        Name = "Flush",
        Value = 6,
        PrimaryMatchesCount = 0,
        SecondaryMatchesCount = 0,
        Sequence = false,
        Uniform = true,
        SequenceMinRank = Ranks.Empty
    };

    public static Hand FullHouse { get; } = new Hand
    {
        Name = "Full House",
        Value = 7,
        PrimaryMatchesCount = 3,
        SecondaryMatchesCount = 2,
        Sequence = false,
        Uniform = false,
        SequenceMinRank = Ranks.Empty
    };

    public static Hand FourOfAKind { get; } = new Hand
    {
        Name = "Four of a Kind",
        Value = 8,
        PrimaryMatchesCount = 4,
        SecondaryMatchesCount = 0,
        Sequence = false,
        Uniform = false,
        SequenceMinRank = Ranks.Empty
    };

    public static Hand StraightFlush { get; } = new Hand
    {
        Name = "Straight Flush",
        Value = 9,
        PrimaryMatchesCount = 0,
        SecondaryMatchesCount = 0,
        Sequence = true,
        Uniform = true,
        SequenceMinRank = Ranks.Two
    };

    public static Hand RoyalFlush { get; } = new Hand
    {
        Name = "Royal Flush",
        Value = 10,
        PrimaryMatchesCount = 0,
        SecondaryMatchesCount = 0,
        Sequence = true,
        Uniform = true,
        SequenceMinRank = Ranks.Ten
    };

    public static Hand FiveOfAKind { get; } = new Hand
    {
        Name = "Five of a Kind",
        Value = 11,
        PrimaryMatchesCount = 5,
        SecondaryMatchesCount = 0,
        Sequence = false,
        Uniform = false,
        SequenceMinRank = Ranks.Empty
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
