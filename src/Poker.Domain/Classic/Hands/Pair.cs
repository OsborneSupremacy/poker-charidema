namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand PairOfTwos { get; } = new Hand
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

    public static Hand PairOfThrees { get; } = new Hand
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

    public static Hand PairOfFours { get; } = new Hand
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

    public static Hand PairOfFives { get; } = new Hand
    {
        Name = "Pair of Fives",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList() } }
    };

    public static Hand PairOfSixes { get; } = new Hand
    {
        Name = "Pair of Sixes",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList() } }
    };

    public static Hand PairOfSevens { get; } = new Hand
    {
        Name = "Pair of Sevens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList() } }
    };

    public static Hand PairOfEights { get; } = new Hand
    {
        Name = "Pair of Eights",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList() } }
    };

    public static Hand PairOfNines { get; } = new Hand
    {
        Name = "Pair of Nines",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList() } }
    };

    public static Hand PairOfTens { get; } = new Hand
    {
        Name = "Pair of Tens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList() } }
    };

    public static Hand PairOfJacks { get; } = new Hand
    {
        Name = "Pair of Jacks",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList() } }
    };

    public static Hand PairOfQueens { get; } = new Hand
    {
        Name = "Pair of Queens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList() } }
    };

    public static Hand PairOfKings { get; } = new Hand
    {
        Name = "Pair of Kings",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.King).ToList() } }
    };

    public static Hand PairOfAces { get; } = new Hand
    {
        Name = "Pair of Aces",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment> { new() { RequiredCount = 2, EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList() } }
    };

    public static List<Hand> AllPairs { get; } = new()
    {
        PairOfTwos,
        PairOfThrees,
        PairOfFours,
        PairOfFives,
        PairOfSixes,
        PairOfSevens,
        PairOfEights,
        PairOfNines,
        PairOfTens,
        PairOfJacks,
        PairOfQueens,
        PairOfKings,
        PairOfAces
    };
}
