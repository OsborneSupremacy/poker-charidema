namespace Poker.Service;

/// <inheritdoc />
public class LeadPlayerService : ILeadPlayerService
{
    private readonly WinnerEvaluator _winnerEvaluator;

    private readonly HandCollectionEvaluator _handCollectionEvaluator;

    private readonly HandEvaluator _handEvaluator;

    public LeadPlayerService(
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

    private static IEnumerable<Player> GetPlayersWithFaceUpCardsOnly(EvaluateLeadPlayerRequest request)
    {
        foreach (var player in request.Players.NotFolded())
        {
            var faceUpCards = player
                .CardsInPlay
                .FaceUp()
                .Concat
                (
                    request.CommunityCards.FaceUp()
                )
                .ToList();
            yield return player with { CardsInPlay = faceUpCards };
        }
    }

    public Task<EvaluateLeaderPlayerResponse> ExecuteAsync(EvaluateLeadPlayerRequest request)
    {
        var playersIn = GetPlayersWithFaceUpCardsOnly(request).ToList();

        var winnerResponse = _winnerEvaluator(
            new()
            {
                Players = playersIn,
                HandCollectionEvaluator = _handCollectionEvaluator,
                HandEvaluator = _handEvaluator
            }
        );

        return Task.FromResult(new EvaluateLeaderPlayerResponse
        {
            LeadPlayers = winnerResponse.Winners,
            PlayerHands = winnerResponse.PlayerHands,
            LeadingHand = winnerResponse.WinningHand
        });
    }
}
