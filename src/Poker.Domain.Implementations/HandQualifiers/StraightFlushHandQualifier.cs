using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightFlushHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
        {

        };
}


