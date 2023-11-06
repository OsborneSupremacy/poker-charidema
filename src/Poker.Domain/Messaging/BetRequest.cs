﻿namespace Poker.Domain.Messaging;

public record BetRequest
{
    public required List<Bet> Bets { get; init; }
    
    public required int Pot { get; init; }
    
    public required Player PlayerInTurn { get; init; }
}
