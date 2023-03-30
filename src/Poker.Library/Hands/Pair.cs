namespace Poker.Library.Hands;

public class Pair : MatchingRankHandRankingResult, IHandRanking
{
    public override string Name => "Pair";

    public override uint Value => 20;

    public override int RequiredMatches => 2;
}
