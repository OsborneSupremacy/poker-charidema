namespace Poker.Domain;

public record Variant
{
    public required string Name { get; init; }

    public required IReadOnlyList<Phase> Phases { get; init; }
}
