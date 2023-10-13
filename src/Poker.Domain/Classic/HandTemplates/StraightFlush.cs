namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate SixHighSpadesStraightFlush { get; } = new HandTemplate
    {
        Name = "Six High Spades Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate SevenHighSpadesStraightFlush { get; } = new HandTemplate
    {
        Name = "Seven High Spades Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate EightHighSpadesStraightFlush { get; } = new HandTemplate
    {
        Name = "Eight High Spades Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate NineHighSpadesStraightFlush { get; } = new HandTemplate
    {
        Name = "Nine High Spades Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate TenHighSpadesStraightFlush { get; } = new HandTemplate
    {
        Name = "Ten High Spades Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate JackHighSpadesStraightFlush { get; } = new HandTemplate
    {
        Name = "Jack High Spades Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate QueenHighSpadesStraightFlush { get; } = new HandTemplate
    {
        Name = "Queen High Spades Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate KingHighSpadesStraightFlush { get; } = new HandTemplate
    {
        Name = "King High Spades Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate SixHighHeartsStraightFlush { get; } = new HandTemplate
    {
        Name = "Six High Hearts Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate SevenHighHeartsStraightFlush { get; } = new HandTemplate
    {
        Name = "Seven High Hearts Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate EightHighHeartsStraightFlush { get; } = new HandTemplate
    {
        Name = "Eight High Hearts Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate NineHighHeartsStraightFlush { get; } = new HandTemplate
    {
        Name = "Nine High Hearts Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate TenHighHeartsStraightFlush { get; } = new HandTemplate
    {
        Name = "Ten High Hearts Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate JackHighHeartsStraightFlush { get; } = new HandTemplate
    {
        Name = "Jack High Hearts Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate QueenHighHeartsStraightFlush { get; } = new HandTemplate
    {
        Name = "Queen High Hearts Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate KingHighHeartsStraightFlush { get; } = new HandTemplate
    {
        Name = "King High Hearts Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate SixHighClubsStraightFlush { get; } = new HandTemplate
    {
        Name = "Six High Clubs Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate SevenHighClubsStraightFlush { get; } = new HandTemplate
    {
        Name = "Seven High Clubs Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate EightHighClubsStraightFlush { get; } = new HandTemplate
    {
        Name = "Eight High Clubs Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate NineHighClubsStraightFlush { get; } = new HandTemplate
    {
        Name = "Nine High Clubs Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate TenHighClubsStraightFlush { get; } = new HandTemplate
    {
        Name = "Ten High Clubs Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate JackHighClubsStraightFlush { get; } = new HandTemplate
    {
        Name = "Jack High Clubs Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate QueenHighClubsStraightFlush { get; } = new HandTemplate
    {
        Name = "Queen High Clubs Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate KingHighClubsStraightFlush { get; } = new HandTemplate
    {
        Name = "King High Clubs Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate SixHighDiamondsStraightFlush { get; } = new HandTemplate
    {
        Name = "Six High Diamonds Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate SevenHighDiamondsStraightFlush { get; } = new HandTemplate
    {
        Name = "Seven High Diamonds Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate EightHighDiamondsStraightFlush { get; } = new HandTemplate
    {
        Name = "Eight High Diamonds Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate NineHighDiamondsStraightFlush { get; } = new HandTemplate
    {
        Name = "Nine High Diamonds Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate TenHighDiamondsStraightFlush { get; } = new HandTemplate
    {
        Name = "Ten High Diamonds Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate JackHighDiamondsStraightFlush { get; } = new HandTemplate
    {
        Name = "Jack High Diamonds Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate QueenHighDiamondsStraightFlush { get; } = new HandTemplate
    {
        Name = "Queen High Diamonds Straight Flush",
        Hand = Hands.Straight,
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

    public static HandTemplate KingHighDiamondsStraightFlush { get; } = new HandTemplate
    {
        Name = "King High Diamonds Straight Flush",
        Hand = Hands.Straight,
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

    public static List<HandTemplate> AllStraightFlushes { get; } = new()
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
