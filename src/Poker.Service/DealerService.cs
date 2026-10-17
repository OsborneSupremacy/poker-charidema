using Poker.Domain.Events;

namespace Poker.Service;

/// <inheritdoc cref="IDealerService"/>
/// <inheritdoc cref="IPhaseService"/>
internal class DealerService : IDealerService, IPhaseService
{
    private readonly IUserInterfaceService _userInterfaceService;

    private readonly IRandomFactory _randomFactory;

    private readonly ShuffleAlgorithm _shuffleAlgorithm;

    private readonly Dealer _dealer;

    public DealerService(
        IUserInterfaceService userInterfaceService,
        IRandomFactory randomFactory,
        ShuffleAlgorithm shuffleAlgorithm,
        Dealer dealer
        )
    {
        _userInterfaceService = userInterfaceService ?? throw new ArgumentNullException(nameof(userInterfaceService));
        _randomFactory = randomFactory ?? throw new ArgumentNullException(nameof(randomFactory));
        _shuffleAlgorithm = shuffleAlgorithm ?? throw new ArgumentNullException(nameof(shuffleAlgorithm));
        _dealer = dealer ?? throw new ArgumentNullException(nameof(dealer));
    }

    public Task<PhaseResponse> ExecuteAsync(PhaseRequest request)
    {
        if(request.GameOver)
            return Task.FromResult(request.ToGameOverResponse());

        _userInterfaceService.WriteHeading(HeadingLevel.Five, $"{request.Phase.Name}");

        var dealResponse = _dealer(new DealRequest
        {
            Deck = request.Deck,
            Participants = request.Participants,
            CommunityCards = request.CommunityCards,
            StartingParticipant = request.StartingParticipant,
            CardsToDealCount = request.Phase.CardsToDealCount,
            CardOrientation = request.Phase.CardOrientation,
            CardDestination = request.Phase.CardDestination,
            CardDealtToParticipantAction = cardDealt =>
            {
                _userInterfaceService.WriteLine($"Card dealt to {cardDealt.Participant.Name}");
            },
            CardDealtToCommunityAction = cardDealt =>
            {
                _userInterfaceService.WriteLine($"{cardDealt.Card.Rank.Name} of {cardDealt.Card.Suit.Name} dealt to the community");
            }
        });

        return Task.FromResult(new PhaseResponse
        {
            Deck = dealResponse.Deck,
            CommunityCards = dealResponse.CommunityCards,
            Discards = request.Discards,
            Participants = dealResponse.Participants,
            Winners = [],
            GameOver = false,
            Pot = request.Pot
        });
    }

    public Task<Deck> ShuffleAsync(Deck deck) =>
        Task.FromResult(
            _shuffleAlgorithm(_randomFactory.Create(), deck)
        );
}
