namespace Poker.Library.Phases;

public record BettingInterval : IPhase
{
    public string Name => "Bet";

    public bool GameCanEndAfter => true;
}
