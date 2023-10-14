﻿namespace Poker.Domain.Implementations;

public static class HandEvaluator
{
    public static IEnumerable<EvaluatedHandResponse> Evaluate(
        EvaluatedHandRequest request
        )
    {
        foreach(var hand in request.HandsToEvaluate
            .OrderByDescending(h => h.HandDefinition.Value)
            .ThenByDescending(h => h.HighRank.Value)
            .ThenByDescending(h => h.Suit.Priority)
            )
            yield return Evaluate(request, hand);
    }

    public static EvaluatedHandResponse Evaluate(
        EvaluatedHandRequest request,
        Hand hand
        )
    {
        List<EvalulatedHandSegmentResponse> evalulatedHandSegments = new();

        UnusedCardsMessage unusedCards = new(request.Cards);

        foreach (var segment in hand.HandSegments)
        {
            var response = EvalulateHandSegment(
                new EvaluatedHandSegmentRequest
                {
                    HandSegment = segment,
                    UnusedCards = unusedCards
                });

            evalulatedHandSegments.Add(response);
            unusedCards = response.UnusedCards;
        }

        return new EvaluatedHandResponse
        {
            Hand = hand,
            HandQualification =
                evalulatedHandSegments.All(x => x.MeetsRequirements) switch
                {
                    true => HandQualifications.Qualifies,
                    false =>
                        request.RemainingCardCount
                            >= evalulatedHandSegments.Select(x => x.Outstanding.RequiredCount).Sum()
                        ? HandQualifications.Possible
                        : HandQualifications.Eliminated
                },
            EvalulatedHandSegments = evalulatedHandSegments,
            UnusedCards = unusedCards
        };
    }

    private static EvalulatedHandSegmentResponse EvalulateHandSegment(
        EvaluatedHandSegmentRequest request
        )
    {
        HandCards contributingCards = new();
        var unusedCardsOut = request.UnusedCards;

        for(int x = 0; x < request.HandSegment.RequiredCount; x++)
        {
            if (requirmentsMet()) // segment is satisfied -- exit
                break;

            if (!unusedCardsOut.Any()) // no more cards to contribute -- exit
                break;

            var qualifyingCards = request.HandSegment.EligibleCards
                .Except(contributingCards.AllStandardized());

            // should only come into play with 5-of-a-kind. 
            // Allow an eligible card to be reused when it's required for five matches.
            if (!qualifyingCards.Any() && unusedCardsOut.UnusedWild.Any())
                qualifyingCards = request.HandSegment.EligibleCards;

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

        return new EvalulatedHandSegmentResponse()
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
