namespace Poker.Library;

public record Card
{
    public CardOrientations CardOrientation { get; init; }

    public Rank Rank { get; init; }

    public Suit Suit { get; init; }

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
