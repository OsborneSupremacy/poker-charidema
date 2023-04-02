namespace Poker.Library.Hands;

public class HighCard : MatchingRankHandRankingResult, IHandRanking, IPossibleHandRanking
{
    public override string Name => "High Card";

    public override uint Value => 10;

    public override int RequiredMatches => 1;
}
