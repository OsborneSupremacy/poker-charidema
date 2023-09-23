namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier MatchingRankHandQualifier { get; } = 
        (QualifiedHandRequest request) =>
    {
        var bestRank = request.Cards
            .GetBestMatchingRank(request.Hand.PrimaryMatchesCount);

        return bestRank switch
        {
            { Value: var val } when val == Ranks.Empty.Value =>
                request.Cards.ToUnqualifiedHand(request.Hand, request.RemainingCardCount > 0),
            _ =>
                request.Cards
                    .ToQualifiedHand(
                        request.Hand,
                        request.Cards.GetMatchingRankHand(bestRank, request.Hand.PrimaryMatchesCount.ToInt())
                    )
        };
    };
}


