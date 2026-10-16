namespace Poker.Domain.Messaging;

public record BettingIntervalOptionsRequest
{
    public required Guid ParticipantInTurnId { get; init; }

    public required Bet CurrentBet { get; init; }

    public required bool APlayerIsAllIn {get; init; }

    public required IReadOnlyList<Participant> ActiveParticipants { get; init; }
}
