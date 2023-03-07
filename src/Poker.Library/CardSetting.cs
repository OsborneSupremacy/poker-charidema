using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Library;

public record CardSetting
{
    public CardOrientations CardOrientation { get; init; }

    public CardDestinations CardDestination { get; init; }
}
