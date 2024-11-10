namespace Poker.Domain.Messaging;

public record BettingIntervalResponse
{
    public required Bet CurrentBet { get; init; }

    public required int Pot { get; init; }

    public required Player PlayerInTurn { get; init; }
}
