using Poker.Domain.Implementations.Variants;

namespace Poker.Domain.Tests.Implementations.Variants;

[ExcludeFromCodeCoverage]
public class AllVariantsTests
{
    [Fact]
    public void All_ContainsEachPlayableVariant()
    {
        // Assert
        AllVariants.All.Select(v => v.Name).Should().BeEquivalentTo(
            FiveCardDraw.GetVariant().Name,
            SevenCardStud.GetVariant().Name,
            TexasHoldEm.GetVariant().Name
        );
    }

    [Fact]
    public void All_ExcludesEmptyVariant()
    {
        // Assert
        AllVariants.All.Should().NotContain(v => v.Name == EmptyVariant.GetVariant().Name);
    }
}
