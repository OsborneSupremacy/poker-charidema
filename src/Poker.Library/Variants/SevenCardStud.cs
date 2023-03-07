using Poker.Library.RoundActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Library.Variants;

public record SevenCardStud : Variant
{
    public override string Name => "5 Card Draw";

    public override List<RoundAction> RoundActions =>
        new()
        {
            new DealCards()
            {
                Count = 2,
                Name = "Hole Cards",
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new AcceptBets(),
            new Flop(),
            new AcceptBets(),
            new Turn(),
            new AcceptBets(),
            new River(),
            new DrawCards(),
            new AcceptBets()
        };
}
