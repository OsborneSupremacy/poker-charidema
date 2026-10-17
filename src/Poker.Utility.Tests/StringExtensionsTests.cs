namespace Poker.Utility.Tests;

[ExcludeFromCodeCoverage]
public class StringExtensionsTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("\t\r\n")]
    public void IsNullOrWhiteSpace_True_NullEmptyOrWhiteSpace(string? input)
    {
        // Act
        var result = input.IsNullOrWhiteSpace();

        // Assert
        result.Should().BeTrue();
    }

    [Theory]
    [InlineData("a")]
    [InlineData(" a ")]
    public void IsNullOrWhiteSpace_False_HasNonWhiteSpace(string input)
    {
        // Act
        var result = input.IsNullOrWhiteSpace();

        // Assert
        result.Should().BeFalse();
    }

    [Theory]
    [InlineData("ben", "Ben")]
    [InlineData("ben osborne", "Ben Osborne")]
    [InlineData("bEN oSBORNE", "Ben Osborne")]
    public void ToTitleCase_ExpectedResult_HasValue(string input, string expectedResult)
    {
        // Act
        var result = input.ToTitleCase();

        // Assert
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("  ")]
    public void ToTitleCase_EmptyString_NullEmptyOrWhiteSpace(string? input)
    {
        // Act
        var result = input.ToTitleCase();

        // Assert
        result.Should().BeEmpty();
    }

    [Theory]
    [InlineData("Ace", "an Ace")]
    [InlineData("Eight", "an Eight")]
    [InlineData("King", "a King")]
    [InlineData("Two", "a Two")]
    public void WithIndefiniteArticle_ArticleMatchesFirstLetter(string input, string expected)
    {
        // Act
        var result = input.WithIndefiniteArticle();

        // Assert
        result.Should().Be(expected);
    }
}
