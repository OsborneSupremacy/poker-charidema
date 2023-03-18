namespace Poker.Library;

public abstract record Card
{
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
