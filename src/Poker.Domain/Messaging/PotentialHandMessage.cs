namespace Poker.Domain.Messaging;

/// <summary>
/// Similar to the concept of <see cref="QualifiedHandResponse"/>, but
/// for in-progress hands, analysis, and comparision.
/// </summary>
public record PotentialHandMessage
{
    public required Rank HighRank { get; init; }

    public required Suit Suit { get; init; }

    public required bool Complete { get; init; }

    /// <summary>
    /// Cards that fully or partially meet the requirements
    /// of the hand.
    /// </summary>
    public required List<Card> Contributing { get; init; }

    public required List<Card> NonContributing { get; init; }
}
