﻿namespace Poker.Domain;

public record Bet
{
    public required int Amount { get; init; }

    public required Guid InitiatingPlayerId { get; init; }
    
    public required List<Guid> CallingPlayerIds { get; init; }
}

public static class Bets
{
    public static Bet Empty => new()
    {
        Amount = 0,
        InitiatingPlayerId = Players.Empty.Id,
        CallingPlayerIds = new()
    };
}
