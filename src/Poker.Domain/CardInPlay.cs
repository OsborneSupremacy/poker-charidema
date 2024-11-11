namespace Poker.Domain;

public enum CardLocations
{
    Empty,
    Deck,
    PlayerHand,
    Community,
    DiscardPile
}

public enum CardOrientations
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

    public required CardLocations CardLocation { get; init; }

    public required CardOrientations CardOrientation { get; init; }
}
