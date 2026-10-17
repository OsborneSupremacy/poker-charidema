namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class BettingIntervalServiceTests
{
    private static BettingIntervalService CreateService(BettingIntervalActionType actionType, int amount) =>
        CreateService(
            actionType,
            amount,
            new TestBettingIntervalActionSelectionService(new BettingIntervalActionSelectionResponse
            {
                BettingIntervalActionType = BettingIntervalActionType.Empty,
                Amount = 0
            })
        );

    private static BettingIntervalService CreateService(
        BettingIntervalActionType actionType,
        int amount,
        TestBettingIntervalActionSelectionService userActionSelectionService
        ) =>
        new(
            new TestBettingIntervalOptionsService(new BettingIntervalOptionsResponse
            {
                RequiredAmountToCall = 0,
                MaximumBet = 100,
                AvailableBettingIntervalActions =
                [
                    new() { BettingIntervalActionType = actionType, Weight = 100 }
                ]
            }),
            userActionSelectionService,
            new AutomatonBettingIntervalActionSelectionService(new TestRandomService(amount))
        );

    [Fact]
    public async Task ExecuteAsync_RaiserPaysToCallPlusRaise_RaiserHasNotContributed()
    {
        // Arrange
        // Both anted $10 (their stake), then One bet $10 in this interval.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 80, Stake = 20 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 90, Stake = 10 };

        BettingIntervalRequest request = new()
        {
            CurrentBet = new Bet
            {
                Amount = 10,
                InitiatingPlayerId = one.Id,
                CheckedPlayerIds = [],
                PlayerContributions = new Dictionary<Guid, int>
                {
                    [one.Id] = 10,
                    [two.Id] = 0
                }
            },
            Pot = 30,
            APlayerIsAllIn = false,
            ParticipantInTurn = two,
            ActiveParticipants = [one, two],
            EmitObservation = _ => { }
        };

        // Act
        // Two raises $5, which means paying $10 to call and $5 more.
        var response = await CreateService(BettingIntervalActionType.Raise, 5).ExecuteAsync(request);

        // Assert
        response.CurrentBet.Amount.Should().Be(15);
        response.CurrentBet.PlayerContributions[two.Id].Should().Be(15);
        response.ParticipantInTurn.Stack.Should().Be(75);
        response.ParticipantInTurn.Stake.Should().Be(25);
        response.Pot.Should().Be(45);
    }

    [Fact]
    public async Task ExecuteAsync_RaiserPaysDifferencePlusRaise_RaiserHasAlreadyContributed()
    {
        // Arrange
        // Both anted $10, Two bet $10, then One raised to $25 in this interval.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 65, Stake = 35 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 80, Stake = 20 };

        BettingIntervalRequest request = new()
        {
            CurrentBet = new Bet
            {
                Amount = 25,
                InitiatingPlayerId = one.Id,
                CheckedPlayerIds = [],
                PlayerContributions = new Dictionary<Guid, int>
                {
                    [one.Id] = 25,
                    [two.Id] = 10
                }
            },
            Pot = 55,
            APlayerIsAllIn = false,
            ParticipantInTurn = two,
            ActiveParticipants = [one, two],
            EmitObservation = _ => { }
        };

        // Act
        // Two re-raises $5, which means paying $15 to call and $5 more.
        var response = await CreateService(BettingIntervalActionType.Raise, 5).ExecuteAsync(request);

        // Assert
        response.CurrentBet.Amount.Should().Be(30);
        response.CurrentBet.PlayerContributions[two.Id].Should().Be(30);
        response.ParticipantInTurn.Stack.Should().Be(60);
        response.ParticipantInTurn.Stake.Should().Be(40);
        response.Pot.Should().Be(75);
    }

    private static BettingIntervalRequest CreateFoldRequest(
        Participant participantInTurn,
        IReadOnlyList<Participant> activeParticipants,
        IReadOnlyDictionary<Guid, int> playerContributions
    ) =>
        new()
        {
            CurrentBet = new Bet
            {
                Amount = 10,
                InitiatingPlayerId = activeParticipants[0].Id,
                CheckedPlayerIds = [],
                PlayerContributions = playerContributions
            },
            Pot = 10,
            APlayerIsAllIn = false,
            ParticipantInTurn = participantInTurn,
            ActiveParticipants = activeParticipants,
            EmitObservation = _ => { }
        };

    [Fact]
    public async Task ExecuteAsync_BettingClosed_FoldLeavesOneParticipant()
    {
        // Arrange
        // One bet $10, and Two folds.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 90 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100 };

        var request = CreateFoldRequest(
            two,
            [one, two],
            new Dictionary<Guid, int> { [one.Id] = 10, [two.Id] = 0 }
        );

        // Act
        var response = await CreateService(BettingIntervalActionType.Fold, 0).ExecuteAsync(request);

        // Assert
        response.ParticipantInTurn.Folded.Should().BeTrue();
        response.CloseBetting.Should().BeTrue();
    }

    [Fact]
    public async Task ExecuteAsync_BettingClosed_FoldAfterRemainingParticipantsCalled()
    {
        // Arrange
        // One bet $10, Two called, and Three folds.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 90 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 90 };
        var three = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100 };

        var request = CreateFoldRequest(
            three,
            [one, two, three],
            new Dictionary<Guid, int> { [one.Id] = 10, [two.Id] = 10, [three.Id] = 0 }
        );

        // Act
        var response = await CreateService(BettingIntervalActionType.Fold, 0).ExecuteAsync(request);

        // Assert
        response.CloseBetting.Should().BeTrue();
    }

    [Fact]
    public async Task ExecuteAsync_BettingOpen_FoldBeforeRemainingParticipantCalled()
    {
        // Arrange
        // One bet $10, and Two folds. Three has not acted yet.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 90 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100 };
        var three = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100 };

        var request = CreateFoldRequest(
            two,
            [one, two, three],
            new Dictionary<Guid, int> { [one.Id] = 10, [two.Id] = 0, [three.Id] = 0 }
        );

        // Act
        var response = await CreateService(BettingIntervalActionType.Fold, 0).ExecuteAsync(request);

        // Assert
        response.CloseBetting.Should().BeFalse();
    }

    [Fact]
    public async Task ExecuteAsync_UserSelectsAction_ParticipantIsNotAnAutomaton()
    {
        // Arrange
        // Nobody has bet yet. The automaton would check, but the user bets $25.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100 };
        var user = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100, Automaton = false };

        var userActionSelectionService = new TestBettingIntervalActionSelectionService(
            new BettingIntervalActionSelectionResponse
            {
                BettingIntervalActionType = BettingIntervalActionType.Bet,
                Amount = 25
            });

        BettingIntervalRequest request = new()
        {
            CurrentBet = Bets.Empty,
            Pot = 20,
            APlayerIsAllIn = false,
            ParticipantInTurn = user,
            ActiveParticipants = [one, user],
            EmitObservation = _ => { }
        };

        // Act
        var response = await CreateService(BettingIntervalActionType.Check, 0, userActionSelectionService)
            .ExecuteAsync(request);

        // Assert
        userActionSelectionService.Requests.Should().ContainSingle();
        response.CurrentBet.Amount.Should().Be(25);
        response.ParticipantInTurn.Stack.Should().Be(75);
        response.Pot.Should().Be(45);
    }

    [Fact]
    public async Task ExecuteAsync_UserNotAsked_ParticipantIsAnAutomaton()
    {
        // Arrange
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100 };

        var userActionSelectionService = new TestBettingIntervalActionSelectionService(
            new BettingIntervalActionSelectionResponse
            {
                BettingIntervalActionType = BettingIntervalActionType.Bet,
                Amount = 25
            });

        BettingIntervalRequest request = new()
        {
            CurrentBet = Bets.Empty,
            Pot = 20,
            APlayerIsAllIn = false,
            ParticipantInTurn = two,
            ActiveParticipants = [one, two],
            EmitObservation = _ => { }
        };

        // Act
        var response = await CreateService(BettingIntervalActionType.Check, 0, userActionSelectionService)
            .ExecuteAsync(request);

        // Assert
        userActionSelectionService.Requests.Should().BeEmpty();
        response.CurrentBet.CheckedPlayerIds.Should().ContainSingle().Which.Should().Be(two.Id);
    }

    [Fact]
    public async Task ExecuteAsync_CallerGoesAllInForLess_CallerCannotAffordFullCall()
    {
        // Arrange
        // One bet $30, but Two only has $20 left.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 60, Stake = 40 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 20, Stake = 10 };

        BettingIntervalRequest request = new()
        {
            CurrentBet = new Bet
            {
                Amount = 30,
                InitiatingPlayerId = one.Id,
                CheckedPlayerIds = [],
                PlayerContributions = new Dictionary<Guid, int>
                {
                    [one.Id] = 30,
                    [two.Id] = 0
                }
            },
            Pot = 50,
            APlayerIsAllIn = false,
            ParticipantInTurn = two,
            ActiveParticipants = [one, two],
            EmitObservation = _ => { }
        };

        // Act
        var response = await CreateService(BettingIntervalActionType.Call, 0).ExecuteAsync(request);

        // Assert
        response.ParticipantInTurn.Stack.Should().Be(0);
        response.ParticipantInTurn.Stake.Should().Be(30);
        response.CurrentBet.PlayerContributions[two.Id].Should().Be(20);
        response.Pot.Should().Be(70);
        response.AllIn.Should().BeTrue();
        response.CloseBetting.Should().BeTrue();
    }

    [Fact]
    public async Task ExecuteAsync_BettingClosed_FoldAfterRemainingParticipantWentAllInForLess()
    {
        // Arrange
        // One bet $10, Two went all-in for $5, and Three folds.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 90 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 0 };
        var three = Participants.Empty with { Id = Guid.NewGuid(), Stack = 100 };

        var request = CreateFoldRequest(
            three,
            [one, two, three],
            new Dictionary<Guid, int> { [one.Id] = 10, [two.Id] = 5, [three.Id] = 0 }
        );

        // Act
        var response = await CreateService(BettingIntervalActionType.Fold, 0).ExecuteAsync(request);

        // Assert
        response.CloseBetting.Should().BeTrue();
    }
}
