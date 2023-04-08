namespace Poker.Library.RoundActions;

public record RoundActionResult
{
    public required List<Player> Players { get; init; }

    public required bool GameOver { get; init; }
}
