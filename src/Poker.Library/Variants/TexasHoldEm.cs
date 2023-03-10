using Poker.Library.RoundActions;

namespace Poker.Library.Variants;

public record class TexasHoldEm : Variant
{
    public override string Name => "Texas Hold 'Em";

    public override List<RoundAction> RoundActions =>
        new()
        {
            new DealCards()
            {
                Count = 2,
                Name = "Deal",
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new AcceptBets(),
            new Flop(),
            new AcceptBets(),
            new Turn(),
            new AcceptBets(),
            new Street(),
            new AcceptBets()
        };
}
