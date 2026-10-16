namespace Poker.Domain.Implementations.Variants;

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
                    PhaseType = PhaseType.Deal,
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
                    Name = "Third Street",
                    PhaseType = PhaseType.Deal,
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
                    Name = "Fourth Street",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
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
                    Name = "Fifth Street",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardOrientation = CardOrientation.FaceUp,
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
                    Name = "Sixth Street",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardOrientation = CardOrientation.FaceUp,
                    CardDestination = CardLocation.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 9,
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
                    Number = 10,
                    Name = "Seventh Street",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 1,
                    CardOrientation = CardOrientation.FaceDown,
                    CardDestination = CardLocation.PlayerHand,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 11,
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
                    Number = 12,
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
