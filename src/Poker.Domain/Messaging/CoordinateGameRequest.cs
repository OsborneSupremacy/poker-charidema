namespace Poker.Domain.Messaging;

public record CoordinateGameRequest
{
    public required Match Match { get; init; }

    public required IReadOnlyList<Player> Players { get; init; }

    public required Variant Variant { get; init; }

    public required Deck Deck { get; init; }

    public required Guid InitialButtonId { get; init; }

    /// <summary>
    /// The history of games played in this match, not including the current game.
    /// </summary>
    public required IList<GameResponse> GameHistory { get; init; }
}
