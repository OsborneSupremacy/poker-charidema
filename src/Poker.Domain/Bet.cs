namespace Poker.Domain;

public record Bet
{
    public required int Amount { get; init; }

    public required Guid InitiatingPlayerId { get; init; }

    public required IReadOnlyList<Guid> CheckedPlayerIds { get; init; }

    public required IReadOnlyDictionary<Guid, int> PlayerContributions { get; init; }
}

public static class Bets
{
    public static Bet Empty => new()
    {
        Amount = 0,
        InitiatingPlayerId = Players.Empty.Id,
        CheckedPlayerIds = [],
        PlayerContributions = new Dictionary<Guid, int>()
    };
}
