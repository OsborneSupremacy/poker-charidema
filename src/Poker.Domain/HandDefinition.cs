namespace Poker.Domain;

public record HandDefinition
{
    public required string Name { get; init; }

    public required uint Value { get; init; }

    /// <summary>
    /// The count of required matches in the first group. e.g. a Pair is 2. A full house is 3.
    /// </summary>
    public required uint PrimaryMatchesCount { get; init; } 

    /// <summary>
    /// Whether a wildcard can impersonate a contributing card
    /// </summary>
    public required bool ImpersonateContributing { get; init; }

    /// <summary>
    /// The function used to qualify a player's cards satisfy this hand.
    /// </summary>
    public required HandQualifier HandQualifier { get; init; }
}
