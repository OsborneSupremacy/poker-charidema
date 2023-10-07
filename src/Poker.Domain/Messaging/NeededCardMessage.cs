namespace Poker.Domain.Messaging;

public record NeededCardMessage
{
    public required List<NeededCard> Cards { get; init; }
}
