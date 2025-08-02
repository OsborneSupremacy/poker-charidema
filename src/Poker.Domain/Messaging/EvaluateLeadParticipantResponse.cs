namespace Poker.Domain.Messaging;

public record EvaluateLeaderPlayerResponse
{
    public required List<Participant> LeadParticipants { get; init; }

    public required List<ParticipantHand> ParticipantHands { get; init; }

    public required Hand LeadingHand { get; init; }
}
