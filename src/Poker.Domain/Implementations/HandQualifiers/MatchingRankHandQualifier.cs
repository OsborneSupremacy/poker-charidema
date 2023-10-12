using System.Linq;

namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier MatchingRankHandQualifier { get; } = 
        (QualifiedHandRequest request) =>
    {
        var bestRank = GetPotentialMatchingRankHand(request);

        return bestRank.Complete switch
        {
            false => request.Hand.ToUnqualifiedHand(bestRank, bestRank.EnoughRemainingCards()),
            true => request.Hand.ToQualifiedHand(bestRank)
        };
    };

    private static PotentialHandMessage GetPotentialMatchingRankHand(QualifiedHandRequest request)
    {
        PotentialHandMessage bestPotentialHand = new PotentialHandMessage
        {
            HighRank = Ranks.Empty,
            Suit = Suits.Empty,
            Complete = false,
            ContributingStandard = new(),
            ContributingWild = new(),
            NonContributing = new(),
            RemainingCardCount = request.RemainingCardCount,
            NeededCardMessage = new NeededCardMessageBuilder()
                .WithCards(
                    GlobalConstants.HandSize + 1,
                    Cards.All
                )
                .Build()
        };

        List<Card> neededCards = new();

        foreach (var rank in Ranks.All.OrderByPokerStandard())
        {
            var potential =
                GetPotentialMatchingRankHand(request, rank);

            if (potential.Complete)
                return potential;

            // we don't have a match, but we might have a better needed card message
            if(potential.NeeededCardCount() < bestPotentialHand.NeeededCardCount())
            {
                bestPotentialHand = potential;
                neededCards.Clear();
            }

            // any potential hand with the same needed card count is a candidate
            if(potential.NeeededCardCount() <= bestPotentialHand.NeeededCardCount())
                neededCards.AddRange(
                    potential.NeededCardMessage.Groups.First().Cards
                );
        }

        return bestPotentialHand with
        {
            NeededCardMessage =
                new NeededCardMessageBuilder()
                    .WithCards(
                        bestPotentialHand.NeeededCardCount(),
                        neededCards
                    )
                    .Build()
        };
    }

    private static PotentialHandMessage GetPotentialMatchingRankHand(
        QualifiedHandRequest request,
        Rank rank
        )
    {
        var contributingStandard = request.Cards
            .WhereRank(rank)
            .OrderByPokerStandard()
            .Take(request.Hand.PrimaryMatchesCount.ToInt())
            .ToList();

        var contributingWild = GetContributingWildCards(
            request.Hand.PrimaryMatchesCount.ToInt() - contributingStandard.Count,
            request.Cards,
            contributingStandard,
            rank
        );

        var neededCardCount =
            request.Hand.PrimaryMatchesCount.ToInt()
            - (contributingStandard.Count + contributingWild.Count);

        NeededCardMessage neededCardMessage = (neededCardCount == 0) switch
        {
            true => NeededCardMessageBuilder.Empty(),
            false => new NeededCardMessageBuilder()
                .WithCards(
                    neededCardCount.ToUint(),
                    getAcceptableCards(
                        contributingStandard
                            .Union(contributingWild.AssignedCards())
                    )
                )
                .Build()
        };

        IEnumerable<Card> getAcceptableCards(
            IEnumerable<Card> contributing
            ) =>
            request.Hand.ImpersonateContributing switch
            {
                true => Cards.All.WhereRank(rank),
                false => Cards.All.WhereRank(rank)
                    .Except(contributing)
            };

        return new PotentialHandMessage
        {
            HighRank = rank,
            Suit = Suits.Empty,
            Complete = neededCardCount == 0,
            ContributingStandard = contributingStandard,
            ContributingWild = contributingWild,
            NonContributing = CardFunctions
                .GetNonContributingCards(request.Cards, contributingStandard, contributingWild),
            RemainingCardCount = request.RemainingCardCount,
            NeededCardMessage = neededCardMessage
        };
    }

    private static List<AssignedWildCard> GetContributingWildCards(
        int neededCount,
        List<Card> cards,
        List<Card> contributingStandard,
        Rank rank
        )
    {
        if (neededCount == 0)
            return Enumerable.Empty<AssignedWildCard>().ToList();

        var wildCards = cards
            .WhereWild()
            .Take(neededCount)
            .ToQueue();

        // cards that can be impersonated, with rank in question
        var targets = Cards
            .All
                .WhereRank(rank)
                .OrderByPokerStandard()
                .OrderBy(contributingStandard.Contains)
                .ToQueue();

        return wildCards.AssignWildCards(targets).ToList();
    }
}


