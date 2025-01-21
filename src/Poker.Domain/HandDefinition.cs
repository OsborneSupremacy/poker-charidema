namespace Poker.Domain;

public record HandDefinition
{
    public required string Name { get; init; }

    public required int Value { get; init; }

    /// <summary>
    /// Whether a wildcard can impersonate a contributing card. In standard poker, this is only needed for a five of a kind,
    /// because in a standard deck there are only four of each rank. For there to be a fifth card of the same rank,
    /// the wild card needs to impersonate a non-wild card.
    /// </summary>
    public required bool ImpersonateContributing { get; init; }
}
