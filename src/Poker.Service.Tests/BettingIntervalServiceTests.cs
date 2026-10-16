namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class BettingIntervalServiceTests
{
    private static BettingIntervalService CreateRaiseService(int raiseAmount) =>
        new(
            new TestBettingIntervalOptionsService(new BettingIntervalOptionsResponse
            {
                RequiredAmountToCall = 0,
                MaximumBet = 100,
                AvailableBettingIntervalActions =
                [
                    new() { BettingIntervalActionType = BettingIntervalActionType.Raise, Weight = 100 }
                ]
            }),
            new TestRandomService(raiseAmount)
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
        var response = await CreateRaiseService(5).ExecuteAsync(request);

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
        var response = await CreateRaiseService(5).ExecuteAsync(request);

        // Assert
        response.CurrentBet.Amount.Should().Be(30);
        response.CurrentBet.PlayerContributions[two.Id].Should().Be(30);
        response.ParticipantInTurn.Stack.Should().Be(60);
        response.ParticipantInTurn.Stake.Should().Be(40);
        response.Pot.Should().Be(75);
    }
}
