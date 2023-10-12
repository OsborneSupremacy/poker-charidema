namespace Poker.Domain.Classic;

public record CardGroup
{
    public required int Count { get; init; }

    public required List<Card> Cards { get; init; }
}
