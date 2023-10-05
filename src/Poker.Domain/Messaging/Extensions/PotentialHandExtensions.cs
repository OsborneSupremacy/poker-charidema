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
        GlobalConstants.HandSize - input.AllContributingCards().Count;

    public static string AggregateId(this PotentialHandMessage input)
    {
        var cardValues = input
            .AllContributingCards()
            .Select(x => x.Value);

        return string.Join('|', cardValues.OrderBy(v => v));
    }

    public static List<Card> AllContributingCards(this PotentialHandMessage input) =>
        input
            .ContributingStandardCards
            .Concat(
                input.ContributingWildCards.Select(x => x.StandardCard)
            )
            .ToList();
}
