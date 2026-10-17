namespace Poker.Service.Abstractions;

public interface IBettingIntervalActionSelectionService
{
    /// <summary>
    /// Chooses the participant's action during a betting interval, from the available options.
    /// </summary>
    public Task<BettingIntervalActionSelectionResponse> SelectAsync(BettingIntervalActionSelectionRequest request);
}
