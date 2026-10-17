namespace Poker.Domain.Delegates;

/// <summary>
/// Chooses the cards a participant discards during a draw phase.
/// </summary>
public delegate IReadOnlyList<Card> DiscardStrategy(DiscardStrategyRequest request);
