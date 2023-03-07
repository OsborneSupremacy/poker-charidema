using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Library.RoundActions;

public record Flop : DealCards
{
    public Flop()
    {
        Count = 3;
        Name = "The Flop";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardDestinations.Community;
    }
}
