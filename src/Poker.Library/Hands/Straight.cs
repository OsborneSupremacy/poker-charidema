using Poker.Library.Cards;

namespace Poker.Library.Hands;

public class Straight : SequenceRankingResult, IHandRanking
{
    public override string Name => "Straight";

    public override uint Value => 50;

    protected override GetCardInSequenceDelegate GetCardInSequence => GetCardInSequenceByRank;
}