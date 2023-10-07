namespace Poker.Domain.Messaging;

public record NeededCardMessage
{
    public required List<NeededCardGroup> NeededCardGroups { get; init; }
}
