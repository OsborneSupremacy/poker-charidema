namespace Poker.Domain.Extensions;

public static class PlayerExtensions
{
    public static Player NextPlayer(
        this List<Player> players,
        Player currentPlayer
        )
    {
        var index = players
            .FindIndex(x => x.Participant.Id == currentPlayer.Participant.Id);

        if (index == players.Count - 1)
            return players.First();

        return players[index + 1];
    }
}
