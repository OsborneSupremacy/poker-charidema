﻿namespace Poker.Library.Rounds;

public record RoundArgs
{
    public required IRound Round { get; init; }

    public required IDeck Deck { get; init; }

    public required List<ICard> CommunityCards { get; init; }

    public required List<IInGamePlayer> Players { get; init; }

    public required IInGamePlayer StartingPlayer { get; init; }

    public required uint RoundNumber { get; init; }

    public required double Pot { get; init; }
}