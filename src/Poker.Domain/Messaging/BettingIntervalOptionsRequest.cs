namespace Poker.Domain.Messaging;

public class BettingIntervalOptionsRequest
{
    public required Bet CurrentBet { get; init; }

    public required List<Participant> ActiveParticipants { get; init; }
}
