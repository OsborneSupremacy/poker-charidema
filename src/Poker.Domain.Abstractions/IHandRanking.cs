namespace Poker.Domain.Abstractions;

public interface IHandRanking
{
    string Name { get; }

    uint Value { get; }

    HandRankingResponse Qualify(HandRankingRequest request);
}

