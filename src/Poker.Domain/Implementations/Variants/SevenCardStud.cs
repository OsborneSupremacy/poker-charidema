﻿namespace Poker.Domain.Implementations.Variants;

public static class SevenCardStud
{
    public static Variant GetVariant() =>
        new()
        {
            Name = "Seven Card Stud",
            Phases =
            [
                new()
                {
                    Number = 0,
                    Name = "Ante",
                    PhaseType = PhaseType.Ante,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocation.Empty,
                    CardOrientation = CardOrientation.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 1,
                    Name = "Deal",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 2,
                    CardOrientation = CardOrientation.FaceDown,
                    CardDestination = CardLocation.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 2,
                    Name = "Deal",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardOrientation = CardOrientation.FaceUp,
                    CardDestination = CardLocation.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 3,
                    Name = "Betting Interval",
                    PhaseType = PhaseType.BettingInterval,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocation.Empty,
                    CardOrientation = CardOrientation.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 4,
                    Name = "Deal",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 3,
                    CardOrientation = CardOrientation.FaceUp,
                    CardDestination = CardLocation.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 5,
                    Name = "Betting Interval",
                    PhaseType = PhaseType.BettingInterval,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocation.Empty,
                    CardOrientation = CardOrientation.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 6,
                    Name = "Deal",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardOrientation = CardOrientation.FaceDown,
                    CardDestination = CardLocation.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 7,
                    Name = "Betting Interval",
                    PhaseType = PhaseType.BettingInterval,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocation.Empty,
                    CardOrientation = CardOrientation.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 8,
                    Name = "Evaluation",
                    PhaseType = PhaseType.Evaluation,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocation.Empty,
                    CardOrientation = CardOrientation.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                }
            ]
        };
}
