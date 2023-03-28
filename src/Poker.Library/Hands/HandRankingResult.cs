namespace Poker.Library.Hands;

public record HandRankingResult : IHandRankingResult
{
    public required bool Qualifies { get; init; }

    public required List<ICard> HandCards { get; init; }

    public required List<ICard> Kickers { get; init; }

    public required List<ICard> DeadCards { get; init; }
}
