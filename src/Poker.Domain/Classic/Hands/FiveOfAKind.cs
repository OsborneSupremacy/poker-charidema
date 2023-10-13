namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand FiveTwos { get; } = new Hand
    {
        Name = "Five Twos",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand FiveThrees { get; } = new Hand
    {
        Name = "Five Threes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand FiveFours { get; } = new Hand
    {
        Name = "Five Fours",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand FiveFives { get; } = new Hand
    {
        Name = "Five Fives",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand FiveSixes { get; } = new Hand
    {
        Name = "Five Sixes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand FiveSevens { get; } = new Hand
    {
        Name = "Five Sevens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand FiveEights { get; } = new Hand
    {
        Name = "Five Eights",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand FiveNines { get; } = new Hand
    {
        Name = "Five Nines",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand FiveTens { get; } = new Hand
    {
        Name = "Five Tens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static Hand FiveJacks { get; } = new Hand
    {
        Name = "Five Jacks",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static Hand FiveQueens { get; } = new Hand
    {
        Name = "Five Queens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static Hand FiveKings { get; } = new Hand
    {
        Name = "Five Kings",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            }
        }
    };

    public static Hand FiveAces { get; } = new Hand
    {
        Name = "Five Aces",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
            }
        }
    };

    public static List<Hand> AllFiveOfAKind { get; } = new()
    {
        FiveTwos,
        FiveThrees,
        FiveFours,
        FiveFives,
        FiveSixes,
        FiveSevens,
        FiveEights,
        FiveNines,
        FiveTens,
        FiveJacks,
        FiveQueens,
        FiveKings,
        FiveAces
    };
}
