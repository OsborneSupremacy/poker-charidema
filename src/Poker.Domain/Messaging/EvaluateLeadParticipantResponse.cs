namespace Poker.Domain.Messaging;

public record EvaluateLeaderPlayerResponse
{
    public required IReadOnlyList<Participant> LeadParticipants { get; init; }

    public required IReadOnlyList<ParticipantHand> ParticipantHands { get; init; }

    public required Hand LeadingHand { get; init; }
}
