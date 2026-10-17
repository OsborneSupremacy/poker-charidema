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

    /// <summary>
    /// The participants in seat order, beginning with the starting participant.
    /// </summary>
    public static IEnumerable<Participant> InTurnOrderFrom(
        this IReadOnlyList<Participant> participants,
        Participant startingParticipant
    )
    {
        var startingIndex = participants
            .ToList()
            .FindIndex(p => p.Id == startingParticipant.Id);

        return participants
            .Skip(startingIndex)
            .Concat(participants.Take(startingIndex));
    }

    public static Participant HumanParticipant(this IEnumerable<Participant> participants) =>
        participants.SingleOrDefault(x => !x.Automaton) ?? Participants.Empty;

    public static IEnumerable<Participant> NotFolded(this IEnumerable<Participant> participants) =>
        participants.Where(x => !x.Folded);

    public static Participant DealCardsTo(
        this Participant input,
        CardOrientation orientation,
        IEnumerable<Card> cards
    )
    {
        var cardsOut = input.CardsInPlay.ToList();
        cardsOut.AddRange(cards.Select(c => new CardInPlay
        {
            Card = c,
            CardLocation = CardLocation.PlayerHand,
            CardOrientation = orientation
        }));
        return input with { CardsInPlay = cardsOut, };
    }

    public static Participant DealCardsFaceDownTo(
        this Participant input,
        IEnumerable<Card> cards
    ) =>
        input.DealCardsTo(CardOrientation.FaceDown, cards);

    /// <summary>
    /// Adds the community cards to the participant's cards in play, so that
    /// the participant's hand can be evaluated with them.
    /// </summary>
    public static Participant WithCommunityCards(
        this Participant input,
        IEnumerable<CardInPlay> communityCards
    ) =>
        input with { CardsInPlay = input.CardsInPlay.Concat(communityCards).ToList() };
}
