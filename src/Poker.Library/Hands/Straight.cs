using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class Straight : SequenceRankingResult, IHandRanking
{
    public override string Name => "Straight";

    public override uint Value => 50;

    protected override GetCardInSequenceDelegate GetCardInSequence => GetCardInSequenceByRank;

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
}