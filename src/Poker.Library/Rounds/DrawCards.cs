﻿using Poker.Library.Cards;

namespace Poker.Library.Rounds;

public record DrawCards : IRound
{
    public string Name => "Draw Cards";

    public required uint Maximum { get; init; }

    public required List<DrawCardsMaximums> Overrides { get; init; }

    public bool GameCanEndAfter => false;
}

public record DrawCardsMaximums
{
    public required Rank Rank { get; set; }

    public required uint Maximum { get; set; }
}