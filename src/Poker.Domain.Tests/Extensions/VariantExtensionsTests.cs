using Poker.Domain.Implementations.Variants;

namespace Poker.Domain.Tests.Extensions;

[ExcludeFromCodeCoverage]
public class VariantExtensionsTests
{
    [Theory]
    [InlineData(0, 9)] // after ante: five dealt, plus up to four drawn
    [InlineData(1, 4)] // after deal: up to four drawn
    [InlineData(2, 4)] // after first betting interval: up to four drawn
    [InlineData(3, 0)] // after draw
    public void GetRemainingCardCount_FiveCardDraw_IncludesDrawMaximum(int lastPhaseNumber, int expected)
    {
        // Act
        var remaining = FiveCardDraw.GetVariant().GetRemainingCardCount(lastPhaseNumber);

        // Assert
        remaining.Should().Be(expected);
    }

    [Fact]
    public void GetRemainingCardCount_DrawWithoutOverrides_UsesBaseMaximum()
    {
        // Arrange
        var drawPhase = FiveCardDraw.GetVariant().Phases.Single(p => p.PhaseType == PhaseType.Draw) with
        {
            CardsToDrawMaximumOverrides = []
        };

        Variant variant = new() { Name = "Test", Phases = [drawPhase] };

        // Act
        var remaining = variant.GetRemainingCardCount(-1);

        // Assert
        remaining.Should().Be(3);
    }
}
