namespace Poker.Domain.Messaging;

public record EvaluateLeadPlayerRequest
{
    public required List<CardInPlay> CommunityCards { get; init; }

    public required List<Player> Players { get; init; }
}
