using Poker.Library.Phases;
using Poker.Library.Rounds;

namespace Poker.Library.Variants;

public record FiveCardDraw : IVariant
{
    public string Name => "Five Card Draw";

    public List<IPhase> Phases =>
        new()
        {
            new Ante(),
            new DealCards()
            {
                Count = 5,
                Name = "Deal",
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardLocations.PlayerHand
            },
            new BettingInterval(),
            new DrawCards()
            {
                Maximum = 5,
                Overrides = new()
            },
            new BettingInterval()
        };
}
