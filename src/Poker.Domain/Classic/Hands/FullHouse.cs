namespace Poker.Domain.Classic.Hands;

public static class FullHouses
{
    public static Hand ThreesOverTwos { get; } = new()
    {
        Name = "Full House, Threes Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand FoursOverTwos { get; } = new()
    {
        Name = "Full House, Fours Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand FivesOverTwos { get; } = new()
    {
        Name = "Full House, Fives Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand SixesOverTwos { get; } = new()
    {
        Name = "Full House, Sixes Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand SevensOverTwos { get; } = new()
    {
        Name = "Full House, Sevens Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand EightsOverTwos { get; } = new()
    {
        Name = "Full House, Eights Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand NinesOverTwos { get; } = new()
    {
        Name = "Full House, Nines Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand TensOverTwos { get; } = new()
    {
        Name = "Full House, Tens Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand JacksOverTwos { get; } = new()
    {
        Name = "Full House, Jacks Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand QueensOverTwos { get; } = new()
    {
        Name = "Full House, Queens Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand KingsOverTwos { get; } = new()
    {
        Name = "Full House, Kings Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand AcesOverTwos { get; } = new()
    {
        Name = "Full House, Aces Over Twos",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static Hand FoursOverThrees { get; } = new()
    {
        Name = "Full House, Fours Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand FivesOverThrees { get; } = new()
    {
        Name = "Full House, Fives Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand SixesOverThrees { get; } = new()
    {
        Name = "Full House, Sixes Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand SevensOverThrees { get; } = new()
    {
        Name = "Full House, Sevens Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand EightsOverThrees { get; } = new()
    {
        Name = "Full House, Eights Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand NinesOverThrees { get; } = new()
    {
        Name = "Full House, Nines Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand TensOverThrees { get; } = new()
    {
        Name = "Full House, Tens Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand JacksOverThrees { get; } = new()
    {
        Name = "Full House, Jacks Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand QueensOverThrees { get; } = new()
    {
        Name = "Full House, Queens Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand KingsOverThrees { get; } = new()
    {
        Name = "Full House, Kings Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand AcesOverThrees { get; } = new()
    {
        Name = "Full House, Aces Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static Hand FivesOverFours { get; } = new()
    {
        Name = "Full House, Fives Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand SixesOverFours { get; } = new()
    {
        Name = "Full House, Sixes Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand SevensOverFours { get; } = new()
    {
        Name = "Full House, Sevens Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand EightsOverFours { get; } = new()
    {
        Name = "Full House, Eights Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand NinesOverFours { get; } = new()
    {
        Name = "Full House, Nines Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand TensOverFours { get; } = new()
    {
        Name = "Full House, Tens Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand JacksOverFours { get; } = new()
    {
        Name = "Full House, Jacks Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand QueensOverFours { get; } = new()
    {
        Name = "Full House, Queens Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand KingsOverFours { get; } = new()
    {
        Name = "Full House, Kings Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand AcesOverFours { get; } = new()
    {
        Name = "Full House, Aces Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static Hand SixesOverFives { get; } = new()
    {
        Name = "Full House, Sixes Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Six).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand SevensOverFives { get; } = new()
    {
        Name = "Full House, Sevens Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand EightsOverFives { get; } = new()
    {
        Name = "Full House, Eights Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand NinesOverFives { get; } = new()
    {
        Name = "Full House, Nines Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand TensOverFives { get; } = new()
    {
        Name = "Full House, Tens Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand JacksOverFives { get; } = new()
    {
        Name = "Full House, Jacks Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand QueensOverFives { get; } = new()
    {
        Name = "Full House, Queens Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand KingsOverFives { get; } = new()
    {
        Name = "Full House, Kings Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand AcesOverFives { get; } = new()
    {
        Name = "Full House, Aces Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static Hand SevensOverSixes { get; } = new()
    {
        Name = "Full House, Sevens Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Seven).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand EightsOverSixes { get; } = new()
    {
        Name = "Full House, Eights Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand NinesOverSixes { get; } = new()
    {
        Name = "Full House, Nines Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand TensOverSixes { get; } = new()
    {
        Name = "Full House, Tens Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand JacksOverSixes { get; } = new()
    {
        Name = "Full House, Jacks Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand QueensOverSixes { get; } = new()
    {
        Name = "Full House, Queens Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand KingsOverSixes { get; } = new()
    {
        Name = "Full House, Kings Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand AcesOverSixes { get; } = new()
    {
        Name = "Full House, Aces Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Six).ToList()
            }
        }
    };

    public static Hand EightsOverSevens { get; } = new()
    {
        Name = "Full House, Eights Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards
                    .All
                    .WhereRank(Ranks.Eight).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards
                    .All
                    .WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand NinesOverSevens { get; } = new()
    {
        Name = "Full House, Nines Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand TensOverSevens { get; } = new()
    {
        Name = "Full House, Tens Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand JacksOverSevens { get; } = new()
    {
        Name = "Full House, Jacks Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand QueensOverSevens { get; } = new()
    {
        Name = "Full House, Queens Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand KingsOverSevens { get; } = new()
    {
        Name = "Full House, Kings Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand AcesOverSevens { get; } = new()
    {
        Name = "Full House, Aces Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = Cards.All.WhereRank(Ranks.Seven).ToList()
            }
        }
    };

    public static Hand NinesOverEights { get; } = new()
    {
        Name = "Full House, Nines Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Nine).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand TensOverEights { get; } = new()
    {
        Name = "Full House, Tens Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand JacksOverEights { get; } = new()
    {
        Name = "Full House, Jacks Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand QueensOverEights { get; } = new()
    {
        Name = "Full House, Queens Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand KingsOverEights { get; } = new()
    {
        Name = "Full House, Kings Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand AcesOverEights { get; } = new()
    {
        Name = "Full House, Aces Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static Hand TensOverNines { get; } = new()
    {
        Name = "Full House, Tens Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand JacksOverNines { get; } = new()
    {
        Name = "Full House, Jacks Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand QueensOverNines { get; } = new()
    {
        Name = "Full House, Queens Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand KingsOverNines { get; } = new()
    {
        Name = "Full House, Kings Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand AcesOverNines { get; } = new()
    {
        Name = "Full House, Aces Over Nines",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static Hand JacksOverTens { get; } = new()
    {
        Name = "Full House, Jacks Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static Hand QueensOverTens { get; } = new()
    {
        Name = "Full House, Queens Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static Hand KingsOverTens { get; } = new()
    {
        Name = "Full House, Kings Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static Hand AcesOverTens { get; } = new()
    {
        Name = "Full House, Aces Over Tens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static Hand QueensOverJacks { get; } = new()
    {
        Name = "Full House, Queens Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static Hand KingsOverJacks { get; } = new()
    {
        Name = "Full House, Kings Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static Hand AcesOverJacks { get; } = new()
    {
        Name = "Full House, Aces Over Jacks",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static Hand KingsOverQueens { get; } = new()
    {
        Name = "Full House, Kings Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static Hand AcesOverQueens { get; } = new()
    {
        Name = "Full House, Aces Over Queens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static Hand AcesOverKings { get; } = new()
    {
        Name = "Full House, Aces Over Kings",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.Ace).ToList()
            },
            new()
            {
                RequiredCount = 2,
                    EligibleCards =
                        Cards.All.WhereRank(Ranks.King).ToList()
            }
        }
    };
}

