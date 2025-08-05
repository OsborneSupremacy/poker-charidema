namespace Poker.Domain.Messaging;

public class BettingIntervalOptionsRequest
{
    public required Guid ParticipantInTurnId { get; init; }

    public required Bet CurrentBet { get; init; }

    public required IReadOnlyList<Participant> ActiveParticipants { get; init; }
}
