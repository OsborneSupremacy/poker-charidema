namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier NoHandQualifier { get; } =
        (QualifiedHandRequest request) =>
        {
            return new QualifiedHandResponse
            {
                HighRank = Ranks.Empty,
                Suit = Suits.Empty,
                Hand = request.Hand,
                HandQualification = HandQualifications.Qualifies,
                ContributingStandardCards = new(),
                ContributingWildCards = new(),
                Kickers = new(),
                DeadCards = request.Cards,
                NeededCardGroups = new()
            };
        };
}
