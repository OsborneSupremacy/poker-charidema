namespace Poker.Domain.Messaging;

public record BettingIntervalResponse
{
    public required string Description { get; init; }

    public required Bet CurrentBet { get; init; }

    public required int Pot { get; init; }

    public required Player PlayerInTurn { get; init; }

    /// <summary>
    /// Whether the betting interval should be closed. e.g., every player has either called or folded.
    /// </summary>
    public required bool CloseBetting { get; init; }
}

public static class BettingIntervalResponses
{
    public static BettingIntervalResponse Empty { get; } = new()
    {
        CurrentBet = Bets.Empty,
        Description = string.Empty,
        Pot = 0,
        PlayerInTurn = Players.Empty,
        CloseBetting = false
    };
}
