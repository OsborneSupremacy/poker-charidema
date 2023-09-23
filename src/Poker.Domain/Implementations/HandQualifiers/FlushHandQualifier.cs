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
        var cardsWithSuit = cards
            .Where(c => c.MatchesSuitOrIsWild(suit))
            .OrderBy(c => c.IsWild)
            .ThenByDescending(c => c.Rank.Value)
            .Take(GlobalConstants.HandSize)
            .ToList();

        return new PotentialHandMessage
        {
            HighRank = Ranks.Empty,
            Suit = suit,
            Complete = cardsWithSuit.Count >= GlobalConstants.HandSize,
            Cards = cardsWithSuit
        };
    }
}
