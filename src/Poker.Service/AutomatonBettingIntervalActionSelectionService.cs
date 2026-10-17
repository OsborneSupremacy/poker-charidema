namespace Poker.Service;

/// <inheritdoc />
internal class AutomatonBettingIntervalActionSelectionService : IAutomatonBettingIntervalActionSelectionService
{
    private readonly IRandomService _randomService;

    public AutomatonBettingIntervalActionSelectionService(IRandomService randomService)
    {
        _randomService = randomService ?? throw new ArgumentNullException(nameof(randomService));
    }

    public Task<BettingIntervalActionSelectionResponse> SelectAsync(BettingIntervalActionSelectionRequest request)
    {
        var option = _randomService
            .PickFromWeightedList(request.Options.AvailableBettingIntervalActions);

        return Task.FromResult(
            new BettingIntervalActionSelectionResponse
            {
                BettingIntervalActionType = option.BettingIntervalActionType,
                Amount = option.BettingIntervalActionType switch
                {
                    BettingIntervalActionType.Bet or BettingIntervalActionType.Raise =>
                        _randomService.GetAmount(1, request.Options.MaximumBet),
                    _ => 0
                }
            }
        );
    }
}
