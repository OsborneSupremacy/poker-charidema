namespace Poker.Domain.Messaging;

public record EvaluateLeadParticipantRequest
{
    public required List<CardInPlay> CommunityCards { get; init; }

    public required List<Participant> Participants { get; init; }
}
