using FluentAssertions;
using Poker.Library.Interface;

namespace Poker.Utility.Tests;

public class PlayerExtensionsTests
{
    [Fact]
    public void NextPlayer_ShouldReturnFirstPlayer_WhenCurrentPlayerIsLastInList()
    {
        // arrange
        List<IPlayer> players = new()
        {
            new Player { Id = Guid.NewGuid(), Name = "Alice", Stack = 100, BeginningStack = 100, Automaton = true, Busted = false },
            new Player { Id = Guid.NewGuid(), Name = "Bob", Stack = 50, BeginningStack = 100, Automaton = true, Busted = false },
            new Player { Id = Guid.NewGuid(), Name = "Charlie", Stack = 25, BeginningStack = 100, Automaton = true, Busted = false }
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
        List<IPlayer> players = new()
        {
            new Player { Id = Guid.NewGuid(), Name = "Alice", Stack = 100, BeginningStack = 100, Automaton = true, Busted = false },
            new Player { Id = Guid.NewGuid(), Name = "Bob", Stack = 50, BeginningStack = 100, Automaton = true, Busted = false },
            new Player { Id = Guid.NewGuid(), Name = "Charlie", Stack = 25, BeginningStack = 100, Automaton = true, Busted = false }
        };

        var currentPlayer = players[1];

        // act
        var nextPlayer = players.NextPlayer(currentPlayer);

        // assert
        nextPlayer.Should().Be(players[2]);
    }
}
