namespace Poker.Library.Hands;

public class FourOfAKind : MatchingRankHandRankingResult, IHandRanking, IPossibleHandRanking
{
    public override string Name => "Four of a Kind";

    public override uint Value => 80;

    public override int RequiredMatches => 4;
}
