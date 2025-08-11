namespace Poker.Domain.Messaging;

public record TableBalanceStatusResponse
{
    public required int Pot { get; init; }

    public required IReadOnlyDictionary<Guid, int> ParticipantStakes { get; init; }

    /// <summary>
    /// Participants who have called, e.g. do not need to pay more.
    /// </summary>
    public required IReadOnlyList<Guid> Callers { get; init; }

    /// <summary>
    /// Participants who have not yet paid their stakes, with their pending amounts.
    /// </summary>
    public required IReadOnlyDictionary<Guid, int> PendingCallers { get; init; }
}
