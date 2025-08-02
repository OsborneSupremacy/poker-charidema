namespace Poker.Domain.Messaging;

public record EvaluateLeadParticipantRequest
{
    public required IReadOnlyList<CardInPlay> CommunityCards { get; init; }

    public required IReadOnlyList<Participant> Participants { get; init; }
}
