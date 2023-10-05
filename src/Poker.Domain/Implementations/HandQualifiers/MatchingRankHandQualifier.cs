namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier MatchingRankHandQualifier { get; } = 
        (QualifiedHandRequest request) =>
    {
        var bestRank = GetPotentialMatchingRankHand(
            request.Cards,
            request.Hand.PrimaryMatchesCount.ToInt()
        );

        return bestRank switch
        {
            { HighRank: var rank } when rank == Ranks.Empty =>
                request.Cards.ToUnqualifiedHand(request.Hand, request.RemainingCardCount > 0),
            _ =>
                request.Hand
                    .ToQualifiedHand(
                        bestRank.ContributingStandardCards,
                        bestRank.ContributingWildCards,
                        bestRank.NonContributing
                    )
        };
    };

    private static PotentialHandMessage GetPotentialMatchingRankHand(
        List<Card> cards,
        int requiredMatches
        )
    {
        foreach(var rank in Ranks.All.OrderByPokerStandard())
        {
            if (cards.WhereRanksOrIsWild(rank).Count() < requiredMatches)
                continue;

            var contributingStandard = cards
                .WhereRank(rank)
                .OrderBySuit()
                .Take(requiredMatches)
                .ToList();

            var neededCount = requiredMatches - contributingStandard.Count;

            List<AssignedWildCard> contributingWild = new();

            if(neededCount > 0)
            {
                var wildCards = cards
                    .WhereWild()
                    .Take(neededCount)
                    .ToQueue();

                // cards that can be impersonated, with rank in question
                var targets = Cards
                    .All
                        .WhereRank(rank)
                        .Except(contributingStandard)
                        .OrderBySuit()
                        .Take(neededCount)
                        .ToQueue();

                contributingWild = wildCards.AssignWildCards(targets).ToList();
            }

            return new PotentialHandMessage
            {
                HighRank = rank,
                Suit = Suits.Empty,
                Complete = true,
                ContributingStandardCards = contributingStandard,
                ContributingWildCards = contributingWild,
                NonContributing = cards.Except(contributingStandard, Card.ValueComparer).ToList()
            };
        }

        return new PotentialHandMessage
        {
            HighRank = Ranks.Empty,
            Suit = Suits.Empty,
            Complete = false,
            ContributingStandardCards = new(),
            ContributingWildCards = new(),
            NonContributing = cards
        };
    }
}


