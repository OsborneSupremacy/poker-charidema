namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var potential = EvaluateStraights(request);
        var complete = potential.WhereComplete();

        if (complete.Any())
            return request.Hand
                .ToQualifiedHand(
                    GetBestFlush(complete)
                );

        var best = GetBestStraight(
            potential
                .WithFewestNeededCards()
            );

        return request.Hand.ToUnqualifiedHand(
            best,
            best.EnoughRemainingCards()
        );
    };

    private static PotentialHandMessage GetBestStraight(
        IEnumerable<PotentialHandMessage> evalulated
        ) =>
        evalulated
            .Where(x => x.HighRank.Value == evalulated.Max(x => x.HighRank.Value))
            .OrderByDescending(x => x.Suit.Priority)
            .First();

    private static List<PotentialHandMessage> EvaluateStraights(QualifiedHandRequest request) =>
        Ranks.All
            .Where(r => r.Value <= Ranks.Ten.Value)
            .OrderBy(x => x.Value)
            .Select(x => EvalulateStraight(request, x))
            .ToList();

    private static PotentialHandMessage EvalulateStraight(
        QualifiedHandRequest request,
        Rank startingRank
        )
    {
        Rank highRank = Ranks.Empty;
        List<Card> contributingStandard = new();
        List<AssignedWildCard> contributingWild = new();

        List<Card> unusedCards = new();
        unusedCards.AddRange(request.Cards);

        Queue<Card> wildCards = request.Cards.WhereWild().ToQueue();

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
                    .Except(request.Cards)
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
                Ranks = new() { rank },
                Suits = Suits.All
            });
        }

        var isComplete =
            contributingStandard.Count + contributingWild.Count >= GlobalConstants.HandSize;

        NeededCardMessage neededCardMessage = isComplete switch
        {
            true => NeededCardMessageBuilder.Empty(),
            false => new NeededCardMessageBuilder()
                .WithCards(neededCards)
                .Build()
        };

        return new PotentialHandMessage
        {
            Suit = Suits.Empty,
            HighRank = highRank,
            Complete = isComplete,
            ContributingStandard = contributingStandard,
            ContributingWild = contributingWild,
            NonContributing = request.Cards
                .Except(contributingStandard)
                .Except(contributingWild.Select(w => w.WildCard))
                .ToList(),
            RemainingCardCount = request.RemainingCardCount,
            NeededCardMessage = neededCardMessage
        };
    }
}
