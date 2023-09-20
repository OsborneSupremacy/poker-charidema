namespace Poker.Domain.Extensions;

public static class PotentialHandExtensions
{
    public static bool EnoughRemainingCards(
        this List<PotentialHand> potentials, uint remainingCardCount
        ) =>
            potentials.Any(x => x.EnoughRemainingCards(remainingCardCount));

    public static bool EnoughRemainingCards(
        this PotentialHand input,
        uint remainingCardCount) =>
            remainingCardCount >= input.CardsNeededToComplete();

    public static int CardsNeededToComplete(this PotentialHand input) =>
        GlobalConstants.HandSize - input.Cards.Count;
}
