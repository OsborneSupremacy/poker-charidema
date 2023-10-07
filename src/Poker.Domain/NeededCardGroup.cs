namespace Poker.Domain;

public record NeededCardGroup
{
    public required uint Count { get; init; }

    public required List<NeededCard> Cards { get; init; }

}
