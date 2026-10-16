namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class BettingIntervalOptionsServiceTests
{
    private readonly BettingIntervalOptionsService _bettingIntervalOptionsService = new();

    [Fact]
    public async Task ExecuteAsync_MaximumBetIsWhatPoorestPlayerHasLeftAfterCalling_BetInProgress()
    {
        // Arrange
        // Everyone anted $10 (their stake), then One bet $20 in this interval.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 70, Stake = 30 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 90, Stake = 10 };
        var three = Participants.Empty with { Id = Guid.NewGuid(), Stack = 25, Stake = 10 };

        BettingIntervalOptionsRequest request = new()
        {
            ParticipantInTurnId = two.Id,
            CurrentBet = new Bet
            {
                Amount = 20,
                InitiatingPlayerId = one.Id,
                CheckedPlayerIds = [],
                PlayerContributions = new Dictionary<Guid, int>
                {
                    [one.Id] = 20,
                    [two.Id] = 0,
                    [three.Id] = 0
                }
            },
            APlayerIsAllIn = false,
            ActiveParticipants = [one, two, three]
        };

        // Act
        var response = await _bettingIntervalOptionsService.ExecuteAsync(request);

        // Assert
        // Three needs $20 to call, leaving $5.
        response.MaximumBet.Should().Be(5);
    }

    [Fact]
    public async Task ExecuteAsync_MaximumBetIsSmallestStack_NoBet()
    {
        // Arrange
        // Everyone anted $10 (their stake), and no one has bet in this interval.
        var one = Participants.Empty with { Id = Guid.NewGuid(), Stack = 90, Stake = 10 };
        var two = Participants.Empty with { Id = Guid.NewGuid(), Stack = 40, Stake = 10 };

        BettingIntervalOptionsRequest request = new()
        {
            ParticipantInTurnId = one.Id,
            CurrentBet = Bets.Empty,
            APlayerIsAllIn = false,
            ActiveParticipants = [one, two]
        };

        // Act
        var response = await _bettingIntervalOptionsService.ExecuteAsync(request);

        // Assert
        response.MaximumBet.Should().Be(40);
    }
}
