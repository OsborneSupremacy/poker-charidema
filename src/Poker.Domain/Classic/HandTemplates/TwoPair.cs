namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate TwoPairThreesOverTwos { get; } = new HandTemplate
    {
        Name = "Threes Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Three,
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

    public static HandTemplate TwoPairFoursOverTwos { get; } = new HandTemplate
    {
        Name = "Fours Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Four,
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

    public static HandTemplate TwoPairFivesOverTwos { get; } = new HandTemplate
    {
        Name = "Fives Over Twos",
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
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSixesOverTwos { get; } = new HandTemplate
    {
        Name = "Sixes Over Twos",
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
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSevensOverTwos { get; } = new HandTemplate
    {
        Name = "Sevens Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
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

    public static HandTemplate TwoPairEightsOverTwos { get; } = new HandTemplate
    {
        Name = "Eights Over Twos",
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
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate TwoPairNinesOverTwos { get; } = new HandTemplate
    {
        Name = "Nines Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
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

    public static HandTemplate TwoPairTensOverTwos { get; } = new HandTemplate
    {
        Name = "Tens Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
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

    public static HandTemplate TwoPairJacksOverTwos { get; } = new HandTemplate
    {
        Name = "Jacks Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverTwos { get; } = new HandTemplate
    {
        Name = "Queens Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverTwos { get; } = new HandTemplate
    {
        Name = "Kings Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
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

    public static HandTemplate TwoPairAcesOverTwos { get; } = new HandTemplate
    {
        Name = "Aces Over Twos",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairFoursOverThrees { get; } = new HandTemplate
    {
        Name = "Fours Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Four,
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

    public static HandTemplate TwoPairFivesOverThrees { get; } = new HandTemplate
    {
        Name = "Fives Over Threes",
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
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSixesOverThrees { get; } = new HandTemplate
    {
        Name = "Sixes Over Threes",
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
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSevensOverThrees { get; } = new HandTemplate
    {
        Name = "Sevens Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
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

    public static HandTemplate TwoPairEightsOverThrees { get; } = new HandTemplate
    {
        Name = "Eights Over Threes",
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

    public static HandTemplate TwoPairNinesOverThrees { get; } = new HandTemplate
    {
        Name = "Nines Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
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

    public static HandTemplate TwoPairTensOverThrees { get; } = new HandTemplate
    {
        Name = "Tens Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
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

    public static HandTemplate TwoPairJacksOverThrees { get; } = new HandTemplate
    {
        Name = "Jacks Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverThrees { get; } = new HandTemplate
    {
        Name = "Queens Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverThrees { get; } = new HandTemplate
    {
        Name = "Kings Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
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

    public static HandTemplate TwoPairAcesOverThrees { get; } = new HandTemplate
    {
        Name = "Aces Over Threes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairFivesOverFours { get; } = new HandTemplate
    {
        Name = "Fives Over Fours",
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

    public static HandTemplate TwoPairSixesOverFours { get; } = new HandTemplate
    {
        Name = "Sixes Over Fours",
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
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSevensOverFours { get; } = new HandTemplate
    {
        Name = "Sevens Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
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

    public static HandTemplate TwoPairEightsOverFours { get; } = new HandTemplate
    {
        Name = "Eights Over Fours",
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
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate TwoPairNinesOverFours { get; } = new HandTemplate
    {
        Name = "Nines Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
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

    public static HandTemplate TwoPairTensOverFours { get; } = new HandTemplate
    {
        Name = "Tens Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
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

    public static HandTemplate TwoPairJacksOverFours { get; } = new HandTemplate
    {
        Name = "Jacks Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverFours { get; } = new HandTemplate
    {
        Name = "Queens Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverFours { get; } = new HandTemplate
    {
        Name = "Kings Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
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

    public static HandTemplate TwoPairAcesOverFours { get; } = new HandTemplate
    {
        Name = "Aces Over Fours",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairSixesOverFives { get; } = new HandTemplate
    {
        Name = "Sixes Over Fives",
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

    public static HandTemplate TwoPairSevensOverFives { get; } = new HandTemplate
    {
        Name = "Sevens Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
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

    public static HandTemplate TwoPairEightsOverFives { get; } = new HandTemplate
    {
        Name = "Eights Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
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

    public static HandTemplate TwoPairNinesOverFives { get; } = new HandTemplate
    {
        Name = "Nines Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
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

    public static HandTemplate TwoPairTensOverFives { get; } = new HandTemplate
    {
        Name = "Tens Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
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

    public static HandTemplate TwoPairJacksOverFives { get; } = new HandTemplate
    {
        Name = "Jacks Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverFives { get; } = new HandTemplate
    {
        Name = "Queens Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverFives { get; } = new HandTemplate
    {
        Name = "Kings Over Fives",
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
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverFives { get; } = new HandTemplate
    {
        Name = "Aces Over Fives",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairSevensOverSixes { get; } = new HandTemplate
    {
        Name = "Sevens Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Seven,
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

    public static HandTemplate TwoPairEightsOverSixes { get; } = new HandTemplate
    {
        Name = "Eights Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
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

    public static HandTemplate TwoPairNinesOverSixes { get; } = new HandTemplate
    {
        Name = "Nines Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
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

    public static HandTemplate TwoPairTensOverSixes { get; } = new HandTemplate
    {
        Name = "Tens Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
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

    public static HandTemplate TwoPairJacksOverSixes { get; } = new HandTemplate
    {
        Name = "Jacks Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverSixes { get; } = new HandTemplate
    {
        Name = "Queens Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverSixes { get; } = new HandTemplate
    {
        Name = "Kings Over Sixes",
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

    public static HandTemplate TwoPairAcesOverSixes { get; } = new HandTemplate
    {
        Name = "Aces Over Sixes",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairEightsOverSevens { get; } = new HandTemplate
    {
        Name = "Eights Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Eight,
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

    public static HandTemplate TwoPairNinesOverSevens { get; } = new HandTemplate
    {
        Name = "Nines Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
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

    public static HandTemplate TwoPairTensOverSevens { get; } = new HandTemplate
    {
        Name = "Tens Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
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

    public static HandTemplate TwoPairJacksOverSevens { get; } = new HandTemplate
    {
        Name = "Jacks Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverSevens { get; } = new HandTemplate
    {
        Name = "Queens Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverSevens { get; } = new HandTemplate
    {
        Name = "Kings Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.King,
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

    public static HandTemplate TwoPairAcesOverSevens { get; } = new HandTemplate
    {
        Name = "Aces Over Sevens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairNinesOverEights { get; } = new HandTemplate
    {
        Name = "Nines Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Nine,
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

    public static HandTemplate TwoPairTensOverEights { get; } = new HandTemplate
    {
        Name = "Tens Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
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

    public static HandTemplate TwoPairJacksOverEights { get; } = new HandTemplate
    {
        Name = "Jacks Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverEights { get; } = new HandTemplate
    {
        Name = "Queens Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverEights { get; } = new HandTemplate
    {
        Name = "Kings Over Eights",
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
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverEights { get; } = new HandTemplate
    {
        Name = "Aces Over Eights",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairTensOverNines { get; } = new HandTemplate
    {
        Name = "Tens Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ten,
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

    public static HandTemplate TwoPairJacksOverNines { get; } = new HandTemplate
    {
        Name = "Jacks Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverNines { get; } = new HandTemplate
    {
        Name = "Queens Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverNines { get; } = new HandTemplate
    {
        Name = "Kings Over Nines",
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
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverNines { get; } = new HandTemplate
    {
        Name = "Aces Over Nines",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairJacksOverTens { get; } = new HandTemplate
    {
        Name = "Jacks Over Tens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Jack,
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

    public static HandTemplate TwoPairQueensOverTens { get; } = new HandTemplate
    {
        Name = "Queens Over Tens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverTens { get; } = new HandTemplate
    {
        Name = "Kings Over Tens",
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
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverTens { get; } = new HandTemplate
    {
        Name = "Aces Over Tens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairQueensOverJacks { get; } = new HandTemplate
    {
        Name = "Queens Over Jacks",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Queen,
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

    public static HandTemplate TwoPairKingsOverJacks { get; } = new HandTemplate
    {
        Name = "Kings Over Jacks",
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
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverJacks { get; } = new HandTemplate
    {
        Name = "Aces Over Jacks",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairKingsOverQueens { get; } = new HandTemplate
    {
        Name = "Kings Over Queens",
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
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverQueens { get; } = new HandTemplate
    {
        Name = "Aces Over Queens",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static HandTemplate TwoPairAcesOverKings { get; } = new HandTemplate
    {
        Name = "Aces Over Kings",
        HandDefinition = HandDefinitions.TwoPair,
        HighRank = Ranks.Ace,
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

    public static List<HandTemplate> AllTwoPair { get; } = new()
    {
        TwoPairThreesOverTwos,
        TwoPairFoursOverTwos,
        TwoPairFivesOverTwos,
        TwoPairSixesOverTwos,
        TwoPairSevensOverTwos,
        TwoPairEightsOverTwos,
        TwoPairNinesOverTwos,
        TwoPairTensOverTwos,
        TwoPairJacksOverTwos,
        TwoPairQueensOverTwos,
        TwoPairKingsOverTwos,
        TwoPairAcesOverTwos,
        TwoPairFoursOverThrees,
        TwoPairFivesOverThrees,
        TwoPairSixesOverThrees,
        TwoPairSevensOverThrees,
        TwoPairEightsOverThrees,
        TwoPairNinesOverThrees,
        TwoPairTensOverThrees,
        TwoPairJacksOverThrees,
        TwoPairQueensOverThrees,
        TwoPairKingsOverThrees,
        TwoPairAcesOverThrees,
        TwoPairFivesOverFours,
        TwoPairSixesOverFours,
        TwoPairSevensOverFours,
        TwoPairEightsOverFours,
        TwoPairNinesOverFours,
        TwoPairTensOverFours,
        TwoPairJacksOverFours,
        TwoPairQueensOverFours,
        TwoPairKingsOverFours,
        TwoPairAcesOverFours,
        TwoPairSixesOverFives,
        TwoPairSevensOverFives,
        TwoPairEightsOverFives,
        TwoPairNinesOverFives,
        TwoPairTensOverFives,
        TwoPairJacksOverFives,
        TwoPairQueensOverFives,
        TwoPairKingsOverFives,
        TwoPairAcesOverFives,
        TwoPairSevensOverSixes,
        TwoPairEightsOverSixes,
        TwoPairNinesOverSixes,
        TwoPairTensOverSixes,
        TwoPairJacksOverSixes,
        TwoPairQueensOverSixes,
        TwoPairKingsOverSixes,
        TwoPairAcesOverSixes,
        TwoPairEightsOverSevens,
        TwoPairNinesOverSevens,
        TwoPairTensOverSevens,
        TwoPairJacksOverSevens,
        TwoPairQueensOverSevens,
        TwoPairKingsOverSevens,
        TwoPairAcesOverSevens,
        TwoPairNinesOverEights,
        TwoPairTensOverEights,
        TwoPairJacksOverEights,
        TwoPairQueensOverEights,
        TwoPairKingsOverEights,
        TwoPairAcesOverEights,
        TwoPairTensOverNines,
        TwoPairJacksOverNines,
        TwoPairQueensOverNines,
        TwoPairKingsOverNines,
        TwoPairAcesOverNines,
        TwoPairJacksOverTens,
        TwoPairQueensOverTens,
        TwoPairKingsOverTens,
        TwoPairAcesOverTens,
        TwoPairQueensOverJacks,
        TwoPairKingsOverJacks,
        TwoPairAcesOverJacks,
        TwoPairKingsOverQueens,
        TwoPairAcesOverQueens,
        TwoPairAcesOverKings
    };
 }

