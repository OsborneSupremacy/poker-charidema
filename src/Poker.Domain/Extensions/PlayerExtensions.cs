namespace Poker.Domain.Extensions;

public static class PlayerExtensions
{
    public static Player NextPlayer(
        this List<Player> players,
        Player currentPlayer
        )
    {
        var index = players
            .FindIndex(x => x.Id == currentPlayer.Id);

        return index == players.Count - 1 ? players.First() : players[index + 1];
    }

    public static List<Player> GetRichest(this List<Player> players) =>
        players.Where(x => x.Stack == players.Max(p => p.Stack)).ToList();

    public static Player DealCards(
        this Player input,
        CardOrientation orientation,
        IEnumerable<Card> cards
        )
    {
        var cardsOut = input.CardsInPlay;
        cardsOut.AddRange(cards.Select(c => new CardInPlay
        {
            Card = c,
            CardLocation = CardLocation.PlayerHand,
            CardOrientation = orientation
        }));
        return input with { CardsInPlay = cardsOut };
    }

    public static Player DealFaceDownCards(
        this Player input,
        IEnumerable<Card> cards
    ) => input.DealCards(CardOrientation.FaceDown, cards);
}
