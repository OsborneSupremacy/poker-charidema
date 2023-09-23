namespace Poker.Domain.Implementations;

public static class TexasHoldEm
{
    public static Variant GetVariant() =>
        new()
        {
            Name = "Texas Hold 'Em",
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
                    CardsToDrawMaximumOverrides = new()
                },
                new()
                {
                    Name = "Deal",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 2,
                    CardDestination = CardLocations.PlayerHand,
                    CardOrientation = CardOrientations.Facedown,
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
                    Name = "The Flop",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 2,
                    CardDestination = CardLocations.Community,
                    CardOrientation = CardOrientations.Faceup,
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
                    Name = "The Turn",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardDestination = CardLocations.Community,
                    CardOrientation = CardOrientations.Faceup,
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
                    Name = "The Street",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardDestination = CardLocations.Community,
                    CardOrientation = CardOrientations.Faceup,
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
                    Name = "The River",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardDestination = CardLocations.Community,
                    CardOrientation = CardOrientations.Faceup,
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
