namespace Poker.Library.Hands;

public class ThreeOfAKind : MatchingRankHandRankingResult, IHandRanking
{
    public override string Name => "Three of a Kind";

    public override uint Value => 40;

    public override int RequiredMatches => 3;
}
