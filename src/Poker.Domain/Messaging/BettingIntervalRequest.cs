namespace Poker.Domain.Messaging;

public record BettingIntervalRequest
{
    public required Bet CurrentBet { get; init; }

    public required int Pot { get; init; }

    public required Participant ParticipantInTurn { get; init; }

    public required List<Participant> ActiveParticipants { get; init; }
}
