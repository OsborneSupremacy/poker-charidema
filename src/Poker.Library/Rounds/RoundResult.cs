namespace Poker.Library.Rounds;

public record RoundResult
{
    public required IDeck Deck { get; init; }

    public required List<ICard> CommunityCards { get; init; }

    public required List<IInGamePlayer> Players { get; init; }

    public required bool GameOver { get; init; }

    public required double Pot { get; init; }
}
