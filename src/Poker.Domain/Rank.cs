namespace Poker.Domain;

public record Rank
{
    public required string Name { get; init; }

    public required int Value { get; init; }

    /// <summary>
    /// Not a face card or Ace.
    /// </summary>
    public required bool IsStandard { get; init; }
}
