namespace Poker.Library.Hands;

public class ThreeOfAKind : MatchingRankHandRankingResult, IHandRanking
{
    public override string Name => "Three of a Kind";

    public override uint Value => 4;

    public override int RequiredMatches => 3;
}
