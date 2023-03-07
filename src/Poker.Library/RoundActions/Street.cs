using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Library.RoundActions;

public record Street : DealCards
{
    public Street()
    {
        Count = 1;
        Name = "The Street";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardDestinations.Community;
    }
}
