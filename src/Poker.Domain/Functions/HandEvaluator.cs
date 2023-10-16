namespace Poker.Domain.Functions;

internal static class HandEvaluator
{
    public static IEnumerable<EvaluatedHandResponse> Evaluate(
        EvaluatedHandCollectionRequest request
        )
    {
        foreach (var hand in request.HandsToEvaluate
            .OrderByDescending(h => h.HandDefinition.Value)
            .ThenByDescending(h => h.HighRank.Value)
            .ThenByDescending(h => h.Suit.Priority)
            )
            yield return Evaluate(new EvaluatedHandRequest
            {
                Cards = request.Cards,
                HandToEvaluate = hand,
                RemainingCardCount = request.RemainingCardCount
            });
    }

    public static EvaluatedHandResponse Evaluate(EvaluatedHandRequest request)
    {
        var evalulatedHandSegments =
            EvaluateHandSegments(request).ToList();

        return new EvaluatedHandResponse
        {
            Hand = request.HandToEvaluate,
            HandQualification =
                evalulatedHandSegments.AllMeetRequirements() switch
                {
                    true => HandQualifications.Qualifies,
                    false =>
                        request.RemainingCardCount
                            >= evalulatedHandSegments.TotalOutstandingCount()
                        ? HandQualifications.Possible
                        : HandQualifications.Eliminated
                },
            EvalulatedHandSegments = evalulatedHandSegments,
            UnusedCards = evalulatedHandSegments.Last().UnusedCards
        };
    }

    public static IEnumerable<EvaluatedHandSegmentResponse> EvaluateHandSegments(
        EvaluatedHandRequest request
         )
    {
        UnusedCardsMessage unusedCards = new(request.Cards);

        foreach (var segment in request.HandToEvaluate.HandSegments)
        {
            var response = EvalulateHandSegment(
                new EvaluatedHandSegmentRequest
                {
                    HandSegment = segment,
                    UnusedCards = unusedCards
                });

            unusedCards = response.UnusedCards;
            yield return response;
        }
    }

    private static EvaluatedHandSegmentResponse EvalulateHandSegment(
        EvaluatedHandSegmentRequest request
        )
    {
        HandCards contributingCards = new();
        var unusedCardsOut = request.UnusedCards;

        for (var x = 0; x < request.HandSegment.RequiredCount; x++)
        {
            if (requirmentsMet()) // segment is satisfied -- exit
                break;

            if (!unusedCardsOut.Any()) // no more cards to contribute -- exit
                break;

            var qualifyingCards = request.HandSegment.EligibleCards
                .Except(contributingCards.AllStandardized());

            var standard = unusedCardsOut.UnusedStandard
                .Where(qualifyingCards.Contains)
                .OrderByPokerStandard()
                .FirstOrDefault() ?? Cards.Empty;

            if (standard != Cards.Empty)
            {
                contributingCards.Add(standard);
                unusedCardsOut.UnusedStandard.Remove(standard);
                continue;
            };

            if (!unusedCardsOut.UnusedWild.Any())
                continue;

            contributingCards.Add(
                unusedCardsOut.UnusedWild.Dequeue(),
                qualifyingCards
                    .OrderByPokerStandard()
                    .First()
            );
        };

        bool requirmentsMet() =>
            contributingCards.Count()
            >= request.HandSegment.RequiredCount;

        return new EvaluatedHandSegmentResponse()
        {
            MeetsRequirements = requirmentsMet(),
            Contributing = contributingCards,
            UnusedCards = unusedCardsOut,
            Outstanding = new HandSegment
            {
                RequiredCount = request.HandSegment.RequiredCount
                    - contributingCards.Count(),
                EligibleCards = request.HandSegment.EligibleCards
                    .Except(contributingCards.AllStandardized())
                    .ToList()
            }
        };
    }
}
