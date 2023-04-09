namespace Poker.Library.Rounds;

public record BettingInterval : IRound
{
    public string Name => "Bet";

    public bool GameCanEndAfter => true;
}
