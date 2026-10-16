namespace Poker.Domain.Functions.Classic;

/// <summary>
/// Compares participant hands using classic poker rules. The hand with the higher hand definition wins.
/// Between hands with the same definition, the contributing cards decide, larger groups of the same rank
/// first (e.g. the three of a kind in a full house before its pair), then higher ranks first. If those are
/// equal, the kickers decide, highest first.
/// </summary>
public static class ClassicHandComparer
{
    public static readonly Comparison<ParticipantHand> Compare = (x, y) =>
    {
        var definitionDifference = x.Hand.HandDefinition.Value
            .CompareTo(y.Hand.HandDefinition.Value);

        return definitionDifference != 0
            ? definitionDifference
            : CompareRankValues(GetRankValues(x), GetRankValues(y));
    };

    public static IComparer<ParticipantHand> Comparer { get; } =
        Comparer<ParticipantHand>.Create(Compare);

    private static List<int> GetRankValues(ParticipantHand playerHand) =>
        GetContributingRankValues(playerHand)
            .Concat(GetKickerRankValues(playerHand))
            .ToList();

    /// <summary>
    /// Wild cards count as the card they are designated as.
    /// </summary>
    private static IEnumerable<int> GetContributingRankValues(ParticipantHand playerHand) =>
        playerHand.HandCards
            .AllStandardized()
            .GroupBy(c => c.Rank.Value)
            .OrderByDescending(g => g.Count())
            .ThenByDescending(g => g.Key)
            .SelectMany(g => g.Select(c => c.Rank.Value));

    /// <summary>
    /// Wild kickers count as aces, the highest rank.
    /// </summary>
    private static IEnumerable<int> GetKickerRankValues(ParticipantHand playerHand) =>
        playerHand.Kickers
            .Select(k => k.IsWild ? Ranks.Ace.Value : k.Rank.Value)
            .OrderDescending();

    /// <summary>
    /// The first pair of rank values that differ decides. If all compared rank values
    /// are equal, having more rank values wins.
    /// </summary>
    private static int CompareRankValues(List<int> x, List<int> y)
    {
        var firstDifference = x
            .Zip(y, (xValue, yValue) => xValue.CompareTo(yValue))
            .FirstOrDefault(c => c != 0);

        return firstDifference != 0 ? firstDifference : x.Count.CompareTo(y.Count);
    }
}
