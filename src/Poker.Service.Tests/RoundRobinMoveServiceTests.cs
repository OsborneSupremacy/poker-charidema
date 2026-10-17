using Poker.Domain.Classic;

namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class RoundRobinMoveServiceTests
{
    private readonly Participant _participantOne = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "One",
        Stack = 100
    };

    private readonly Participant _participantTwo = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "Two",
        Stack = 100
    };

    private readonly Participant _participantThree = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "Three",
        Stack = 100
    };

    private PhaseRequest CreateRequest(params Participant[] participants) =>
        new()
        {
            Participants = participants,
            Phase = FiveCardDraw.GetVariant().Phases
                .First(p => p.PhaseType == PhaseType.Ante),
            Deck = Decks.Empty with { Cards = [Cards.TwoOfClubs, Cards.ThreeOfClubs, Cards.FourOfClubs] },
            Ante = 0,
            CommunityCards = [],
            Discards = [],
            StartingParticipant = participants.First(),
            Pot = 0,
            GameOver = false
        };

    /// <summary>
    /// Each move takes the top card off the deck.
    /// </summary>
    private static MoveResponse TakeTopCard(MoveRequest request) =>
        new()
        {
            ParticipantInTurn = request.ParticipantInTurn,
            Deck = request.PhaseRequest.Deck with { Cards = request.PhaseRequest.Deck.Cards.Skip(1).ToList() },
            Pot = request.Pot
        };

    [Fact]
    public async Task ExecuteAsync_EachMoveReceivesDeckFromPreviousMove()
    {
        // Arrange
        TestMoveService moveService = new(TakeTopCard);
        RoundRobinMoveService service = new(new TestUserInterfaceService(), moveService);

        // Act
        await service.ExecuteAsync(CreateRequest(_participantOne, _participantTwo, _participantThree));

        // Assert
        moveService.Requests
            .Select(r => r.PhaseRequest.Deck.Cards.Count)
            .Should()
            .Equal(3, 2, 1);
    }

    [Fact]
    public async Task ExecuteAsync_ResponseDeckReflectsAllMoves()
    {
        // Arrange
        TestMoveService moveService = new(TakeTopCard);
        RoundRobinMoveService service = new(new TestUserInterfaceService(), moveService);

        // Act
        var response = await service.ExecuteAsync(CreateRequest(_participantOne, _participantTwo, _participantThree));

        // Assert
        response.Deck.Cards.Should().BeEmpty();
    }

    [Fact]
    public async Task ExecuteAsync_FoldedParticipantDoesNotMove()
    {
        // Arrange
        TestMoveService moveService = new(TakeTopCard);
        RoundRobinMoveService service = new(new TestUserInterfaceService(), moveService);

        var folded = _participantTwo with { Folded = true };

        // Act
        await service.ExecuteAsync(CreateRequest(_participantOne, folded, _participantThree));

        // Assert
        moveService.Requests
            .Select(r => r.ParticipantInTurn.Id)
            .Should()
            .Equal(_participantOne.Id, _participantThree.Id);
    }

    [Fact]
    public async Task ExecuteAsync_FoldedParticipantIsReturnedUnchanged()
    {
        // Arrange
        TestMoveService moveService = new(TakeTopCard);
        RoundRobinMoveService service = new(new TestUserInterfaceService(), moveService);

        var folded = _participantTwo with { Folded = true };

        // Act
        var response = await service.ExecuteAsync(CreateRequest(_participantOne, folded, _participantThree));

        // Assert
        response.Participants.Should().ContainSingle(p => p.Id == folded.Id)
            .Which.Should().Be(folded);
    }
}
