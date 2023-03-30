namespace Poker.Library.Hands;

public record PartialHandRankingResult : IPartialHandRankingResult
{
    public required bool Qualifies { get; init; }

    public required List<ICard> HandCards { get; init; }

    public required List<ICard> NonHandCards { get; init; }
}
