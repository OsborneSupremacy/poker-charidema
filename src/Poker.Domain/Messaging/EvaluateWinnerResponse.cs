namespace Poker.Domain.Messaging;

public class EvaluateWinnerResponse
{
    public required IReadOnlyList<Participant> Winners { get; init; }

    public required IReadOnlyList<ParticipantHand> ParticipantHands { get; init; }

    public required Hand WinningHand { get; init; }
}
