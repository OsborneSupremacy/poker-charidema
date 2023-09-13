namespace Poker.Library;

public record MoveResult
{
    public required IInGamePlayer PlayerInTurn { get; init; }

    // TODO: Change this to DeckCardsOut. We're not changing the whole deck.
    public required IDeck Deck { get; init; }

    public required uint Pot { get; set; }
}
