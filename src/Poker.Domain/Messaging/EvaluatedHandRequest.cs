﻿namespace Poker.Domain.Messaging;

public record EvaluatedHandRequest
{
    public required List<Card> Cards { get; init; }

    public required Hand HandToEvaluate { get; init; }

    public required int RemainingCardCount { get; init; }
}
