namespace Poker.Domain.Tests.Functions;

[ExcludeFromCodeCoverage]
public class DefaultDrawerTests
{
    private readonly Participant _participant = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "One",
        CardsInPlay =
        [
            Cards.TwoOfClubs.DealFaceDownToPlayer(),
            Cards.SevenOfHearts.DealFaceDownToPlayer(),
            Cards.NineOfDiamonds.DealFaceDownToPlayer(),
            Cards.KingOfSpades.DealFaceDownToPlayer(),
            Cards.KingOfHearts.DealFaceDownToPlayer()
        ]
    };

    private readonly Deck _deck = Decks.Empty with
    {
        Cards = [Cards.AceOfSpades, Cards.QueenOfSpades, Cards.JackOfSpades, Cards.TenOfSpades]
    };

    private DrawRequest CreateRequest(params Card[] cardsToDiscard) =>
        new()
        {
            Participant = _participant,
            CardsToDiscard = cardsToDiscard,
            Deck = _deck,
            Discards = [],
            CardOrientation = CardOrientation.FaceDown
        };

    [Fact]
    public void Draw_HandSizeUnchanged()
    {
        // Act
        var response = DefaultDrawer.Draw(CreateRequest(Cards.TwoOfClubs, Cards.SevenOfHearts, Cards.NineOfDiamonds));

        // Assert
        response.Participant.CardsInPlay.Should().HaveCount(5);
    }

    [Fact]
    public void Draw_DiscardedCardsReplacedWithTopOfDeck()
    {
        // Act
        var response = DefaultDrawer.Draw(CreateRequest(Cards.TwoOfClubs, Cards.SevenOfHearts, Cards.NineOfDiamonds));

        // Assert
        response.Participant.CardsInPlay.ToCards().Should().BeEquivalentTo(
        [
            Cards.KingOfSpades,
            Cards.KingOfHearts,
            Cards.AceOfSpades,
            Cards.QueenOfSpades,
            Cards.JackOfSpades
        ]);
        response.CardsDrawn.Should().Equal(Cards.AceOfSpades, Cards.QueenOfSpades, Cards.JackOfSpades);
    }

    [Fact]
    public void Draw_DrawnCardsRemovedFromDeck()
    {
        // Act
        var response = DefaultDrawer.Draw(CreateRequest(Cards.TwoOfClubs, Cards.SevenOfHearts));

        // Assert
        response.Deck.Cards.Should().Equal(Cards.JackOfSpades, Cards.TenOfSpades);
    }

    [Fact]
    public void Draw_DiscardsAddedToDiscardPile()
    {
        // Arrange
        var request = CreateRequest(Cards.TwoOfClubs) with
        {
            Discards = new[] { Cards.ThreeOfClubs }.ToDiscards()
        };

        // Act
        var response = DefaultDrawer.Draw(request);

        // Assert
        response.Discards.ToCards().Should().Equal(Cards.ThreeOfClubs, Cards.TwoOfClubs);
        response.Discards.Should().OnlyContain(c => c.CardLocation == CardLocation.DiscardPile);
    }

    [Fact]
    public void Draw_NothingChanges_NoCardsDiscarded()
    {
        // Act
        var response = DefaultDrawer.Draw(CreateRequest());

        // Assert
        response.Participant.CardsInPlay.Should().Equal(_participant.CardsInPlay);
        response.Deck.Cards.Should().Equal(_deck.Cards);
        response.Discards.Should().BeEmpty();
        response.CardsDrawn.Should().BeEmpty();
    }

    [Fact]
    public void Draw_Throws_CardNotInHand()
    {
        // Act
        var act = () => DefaultDrawer.Draw(CreateRequest(Cards.AceOfHearts));

        // Assert
        act.Should().Throw<InvalidOperationException>();
    }

    [Fact]
    public void Draw_Throws_DeckTooSmall()
    {
        // Arrange
        var request = CreateRequest(Cards.TwoOfClubs, Cards.SevenOfHearts) with
        {
            Deck = Decks.Empty with { Cards = [Cards.AceOfSpades] }
        };

        // Act
        var act = () => DefaultDrawer.Draw(request);

        // Assert
        act.Should().Throw<InvalidOperationException>();
    }
}
