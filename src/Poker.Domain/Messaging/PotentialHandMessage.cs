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

    public required List<Card> ContributingStandard { get; init; }

    public required List<AssignedWildCard> ContributingWild { get; init; }

    public required List<Card> NonContributing { get; init; }

    public required uint RemainingCardCount { get; init; }

    public required NeededCardMessage NeededCardMessage { get; init; }
}
