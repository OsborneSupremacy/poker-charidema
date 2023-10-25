namespace Poker.Domain.Classic.Hands;

public static class FullHouses
{
    public static Hand TwosOverThrees { get; } = new()
    {
        Name = "Full House, Twos Over Threes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverFours { get; } = new()
    {
        Name = "Full House, Twos Over Fours",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverFives { get; } = new()
    {
        Name = "Full House, Twos Over Fives",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverSixes { get; } = new()
    {
        Name = "Full House, Twos Over Sixes",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverSevens { get; } = new()
    {
        Name = "Full House, Twos Over Sevens",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverEights { get; } = new()
    {
        Name = "Full House, Twos Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverNines { get; } = new()
    {
        Name = "Full House, Twos Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverTens { get; } = new()
    {
        Name = "Full House, Twos Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverJacks { get; } = new()
    {
        Name = "Full House, Twos Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverQueens { get; } = new()
    {
        Name = "Full House, Twos Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            }
        }
    };  
    
    public static Hand TwosOverKings { get; } = new()
    {
        Name = "Full House, Twos Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            }
        }
    };
    
    public static Hand TwosOverAces { get; } = new()
    {
        Name = "Full House, Twos Over Eights",
        HandDefinition = HandDefinitions.FullHouse,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 3,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            }
        }
    };
    
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
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds
                }
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
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds
                }
            },
            new()
            {
                RequiredCount = 2,
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds
                }
            }
        }
    };
}

