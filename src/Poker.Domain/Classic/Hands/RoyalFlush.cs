﻿namespace Poker.Domain.Classic.Hands;

public static class RoyalFlushes
{
    public static Hand Spades { get; } = new()
    {
        Name = "Spades Royal Flush",
        HandDefinition = HandDefinitions.RoyalFlush,
        HighRank = Ranks.Ace,
        Suit = Suits.Spades,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.JackOfSpades,
                    Cards.QueenOfSpades,
                    Cards.KingOfSpades,
                    Cards.AceOfSpades
                }
            }
        }
    };

    public static Hand Hearts { get; } = new()
    {
        Name = "Hearts Royal Flush",
        HandDefinition = HandDefinitions.RoyalFlush,
        HighRank = Ranks.Ace,
        Suit = Suits.Hearts,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfHearts,
                    Cards.JackOfHearts,
                    Cards.QueenOfHearts,
                    Cards.KingOfHearts,
                    Cards.AceOfHearts
                }
            }
        }
    };

    public static Hand Diamonds { get; } = new()
    {
        Name = "Diamonds Royal Flush",
        HandDefinition = HandDefinitions.RoyalFlush,
        HighRank = Ranks.Ace,
        Suit = Suits.Diamonds,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfDiamonds,
                    Cards.JackOfDiamonds,
                    Cards.QueenOfDiamonds,
                    Cards.KingOfDiamonds,
                    Cards.AceOfDiamonds
                }
            }
        }
    };

    public static Hand Clubs { get; } = new()
    {
        Name = "Clubs Royal Flush",
        HandDefinition = HandDefinitions.RoyalFlush,
        HighRank = Ranks.Ace,
        Suit = Suits.Clubs,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfClubs,
                    Cards.JackOfClubs,
                    Cards.QueenOfClubs,
                    Cards.KingOfClubs,
                    Cards.AceOfClubs
                }
            }
        }
    };

    public static List<Hand> All { get; } = new()
    {
        Hearts,
        Spades,
        Diamonds,
        Clubs
    };
}
