namespace Poker.Domain;

public record AssignedWildCard
{
    public required Card Card { get; init; }

    public required Card Impersonating { get; init; }
}
