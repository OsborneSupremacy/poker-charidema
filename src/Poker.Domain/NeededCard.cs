namespace Poker.Domain;

public record NeededCard
{
    public required List<Rank> Ranks { get; init; }

    public required List<Suit> Suits { get; init; }
}
