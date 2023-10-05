namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var allFlushes = EvaluateFlushes(request.Cards);
        var completeFlushes = allFlushes.Where(x => x.Complete).ToList();

        if (!completeFlushes.Any())
            return request.Cards.ToUnqualifiedHand(
                request.Hand,
                allFlushes.EnoughRemainingCards(request.RemainingCardCount)
            );

        var bestFlush = GetBestFlush(completeFlushes);

        return request.Hand.ToQualifiedHand(
            bestFlush.ContributingStandardCards,
            bestFlush.ContributingWildCards,
            bestFlush.NonContributing
        );
    };

    private static PotentialHandMessage GetBestFlush(
        List<PotentialHandMessage> evalulated
        ) =>
        evalulated
            .OrderByDescending(x => x.HighRank.Value)
            .ThenByDescending(x => x.Suit.Priority)
            .First();

    private static List<PotentialHandMessage> EvaluateFlushes(List<Card> cards) =>
        Suits.All
            .OrderByDescending(s => s.Priority)
            .Select(s => EvalulateFlush(s, cards))
            .ToList();

    private static PotentialHandMessage EvalulateFlush(
        Suit suit,
        List<Card> cards
        )
    {
        var playerCardsWithSuit = cards.WhereSuit(suit).ToList();
        var neededCount = GlobalConstants.HandSize - playerCardsWithSuit.Count;

        // add non-wildcards matching suit
        var contributingStandard = playerCardsWithSuit
            .OrderBySuit()
            .Take(GlobalConstants.HandSize)
            .ToList();

        // cards that can be impersonated, with suit in question
        var targets = Cards.All
            .WhereSuit(suit)
            .Except(playerCardsWithSuit)
            .OrderByRank()
            .Take(neededCount)
            .ToQueue();

        Queue<Card> wildCards = cards
            .WhereWild()
            .Take(GlobalConstants.HandSize - contributingStandard.Count)
            .ToQueue();

        var contributingWild = wildCards
            .AssignWildCards(targets)
            .ToList();

        return new PotentialHandMessage
        {
            HighRank = cards.GetMaxRank(contributingWild),
            Suit = suit,
            Complete = contributingStandard.Count + contributingWild.Count >= GlobalConstants.HandSize,
            ContributingStandardCards = contributingStandard,
            ContributingWildCards = contributingWild,
            NonContributing = cards
                .Except(contributingStandard.ToList())
                .Except(contributingWild.Select(w => w.Card))
                .ToList()
        };
    }
}
