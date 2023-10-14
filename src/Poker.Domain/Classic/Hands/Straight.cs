namespace Poker.Domain.Classic.Hands;

public record Straights
{
    public static Hand SixHigh { get; } = new Hand
    {
        Name = "Six High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand SevenHigh { get; } = new Hand
    {
        Name = "Seven High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand EightHigh { get; } = new Hand
    {
        Name = "Eight High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand NineHigh { get; } = new Hand
    {
        Name = "Nine High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand TenHigh { get; } = new Hand
    {
        Name = "Ten High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand JackHigh { get; } = new Hand
    {
        Name = "Jack High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand QueenHigh { get; } = new Hand
    {
        Name = "Queen High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand KingHigh { get; } = new Hand
    {
        Name = "King High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand AceHigh { get; } = new Hand
    {
        Name = "Ace High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new List<Card> { Cards.All.Single(c => c.Rank == Ranks.Ace) }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static List<Hand> All { get; } = new()
    {
        SixHigh,
        SevenHigh,
        EightHigh,
        NineHigh,
        TenHigh,
        JackHigh,
        QueenHigh,
        KingHigh,
        AceHigh
    };
}
