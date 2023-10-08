namespace Poker.Domain.Messaging.Extensions;

internal static class PotentialHandExtensions
{
    /// <summary>
    /// What is the highest rank will be if the hand is completed.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static Rank TheoreticalHighRank(this PotentialHandMessage input)
    {
        var neededHighRank = input
            .NeededCardMessage.Cards.Select(x => x.Rank)
            .High();

        return input.HighRank.Value >= neededHighRank.Value
            ? input.HighRank
            : neededHighRank;
    }

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
