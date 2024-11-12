namespace Poker.Domain.Extensions;

public static class CardInPlayExtensions
{
    public static List<Card> ToCards(this IEnumerable<CardInPlay> input) =>
        input
            .Select(x => x.Card)
            .ToList();

    public static IEnumerable<CardInPlay> FaceUp(this IEnumerable<CardInPlay> input) =>
        input.Where(x => x.CardOrientation == CardOrientation.FaceUp);
}
