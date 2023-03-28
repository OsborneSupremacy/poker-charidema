﻿namespace Poker.Library;

public record GameArgs
{
    public required List<Player> Players { get; init; }

    public required IVariant Variant { get; init; }

    public required Deck Deck { get; init; }

    public required Player Button { get; init; }
}
