namespace Poker.Domain.Classic.HandRequirements;

public record StraightFlush
{
    public static HandRequirement SixHighSpades { get; } = new HandRequirement
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

    public static HandRequirement SevenHighSpades { get; } = new HandRequirement
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

    public static HandRequirement EightHighSpades { get; } = new HandRequirement
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

    public static HandRequirement NineHighSpades { get; } = new HandRequirement
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

    public static HandRequirement TenHighSpades { get; } = new HandRequirement
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

    public static HandRequirement JackHighSpades { get; } = new HandRequirement
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

    public static HandRequirement QueenHighSpades { get; } = new HandRequirement
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

    public static HandRequirement KingHighSpades { get; } = new HandRequirement
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

    public static HandRequirement SixHighHearts { get; } = new HandRequirement
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

    public static HandRequirement SevenHighHearts { get; } = new HandRequirement
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

    public static HandRequirement EightHighHearts { get; } = new HandRequirement
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

    public static HandRequirement NineHighHearts { get; } = new HandRequirement
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

    public static HandRequirement TenHighHearts { get; } = new HandRequirement
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

    public static HandRequirement JackHighHearts { get; } = new HandRequirement
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

    public static HandRequirement QueenHighHearts { get; } = new HandRequirement
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

    public static HandRequirement KingHighHearts { get; } = new HandRequirement
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

    public static HandRequirement SixHighClubs { get; } = new HandRequirement
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

    public static HandRequirement SevenHighClubs { get; } = new HandRequirement
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

    public static HandRequirement EightHighClubs { get; } = new HandRequirement
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

    public static HandRequirement NineHighClubs { get; } = new HandRequirement
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

    public static HandRequirement TenHighClubs { get; } = new HandRequirement
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

    public static HandRequirement JackHighClubs { get; } = new HandRequirement
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

    public static HandRequirement QueenHighClubs { get; } = new HandRequirement
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

    public static HandRequirement KingHighClubs { get; } = new HandRequirement
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

    public static HandRequirement SixHighDiamonds { get; } = new HandRequirement
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

    public static HandRequirement SevenHighDiamonds { get; } = new HandRequirement
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

    public static HandRequirement EightHighDiamonds { get; } = new HandRequirement
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

    public static HandRequirement NineHighDiamonds { get; } = new HandRequirement
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

    public static HandRequirement TenHighDiamonds { get; } = new HandRequirement
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

    public static HandRequirement JackHighDiamonds { get; } = new HandRequirement
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

    public static HandRequirement QueenHighDiamonds { get; } = new HandRequirement
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

    public static HandRequirement KingHighDiamonds { get; } = new HandRequirement
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

    public static List<HandRequirement> All { get; } = new()
    {
        SixHighSpades,
        SevenHighSpades,
        EightHighSpades,
        NineHighSpades,
        TenHighSpades,
        JackHighSpades,
        QueenHighSpades,
        KingHighSpades,
        SixHighHearts,
        SevenHighHearts,
        EightHighHearts,
        NineHighHearts,
        TenHighHearts,
        JackHighHearts,
        QueenHighHearts,
        KingHighHearts,
        SixHighClubs,
        SevenHighClubs,
        EightHighClubs,
        NineHighClubs,
        TenHighClubs,
        JackHighClubs,
        QueenHighClubs,
        KingHighClubs,
        SixHighDiamonds,
        SevenHighDiamonds,
        EightHighDiamonds,
        NineHighDiamonds,
        TenHighDiamonds,
        JackHighDiamonds,
        QueenHighDiamonds,
        KingHighDiamonds
    };

}
