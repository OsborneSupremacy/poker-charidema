namespace Poker.Domain.Messaging;

public record EvaluateLeaderPlayerResponse
{
    public required List<Player> LeadPlayers { get; init; }

    public required List<PlayerHand> PlayerHands { get; init; }

    public required Hand LeadingHand { get; init; }
}
