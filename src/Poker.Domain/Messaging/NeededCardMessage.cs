namespace Poker.Domain.Messaging;

public record NeededCardMessage
{
    public required List<NeededCardGroup> Groups { get; init; }
}
