namespace Poker.Domain;

/// <summary>
/// A player needs <code>Cards</code> cards in <code>Cards</code> to complete a hand.
/// If a <see cref="NeededCardMessage"/> has multiple <see cref="NeededCardGroup"/>s, they
/// all need to be satisfied to complete the hand.
/// </summary>
public record NeededCardGroup
{
    public required uint Count { get; init; }

    public required List<Card> Cards { get; init; }
}
