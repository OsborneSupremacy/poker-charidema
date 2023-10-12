namespace Poker.Domain.Classic.HandRequirements;

public record TwoPairs
{
    public static HandRequirement ThreesOverTwos { get; } = new HandRequirement
    {
        Name = "Threes Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Three,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement FoursOverTwos { get; } = new HandRequirement
    {
        Name = "Fours Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement FivesOverTwos { get; } = new HandRequirement
    {
        Name = "Fives Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement SixesOverTwos { get; } = new HandRequirement
    {
        Name = "Sixes Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement SevensOverTwos { get; } = new HandRequirement
    {
        Name = "Sevens Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement EightsOverTwos { get; } = new HandRequirement
    {
        Name = "Eights Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement NinesOverTwos { get; } = new HandRequirement
    {
        Name = "Nines Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement TensOverTwos { get; } = new HandRequirement
    {
        Name = "Tens Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement JacksOverTwos { get; } = new HandRequirement
    {
        Name = "Jacks Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement QueensOverTwos { get; } = new HandRequirement
    {
        Name = "Queens Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement KingsOverTwos { get; } = new HandRequirement
    {
        Name = "Kings Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement AcesOverTwos { get; } = new HandRequirement
    {
        Name = "Aces Over Twos",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandRequirement FoursOverThrees { get; } = new HandRequirement
    {
        Name = "Fours Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement FivesOverThrees { get; } = new HandRequirement
    {
        Name = "Fives Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement SixesOverThrees { get; } = new HandRequirement
    {
        Name = "Sixes Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement SevensOverThrees { get; } = new HandRequirement
    {
        Name = "Sevens Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement EightsOverThrees { get; } = new HandRequirement
    {
        Name = "Eights Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement NinesOverThrees { get; } = new HandRequirement
    {
        Name = "Nines Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement TensOverThrees { get; } = new HandRequirement
    {
        Name = "Tens Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement JacksOverThrees { get; } = new HandRequirement
    {
        Name = "Jacks Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement QueensOverThrees { get; } = new HandRequirement
    {
        Name = "Queens Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement KingsOverThrees { get; } = new HandRequirement
    {
        Name = "Kings Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement AcesOverThrees { get; } = new HandRequirement
    {
        Name = "Aces Over Threes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandRequirement FivesOverFours { get; } = new HandRequirement
    {
        Name = "Fives Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement SixesOverFours { get; } = new HandRequirement
    {
        Name = "Sixes Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement SevensOverFours { get; } = new HandRequirement
    {
        Name = "Sevens Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement EightsOverFours { get; } = new HandRequirement
    {
        Name = "Eights Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement NinesOverFours { get; } = new HandRequirement
    {
        Name = "Nines Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement TensOverFours { get; } = new HandRequirement
    {
        Name = "Tens Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement JacksOverFours { get; } = new HandRequirement
    {
        Name = "Jacks Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement QueensOverFours { get; } = new HandRequirement
    {
        Name = "Queens Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement KingsOverFours { get; } = new HandRequirement
    {
        Name = "Kings Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement AcesOverFours { get; } = new HandRequirement
    {
        Name = "Aces Over Fours",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandRequirement SixesOverFives { get; } = new HandRequirement
    {
        Name = "Sixes Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement SevensOverFives { get; } = new HandRequirement
    {
        Name = "Sevens Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement EightsOverFives { get; } = new HandRequirement
    {
        Name = "Eights Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement NinesOverFives { get; } = new HandRequirement
    {
        Name = "Nines Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement TensOverFives { get; } = new HandRequirement
    {
        Name = "Tens Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement JacksOverFives { get; } = new HandRequirement
    {
        Name = "Jacks Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement QueensOverFives { get; } = new HandRequirement
    {
        Name = "Queens Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement KingsOverFives { get; } = new HandRequirement
    {
        Name = "Kings Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement AcesOverFives { get; } = new HandRequirement
    {
        Name = "Aces Over Fives",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandRequirement SevensOverSixes { get; } = new HandRequirement
    {
        Name = "Sevens Over Sixes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement EightsOverSixes { get; } = new HandRequirement
    {
        Name = "Eights Over Sixes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement NinesOverSixes { get; } = new HandRequirement
    {
        Name = "Nines Over Sixes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement TensOverSixes { get; } = new HandRequirement
    {
        Name = "Tens Over Sixes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement JacksOverSixes { get; } = new HandRequirement
    {
        Name = "Jacks Over Sixes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement QueensOverSixes { get; } = new HandRequirement
    {
        Name = "Queens Over Sixes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement KingsOverSixes { get; } = new HandRequirement
    {
        Name = "Kings Over Sixes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement AcesOverSixes { get; } = new HandRequirement
    {
        Name = "Aces Over Sixes",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static HandRequirement EightsOverSevens { get; } = new HandRequirement
    {
        Name = "Eights Over Sevens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards
                    .All
                    .WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards
                    .All
                    .WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandRequirement NinesOverSevens { get; } = new HandRequirement
    {
        Name = "Nines Over Sevens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandRequirement TensOverSevens { get; } = new HandRequirement
    {
        Name = "Tens Over Sevens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandRequirement JacksOverSevens { get; } = new HandRequirement
    {
        Name = "Jacks Over Sevens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandRequirement QueensOverSevens { get; } = new HandRequirement
    {
        Name = "Queens Over Sevens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandRequirement KingsOverSevens { get; } = new HandRequirement
    {
        Name = "Kings Over Sevens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandRequirement AcesOverSevens { get; } = new HandRequirement
    {
        Name = "Aces Over Sevens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandRequirement NinesOverEights { get; } = new HandRequirement
    {
        Name = "Nines Over Eights",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandRequirement TensOverEights { get; } = new HandRequirement
    {
        Name = "Tens Over Eights",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandRequirement JacksOverEights { get; } = new HandRequirement
    {
        Name = "Jacks Over Eights",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandRequirement QueensOverEights { get; } = new HandRequirement
    {
        Name = "Queens Over Eights",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandRequirement KingsOverEights { get; } = new HandRequirement
    {
        Name = "Kings Over Eights",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandRequirement AcesOverEights { get; } = new HandRequirement
    {
        Name = "Aces Over Eights",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandRequirement TensOverNines { get; } = new HandRequirement
    {
        Name = "Tens Over Nines",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandRequirement JacksOverNines { get; } = new HandRequirement
    {
        Name = "Jacks Over Nines",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandRequirement QueensOverNines { get; } = new HandRequirement
    {
        Name = "Queens Over Nines",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandRequirement KingsOverNines { get; } = new HandRequirement
    {
        Name = "Kings Over Nines",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                Cards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandRequirement AcesOverNines { get; } = new HandRequirement
    {
        Name = "Aces Over Nines",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandRequirement JacksOverTens { get; } = new HandRequirement
    {
        Name = "Jacks Over Tens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandRequirement QueensOverTens { get; } = new HandRequirement
    {
        Name = "Queens Over Tens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandRequirement KingsOverTens { get; } = new HandRequirement
    {
        Name = "Kings Over Tens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandRequirement AcesOverTens { get; } = new HandRequirement
    {
        Name = "Aces Over Tens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandRequirement QueensOverJacks { get; } = new HandRequirement
    {
        Name = "Queens Over Jacks",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static HandRequirement KingsOverJacks { get; } = new HandRequirement
    {
        Name = "Kings Over Jacks",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static HandRequirement AcesOverJacks { get; } = new HandRequirement
    {
        Name = "Aces Over Jacks",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static HandRequirement KingsOverQueens { get; } = new HandRequirement
    {
        Name = "Kings Over Queens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static HandRequirement AcesOverQueens { get; } = new HandRequirement
    {
        Name = "Aces Over Queens",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static HandRequirement AcesOverKings { get; } = new HandRequirement
    {
        Name = "Aces Over Kings",
        Hand = Hands.TwoPair,
        HighRank =Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                    Cards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            }
        }
    };

    public static List<HandRequirement> All { get; } = new()
    {
        ThreesOverTwos,
        FoursOverTwos,
        FivesOverTwos,
        SixesOverTwos,
        SevensOverTwos,
        EightsOverTwos,
        NinesOverTwos,
        TensOverTwos,
        JacksOverTwos,
        QueensOverTwos,
        KingsOverTwos,
        AcesOverTwos,
        FoursOverThrees,
        FivesOverThrees,
        SixesOverThrees,
        SevensOverThrees,
        EightsOverThrees,
        NinesOverThrees,
        TensOverThrees,
        JacksOverThrees,
        QueensOverThrees,
        KingsOverThrees,
        AcesOverThrees,
        FivesOverFours,
        SixesOverFours,
        SevensOverFours,
        EightsOverFours,
        NinesOverFours,
        TensOverFours,
        JacksOverFours,
        QueensOverFours,
        KingsOverFours,
        AcesOverFours,
        SixesOverFives,
        SevensOverFives,
        EightsOverFives,
        NinesOverFives,
        TensOverFives,
        JacksOverFives,
        QueensOverFives,
        KingsOverFives,
        AcesOverFives,
        SevensOverSixes,
        EightsOverSixes,
        NinesOverSixes,
        TensOverSixes,
        JacksOverSixes,
        QueensOverSixes,
        KingsOverSixes,
        AcesOverSixes,
        EightsOverSevens,
        NinesOverSevens,
        TensOverSevens,
        JacksOverSevens,
        QueensOverSevens,
        KingsOverSevens,
        AcesOverSevens,
        NinesOverEights,
        TensOverEights,
        JacksOverEights,
        QueensOverEights,
        KingsOverEights,
        AcesOverEights,
        TensOverNines,
        JacksOverNines,
        QueensOverNines,
        KingsOverNines,
        AcesOverNines,
        JacksOverTens,
        QueensOverTens,
        KingsOverTens,
        AcesOverTens,
        QueensOverJacks,
        KingsOverJacks,
        AcesOverJacks,
        KingsOverQueens,
        AcesOverQueens,
        AcesOverKings
    };
 }

