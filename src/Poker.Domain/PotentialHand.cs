namespace Poker.Domain;

/// <summary>
/// Similar to the concept of <see cref="QualifiedHand"/>, but
/// for in-progress hands, analysis, and comparision.
/// </summary>
public record PotentialHand
{
    public required Rank HighRank { get; init; }

    public required Suit Suit { get; init; }

    public required bool Complete { get; init; }

    /// <summary>
    /// Cards that fully or partially meet the requirements
    /// of the hand.
    /// </summary>
    public required List<Card> Cards { get; init; }
}
