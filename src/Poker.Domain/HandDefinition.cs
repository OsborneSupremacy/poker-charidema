namespace Poker.Domain;

public record HandDefinition
{
    public required string Name { get; init; }

    public required uint Value { get; init; }

    /// <summary>
    /// Whether a wildcard can impersonate a contributing card
    /// </summary>
    public required bool ImpersonateContributing { get; init; }
}
