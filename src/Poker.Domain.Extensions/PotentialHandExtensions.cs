namespace Poker.Domain.Extensions;

public static class PotentialHandExtensions
{
    public static bool EnoughRemainingCardsForHand(
        this List<PotentialHand> potentials, uint remainingCardCount
        ) =>
            remainingCardCount >= (
                GlobalConstants.HandSize - potentials.Max(x => x.Cards.Count)
            );
}
