﻿namespace Poker.Domain.Classic.Hands;

public static class ThreeOfAKind
{
    public static Hand Twos { get; } = new()
    {
        Name = "Three Twos",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Threes { get; } = new()
    {
        Name = "Three Threes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Fours { get; } = new()
    {
        Name = "Three Fours",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Fives { get; } = new()
    {
        Name = "Three Fives",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Sixes { get; } = new()
    {
        Name = "Three Sixes",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Sevens { get; } = new()
    {
        Name = "Three Sevens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Eights { get; } = new()
    {
        Name = "Three Eights",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Nines { get; } = new()
    {
        Name = "Three Nines",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Tens { get; } = new()
    {
        Name = "Three Tens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Jacks { get; } = new()
    {
        Name = "Three Jacks",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Queens { get; } = new()
    {
        Name = "Three Queens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Kings { get; } = new()
    {
        Name = "Three Kings",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };

    public static Hand Aces { get; } = new()
    {
        Name = "Three Aces",
        HandDefinition = HandDefinitions.ThreeOfAKind,
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
            }
        }
    };
}
