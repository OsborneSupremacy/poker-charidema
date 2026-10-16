namespace Poker.Utility.Tests;

[ExcludeFromCodeCoverage]
public class EnumerableExtensionsTests
{
    [Fact]
    public void ToQueue_PreservesOrder_MultipleItems()
    {
        // Arrange
        List<int> input = [3, 1, 2];

        // Act
        var result = input.ToQueue();

        // Assert
        result.Should().Equal(3, 1, 2);
        result.Dequeue().Should().Be(3);
    }

    [Fact]
    public void ToQueue_EmptyQueue_EmptyInput()
    {
        // Arrange
        List<int> input = [];

        // Act
        var result = input.ToQueue();

        // Assert
        result.Should().BeEmpty();
    }

    [Fact]
    public void ToQueue_NewQueue_InputAlreadyQueue()
    {
        // Arrange
        Queue<int> input = new([1, 2]);

        // Act
        var result = input.ToQueue();
        result.Dequeue();

        // Assert
        result.Should().NotBeSameAs(input);
        input.Should().Equal(1, 2);
    }
}
