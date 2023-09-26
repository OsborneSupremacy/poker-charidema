namespace Poker.Domain.Functions;

public static class RankFunctions
{
    /// <summary>
    /// Gets a list of ranks in descending order by value.
    /// </summary>
    /// <returns></returns>
    public static List<Rank> GetOrderedRanks() =>
        Ranks.All.OrderByDescending(x => x.Value).ToList();

}
