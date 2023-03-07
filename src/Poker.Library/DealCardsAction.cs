using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Library;

public record DealCardsAction : RoundAction
{
    public string Name { get; set; }

    public uint Count { get; init; }

    public CardOrientations CardOrientation { get; init; }

    public CardDestinations CardDestination { get; init; }
}
