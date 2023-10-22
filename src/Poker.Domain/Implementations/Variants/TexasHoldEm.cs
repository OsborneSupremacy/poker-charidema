namespace Poker.Domain.Implementations.Variants;

public static class TexasHoldEm
{
    public static Variant GetVariant() =>
        new()
        {
            Name = "Texas Hold 'Em",
            Phases = new()
            {
                new() {
                    Number = 0,
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
                    Number = 1,
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
                    Number = 2,
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
                    Number = 3,
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
                    Number = 4,
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
                    Number = 5,
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
                    Number = 6,
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
                    Number = 7,
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
                    Number = 8,
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
                    Number = 9,
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
                    Number = 10,
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
                    Number = 11,
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
