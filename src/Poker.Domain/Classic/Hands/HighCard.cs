﻿namespace Poker.Domain.Classic.Hands;

public static class HighCards
{
    public static Hand Two { get; } = new()
    {
        Name = "Two High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.TwoOfSpades, Cards.TwoOfHearts, Cards.TwoOfClubs, Cards.TwoOfDiamonds]
            }
        ]
    };

    public static Hand Three { get; } = new()
    {
        Name = "Three High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.ThreeOfSpades, Cards.ThreeOfHearts, Cards.ThreeOfClubs, Cards.ThreeOfDiamonds]
            }
        ]
    };

    public static Hand Four { get; } = new()
    {
        Name = "Four High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.FourOfSpades, Cards.FourOfHearts, Cards.FourOfClubs, Cards.FourOfDiamonds]
            }
        ]
    };

    public static Hand Five { get; } = new()
    {
        Name = "Five High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.FiveOfSpades, Cards.FiveOfHearts, Cards.FiveOfClubs, Cards.FiveOfDiamonds]
            }
        ]
    };

    public static Hand Six { get; } = new()
    {
        Name = "Six High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.SixOfSpades, Cards.SixOfHearts, Cards.SixOfClubs, Cards.SixOfDiamonds]
            }
        ]
    };

    public static Hand Seven { get; } = new()
    {
        Name = "Seven High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.SevenOfSpades, Cards.SevenOfHearts, Cards.SevenOfClubs, Cards.SevenOfDiamonds]
            }
        ]
    };

    public static Hand Eight { get; } = new()
    {
        Name = "Eight High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.EightOfSpades, Cards.EightOfHearts, Cards.EightOfClubs, Cards.EightOfDiamonds]
            }
        ]
    };

    public static Hand Nine { get; } = new()
    {
        Name = "Nine High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.NineOfSpades, Cards.NineOfHearts, Cards.NineOfClubs, Cards.NineOfDiamonds]
            }
        ]
    };

    public static Hand Ten { get; } = new()
    {
        Name = "Ten High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.TenOfSpades, Cards.TenOfHearts, Cards.TenOfClubs, Cards.TenOfDiamonds]
            }
        ]
    };

    public static Hand Jack { get; } = new()
    {
        Name = "Jack High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.JackOfSpades, Cards.JackOfHearts, Cards.JackOfClubs, Cards.JackOfDiamonds]
            }
        ]
    };

    public static Hand Queen { get; } = new()
    {
        Name = "Queen High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.QueenOfSpades, Cards.QueenOfHearts, Cards.QueenOfClubs, Cards.QueenOfDiamonds]
            }
        ]
    };

    public static Hand King { get; } = new()
    {
        Name = "King High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.KingOfSpades, Cards.KingOfHearts, Cards.KingOfClubs, Cards.KingOfDiamonds]
            }
        ]
    };

    public static Hand Ace { get; } = new()
    {
        Name = "Ace High",
        HandDefinition = HandDefinitions.HighCard,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 1,
                EligibleCards = [Cards.AceOfSpades, Cards.AceOfHearts, Cards.AceOfClubs, Cards.AceOfDiamonds]
            }
        ]
    };

}
