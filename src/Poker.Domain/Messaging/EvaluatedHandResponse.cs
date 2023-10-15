﻿namespace Poker.Domain.Messaging;

public record EvaluatedHandResponse
{
    public required Hand Hand { get; init; }

    public required HandQualifications HandQualification { get; init; }

    public required List<EvaluatedHandSegmentResponse> EvalulatedHandSegments { get; init; }

    public required UnusedCardsMessage UnusedCards { get; init; }
}