using Poker.Library.Interface;

namespace Poker.Utility;

public static class PlayerExtensions
{
    public static IPlayer NextPlayer(this List<IPlayer> players, IPlayer currentPlayer)
    {
        var index = players
            .FindIndex(x => x.Id == currentPlayer.Id);

        if (index == players.Count - 1)
            return players.First();

        return players[index + 1];
    }
}
