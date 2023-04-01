using Poker.Library.Cards;
using System.Collections.Generic;
using System.Formats.Asn1;

namespace Poker.Library.Hands;

public class Straight : IHandRanking
{
    public string Name => "Straight";

    public uint Value => 50;

    public IHandRankingResult Qualify(IDeck deck, List<ICard> playerCards)
    {
        for (uint r = deck.CardRankValues.Max(); r >= 5; r--)
        {
            List<ICard> sequence = new();
            List<ICard> unusedCards = new();
            unusedCards.AddRange(playerCards);

            bool cardInSequenceExists = true;
            ICard? cardInSequence;

            while (
                sequence.Count < 5
                && cardInSequenceExists
                )
            {
                (cardInSequenceExists, cardInSequence) = 
                    GetCardInSequence(unusedCards, r - (uint)sequence.Count);

                if(cardInSequenceExists)
                {
                    sequence.Add(cardInSequence!);
                    unusedCards.Remove(cardInSequence!);
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

    protected (bool exists, ICard? cardInSequence) GetCardInSequence(List<ICard> unusedCards, uint r)
    {
        var cardInSequence = unusedCards
            .Where(x => x.MatchesRankOrIsWild(r))
            .OrderBy(x => x.IsWild) // prefer non-wild
            .FirstOrDefault();

        return (cardInSequence is not null, cardInSequence);
    }

}
