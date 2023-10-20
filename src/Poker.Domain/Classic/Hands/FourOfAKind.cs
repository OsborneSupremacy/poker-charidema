namespace Poker.Domain.Classic.Hands;

public static class FourOfAKind
{
    public static Hand Twos { get; } = new Hand
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

    public static Hand Threes { get; } = new Hand
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

    public static Hand Fours { get; } = new Hand
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

    public static Hand Fives { get; } = new Hand
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

    public static Hand Sixes { get; } = new Hand
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

    public static Hand Sevens { get; } = new Hand
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

    public static Hand Eights { get; } = new Hand
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

    public static Hand Nines { get; } = new Hand
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

    public static Hand Tens { get; } = new Hand
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

    public static Hand Jacks { get; } = new Hand
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

    public static Hand Queens { get; } = new Hand
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

    public static Hand Kings { get; } = new Hand
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

    public static Hand Aces { get; } = new Hand
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
