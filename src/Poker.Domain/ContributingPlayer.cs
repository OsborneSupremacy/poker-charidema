namespace Poker.Domain;

public record ContributingPlayer()
{
    public required Guid PlayerId { get; init; }
    
    public required int Amount { get; init; }
};
