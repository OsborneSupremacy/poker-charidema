﻿namespace Poker.Domain.Messaging;

public record PhaseRequest
{
    public required Game Game { get; init; }

    public required Phase Phase { get; init; }

    public required Deck Deck { get; init; }

    public required List<CardInPlay> CommunityCards { get; init; }

    public required Player StartingPlayer { get; init; }

    public required int Pot { get; init; }

    /// <summary>
    /// Will only be true if a previous phase resulted in the game being over.
    /// Phases should generally not do any work if this is true.
    /// </summary>
    public required bool GameOver { get; init; }
}
