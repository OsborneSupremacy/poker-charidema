using Poker.Library.RoundActions;

namespace Poker.Library.Variants;

public record SevenCardStud : IVariant
{
    public string Name => "Seven Card Stud";

    public List<IRoundAction> RoundActions =>
        new()
        {
            new Ante(),
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
