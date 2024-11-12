namespace Poker.Domain.Extensions;

public static class ContributingPlayerExtensions
{
    public static bool PaidUp(this ContributingPlayer player, int currentBet) =>
        player.Amount >= currentBet;

    public static IEnumerable<ContributingPlayer> PaidUp(this IEnumerable<ContributingPlayer> players, int currentBet) =>
        players.Where(p => p.PaidUp(currentBet));
}
