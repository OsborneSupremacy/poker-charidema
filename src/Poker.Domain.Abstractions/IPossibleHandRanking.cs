namespace Poker.Domain.Abstractions;

/// <summary>
/// Determines whether a hand qualifies as a rank, before all cards have been dealt.
/// </summary>
public interface IPossibleHandRanking
{
    PossibleHandRankingResponse QualifyPossible(HandRankingRequest request);
}
