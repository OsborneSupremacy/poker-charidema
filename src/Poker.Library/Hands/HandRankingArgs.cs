namespace Poker.Library.Hands;

public record HandRankingArgs : IHandRankingArgs
{
    public required IDeck Deck { get; init; }

    public required List<ICard> PlayerCards { get; init; }
}
