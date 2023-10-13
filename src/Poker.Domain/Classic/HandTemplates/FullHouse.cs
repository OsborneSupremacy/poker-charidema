namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate FullHouseThreesOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Threes Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseFoursOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Fours Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseFivesOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Fives Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseSixesOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Sixes Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseSevensOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Sevens Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseEightsOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Eights Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseNinesOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Nines Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseTensOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Tens Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseJacksOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseQueensOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseKingsOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseAcesOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Twos",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate FullHouseFoursOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Fours Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseFivesOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Fives Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseSixesOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Sixes Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseSevensOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Sevens Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseEightsOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Eights Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Eight,
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

    public static HandTemplate FullHouseNinesOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Nines Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseTensOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Tens Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseJacksOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseQueensOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseKingsOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseAcesOverThrees { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Threes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate FullHouseFivesOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Fives Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Five,
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

    public static HandTemplate FullHouseSixesOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Sixes Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseSevensOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Sevens Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseEightsOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Eights Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseNinesOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Nines Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseTensOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Tens Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseJacksOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseQueensOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseKingsOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseAcesOverFours { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Fours",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate FullHouseSixesOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Sixes Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Six,
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

    public static HandTemplate FullHouseSevensOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Sevens Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandTemplate FullHouseEightsOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Eights Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseNinesOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Nines Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseTensOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Tens Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseJacksOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseQueensOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseKingsOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseAcesOverFives { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Fives",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseSevensOverSixes { get; } = new HandTemplate
    {
        Name = "Full House, Sevens Over Sixes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseEightsOverSixes { get; } = new HandTemplate
    {
        Name = "Full House, Eights Over Sixes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseNinesOverSixes { get; } = new HandTemplate
    {
        Name = "Full House, Nines Over Sixes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseTensOverSixes { get; } = new HandTemplate
    {
        Name = "Full House, Tens Over Sixes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseJacksOverSixes { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Sixes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseQueensOverSixes { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Sixes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseKingsOverSixes { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Sixes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
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

    public static HandTemplate FullHouseAcesOverSixes { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Sixes",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseEightsOverSevens { get; } = new HandTemplate
    {
        Name = "Full House, Eights Over Sevens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseNinesOverSevens { get; } = new HandTemplate
    {
        Name = "Full House, Nines Over Sevens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandTemplate FullHouseTensOverSevens { get; } = new HandTemplate
    {
        Name = "Full House, Tens Over Sevens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandTemplate FullHouseJacksOverSevens { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Sevens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandTemplate FullHouseQueensOverSevens { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Sevens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandTemplate FullHouseKingsOverSevens { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Sevens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandTemplate FullHouseAcesOverSevens { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Sevens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
                Cards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                Count = 2,
                Cards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static HandTemplate FullHouseNinesOverEights { get; } = new HandTemplate
    {
        Name = "Full House, Nines Over Eights",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseTensOverEights { get; } = new HandTemplate
    {
        Name = "Full House, Tens Over Eights",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseJacksOverEights { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Eights",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseQueensOverEights { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Eights",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseKingsOverEights { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Eights",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseAcesOverEights { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Eights",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseTensOverNines { get; } = new HandTemplate
    {
        Name = "Full House, Tens Over Nines",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseJacksOverNines { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Nines",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseQueensOverNines { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Nines",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseKingsOverNines { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Nines",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseAcesOverNines { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Nines",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseJacksOverTens { get; } = new HandTemplate
    {
        Name = "Full House, Jacks Over Tens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseQueensOverTens { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Tens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseKingsOverTens { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Tens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseAcesOverTens { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Tens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseQueensOverJacks { get; } = new HandTemplate
    {
        Name = "Full House, Queens Over Jacks",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseKingsOverJacks { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Jacks",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseAcesOverJacks { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Jacks",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseKingsOverQueens { get; } = new HandTemplate
    {
        Name = "Full House, Kings Over Queens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseAcesOverQueens { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Queens",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static HandTemplate FullHouseAcesOverKings { get; } = new HandTemplate
    {
        Name = "Full House, Aces Over Kings",
        Hand = Hands.TwoPair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        CardGroups = new List<CardGroup>
        {
            new()
            {
                Count = 3,
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

    public static List<HandTemplate> AllFullHouses { get; } = new()
    {
        FullHouseThreesOverTwos,
        FullHouseFoursOverTwos,
        FullHouseFivesOverTwos,
        FullHouseSixesOverTwos,
        FullHouseSevensOverTwos,
        FullHouseEightsOverTwos,
        FullHouseNinesOverTwos,
        FullHouseTensOverTwos,
        FullHouseJacksOverTwos,
        FullHouseQueensOverTwos,
        FullHouseKingsOverTwos,
        FullHouseAcesOverTwos,
        FullHouseFoursOverThrees,
        FullHouseFivesOverThrees,
        FullHouseSixesOverThrees,
        FullHouseSevensOverThrees,
        FullHouseEightsOverThrees,
        FullHouseNinesOverThrees,
        FullHouseTensOverThrees,
        FullHouseJacksOverThrees,
        FullHouseQueensOverThrees,
        FullHouseKingsOverThrees,
        FullHouseAcesOverThrees,
        FullHouseFivesOverFours,
        FullHouseSixesOverFours,
        FullHouseSevensOverFours,
        FullHouseEightsOverFours,
        FullHouseNinesOverFours,
        FullHouseTensOverFours,
        FullHouseJacksOverFours,
        FullHouseQueensOverFours,
        FullHouseKingsOverFours,
        FullHouseAcesOverFours,
        FullHouseSixesOverFives,
        FullHouseSevensOverFives,
        FullHouseEightsOverFives,
        FullHouseNinesOverFives,
        FullHouseTensOverFives,
        FullHouseJacksOverFives,
        FullHouseQueensOverFives,
        FullHouseKingsOverFives,
        FullHouseAcesOverFives,
        FullHouseSevensOverSixes,
        FullHouseEightsOverSixes,
        FullHouseNinesOverSixes,
        FullHouseTensOverSixes,
        FullHouseJacksOverSixes,
        FullHouseQueensOverSixes,
        FullHouseKingsOverSixes,
        FullHouseAcesOverSixes,
        FullHouseEightsOverSevens,
        FullHouseNinesOverSevens,
        FullHouseTensOverSevens,
        FullHouseJacksOverSevens,
        FullHouseQueensOverSevens,
        FullHouseKingsOverSevens,
        FullHouseAcesOverSevens,
        FullHouseNinesOverEights,
        FullHouseTensOverEights,
        FullHouseJacksOverEights,
        FullHouseQueensOverEights,
        FullHouseKingsOverEights,
        FullHouseAcesOverEights,
        FullHouseTensOverNines,
        FullHouseJacksOverNines,
        FullHouseQueensOverNines,
        FullHouseKingsOverNines,
        FullHouseAcesOverNines,
        FullHouseJacksOverTens,
        FullHouseQueensOverTens,
        FullHouseKingsOverTens,
        FullHouseAcesOverTens,
        FullHouseQueensOverJacks,
        FullHouseKingsOverJacks,
        FullHouseAcesOverJacks,
        FullHouseKingsOverQueens,
        FullHouseAcesOverQueens,
        FullHouseAcesOverKings
    };
}

