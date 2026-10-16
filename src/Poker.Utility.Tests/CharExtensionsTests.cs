namespace Poker.Utility.Tests;

[ExcludeFromCodeCoverage]
public class CharExtensionsTests
{
    [Theory]
    [InlineData('*', 1, "*")]
    [InlineData('-', 3, "---")]
    [InlineData('^', 5, "^^^^^")]
    public void Repeat_ExpectedResult_PositiveCount(char input, int count, string expectedResult)
    {
        // Act
        var result = input.Repeat(count);

        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Repeat_EmptyString_ZeroCount()
    {
        // Act
        var result = '*'.Repeat(0);

        // Assert
        result.Should().BeEmpty();
    }
}
