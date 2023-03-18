using Poker.Library.RoundActions;

namespace Poker.Library.Variants;

public record SevenCardStud : Variant
{
    public override string Name => "Seven Card Stud";

    public override List<RoundAction> RoundActions =>
        new()
        {
            new DealCards()
            {
                Count = 2,
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new DealCards()
            {
                Count = 1,
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardDestinations.PlayerHand
            },
            new BettingInterval(),
            new DealCards()
            {
                Count = 3,
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardDestinations.PlayerHand
            },
            new DealCards()
            {
                Count = 1,
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new BettingInterval()
        };
}
