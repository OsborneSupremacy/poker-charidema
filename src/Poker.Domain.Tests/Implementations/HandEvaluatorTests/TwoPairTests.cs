namespace Poker.Domain.Tests.Implementations;

[ExcludeFromCodeCoverage]
public class TwoPairTests
{
    [Theory]
    [InlineData(2, 2)]
    [InlineData(2, 3)]
    [InlineData(3, 2)]  
    public void ThreesOverTwos_Qualifies_TwoPlusPresent(
        int threeCount,
        int twoCount
        )
    {
        // Arrange
        EvaluatedHandRequest request = new()
        {
            Cards = Cards.All
                .WhereRank(Ranks.Two)
                .Take(twoCount)
                .Concat(
                    Cards.All
                        .WhereRank(Ranks.Three)
                        .Take(threeCount)
                )
                .ToList(),
            HandsToEvaluate = new()
            {
                TwoPair.ThreesOverTwos
            },
            RemainingCardCount = 0
        };

        // Act
        var response = HandEvaluator.Evaluate(request);

        // Assert
        response.Single().HandQualification.Should().Be(HandQualifications.Qualifies);
    }

}
