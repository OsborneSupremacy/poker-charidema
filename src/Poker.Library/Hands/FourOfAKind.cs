﻿namespace Poker.Library.Hands;

public class FourOfAKind : MatchingRankHandRankingResult, IHandRanking
{
    public override string Name => "Four of a Kind";

    public override uint Value => 8;

    public override int RequiredMatches => 4;
}