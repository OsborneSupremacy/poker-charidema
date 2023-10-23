namespace Poker.Domain.Classic.Hands;

public static class Pairs
{
    public static Hand Twos { get; } = new()
    {
        Name = "Pair of Twos",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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

    public static Hand Threes { get; } = new()
    {
        Name = "Pair of Threes",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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

    public static Hand Fours { get; } = new()
    {
        Name = "Pair of Fours",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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

    public static Hand Fives { get; } = new()
    {
        Name = "Pair of Fives",
        HandDefinition = HandDefinitions.Pair,
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
            }
        }
    };

    public static Hand Sixes { get; } = new()
    {
        Name = "Pair of Sixes",
        HandDefinition = HandDefinitions.Pair,
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
            }
        }
    };

    public static Hand Sevens { get; } = new()
    {
        Name = "Pair of Sevens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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

    public static Hand Eights { get; } = new()
    {
        Name = "Pair of Eights",
        HandDefinition = HandDefinitions.Pair,
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
            }
        }
    };

    public static Hand Nines { get; } = new()
    {
        Name = "Pair of Nines",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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

    public static Hand Tens { get; } = new()
    {
        Name = "Pair of Tens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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

    public static Hand Jacks { get; } = new()
    {
        Name = "Pair of Jacks",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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

    public static Hand Queens { get; } = new()
    {
        Name = "Pair of Queens",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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

    public static Hand Kings { get; } = new()
    {
        Name = "Pair of Kings",
        HandDefinition = HandDefinitions.Pair,
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
            }
        }
    };

    public static Hand Aces { get; } = new()
    {
        Name = "Pair of Aces",
        HandDefinition = HandDefinitions.Pair,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
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
}
