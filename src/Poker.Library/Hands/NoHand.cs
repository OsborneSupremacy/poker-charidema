namespace Poker.Library.Hands;

public class NoHand : IHandRanking
{
    public string Name => "No hand";

    public uint Value => 0;

    public IHandRankingResult Qualify(IHandRankingArgs args) => 
        new HandRankingResult
        {
            Qualifies = false,
            HandCards = new(),
            Kickers = new(),
            DeadCards = new()
        };
}
