using Poker.Library;

namespace Poker.Utility;

public static class PlayerExtensions
{
    public static Player NextPlayer(this List<Player> players, Player currentPlayer)
    {
        var index = players
            .FindIndex(x => x.Id == currentPlayer.Id);

        if (index == players.Count - 1)
            return players.First();

        return players[index + 1];
    }
}
