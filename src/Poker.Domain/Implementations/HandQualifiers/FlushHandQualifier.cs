namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier FlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
    {
        var all = EvaluateFlushes(request.Cards);
        var complete = all.Where(x => x.Complete).ToList();

        if (!complete.Any())
            return request.Cards.ToUnqualifiedHand(
                request.Hand,
                all.EnoughRemainingCards(request.RemainingCardCount)
            );

        return request.Cards.ToQualifiedHand(
            request.Hand,
            GetBestFlush(complete).Cards
        );
    };

    private static PotentialHandMessage GetBestFlush(
        List<PotentialHandMessage> evalulated
        ) =>
        evalulated
            .Where(x => x.Suit.Priority == evalulated.Max(x => x.Suit.Priority))
            .OrderByDescending(x => x.Cards.Max(c => c.IsWild))
            .ThenByDescending(x => x.Cards.Max(c => c.Rank.Value))
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
        Queue<Card> wildCards = cards.WhereWild().ToQueue();

        var playerCardsWithSuit = cards.WhereSuit(suit).ToList();
        var neededCount = GlobalConstants.HandSize - playerCardsWithSuit.Count;

        // add non-wildcards matching suit
        var cardsOut = playerCardsWithSuit
            .OrderBySuit()
            .Take(GlobalConstants.HandSize)
            .ToList();

        // cards that can be impersonated, with rank in question
        var targets = Cards
            .All
            .WhereSuit(suit)
            .Except(playerCardsWithSuit)
            .OrderByRank()
            .Take(neededCount)
            .ToQueue();

        while (
            targets.Any()
            && wildCards.Any()
            && cardsOut.Count < GlobalConstants.HandSize
            )
            cardsOut.Add(
                wildCards.Dequeue() with { Impersonating = targets.Dequeue() }
            );

        return new PotentialHandMessage
        {
            HighRank = cards.GetMaxRank(),
            Suit = suit,
            Complete = cardsOut.Count >= GlobalConstants.HandSize,
            Cards = cardsOut
        };
    }
}
