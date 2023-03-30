namespace Poker.Library.Hands;

public class FiveOfAKind : MatchingRankHandRankingResult, IHandRanking
{
    public override string Name => "Five of a Kind";

    public override uint Value => 110;

    public override int RequiredMatches => 5;
}
