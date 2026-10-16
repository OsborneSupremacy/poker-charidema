namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class DefaultDealerTests
{
    private readonly Participant _participantOne = Participants.Empty with { Id = Guid.NewGuid(), Name = "One" };

    private readonly Participant _participantTwo = Participants.Empty with { Id = Guid.NewGuid(), Name = "Two" };

    private readonly Deck _deck = Decks.Empty with
    {
        Cards =
        [
            Cards.AceOfSpades,
            Cards.KingOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades,
            Cards.TenOfSpades
        ]
    };

    private DealRequest CreateRequest(
        CardLocation cardDestination,
        int cardsToDealCount,
        IReadOnlyList<CardInPlay> communityCards
    ) =>
        new()
        {
            Deck = _deck,
            Participants = [_participantOne, _participantTwo],
            CommunityCards = communityCards,
            StartingParticipant = _participantOne,
            CardsToDealCount = cardsToDealCount,
            CardOrientation = cardDestination == CardLocation.Community
                ? CardOrientation.FaceUp
                : CardOrientation.FaceDown,
            CardDestination = cardDestination,
            CardDealtToParticipantAction = _ => { },
            CardDealtToCommunityAction = _ => { }
        };

    [Fact]
    public void Deal_CardsDealtToCommunity_CommunityDestination()
    {
        // Arrange
        var request = CreateRequest(CardLocation.Community, 3, []);

        List<CardInPlay> expectedCommunityCards =
        [
            new() { Card = Cards.AceOfSpades, CardLocation = CardLocation.Community, CardOrientation = CardOrientation.FaceUp },
            new() { Card = Cards.KingOfSpades, CardLocation = CardLocation.Community, CardOrientation = CardOrientation.FaceUp },
            new() { Card = Cards.QueenOfSpades, CardLocation = CardLocation.Community, CardOrientation = CardOrientation.FaceUp }
        ];

        // Act
        var response = DefaultDealer.Deal(request);

        // Assert
        response.CommunityCards.Should().BeEquivalentTo(expectedCommunityCards, o => o.WithStrictOrdering());
        response.Deck.Cards.Should().Equal(Cards.JackOfSpades, Cards.TenOfSpades);
        response.Participants.Should().AllSatisfy(p => p.CardsInPlay.Should().BeEmpty());
    }

    [Fact]
    public void Deal_CardsAddedToExistingCommunityCards_CommunityDestination()
    {
        // Arrange
        CardInPlay existingCard = new()
        {
            Card = Cards.TwoOfHearts,
            CardLocation = CardLocation.Community,
            CardOrientation = CardOrientation.FaceUp
        };

        var request = CreateRequest(CardLocation.Community, 1, [existingCard]);

        // Act
        var response = DefaultDealer.Deal(request);

        // Assert
        response.CommunityCards
            .ToCards()
            .Should()
            .Equal(Cards.TwoOfHearts, Cards.AceOfSpades);
    }

    [Fact]
    public void Deal_CardsDealtToEachParticipant_PlayerHandDestination()
    {
        // Arrange
        var request = CreateRequest(CardLocation.PlayerHand, 2, []);

        // Act
        var response = DefaultDealer.Deal(request);

        // Assert
        response.CommunityCards.Should().BeEmpty();
        response.Deck.Cards.Should().Equal(Cards.TenOfSpades);
        response.Participants.Should().AllSatisfy(p =>
        {
            p.CardsInPlay.Should().HaveCount(2);
            p.CardsInPlay.Should().AllSatisfy(c =>
            {
                c.CardLocation.Should().Be(CardLocation.PlayerHand);
                c.CardOrientation.Should().Be(CardOrientation.FaceDown);
            });
        });
    }
}
