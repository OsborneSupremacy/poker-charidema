using Poker.Domain.Classic;
using Poker.Domain.Extensions;
using Poker.Domain.Functions;

namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class DrawCoordinatorTests
{
    private readonly Participant _participantOne = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "One",
        Automaton = true,
        CardsInPlay = new[]
        {
            Cards.TwoOfClubs, Cards.ThreeOfClubs, Cards.FourOfClubs, Cards.SixOfClubs, Cards.SevenOfHearts
        }.DealToPlayer(CardOrientation.FaceDown)
    };

    private readonly Participant _participantTwo = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "Two",
        Automaton = true,
        CardsInPlay = new[]
        {
            Cards.TwoOfHearts, Cards.ThreeOfHearts, Cards.FourOfHearts, Cards.SixOfHearts, Cards.EightOfClubs
        }.DealToPlayer(CardOrientation.FaceDown)
    };

    private readonly Participant _participantThree = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "Three",
        Automaton = false,
        CardsInPlay = new[]
        {
            Cards.TwoOfSpades, Cards.ThreeOfSpades, Cards.FourOfSpades, Cards.SixOfSpades, Cards.EightOfDiamonds
        }.DealToPlayer(CardOrientation.FaceDown)
    };

    private readonly Phase _drawPhase = FiveCardDraw.GetVariant().Phases
        .Single(p => p.PhaseType == PhaseType.Draw);

    private PhaseRequest CreateRequest(params Participant[] participants) =>
        new()
        {
            Participants = participants,
            Phase = _drawPhase,
            Deck = Decks.Empty with
            {
                Cards = [Cards.AceOfSpades, Cards.KingOfSpades, Cards.QueenOfSpades, Cards.JackOfSpades]
            },
            Ante = 0,
            CommunityCards = [],
            Discards = [],
            StartingParticipant = participants.First(),
            Pot = 0,
            GameOver = false
        };

    /// <summary>
    /// Discards the last card in the participant's hand.
    /// </summary>
    private static IReadOnlyList<Card> DiscardLastCard(DiscardSelectionRequest request) =>
        [request.Participant.CardsInPlay.Last().Card];

    private static DrawCoordinator CreateCoordinator(
        TestDiscardSelectionService userService,
        TestDiscardSelectionService automatonService
        ) =>
        new(
            new TestUserInterfaceService(),
            userService,
            automatonService,
            new DealerService(
                new TestUserInterfaceService(),
                new TestRandomFactory(1),
                FisherYatesShuffleAlgorithm.Shuffle,
                DefaultDealer.Deal
            ),
            DefaultDrawer.Draw
        );

    [Fact]
    public async Task ExecuteAsync_ParticipantsDrawInTurnOrder_FromStartingParticipant()
    {
        // Arrange
        TestDiscardSelectionService selectionService = new(DiscardLastCard);
        var coordinator = CreateCoordinator(selectionService, selectionService);

        var request = CreateRequest(_participantOne, _participantTwo, _participantThree) with
        {
            StartingParticipant = _participantTwo
        };

        // Act
        await coordinator.ExecuteAsync(request);

        // Assert
        selectionService.Requests
            .Select(r => r.Participant.Id)
            .Should()
            .Equal(_participantTwo.Id, _participantThree.Id, _participantOne.Id);
    }

    [Fact]
    public async Task ExecuteAsync_FoldedParticipantDoesNotDraw()
    {
        // Arrange
        TestDiscardSelectionService selectionService = new(DiscardLastCard);
        var coordinator = CreateCoordinator(selectionService, selectionService);

        var folded = _participantTwo with { Folded = true };

        // Act
        var response = await coordinator.ExecuteAsync(CreateRequest(_participantOne, folded, _participantThree));

        // Assert
        selectionService.Requests
            .Select(r => r.Participant.Id)
            .Should()
            .Equal(_participantOne.Id, _participantThree.Id);
        response.Participants.Single(p => p.Id == folded.Id).Should().Be(folded);
    }

    [Fact]
    public async Task ExecuteAsync_HumanUsesUserService_AutomatonUsesAutomatonService()
    {
        // Arrange
        TestDiscardSelectionService userService = new(DiscardLastCard);
        TestDiscardSelectionService automatonService = new(DiscardLastCard);
        var coordinator = CreateCoordinator(userService, automatonService);

        // Act
        await coordinator.ExecuteAsync(CreateRequest(_participantOne, _participantThree));

        // Assert
        userService.Requests.Select(r => r.Participant.Id).Should().Equal(_participantThree.Id);
        automatonService.Requests.Select(r => r.Participant.Id).Should().Equal(_participantOne.Id);
    }

    [Fact]
    public async Task ExecuteAsync_EachParticipantDrawsFromTopOfRemainingDeck()
    {
        // Arrange
        TestDiscardSelectionService selectionService = new(DiscardLastCard);
        var coordinator = CreateCoordinator(selectionService, selectionService);

        // Act
        var response = await coordinator.ExecuteAsync(CreateRequest(_participantOne, _participantTwo));

        // Assert
        response.Participants[0].CardsInPlay.ToCards().Should().Contain(Cards.AceOfSpades);
        response.Participants[1].CardsInPlay.ToCards().Should().Contain(Cards.KingOfSpades);
        response.Deck.Cards.Should().Equal(Cards.QueenOfSpades, Cards.JackOfSpades);
    }

    [Fact]
    public async Task ExecuteAsync_DiscardsAccumulate()
    {
        // Arrange
        TestDiscardSelectionService selectionService = new(DiscardLastCard);
        var coordinator = CreateCoordinator(selectionService, selectionService);

        // Act
        var response = await coordinator.ExecuteAsync(CreateRequest(_participantOne, _participantTwo));

        // Assert
        response.Discards.ToCards().Should().Equal(Cards.SevenOfHearts, Cards.EightOfClubs);
    }

    [Fact]
    public async Task ExecuteAsync_DiscardsShuffledIntoDeck_DeckRunsOut()
    {
        // Arrange
        TestDiscardSelectionService selectionService = new(request =>
            request.Participant.CardsInPlay.ToCards().Take(3).ToList());
        var coordinator = CreateCoordinator(selectionService, selectionService);

        // the deck has four cards, so the second participant's draw of three needs the first participant's discards
        // Act
        var response = await coordinator.ExecuteAsync(CreateRequest(_participantOne, _participantTwo));

        // Assert
        response.Participants.Should().OnlyContain(p => p.CardsInPlay.Count == 5);
        response.Participants[1].CardsInPlay.ToCards().Should().Contain(Cards.JackOfSpades);
        response.Discards.ToCards().Should().BeEquivalentTo(
            [Cards.TwoOfHearts, Cards.ThreeOfHearts, Cards.FourOfHearts]);
        response.Deck.Cards.Should().HaveCount(1);
    }

    [Fact]
    public async Task ExecuteAsync_Throws_DrawExceedsMaximum()
    {
        // Arrange
        TestDiscardSelectionService selectionService = new(request =>
            request.Participant.CardsInPlay.ToCards().Take(4).ToList());
        var coordinator = CreateCoordinator(selectionService, selectionService);

        // Act
        var act = () => coordinator.ExecuteAsync(CreateRequest(_participantOne));

        // Assert
        await act.Should().ThrowAsync<InvalidOperationException>();
    }

    [Fact]
    public async Task ExecuteAsync_NoDraws_GameOver()
    {
        // Arrange
        TestDiscardSelectionService selectionService = new(DiscardLastCard);
        var coordinator = CreateCoordinator(selectionService, selectionService);

        // Act
        var response = await coordinator.ExecuteAsync(
            CreateRequest(_participantOne, _participantTwo) with { GameOver = true });

        // Assert
        selectionService.Requests.Should().BeEmpty();
        response.GameOver.Should().BeTrue();
    }
}
