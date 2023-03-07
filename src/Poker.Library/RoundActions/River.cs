using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Poker.Library.RoundActions;

public record River : DealCards
{
    public River()
    {
        Count = 1;
        Name = "The River";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardDestinations.Community;
    }
}
