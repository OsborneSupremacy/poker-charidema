namespace Poker.Library.Variants;

public static class FiveCardDraw
{
    public static Variant GetVariant() =>
        new()
        {
            Name = "Five Card Draw",
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
                    CardsToDealCount = 5,
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
                    Name = "Draw",
                    PhaseType = PhaseType.Draw,
                    GameCanEndAfter = false,
                    CardsToDealCount = 0,
                    CardDestination = CardLocations.Empty,
                    CardOrientation = CardOrientations.Empty,
                    CardsToDrawMaximum = 3,
                    CardsToDrawMaximumOverrides = new() {
                        new()
                        {
                            Rank = Ranks.Ace,
                            Maximum  = 4
                        }
                    }
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
