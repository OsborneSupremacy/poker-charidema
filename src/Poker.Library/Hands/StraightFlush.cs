namespace Poker.Library.Hands;

public class StraightFlush : SequenceRankingResult, IHandRanking
{
    public override string Name => "Straight Flush";

    public override uint Value => 90;

    protected override GetCardInSequenceDelegate GetCardInSequence =>
        GetCardInSequenceByRandAndSuit;
}
