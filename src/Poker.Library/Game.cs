namespace Poker.Library;

public record Game
{
    public List<Player> Players { get; init; }

    public List<Hand> Hands { get; init; }
}
