namespace Poker.Library.Cards;

public abstract record Card
{
    public Guid Id { get; } = Guid.NewGuid();

    public CardOrientations CardOrientation { get; init; }

    public bool IsWild { get; set; }
}

public enum CardDestinations
{
    PlayerHand,
    Community
}

public enum CardOrientations
{
    Faceup,
    Facedown
}
