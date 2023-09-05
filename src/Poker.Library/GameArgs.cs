namespace Poker.Library;

public record GameArgs
{
    public required Match Match { get; init; }

    public required List<IPlayer> Players { get; init; }

    public required IVariant Variant { get; init; }

    public required IDeck Deck { get; init; }

    public required IPlayer Button { get; init; }
}
