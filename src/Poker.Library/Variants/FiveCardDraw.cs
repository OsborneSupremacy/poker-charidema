namespace Poker.Library.Variants;

public record FiveCardDraw : Variant
{
    public override string Name => "5 Card Draw";

    public override List<RoundAction> RoundActions =>
        new()
        {
            new DealCardsAction()
            {
                Count = 5,
                Name = "Deal",
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new AcceptBetsAction(),
            new DrawCardsAction(),
            new AcceptBetsAction()
        };
}
