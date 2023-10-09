namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier TwoPairHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var firstPair =
            GetPotentialMatchingRankHand(
                request with { Hand = Hands.Pair }
            );

        var secondPair =
            GetPotentialMatchingRankHand(
                request with
                {
                    Cards = firstPair.NonContributing,
                    Hand = Hands.Pair,
                    RemainingCardCount =
                        request.RemainingCardCount
                        - firstPair.NeeededCardCount()
                }
            );

        return (firstPair.Complete, secondPair.Complete) switch
        {
            (true, true) =>
                request.Hand
                    .ToQualifiedHand(firstPair.CombineWith(secondPair)),

            (true, false) =>
                request.Cards
                    .ToUnqualifiedHand(request.Hand, secondPair.EnoughRemainingCards()),

            (false, true) =>
            // this scenario shouldn't happen. If there's a second pair, there should be a first pair.
            // I'm preferring to handle a scenario that should never happen over adding an
            // ugly exception that will never be thrown.
                request.Cards
                    .ToUnqualifiedHand(request.Hand, firstPair.EnoughRemainingCards()),

            (false, false) =>
                request.Cards
                    .ToUnqualifiedHand(request.Hand, firstPair.EnoughRemainingCards() && secondPair.EnoughRemainingCards())
        };
    };
}
