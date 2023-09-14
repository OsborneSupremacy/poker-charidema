using Poker.Library;

namespace Poker.Utility;

public static class InGamePlayerExtensions
{
    public static InGamePlayer NextPlayer(this List<InGamePlayer> players, InGamePlayer currentPlayer)
    {
        var index = players
            .FindIndex(x => x.Participant.Id == currentPlayer.Participant.Id);

        if (index == players.Count - 1)
            return players.First();

        return players[index + 1];
    }
}
