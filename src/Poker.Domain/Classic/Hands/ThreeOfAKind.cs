namespace Poker.Domain.Classic.Hands;

public static class ThreeOfAKind
{
    public static Hand Twos { get; } = new()
    {
        Name = "Three Twos",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand Threes { get; } = new()
    {
        Name = "Three Threes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand Fours { get; } = new()
    {
        Name = "Three Fours",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand Fives { get; } = new()
    {
        Name = "Three Fives",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand Sixes { get; } = new()
    {
        Name = "Three Sixes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand Sevens { get; } = new()
    {
        Name = "Three Sevens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand Eights { get; } = new()
    {
        Name = "Three Eights",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand Nines { get; } = new()
    {
        Name = "Three Nines",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand Tens { get; } = new()
    {
        Name = "Three Tens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static Hand Jacks { get; } = new()
    {
        Name = "Three Jacks",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static Hand Queens { get; } = new()
    {
        Name = "Three Queens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static Hand Kings { get; } = new()
    {
        Name = "Three Kings",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            }
        }
    };

    public static Hand Aces { get; } = new()
    {
        Name = "Three Aces",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
            }
        }
    };

    public static List<Hand> All { get; } = new()
    {
        Twos,
        Threes,
        Fours,
        Fives,
        Sixes,
        Sevens,
        Eights,
        Nines,
        Tens,
        Jacks,
        Queens,
        Kings,
        Aces
    };
}
