namespace Poker.Utility.Tests;

[ExcludeFromCodeCoverage]
public class IntExtensionsTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(int.MaxValue)]
    [InlineData(int.MinValue)]
    public void HasValue_True_NonZero(int input)
    {
        // Act
        var result = input.HasValue();

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void HasValue_False_Zero()
    {
        // Act
        var result = 0.HasValue();

        // Assert
        result.Should().BeFalse();
    }
}
