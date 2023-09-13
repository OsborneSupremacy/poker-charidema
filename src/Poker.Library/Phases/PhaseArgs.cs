namespace Poker.Library.Phases;

public record PhaseArgs
{
    public required Game Game { get; init; }

    public required IPhase Phase { get; init; }

    public required IDeck Deck { get; init; }

    public required List<ICard> CommunityCards { get; init; }

    public required IInGamePlayer StartingPlayer { get; init; }

    public required uint Pot { get; init; }
}
