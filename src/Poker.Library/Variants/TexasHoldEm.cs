using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Library.Variants;

public record class TexasHoldEm : Variant
{
    public override string Name => "Texas Hold 'Em";

    public override List<RoundAction> RoundActions =>
        new()
        {
            new DealCardsAction()
            {
                Count = 2,
                Name = "Deal",
                CardOrientation = CardOrientations.Facedown,
                CardDestination = CardDestinations.PlayerHand
            },
            new AcceptBetsAction(),
            new DealCardsAction()
            {
                Count = 3,
                Name = "Flop",
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardDestinations.Community
            },
            new AcceptBetsAction(),
            new DealCardsAction()
            {
                Count = 1,
                Name = "The Turn",
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardDestinations.Community
            },
            new AcceptBetsAction(),
            new DealCardsAction()
            {
                Count = 1,
                Name = "The Street",
                CardOrientation = CardOrientations.Faceup,
                CardDestination = CardDestinations.Community
            },
            new AcceptBetsAction()
        };
}
