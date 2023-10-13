namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand SixHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Six High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Two).WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand SevenHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Seven High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand EightHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Eight High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand NineHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Nine High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand TenHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Ten High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand JackHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Jack High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand QueenHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "Queen High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand KingHighSpadesStraightFlush { get; } = new Hand
    {
        Name = "King High Spades Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Spades,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.King).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Spades).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Spades).ToList()
            }
        }
    };

    public static Hand SixHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Six High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Two).WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand SevenHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Seven High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand EightHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Eight High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand NineHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Nine High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand TenHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Ten High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand JackHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Jack High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand QueenHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "Queen High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand KingHighHeartsStraightFlush { get; } = new Hand
    {
        Name = "King High Hearts Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Hearts,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.King).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Hearts).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Hearts).ToList()
            }
        }
    };

    public static Hand SixHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Six High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Two).WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static Hand SevenHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Seven High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static Hand EightHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Eight High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static Hand NineHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Nine High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static Hand TenHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Ten High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static Hand JackHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Jack High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static Hand QueenHighClubsStraightFlush { get; } = new Hand
    {
        Name = "Queen High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static Hand KingHighClubsStraightFlush { get; } = new Hand
    {
        Name = "King High Clubs Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Clubs,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.King).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Clubs).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Clubs).ToList()
            }
        }
    };

    public static Hand SixHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Six High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Two).WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand SevenHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Seven High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Three).WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand EightHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Eight High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Four).WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand NineHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Nine High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Five).WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand TenHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Ten High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Six).WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand JackHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Jack High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Seven).WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand QueenHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "Queen High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Eight).WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static Hand KingHighDiamondsStraightFlush { get; } = new Hand
    {
        Name = "King High Diamonds Straight Flush",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Diamonds,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.King).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Queen).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Jack).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Ten).WhereSuit(Suits.Diamonds).ToList()
            },
            new()
            {
                Count = 1,
                Cards = Cards.All.WhereRank(Ranks.Nine).WhereSuit(Suits.Diamonds).ToList()
            }
        }
    };

    public static List<Hand> AllStraightFlushes { get; } = new()
    {
        SixHighSpadesStraightFlush,
        SevenHighSpadesStraightFlush,
        EightHighSpadesStraightFlush,
        NineHighSpadesStraightFlush,
        TenHighSpadesStraightFlush,
        JackHighSpadesStraightFlush,
        QueenHighSpadesStraightFlush,
        KingHighSpadesStraightFlush,
        SixHighHeartsStraightFlush,
        SevenHighHeartsStraightFlush,
        EightHighHeartsStraightFlush,
        NineHighHeartsStraightFlush,
        TenHighHeartsStraightFlush,
        JackHighHeartsStraightFlush,
        QueenHighHeartsStraightFlush,
        KingHighHeartsStraightFlush,
        SixHighClubsStraightFlush,
        SevenHighClubsStraightFlush,
        EightHighClubsStraightFlush,
        NineHighClubsStraightFlush,
        TenHighClubsStraightFlush,
        JackHighClubsStraightFlush,
        QueenHighClubsStraightFlush,
        KingHighClubsStraightFlush,
        SixHighDiamondsStraightFlush,
        SevenHighDiamondsStraightFlush,
        EightHighDiamondsStraightFlush,
        NineHighDiamondsStraightFlush,
        TenHighDiamondsStraightFlush,
        JackHighDiamondsStraightFlush,
        QueenHighDiamondsStraightFlush,
        KingHighDiamondsStraightFlush
    };

}
