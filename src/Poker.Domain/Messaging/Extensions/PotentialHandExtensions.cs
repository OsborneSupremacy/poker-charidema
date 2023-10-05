namespace Poker.Domain.Messaging.Extensions;

public static class PotentialHandExtensions
{
    public static bool EnoughRemainingCards(
        this List<PotentialHandMessage> potentials, uint remainingCardCount
        ) =>
            potentials.Any(x => x.EnoughRemainingCards(remainingCardCount));

    public static bool EnoughRemainingCards(
        this PotentialHandMessage input,
        uint remainingCardCount) =>
            remainingCardCount >= input.CardsNeededToComplete();

    public static int CardsNeededToComplete(this PotentialHandMessage input) =>
        GlobalConstants.HandSize - input.ContributingStandardCards.Count;
}
