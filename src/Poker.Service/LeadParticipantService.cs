namespace Poker.Service;

/// <inheritdoc />
internal class LeadParticipantService : ILeadPlayerService
{
    private readonly WinnerEvaluator _winnerEvaluator;

    private readonly HandCollectionEvaluator _handCollectionEvaluator;

    private readonly HandEvaluator _handEvaluator;

    public LeadParticipantService(
        WinnerEvaluator winnerEvaluator,
        HandCollectionEvaluator handCollectionEvaluator,
        HandEvaluator handEvaluator
        )
    {
        _winnerEvaluator = winnerEvaluator ?? throw new ArgumentNullException(nameof(winnerEvaluator));
        _handCollectionEvaluator =
            handCollectionEvaluator ?? throw new ArgumentNullException(nameof(handCollectionEvaluator));
        _handEvaluator = handEvaluator ?? throw new ArgumentNullException(nameof(handEvaluator));
    }

    private static IEnumerable<Participant> GetParticipantsWithFaceUpCardsOnly(EvaluateLeadParticipantRequest request)
    {
        foreach (var player in request.Participants.NotFolded())
        {
            var faceUpCards = player
                .CardsInPlay
                .FaceUp()
                .Concat(request.CommunityCards.FaceUp())
                .ToList();
            yield return player with { CardsInPlay = faceUpCards };
        }
    }

    public Task<EvaluateLeaderPlayerResponse> ExecuteAsync(EvaluateLeadParticipantRequest request)
    {
        var playersIn = GetParticipantsWithFaceUpCardsOnly(request).ToList();

        var winnerResponse = _winnerEvaluator(
            new()
            {
                Participants = playersIn,
                HandCollectionEvaluator = _handCollectionEvaluator,
                HandEvaluator = _handEvaluator
            }
        );

        return Task.FromResult(new EvaluateLeaderPlayerResponse
        {
            LeadParticipants = winnerResponse.Winners,
            ParticipantHands = winnerResponse.ParticipantHands,
            LeadingHand = winnerResponse.WinningHand
        });
    }
}
