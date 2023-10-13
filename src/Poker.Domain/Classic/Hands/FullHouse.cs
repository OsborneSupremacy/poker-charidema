namespace Poker.Domain.Classic;

public partial record Hands
{
    public static Hand FullHouseThreesOverTwos { get; } = new Hand
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

    public static Hand FullHouseFoursOverTwos { get; } = new Hand
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

    public static Hand FullHouseFivesOverTwos { get; } = new Hand
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

    public static Hand FullHouseSixesOverTwos { get; } = new Hand
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

    public static Hand FullHouseSevensOverTwos { get; } = new Hand
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

    public static Hand FullHouseEightsOverTwos { get; } = new Hand
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

    public static Hand FullHouseNinesOverTwos { get; } = new Hand
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

    public static Hand FullHouseTensOverTwos { get; } = new Hand
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

    public static Hand FullHouseJacksOverTwos { get; } = new Hand
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

    public static Hand FullHouseQueensOverTwos { get; } = new Hand
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

    public static Hand FullHouseKingsOverTwos { get; } = new Hand
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

    public static Hand FullHouseAcesOverTwos { get; } = new Hand
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

    public static Hand FullHouseFoursOverThrees { get; } = new Hand
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

    public static Hand FullHouseFivesOverThrees { get; } = new Hand
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

    public static Hand FullHouseSixesOverThrees { get; } = new Hand
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

    public static Hand FullHouseSevensOverThrees { get; } = new Hand
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

    public static Hand FullHouseEightsOverThrees { get; } = new Hand
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

    public static Hand FullHouseNinesOverThrees { get; } = new Hand
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

    public static Hand FullHouseTensOverThrees { get; } = new Hand
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

    public static Hand FullHouseJacksOverThrees { get; } = new Hand
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

    public static Hand FullHouseQueensOverThrees { get; } = new Hand
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

    public static Hand FullHouseKingsOverThrees { get; } = new Hand
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

    public static Hand FullHouseAcesOverThrees { get; } = new Hand
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

    public static Hand FullHouseFivesOverFours { get; } = new Hand
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

    public static Hand FullHouseSixesOverFours { get; } = new Hand
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

    public static Hand FullHouseSevensOverFours { get; } = new Hand
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

    public static Hand FullHouseEightsOverFours { get; } = new Hand
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

    public static Hand FullHouseNinesOverFours { get; } = new Hand
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

    public static Hand FullHouseTensOverFours { get; } = new Hand
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

    public static Hand FullHouseJacksOverFours { get; } = new Hand
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

    public static Hand FullHouseQueensOverFours { get; } = new Hand
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

    public static Hand FullHouseKingsOverFours { get; } = new Hand
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

    public static Hand FullHouseAcesOverFours { get; } = new Hand
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

    public static Hand FullHouseSixesOverFives { get; } = new Hand
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

    public static Hand FullHouseSevensOverFives { get; } = new Hand
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

    public static Hand FullHouseEightsOverFives { get; } = new Hand
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

    public static Hand FullHouseNinesOverFives { get; } = new Hand
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

    public static Hand FullHouseTensOverFives { get; } = new Hand
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

    public static Hand FullHouseJacksOverFives { get; } = new Hand
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

    public static Hand FullHouseQueensOverFives { get; } = new Hand
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

    public static Hand FullHouseKingsOverFives { get; } = new Hand
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

    public static Hand FullHouseAcesOverFives { get; } = new Hand
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

    public static Hand FullHouseSevensOverSixes { get; } = new Hand
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

    public static Hand FullHouseEightsOverSixes { get; } = new Hand
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

    public static Hand FullHouseNinesOverSixes { get; } = new Hand
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

    public static Hand FullHouseTensOverSixes { get; } = new Hand
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

    public static Hand FullHouseJacksOverSixes { get; } = new Hand
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

    public static Hand FullHouseQueensOverSixes { get; } = new Hand
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

    public static Hand FullHouseKingsOverSixes { get; } = new Hand
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

    public static Hand FullHouseAcesOverSixes { get; } = new Hand
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

    public static Hand FullHouseEightsOverSevens { get; } = new Hand
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

    public static Hand FullHouseNinesOverSevens { get; } = new Hand
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

    public static Hand FullHouseTensOverSevens { get; } = new Hand
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

    public static Hand FullHouseJacksOverSevens { get; } = new Hand
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

    public static Hand FullHouseQueensOverSevens { get; } = new Hand
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

    public static Hand FullHouseKingsOverSevens { get; } = new Hand
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

    public static Hand FullHouseAcesOverSevens { get; } = new Hand
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

    public static Hand FullHouseNinesOverEights { get; } = new Hand
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

    public static Hand FullHouseTensOverEights { get; } = new Hand
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

    public static Hand FullHouseJacksOverEights { get; } = new Hand
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

    public static Hand FullHouseQueensOverEights { get; } = new Hand
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

    public static Hand FullHouseKingsOverEights { get; } = new Hand
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

    public static Hand FullHouseAcesOverEights { get; } = new Hand
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

    public static Hand FullHouseTensOverNines { get; } = new Hand
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

    public static Hand FullHouseJacksOverNines { get; } = new Hand
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

    public static Hand FullHouseQueensOverNines { get; } = new Hand
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

    public static Hand FullHouseKingsOverNines { get; } = new Hand
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

    public static Hand FullHouseAcesOverNines { get; } = new Hand
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

    public static Hand FullHouseJacksOverTens { get; } = new Hand
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

    public static Hand FullHouseQueensOverTens { get; } = new Hand
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

    public static Hand FullHouseKingsOverTens { get; } = new Hand
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

    public static Hand FullHouseAcesOverTens { get; } = new Hand
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

    public static Hand FullHouseQueensOverJacks { get; } = new Hand
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

    public static Hand FullHouseKingsOverJacks { get; } = new Hand
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

    public static Hand FullHouseAcesOverJacks { get; } = new Hand
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

    public static Hand FullHouseKingsOverQueens { get; } = new Hand
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

    public static Hand FullHouseAcesOverQueens { get; } = new Hand
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

    public static Hand FullHouseAcesOverKings { get; } = new Hand
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

    public static List<Hand> AllFullHouses { get; } = new()
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

