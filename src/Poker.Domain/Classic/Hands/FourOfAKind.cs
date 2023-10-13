namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand FourTwos { get; } = new Hand
    {
        Name = "Four Twos",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand FourThrees { get; } = new Hand
    {
        Name = "Four Threes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand FourFours { get; } = new Hand
    {
        Name = "Four Fours",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand FourFives { get; } = new Hand
    {
        Name = "Four Fives",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand FourSixes { get; } = new Hand
    {
        Name = "Four Sixes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand FourSevens { get; } = new Hand
    {
        Name = "Four Sevens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand FourEights { get; } = new Hand
    {
        Name = "Four Eights",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand FourNines { get; } = new Hand
    {
        Name = "Four Nines",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand FourTens { get; } = new Hand
    {
        Name = "Four Tens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static Hand FourJacks { get; } = new Hand
    {
        Name = "Four Jacks",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static Hand FourQueens { get; } = new Hand
    {
        Name = "Four Queens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static Hand FourKings { get; } = new Hand
    {
        Name = "Four Kings",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            }
        }
    };

    public static Hand FourAces { get; } = new Hand
    {
        Name = "Four Aces",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
            }
        }
    };

    public static List<Hand> AllFourOfAKind { get; } = new()
    {
        FourTwos,
        FourThrees,
        FourFours,
        FourFives,
        FourSixes,
        FourSevens,
        FourEights,
        FourNines,
        FourTens,
        FourJacks,
        FourQueens,
        FourKings,
        FourAces
    };
}
