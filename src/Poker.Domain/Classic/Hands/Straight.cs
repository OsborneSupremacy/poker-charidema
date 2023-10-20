namespace Poker.Domain.Classic.Hands;

public static class Straights
{
    public static Hand SixHigh { get; } = new Hand
    {
        Name = "Six High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfDiamonds,
                    Cards.SixOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfDiamonds,
                    Cards.FiveOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfDiamonds,
                    Cards.FourOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfDiamonds,
                    Cards.ThreeOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfDiamonds,
                    Cards.TwoOfClubs
                }
            }
        }
    };

    public static Hand SevenHigh { get; } = new Hand
    {
        Name = "Seven High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfDiamonds,
                    Cards.SevenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfDiamonds,
                    Cards.SixOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfDiamonds,
                    Cards.FiveOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfDiamonds,
                    Cards.FourOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfDiamonds,
                    Cards.ThreeOfClubs
                }
            }
        }
    };

    public static Hand EightHigh { get; } = new Hand
    {
        Name = "Eight High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfDiamonds,
                    Cards.EightOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfDiamonds,
                    Cards.SevenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfDiamonds,
                    Cards.SixOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfDiamonds,
                    Cards.FiveOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfDiamonds,
                    Cards.FourOfClubs
                }
            }
        }
    };

    public static Hand NineHigh { get; } = new Hand
    {
        Name = "Nine High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfDiamonds,
                    Cards.NineOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfDiamonds,
                    Cards.EightOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfDiamonds,
                    Cards.SevenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfDiamonds,
                    Cards.SixOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfDiamonds,
                    Cards.FiveOfClubs
                }
            }
        }
    };

    public static Hand TenHigh { get; } = new Hand
    {
        Name = "Ten High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfDiamonds,
                    Cards.TenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfDiamonds,
                    Cards.NineOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfDiamonds,
                    Cards.EightOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfDiamonds,
                    Cards.SevenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfDiamonds,
                    Cards.SixOfClubs
                }
            }
        }
    };

    public static Hand JackHigh { get; } = new Hand
    {
        Name = "Jack High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfDiamonds,
                    Cards.JackOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfDiamonds,
                    Cards.TenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfDiamonds,
                    Cards.NineOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfDiamonds,
                    Cards.EightOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfDiamonds,
                    Cards.SevenOfClubs
                }
            }
        }
    };

    public static Hand QueenHigh { get; } = new Hand
    {
        Name = "Queen High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfDiamonds,
                    Cards.QueenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfDiamonds,
                    Cards.JackOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfDiamonds,
                    Cards.TenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfDiamonds,
                    Cards.NineOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfDiamonds,
                    Cards.EightOfClubs
                }
            }
        }
    };

    public static Hand KingHigh { get; } = new Hand
    {
        Name = "King High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfDiamonds,
                    Cards.KingOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfDiamonds,
                    Cards.QueenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfDiamonds,
                    Cards.JackOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfDiamonds,
                    Cards.TenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfDiamonds,
                    Cards.NineOfClubs
                }
            }
        }
    };

    public static Hand AceHigh { get; } = new Hand
    {
        Name = "Ace High Straight",
        HandDefinition = HandDefinitions.Straight,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfDiamonds,
                    Cards.AceOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfDiamonds,
                    Cards.KingOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfDiamonds,
                    Cards.QueenOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfDiamonds,
                    Cards.JackOfClubs
                }
            },
            new()
            {
                RequiredCount = 1,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfDiamonds,
                    Cards.TenOfClubs
                }
            }
        }
    };

    public static List<Hand> All { get; } = new()
    {
        SixHigh,
        SevenHigh,
        EightHigh,
        NineHigh,
        TenHigh,
        JackHigh,
        QueenHigh,
        KingHigh,
        AceHigh
    };
}
