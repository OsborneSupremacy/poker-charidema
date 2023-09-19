namespace Poker.Domain.Implementations.HandQualifiers;

public static partial class HandQualifierDelegates
{
    public static HandQualifier StraightFlushHandQualifier { get; } =
        (Hand hand, List<Card> cards, uint remainingCardCount) =>
        {
            var potentials = FindPotentialStraightFlushes(cards);
            var complete = potentials.Where(x => x.Complete).ToList();

            if (!complete.Any())
                return cards.ToUnqualifiedHand(
                    hand,
                    // Determining whether a straight flush is possible for a player is tricky.
                    // If there are 4+ cards yet to be dealt, then it's always possible possible.
                    remainingCardCount >= GlobalConstants.HandSize - 1
                    ||
                    (
                        // if the player has a potential straight flush, a complete straight flush is possible...
                        potentials.Any()
                        // ... if there are enough remaining cards
                        && potentials.EnoughRemainingCardsForHand(remainingCardCount)
                    )
                );

            return cards.ToQualifiedHand(
                hand,
                GetBestStraightFlush(complete).Cards
            );
        };

    private static PotentialHand GetBestStraightFlush(
        List<PotentialHand> potential
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
    private static List<PotentialHand> FindPotentialStraightFlushes(List<Card> cards) =>
        EvaluateFlushes(cards)
            .Join
            (
                EvaluateStraights(cards),
                f => f.Cards, s => s.Cards,
                (f, s) => new PotentialHand
                {
                    HighRank = s.HighRank,
                    Suit = f.Suit,
                    Cards = f.Cards,
                    Complete = f.Complete && s.Complete
                }
            ).ToList();
}


