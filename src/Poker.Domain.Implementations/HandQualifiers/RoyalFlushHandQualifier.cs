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
                && (straightFlush.GetHighRank() == Ranks.Ace)) switch
                {
                    true => straightFlush with { Hand = hand },
                    false => cards.ToUnqualifiedHand
                    (
                        hand,
                        FindPotentialStraightFlushes(cards)
                            .Select(x => x with
                            {
                                Cards = x.Cards
                                    .Where(x => x.SatisfiesRankOrIsWild(Ranks.Ten))
                                    .ToList()
                            })
                            .ToList()
                            .EnoughRemainingCards(remainingCardCount)
                    )
                }; ;
        };
}
