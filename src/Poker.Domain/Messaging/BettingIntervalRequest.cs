namespace Poker.Domain.Messaging;

public record BettingIntervalRequest
{
    public required List<Bet> Bets { get; init; }
    
    public required int Pot { get; init; }
    
    public required Player PlayerInTurn { get; init; }
    
    public required List<Player> ActivePlayers { get; init; }
}
