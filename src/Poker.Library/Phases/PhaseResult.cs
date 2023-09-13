namespace Poker.Library.Phases;

public record PhaseResult
{
    public required IDeck Deck { get; init; }

    public required List<ICard> CommunityCards { get; init; }

    public required List<IInGamePlayer> Players { get; init; }

    public required bool GameOver { get; init; }

    public required uint Pot { get; init; }
}
