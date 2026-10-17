using Poker.Domain.Implementations.Variants;

namespace Poker.Domain.Tests.Extensions;

[ExcludeFromCodeCoverage]
public class PhaseExtensionsTests
{
    private readonly Phase _drawPhase = FiveCardDraw.GetVariant().Phases
        .Single(p => p.PhaseType == PhaseType.Draw);

    [Fact]
    public void GetDrawMaximum_BaseMaximum_NoAceKept()
    {
        // Act
        var maximum = _drawPhase.GetDrawMaximum([Cards.KingOfSpades, Cards.TwoOfClubs]);

        // Assert
        maximum.Should().Be(3);
    }

    [Fact]
    public void GetDrawMaximum_OverrideMaximum_AceKept()
    {
        // Act
        var maximum = _drawPhase.GetDrawMaximum([Cards.AceOfHearts]);

        // Assert
        maximum.Should().Be(4);
    }

    [Fact]
    public void GetDrawMaximum_BaseMaximum_NothingKept()
    {
        // Act
        var maximum = _drawPhase.GetDrawMaximum([]);

        // Assert
        maximum.Should().Be(3);
    }
}
