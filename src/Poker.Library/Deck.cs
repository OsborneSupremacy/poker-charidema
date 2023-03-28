namespace Poker.Library;

public record Deck : IDeck
{
    public required List<ICard> Cards { get; init; }

    public required uint NumberOfJokers { get; init; }

    public required List<uint> CardRankValues { get; init; }
}

