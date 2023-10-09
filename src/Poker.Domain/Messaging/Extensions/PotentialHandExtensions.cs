namespace Poker.Domain.Messaging.Extensions;

internal static class PotentialHandExtensions
{
    /// <summary>
    /// What the highest rank will be if the hand is completed.
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static Rank TheoreticalHighRank(this PotentialHandMessage input)
    {
        var neededHighRank = input
            .NeededCardMessage.Cards.SelectMany(x => x.Ranks)
            .High();

        return input.HighRank.Value >= neededHighRank.Value
            ? input.HighRank
            : neededHighRank;
    }

    public static IEnumerable<PotentialHandMessage> WhereComplete(
        this IEnumerable<PotentialHandMessage> potentials
    ) =>
        potentials.Where(x => x.Complete);

    public static IEnumerable<PotentialHandMessage> WithEnoughRemainingCards(
        this IEnumerable<PotentialHandMessage> potentials
        ) =>
            potentials.Where(x => x.EnoughRemainingCards());

    public static bool AnyWithEnoughRemainingCards(
        this IEnumerable<PotentialHandMessage> potentials
        ) =>
            potentials.WithEnoughRemainingCards().Any();

    public static bool EnoughRemainingCards(
        this PotentialHandMessage input
        ) =>
            input.RemainingCardCount >= input.NeeededCardCount();

    public static uint NeeededCardCount(this PotentialHandMessage input) =>
        input.NeededCardMessage.Cards.Count.ToUint();

    public static IEnumerable<PotentialHandMessage> WithFewestNeededCards(
        this IEnumerable<PotentialHandMessage> potentials
    ) =>
        potentials
            .Where(x => x.NeeededCardCount() == potentials.FewestNeededCards());

    public static uint FewestNeededCards(this IEnumerable<PotentialHandMessage> potentials) =>
        potentials
            .Select(x => x.NeeededCardCount())
            .Min();

    public static string AggregateValue(this PotentialHandMessage input)
    {
        var cardValues = input
            .AllContributingCards()
            .Select(x => x.Value);

        return string.Join('|', cardValues.OrderBy(v => v));
    }

    public static List<Card> AllContributingCards(this PotentialHandMessage input) =>
        input
            .ContributingStandard
            .Concat(
                input.ContributingWild.Select(x => x.StandardCard)
            )
            .ToList();
}
