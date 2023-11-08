namespace Poker.Domain;

public record ContributedPlayer()
{
    public required Guid PlayerId { get; init; }
    
    public required int Amount { get; init; }
};
