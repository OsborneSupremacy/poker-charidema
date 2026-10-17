namespace Poker.Service.Abstractions;

public interface IDiscardSelectionService
{
    /// <summary>
    /// Chooses the cards the participant discards during a draw phase.
    /// </summary>
    public Task<IReadOnlyList<Card>> SelectAsync(DiscardSelectionRequest request);
}
