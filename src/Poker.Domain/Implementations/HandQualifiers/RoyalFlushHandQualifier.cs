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
                        FindPotentialStraightFlushes(request.Cards, request.RemainingCardCount)
                            .Select(x => x with
                            {
                                ContributingStandardCards = x.ContributingStandardCards
                                    .WhereRanksOrIsWild(Ranks.Ten)
                                    .ToList()
                            })
                            .ToList()
                            .EnoughRemainingCards(request.RemainingCardCount)
                    )
            };
        };

    private static bool IsRoyalFlush(this QualifiedHandResponse straightFlush) =>
        straightFlush.Qualifies() switch
        {
            true => straightFlush.GetHighRank() == Ranks.Ace,
            false => false
        };

}
