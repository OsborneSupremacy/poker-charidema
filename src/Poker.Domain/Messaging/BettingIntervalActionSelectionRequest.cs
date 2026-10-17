namespace Poker.Domain.Messaging;

public record BettingIntervalActionSelectionRequest
{
    public required Participant ParticipantInTurn { get; init; }

    public required Bet CurrentBet { get; init; }

    public required int Pot { get; init; }

    public required BettingIntervalOptionsResponse Options { get; init; }
}
