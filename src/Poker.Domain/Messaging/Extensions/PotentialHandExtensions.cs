namespace Poker.Domain.Messaging.Extensions;

internal static class PotentialHandExtensions
{
    public static bool AnyWithEnoughRemainingCards(
        this List<PotentialHandMessage> potentials
        ) =>
            potentials.Any(x => x.EnoughRemainingCards());

    public static bool EnoughRemainingCards(
        this PotentialHandMessage input
        ) =>
            input.RemainingCardCount >= input.NeededCardMessage.Cards.Count;

    public static string AggregateValue(this PotentialHandMessage input)
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
