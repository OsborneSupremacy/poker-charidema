using Poker.Library.Interface;

namespace Poker.Utility;

public static class InGamePlayerExtensions
{
    public static IInGamePlayer NextPlayer(this List<IInGamePlayer> players, IInGamePlayer currentPlayer)
    {
        var index = players
            .FindIndex(x => x.Player.Id == currentPlayer.Player.Id);

        if (index == players.Count - 1)
            return players.First();

        return players[index + 1];
    }
}
