﻿namespace Poker.Library;

public record DrawCardsAction : RoundAction
{
    public uint Maximums { get; init; }

    public List<DrawCardsMaximums> Overrides { get; init; }
}

public record DrawCardsMaximums
{
    public Rank Rank { get; set; }

    public uint Maximum { get; set; }
}