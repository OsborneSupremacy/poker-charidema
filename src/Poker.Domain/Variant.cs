namespace Poker.Domain;

public record Variant
{
    public required string Name { get; init; }

    public required List<Phase> Phases { get; init; }
}
