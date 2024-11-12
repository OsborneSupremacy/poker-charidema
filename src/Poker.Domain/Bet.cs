namespace Poker.Domain;

public record Bet
{
    public required int Amount { get; init; }

    public required Guid InitiatingPlayerId { get; init; }

    public required List<Guid> CheckedPlayerIds { get; init; }

    public required List<ContributingPlayer> ContributingPlayers { get; init; }

    /// <summary>
    /// IDs of players who are done with this bet for whatever reason.
    /// </summary>
    public required List<Guid> TerminalPlayerIds { get; init; }
}

public static class Bets
{
    public static Bet Empty => new()
    {
        Amount = 0,
        InitiatingPlayerId = Players.Empty.Id,
        CheckedPlayerIds = [],
        ContributingPlayers = [],
        TerminalPlayerIds = []
    };
}
