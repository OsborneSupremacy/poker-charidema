namespace Poker.Domain.Messaging.Extensions;

public static class EvaluatedHandSegmentResponseExtensions
{
    public static int TotalOutstandingCount(this IEnumerable<EvaluatedHandSegmentResponse> response) =>
        response.Sum(x => x.Outstanding.RequiredCount);

    public static bool AllMeetRequirements(this IEnumerable<EvaluatedHandSegmentResponse> response) =>
        response.All(x => x.MeetsRequirements);
}
