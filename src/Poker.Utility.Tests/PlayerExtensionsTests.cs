using FluentAssertions;

namespace Poker.Utility.Tests;

public class PlayerExtensionsTests
{
    [Fact]
    public void NextPlayer_ShouldReturnFirstPlayer_WhenCurrentPlayerIsLastInList()
    {
        // arrange
        List<Player> players = new()
        {
            new Player { Id = Guid.NewGuid(), Name = "Alice", Stack = 100, HasFolded = false },
            new Player { Id = Guid.NewGuid(), Name = "Bob", Stack = 50, HasFolded = false },
            new Player { Id = Guid.NewGuid(), Name = "Charlie", Stack = 25, HasFolded = false }
        };

        var currentPlayer = players[2];

        // act
        var nextPlayer = players.NextPlayer(currentPlayer);

        // assert
        nextPlayer.Should().Be(players[0]);
    }

    [Fact]
    public void NextPlayer_ShouldReturnNextPlayer_WhenCurrentPlayerIsNotLastInList()
    {
        // arrange
        List<Player> players = new()
        {
            new Player { Id = Guid.NewGuid(), Name = "Alice", Stack = 100, HasFolded = false },
            new Player { Id = Guid.NewGuid(), Name = "Bob", Stack = 50, HasFolded = false },
            new Player { Id = Guid.NewGuid(), Name = "Charlie", Stack = 25, HasFolded = false }
        };

        var currentPlayer = players[1];

        // act
        var nextPlayer = players.NextPlayer(currentPlayer);

        // assert
        nextPlayer.Should().Be(players[2]);
    }
}