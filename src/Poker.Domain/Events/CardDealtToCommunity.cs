namespace Poker.Domain.Events;

public record CardDealtToCommunity
{
    public required Card Card { get; init; }
}
