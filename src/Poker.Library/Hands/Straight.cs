using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class Straight : SequenceRankingResult, IHandRanking
{
    public override string Name => "Straight";

    public override uint Value => 50;

    protected override GetCardInSequenceDelegate GetCardInSequence => GetCardInSequenceByRank;

    protected static CardInSequenceResult GetCardInSequenceByRank(List<ICard> unusedCards, uint r)
    {
        var cardInSequence = unusedCards
            .Where(x => x.MatchesRankOrIsWild(r))
            .OrderBy(x => x.IsWild) // prefer non-wild
            .FirstOrDefault();

        return new CardInSequenceResult
        {
            Exists = cardInSequence is not null,
            Card = cardInSequence
        };
    }
}