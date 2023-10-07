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

        NeededCardMessageBuilder neededCardMessageBuilder = new();
        List<NeededCard> neededCards = new();

        foreach (var rank in Ranks.All
            .Where(r => r.Value > startingRank.Value)
            .Take(GlobalConstants.HandSize)
            .OrderBy(r => r.Value)
            )
        {
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

            if(wildCards.Any())
            {
                var wildCardInSequence = wildCards.Dequeue();

                // cards that can be impersonated, with rank in question
                var target = Cards.All
                    .WhereRank(rank)
                    .Except(cards)
                    .OrderBySuit()
                    .First();

                highRank = rank;

                contributingWild.Add(new AssignedWildCard
                {
                    WildCard = wildCardInSequence,
                    StandardCard = target
                });

                unusedCards.Remove(wildCardInSequence);
                continue;
            }

            // no matching standard card and no wild cards left, so we need a card
            // with these properties
            neededCards.Add(new NeededCard
            {
                Rank = rank,
                Suit = Suits.Empty
            });
        }

        var isComplete =
            contributingStandard.Count + contributingWild.Count >= GlobalConstants.HandSize;

        NeededCardMessage neededCardMessage = isComplete switch
        {
            true => NeededCardMessageBuilder.Empty(),
            false => neededCardMessageBuilder
                .WithGroup(neededCards.Count)
                .WithCards(neededCards)
                .Build()
        };

        return new PotentialHandMessage
        {
            Suit = Suits.Empty,
            HighRank = highRank,
            Complete = isComplete,
            ContributingStandardCards = contributingStandard,
            ContributingWildCards = contributingWild,
            NonContributing = cards
                .Except(contributingStandard)
                .Except(contributingWild.Select(w => w.WildCard))
                .ToList(),
            RemainingCardCount = remainingCardCount,
            NeededCardMessage = neededCardMessage
        };
    }
}
