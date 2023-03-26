namespace Poker.Library;

public record Player
{
    public required Guid Id { get; init; }

    public required string Name { get; init; }

    public required double Stack { get; init; }

    public bool IsInHand =>
        Stack > 0 && !HasFolded;

    public bool HasFolded { get; init; }

    public Hand? Hand { get; init; }
}
