namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier RoyalFlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
        {
            var straightFlush =
                StraightFlushHandQualifier!(request with { Hand = Hands.StraightFlush })!;

            return straightFlush.IsRoyalFlush() switch
            {
                true => straightFlush with { Hand = Hands.RoyalFlush },
                false => request.Cards.ToUnqualifiedHand
                    (
                        request.Hand,
                        FindPotentialStraightFlushes(request)
                            .Select(x => x with
                            {
                                ContributingStandardCards = x.ContributingStandardCards
                                    .WhereRanksOrIsWild(Ranks.Ten)
                                    .ToList()
                            })
                            .ToList()
                            .AnyWithEnoughRemainingCards()
                    )
            };
        };

    private static bool IsRoyalFlush(this QualifiedHandResponse straightFlush) =>
        straightFlush.Qualifies() switch
        {
            true => straightFlush.HighRank == Ranks.Ace,
            false => false
        };

}
