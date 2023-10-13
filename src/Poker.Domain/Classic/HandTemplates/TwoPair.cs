namespace Poker.Domain.Classic;

public partial record HandTemplates
{
    public static HandTemplate TwoPairThreesOverTwos { get; } = new HandTemplate
    {
        Name = "Threes Over Twos",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSixesOverTwos { get; } = new HandTemplate
    {
        Name = "Sixes Over Twos",
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
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSevensOverTwos { get; } = new HandTemplate
    {
        Name = "Sevens Over Twos",
        Hand = Hands.TwoPair,
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
                Cards = Cards.All.WhereRank(Ranks.Two).ToList()
            }
        }
    };

    public static HandTemplate TwoPairNinesOverTwos { get; } = new HandTemplate
    {
        Name = "Nines Over Twos",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSixesOverThrees { get; } = new HandTemplate
    {
        Name = "Sixes Over Threes",
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
                Cards = Cards.All.WhereRank(Ranks.Three).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSevensOverThrees { get; } = new HandTemplate
    {
        Name = "Sevens Over Threes",
        Hand = Hands.TwoPair,
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

    public static HandTemplate TwoPairNinesOverThrees { get; } = new HandTemplate
    {
        Name = "Nines Over Threes",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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

    public static HandTemplate TwoPairSixesOverFours { get; } = new HandTemplate
    {
        Name = "Sixes Over Fours",
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
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate TwoPairSevensOverFours { get; } = new HandTemplate
    {
        Name = "Sevens Over Fours",
        Hand = Hands.TwoPair,
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
                Cards = Cards.All.WhereRank(Ranks.Four).ToList()
            }
        }
    };

    public static HandTemplate TwoPairNinesOverFours { get; } = new HandTemplate
    {
        Name = "Nines Over Fours",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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

    public static HandTemplate TwoPairSevensOverFives { get; } = new HandTemplate
    {
        Name = "Sevens Over Fives",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
                    Cards.All.WhereRank(Ranks.Five).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverFives { get; } = new HandTemplate
    {
        Name = "Aces Over Fives",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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

    public static HandTemplate TwoPairAcesOverSixes { get; } = new HandTemplate
    {
        Name = "Aces Over Sixes",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
                    Cards.All.WhereRank(Ranks.Eight).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverEights { get; } = new HandTemplate
    {
        Name = "Aces Over Eights",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
                        Cards.All.WhereRank(Ranks.Nine).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverNines { get; } = new HandTemplate
    {
        Name = "Aces Over Nines",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
                        Cards.All.WhereRank(Ranks.Ten).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverTens { get; } = new HandTemplate
    {
        Name = "Aces Over Tens",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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
                        Cards.All.WhereRank(Ranks.Jack).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverJacks { get; } = new HandTemplate
    {
        Name = "Aces Over Jacks",
        Hand = Hands.TwoPair,
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
                        Cards.All.WhereRank(Ranks.Queen).ToList()
            }
        }
    };

    public static HandTemplate TwoPairAcesOverQueens { get; } = new HandTemplate
    {
        Name = "Aces Over Queens",
        Hand = Hands.TwoPair,
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
        Hand = Hands.TwoPair,
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

