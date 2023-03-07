using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Poker.Library.RoundActions;

public record Turn : DealCards
{
    public Turn()
    {
        Count = 1;
        Name = "The Turn";
        CardOrientation = CardOrientations.Faceup;
        CardDestination = CardDestinations.Community;
    }
}
