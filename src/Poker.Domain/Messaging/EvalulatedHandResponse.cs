namespace Poker.Domain.Messaging;

public record EvalulatedHandResponse
{
    public required Hand Hand { get; init; }

    public required HandQualifications HandQualification { get; init; }

    public required List<EvalulatedHandSegmentResponse> EvalulatedHandSegments { get; init; }
}
