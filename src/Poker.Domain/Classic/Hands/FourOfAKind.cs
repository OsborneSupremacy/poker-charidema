namespace Poker.Domain.Classic.Hands;

public static class FourOfAKind
{
    public static Hand Twos { get; } = new()
    {
        Name = "Four Twos",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds,
                    Cards.TwoOfSpades 
                }
            }
        }
    };

    public static Hand Threes { get; } = new()
    {
        Name = "Four Threes",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds,
                    Cards.ThreeOfSpades                  
                }
            }
        }
    };

    public static Hand Fours { get; } = new()
    {
        Name = "Four Fours",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds,
                    Cards.FourOfSpades                  
                }
            }
        }
    };

    public static Hand Fives { get; } = new()
    {
        Name = "Four Fives",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds,
                    Cards.FiveOfSpades                  
                }
            }
        }
    };

    public static Hand Sixes { get; } = new()
    {
        Name = "Four Sixes",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds,
                    Cards.SixOfSpades                  
                }
            }
        }
    };

    public static Hand Sevens { get; } = new()
    {
        Name = "Four Sevens",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds,
                    Cards.SevenOfSpades                  
                }
            }
        }
    };

    public static Hand Eights { get; } = new()
    {
        Name = "Four Eights",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds,
                    Cards.EightOfSpades                  
                }
            }
        }
    };

    public static Hand Nines { get; } = new()
    {
        Name = "Four Nines",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds,
                    Cards.NineOfSpades                  
                }
            }
        }
    };

    public static Hand Tens { get; } = new()
    {
        Name = "Four Tens",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds,
                    Cards.TenOfSpades                  
                }
            }
        }
    };

    public static Hand Jacks { get; } = new()
    {
        Name = "Four Jacks",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds,
                    Cards.JackOfSpades                  
                }
            }
        }
    };

    public static Hand Queens { get; } = new()
    {
        Name = "Four Queens",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds,
                    Cards.QueenOfSpades                  
                }
            }
        }
    };

    public static Hand Kings { get; } = new()
    {
        Name = "Four Kings",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds,
                    Cards.KingOfSpades                  
                }
            }
        }
    };

    public static Hand Aces { get; } = new()
    {
        Name = "Four Aces",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 4,
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds,
                    Cards.AceOfSpades                  
                }
            }
        }
    };
}
