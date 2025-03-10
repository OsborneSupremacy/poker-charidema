﻿namespace Poker.Domain.Classic.Hands;

/// <summary>
/// Five-of-a-Kind is not a classic Poker hand. It is not always allowed. It can only be
/// met with a wild card, and when that happens the wild card has to impersonate another
/// card that the player is holding (or a card being impersonated by another wild card).
///
/// Because of that, the typical strategies for determining if a player's card satisfy a
/// hand's requirement don't work, because it assumes that a player can only have one of the
/// same card in their hard. We could change that assumption, but the assumption is useful
/// in every other scenario, and working around it would require complexity to be added
/// to <see cref="Functions.Classic.ClassicHandEvaluator"/>.
///
/// So we're getting around this by adding the same card to the list of
/// <see cref="HandSegment.EligibleCards"/> for each possible Five-of-a-Kind, giving it
/// a different Id so that it's not considered identical to the original card. We only
/// need to add a second Spade, because we'll only ever need one "duplicate" standard card
/// (Spade being the highest <see cref="Suit.Priority"/> [not value] suit in this application).
/// By doing that, a wild card can impersonate the second spade, and we can continue to
/// make the useful assumption described earlier.
/// </summary>
// ReSharper disable once ClassNeverInstantiated.Global
public record FiveOfAKind
{
    public static Hand Twos { get; } = new()
    {
        Name = "Five Twos",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Two,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.TwoOfSpades,
                    Cards.TwoOfHearts,
                    Cards.TwoOfClubs,
                    Cards.TwoOfDiamonds,
                    Cards.TwoOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Threes { get; } = new()
    {
        Name = "Five Threes",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Three,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.ThreeOfSpades,
                    Cards.ThreeOfHearts,
                    Cards.ThreeOfClubs,
                    Cards.ThreeOfDiamonds,
                    Cards.ThreeOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Fours { get; } = new()
    {
        Name = "Five Fours",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Four,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.FourOfSpades,
                    Cards.FourOfHearts,
                    Cards.FourOfClubs,
                    Cards.FourOfDiamonds,
                    Cards.FourOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Fives { get; } = new()
    {
        Name = "Five Fives",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Five,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.FiveOfSpades,
                    Cards.FiveOfHearts,
                    Cards.FiveOfClubs,
                    Cards.FiveOfDiamonds,
                    Cards.FiveOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Sixes { get; } = new()
    {
        Name = "Five Sixes",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Six,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SixOfSpades,
                    Cards.SixOfHearts,
                    Cards.SixOfClubs,
                    Cards.SixOfDiamonds,
                    Cards.SixOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Sevens { get; } = new()
    {
        Name = "Five Sevens",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Seven,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.SevenOfSpades,
                    Cards.SevenOfHearts,
                    Cards.SevenOfClubs,
                    Cards.SevenOfDiamonds,
                    Cards.SevenOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Eights { get; } = new()
    {
        Name = "Five Eights",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Eight,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.EightOfSpades,
                    Cards.EightOfHearts,
                    Cards.EightOfClubs,
                    Cards.EightOfDiamonds,
                    Cards.EightOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Nines { get; } = new()
    {
        Name = "Five Nines",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Nine,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.NineOfSpades,
                    Cards.NineOfHearts,
                    Cards.NineOfClubs,
                    Cards.NineOfDiamonds,
                    Cards.NineOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Tens { get; } = new()
    {
        Name = "Five Tens",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Ten,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.TenOfSpades,
                    Cards.TenOfHearts,
                    Cards.TenOfClubs,
                    Cards.TenOfDiamonds,
                    Cards.TenOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Jacks { get; } = new()
    {
        Name = "Five Jacks",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Jack,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.JackOfSpades,
                    Cards.JackOfHearts,
                    Cards.JackOfClubs,
                    Cards.JackOfDiamonds,
                    Cards.JackOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Queens { get; } = new()
    {
        Name = "Five Queens",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Queen,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.QueenOfSpades,
                    Cards.QueenOfHearts,
                    Cards.QueenOfClubs,
                    Cards.QueenOfDiamonds,
                    Cards.QueenOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Kings { get; } = new()
    {
        Name = "Five Kings",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.King,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.KingOfSpades,
                    Cards.KingOfHearts,
                    Cards.KingOfClubs,
                    Cards.KingOfDiamonds,
                    Cards.KingOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

    public static Hand Aces { get; } = new()
    {
        Name = "Five Aces",
        HandDefinition = HandDefinitions.FiveOfAKind,
        HighRank = Ranks.Ace,
        Suit = Suits.Empty,
        HandSegments =
        [
            new()
            {
                RequiredCount = 5,
                EligibleCards =
                [
                    Cards.AceOfSpades,
                    Cards.AceOfHearts,
                    Cards.AceOfClubs,
                    Cards.AceOfDiamonds,
                    Cards.AceOfSpades with { Suit = Suits.Spades with { Priority = 0 } }
                ]
            }
        ]
    };

}
