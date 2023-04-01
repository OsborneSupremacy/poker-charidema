namespace Poker.Library.Hands;

public abstract class SequenceRankingResult
{
    public abstract string Name { get; }

    public abstract uint Value { get; }

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        for (uint r = deck.CardRankValues.Max(); r >= 5; r--)
        {
            List<ICard> sequence = new();
            List<ICard> unusedCards = new();
            unusedCards.AddRange(playerCards);

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
                    GetCardInSequence(unusedCards, r - (uint)sequence.Count);

                if (cardInSequence.Exists)
                {
                    sequence.Add(cardInSequence.Card!);
                    unusedCards.Remove(cardInSequence.Card!);
                }
            }

            if (sequence.Count < 5) continue;

            return new HandRankingResult
            {
                Qualifies = true,
                HandCards = sequence,
                Kickers = new(),
                DeadCards = unusedCards
            };
        }

        return new HandRankingResult
        {
            Qualifies = false,
            HandCards = new(),
            Kickers = new(),
            DeadCards = new()
        };
    }

    protected record CardInSequenceResult
    {
        public required bool Exists { get; init; }

        public ICard? Card { get; init; }
    }

    protected delegate CardInSequenceResult GetCardInSequenceDelegate(List<ICard> unusedCards, uint r);

    protected abstract GetCardInSequenceDelegate GetCardInSequence { get; }
}
