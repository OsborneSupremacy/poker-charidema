﻿namespace Poker.Domain.Classic.Hands;

/// <summary>
/// Five-of-a-Kind is not a classic Poker hand. It is not always allowed. It can only be
/// met with a wild card, and when that happens the wild card has to impersonate another
/// card that the player is holding (or a card being impersonated by another wild card).
/// 
/// Because of that, the typically strategy for determining if a player's card satisfy a 
/// hand's requirement don't work, because it assumes that a player can only have one of the
/// same card in their hard. We could change that assumption, but the assumption is useful
/// in every other scenario, and working around it would required complexity to be added
/// to <see cref="Functions.HandCollectionEvaluator"/>.
/// 
/// So we're getting around this by adding the same card to the list of
/// <see cref="HandSegment.EligibleCards"/> for each possible Five-of-a-Kind, giving it
/// a different Id so that it's not considered identical to the original card. We only
/// need to add a second Spade, because we'll only ever need one "duplicate" standard card 
/// (Spade being the highest <see cref="Suit.Priority"/> (not value) suit in this application.
/// By doing that, a wild card can impersonate the second spade, and we can continue to 
/// make the useful assumption described earlier.
/// </summary>
public record FiveOfAKind
{
    public static Hand Twos { get; } = new()
    {
        Name = "Five Twos",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds,
                    Cards.TwoOfSpades with { }
                }
            }
        }
    };

    public static Hand Threes { get; } = new()
    {
        Name = "Five Threes",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds,
                    Cards.ThreeOfSpades with { }
                }
            }
        }
    };

    public static Hand Fours { get; } = new()
    {
        Name = "Five Fours",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds,
                    Cards.FourOfSpades with { }
                }
            }
        }
    };

    public static Hand Fives { get; } = new()
    {
        Name = "Five Fives",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds,
                    Cards.FiveOfSpades with { }
                }
            }
        }
    };

    public static Hand Sixes { get; } = new()
    {
        Name = "Five Sixes",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds,
                    Cards.SixOfSpades with { }
                }
            }
        }
    };

    public static Hand Sevens { get; } = new()
    {
        Name = "Five Sevens",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds,
                    Cards.SevenOfSpades with { }
                }
            }
        }
    };

    public static Hand Eights { get; } = new()
    {
        Name = "Five Eights",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds,
                    Cards.EightOfSpades with { }
                }
            }
        }
    };

    public static Hand Nines { get; } = new()
    {
        Name = "Five Nines",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds,
                    Cards.NineOfSpades with { }
                }
            }
        }
    };

    public static Hand Tens { get; } = new()
    {
        Name = "Five Tens",
        HandDefinition = HandDefinitions.ThreeOfAKind,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds,
                    Cards.TenOfSpades with { }
                }
            }
        }
    };

    public static Hand Jacks { get; } = new()
    {
        Name = "Five Jacks",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds,
                    Cards.JackOfSpades with { }
                }
            }
        }
    };

    public static Hand Queens { get; } = new()
    {
        Name = "Five Queens",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds,
                    Cards.QueenOfSpades with { }
                }
            }
        }
    };

    public static Hand Kings { get; } = new()
    {
        Name = "Five Kings",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds,
                    Cards.KingOfSpades with { }
                }
            }
        }
    };

    public static Hand Aces { get; } = new()
    {
        Name = "Five Aces",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments = new List<HandSegment>
        {
            new()
            {
                RequiredCount = 5,
                EligibleCards = new()
                {
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds,
                    Cards.AceOfSpades with { }
                }
            }
        }
    };

    public static List<Hand> All { get; } = new()
    {
        Twos,
        Threes,
        Fours,
        Fives,
        Sixes,
        Sevens,
        Eights,
        Nines,
        Tens,
        Jacks,
        Queens,
        Kings,
        Aces
    };
}
