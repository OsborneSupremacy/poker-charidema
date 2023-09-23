namespace Poker.Domain.Implementations;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightFlushHandQualifier { get; } =
        (QualifiedHandRequest request) =>
        {
            var potentials = FindPotentialStraightFlushes(request.Cards);
            var complete = potentials.Where(x => x.Complete).ToList();

            if (!complete.Any())
                return request.Cards.ToUnqualifiedHand(
                    request.Hand,
                    // Determining whether a straight flush is possible for a player is tricky.
                    // If there are 4+ cards yet to be dealt, then it's always possible possible.
                    request.RemainingCardCount >= GlobalConstants.HandSize - 1
                    || potentials.EnoughRemainingCards(request.RemainingCardCount)
                );

            return request.Cards.ToQualifiedHand(
                request.Hand,
                GetBestStraightFlush(complete).Cards
            );
        };

    private static PotentialHandMessage GetBestStraightFlush(
        List<PotentialHandMessage> potential
    ) =>
        potential
            .Where(x => x.HighRank.Value == potential.Max(x => x.HighRank.Value))
            .OrderByDescending(x => x.Cards.First().Suit.Priority)
            .First();

    /// <summary>
    /// Returns the intersection of <see cref="EvaluateFlushes(List{Card})"/> and <see cref="EvalulatedStraight"/>, 
    /// joining on this list of cards that those methods return. Since the list of cards returned by those methods
    /// are only the cards that count towards satisfying their respective hands, this method is not 
    /// guaranteeed to return any records.
    /// </summary>
    /// <param name="cards"></param>
    /// <returns></returns>
    private static List<PotentialHandMessage> FindPotentialStraightFlushes(List<Card> cards) =>
        EvaluateFlushes(cards)
            .Join
            (
                EvaluateStraights(cards),
                f => f.Cards, s => s.Cards, // TODO: this isn't going to work. Create a key
                (f, s) => new PotentialHandMessage
                {
                    HighRank = s.HighRank,
                    Suit = f.Suit,
                    Cards = f.Cards,
                    Complete = f.Complete && s.Complete
                }
            ).ToList();
}


