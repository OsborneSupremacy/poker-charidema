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

    public static List<Player> GetRichest(this List<Player> players) =>
        players.Where(x => x.Stack == players.Max(p => p.Stack)).ToList();
}
