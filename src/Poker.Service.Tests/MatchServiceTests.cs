using Poker.Domain.Extensions;

namespace Poker.Service.Tests;

[ExcludeFromCodeCoverage]
public class MatchServiceTests
{
    private readonly Player _playerOne = Players.Empty with { Id = Guid.NewGuid(), Name = "One", Stack = 100 };

    private readonly Player _playerTwo = Players.Empty with { Id = Guid.NewGuid(), Name = "Two", Stack = 100 };

    private MatchRequest CreateRequest(int fixedNumberOfGames) =>
        new()
        {
            Match = MatchResponses.Empty.Match with
            {
                FixedNumberOfGames = fixedNumberOfGames,
                FixedVariant = FiveCardDraw.GetVariant(),
                Players = [_playerOne, _playerTwo],
                TotalMoneyInPlay = 200
            },
            InitialButton = _playerOne
        };

    /// <summary>
    /// A game that ends with the participants' stacks as given.
    /// </summary>
    private static Func<CoordinateGameRequest, CoordinateGameResponse> GameEndingWith(params Player[] playersAfterGame) =>
        request => new CoordinateGameResponse
        {
            GameResponse = new GameResponse
            {
                CompletedGame = CompletedGames.Empty with
                {
                    GameNumber = request.GameHistory.Count + 1,
                    Variant = request.Variant
                },
                Participants = playersAfterGame
                    .Select(p => p.ToParticipant() with { Busted = p.Stack <= 0 })
                    .ToList()
            }
        };

    [Fact]
    public async Task PlayAsync_MatchEndsWithoutPrompt_PlayingIndefinitelyAndOnlyOnePlayerRemains()
    {
        // Arrange
        TestGameCoordinator gameCoordinator = new(
            GameEndingWith(_playerOne with { Stack = 200 }, _playerTwo with { Stack = 0 })
        );

        TestGamePreferencesService gamePreferencesService = new(true);

        MatchService matchService = new(
            new TestMatchPreferencesService(confirmStart: true, playAgain: false),
            gamePreferencesService,
            new TestUserInterfaceService(),
            gameCoordinator
        );

        // Act
        var response = await matchService.PlayAsync(CreateRequest(fixedNumberOfGames: 0));

        // Assert
        gameCoordinator.Requests.Should().HaveCount(1);
        gamePreferencesService.PlayAgainPromptCount.Should().Be(0);
        response.Match.Players.NotBusted().Should().ContainSingle(p => p.Id == _playerOne.Id);
    }

    [Fact]
    public async Task PlayAsync_GamesPlayedUntilUserStops_PlayingIndefinitely()
    {
        // Arrange
        TestGameCoordinator gameCoordinator = new(
            GameEndingWith(_playerOne with { Stack = 110 }, _playerTwo with { Stack = 90 }),
            GameEndingWith(_playerOne with { Stack = 100 }, _playerTwo with { Stack = 100 })
        );

        TestGamePreferencesService gamePreferencesService = new(true, false);

        MatchService matchService = new(
            new TestMatchPreferencesService(confirmStart: true, playAgain: false),
            gamePreferencesService,
            new TestUserInterfaceService(),
            gameCoordinator
        );

        // Act
        var response = await matchService.PlayAsync(CreateRequest(fixedNumberOfGames: 0));

        // Assert
        gameCoordinator.Requests.Should().HaveCount(2);
        gamePreferencesService.PlayAgainPromptCount.Should().Be(2);
        response.Match.GameHistory.Should().HaveCount(2);
    }

    [Fact]
    public async Task PlayAsync_FixedNumberOfGamesPlayed_FixedNumberOfGames()
    {
        // Arrange
        TestGameCoordinator gameCoordinator = new(
            GameEndingWith(_playerOne with { Stack = 110 }, _playerTwo with { Stack = 90 }),
            GameEndingWith(_playerOne with { Stack = 100 }, _playerTwo with { Stack = 100 })
        );

        MatchService matchService = new(
            new TestMatchPreferencesService(confirmStart: true, playAgain: false),
            new TestGamePreferencesService(),
            new TestUserInterfaceService(),
            gameCoordinator
        );

        // Act
        var response = await matchService.PlayAsync(CreateRequest(fixedNumberOfGames: 2));

        // Assert
        gameCoordinator.Requests.Should().HaveCount(2);
        response.Match.GameHistory.Should().HaveCount(2);
    }

    [Fact]
    public async Task PlayAsync_MatchEndsEarly_FixedNumberOfGamesAndOnlyOnePlayerRemains()
    {
        // Arrange
        TestGameCoordinator gameCoordinator = new(
            GameEndingWith(_playerOne with { Stack = 200 }, _playerTwo with { Stack = 0 })
        );

        MatchService matchService = new(
            new TestMatchPreferencesService(confirmStart: true, playAgain: false),
            new TestGamePreferencesService(),
            new TestUserInterfaceService(),
            gameCoordinator
        );

        // Act
        var response = await matchService.PlayAsync(CreateRequest(fixedNumberOfGames: 5));

        // Assert
        gameCoordinator.Requests.Should().HaveCount(1);
        response.Match.GameHistory.Should().HaveCount(1);
    }
}
