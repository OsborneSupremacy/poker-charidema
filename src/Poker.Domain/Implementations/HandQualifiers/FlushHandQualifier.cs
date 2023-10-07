namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var allFlushes = EvaluateFlushes(request.Cards, request.RemainingCardCount);
        var completeFlushes = allFlushes.Where(x => x.Complete).ToList();

        if (!completeFlushes.Any())
            return request.Cards.ToUnqualifiedHand(
                request.Hand,
                allFlushes.EnoughRemainingCards(request.RemainingCardCount)
            );

        var bestFlush = GetBestFlush(completeFlushes);

        return request.Hand.ToQualifiedHand(bestFlush);
    };

    private static PotentialHandMessage GetBestFlush(
        List<PotentialHandMessage> evalulated
        ) =>
        evalulated
            .OrderByDescending(x => x.HighRank.Value)
            .ThenByDescending(x => x.Suit.Priority)
            .First();

    private static List<PotentialHandMessage> EvaluateFlushes(List<Card> cards, uint remainingCardCount) =>
        Suits.All
            .OrderByDescending(s => s.Priority)
            .Select(s => EvalulateFlush(s, cards, remainingCardCount))
            .ToList();

    private static PotentialHandMessage EvalulateFlush(
        Suit suit,
        List<Card> cards,
        uint remainingCardCount
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

        NeededCardMessageBuilder neededCardMessageBuilder = new();

        var stillNeededCount = GlobalConstants.HandSize
            - contributingStandard.Count
            - contributingWild.Count;

        if (stillNeededCount > 0)
            neededCardMessageBuilder
                .WithGroup(stillNeededCount)
                    .WithCard(Ranks.Empty, suit);

        return new PotentialHandMessage
        {
            HighRank = cards.GetMaxRank(contributingWild),
            Suit = suit,
            Complete = stillNeededCount > 0,
            ContributingStandardCards = contributingStandard,
            ContributingWildCards = contributingWild,
            NonContributing = cards
                .Except(contributingStandard.ToList())
                .Except(contributingWild.Select(w => w.WildCard))
                .ToList(),
            RemainingCardCount = remainingCardCount,
            NeededCardMessage = neededCardMessageBuilder.Build()
        };
    }
}
