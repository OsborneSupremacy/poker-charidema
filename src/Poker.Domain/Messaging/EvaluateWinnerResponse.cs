namespace Poker.Domain.Messaging;

public class EvaluateWinnerResponse
{
    public required List<Participant> Winners { get; init; }

    public required List<ParticipantHand> ParticipantHands { get; init; }

    public required Hand WinningHand { get; init; }
}
