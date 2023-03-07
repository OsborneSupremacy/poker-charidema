using Poker.Library.RoundActions;

namespace Poker.Library.Variants;

public record FiveCardDraw : Variant
{
    public override string Name => "5 Card Draw";

    public override List<RoundAction> RoundActions =>
        new()
        {
            new DealCards()
            {
                Count = 5,
                Name = "Deal",
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new AcceptBets(),
            new DrawCards(),
            new AcceptBets()
        };
}
