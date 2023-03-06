namespace Poker.Library;

public record Card
{
    public enum CardStatus
    {
        InDeck,
        PlayerCard,
        CommunityCard
    }

    public Rank Rank { get; init; }

    public Suit Suit { get; init; }

    public bool IsWild { get; set; }
}
