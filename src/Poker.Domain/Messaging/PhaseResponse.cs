namespace Poker.Domain.Messaging;

public record PhaseResponse
{
    public required Deck Deck { get; init; }

    public required IReadOnlyList<CardInPlay> CommunityCards { get; init; }

    public required IReadOnlyList<Participant> Participants { get; init; }

    public required IReadOnlyList<Participant> Winners { get; init; }

    public required bool GameOver { get; init; }

    public required int Pot { get; init; }
}
