namespace Poker.Domain;

public enum CardLocation
{
    Empty,
    Deck,
    PlayerHand,
    Community,
    DiscardPile
}

public enum CardOrientation
{
    Empty,
    FaceUp,
    FaceDown
}

/// <summary>
/// A CardInPlay is a <see cref="Card"/> that has been dealt, and
/// therefore has additional properties.
/// </summary>
public record CardInPlay
{
    public required Card Card { get; init; }

    public required CardLocation CardLocation { get; init; }

    public required CardOrientation CardOrientation { get; init; }
}
