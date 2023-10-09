namespace Poker.Domain.Messaging;

public enum HandQualifications
{
    Eliminated,
    Possible,
    Qualifies
}

/// <summary>
/// A thorough result of a hand "qualification", which determines
/// whether the player's cards satisfy the hand's requirements 
/// (and if they don't, whether it's possible to meet those requirements),
/// which cards comprised the hand, which cards are the kickers, and which
/// cards are dead.
/// </summary>
public record QualifiedHandResponse
{
    public required Rank HighRank { get; init; }

    public required Suit Suit { get; init; }

    public required Hand Hand { get; set; }

    public required HandQualifications HandQualification { get; init; }

    public required List<Card> ContributingStandardCards { get; init; }

    public required List<AssignedWildCard> ContributingWildCards { get; init; }

    public required List<Card> Kickers { get; init; }

    public required List<Card> DeadCards { get; init; }

    public required List<NeededCard> NeededCards { get; init; }
}
