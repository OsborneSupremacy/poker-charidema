namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier RoyalFlushHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
        {
            var straightFlush =
                StraightFlushHandQualifier(hand, cards, remainingCardCount);

            return
                (straightFlush.Qualifies()
                && (straightFlush.GetHighRank() == Ranks.Ace)) switch {
                    true => straightFlush with { Hand = hand },
                    false => cards.ToUnqualifiedHand
                    (
                        hand,
                        // this isn't completely accurate. There are scenarios where a player
                        // is eliminated for a royal flush, but not a straight flush.
                        // figure it out later.
                        straightFlush.HandQualification != HandQualifications.Eliminated
                    )
                };
        };
}
