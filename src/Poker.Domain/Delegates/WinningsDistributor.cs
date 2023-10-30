namespace Poker.Domain.Delegates;

public delegate DistributeWinningsResponse WinningsDistributor(
    DistributeWinningsRequest request
);
