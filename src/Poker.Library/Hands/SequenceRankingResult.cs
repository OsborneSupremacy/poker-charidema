using Poker.Library.Cards;

namespace Poker.Library.Hands;

public abstract class SequenceRankingResult
{
    public abstract string Name { get; }

    public abstract uint Value { get; }

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        for (uint r = deck.CardRankValues.Max(); r >= 5; r--)
        {
            var result = GetSequenceStartingWithRank(playerCards, r);
            if (result != null)
                return result;
        }

        return new HandRankingResult
        {
            Qualifies = false,
            HandCards = new(),
            Kickers = new(),
            DeadCards = new()
        };
    }

    protected HandRankingResult? GetSequenceStartingWithRank(List<ICard> playerCards, uint rankValue)
    {
        List<ICard> sequence = new();
        List<ICard> unusedCards = new();
        unusedCards.AddRange(playerCards);

        ISuit? sequenceSuit = null;

        CardInSequenceResult cardInSequence = new()
        {
            Exists = true
        };

        while (
            sequence.Count < 5
            && cardInSequence.Exists
            )
        {
            cardInSequence =
                GetCardInSequence(
                    unusedCards,
                    new CardInSequenceCriteria
                    {
                        RankValue = rankValue - (uint)sequence.Count,
                        Suit = sequenceSuit
                    }
                );

            if (cardInSequence.Exists)
            {
                sequence.Add(cardInSequence.Card!);
                unusedCards.Remove(cardInSequence.Card!);
                sequenceSuit ??= cardInSequence.Card!.GetNonWildSuit();
            }
        }

        if (sequence.Count < 5) return null;

        return new HandRankingResult
        {
            Qualifies = true,
            HandCards = sequence,
            Kickers = new(),
            DeadCards = unusedCards
        };
    }

    protected record CardInSequenceCriteria
    {
        public required uint RankValue { get; init; }

        public required ISuit? Suit { get; init; }
    }

    protected record CardInSequenceResult
    {
        public required bool Exists { get; init; }

        public ICard? Card { get; init; }
    }

    protected delegate CardInSequenceResult GetCardInSequenceDelegate(
        List<ICard> unusedCards,
        CardInSequenceCriteria criteria
        );

    protected abstract GetCardInSequenceDelegate GetCardInSequence { get; }

    protected static CardInSequenceResult GetCardInSequenceByRank(
        List<ICard> unusedCards,
        CardInSequenceCriteria crit
        )
    {
        var cardInSequence = unusedCards
            .Where(x => x.MatchesRankOrIsWild(crit.RankValue))
            .OrderBy(x => x.IsWild) // prefer non-wild
            .FirstOrDefault();

        return new CardInSequenceResult
        {
            Exists = cardInSequence is not null,
            Card = cardInSequence
        };
    }

    protected static GetCardInSequenceDelegate GetCardInSequenceByRandAndSuit =>
    (
        List<ICard> unusedCards,
        CardInSequenceCriteria crit
    ) =>
    {
        if (crit.Suit == null)
            return GetCardInSequenceByRank(unusedCards, crit);

        var cardInSequence = unusedCards
            .Where(x => x.MatchesRankOrIsWild(crit.RankValue))
            .Where(x => x.MatchesSuit(crit.Suit.Priority))
            .OrderBy(x => x.IsWild) // prefer non-wild
            .FirstOrDefault();

        return new CardInSequenceResult
        {
            Exists = cardInSequence is not null,
            Card = cardInSequence
        };
    };
}
