namespace Poker.Domain.Extensions;

public static class ParticipantExtensions
{
    public static Participant NextParticipant(
        this IReadOnlyList<Participant> participants,
        Participant currentParticipant
    ) => participants.ToList().NextParticipant(currentParticipant);

    public static Participant NextParticipant(
        this List<Participant> participants,
        Participant currentParticipant
    )
    {
        var index = participants
            .FindIndex(x => x.Id == currentParticipant.Id);

        return index == participants.Count - 1 ? participants.First() : participants[index + 1];
    }

    public static Participant HumanParticipant(this IEnumerable<Participant> participants) =>
        participants.Single(x => !x.Automaton);

    public static IEnumerable<Participant> NotFolded(this IEnumerable<Participant> participants) =>
        participants.Where(x => !x.Folded);

    public static Participant DealCardsTo(
        this Participant input,
        CardOrientation orientation,
        IEnumerable<Card> cards
    )
    {
        var cardsOut = input.CardsInPlay;
        cardsOut.ToList().AddRange(cards.Select(c => new CardInPlay
        {
            Card = c,
            CardLocation = CardLocation.PlayerHand,
            CardOrientation = orientation
        }));
        return input with { CardsInPlay = cardsOut };
    }

    public static Participant DealCardsFaceDownTo(
        this Participant input,
        IEnumerable<Card> cards
    ) =>
        input.DealCardsTo(CardOrientation.FaceDown, cards);
}
