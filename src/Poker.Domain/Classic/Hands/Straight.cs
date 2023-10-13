namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand SixHighStraight { get; } = new Hand
    {
        Name = "Six High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand SevenHighStraight { get; } = new Hand
    {
        Name = "Seven High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand EightHighStraight { get; } = new Hand
    {
        Name = "Eight High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand NineHighStraight { get; } = new Hand
    {
        Name = "Nine High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand TenHighStraight { get; } = new Hand
    {
        Name = "Ten High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand JackHighStraight { get; } = new Hand
    {
        Name = "Jack High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand QueenHighStraight { get; } = new Hand
    {
        Name = "Queen High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand KingHighStraight { get; } = new Hand
    {
        Name = "King High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand AceHighStraight { get; } = new Hand
    {
        Name = "Ace High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = new List<Card> { Cards.All.Single(c => c.Rank == Ranks.Ace) }
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static List<Hand> AllStraights { get; } = new()
    {
        SixHighStraight,
        SevenHighStraight,
        EightHighStraight,
        NineHighStraight,
        TenHighStraight,
        JackHighStraight,
        QueenHighStraight,
        KingHighStraight,
        AceHighStraight
    };
}
