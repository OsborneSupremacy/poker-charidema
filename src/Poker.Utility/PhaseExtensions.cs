using Poker.Library.Interface;
using Poker.Library.Rounds;

namespace Poker.Utility;

public static class PhaseExtensions
{
    public static int GetCountOfCardsToDeal(this IPhase input)
    {
        if (input is not DealCards dealCards)
            return 0;
        return dealCards.Count.ToInt();
    }
}
