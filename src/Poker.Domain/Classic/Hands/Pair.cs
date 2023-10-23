namespace Poker.Domain.Classic.Hands;

public static class Pairs
{
    public static Hand Twos { get; } = new()
    {
        Name = "Pair of Twos",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand Threes { get; } = new()
    {
        Name = "Pair of Threes",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand Fours { get; } = new()
    {
        Name = "Pair of Fours",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand Fives { get; } = new()
    {
        Name = "Pair of Fives",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList() } }
    };

    public static Hand Sixes { get; } = new()
    {
        Name = "Pair of Sixes",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList() } }
    };

    public static Hand Sevens { get; } = new()
    {
        Name = "Pair of Sevens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList() } }
    };

    public static Hand Eights { get; } = new()
    {
        Name = "Pair of Eights",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList() } }
    };

    public static Hand Nines { get; } = new()
    {
        Name = "Pair of Nines",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList() } }
    };

    public static Hand Tens { get; } = new()
    {
        Name = "Pair of Tens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList() } }
    };

    public static Hand Jacks { get; } = new()
    {
        Name = "Pair of Jacks",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList() } }
    };

    public static Hand Queens { get; } = new()
    {
        Name = "Pair of Queens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList() } }
    };

    public static Hand Kings { get; } = new()
    {
        Name = "Pair of Kings",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.King).ToList() } }
    };

    public static Hand Aces { get; } = new()
    {
        Name = "Pair of Aces",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList() } }
    };
}
