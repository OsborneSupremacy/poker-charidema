namespace Poker.Domain.Implementations.Variants;

public static class FiveCardDraw
{
    public static Variant GetVariant() =>
        new()
        {
            Name = "Five Card Draw",
            Phases =
            [
                new()
                {
                    Number = 0,
                    Name = "Ante",
                    PhaseType = PhaseType.Ante,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 1,
                    Name = "Deal",
                    PhaseType = PhaseType.Deal,
                    GameCanEndAfter = false,
                    CardsToDealCount = 5,
                    CardDestination = CardLocations.PlayerHand,
                    CardOrientation = CardOrientations.FaceDown,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
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
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 3,
                    Name = "Draw",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 3,
                    CardsToDrawMaximumOverrides = [new() { Rank = Ranks.Ace, Maximum = 4 }]
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
                    CardsToDrawMaximumOverrides = []
                },

                new()
                {
                    Number = 5,
                    Name = "Evaluation",
                    PhaseType = PhaseType.Evaluation,
                    GameCanEndAfter = true,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 0,
                    CardsToDrawMaximumOverrides = []
                }
            ]
        };
}
