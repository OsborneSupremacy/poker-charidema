﻿namespace Poker.Domain.Functions.Classic;

public static class ClassicHandEvaluator
{
    public static readonly HandEvaluator Evaluate = request =>
    {
        var evaluatedHandSegments =
            EvaluateHandSegments(request).ToList();

        return new EvaluatedHandResponse
        {
            Hand = request.HandToEvaluate,
            HandQualification =
                evaluatedHandSegments.AllMeetRequirements() switch
                {
                    true => HandQualifications.Qualifies,
                    false =>
                        request.RemainingCardCount
                            >= evaluatedHandSegments.TotalOutstandingCount()
                        ? HandQualifications.Possible
                        : HandQualifications.Eliminated
                },
            EvaluatedHandSegments = evaluatedHandSegments,
            UnusedCards = evaluatedHandSegments.Last().UnusedCards,
            RemainingCardCount = request.RemainingCardCount
        };
    };

    private static IEnumerable<EvaluatedHandSegmentResponse> EvaluateHandSegments(
        EvaluatedHandRequest request
    )
    {
        UnusedCardsMessage unusedCards = new(request.Cards);

        foreach (var response in request
                     .HandToEvaluate
                     .HandSegments
                     .Select
                     (
                         segment => EvaluateHandSegment
                         (
                            new EvaluatedHandSegmentRequest
                            {
                                HandSegment = segment,
                                UnusedCards = unusedCards
                            }
                        )
                    )
                 )
        {
            unusedCards = response.UnusedCards;
            yield return response;
        }
    }

    private static EvaluatedHandSegmentResponse EvaluateHandSegment(
        EvaluatedHandSegmentRequest request
        )
    {
        HandCards contributingCards = new();
        var unusedCardsOut = request.UnusedCards;

        for (var x = 0; x < request.HandSegment.RequiredCount; x++)
        {
            if (RequirementsMet()) // segment is satisfied -- exit
                break;

            if (!unusedCardsOut.Any()) // no more cards to contribute -- exit
                break;

            var qualifyingCards = request.HandSegment.EligibleCards
                .Except(contributingCards.AllStandardized())
                .ToList();

            var standard = unusedCardsOut.UnusedStandard
                .Where(qualifyingCards.Contains)
                .OrderByPokerStandard()
                .FirstOrDefault() ?? Cards.Empty;

            if (standard != Cards.Empty)
            {
                contributingCards.Add(standard);
                unusedCardsOut.UnusedStandard.Remove(standard);
                continue;
            }

            if (!unusedCardsOut.UnusedWild.Any())
                continue;
            
            contributingCards.Add(
                unusedCardsOut.UnusedWild.Dequeue(),
                qualifyingCards
                    .OrderByPokerStandard()
                    .First()
            );
        }

        return new EvaluatedHandSegmentResponse()
        {
            MeetsRequirements = RequirementsMet(),
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
        
        bool RequirementsMet() =>
            contributingCards.Count()
            >= request.HandSegment.RequiredCount;        
    }
}
