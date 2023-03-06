namespace Poker.Library;

public record Player
{
    public string Name { get; init; }

    public double Stack { get; init; }

    public bool IsInHand =>
        Stack > 0 && !HasFolded;

    public bool HasFolded { get; init; }

    public Hand Hand { get; init; }
}
