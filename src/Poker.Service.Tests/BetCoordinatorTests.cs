using Poker.Domain.Classic.Hands;

namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class BetCoordinatorTests
{
    private readonly Participant _participantOne = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "One",
        Stack = 100,
        Automaton = true
    };

    private readonly Participant _participantTwo = Participants.Empty with
    {
        Id = Guid.NewGuid(),
        Name = "Two",
        Stack = 100,
        Automaton = true
    };

    private readonly TestLeadPlayerService _leadPlayerService = new(new EvaluateLeaderPlayerResponse
    {
        LeadParticipants = [],
        ParticipantHands = [],
        LeadingHand = Pairs.Twos
    });

    private PhaseRequest CreateRequest() =>
        new()
        {
            Participants = [_participantOne, _participantTwo],
            Phase = FiveCardDraw.GetVariant().Phases
                .First(p => p.PhaseType == PhaseType.BettingInterval),
            Deck = Decks.Empty,
            Ante = 0,
            CommunityCards = [],
            StartingParticipant = _participantOne,
            Pot = 0,
            GameOver = false
        };

    [Fact]
    public async Task ExecuteAsync_APlayerIsAllInPassedToNextBettor_PreviousBettorWentAllIn()
    {
        // Arrange
        TestBettingIntervalService bettingIntervalService = new(
            request => BettingIntervalResponses.Empty with
            {
                ParticipantInTurn = request.ParticipantInTurn with { Stack = 0 },
                AllIn = true,
                CloseBetting = false
            },
            request => BettingIntervalResponses.Empty with
            {
                ParticipantInTurn = request.ParticipantInTurn,
                AllIn = request.APlayerIsAllIn,
                CloseBetting = true
            }
        );

        BetCoordinator betCoordinator = new(
            new TestUserInterfaceService(),
            bettingIntervalService,
            _leadPlayerService
        );

        // Act
        await betCoordinator.ExecuteAsync(CreateRequest());

        // Assert
        bettingIntervalService.Requests
            .Select(r => r.APlayerIsAllIn)
            .Should()
            .Equal(false, true);
    }

    [Fact]
    public async Task ExecuteAsync_APlayerIsAllInNotPassedToNextBettor_NoBettorWentAllIn()
    {
        // Arrange
        TestBettingIntervalService bettingIntervalService = new(
            request => BettingIntervalResponses.Empty with
            {
                ParticipantInTurn = request.ParticipantInTurn,
                AllIn = false,
                CloseBetting = false
            },
            request => BettingIntervalResponses.Empty with
            {
                ParticipantInTurn = request.ParticipantInTurn,
                AllIn = request.APlayerIsAllIn,
                CloseBetting = true
            }
        );

        BetCoordinator betCoordinator = new(
            new TestUserInterfaceService(),
            bettingIntervalService,
            _leadPlayerService
        );

        // Act
        await betCoordinator.ExecuteAsync(CreateRequest());

        // Assert
        bettingIntervalService.Requests
            .Select(r => r.APlayerIsAllIn)
            .Should()
            .Equal(false, false);
    }

    [Fact]
    public async Task ExecuteAsync_BettingSkipped_OnlyOnePlayerHasChips()
    {
        // Arrange
        // Two went all-in in an earlier betting interval.
        var two = _participantTwo with { Stack = 0 };

        var request = CreateRequest() with
        {
            Participants = [_participantOne, two],
            Pot = 50
        };

        TestBettingIntervalService bettingIntervalService = new();

        BetCoordinator betCoordinator = new(
            new TestUserInterfaceService(),
            bettingIntervalService,
            _leadPlayerService
        );

        // Act
        var response = await betCoordinator.ExecuteAsync(request);

        // Assert
        bettingIntervalService.Requests.Should().BeEmpty();
        response.Participants.Should().Equal(_participantOne, two);
        response.Pot.Should().Be(50);
        response.GameOver.Should().BeFalse();
        response.Winners.Should().BeEmpty();
    }

    [Fact]
    public async Task ExecuteAsync_BettingSkipped_OnlyOtherPlayerWithChipsFolded()
    {
        // Arrange
        var two = _participantTwo with { Stack = 0 };
        var three = Participants.Empty with { Id = Guid.NewGuid(), Name = "Three", Stack = 100, Folded = true };

        var request = CreateRequest() with
        {
            Participants = [_participantOne, two, three]
        };

        TestBettingIntervalService bettingIntervalService = new();

        BetCoordinator betCoordinator = new(
            new TestUserInterfaceService(),
            bettingIntervalService,
            _leadPlayerService
        );

        // Act
        var response = await betCoordinator.ExecuteAsync(request);

        // Assert
        bettingIntervalService.Requests.Should().BeEmpty();
        response.GameOver.Should().BeFalse();
    }
}
