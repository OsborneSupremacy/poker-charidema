﻿namespace Poker.Library;

public record Game
{
    public required IVariant Variant { get; init; }

    public double Ante { get; init; }

    public double Pot { get; init; }

    public required IDeck Deck { get; init; }

    public required List<ICard> CommunityCards { get; init; }

    public required List<ICard> Discards { get; init; }

    public required List<IPlayer> Players { get; init; }

    public required List<Round> Rounds { get; init; }
}
