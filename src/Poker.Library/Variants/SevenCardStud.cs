using Poker.Domain.Classic;

namespace Poker.Library.Variants;

public record SevenCardStud
{
    public static Variant GetVariant() =>
        new()
        {
            Name = "Seven Card Stud",
            Phases = new()
            {
                new() {
                    Name = "Ante",
                    PhaseType = PhaseType.Ante,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new ()
                },
                new()
                {
                    Name = "Deal",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 2,
                    CardOrientation = CardOrientations.Facedown,
                    CardDestination = CardLocations.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new()
                },
                new()
                {
                    Name = "Deal",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardOrientation = CardOrientations.Faceup,
                    CardDestination = CardLocations.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new()
                },
                new()
                {
                    Name = "Betting Interval",
                    PhaseType = PhaseType.BettingInterval,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new()
                },
                new()
                {
                    Name = "Deal",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 3,
                    CardOrientation = CardOrientations.Faceup,
                    CardDestination = CardLocations.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new()
                },
                new()
                {
                    Name = "Betting Interval",
                    PhaseType = PhaseType.BettingInterval,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new()
                },
                new()
                {
                    Name = "Deal",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardOrientation = CardOrientations.Facedown,
                    CardDestination = CardLocations.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new()
                },
                new()
                {
                    Name = "Betting Interval",
                    PhaseType = PhaseType.BettingInterval,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new()
                },
                new()
                {
                    Name = "Evaluation",
                    PhaseType = PhaseType.Evaluation,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = new()
                }
            }
        };
}
