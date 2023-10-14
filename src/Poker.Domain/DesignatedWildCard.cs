namespace Poker.Domain;

public record DesignatedWildCard
{
    public required Card WildCard { get; init; }

    /// <summary>
    /// The card that the wildcard is impersonating
    /// </summary>
    public required Card DesignatedCard { get; init; }
}
