namespace Poker.Domain.Extensions;

public static class PlayerExtensions
{
    public static Player NextPlayer(
        this List<Player> players,
        Player currentPlayer
        )
    {
        var index = players
            .FindIndex(x => x.Id == currentPlayer.Id);

        return index == players.Count - 1 ? players.First() : players[index + 1];
    }

    public static Player HumanPlayer(this IEnumerable<Player> players) =>
        players.Single(x => !x.Automaton);

    /// <summary>
    /// ParticipatingPlayers that are still in the match, i.e. not busted.
    /// </summary>
    /// <param name="players"></param>
    /// <returns></returns>
    public static IEnumerable<Player> InMatch(this IEnumerable<Player> players) =>
        players.Where(x => !x.Busted());

    public static IReadOnlyList<Player> Richest(this IReadOnlyList<Player> players) =>
        players.Where(x => x.Stack == players.Max(p => p.Stack)).ToList();

    public static IReadOnlyList<Player> NotBusted(this IReadOnlyList<Player> players) =>
        players.Where(x => !x.Busted()).ToList();
}
