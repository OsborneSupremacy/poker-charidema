namespace Poker.Domain.Delegates;

public delegate Ledger LedgerUpdater(Ledger ledger, LedgerUpdateRequest request);
