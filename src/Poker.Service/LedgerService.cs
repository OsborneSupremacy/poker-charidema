using System.Collections.Concurrent;

namespace Poker.Service;

internal class LedgerService : ILedgerService
{
    /// <summary>
    /// Ledger entries keyed by player ID.
    /// </summary>
    private readonly Dictionary<Guid, List<LedgerEntry>> _ledgerEntries;

    /// <summary>
    /// Table balance entries keyed by game ID, then by player ID.
    /// </summary>
    private readonly Dictionary<Guid, Dictionary<Guid, List<TableBalanceEntry>>> _tableBalanceEntries;

    // ReSharper disable once ConvertConstructorToMemberInitializers
    public LedgerService()
    {
        _ledgerEntries = new();
        _tableBalanceEntries = new();
    }

    public void InitializePlayerStacks(IReadOnlyList<Guid> playerIds, int initialBalance)
    {
        foreach (var playerId in playerIds)
        {
            var entry = new LedgerEntry
            {
                Id = Guid.NewGuid(),
                Timestamp = DateTimeOffset.UtcNow,
                PlayerId = playerId,
                Credit = initialBalance,
                Debit = 0,
                LedgerEntryType = LedgerEntryType.InitialBalance
            };
            _ledgerEntries.Add(playerId, [entry]);
        }
    }

    public int GetPlayerStack(Guid playerId)
    {
        var playerEntries = _ledgerEntries.GetValueOrDefault(playerId, []);
        return playerEntries.Sum(e => e.Credit) - playerEntries.Sum(e => e.Debit);
    }

    public void InitializeTable(Guid gameId, IReadOnlyList<Guid> participantIds) =>
        _tableBalanceEntries
            .Add(
                gameId,
                participantIds.ToDictionary<Guid, Guid, List<TableBalanceEntry>>(playerId => playerId, _ => [])
            );

    public int GetGamePot(Guid gameId)
    {
        var gameEntry = _tableBalanceEntries.GetValueOrDefault(gameId, new());
        return gameEntry.Values
            .SelectMany(entries => entries)
            .Sum(e => e.Credit) - gameEntry.Values
            .SelectMany(entries => entries)
            .Sum(e => e.Debit);
    }

    public int GetParticipantStake(Guid gameId, Guid participantId)
    {
        var gameEntry = _tableBalanceEntries.GetValueOrDefault(gameId, new());
        var playerEntries = gameEntry.GetValueOrDefault(participantId, []);
        return playerEntries.Sum(e => e.Credit) - playerEntries.Sum(e => e.Debit);
    }

    public IReadOnlyDictionary<Guid, int> GetParticipantStakes(Guid gameId)
    {
        var gameEntry = _tableBalanceEntries.GetValueOrDefault(gameId, new());
        var participantIds = gameEntry.Keys;
        var stakes = new Dictionary<Guid, int>();
        foreach (var playerId in participantIds)
        {
            var playerEntries = gameEntry.GetValueOrDefault(playerId, []);
            var stake = playerEntries.Sum(e => e.Credit) - playerEntries.Sum(e => e.Debit);
            stakes[playerId] = stake;
        }
        return stakes;
    }

    public IReadOnlyDictionary<Guid, int> GetParticipantCallAmounts(Guid gameId)
    {
        var gameEntry = _tableBalanceEntries.GetValueOrDefault(gameId, new());
        var participantIds = gameEntry.Keys;

        var maxStake = participantIds
            .Select(participantId =>
            {
                var playerEntries = gameEntry.GetValueOrDefault(participantId, []);
                return playerEntries.Sum(e => e.Credit) - playerEntries.Sum(e => e.Debit);
            })
            .Max();

        var stakes = new Dictionary<Guid, int>();

        foreach (var playerId in participantIds)
        {
            var playerEntries = gameEntry.GetValueOrDefault(playerId, []);
            var stake = playerEntries.Sum(e => e.Credit) - playerEntries.Sum(e => e.Debit);
            stakes[playerId] = maxStake - stake;
        }
        return stakes;
    }

    public void RecordAnte(Guid gameId, Guid participantId, int amount)
    {
        var participantStack = GetPlayerStack(participantId);
        if (participantStack < amount)
            throw new InvalidOperationException("Participant does not have enough balance to ante.");

        var gameEntry = _tableBalanceEntries.GetValueOrDefault(gameId, new());
        var participantEntries = gameEntry.GetValueOrDefault(participantId, []);

        var tableEntry = new TableBalanceEntry
        {
            Id = Guid.NewGuid(),
            Timestamp = DateTime.UtcNow,
            ParticipantId = participantId,
            Credit = amount,
            Debit = 0,
            TableBalanceEntryType = TableBalanceEntryType.Ante
        };
        participantEntries.Add(tableEntry);

        var ledgerEntry = new LedgerEntry
        {
            Id = Guid.NewGuid(),
            Timestamp = DateTimeOffset.UtcNow,
            PlayerId = participantId,
            Credit = 0,
            Debit = amount,
            LedgerEntryType = LedgerEntryType.Ante
        };
        _ledgerEntries[participantId].Add(ledgerEntry);
    }
}

