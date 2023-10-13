namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate FullHouseThreesOverTwos { get; } = new HandTemplate
    {
        Name = "Full House, Threes Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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
        HandDefinition = HandDefinitions.TwoPair,
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

