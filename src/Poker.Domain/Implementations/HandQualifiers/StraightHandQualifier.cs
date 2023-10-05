namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var allStraights = EvaluateStraights(request.Cards, request.RemainingCardCount);
        var completeStraights = allStraights.Where(x => x.Complete).ToList();

        if (!completeStraights.Any())
            return request.Cards.ToUnqualifiedHand(
                request.Hand,
                allStraights.EnoughRemainingCards(request.RemainingCardCount)
            );

        var bestStraight = GetBestStraight(completeStraights);

        return request.Hand.ToQualifiedHand(bestStraight);
    };

    private static PotentialHandMessage GetBestStraight(
        List<PotentialHandMessage> evalulated
        ) =>
        evalulated
            .Where(x => x.HighRank.Value == evalulated.Max(x => x.HighRank.Value))
            .OrderByDescending(x => x.Suit.Priority)
            .First();

    private static List<PotentialHandMessage> EvaluateStraights(List<Card> cards, uint remainingCardCount) =>
        Ranks.All
            .Where(r => r.Value <= Ranks.Ten.Value)
            .OrderBy(x => x.Value)
            .Select(x => EvalulateStraight(x, cards, remainingCardCount))
            .ToList();

    private static PotentialHandMessage EvalulateStraight(
        Rank startingRank,
        List<Card> cards,
        uint remainingCardCount
        )
    {
        Rank highRank = Ranks.Empty;
        List<Card> contributingStandard = new();
        List<AssignedWildCard> contributingWild = new();

        List<Card> unusedCards = new();
        unusedCards.AddRange(cards);

        Queue<Card> wildCards = cards.WhereWild().ToQueue();

        for (uint r = 0; r < GlobalConstants.HandSize; r++)
        {
            // for some reason the compiler doesn't like this when used
            // in an inline expression. 🤷
            uint nextRankValue = startingRank.Value + r;

            var rank = Ranks.All
                .Where(r => r.Value.Equals(nextRankValue))
                .FirstOrDefault();

            if (rank is null) // have gone past Ace. Can this actually happen? TODO: test
                break;

            var standardCardInSequence = unusedCards
                .Where(c => c.MatchesRank(rank))
                .OrderBySuit()
                .FirstOrDefault() ?? Cards.Empty;

            if(standardCardInSequence != Cards.Empty)
            {
                highRank = rank;
                contributingStandard.Add(standardCardInSequence);
                unusedCards.Remove(standardCardInSequence);
                continue;
            }

            if(!wildCards.Any())
                return new PotentialHandMessage
                {
                    Suit = Suits.Empty,
                    HighRank = highRank,
                    Complete = false,
                    ContributingStandardCards = contributingStandard,
                    ContributingWildCards = contributingWild,
                    NonContributing = cards
                        .Except(contributingStandard)
                        .Except(contributingWild.Select(w => w.WildCard))
                        .ToList(),
                    RemainingCardCount = remainingCardCount
                };

            var wildCardInSequence = wildCards.Dequeue();

            // cards that can be impersonated, with rank in question
            var target = Cards.All
                .WhereRank(rank)
                .Except(cards)
                .OrderBySuit()
                .First();

            highRank = rank;

            contributingWild.Add(new AssignedWildCard {
                WildCard = wildCardInSequence,
                StandardCard = target
            });

            unusedCards.Remove(wildCardInSequence);
        }

        return new PotentialHandMessage
        {
            Suit = Suits.Empty,
            HighRank = highRank,
            Complete = true,
            ContributingStandardCards = contributingStandard,
            ContributingWildCards = contributingWild,
            NonContributing = cards
                .Except(contributingStandard)
                .Except(contributingWild.Select(w => w.WildCard))
                .ToList(),
            RemainingCardCount = remainingCardCount
        };
    }
}
