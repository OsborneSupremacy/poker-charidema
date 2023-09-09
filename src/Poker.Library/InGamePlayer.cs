namespace Poker.Library;

public record InGamePlayer : IInGamePlayer
{
    public required IPlayer Player { get; init; }

    public required List<ICard> Cards { get; init; }

    public required uint Stack { get; init; }

    public required bool Folded { get; init; }
}
