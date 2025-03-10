﻿namespace Poker.Domain.Classic.Hands;

public static class FourOfAKind
{
    public static Hand Twos { get; } = new()
    {
        Name = "Four Twos",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand Threes { get; } = new()
    {
        Name = "Four Threes",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand Fours { get; } = new()
    {
        Name = "Four Fours",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand Fives { get; } = new()
    {
        Name = "Four Fives",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand Sixes { get; } = new()
    {
        Name = "Four Sixes",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand Sevens { get; } = new()
    {
        Name = "Four Sevens",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand Eights { get; } = new()
    {
        Name = "Four Eights",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand Nines { get; } = new()
    {
        Name = "Four Nines",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand Tens { get; } = new()
    {
        Name = "Four Tens",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand Jacks { get; } = new()
    {
        Name = "Four Jacks",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand Queens { get; } = new()
    {
        Name = "Four Queens",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand Kings { get; } = new()
    {
        Name = "Four Kings",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand Aces { get; } = new()
    {
        Name = "Four Aces",
        HandDefinition = HandDefinitions.FourOfAKind,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 4,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

}
