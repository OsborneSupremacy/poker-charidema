using Poker.Domain.Classic;
using Poker.Domain.Extensions;

namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier MatchingRankHandQualifier { get; } = 
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
    {
        var bestRank = cards
            .GetBestMatchingRank(hand.PrimaryMatchesCount);

        return bestRank switch
        {
            { Value: var val } when val == Ranks.Empty.Value =>
                cards.ToUnqualifiedHand(hand, remainingCardCount > 0),
            _ =>
                cards
                    .ToQualifiedHand(
                        cards.GetMatchingRankHand(bestRank, hand.PrimaryMatchesCount.ToInt()),
                        hand
                    )
        };
    };

}


