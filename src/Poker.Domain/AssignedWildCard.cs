namespace Poker.Domain;

public record AssignedWildCard
{
    public required Card WildCard { get; init; }

    public required Card StandardCard { get; init; }
}
