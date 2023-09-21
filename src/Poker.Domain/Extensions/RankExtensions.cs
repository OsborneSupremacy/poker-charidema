namespace Poker.Domain.Extensions;

public static class RankExtensions
{
    public static Rank NextRank(this Rank input) =>
        Ranks.All.Where(r => r.Value == input.Value + 1).Single();
}
