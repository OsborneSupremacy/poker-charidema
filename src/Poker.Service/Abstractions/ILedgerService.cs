namespace Poker.Service.Abstractions;

public interface ILedgerService
{
    public void InitializePlayerStacks(IReadOnlyList<Guid> playerIds, int initialBalance);

    public int GetPlayerStack(Guid playerId);

    public void InitializeTable(Guid gameId, IReadOnlyList<Guid> participantIds);

    public int GetPlayerGetBeginningStack(Guid requestId);

    public bool IsPlayerBusted(Guid requestId);
}
