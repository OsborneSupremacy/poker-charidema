namespace Poker.Domain.Messaging;

public record BettingIntervalRequest
{
    public required Bet CurrentBet { get; init; }

    public required int Pot { get; init; }

    public required bool APlayerIsAllIn { get; init; }

    public required Participant ParticipantInTurn { get; init; }

    public required IReadOnlyList<Participant> ActiveParticipants { get; init; }

    public required Action<string> EmitObservation { get; init; }
}
