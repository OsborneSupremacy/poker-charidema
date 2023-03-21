using FluentAssertions;

namespace Poker.Utility.Tests;

public class PlayerExtensionsTests
{
    [Fact]
    public void NextPlayer_ShouldReturnFirstPlayer_WhenCurrentPlayerIsLastInList()
    {
        var players = new List<Player>
            {
                new Player { Id = Guid.NewGuid(), Name = "Alice", Stack = 100, HasFolded = false },
                new Player { Id = Guid.NewGuid(), Name = "Bob", Stack = 50, HasFolded = false },
                new Player { Id = Guid.NewGuid(), Name = "Charlie", Stack = 25, HasFolded = false }
            };

        var currentPlayer = players[2];
        var nextPlayer = players.NextPlayer(currentPlayer);

        nextPlayer.Should().Be(players[0]);
    }

    [Fact]
    public void NextPlayer_ShouldReturnNextPlayer_WhenCurrentPlayerIsNotLastInList()
    {
        var players = new List<Player>
            {
                new Player { Id = Guid.NewGuid(), Name = "Alice", Stack = 100, HasFolded = false },
                new Player { Id = Guid.NewGuid(), Name = "Bob", Stack = 50, HasFolded = false },
                new Player { Id = Guid.NewGuid(), Name = "Charlie", Stack = 25, HasFolded = false }
            };

        var currentPlayer = players[1];
        var nextPlayer = players.NextPlayer(currentPlayer);

        nextPlayer.Should().Be(players[2]);
    }
}