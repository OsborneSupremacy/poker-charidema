namespace Poker.Domain.Messaging;

public class EvaluateWinnerResponse
{
    public required List<Player> Winners { get; init; }
    
    public required List<PlayerHand> PlayerHands { get; init; }
    
    public required Hand WinningHand { get; init; }
}
