using System.ComponentModel.DataAnnotations;

namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier MatchingRankHandQualifier { get; } = 
        (QualifiedHandRequest request) =>
    {
        var bestRank = GetPotentialMatchingRankHand(
            request.Cards,
            request.Hand.PrimaryMatchesCount.ToInt(),
            request.RemainingCardCount
        );

        return bestRank switch
        {
            { HighRank: var rank } when rank == Ranks.Empty =>
                request.Cards.ToUnqualifiedHand(request.Hand, request.RemainingCardCount > 0),
            _ =>
                request.Hand.ToQualifiedHand(bestRank)
        };
    };

    private static PotentialHandMessage GetPotentialMatchingRankHand(
        List<Card> cards,
        int requiredMatches,
        uint remainingCardCount
        )
    {
        NeededCardMessage bestNeededCardMessage = NeededCardMessageBuilder.Empty();
        var bestNeededCardCount = GlobalConstants.HandSize + 1;

        foreach(var rank in Ranks.All.OrderByPokerStandard())
        {
            var potential =
                GetPotentialMatchingRankHand(cards, requiredMatches, remainingCardCount, rank);

            if (potential.Complete)
                return potential;

            // we don't have a match, but we might have a better needed card message
            var potentialNeededCards = potential.NeededCardMessage.TotalNeededCards();
            if(potentialNeededCards < bestNeededCardCount)
            {
                bestNeededCardMessage = potential.NeededCardMessage;
                bestNeededCardCount = potentialNeededCards;
            }
        }

        return new PotentialHandMessage
        {
            HighRank = Ranks.Empty,
            Suit = Suits.Empty,
            Complete = false,
            ContributingStandardCards = new(),
            ContributingWildCards = new(),
            NonContributing = cards,
            RemainingCardCount = remainingCardCount,
            NeededCardMessage = bestNeededCardMessage
        };
    }

    private static PotentialHandMessage GetPotentialMatchingRankHand(
        List<Card> cards,
        int requiredMatches,
        uint remainingCardCount,
        Rank rank
        )
    {
        var neededCardCount = requiredMatches - cards.WhereRanksOrIsWild(rank).Count();

        if (neededCardCount > 0)
        {
            return new PotentialHandMessage
            {
                HighRank = Ranks.Empty,
                Suit = Suits.Empty,
                Complete = false,
                ContributingStandardCards = new(),
                ContributingWildCards = new(),
                NonContributing = cards,
                RemainingCardCount = remainingCardCount,
                NeededCardMessage = new NeededCardMessageBuilder()
                    .WithGroup(neededCardCount)
                        .WithCard(rank, Suits.Empty)
                    .Build()
            };
        }

        var contributingStandard = cards
            .WhereRank(rank)
            .OrderBySuit()
            .Take(requiredMatches)
            .ToList();

        var contributingWild = GetContributingWildCards(
            requiredMatches - contributingStandard.Count,
            cards,
            contributingStandard,
            rank
        );

        return new PotentialHandMessage
        {
            HighRank = rank,
            Suit = Suits.Empty,
            Complete = true,
            ContributingStandardCards = contributingStandard,
            ContributingWildCards = contributingWild,
            NonContributing = cards
                .Except(contributingStandard)
                .Except(contributingWild.Select(w => w.WildCard))
                .ToList(),
            RemainingCardCount = remainingCardCount,
            NeededCardMessage = NeededCardMessageBuilder.Empty()
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
                .OrderBySuit()
                .OrderBy(contributingStandard.Contains)
                .ToQueue();

        return wildCards.AssignWildCards(targets).ToList();
    }
}


